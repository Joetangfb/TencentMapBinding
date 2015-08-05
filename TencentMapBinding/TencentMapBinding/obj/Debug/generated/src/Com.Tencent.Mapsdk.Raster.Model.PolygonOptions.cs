using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/PolygonOptions", DoNotGenerateAcw=true)]
	public sealed partial class PolygonOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/PolygonOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolygonOptions); }
		}

		internal PolygonOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/constructor[@name='PolygonOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PolygonOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PolygonOptions)) {
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

		static IntPtr id_getFillColor;
		public int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getFillColor);
			}
		}

		static IntPtr id_isVisible;
		public bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
		}

		static IntPtr id_getPoints;
		public global::System.Collections.Generic.IList<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Tencent.Mapsdk.Raster.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getStrokeColor;
		public int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStrokeColor);
			}
		}

		static IntPtr id_getStrokeWidth;
		public float StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getStrokeWidth);
			}
		}

		static IntPtr id_getZIndex;
		public float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
		}

		static IntPtr id_add_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("add", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/PolygonOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions Add (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_add_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_add_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/PolygonOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_add_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_add_arrayLcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng...']]"
		[Register ("add", "([Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/PolygonOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions Add (params global:: Com.Tencent.Mapsdk.Raster.Model.LatLng[] p0)
		{
			if (id_add_arrayLcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_add_arrayLcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "add", "([Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/PolygonOptions;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_add_arrayLcom_tencent_mapsdk_raster_model_LatLng_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_addAll_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable']]"
		[Register ("addAll", "(Ljava/lang/Iterable;)Lcom/tencent/mapsdk/raster/model/PolygonOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions AddAll (global::Java.Lang.IIterable p0)
		{
			if (id_addAll_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_addAll_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/lang/Iterable;)Lcom/tencent/mapsdk/raster/model/PolygonOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_addAll_Ljava_lang_Iterable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_fillColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='fillColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fillColor", "(I)Lcom/tencent/mapsdk/raster/model/PolygonOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions InvokeFillColor (int p0)
		{
			if (id_fillColor_I == IntPtr.Zero)
				id_fillColor_I = JNIEnv.GetMethodID (class_ref, "fillColor", "(I)Lcom/tencent/mapsdk/raster/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_fillColor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_strokeColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='strokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("strokeColor", "(I)Lcom/tencent/mapsdk/raster/model/PolygonOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions InvokeStrokeColor (int p0)
		{
			if (id_strokeColor_I == IntPtr.Zero)
				id_strokeColor_I = JNIEnv.GetMethodID (class_ref, "strokeColor", "(I)Lcom/tencent/mapsdk/raster/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_strokeColor_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_strokeWidth_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='strokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("strokeWidth", "(F)Lcom/tencent/mapsdk/raster/model/PolygonOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions InvokeStrokeWidth (float p0)
		{
			if (id_strokeWidth_F == IntPtr.Zero)
				id_strokeWidth_F = JNIEnv.GetMethodID (class_ref, "strokeWidth", "(F)Lcom/tencent/mapsdk/raster/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_strokeWidth_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/tencent/mapsdk/raster/model/PolygonOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/tencent/mapsdk/raster/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_zIndex_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='PolygonOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zIndex", "(F)Lcom/tencent/mapsdk/raster/model/PolygonOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions InvokeZIndex (float p0)
		{
			if (id_zIndex_F == IntPtr.Zero)
				id_zIndex_F = JNIEnv.GetMethodID (class_ref, "zIndex", "(F)Lcom/tencent/mapsdk/raster/model/PolygonOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (JNIEnv.CallObjectMethod  (Handle, id_zIndex_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
