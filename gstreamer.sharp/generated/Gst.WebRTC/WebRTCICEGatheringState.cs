// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.WebRTC.WebRTCICEGatheringStateGType))]
	public enum WebRTCICEGatheringState {

		New = 0,
		Gathering = 1,
		Complete = 2,
	}

	internal class WebRTCICEGatheringStateGType {
		[DllImport ("libgstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_ice_gathering_state_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_webrtc_ice_gathering_state_get_type ());
			}
		}
	}
#endregion
}
