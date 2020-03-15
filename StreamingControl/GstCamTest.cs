#define YASC_DEBUG

using System;
using sysThread = System.Threading;
using sysDbg = System.Diagnostics.Debug;
using Gst;


namespace Yasc
{
    public class GstCamTest : IDisposable
    {

        protected Pipeline pipeline;
        private sysThread.Thread glibThread;
        static GLib.MainLoop glibLoop;
        Bin binSource,       // Either an RTSP or local (USB cam) or test source
            binDecode;       // Autoplugger bin to create decode path. 

        Pad padSrcBinSource, // Pad from source bin
            padTeeDisp,
            padOverlay0;

        // Source elements (RTSP). Use decodebin instead. 
        //Element mRtspSrc, mRtpDepay, mQueueDec, mDecode;

        private Element srcElt;

        // Display elements
        private Element mQueueDisp, mDispSink;

        // "Accessories"
        private Element mTee;
        public ulong HdlPreviewPanel { get; set; }

        /// <summary>
        /// For local cameras only, the index of the device. 
        /// </summary>
        public int DeviceIndex { get; set; }

        public GstCamTest()
        {
        }

        /// <summary>
        /// Start camera preview. 
        /// </summary>
        public void StartPreview()
        {
            if (!this.Connect())
                throw new YascStreamingException("Error connecting to camera.");

            StateChangeReturn ret;

            ret = pipeline.SetState(State.Playing);
            sysDbg.WriteLine("SetState playing: " + ret.ToString());

            if (ret == StateChangeReturn.Failure)
            {
                sysDbg.WriteLine("Error setting state to playing: " + ret);
                return;
            }
            else
            {
                sysDbg.WriteLine("Starting preview...");
            }
        }

        /// <summary>
        /// Stop the preview but don't disconnect or destroy the pipeline. 
        /// </summary>
        public void StopPreview()
        {
            try
            {
                var ret = pipeline.SetState(State.Null);
                if (ret != StateChangeReturn.Success)
                    sysDbg.WriteLine("Error setting state to null. ");
            }
            catch (Exception)
            {
                sysDbg.WriteLine("Error stopping preview.");
                throw;
            }
        }

        /// <summary>
        /// Initializes the Gstreamer pipeline and Glib loop. 
        /// </summary>
        /// <returns></returns>
        public bool Connect()
        {
            GstUtilities.DetectGstPath();
            bool r = false;

            glibLoop = new GLib.MainLoop();
            glibThread = new sysThread.Thread(glibLoop.Run) { IsBackground = true };

            if (pipeline == null)
                pipelineCreated = this.SetupPipeline();
            if (!pipelineCreated) sysDbg.WriteLine("Error creating pipeline.");
            StateChangeReturn ret = pipeline.SetState(State.Ready);

            r = pipelineCreated && (ret != StateChangeReturn.Failure);

            return r;
        }

        /// <summary>
        /// Setup the source bin. This method can be overridden by inheriting classes for different sources. 
        /// </summary>
        /// <returns>true on success</returns>
        protected virtual bool SetupSourceBin()
        {
            bool ret = true;
            CreateElements();

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

            //srcElt["location"] = "rtsp://admin:3@cameraxuanthuy.dyndns.org:30553/onvifStreaming?video=0&meta=0";
            srcElt["location"] = "rtsp://admin:3@localhost:8554/test";
            srcElt["drop-on-latency"] = true;
            srcElt["latency"] = 0;

            srcElt.PadAdded += cb_binSrcPadAdded;
            ret &= binSource.Add(srcElt);

            mTee = ElementFactory.Make("tee", "tee0");
            GstUtilities.CheckError(mTee);

            return ret;
        }

        /// <summary>
        /// Setup the pipeline, including starting the glib and gtk loops. Then, create and link the elements. 
        /// In hindsight: Doing a ParseLaunch would have been much easier. Then just get the elements needed with pipeline.GetChildByName (or a variant).
        /// //Parse.Launch($"rtspsrc location={this.ConnectionUri} latency={this.Latency} drop-on-latency=true ! decodebin ! textoverlay ! tee name=t0 ! queue ! videoconvert ! autovideosink name=vidsink"); 
        /// Not sure if this would take care of auto linking though - can't link until we start the pipeline and get rtsp data flowing. 
        /// </summary>
        /// <returns></returns>
        protected bool SetupPipeline()
        {
            sysDbg.WriteLine("Setting up pipeline...");

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

            // Create bins.
            try
            {
                pipeline = new Pipeline("pipeline0");
                binSource = new Bin("srcbin0");
                binDecode = (Bin)ElementFactory.Make("decodebin");
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

            pipeline.Add(binSource, binDecode);
            SetupSourceBin();

            try
            {
                // Add in the rendering elements. 
                pipeline.Add(mTee, mQueueDisp, mDispSink);

                var template = mTee.GetPadTemplate("src_%u");
                padTeeDisp = mTee.RequestPad(template);

                var ret = padTeeDisp.Link(mQueueDisp.GetStaticPad("sink"));
                if (ret != PadLinkReturn.Ok)
                    sysDbg.WriteLine("Error linking tee to queue: " + ret.ToString());

                // We have to link after a pad is created on the decode bin. 
                binDecode.PadAdded += cb_binDecPadAdded;

                // Link the last pad. 
                if (!mQueueDisp.Link(mDispSink))
                    sysDbg.WriteLine("Error linking display queue to display sink.");

            }
            catch (Exception ex)
            {
                sysDbg.WriteLine("Error linking: " + ex.Message);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Fired after data starts flowing through pipeline and stream type is detected. 
        /// </summary>
        /// <param name="o"></param>
        /// <param name="args"></param>
        private void cb_binDecPadAdded(object o, PadAddedArgs args)
        {
            sysDbg.WriteLine("Decode bin pad added.");

            var newPad = args.NewPad;

            if (newPad.IsLinked)
                return;

            Pad nextPad;

            if (padOverlay0 == null)
                nextPad = mTee?.GetStaticPad("sink");
            else
                nextPad = padOverlay0;

            if (nextPad.IsLinked)
            {
                if (!nextPad.Peer.Unlink(nextPad))
                    sysDbg.WriteLine("Failed to unlink.");
            }

            var ret = newPad.Link(nextPad);
            if (ret != PadLinkReturn.Ok)
                sysDbg.WriteLine("Error linking decode bin to tee: " + ret.ToString());
            // Add overlay elements. 
            padOverlay0 = nextPad;

        }

        /// <summary>
        /// Fired after pipeline enters paused state for rtspsrc, or other sources where the codec/type isn't known until playing. 
        /// Try to link to DecodeBin.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="args"></param>
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
        }

        /// <summary>
        /// Set the panel on which to display the video. This must be done at the right time and via this callback. 
        /// </summary>
        /// <param name="o"></param>
        /// <param name="args"></param>
        private void cb_busSyncMessage(object o, SyncMessageArgs args)
        {
            if (Gst.Video.Global.IsVideoOverlayPrepareWindowHandleMessage(args.Message))
            {
                Element src = (Gst.Element)args.Message.Src;
                sysDbg.WriteLine("Message'prepare-window-handle' received by: " + src.Name + " " + src.ToString());
                {
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

        /// <summary>
        /// Create the elements for rendering preview.
        /// </summary>
        /// <returns>true on success</returns>
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


        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        private bool pipelineCreated;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        #endregion
    }
}
