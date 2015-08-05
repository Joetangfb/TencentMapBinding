using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/GeoPoint", DoNotGenerateAcw=true)]
	public partial class GeoPoint : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/field[@name='CREATOR']"
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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/GeoPoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeoPoint); }
		}

		protected GeoPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/constructor[@name='GeoPoint' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public GeoPoint (int p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeoPoint)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_II == IntPtr.Zero)
				id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getLatitudeE6;
#pragma warning disable 0169
		static Delegate GetGetLatitudeE6Handler ()
		{
			if (cb_getLatitudeE6 == null)
				cb_getLatitudeE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatitudeE6);
			return cb_getLatitudeE6;
		}

		static int n_GetLatitudeE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeE6;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitudeE6_I;
#pragma warning disable 0169
		static Delegate GetSetLatitudeE6_IHandler ()
		{
			if (cb_setLatitudeE6_I == null)
				cb_setLatitudeE6_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLatitudeE6_I);
			return cb_setLatitudeE6_I;
		}

		static void n_SetLatitudeE6_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LatitudeE6 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitudeE6;
		static IntPtr id_setLatitudeE6_I;
		public virtual int LatitudeE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/method[@name='getLatitudeE6' and count(parameter)=0]"
			[Register ("getLatitudeE6", "()I", "GetGetLatitudeE6Handler")]
			get {
				if (id_getLatitudeE6 == IntPtr.Zero)
					id_getLatitudeE6 = JNIEnv.GetMethodID (class_ref, "getLatitudeE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLatitudeE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitudeE6", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/method[@name='setLatitudeE6' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLatitudeE6", "(I)V", "GetSetLatitudeE6_IHandler")]
			set {
				if (id_setLatitudeE6_I == IntPtr.Zero)
					id_setLatitudeE6_I = JNIEnv.GetMethodID (class_ref, "setLatitudeE6", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLatitudeE6_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLatitudeE6", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getLongitudeE6;
#pragma warning disable 0169
		static Delegate GetGetLongitudeE6Handler ()
		{
			if (cb_getLongitudeE6 == null)
				cb_getLongitudeE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLongitudeE6);
			return cb_getLongitudeE6;
		}

		static int n_GetLongitudeE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeE6;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitudeE6_I;
#pragma warning disable 0169
		static Delegate GetSetLongitudeE6_IHandler ()
		{
			if (cb_setLongitudeE6_I == null)
				cb_setLongitudeE6_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLongitudeE6_I);
			return cb_setLongitudeE6_I;
		}

		static void n_SetLongitudeE6_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LongitudeE6 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitudeE6;
		static IntPtr id_setLongitudeE6_I;
		public virtual int LongitudeE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/method[@name='getLongitudeE6' and count(parameter)=0]"
			[Register ("getLongitudeE6", "()I", "GetGetLongitudeE6Handler")]
			get {
				if (id_getLongitudeE6 == IntPtr.Zero)
					id_getLongitudeE6 = JNIEnv.GetMethodID (class_ref, "getLongitudeE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLongitudeE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitudeE6", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/method[@name='setLongitudeE6' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLongitudeE6", "(I)V", "GetSetLongitudeE6_IHandler")]
			set {
				if (id_setLongitudeE6_I == IntPtr.Zero)
					id_setLongitudeE6_I = JNIEnv.GetMethodID (class_ref, "setLongitudeE6", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLongitudeE6_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLongitudeE6", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_Copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_Copy == null)
				cb_Copy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Copy);
			return cb_Copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		static IntPtr id_Copy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/method[@name='Copy' and count(parameter)=0]"
		[Register ("Copy", "()Lcom/tencent/mapsdk/raster/model/GeoPoint;", "GetCopyHandler")]
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint Copy ()
		{
			if (id_Copy == IntPtr.Zero)
				id_Copy = JNIEnv.GetMethodID (class_ref, "Copy", "()Lcom/tencent/mapsdk/raster/model/GeoPoint;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_Copy), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Copy", "()Lcom/tencent/mapsdk/raster/model/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_hashCode);
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='GeoPoint']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), new JValue (p0), new JValue ((int) p1));
		}

	}
}
