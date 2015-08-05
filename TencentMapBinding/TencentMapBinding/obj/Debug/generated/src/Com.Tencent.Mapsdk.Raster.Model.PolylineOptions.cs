using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/PolylineOptions", DoNotGenerateAcw=true)]
	public sealed partial class PolylineOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/PolylineOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolylineOptions); }
		}

		internal PolylineOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/constructor[@name='PolylineOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PolylineOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PolylineOptions)) {
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

		static IntPtr id_getColor;
		public int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getColor);
			}
		}

		static IntPtr id_isDottedLine;
		public bool IsDottedLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='isDottedLine' and count(parameter)=0]"
			[Register ("isDottedLine", "()Z", "GetIsDottedLineHandler")]
			get {
				if (id_isDottedLine == IntPtr.Zero)
					id_isDottedLine = JNIEnv.GetMethodID (class_ref, "isDottedLine", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isDottedLine);
			}
		}

		static IntPtr id_isGeodesic;
		public bool IsGeodesic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='isGeodesic' and count(parameter)=0]"
			[Register ("isGeodesic", "()Z", "GetIsGeodesicHandler")]
			get {
				if (id_isGeodesic == IntPtr.Zero)
					id_isGeodesic = JNIEnv.GetMethodID (class_ref, "isGeodesic", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isGeodesic);
			}
		}

		static IntPtr id_isVisible;
		public bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
		}

		static IntPtr id_getPoints;
		public global::System.Collections.Generic.IList<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Tencent.Mapsdk.Raster.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getWidth;
		public float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
			}
		}

		static IntPtr id_getZIndex;
		public float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
		}

		static IntPtr id_add_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("add", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/PolylineOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions Add (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_add_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_add_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/PolylineOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_add_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_add_arrayLcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng...']]"
		[Register ("add", "([Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/PolylineOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions Add (params global:: Com.Tencent.Mapsdk.Raster.Model.LatLng[] p0)
		{
			if (id_add_arrayLcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_add_arrayLcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "add", "([Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/PolylineOptions;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_add_arrayLcom_tencent_mapsdk_raster_model_LatLng_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_addAll_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("addAll", "(Ljava/lang/Iterable;)Lcom/tencent/mapsdk/raster/model/PolylineOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions AddAll (global::Java.Lang.IIterable p0)
		{
			if (id_addAll_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_addAll_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/lang/Iterable;)Lcom/tencent/mapsdk/raster/model/PolylineOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_addAll_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_color_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='color' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("color", "(I)Lcom/tencent/mapsdk/raster/model/PolylineOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions InvokeColor (int p0)
		{
			if (id_color_I == IntPtr.Zero)
				id_color_I = JNIEnv.GetMethodID (class_ref, "color", "(I)Lcom/tencent/mapsdk/raster/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_color_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_geodesic_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='geodesic' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("geodesic", "(Z)Lcom/tencent/mapsdk/raster/model/PolylineOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions Geodesic (bool p0)
		{
			if (id_geodesic_Z == IntPtr.Zero)
				id_geodesic_Z = JNIEnv.GetMethodID (class_ref, "geodesic", "(Z)Lcom/tencent/mapsdk/raster/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_geodesic_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setDottedLine_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='setDottedLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDottedLine", "(Z)Lcom/tencent/mapsdk/raster/model/PolylineOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions SetDottedLine (bool p0)
		{
			if (id_setDottedLine_Z == IntPtr.Zero)
				id_setDottedLine_Z = JNIEnv.GetMethodID (class_ref, "setDottedLine", "(Z)Lcom/tencent/mapsdk/raster/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_setDottedLine_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/tencent/mapsdk/raster/model/PolylineOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/tencent/mapsdk/raster/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_width_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='width' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("width", "(F)Lcom/tencent/mapsdk/raster/model/PolylineOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions InvokeWidth (float p0)
		{
			if (id_width_F == IntPtr.Zero)
				id_width_F = JNIEnv.GetMethodID (class_ref, "width", "(F)Lcom/tencent/mapsdk/raster/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_width_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_zIndex_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolylineOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zIndex", "(F)Lcom/tencent/mapsdk/raster/model/PolylineOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions InvokeZIndex (float p0)
		{
			if (id_zIndex_F == IntPtr.Zero)
				id_zIndex_F = JNIEnv.GetMethodID (class_ref, "zIndex", "(F)Lcom/tencent/mapsdk/raster/model/PolylineOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (JNIEnv.CallObjectMethod  (Handle, id_zIndex_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
