// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Controller {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.Controller.LFOWaveformGType))]
	public enum LFOWaveform {

		Sine = 0,
		Square = 1,
		Saw = 2,
		ReverseSaw = 3,
		Triangle = 4,
	}

	internal class LFOWaveformGType {
		[DllImport ("libgstcontroller-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_lfo_waveform_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_lfo_waveform_get_type ());
			}
		}
	}
#endregion
}
