using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/CircleOptions", DoNotGenerateAcw=true)]
	public sealed partial class CircleOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/CircleOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CircleOptions); }
		}

		internal CircleOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/constructor[@name='CircleOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CircleOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CircleOptions)) {
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

		static IntPtr id_getCenter;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getFillColor;
		public int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getFillColor);
			}
		}

		static IntPtr id_isVisible;
		public bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
		}

		static IntPtr id_getRadius;
		public double Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()D", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()D");
				return JNIEnv.CallDoubleMethod  (Handle, id_getRadius);
			}
		}

		static IntPtr id_getStrokeColor;
		public int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStrokeColor);
			}
		}

		static IntPtr id_getStrokeWidth;
		public float StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getStrokeWidth);
			}
		}

		static IntPtr id_getZIndex;
		public float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
		}

		static IntPtr id_center_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='center' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("center", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/CircleOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions InvokeCenter (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_center_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_center_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "center", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/CircleOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_center_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_fillColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='fillColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fillColor", "(I)Lcom/tencent/mapsdk/raster/model/CircleOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions InvokeFillColor (int p0)
		{
			if (id_fillColor_I == IntPtr.Zero)
				id_fillColor_I = JNIEnv.GetMethodID (class_ref, "fillColor", "(I)Lcom/tencent/mapsdk/raster/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_fillColor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_radius_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='radius' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("radius", "(D)Lcom/tencent/mapsdk/raster/model/CircleOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions InvokeRadius (double p0)
		{
			if (id_radius_D == IntPtr.Zero)
				id_radius_D = JNIEnv.GetMethodID (class_ref, "radius", "(D)Lcom/tencent/mapsdk/raster/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_radius_D, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_strokeColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='strokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("strokeColor", "(I)Lcom/tencent/mapsdk/raster/model/CircleOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions InvokeStrokeColor (int p0)
		{
			if (id_strokeColor_I == IntPtr.Zero)
				id_strokeColor_I = JNIEnv.GetMethodID (class_ref, "strokeColor", "(I)Lcom/tencent/mapsdk/raster/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_strokeColor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_strokeWidth_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='strokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("strokeWidth", "(F)Lcom/tencent/mapsdk/raster/model/CircleOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions InvokeStrokeWidth (float p0)
		{
			if (id_strokeWidth_F == IntPtr.Zero)
				id_strokeWidth_F = JNIEnv.GetMethodID (class_ref, "strokeWidth", "(F)Lcom/tencent/mapsdk/raster/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_strokeWidth_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/tencent/mapsdk/raster/model/CircleOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/tencent/mapsdk/raster/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, int p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_zIndex_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CircleOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zIndex", "(F)Lcom/tencent/mapsdk/raster/model/CircleOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions InvokeZIndex (float p0)
		{
			if (id_zIndex_F == IntPtr.Zero)
				id_zIndex_F = JNIEnv.GetMethodID (class_ref, "zIndex", "(F)Lcom/tencent/mapsdk/raster/model/CircleOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (JNIEnv.CallObjectMethod  (Handle, id_zIndex_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
