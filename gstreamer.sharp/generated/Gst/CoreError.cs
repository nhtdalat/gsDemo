// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.CoreErrorGType))]
	public enum CoreError {

		Failed = 1,
		TooLazy = 2,
		NotImplemented = 3,
		StateChange = 4,
		Pad = 5,
		Thread = 6,
		Negotiation = 7,
		Event = 8,
		Seek = 9,
		Caps = 10,
		Tag = 11,
		MissingPlugin = 12,
		Clock = 13,
		Disabled = 14,
		NumErrors = 15,
	}

	internal class CoreErrorGType {
		[DllImport ("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_core_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_core_error_get_type ());
			}
		}
	}
#endregion
}
