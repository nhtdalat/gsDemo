// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AudioCdSrc : Gst.Base.PushSrc, Gst.IURIHandler {

		public AudioCdSrc (IntPtr raw) : base(raw) {}

		protected AudioCdSrc() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("device")]
		public string Device {
			get {
				GLib.Value val = GetProperty ("device");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("device", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("mode")]
		public Gst.Audio.AudioCdSrcMode Mode {
			get {
				GLib.Value val = GetProperty ("mode");
				Gst.Audio.AudioCdSrcMode ret = (Gst.Audio.AudioCdSrcMode) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("mode", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("track")]
		public uint Track {
			get {
				GLib.Value val = GetProperty ("track");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("track", val);
				val.Dispose ();
			}
		}

		public Gst.TagList Tags {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("tags"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.TagList) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.TagList), false);
				}
			}
		}

		static OpenNativeDelegate Open_cb_delegate;
		static OpenNativeDelegate OpenVMCallback {
			get {
				if (Open_cb_delegate == null)
					Open_cb_delegate = new OpenNativeDelegate (Open_cb);
				return Open_cb_delegate;
			}
		}

		static void OverrideOpen (GLib.GType gtype)
		{
			OverrideOpen (gtype, OpenVMCallback);
		}

		static void OverrideOpen (GLib.GType gtype, OpenNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("open"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool OpenNativeDelegate (IntPtr inst, IntPtr device);

		static bool Open_cb (IntPtr inst, IntPtr device)
		{
			try {
				AudioCdSrc __obj = GLib.Object.GetObject (inst, false) as AudioCdSrc;
				bool __result;
				__result = __obj.OnOpen (GLib.Marshaller.Utf8PtrToString (device));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Audio.AudioCdSrc), ConnectionMethod="OverrideOpen")]
		protected virtual bool OnOpen (string device)
		{
			return InternalOpen (device);
		}

		private bool InternalOpen (string device)
		{
			OpenNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("open"));
				unmanaged = (OpenNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(OpenNativeDelegate));
			}
			if (unmanaged == null) return false;

			IntPtr native_device = GLib.Marshaller.StringToPtrGStrdup (device);
			bool __result = unmanaged (this.Handle, native_device);
			GLib.Marshaller.Free (native_device);
			return __result;
		}

		static CloseNativeDelegate Close_cb_delegate;
		static CloseNativeDelegate CloseVMCallback {
			get {
				if (Close_cb_delegate == null)
					Close_cb_delegate = new CloseNativeDelegate (Close_cb);
				return Close_cb_delegate;
			}
		}

		static void OverrideClose (GLib.GType gtype)
		{
			OverrideClose (gtype, CloseVMCallback);
		}

		static void OverrideClose (GLib.GType gtype, CloseNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("close"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CloseNativeDelegate (IntPtr inst);

		static void Close_cb (IntPtr inst)
		{
			try {
				AudioCdSrc __obj = GLib.Object.GetObject (inst, false) as AudioCdSrc;
				__obj.OnClose ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Audio.AudioCdSrc), ConnectionMethod="OverrideClose")]
		protected virtual void OnClose ()
		{
			InternalClose ();
		}

		private void InternalClose ()
		{
			CloseNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("close"));
				unmanaged = (CloseNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CloseNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ReadSectorNativeDelegate ReadSector_cb_delegate;
		static ReadSectorNativeDelegate ReadSectorVMCallback {
			get {
				if (ReadSector_cb_delegate == null)
					ReadSector_cb_delegate = new ReadSectorNativeDelegate (ReadSector_cb);
				return ReadSector_cb_delegate;
			}
		}

		static void OverrideReadSector (GLib.GType gtype)
		{
			OverrideReadSector (gtype, ReadSectorVMCallback);
		}

		static void OverrideReadSector (GLib.GType gtype, ReadSectorNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("read_sector"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr ReadSectorNativeDelegate (IntPtr inst, int sector);

		static IntPtr ReadSector_cb (IntPtr inst, int sector)
		{
			try {
				AudioCdSrc __obj = GLib.Object.GetObject (inst, false) as AudioCdSrc;
				Gst.Buffer __result;
				__result = __obj.OnReadSector (sector);
				return __result == null ? IntPtr.Zero : __result.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Audio.AudioCdSrc), ConnectionMethod="OverrideReadSector")]
		protected virtual Gst.Buffer OnReadSector (int sector)
		{
			return InternalReadSector (sector);
		}

		private Gst.Buffer InternalReadSector (int sector)
		{
			ReadSectorNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("read_sector"));
				unmanaged = (ReadSectorNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ReadSectorNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, sector);
			return __result == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (__result, typeof (Gst.Buffer), true);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("open"
							, Gst.Base.PushSrc.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // open
							, null
							, "close"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("close"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // close
							, "open"
							, "read_sector"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("read_sector"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // read_sector
							, "close"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 20 // _gst_reserved
							, "read_sector"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_cd_src_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_audio_cd_src_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_audio_cd_src_add_track(IntPtr raw, IntPtr track);

		public bool AddTrack(Gst.Audio.AudioCdSrcTrack track) {
			IntPtr native_track = GLib.Marshaller.StructureToPtrAlloc (track);
			bool raw_ret = gst_audio_cd_src_add_track(Handle, native_track);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_track);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_uri_handler_get_uri(IntPtr raw);

		public string Uri { 
			get {
				IntPtr raw_ret = gst_uri_handler_get_uri(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_uri_handler_get_uri_type(IntPtr raw);

		public Gst.URIType UriType { 
			get {
				int raw_ret = gst_uri_handler_get_uri_type(Handle);
				Gst.URIType ret = (Gst.URIType) raw_ret;
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_uri_handler_set_uri(IntPtr raw, IntPtr uri, out IntPtr error);

		public bool SetUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_uri_handler_set_uri(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}


		static AudioCdSrc ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("tags"
							, Gst.Base.PushSrc.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // tags
							, null
							, "priv"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "tags"
							, "_gst_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) * 2 // _gst_reserved1
							, "priv"
							, "_gst_reserved2"
							, (long) Marshal.OffsetOf(typeof(GstAudioCdSrc__gst_reserved1Align), "_gst_reserved1")
							, 0
							),
						new GLib.AbiField("_gst_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 2 // _gst_reserved2
							, "_gst_reserved1"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstAudioCdSrc__gst_reserved1Align
		{
			sbyte f1;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=2)]
			private uint[] _gst_reserved1;
		}


		// End of the ABI representation.

#endregion
	}
}
