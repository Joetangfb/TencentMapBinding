using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/LatLngBounds", DoNotGenerateAcw=true)]
	public partial class LatLngBounds : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds.Builder']"
		[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/LatLngBounds$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/LatLngBounds$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds.Builder']/constructor[@name='LatLngBounds.Builder' and count(parameter)=0]"
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds;", "")]
			public global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_include_Lcom_tencent_mapsdk_raster_model_LatLng_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds.Builder']/method[@name='include' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
			[Register ("include", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/LatLngBounds$Builder;", "")]
			public global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder Include (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
			{
				if (id_include_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
					id_include_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "include", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/LatLngBounds$Builder;");
				global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder> (JNIEnv.CallObjectMethod  (Handle, id_include_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/LatLngBounds", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LatLngBounds); }
		}

		protected LatLngBounds (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/constructor[@name='LatLngBounds' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register (".ctor", "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)V", "")]
		public LatLngBounds (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LatLngBounds)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_ctor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getNortheast;
#pragma warning disable 0169
		static Delegate GetGetNortheastHandler ()
		{
			if (cb_getNortheast == null)
				cb_getNortheast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNortheast);
			return cb_getNortheast;
		}

		static IntPtr n_GetNortheast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Northeast);
		}
#pragma warning restore 0169

		static IntPtr id_getNortheast;
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.LatLng Northeast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='getNortheast' and count(parameter)=0]"
			[Register ("getNortheast", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetNortheastHandler")]
			get {
				if (id_getNortheast == IntPtr.Zero)
					id_getNortheast = JNIEnv.GetMethodID (class_ref, "getNortheast", "()Lcom/tencent/mapsdk/raster/model/LatLng;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getNortheast), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNortheast", "()Lcom/tencent/mapsdk/raster/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSouthwest;
#pragma warning disable 0169
		static Delegate GetGetSouthwestHandler ()
		{
			if (cb_getSouthwest == null)
				cb_getSouthwest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSouthwest);
			return cb_getSouthwest;
		}

		static IntPtr n_GetSouthwest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Southwest);
		}
#pragma warning restore 0169

		static IntPtr id_getSouthwest;
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.LatLng Southwest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='getSouthwest' and count(parameter)=0]"
			[Register ("getSouthwest", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetSouthwestHandler")]
			get {
				if (id_getSouthwest == IntPtr.Zero)
					id_getSouthwest = JNIEnv.GetMethodID (class_ref, "getSouthwest", "()Lcom/tencent/mapsdk/raster/model/LatLng;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getSouthwest), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSouthwest", "()Lcom/tencent/mapsdk/raster/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_builder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds$Builder;", "")]
		public static global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder InvokeBuilder ()
		{
			if (id_builder == IntPtr.Zero)
				id_builder = JNIEnv.GetStaticMethodID (class_ref, "builder", "()Lcom/tencent/mapsdk/raster/model/LatLngBounds$Builder;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_contains_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_contains_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_contains_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_contains_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static bool n_Contains_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("contains", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Z", "GetContains_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual bool Contains (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_contains_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_contains_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_Handler ()
		{
			if (cb_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ == null)
				cb_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_);
			return cb_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
		}

		static bool n_Contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLngBounds']]"
		[Register ("contains", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Z", "GetContains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_Handler")]
		public virtual bool Contains (global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0)
		{
			if (id_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ == IntPtr.Zero)
				id_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Lcom_tencent_mapsdk_raster_model_LatLngBounds_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Z"), new JValue (p0));
			return __ret;
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_hashCode);
		}

		static Delegate cb_including_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetIncluding_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_including_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_including_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Including_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_including_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static IntPtr n_Including_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Including (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_including_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='including' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("including", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/LatLngBounds;", "GetIncluding_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds Including (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_including_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_including_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "including", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/LatLngBounds;");

			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (JNIEnv.CallObjectMethod  (Handle, id_including_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "including", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/LatLngBounds;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetIntersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_Handler ()
		{
			if (cb_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ == null)
				cb_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_);
			return cb_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
		}

		static bool n_Intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Intersects (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='intersects' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLngBounds']]"
		[Register ("intersects", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Z", "GetIntersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_Handler")]
		public virtual bool Intersects (global::Com.Tencent.Mapsdk.Raster.Model.LatLngBounds p0)
		{
			if (id_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ == IntPtr.Zero)
				id_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_ = JNIEnv.GetMethodID (class_ref, "intersects", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_intersects_Lcom_tencent_mapsdk_raster_model_LatLngBounds_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "intersects", "(Lcom/tencent/mapsdk/raster/model/LatLngBounds;)Z"), new JValue (p0));
			return __ret;
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='LatLngBounds']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}
}
