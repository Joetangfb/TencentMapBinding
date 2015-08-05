using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptor']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/BitmapDescriptor", DoNotGenerateAcw=true)]
	public sealed partial class BitmapDescriptor : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/BitmapDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapDescriptor); }
		}

		internal BitmapDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptor']/constructor[@name='BitmapDescriptor' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public BitmapDescriptor (global::Android.Graphics.Bitmap p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BitmapDescriptor)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_ctor_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_, new JValue (p0));
		}

		static IntPtr id_getBitmap;
		public global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptor']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get {
				if (id_getBitmap == IntPtr.Zero)
					id_getBitmap = JNIEnv.GetMethodID (class_ref, "getBitmap", "()Landroid/graphics/Bitmap;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getBitmap), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getHeight;
		public int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptor']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getHeight);
			}
		}

		static IntPtr id_getWidth;
		public int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptor']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getWidth);
			}
		}

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptor']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
		}

	}
}
