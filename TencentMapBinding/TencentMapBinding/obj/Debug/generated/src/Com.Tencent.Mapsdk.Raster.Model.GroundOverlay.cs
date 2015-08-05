using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/GroundOverlay", DoNotGenerateAcw=true)]
	public sealed partial class GroundOverlay : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/GroundOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GroundOverlay); }
		}

		internal GroundOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBearing;
		static IntPtr id_setBearing_F;
		public float Bearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='getBearing' and count(parameter)=0]"
			[Register ("getBearing", "()F", "GetGetBearingHandler")]
			get {
				if (id_getBearing == IntPtr.Zero)
					id_getBearing = JNIEnv.GetMethodID (class_ref, "getBearing", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getBearing);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='setBearing' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBearing", "(F)V", "GetSetBearing_FHandler")]
			set {
				if (id_setBearing_F == IntPtr.Zero)
					id_setBearing_F = JNIEnv.GetMethodID (class_ref, "setBearing", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setBearing_F, new JValue (value));
			}
		}

		static IntPtr id_getBounds;
		protected global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds Bounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='getBounds' and count(parameter)=0]"
			[Register ("getBounds", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds;", "GetGetBoundsHandler")]
			get {
				if (id_getBounds == IntPtr.Zero)
					id_getBounds = JNIEnv.GetMethodID (class_ref, "getBounds", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (JNIEnv.CallObjectMethod  (Handle, id_getBounds), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getHeight;
		protected float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getHeight);
			}
		}

		static IntPtr id_getId;
		protected string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_Lcom_tencent_mapsdk_raster_model_LatLng_;
		protected global::Com.Tencent.Mapsdk.Raster.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
			[Register ("setPosition", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetSetPosition_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
			set {
				if (id_setPosition_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
					id_setPosition_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setPosition_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (value));
			}
		}

		static IntPtr id_getTransparency;
		static IntPtr id_setTransparency_F;
		protected float Transparency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='getTransparency' and count(parameter)=0]"
			[Register ("getTransparency", "()F", "GetGetTransparencyHandler")]
			get {
				if (id_getTransparency == IntPtr.Zero)
					id_getTransparency = JNIEnv.GetMethodID (class_ref, "getTransparency", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getTransparency);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='setTransparency' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTransparency", "(F)V", "GetSetTransparency_FHandler")]
			set {
				if (id_setTransparency_F == IntPtr.Zero)
					id_setTransparency_F = JNIEnv.GetMethodID (class_ref, "setTransparency", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setTransparency_F, new JValue (value));
			}
		}

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		protected bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setVisible_Z, new JValue (value));
			}
		}

		static IntPtr id_getWidth;
		protected float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
			}
		}

		static IntPtr id_getZIndex;
		static IntPtr id_setZIndex_F;
		public float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler")]
			set {
				if (id_setZIndex_F == IntPtr.Zero)
					id_setZIndex_F = JNIEnv.GetMethodID (class_ref, "setZIndex", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setZIndex_F, new JValue (value));
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_hashCode);
		}

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "")]
		public void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_remove);
		}

		static IntPtr id_setAnchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='setAnchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setAnchor", "(FF)V", "")]
		public void SetAnchor (float p0, float p1)
		{
			if (id_setAnchor_FF == IntPtr.Zero)
				id_setAnchor_FF = JNIEnv.GetMethodID (class_ref, "setAnchor", "(FF)V");
			JNIEnv.CallVoidMethod  (Handle, id_setAnchor_FF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setDimensions_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='setDimensions' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDimensions", "(F)V", "")]
		protected void SetDimensions (float p0)
		{
			if (id_setDimensions_F == IntPtr.Zero)
				id_setDimensions_F = JNIEnv.GetMethodID (class_ref, "setDimensions", "(F)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDimensions_F, new JValue (p0));
		}

		static IntPtr id_setDimensions_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='setDimensions' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setDimensions", "(FF)V", "")]
		protected void SetDimensions (float p0, float p1)
		{
			if (id_setDimensions_FF == IntPtr.Zero)
				id_setDimensions_FF = JNIEnv.GetMethodID (class_ref, "setDimensions", "(FF)V");
			JNIEnv.CallVoidMethod  (Handle, id_setDimensions_FF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setImage_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.BitmapDescriptor']]"
		[Register ("setImage", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)V", "")]
		protected void SetImage (global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor p0)
		{
			if (id_setImage_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_ == IntPtr.Zero)
				id_setImage_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setImage_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_, new JValue (p0));
		}

		static IntPtr id_setPositionFromBounds_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlay']/method[@name='setPositionFromBounds' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLngBounds']]"
		[Register ("setPositionFromBounds", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)V", "")]
		protected void SetPositionFromBounds (global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0)
		{
			if (id_setPositionFromBounds_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ == IntPtr.Zero)
				id_setPositionFromBounds_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "setPositionFromBounds", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setPositionFromBounds_Lcom_tencent_mapsdk_raster_model_LatLngBounds_, new JValue (p0));
		}

	}
}
