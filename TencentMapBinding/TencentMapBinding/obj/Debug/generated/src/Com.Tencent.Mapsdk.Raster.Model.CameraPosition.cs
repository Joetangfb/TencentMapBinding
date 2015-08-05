using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/CameraPosition", DoNotGenerateAcw=true)]
	public sealed partial class CameraPosition : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition.Builder']"
		[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/CameraPosition$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/CameraPosition$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition.Builder']/constructor[@name='CameraPosition.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
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

			static IntPtr id_ctor_Lcom_tencent_mapsdk_raster_model_CameraPosition_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition.Builder']/constructor[@name='CameraPosition.Builder' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.CameraPosition']]"
			[Register (".ctor", "(Lcom/tencent/mapsdk/raster/model/CameraPosition;)V", "")]
			public Builder (global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Builder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/mapsdk/raster/model/CameraPosition;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/mapsdk/raster/model/CameraPosition;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lcom_tencent_mapsdk_raster_model_CameraPosition_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_mapsdk_raster_model_CameraPosition_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/mapsdk/raster/model/CameraPosition;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_mapsdk_raster_model_CameraPosition_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_mapsdk_raster_model_CameraPosition_, new JValue (p0));
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/tencent/mapsdk/raster/model/CameraPosition;", "")]
			public global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/tencent/mapsdk/raster/model/CameraPosition;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_target_Lcom_tencent_mapsdk_raster_model_LatLng_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition.Builder']/method[@name='target' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
			[Register ("target", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/CameraPosition$Builder;", "")]
			public global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition.Builder Target (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
			{
				if (id_target_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
					id_target_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "target", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/CameraPosition$Builder;");
				global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition.Builder> (JNIEnv.CallObjectMethod  (Handle, id_target_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_zoom_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition.Builder']/method[@name='zoom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("zoom", "(F)Lcom/tencent/mapsdk/raster/model/CameraPosition$Builder;", "")]
			public global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition.Builder Zoom (float p0)
			{
				if (id_zoom_F == IntPtr.Zero)
					id_zoom_F = JNIEnv.GetMethodID (class_ref, "zoom", "(F)Lcom/tencent/mapsdk/raster/model/CameraPosition$Builder;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition.Builder> (JNIEnv.CallObjectMethod  (Handle, id_zoom_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/CameraPosition", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraPosition); }
		}

		internal CameraPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_mapsdk_raster_model_LatLng_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/constructor[@name='CameraPosition' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='float']]"
		[Register (".ctor", "(Lcom/tencent/mapsdk/raster/model/LatLng;F)V", "")]
		public CameraPosition (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, float p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CameraPosition)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/mapsdk/raster/model/LatLng;F)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/mapsdk/raster/model/LatLng;F)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_tencent_mapsdk_raster_model_LatLng_F == IntPtr.Zero)
				id_ctor_Lcom_tencent_mapsdk_raster_model_LatLng_F = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/mapsdk/raster/model/LatLng;F)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_mapsdk_raster_model_LatLng_F, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_mapsdk_raster_model_LatLng_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_getTarget;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetTargetHandler")]
			get {
				if (id_getTarget == IntPtr.Zero)
					id_getTarget = JNIEnv.GetMethodID (class_ref, "getTarget", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getTarget), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getZoom;
		public float Zoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/method[@name='getZoom' and count(parameter)=0]"
			[Register ("getZoom", "()F", "GetGetZoomHandler")]
			get {
				if (id_getZoom == IntPtr.Zero)
					id_getZoom = JNIEnv.GetMethodID (class_ref, "getZoom", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getZoom);
			}
		}

		static IntPtr id_builder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/tencent/mapsdk/raster/model/CameraPosition$Builder;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition.Builder InvokeBuilder ()
		{
			if (id_builder == IntPtr.Zero)
				id_builder = JNIEnv.GetStaticMethodID (class_ref, "builder", "()Lcom/tencent/mapsdk/raster/model/CameraPosition$Builder;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_builder_Lcom_tencent_mapsdk_raster_model_CameraPosition_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.CameraPosition']]"
		[Register ("builder", "(Lcom/tencent/mapsdk/raster/model/CameraPosition;)Lcom/tencent/mapsdk/raster/model/CameraPosition$Builder;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition.Builder InvokeBuilder (global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0)
		{
			if (id_builder_Lcom_tencent_mapsdk_raster_model_CameraPosition_ == IntPtr.Zero)
				id_builder_Lcom_tencent_mapsdk_raster_model_CameraPosition_ = JNIEnv.GetStaticMethodID (class_ref, "builder", "(Lcom/tencent/mapsdk/raster/model/CameraPosition;)Lcom/tencent/mapsdk/raster/model/CameraPosition$Builder;");
			global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder_Lcom_tencent_mapsdk_raster_model_CameraPosition_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_describeContents);
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_fromLatLngZoom_Lcom_tencent_mapsdk_raster_model_LatLng_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/method[@name='fromLatLngZoom' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='float']]"
		[Register ("fromLatLngZoom", "(Lcom/tencent/mapsdk/raster/model/LatLng;F)Lcom/tencent/mapsdk/raster/model/CameraPosition;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition FromLatLngZoom (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, float p1)
		{
			if (id_fromLatLngZoom_Lcom_tencent_mapsdk_raster_model_LatLng_F == IntPtr.Zero)
				id_fromLatLngZoom_Lcom_tencent_mapsdk_raster_model_LatLng_F = JNIEnv.GetStaticMethodID (class_ref, "fromLatLngZoom", "(Lcom/tencent/mapsdk/raster/model/LatLng;F)Lcom/tencent/mapsdk/raster/model/CameraPosition;");
			global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromLatLngZoom_Lcom_tencent_mapsdk_raster_model_LatLng_F, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_hashCode);
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='CameraPosition']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
		}

	}
}
