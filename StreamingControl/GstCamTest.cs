#define YASC_DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sysThread = System.Threading;
using sysDbg = System.Diagnostics.Debug;
using System.Threading.Tasks;
using static Yasc.GstEnums;
using Gst;
using System.Drawing;
using System.IO;
using Yasc;

namespace Yasc
{
    public class GstCamTest : IDisposable
    {

        /// <summary>
        /// A GstCam is the base class for a streaming camera. It can have any type of streaming source (USB, RTSP, MJPG, etc.) and any 
        /// type of recording branch. The rough outline of the pipeline is as follows: 
        /// 
        ///                                                   /--> queueDisp --> PreviewSink (autovideosink)
        /// SourceBIN --> decodeBin --> Overlay --> Tee _____/
        ///                                                  \ 
        ///                                                   \ [--> RecordBIN]
        ///                                     
        /// Easier said than done.
        /// </summary>
        /// 

        protected Pipeline pipeline;
        private sysThread.Thread glibThread;
        static GLib.MainLoop glibLoop;
        Bin binSource,       // Either an RTSP or local (USB cam) or test source
            binRecord,       // Bin to hold all the recording elements (to add/remove at once). 
            binDecode;       // Autoplugger bin to create decode path. 

        Pad padSrcBinSource; // Pad from source bin

        // Source elements (RTSP). Use decodebin instead. 
        //Element mRtspSrc, mRtpDepay, mQueueDec, mDecode;

        private Element srcElt;

       
        public ulong HdlPreviewPanel { get; set; }

        // Display elements
        private Element mQueueDisp, mDispSink;

        // "Accessories"
        private Element  mTee;


        public GstCamTest()
        {
            
        }



