using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/GroundOverlayOptions", DoNotGenerateAcw=true)]
	public sealed partial class GroundOverlayOptions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/GroundOverlayOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GroundOverlayOptions); }
		}

		internal GroundOverlayOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAnchorU;
		public float AnchorU {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getAnchorU' and count(parameter)=0]"
			[Register ("getAnchorU", "()F", "GetGetAnchorUHandler")]
			get {
				if (id_getAnchorU == IntPtr.Zero)
					id_getAnchorU = JNIEnv.GetMethodID (class_ref, "getAnchorU", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAnchorU);
			}
		}

		static IntPtr id_getAnchorV;
		public float AnchorV {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getAnchorV' and count(parameter)=0]"
			[Register ("getAnchorV", "()F", "GetGetAnchorVHandler")]
			get {
				if (id_getAnchorV == IntPtr.Zero)
					id_getAnchorV = JNIEnv.GetMethodID (class_ref, "getAnchorV", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAnchorV);
			}
		}

		static IntPtr id_getBearing;
		public float Bearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getBearing' and count(parameter)=0]"
			[Register ("getBearing", "()F", "GetGetBearingHandler")]
			get {
				if (id_getBearing == IntPtr.Zero)
					id_getBearing = JNIEnv.GetMethodID (class_ref, "getBearing", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getBearing);
			}
		}

		static IntPtr id_getBounds;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds Bounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getBounds' and count(parameter)=0]"
			[Register ("getBounds", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds;", "GetGetBoundsHandler")]
			get {
				if (id_getBounds == IntPtr.Zero)
					id_getBounds = JNIEnv.GetMethodID (class_ref, "getBounds", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (JNIEnv.CallObjectMethod  (Handle, id_getBounds), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getHeight;
		public float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getHeight);
			}
		}

		static IntPtr id_getImage;
		public global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isVisible;
		public bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
		}

		static IntPtr id_getLocation;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getTransparency;
		public float Transparency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getTransparency' and count(parameter)=0]"
			[Register ("getTransparency", "()F", "GetGetTransparencyHandler")]
			get {
				if (id_getTransparency == IntPtr.Zero)
					id_getTransparency = JNIEnv.GetMethodID (class_ref, "getTransparency", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getTransparency);
			}
		}

		static IntPtr id_getWidth;
		public float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
			}
		}

		static IntPtr id_getZIndex;
		public float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
			}
		}

		static IntPtr id_anchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='anchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("anchor", "(FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions Anchor (float p0, float p1)
		{
			if (id_anchor_FF == IntPtr.Zero)
				id_anchor_FF = JNIEnv.GetMethodID (class_ref, "anchor", "(FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_anchor_FF, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_bearing_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='bearing' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("bearing", "(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions InvokeBearing (float p0)
		{
			if (id_bearing_F == IntPtr.Zero)
				id_bearing_F = JNIEnv.GetMethodID (class_ref, "bearing", "(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_bearing_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_image_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='image' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.BitmapDescriptor']]"
		[Register ("image", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions InvokeImage (global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor p0)
		{
			if (id_image_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_ == IntPtr.Zero)
				id_image_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "image", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_image_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_position_Lcom_tencent_mapsdk_raster_model_LatLng_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='position' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='float']]"
		[Register ("position", "(Lcom/tencent/mapsdk/raster/model/LatLng;F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions Position (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, float p1)
		{
			if (id_position_Lcom_tencent_mapsdk_raster_model_LatLng_F == IntPtr.Zero)
				id_position_Lcom_tencent_mapsdk_raster_model_LatLng_F = JNIEnv.GetMethodID (class_ref, "position", "(Lcom/tencent/mapsdk/raster/model/LatLng;F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_position_Lcom_tencent_mapsdk_raster_model_LatLng_F, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_position_Lcom_tencent_mapsdk_raster_model_LatLng_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='position' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("position", "(Lcom/tencent/mapsdk/raster/model/LatLng;FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions Position (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, float p1, float p2)
		{
			if (id_position_Lcom_tencent_mapsdk_raster_model_LatLng_FF == IntPtr.Zero)
				id_position_Lcom_tencent_mapsdk_raster_model_LatLng_FF = JNIEnv.GetMethodID (class_ref, "position", "(Lcom/tencent/mapsdk/raster/model/LatLng;FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_position_Lcom_tencent_mapsdk_raster_model_LatLng_FF, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_positionFromBounds_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='positionFromBounds' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLngBounds']]"
		[Register ("positionFromBounds", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions PositionFromBounds (global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0)
		{
			if (id_positionFromBounds_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ == IntPtr.Zero)
				id_positionFromBounds_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "positionFromBounds", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_positionFromBounds_Lcom_tencent_mapsdk_raster_model_LatLngBounds_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_putGroundOverlayOptions_Lcom_tencent_mapsdk_raster_model_LatLng_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='putGroundOverlayOptions' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("putGroundOverlayOptions", "(Lcom/tencent/mapsdk/raster/model/LatLng;FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		protected global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions PutGroundOverlayOptions (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, float p1, float p2)
		{
			if (id_putGroundOverlayOptions_Lcom_tencent_mapsdk_raster_model_LatLng_FF == IntPtr.Zero)
				id_putGroundOverlayOptions_Lcom_tencent_mapsdk_raster_model_LatLng_FF = JNIEnv.GetMethodID (class_ref, "putGroundOverlayOptions", "(Lcom/tencent/mapsdk/raster/model/LatLng;FF)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_putGroundOverlayOptions_Lcom_tencent_mapsdk_raster_model_LatLng_FF, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_transparency_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='transparency' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("transparency", "(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions InvokeTransparency (float p0)
		{
			if (id_transparency_F == IntPtr.Zero)
				id_transparency_F = JNIEnv.GetMethodID (class_ref, "transparency", "(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_transparency_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_zIndex_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GroundOverlayOptions']/method[@name='zIndex' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zIndex", "(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions InvokeZIndex (float p0)
		{
			if (id_zIndex_F == IntPtr.Zero)
				id_zIndex_F = JNIEnv.GetMethodID (class_ref, "zIndex", "(F)Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (JNIEnv.CallObjectMethod  (Handle, id_zIndex_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
