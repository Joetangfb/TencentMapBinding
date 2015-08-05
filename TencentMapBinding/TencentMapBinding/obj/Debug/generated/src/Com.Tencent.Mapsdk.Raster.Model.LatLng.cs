using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLng']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/LatLng", DoNotGenerateAcw=true)]
	public sealed partial class LatLng : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/LatLng", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatLng); }
		}

		internal LatLng (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLng']/constructor[@name='LatLng' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public LatLng (double p0, double p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LatLng)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DD)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_DD == IntPtr.Zero)
				id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DD, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_getLatitude;
		public double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLng']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");
				return JNIEnv.CallDoubleMethod  (Handle, id_getLatitude);
			}
		}

		static IntPtr id_getLongitude;
		public double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLng']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");
				return JNIEnv.CallDoubleMethod  (Handle, id_getLongitude);
			}
		}

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLng']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLng']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLng']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_hashCode);
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLng']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
