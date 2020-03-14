// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.PbUtils {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AudioVisualizer : Gst.Element {

		protected AudioVisualizer (IntPtr raw) : base(raw) {}

		protected AudioVisualizer() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("shade-amount")]
		public uint ShadeAmount {
			get {
				GLib.Value val = GetProperty ("shade-amount");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("shade-amount", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("shader")]
		public Gst.PbUtils.AudioVisualizerShader Shader {
			get {
				GLib.Value val = GetProperty ("shader");
				Gst.PbUtils.AudioVisualizerShader ret = (Gst.PbUtils.AudioVisualizerShader) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("shader", val);
				val.Dispose ();
			}
		}

		public uint ReqSpf {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("req_spf"));
					return (*raw_ptr);
				}
			}
		}

		public Gst.Video.VideoInfo Vinfo {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("vinfo"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Video.VideoInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Video.VideoInfo), false);
				}
			}
		}

		public Gst.Audio.AudioInfo Ainfo {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("ainfo"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Audio.AudioInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Audio.AudioInfo), false);
				}
			}
		}

		static SetupNativeDelegate Setup_cb_delegate;
		static SetupNativeDelegate SetupVMCallback {
			get {
				if (Setup_cb_delegate == null)
					Setup_cb_delegate = new SetupNativeDelegate (Setup_cb);
				return Setup_cb_delegate;
			}
		}

		static void OverrideSetup (GLib.GType gtype)
		{
			OverrideSetup (gtype, SetupVMCallback);
		}

		static void OverrideSetup (GLib.GType gtype, SetupNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("setup"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetupNativeDelegate (IntPtr inst);

		static bool Setup_cb (IntPtr inst)
		{
			try {
				AudioVisualizer __obj = GLib.Object.GetObject (inst, false) as AudioVisualizer;
				bool __result;
				__result = __obj.OnSetup ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.PbUtils.AudioVisualizer), ConnectionMethod="OverrideSetup")]
		protected virtual bool OnSetup ()
		{
			return InternalSetup ();
		}

		private bool InternalSetup ()
		{
			SetupNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("setup"));
				unmanaged = (SetupNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SetupNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static RenderNativeDelegate Render_cb_delegate;
		static RenderNativeDelegate RenderVMCallback {
			get {
				if (Render_cb_delegate == null)
					Render_cb_delegate = new RenderNativeDelegate (Render_cb);
				return Render_cb_delegate;
			}
		}

		static void OverrideRender (GLib.GType gtype)
		{
			OverrideRender (gtype, RenderVMCallback);
		}

		static void OverrideRender (GLib.GType gtype, RenderNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("render"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool RenderNativeDelegate (IntPtr inst, IntPtr audio, IntPtr video);

		static bool Render_cb (IntPtr inst, IntPtr audio, IntPtr video)
		{
			try {
				AudioVisualizer __obj = GLib.Object.GetObject (inst, false) as AudioVisualizer;
				bool __result;
				__result = __obj.OnRender (audio == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (audio, typeof (Gst.Buffer), false), Gst.Video.VideoFrame.New (video));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.PbUtils.AudioVisualizer), ConnectionMethod="OverrideRender")]
		protected virtual bool OnRender (Gst.Buffer audio, Gst.Video.VideoFrame video)
		{
			return InternalRender (audio, video);
		}

		private bool InternalRender (Gst.Buffer audio, Gst.Video.VideoFrame video)
		{
			RenderNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("render"));
				unmanaged = (RenderNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(RenderNativeDelegate));
			}
			if (unmanaged == null) return false;

			IntPtr native_video = GLib.Marshaller.StructureToPtrAlloc (video);
			bool __result = unmanaged (this.Handle, audio == null ? IntPtr.Zero : audio.Handle, native_video);
			Marshal.FreeHGlobal (native_video);
			return __result;
		}

		static DecideAllocationNativeDelegate DecideAllocation_cb_delegate;
		static DecideAllocationNativeDelegate DecideAllocationVMCallback {
			get {
				if (DecideAllocation_cb_delegate == null)
					DecideAllocation_cb_delegate = new DecideAllocationNativeDelegate (DecideAllocation_cb);
				return DecideAllocation_cb_delegate;
			}
		}

		static void OverrideDecideAllocation (GLib.GType gtype)
		{
			OverrideDecideAllocation (gtype, DecideAllocationVMCallback);
		}

		static void OverrideDecideAllocation (GLib.GType gtype, DecideAllocationNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("decide_allocation"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool DecideAllocationNativeDelegate (IntPtr inst, IntPtr query);

		static bool DecideAllocation_cb (IntPtr inst, IntPtr query)
		{
			try {
				AudioVisualizer __obj = GLib.Object.GetObject (inst, false) as AudioVisualizer;
				bool __result;
				__result = __obj.OnDecideAllocation (query == IntPtr.Zero ? null : (Gst.Query) GLib.Opaque.GetOpaque (query, typeof (Gst.Query), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.PbUtils.AudioVisualizer), ConnectionMethod="OverrideDecideAllocation")]
		protected virtual bool OnDecideAllocation (Gst.Query query)
		{
			return InternalDecideAllocation (query);
		}

		private bool InternalDecideAllocation (Gst.Query query)
		{
			DecideAllocationNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("decide_allocation"));
				unmanaged = (DecideAllocationNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(DecideAllocationNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, query == null ? IntPtr.Zero : query.Handle);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("setup"
							, Gst.Element.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // setup
							, null
							, "render"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("render"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // render
							, "setup"
							, "decide_allocation"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("decide_allocation"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // decide_allocation
							, "render"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_visualizer_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_audio_visualizer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static AudioVisualizer ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("req_spf"
							, Gst.Element.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(uint)) // req_spf
							, null
							, "vinfo"
							, (long) Marshal.OffsetOf(typeof(GstAudioVisualizer_req_spfAlign), "req_spf")
							, 0
							),
						new GLib.AbiField("vinfo"
							, -1
							, Gst.Video.VideoInfo.abi_info.Size // vinfo
							, "req_spf"
							, "ainfo"
							, Gst.Video.VideoInfo.abi_info.Align
							, 0
							),
						new GLib.AbiField("ainfo"
							, -1
							, Gst.Audio.AudioInfo.abi_info.Size // ainfo
							, "vinfo"
							, "priv"
							, Gst.Audio.AudioInfo.abi_info.Align
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "ainfo"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstAudioVisualizer_req_spfAlign
		{
			sbyte f1;
			private uint req_spf;
		}


		// End of the ABI representation.

#endregion
	}
}
