using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='VisibleRegion']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/VisibleRegion", DoNotGenerateAcw=true)]
	public sealed partial class VisibleRegion : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/VisibleRegion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VisibleRegion); }
		}

		internal VisibleRegion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getFarLeft;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng FarLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='VisibleRegion']/method[@name='getFarLeft' and count(parameter)=0]"
			[Register ("getFarLeft", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetFarLeftHandler")]
			get {
				if (id_getFarLeft == IntPtr.Zero)
					id_getFarLeft = JNIEnv.GetMethodID (class_ref, "getFarLeft", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getFarLeft), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getFarRight;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng FarRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='VisibleRegion']/method[@name='getFarRight' and count(parameter)=0]"
			[Register ("getFarRight", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetFarRightHandler")]
			get {
				if (id_getFarRight == IntPtr.Zero)
					id_getFarRight = JNIEnv.GetMethodID (class_ref, "getFarRight", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getFarRight), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getLatLngBounds;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds LatLngBounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='VisibleRegion']/method[@name='getLatLngBounds' and count(parameter)=0]"
			[Register ("getLatLngBounds", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds;", "GetGetLatLngBoundsHandler")]
			get {
				if (id_getLatLngBounds == IntPtr.Zero)
					id_getLatLngBounds = JNIEnv.GetMethodID (class_ref, "getLatLngBounds", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (JNIEnv.CallObjectMethod  (Handle, id_getLatLngBounds), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getNearLeft;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng NearLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='VisibleRegion']/method[@name='getNearLeft' and count(parameter)=0]"
			[Register ("getNearLeft", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetNearLeftHandler")]
			get {
				if (id_getNearLeft == IntPtr.Zero)
					id_getNearLeft = JNIEnv.GetMethodID (class_ref, "getNearLeft", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getNearLeft), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getNearRight;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng NearRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='VisibleRegion']/method[@name='getNearRight' and count(parameter)=0]"
			[Register ("getNearRight", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetNearRightHandler")]
			get {
				if (id_getNearRight == IntPtr.Zero)
					id_getNearRight = JNIEnv.GetMethodID (class_ref, "getNearRight", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getNearRight), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getVersionCode;
		protected int VersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='VisibleRegion']/method[@name='getVersionCode' and count(parameter)=0]"
			[Register ("getVersionCode", "()I", "GetGetVersionCodeHandler")]
			get {
				if (id_getVersionCode == IntPtr.Zero)
					id_getVersionCode = JNIEnv.GetMethodID (class_ref, "getVersionCode", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getVersionCode);
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='VisibleRegion']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='VisibleRegion']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_hashCode);
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='VisibleRegion']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
