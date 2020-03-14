// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Iterator : GLib.Opaque, IEnumerable {

		public Gst.IteratorCopyFunction CopyFunc {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("copy"));
					 GstSharp.IteratorCopyFunctionNative del = (GstSharp.IteratorCopyFunctionNative)Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GstSharp.IteratorCopyFunctionNative));
					return GstSharp.IteratorCopyFunctionWrapper.GetManagedDelegate ((del));
				}
			}
			set {
				unsafe {
					GstSharp.IteratorCopyFunctionWrapper wrapper = new GstSharp.IteratorCopyFunctionWrapper (value);
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("copy"));
					*raw_ptr = Marshal.GetFunctionPointerForDelegate (wrapper.NativeDelegate);
				}
			}
		}

		public Gst.IteratorNextFunction NextFunc {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("next"));
					 GstSharp.IteratorNextFunctionNative del = (GstSharp.IteratorNextFunctionNative)Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GstSharp.IteratorNextFunctionNative));
					return GstSharp.IteratorNextFunctionWrapper.GetManagedDelegate ((del));
				}
			}
			set {
				unsafe {
					GstSharp.IteratorNextFunctionWrapper wrapper = new GstSharp.IteratorNextFunctionWrapper (value);
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("next"));
					*raw_ptr = Marshal.GetFunctionPointerForDelegate (wrapper.NativeDelegate);
				}
			}
		}

		public Gst.IteratorItemFunction Item {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("item"));
					 GstSharp.IteratorItemFunctionNative del = (GstSharp.IteratorItemFunctionNative)Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GstSharp.IteratorItemFunctionNative));
					return GstSharp.IteratorItemFunctionWrapper.GetManagedDelegate ((del));
				}
			}
			set {
				unsafe {
					GstSharp.IteratorItemFunctionWrapper wrapper = new GstSharp.IteratorItemFunctionWrapper (value);
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("item"));
					*raw_ptr = Marshal.GetFunctionPointerForDelegate (wrapper.NativeDelegate);
				}
			}
		}

		public Gst.IteratorResyncFunction ResyncFunc {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("resync"));
					 GstSharp.IteratorResyncFunctionNative del = (GstSharp.IteratorResyncFunctionNative)Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GstSharp.IteratorResyncFunctionNative));
					return GstSharp.IteratorResyncFunctionWrapper.GetManagedDelegate ((del));
				}
			}
			set {
				unsafe {
					GstSharp.IteratorResyncFunctionWrapper wrapper = new GstSharp.IteratorResyncFunctionWrapper (value);
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("resync"));
					*raw_ptr = Marshal.GetFunctionPointerForDelegate (wrapper.NativeDelegate);
				}
			}
		}

		public Gst.IteratorFreeFunction FreeFunc {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("free"));
					 GstSharp.IteratorFreeFunctionNative del = (GstSharp.IteratorFreeFunctionNative)Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GstSharp.IteratorFreeFunctionNative));
					return GstSharp.IteratorFreeFunctionWrapper.GetManagedDelegate ((del));
				}
			}
			set {
				unsafe {
					GstSharp.IteratorFreeFunctionWrapper wrapper = new GstSharp.IteratorFreeFunctionWrapper (value);
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("free"));
					*raw_ptr = Marshal.GetFunctionPointerForDelegate (wrapper.NativeDelegate);
				}
			}
		}

		public Gst.Iterator Pushed {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("pushed"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Iterator) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Iterator), false);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("pushed"));
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		public GLib.GType Type {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("type"));
					return new GLib.GType((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("type"));
					*raw_ptr = value.Val;
				}
			}
		}

		public GLib.Mutex Lock {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("lock"));
					return new GLib.Mutex((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("lock"));
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		public uint Cookie {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("cookie"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("cookie"));
					*raw_ptr = value;
				}
			}
		}

		public uint MasterCookie {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("master_cookie"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("master_cookie"));
					*raw_ptr = value;
				}
			}
		}

		public uint Size {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("size"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("size"));
					*raw_ptr = value;
				}
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_iterator_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_iterator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_iterator_copy(IntPtr raw);

		public Gst.Iterator Copy() {
			IntPtr raw_ret = gst_iterator_copy(Handle);
			Gst.Iterator ret = raw_ret == IntPtr.Zero ? null : (Gst.Iterator) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Iterator), true);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_iterator_fold(IntPtr raw, GstSharp.IteratorFoldFunctionNative func, IntPtr _ret, IntPtr user_data);

		public Gst.IteratorResult Fold(Gst.IteratorFoldFunction func, GLib.Value _ret) {
			GstSharp.IteratorFoldFunctionWrapper func_wrapper = new GstSharp.IteratorFoldFunctionWrapper (func);
			IntPtr native__ret = GLib.Marshaller.StructureToPtrAlloc (_ret);
			int raw_ret = gst_iterator_fold(Handle, func_wrapper.NativeDelegate, native__ret, IntPtr.Zero);
			Gst.IteratorResult ret = (Gst.IteratorResult) raw_ret;
			Marshal.FreeHGlobal (native__ret);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_iterator_foreach(IntPtr raw, GstSharp.IteratorForeachFunctionNative func, IntPtr user_data);

		public Gst.IteratorResult Foreach(Gst.IteratorForeachFunction func) {
			GstSharp.IteratorForeachFunctionWrapper func_wrapper = new GstSharp.IteratorForeachFunctionWrapper (func);
			int raw_ret = gst_iterator_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
			Gst.IteratorResult ret = (Gst.IteratorResult) raw_ret;
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_iterator_push(IntPtr raw, IntPtr other);

		public void Push(Gst.Iterator other) {
			gst_iterator_push(Handle, other == null ? IntPtr.Zero : other.Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_iterator_resync(IntPtr raw);

		public void Resync() {
			gst_iterator_resync(Handle);
		}

		public Iterator(IntPtr raw) : base(raw) {}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_iterator_new_single(IntPtr type, IntPtr _object);

		public Iterator (GLib.GType type, GLib.Value _object) 
		{
			IntPtr native__object = GLib.Marshaller.StructureToPtrAlloc (_object);
			Raw = gst_iterator_new_single(type.Val, native__object);
			Marshal.FreeHGlobal (native__object);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_iterator_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_iterator_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gst_iterator_free (handle);
				return false;
			}
		}

		~Iterator ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("copy"
							, 0
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // copy
							, null
							, "next"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("next"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // next
							, "copy"
							, "item"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("item"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // item
							, "next"
							, "resync"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("resync"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // resync
							, "item"
							, "free"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("free"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // free
							, "resync"
							, "pushed"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("pushed"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // pushed
							, "free"
							, "type"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("type"
							, -1
							, (uint) Marshal.SizeOf(typeof(GLib.GType)) // type
							, "pushed"
							, "lock"
							, (long) Marshal.OffsetOf(typeof(GstIterator_typeAlign), "type")
							, 0
							),
						new GLib.AbiField("lock"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // lock
							, "type"
							, "cookie"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("cookie"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // cookie
							, "lock"
							, "master_cookie"
							, (long) Marshal.OffsetOf(typeof(GstIterator_cookieAlign), "cookie")
							, 0
							),
						new GLib.AbiField("master_cookie"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // master_cookie
							, "cookie"
							, "size"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("size"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // size
							, "master_cookie"
							, "_gst_reserved"
							, (long) Marshal.OffsetOf(typeof(GstIterator_sizeAlign), "size")
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "size"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstIterator_typeAlign
		{
			sbyte f1;
			private GLib.GType type;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstIterator_cookieAlign
		{
			sbyte f1;
			private uint cookie;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstIterator_sizeAlign
		{
			sbyte f1;
			private uint size;
		}


		// End of the ABI representation.

#endregion
	}
}