        public bool SetupPipeline()
        {
            // Init GStreamer and GLib.
            try
            {
                if (!Gst.Application.InitCheck())
                    Gst.Application.Init();
                GtkSharp.GstreamerSharp.ObjectManager.Initialize();
            }
            catch (Exception ex)
            {
                sysDbg.WriteLine("Error initing gst applicaiton: " + ex.Message);
            }

            if (glibThread.ThreadState != sysThread.ThreadState.Running)
            {
                glibThread.Start();
                sysDbg.WriteLine("glib thread started.");
            }

            try
            {
                pipeline = new Pipeline("pipeline0");
                GstUtilities.CheckError(pipeline);
                binSource = new Bin("srcbin0");
                GstUtilities.CheckError(binSource);
                binRecord = new Bin("recordbin0");
                GstUtilities.CheckError(binRecord);
                binDecode = (Bin)ElementFactory.Make("decodebin");
                GstUtilities.CheckError(binDecode);
            }
            catch (Exception ex)
            {
                sysDbg.WriteLine("failed creating bins: " + ex.Message);
                return false;
            }

            // Listen for messages. 
            var bus = pipeline.Bus;
            if (bus != null)
            {
                bus.AddSignalWatch();
                // Need sync message for binding the rendering window to a panel. 
                bus.EnableSyncMessageEmission();
                bus.SyncMessage += cb_busSyncMessage;
                bus.AddSignalWatch();
            }
            else
                throw new YascElementNullException("Bus is null. Failed to setup pipeline.");

            if (binSource != null && binDecode != null)
                pipeline.Add(binSource, binDecode);


            SetupSourceBin();


            return true;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private void cb_busSyncMessage(object o, SyncMessageArgs args)
        {

            if (Gst.Video.Global.IsVideoOverlayPrepareWindowHandleMessage(args.Message))
            {
                Element src = (Gst.Element)args.Message.Src;

                sysDbg.WriteLine("Message'prepare-window-handle' received by: " + src.Name + " " + src.ToString());

                //if (src != null && (src is Gst.Video.VideoSink | src is Gst.Bin))
                {
                    //    Try to set Aspect Ratio
                    try
                    {
                        src["force-aspect-ratio"] = true;

                    }
                    catch (PropertyNotFoundException ex)
                    {
                        sysDbg.WriteLine("Error setting aspect ratio: " + ex.Message);
                    }

                    //    Try to set Overlay
                    try
                    {
                        Gst.Video.VideoOverlayAdapter overlay_ = new Gst.Video.VideoOverlayAdapter(src.Handle);
                        overlay_.WindowHandle = (IntPtr)HdlPreviewPanel;
                        overlay_.HandleEvents(true);
                    }
                    catch (Exception ex)
                    {
                        sysDbg.WriteLine("Error setting overlay: " + ex.Message);
                    }
                }
            }
            if (args.Message.Type == MessageType.Eos)
            {
                sysDbg.WriteLine("EOS sync message received...");
            }
        }

        protected virtual bool SetupSourceBin()
        {
            bool ret = true;

            if (pipeline == null)
                return false;

            if (pipeline.CurrentState == State.Playing)
                return false;

            if (!CreateElements())
                return false;

            // Empty the bin to start fresh. 
            foreach (Element e in binSource.IterateElements())
            {
                binSource.Remove(e);
                e.Dispose();
                e.Unref();
            }

            if (padSrcBinSource != null)
            {
                padSrcBinSource.Unlink(binDecode.GetStaticPad("sink"));
                padSrcBinSource = null;
            }




            sysDbg.WriteLine("Creating rtsp source.");
            srcElt = ElementFactory.Make("rtspsrc", "rtspsrc");
            if (srcElt == null) throw new YascElementNullException("failed to create rtspsrc.");

            srcElt["location"] = "rtsp://admin:3@localhost:8554/test";
            srcElt["drop-on-latency"] = true;
            srcElt["latency"] = 0;

            srcElt.PadAdded += cb_binSrcPadAdded;
            ret &= binSource.Add(srcElt);

            mTee = ElementFactory.Make("tee", "tee0");
            GstUtilities.CheckError(mTee);

            return ret;
        }

        protected bool CreateElements()
        {
            sysDbg.WriteLine("Creating elements...");

            try
            {
                if (mDispSink == null)
                    mDispSink = ElementFactory.Make("autovideosink", "videosink0");
                GstUtilities.CheckError(mDispSink);

                mDispSink["sync"] = false;

                if (mQueueDisp == null)
                    mQueueDisp = ElementFactory.Make("queue", "qDisp");
                GstUtilities.CheckError(mQueueDisp);

                if (mTee == null)
                    mTee = ElementFactory.Make("tee", "tee0");
                GstUtilities.CheckError(mTee);
            }
            catch (Exception ex)
            {
                sysDbg.WriteLine("Error creating elements: " + ex.Message);
                return false;
            }

            return true;
        }

        private void cb_binSrcPadAdded(object o, PadAddedArgs args)
        {
            var src = (Element)o;
            var newPad = args.NewPad;
            try
            {

                if (padSrcBinSource != null)
                {
                    if (!padSrcBinSource.Unlink(binDecode.GetStaticPad("sink")))
                        sysDbg.WriteLine("Failed to unlink decode bin.");
                    if (!binSource.RemovePad(padSrcBinSource))
                        sysDbg.WriteLine("failed to remove existing source pad.");
                    padSrcBinSource.Unref();
                }

                padSrcBinSource = new GhostPad("srcPad", newPad);
                binSource.AddPad(padSrcBinSource);
            }
            catch (Exception ex)
            {
                sysDbg.WriteLine("Failed adding a pad: " + ex.Message);
            }

            if (!padSrcBinSource.IsLinked)
            {
                Pad bindecpad = binDecode.GetStaticPad("sink");
                var ret = padSrcBinSource.Link(binDecode.GetStaticPad("sink"));
                if (ret != PadLinkReturn.Ok)
                    sysDbg.WriteLine("Error linking to decbin " + ret.ToString());
            }
            DumpPipeline("afterRtspLink");
        }


        public void DumpPipeline(string path)
        {
            GstUtilities.DumpGraph(this.pipeline, path);
        }


        public void StartPreview()
        {
            this.Connect();
            StateChangeReturn ret;

            ret = pipeline.SetState(State.Playing);
            sysDbg.WriteLine("SetState playing: " + ret.ToString());

            GstUtilities.DumpGraph(pipeline, "startPreview");

        }


        private bool pipelineCreated;
       
        public bool Connect()
        {
            GstUtilities.DetectGstPath();

            bool r = false;

            if (glibLoop == null)
            {
                glibLoop = new GLib.MainLoop();
                glibThread = new sysThread.Thread(glibLoop.Run) { IsBackground = true };
            }

            try
            {
                if (pipeline == null)
                    pipelineCreated = this.SetupPipeline();


                if (!pipelineCreated) sysDbg.WriteLine("Error creating pipeline.");


                StateChangeReturn ret = pipeline.SetState(State.Ready);

                r = pipelineCreated && (ret != StateChangeReturn.Failure);
            }
            catch (Exception ex)
            {
                sysDbg.WriteLine("Error connecting: " + ex.Message);
                throw new YascStreamingException("Error initializing pipeline. ");
            }

            return r;
        }

    }
}
