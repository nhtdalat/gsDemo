// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtsp {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class RTSPConnection : GLib.Opaque {

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_connection_clear_auth_params(IntPtr raw);

		public void ClearAuthParams() {
			gst_rtsp_connection_clear_auth_params(Handle);
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_close(IntPtr raw);

		public Gst.Rtsp.RTSPResult Close() {
			int raw_ret = gst_rtsp_connection_close(Handle);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_connect(IntPtr raw, IntPtr timeout);

		public Gst.Rtsp.RTSPResult Connect(IntPtr timeout) {
			int raw_ret = gst_rtsp_connection_connect(Handle, timeout);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_connect_with_response(IntPtr raw, IntPtr timeout, IntPtr response);

		public Gst.Rtsp.RTSPResult ConnectWithResponse(IntPtr timeout, Gst.Rtsp.RTSPMessage response) {
			IntPtr native_response = GLib.Marshaller.StructureToPtrAlloc (response);
			int raw_ret = gst_rtsp_connection_connect_with_response(Handle, timeout, native_response);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			Marshal.FreeHGlobal (native_response);
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_do_tunnel(IntPtr raw, IntPtr conn2);

		public Gst.Rtsp.RTSPResult DoTunnel(Gst.Rtsp.RTSPConnection conn2) {
			int raw_ret = gst_rtsp_connection_do_tunnel(Handle, conn2 == null ? IntPtr.Zero : conn2.Handle);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_flush(IntPtr raw, bool flush);

		public Gst.Rtsp.RTSPResult Flush(bool flush) {
			int raw_ret = gst_rtsp_connection_flush(Handle, flush);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_free(IntPtr raw);

		public Gst.Rtsp.RTSPResult Free() {
			int raw_ret = gst_rtsp_connection_free(Handle);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_connection_get_ip(IntPtr raw);

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_connection_set_ip(IntPtr raw, IntPtr ip);

		public string Ip { 
			get {
				IntPtr raw_ret = gst_rtsp_connection_get_ip(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gst_rtsp_connection_set_ip(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_connection_get_read_socket(IntPtr raw);

		public GLib.Socket ReadSocket { 
			get {
				IntPtr raw_ret = gst_rtsp_connection_get_read_socket(Handle);
				GLib.Socket ret = raw_ret == IntPtr.Zero ? null : (GLib.Socket) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.Socket), false);
				return ret;
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtsp_connection_get_remember_session_id(IntPtr raw);

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_connection_set_remember_session_id(IntPtr raw, bool remember);

		public bool RememberSessionId { 
			get {
				bool raw_ret = gst_rtsp_connection_get_remember_session_id(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gst_rtsp_connection_set_remember_session_id(Handle, value);
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_rtsp_connection_get_tls(IntPtr raw, out IntPtr error);

		public unsafe GLib.TlsConnection GetTls() {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_rtsp_connection_get_tls(Handle, out error);
			GLib.TlsConnection ret = GLib.Object.GetObject(raw_ret) as GLib.TlsConnection;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_connection_get_tls_database(IntPtr raw);

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_connection_set_tls_database(IntPtr raw, IntPtr database);

		public GLib.TlsDatabase TlsDatabase { 
			get {
				IntPtr raw_ret = gst_rtsp_connection_get_tls_database(Handle);
				GLib.TlsDatabase ret = GLib.Object.GetObject(raw_ret, true) as GLib.TlsDatabase;
				return ret;
			}
			set {
				gst_rtsp_connection_set_tls_database(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_connection_get_tls_interaction(IntPtr raw);

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_connection_set_tls_interaction(IntPtr raw, IntPtr interaction);

		public GLib.TlsInteraction TlsInteraction { 
			get {
				IntPtr raw_ret = gst_rtsp_connection_get_tls_interaction(Handle);
				GLib.TlsInteraction ret = GLib.Object.GetObject(raw_ret, true) as GLib.TlsInteraction;
				return ret;
			}
			set {
				gst_rtsp_connection_set_tls_interaction(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_get_tls_validation_flags(IntPtr raw);

		public GLib.TlsCertificateFlags TlsValidationFlags { 
			get {
				int raw_ret = gst_rtsp_connection_get_tls_validation_flags(Handle);
				GLib.TlsCertificateFlags ret = (GLib.TlsCertificateFlags) raw_ret;
				return ret;
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_connection_get_tunnelid(IntPtr raw);

		public string Tunnelid { 
			get {
				IntPtr raw_ret = gst_rtsp_connection_get_tunnelid(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_connection_get_url(IntPtr raw);

		public Gst.Rtsp.RTSPUrl Url { 
			get {
				IntPtr raw_ret = gst_rtsp_connection_get_url(Handle);
				Gst.Rtsp.RTSPUrl ret = Gst.Rtsp.RTSPUrl.New (raw_ret);
				return ret;
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_connection_get_write_socket(IntPtr raw);

		public GLib.Socket WriteSocket { 
			get {
				IntPtr raw_ret = gst_rtsp_connection_get_write_socket(Handle);
				GLib.Socket ret = raw_ret == IntPtr.Zero ? null : (GLib.Socket) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.Socket), false);
				return ret;
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtsp_connection_is_tunneled(IntPtr raw);

		public bool IsTunneled { 
			get {
				bool raw_ret = gst_rtsp_connection_is_tunneled(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_next_timeout(IntPtr raw, IntPtr timeout);

		public Gst.Rtsp.RTSPResult NextTimeout(IntPtr timeout) {
			int raw_ret = gst_rtsp_connection_next_timeout(Handle, timeout);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_poll(IntPtr raw, int events, int revents, IntPtr timeout);

		public Gst.Rtsp.RTSPResult Poll(Gst.Rtsp.RTSPEvent events, Gst.Rtsp.RTSPEvent revents, IntPtr timeout) {
			int raw_ret = gst_rtsp_connection_poll(Handle, (int) events, (int) revents, timeout);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_read(IntPtr raw, byte data, uint size, IntPtr timeout);

		public Gst.Rtsp.RTSPResult Read(byte data, uint size, IntPtr timeout) {
			int raw_ret = gst_rtsp_connection_read(Handle, data, size, timeout);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_receive(IntPtr raw, IntPtr message, IntPtr timeout);

		public Gst.Rtsp.RTSPResult Receive(Gst.Rtsp.RTSPMessage message, IntPtr timeout) {
			IntPtr native_message = GLib.Marshaller.StructureToPtrAlloc (message);
			int raw_ret = gst_rtsp_connection_receive(Handle, native_message, timeout);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			Marshal.FreeHGlobal (native_message);
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_reset_timeout(IntPtr raw);

		public Gst.Rtsp.RTSPResult ResetTimeout() {
			int raw_ret = gst_rtsp_connection_reset_timeout(Handle);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_send(IntPtr raw, IntPtr message, IntPtr timeout);

		public Gst.Rtsp.RTSPResult Send(Gst.Rtsp.RTSPMessage message, IntPtr timeout) {
			IntPtr native_message = GLib.Marshaller.StructureToPtrAlloc (message);
			int raw_ret = gst_rtsp_connection_send(Handle, native_message, timeout);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			Marshal.FreeHGlobal (native_message);
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_connection_set_accept_certificate_func(IntPtr raw, Gst.RtspSharp.RTSPConnectionAcceptCertificateFuncNative func, IntPtr user_data, GLib.DestroyNotify destroy_notify);

		public Gst.Rtsp.RTSPConnectionAcceptCertificateFunc AcceptCertificateFunc { 
			set {
				Gst.RtspSharp.RTSPConnectionAcceptCertificateFuncWrapper value_wrapper = new Gst.RtspSharp.RTSPConnectionAcceptCertificateFuncWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify destroy_notify;
				if (value == null) {
					user_data = IntPtr.Zero;
					destroy_notify = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy_notify = GLib.DestroyHelper.NotifyHandler;
				}
				gst_rtsp_connection_set_accept_certificate_func(Handle, value_wrapper.NativeDelegate, user_data, destroy_notify);
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_set_auth(IntPtr raw, int method, IntPtr user, IntPtr pass);

		public Gst.Rtsp.RTSPResult SetAuth(Gst.Rtsp.RTSPAuthMethod method, string user, string pass) {
			IntPtr native_user = GLib.Marshaller.StringToPtrGStrdup (user);
			IntPtr native_pass = GLib.Marshaller.StringToPtrGStrdup (pass);
			int raw_ret = gst_rtsp_connection_set_auth(Handle, (int) method, native_user, native_pass);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_user);
			GLib.Marshaller.Free (native_pass);
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_connection_set_auth_param(IntPtr raw, IntPtr param, IntPtr value);

		public void SetAuthParam(string param, string value) {
			IntPtr native_param = GLib.Marshaller.StringToPtrGStrdup (param);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			gst_rtsp_connection_set_auth_param(Handle, native_param, native_value);
			GLib.Marshaller.Free (native_param);
			GLib.Marshaller.Free (native_value);
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_connection_set_http_mode(IntPtr raw, bool enable);

		public bool HttpMode { 
			set {
				gst_rtsp_connection_set_http_mode(Handle, value);
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_set_proxy(IntPtr raw, IntPtr host, uint port);

		public Gst.Rtsp.RTSPResult SetProxy(string host, uint port) {
			IntPtr native_host = GLib.Marshaller.StringToPtrGStrdup (host);
			int raw_ret = gst_rtsp_connection_set_proxy(Handle, native_host, port);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_host);
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_set_qos_dscp(IntPtr raw, uint qos_dscp);

		public Gst.Rtsp.RTSPResult SetQosDscp(uint qos_dscp) {
			int raw_ret = gst_rtsp_connection_set_qos_dscp(Handle, qos_dscp);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_rtsp_connection_set_tls_validation_flags(IntPtr raw, int flags);

		public bool SetTlsValidationFlags(GLib.TlsCertificateFlags flags) {
			bool raw_ret = gst_rtsp_connection_set_tls_validation_flags(Handle, (int) flags);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_connection_set_tunneled(IntPtr raw, bool tunneled);

		public bool Tunneled { 
			set {
				gst_rtsp_connection_set_tunneled(Handle, value);
			}
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_write(IntPtr raw, byte data, uint size, IntPtr timeout);

		public Gst.Rtsp.RTSPResult Write(byte data, uint size, IntPtr timeout) {
			int raw_ret = gst_rtsp_connection_write(Handle, data, size, timeout);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_accept(IntPtr socket, out IntPtr conn, IntPtr cancellable);

		public static Gst.Rtsp.RTSPResult Accept(GLib.Socket socket, out Gst.Rtsp.RTSPConnection conn, GLib.Cancellable cancellable) {
			IntPtr native_conn;
			int raw_ret = gst_rtsp_connection_accept(socket == null ? IntPtr.Zero : socket.Handle, out native_conn, cancellable == null ? IntPtr.Zero : cancellable.Handle);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			conn = native_conn == IntPtr.Zero ? null : (Gst.Rtsp.RTSPConnection) GLib.Opaque.GetOpaque (native_conn, typeof (Gst.Rtsp.RTSPConnection), true);
			return ret;
		}

		public static Gst.Rtsp.RTSPResult Accept(GLib.Socket socket, out Gst.Rtsp.RTSPConnection conn) {
			return Accept (socket, out conn, null);
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_create(IntPtr url, out IntPtr conn);

		public static Gst.Rtsp.RTSPResult Create(Gst.Rtsp.RTSPUrl url, out Gst.Rtsp.RTSPConnection conn) {
			IntPtr native_url = GLib.Marshaller.StructureToPtrAlloc (url);
			IntPtr native_conn;
			int raw_ret = gst_rtsp_connection_create(native_url, out native_conn);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			Marshal.FreeHGlobal (native_url);
			conn = native_conn == IntPtr.Zero ? null : (Gst.Rtsp.RTSPConnection) GLib.Opaque.GetOpaque (native_conn, typeof (Gst.Rtsp.RTSPConnection), true);
			return ret;
		}

		[DllImport("libgstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_connection_create_from_socket(IntPtr socket, IntPtr ip, ushort port, IntPtr initial_buffer, out IntPtr conn);

		public static Gst.Rtsp.RTSPResult CreateFromSocket(GLib.Socket socket, string ip, ushort port, string initial_buffer, out Gst.Rtsp.RTSPConnection conn) {
			IntPtr native_ip = GLib.Marshaller.StringToPtrGStrdup (ip);
			IntPtr native_initial_buffer = GLib.Marshaller.StringToPtrGStrdup (initial_buffer);
			IntPtr native_conn;
			int raw_ret = gst_rtsp_connection_create_from_socket(socket == null ? IntPtr.Zero : socket.Handle, native_ip, port, native_initial_buffer, out native_conn);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			GLib.Marshaller.Free (native_ip);
			GLib.Marshaller.Free (native_initial_buffer);
			conn = native_conn == IntPtr.Zero ? null : (Gst.Rtsp.RTSPConnection) GLib.Opaque.GetOpaque (native_conn, typeof (Gst.Rtsp.RTSPConnection), true);
			return ret;
		}

		public RTSPConnection(IntPtr raw) : base(raw) {}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
