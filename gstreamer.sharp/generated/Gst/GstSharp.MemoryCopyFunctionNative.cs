// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate IntPtr MemoryCopyFunctionNative(IntPtr mem, IntPtr offset, IntPtr size);

	internal class MemoryCopyFunctionInvoker {

		MemoryCopyFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~MemoryCopyFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal MemoryCopyFunctionInvoker (MemoryCopyFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal MemoryCopyFunctionInvoker (MemoryCopyFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal MemoryCopyFunctionInvoker (MemoryCopyFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.MemoryCopyFunction Handler {
			get {
				return new Gst.MemoryCopyFunction(InvokeNative);
			}
		}

		Gst.Memory InvokeNative (Gst.Memory mem, long offset, long size)
		{
			Gst.Memory __result = native_cb (mem == null ? IntPtr.Zero : mem.Handle, new IntPtr (offset), new IntPtr (size)) == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque (native_cb (mem == null ? IntPtr.Zero : mem.Handle, new IntPtr (offset), new IntPtr (size)), typeof (Gst.Memory), true);
			return __result;
		}
	}

	internal class MemoryCopyFunctionWrapper {

		public IntPtr NativeCallback (IntPtr mem, IntPtr offset, IntPtr size)
		{
			try {
				Gst.Memory __ret = managed (mem == IntPtr.Zero ? null : (Gst.Memory) GLib.Opaque.GetOpaque (mem, typeof (Gst.Memory), false), (long) offset, (long) size);
				if (release_on_call)
					gch.Free ();
				return __ret == null ? IntPtr.Zero : __ret.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal MemoryCopyFunctionNative NativeDelegate;
		Gst.MemoryCopyFunction managed;

		public MemoryCopyFunctionWrapper (Gst.MemoryCopyFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new MemoryCopyFunctionNative (NativeCallback);
		}

		public static Gst.MemoryCopyFunction GetManagedDelegate (MemoryCopyFunctionNative native)
		{
			if (native == null)
				return null;
			MemoryCopyFunctionWrapper wrapper = (MemoryCopyFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
