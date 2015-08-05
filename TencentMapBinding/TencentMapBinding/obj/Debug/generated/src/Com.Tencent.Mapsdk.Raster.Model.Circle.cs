using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/Circle", DoNotGenerateAcw=true)]
	public sealed partial class Circle : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/Circle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Circle); }
		}

		internal Circle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCenter;
		static IntPtr id_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
			[Register ("setCenter", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetSetCenter_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
			set {
				if (id_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
					id_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setCenter", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (value));
			}
		}

		static IntPtr id_getFillColor;
		static IntPtr id_setFillColor_I;
		public int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getFillColor);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillColor", "(I)V", "GetSetFillColor_IHandler")]
			set {
				if (id_setFillColor_I == IntPtr.Zero)
					id_setFillColor_I = JNIEnv.GetMethodID (class_ref, "setFillColor", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setFillColor_I, new JValue (value));
			}
		}

		static IntPtr id_getId;
		public string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRadius;
		static IntPtr id_setRadius_D;
		public double Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()D", "GetGetRadiusHandler")]
			get {
				if (id_getRadius == IntPtr.Zero)
					id_getRadius = JNIEnv.GetMethodID (class_ref, "getRadius", "()D");
				return JNIEnv.CallDoubleMethod  (Handle, id_getRadius);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRadius", "(D)V", "GetSetRadius_DHandler")]
			set {
				if (id_setRadius_D == IntPtr.Zero)
					id_setRadius_D = JNIEnv.GetMethodID (class_ref, "setRadius", "(D)V");
				JNIEnv.CallVoidMethod  (Handle, id_setRadius_D, new JValue (value));
			}
		}

		static IntPtr id_getStrokeColor;
		static IntPtr id_setStrokeColor_I;
		public int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getStrokeColor);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='setStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeColor", "(I)V", "GetSetStrokeColor_IHandler")]
			set {
				if (id_setStrokeColor_I == IntPtr.Zero)
					id_setStrokeColor_I = JNIEnv.GetMethodID (class_ref, "setStrokeColor", "(I)V");
				JNIEnv.CallVoidMethod  (Handle, id_setStrokeColor_I, new JValue (value));
			}
		}

		static IntPtr id_getStrokeWidth;
		static IntPtr id_setStrokeWidth_F;
		public float StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getStrokeWidth);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setStrokeWidth", "(F)V", "GetSetStrokeWidth_FHandler")]
			set {
				if (id_setStrokeWidth_F == IntPtr.Zero)
					id_setStrokeWidth_F = JNIEnv.GetMethodID (class_ref, "setStrokeWidth", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setStrokeWidth_F, new JValue (value));
			}
		}

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setVisible_Z, new JValue (value));
			}
		}

		static IntPtr id_getZIndex;
		static IntPtr id_setZIndex_F;
		public float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler")]
			set {
				if (id_setZIndex_F == IntPtr.Zero)
					id_setZIndex_F = JNIEnv.GetMethodID (class_ref, "setZIndex", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setZIndex_F, new JValue (value));
			}
		}

		static IntPtr id_contains_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("contains", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Z", "")]
		public bool Contains (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_contains_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_contains_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_hashCode);
		}

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Circle']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "")]
		public void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_remove);
		}

	}
}
