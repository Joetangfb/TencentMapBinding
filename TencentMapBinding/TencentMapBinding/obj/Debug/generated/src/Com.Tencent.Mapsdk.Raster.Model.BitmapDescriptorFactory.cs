using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/BitmapDescriptorFactory", DoNotGenerateAcw=true)]
	public sealed partial class BitmapDescriptorFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/BitmapDescriptorFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapDescriptorFactory); }
		}

		internal BitmapDescriptorFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/constructor[@name='BitmapDescriptorFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BitmapDescriptorFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BitmapDescriptorFactory)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_defaultMarker;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='defaultMarker' and count(parameter)=0]"
		[Register ("defaultMarker", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor DefaultMarker ()
		{
			if (id_defaultMarker == IntPtr.Zero)
				id_defaultMarker = JNIEnv.GetStaticMethodID (class_ref, "defaultMarker", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultMarker), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_fromAsset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromAsset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromAsset", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromAsset (string p0)
		{
			if (id_fromAsset_Ljava_lang_String_ == IntPtr.Zero)
				id_fromAsset_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromAsset", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromAsset_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_fromBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("fromBitmap", "(Landroid/graphics/Bitmap;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromBitmap (global::Android.Graphics.Bitmap p0)
		{
			if (id_fromBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_fromBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "fromBitmap", "(Landroid/graphics/Bitmap;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;");
			global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromBitmap_Landroid_graphics_Bitmap_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_fromFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromFile", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromFile (string p0)
		{
			if (id_fromFile_Ljava_lang_String_ == IntPtr.Zero)
				id_fromFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromFile", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFile_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_fromPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromPath", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromPath (string p0)
		{
			if (id_fromPath_Ljava_lang_String_ == IntPtr.Zero)
				id_fromPath_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromPath", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromPath_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_fromResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromResource", "(I)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromResource (int p0)
		{
			if (id_fromResource_I == IntPtr.Zero)
				id_fromResource_I = JNIEnv.GetStaticMethodID (class_ref, "fromResource", "(I)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromResource_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_fromView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("fromView", "(Landroid/view/View;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromView (global::Android.Views.View p0)
		{
			if (id_fromView_Landroid_view_View_ == IntPtr.Zero)
				id_fromView_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "fromView", "(Landroid/view/View;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;");
			global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromView_Landroid_view_View_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
