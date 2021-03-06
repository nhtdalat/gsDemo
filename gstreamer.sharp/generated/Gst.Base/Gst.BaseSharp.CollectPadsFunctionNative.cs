// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.BaseSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate int CollectPadsFunctionNative(IntPtr pads, IntPtr user_data);

	internal class CollectPadsFunctionInvoker {

		CollectPadsFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~CollectPadsFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal CollectPadsFunctionInvoker (CollectPadsFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal CollectPadsFunctionInvoker (CollectPadsFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal CollectPadsFunctionInvoker (CollectPadsFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.Base.CollectPadsFunction Handler {
			get {
				return new Gst.Base.CollectPadsFunction(InvokeNative);
			}
		}

		Gst.FlowReturn InvokeNative (Gst.Base.CollectPads pads)
		{
			Gst.FlowReturn __result = (Gst.FlowReturn) native_cb (pads == null ? IntPtr.Zero : pads.Handle, __data);
			return __result;
		}
	}

	internal class CollectPadsFunctionWrapper {

		public int NativeCallback (IntPtr pads, IntPtr user_data)
		{
			try {
				Gst.FlowReturn __ret = managed (GLib.Object.GetObject(pads) as Gst.Base.CollectPads);
				if (release_on_call)
					gch.Free ();
				return (int) __ret;
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

		internal CollectPadsFunctionNative NativeDelegate;
		Gst.Base.CollectPadsFunction managed;

		public CollectPadsFunctionWrapper (Gst.Base.CollectPadsFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new CollectPadsFunctionNative (NativeCallback);
		}

		public static Gst.Base.CollectPadsFunction GetManagedDelegate (CollectPadsFunctionNative native)
		{
			if (native == null)
				return null;
			CollectPadsFunctionWrapper wrapper = (CollectPadsFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
