// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Query : Gst.MiniObject {

		public Gst.QueryType Type {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("type"));
					return (Gst.QueryType) (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("type"));
					*raw_ptr = (int) value;
				}
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_query_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_add_allocation_meta(IntPtr raw, IntPtr api, IntPtr parms);

		public void AddAllocationMeta(GLib.GType api, Gst.Structure parms) {
			gst_query_add_allocation_meta(Handle, api.Val, parms == null ? IntPtr.Zero : parms.Handle);
		}

		public void AddAllocationMeta(GLib.GType api) {
			AddAllocationMeta (api, null);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_add_allocation_param(IntPtr raw, IntPtr allocator, IntPtr parms);

		public void AddAllocationParam(Gst.Allocator allocator, Gst.AllocationParams parms) {
			IntPtr native_parms = GLib.Marshaller.StructureToPtrAlloc (parms);
			gst_query_add_allocation_param(Handle, allocator == null ? IntPtr.Zero : allocator.Handle, native_parms);
			Marshal.FreeHGlobal (native_parms);
		}

		public void AddAllocationParam() {
			AddAllocationParam (null, Gst.AllocationParams.Zero);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_add_allocation_pool(IntPtr raw, IntPtr pool, uint size, uint min_buffers, uint max_buffers);

		public void AddAllocationPool(Gst.BufferPool pool, uint size, uint min_buffers, uint max_buffers) {
			gst_query_add_allocation_pool(Handle, pool == null ? IntPtr.Zero : pool.Handle, size, min_buffers, max_buffers);
		}

		public void AddAllocationPool(uint size, uint min_buffers, uint max_buffers) {
			AddAllocationPool (null, size, min_buffers, max_buffers);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_query_add_buffering_range(IntPtr raw, long start, long stop);

		public bool AddBufferingRange(long start, long stop) {
			bool raw_ret = gst_query_add_buffering_range(Handle, start, stop);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_add_scheduling_mode(IntPtr raw, int mode);

		public void AddSchedulingMode(Gst.PadMode mode) {
			gst_query_add_scheduling_mode(Handle, (int) mode);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_query_find_allocation_meta(IntPtr raw, IntPtr api, out uint index);

		public bool FindAllocationMeta(GLib.GType api, out uint index) {
			bool raw_ret = gst_query_find_allocation_meta(Handle, api.Val, out index);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_query_get_n_allocation_metas(IntPtr raw);

		public uint NAllocationMetas { 
			get {
				uint raw_ret = gst_query_get_n_allocation_metas(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_query_get_n_allocation_params(IntPtr raw);

		public uint NAllocationParams { 
			get {
				uint raw_ret = gst_query_get_n_allocation_params(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_query_get_n_allocation_pools(IntPtr raw);

		public uint NAllocationPools { 
			get {
				uint raw_ret = gst_query_get_n_allocation_pools(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_query_get_n_buffering_ranges(IntPtr raw);

		public uint NBufferingRanges { 
			get {
				uint raw_ret = gst_query_get_n_buffering_ranges(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_query_get_n_scheduling_modes(IntPtr raw);

		public uint NSchedulingModes { 
			get {
				uint raw_ret = gst_query_get_n_scheduling_modes(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_get_structure(IntPtr raw);

		public Gst.Structure Structure { 
			get {
				IntPtr raw_ret = gst_query_get_structure(Handle);
				Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), false);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_query_has_scheduling_mode(IntPtr raw, int mode);

		public bool HasSchedulingMode(Gst.PadMode mode) {
			bool raw_ret = gst_query_has_scheduling_mode(Handle, (int) mode);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_query_has_scheduling_mode_with_flags(IntPtr raw, int mode, int flags);

		public bool HasSchedulingModeWithFlags(Gst.PadMode mode, Gst.SchedulingFlags flags) {
			bool raw_ret = gst_query_has_scheduling_mode_with_flags(Handle, (int) mode, (int) flags);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_accept_caps(IntPtr raw, out IntPtr caps);

		public Gst.Caps ParseAcceptCaps() {
			Gst.Caps caps;
			IntPtr native_caps;
			gst_query_parse_accept_caps(Handle, out native_caps);
			caps = native_caps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (native_caps, typeof (Gst.Caps), false);
			return caps;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_accept_caps_result(IntPtr raw, out bool _result);

		public bool ParseAcceptCapsResult() {
			bool _result;
			gst_query_parse_accept_caps_result(Handle, out _result);
			return _result;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_allocation(IntPtr raw, out IntPtr caps, out bool need_pool);

		public void ParseAllocation(out Gst.Caps caps, out bool need_pool) {
			IntPtr native_caps;
			gst_query_parse_allocation(Handle, out native_caps, out need_pool);
			caps = native_caps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (native_caps, typeof (Gst.Caps), false);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_buffering_percent(IntPtr raw, out bool busy, out int percent);

		public void ParseBufferingPercent(out bool busy, out int percent) {
			gst_query_parse_buffering_percent(Handle, out busy, out percent);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_buffering_range(IntPtr raw, out int format, out long start, out long stop, out long estimated_total);

		public void ParseBufferingRange(out Gst.Format format, out long start, out long stop, out long estimated_total) {
			int native_format;
			gst_query_parse_buffering_range(Handle, out native_format, out start, out stop, out estimated_total);
			format = (Gst.Format) native_format;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_buffering_stats(IntPtr raw, out int mode, out int avg_in, out int avg_out, out long buffering_left);

		public void ParseBufferingStats(out Gst.BufferingMode mode, out int avg_in, out int avg_out, out long buffering_left) {
			int native_mode;
			gst_query_parse_buffering_stats(Handle, out native_mode, out avg_in, out avg_out, out buffering_left);
			mode = (Gst.BufferingMode) native_mode;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_caps(IntPtr raw, out IntPtr filter);

		public Gst.Caps ParseCaps() {
			Gst.Caps filter;
			IntPtr native_filter;
			gst_query_parse_caps(Handle, out native_filter);
			filter = native_filter == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (native_filter, typeof (Gst.Caps), false);
			return filter;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_caps_result(IntPtr raw, out IntPtr caps);

		public Gst.Caps ParseCapsResult() {
			Gst.Caps caps;
			IntPtr native_caps;
			gst_query_parse_caps_result(Handle, out native_caps);
			caps = native_caps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (native_caps, typeof (Gst.Caps), false);
			return caps;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_context(IntPtr raw, IntPtr context);

		public Gst.Context ParseContext() {
			Gst.Context context;
			IntPtr native_context = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.Context)));
			gst_query_parse_context(Handle, native_context);
			context = Gst.Context.New (native_context);
			Marshal.FreeHGlobal (native_context);
			return context;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_query_parse_context_type(IntPtr raw, out IntPtr context_type);

		public bool ParseContextType(out string context_type) {
			IntPtr native_context_type;
			bool raw_ret = gst_query_parse_context_type(Handle, out native_context_type);
			bool ret = raw_ret;
			context_type = GLib.Marshaller.Utf8PtrToString (native_context_type);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_convert(IntPtr raw, out int src_format, out long src_value, out int dest_format, out long dest_value);

		public void ParseConvert(out Gst.Format src_format, out long src_value, out Gst.Format dest_format, out long dest_value) {
			int native_src_format;
			int native_dest_format;
			gst_query_parse_convert(Handle, out native_src_format, out src_value, out native_dest_format, out dest_value);
			src_format = (Gst.Format) native_src_format;
			dest_format = (Gst.Format) native_dest_format;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_duration(IntPtr raw, out int format, out long duration);

		public void ParseDuration(out Gst.Format format, out long duration) {
			int native_format;
			gst_query_parse_duration(Handle, out native_format, out duration);
			format = (Gst.Format) native_format;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_latency(IntPtr raw, out bool live, out ulong min_latency, out ulong max_latency);

		public void ParseLatency(out bool live, out ulong min_latency, out ulong max_latency) {
			gst_query_parse_latency(Handle, out live, out min_latency, out max_latency);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_n_formats(IntPtr raw, out uint n_formats);

		public uint ParseNFormats() {
			uint n_formats;
			gst_query_parse_n_formats(Handle, out n_formats);
			return n_formats;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_parse_nth_allocation_meta(IntPtr raw, uint index, out IntPtr parms);

		public GLib.GType ParseNthAllocationMeta(uint index, out Gst.Structure parms) {
			IntPtr native_parms;
			IntPtr raw_ret = gst_query_parse_nth_allocation_meta(Handle, index, out native_parms);
			GLib.GType ret = new GLib.GType(raw_ret);
			parms = native_parms == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (native_parms, typeof (Gst.Structure), false);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_nth_allocation_param(IntPtr raw, uint index, out IntPtr allocator, IntPtr parms);

		public void ParseNthAllocationParam(uint index, out Gst.Allocator allocator, out Gst.AllocationParams parms) {
			IntPtr native_allocator;
			IntPtr native_parms = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gst.AllocationParams)));
			gst_query_parse_nth_allocation_param(Handle, index, out native_allocator, native_parms);
			allocator = GLib.Object.GetObject(native_allocator, true) as Gst.Allocator;
			parms = Gst.AllocationParams.New (native_parms);
			Marshal.FreeHGlobal (native_parms);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_nth_allocation_pool(IntPtr raw, uint index, out IntPtr pool, out uint size, out uint min_buffers, out uint max_buffers);

		public void ParseNthAllocationPool(uint index, out Gst.BufferPool pool, out uint size, out uint min_buffers, out uint max_buffers) {
			IntPtr native_pool;
			gst_query_parse_nth_allocation_pool(Handle, index, out native_pool, out size, out min_buffers, out max_buffers);
			pool = GLib.Object.GetObject(native_pool, true) as Gst.BufferPool;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_query_parse_nth_buffering_range(IntPtr raw, uint index, out long start, out long stop);

		public bool ParseNthBufferingRange(uint index, out long start, out long stop) {
			bool raw_ret = gst_query_parse_nth_buffering_range(Handle, index, out start, out stop);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_nth_format(IntPtr raw, uint nth, out int format);

		public Gst.Format ParseNthFormat(uint nth) {
			Gst.Format format;
			int native_format;
			gst_query_parse_nth_format(Handle, nth, out native_format);
			format = (Gst.Format) native_format;
			return format;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_query_parse_nth_scheduling_mode(IntPtr raw, uint index);

		public Gst.PadMode ParseNthSchedulingMode(uint index) {
			int raw_ret = gst_query_parse_nth_scheduling_mode(Handle, index);
			Gst.PadMode ret = (Gst.PadMode) raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_position(IntPtr raw, out int format, out long cur);

		public void ParsePosition(out Gst.Format format, out long cur) {
			int native_format;
			gst_query_parse_position(Handle, out native_format, out cur);
			format = (Gst.Format) native_format;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_scheduling(IntPtr raw, out int flags, out int minsize, out int maxsize, out int align);

		public void ParseScheduling(out Gst.SchedulingFlags flags, out int minsize, out int maxsize, out int align) {
			int native_flags;
			gst_query_parse_scheduling(Handle, out native_flags, out minsize, out maxsize, out align);
			flags = (Gst.SchedulingFlags) native_flags;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_seeking(IntPtr raw, out int format, out bool seekable, out long segment_start, out long segment_end);

		public void ParseSeeking(out Gst.Format format, out bool seekable, out long segment_start, out long segment_end) {
			int native_format;
			gst_query_parse_seeking(Handle, out native_format, out seekable, out segment_start, out segment_end);
			format = (Gst.Format) native_format;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_segment(IntPtr raw, out double rate, out int format, out long start_value, out long stop_value);

		public void ParseSegment(out double rate, out Gst.Format format, out long start_value, out long stop_value) {
			int native_format;
			gst_query_parse_segment(Handle, out rate, out native_format, out start_value, out stop_value);
			format = (Gst.Format) native_format;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_uri(IntPtr raw, out IntPtr uri);

		public string ParseUri() {
			string uri;
			IntPtr native_uri;
			gst_query_parse_uri(Handle, out native_uri);
			uri = GLib.Marshaller.PtrToStringGFree(native_uri);
			return uri;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_uri_redirection(IntPtr raw, out IntPtr uri);

		public string ParseUriRedirection() {
			string uri;
			IntPtr native_uri;
			gst_query_parse_uri_redirection(Handle, out native_uri);
			uri = GLib.Marshaller.PtrToStringGFree(native_uri);
			return uri;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_parse_uri_redirection_permanent(IntPtr raw, out bool permanent);

		public bool ParseUriRedirectionPermanent() {
			bool permanent;
			gst_query_parse_uri_redirection_permanent(Handle, out permanent);
			return permanent;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_remove_nth_allocation_meta(IntPtr raw, uint index);

		public void RemoveNthAllocationMeta(uint index) {
			gst_query_remove_nth_allocation_meta(Handle, index);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_remove_nth_allocation_param(IntPtr raw, uint index);

		public void RemoveNthAllocationParam(uint index) {
			gst_query_remove_nth_allocation_param(Handle, index);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_remove_nth_allocation_pool(IntPtr raw, uint index);

		public void RemoveNthAllocationPool(uint index) {
			gst_query_remove_nth_allocation_pool(Handle, index);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_accept_caps_result(IntPtr raw, bool _result);

		public bool AcceptCapsResult { 
			set {
				gst_query_set_accept_caps_result(Handle, value);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_buffering_percent(IntPtr raw, bool busy, int percent);

		public void SetBufferingPercent(bool busy, int percent) {
			gst_query_set_buffering_percent(Handle, busy, percent);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_buffering_range(IntPtr raw, int format, long start, long stop, long estimated_total);

		public void SetBufferingRange(Gst.Format format, long start, long stop, long estimated_total) {
			gst_query_set_buffering_range(Handle, (int) format, start, stop, estimated_total);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_buffering_stats(IntPtr raw, int mode, int avg_in, int avg_out, long buffering_left);

		public void SetBufferingStats(Gst.BufferingMode mode, int avg_in, int avg_out, long buffering_left) {
			gst_query_set_buffering_stats(Handle, (int) mode, avg_in, avg_out, buffering_left);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_caps_result(IntPtr raw, IntPtr caps);

		public Gst.Caps CapsResult { 
			set {
				gst_query_set_caps_result(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_context(IntPtr raw, IntPtr value);

		public Gst.Context Context { 
			set {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gst_query_set_context(Handle, native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_convert(IntPtr raw, int src_format, long src_value, int dest_format, long dest_value);

		public void SetConvert(Gst.Format src_format, long src_value, Gst.Format dest_format, long dest_value) {
			gst_query_set_convert(Handle, (int) src_format, src_value, (int) dest_format, dest_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_duration(IntPtr raw, int format, long duration);

		public void SetDuration(Gst.Format format, long duration) {
			gst_query_set_duration(Handle, (int) format, duration);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_formatsv(IntPtr raw, int n_formats, int[] formats);

		public Gst.Format[] Formatsv { 
			set {
				int cnt_value = value == null ? 0 : value.Length;
				int[] native_value = new int [cnt_value];
				for (int i = 0; i < cnt_value; i++)
					native_value [i] = (int) value[i];
				gst_query_set_formatsv(Handle, (value == null ? 0 : value.Length), native_value);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_latency(IntPtr raw, bool live, ulong min_latency, ulong max_latency);

		public void SetLatency(bool live, ulong min_latency, ulong max_latency) {
			gst_query_set_latency(Handle, live, min_latency, max_latency);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_nth_allocation_param(IntPtr raw, uint index, IntPtr allocator, IntPtr parms);

		public void SetNthAllocationParam(uint index, Gst.Allocator allocator, Gst.AllocationParams parms) {
			IntPtr native_parms = GLib.Marshaller.StructureToPtrAlloc (parms);
			gst_query_set_nth_allocation_param(Handle, index, allocator == null ? IntPtr.Zero : allocator.Handle, native_parms);
			Marshal.FreeHGlobal (native_parms);
		}

		public void SetNthAllocationParam(uint index) {
			SetNthAllocationParam (index, null, Gst.AllocationParams.Zero);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_nth_allocation_pool(IntPtr raw, uint index, IntPtr pool, uint size, uint min_buffers, uint max_buffers);

		public void SetNthAllocationPool(uint index, Gst.BufferPool pool, uint size, uint min_buffers, uint max_buffers) {
			gst_query_set_nth_allocation_pool(Handle, index, pool == null ? IntPtr.Zero : pool.Handle, size, min_buffers, max_buffers);
		}

		public void SetNthAllocationPool(uint index, uint size, uint min_buffers, uint max_buffers) {
			SetNthAllocationPool (index, null, size, min_buffers, max_buffers);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_position(IntPtr raw, int format, long cur);

		public void SetPosition(Gst.Format format, long cur) {
			gst_query_set_position(Handle, (int) format, cur);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_scheduling(IntPtr raw, int flags, int minsize, int maxsize, int align);

		public void SetScheduling(Gst.SchedulingFlags flags, int minsize, int maxsize, int align) {
			gst_query_set_scheduling(Handle, (int) flags, minsize, maxsize, align);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_seeking(IntPtr raw, int format, bool seekable, long segment_start, long segment_end);

		public void SetSeeking(Gst.Format format, bool seekable, long segment_start, long segment_end) {
			gst_query_set_seeking(Handle, (int) format, seekable, segment_start, segment_end);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_segment(IntPtr raw, double rate, int format, long start_value, long stop_value);

		public void SetSegment(double rate, Gst.Format format, long start_value, long stop_value) {
			gst_query_set_segment(Handle, rate, (int) format, start_value, stop_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_uri(IntPtr raw, IntPtr uri);

		public string Uri { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gst_query_set_uri(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_uri_redirection(IntPtr raw, IntPtr uri);

		public string UriRedirection { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gst_query_set_uri_redirection(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_query_set_uri_redirection_permanent(IntPtr raw, bool permanent);

		public bool UriRedirectionPermanent { 
			set {
				gst_query_set_uri_redirection_permanent(Handle, value);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_writable_structure(IntPtr raw);

		public Gst.Structure WritableStructure() {
			IntPtr raw_ret = gst_query_writable_structure(Handle);
			Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), false);
			return ret;
		}

		public Query(IntPtr raw) : base(raw) {}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_accept_caps(IntPtr caps);

		public Query (Gst.Caps caps) 
		{
			Raw = gst_query_new_accept_caps(caps == null ? IntPtr.Zero : caps.Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_allocation(IntPtr caps, bool need_pool);

		public Query (Gst.Caps caps, bool need_pool) 
		{
			Raw = gst_query_new_allocation(caps == null ? IntPtr.Zero : caps.Handle, need_pool);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_buffering(int format);

		public Query (Gst.Format format) 
		{
			Raw = gst_query_new_buffering((int) format);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_caps(IntPtr filter);

		public static Query NewCaps(Gst.Caps filter)
		{
			Query result = new Query (gst_query_new_caps(filter == null ? IntPtr.Zero : filter.Handle));
			return result;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_context(IntPtr context_type);

		public Query (string context_type) 
		{
			IntPtr native_context_type = GLib.Marshaller.StringToPtrGStrdup (context_type);
			Raw = gst_query_new_context(native_context_type);
			GLib.Marshaller.Free (native_context_type);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_convert(int src_format, long value, int dest_format);

		public Query (Gst.Format src_format, long value, Gst.Format dest_format) 
		{
			Raw = gst_query_new_convert((int) src_format, value, (int) dest_format);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_custom(int type, IntPtr structure);

		public Query (Gst.QueryType type, Gst.Structure structure) 
		{
			structure.Owned = false;
			Raw = gst_query_new_custom((int) type, structure == null ? IntPtr.Zero : structure.Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_drain();

		public Query () 
		{
			Raw = gst_query_new_drain();
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_duration(int format);

		public static Query NewDuration(Gst.Format format)
		{
			Query result = new Query (gst_query_new_duration((int) format));
			return result;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_formats();

		public static Query NewFormats()
		{
			Query result = new Query (gst_query_new_formats());
			return result;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_latency();

		public static Query NewLatency()
		{
			Query result = new Query (gst_query_new_latency());
			return result;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_position(int format);

		public static Query NewPosition(Gst.Format format)
		{
			Query result = new Query (gst_query_new_position((int) format));
			return result;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_scheduling();

		public static Query NewScheduling()
		{
			Query result = new Query (gst_query_new_scheduling());
			return result;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_seeking(int format);

		public static Query NewSeeking(Gst.Format format)
		{
			Query result = new Query (gst_query_new_seeking((int) format));
			return result;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_segment(int format);

		public static Query NewSegment(Gst.Format format)
		{
			Query result = new Query (gst_query_new_segment((int) format));
			return result;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_query_new_uri();

		public static Query NewUri()
		{
			Query result = new Query (gst_query_new_uri());
			return result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("type"
							, Gst.MiniObject.abi_info.Fields
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.QueryType))) // type
							, null
							, null
							, (long) Marshal.OffsetOf(typeof(GstQuery_typeAlign), "type")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstQuery_typeAlign
		{
			sbyte f1;
			private Gst.QueryType type;
		}


		// End of the ABI representation.

#endregion
	}
}
