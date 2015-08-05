using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/Projection", DoNotGenerateAcw=true)]
	public partial class Projection : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/Projection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Projection); }
		}

		protected Projection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getLatitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLatitudeSpanHandler ()
		{
			if (cb_getLatitudeSpan == null)
				cb_getLatitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatitudeSpan);
			return cb_getLatitudeSpan;
		}

		static int n_GetLatitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeSpan;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitudeSpan;
		public virtual int LatitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='getLatitudeSpan' and count(parameter)=0]"
			[Register ("getLatitudeSpan", "()I", "GetGetLatitudeSpanHandler")]
			get {
				if (id_getLatitudeSpan == IntPtr.Zero)
					id_getLatitudeSpan = JNIEnv.GetMethodID (class_ref, "getLatitudeSpan", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLatitudeSpan);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitudeSpan", "()I"));
			}
		}

		static Delegate cb_getLongitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLongitudeSpanHandler ()
		{
			if (cb_getLongitudeSpan == null)
				cb_getLongitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLongitudeSpan);
			return cb_getLongitudeSpan;
		}

		static int n_GetLongitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeSpan;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitudeSpan;
		public virtual int LongitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='getLongitudeSpan' and count(parameter)=0]"
			[Register ("getLongitudeSpan", "()I", "GetGetLongitudeSpanHandler")]
			get {
				if (id_getLongitudeSpan == IntPtr.Zero)
					id_getLongitudeSpan = JNIEnv.GetMethodID (class_ref, "getLongitudeSpan", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLongitudeSpan);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitudeSpan", "()I"));
			}
		}

		static Delegate cb_getScalePerPixel;
#pragma warning disable 0169
		static Delegate GetGetScalePerPixelHandler ()
		{
			if (cb_getScalePerPixel == null)
				cb_getScalePerPixel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScalePerPixel);
			return cb_getScalePerPixel;
		}

		static float n_GetScalePerPixel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScalePerPixel;
		}
#pragma warning restore 0169

		static IntPtr id_getScalePerPixel;
		public virtual float ScalePerPixel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='getScalePerPixel' and count(parameter)=0]"
			[Register ("getScalePerPixel", "()F", "GetGetScalePerPixelHandler")]
			get {
				if (id_getScalePerPixel == IntPtr.Zero)
					id_getScalePerPixel = JNIEnv.GetMethodID (class_ref, "getScalePerPixel", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getScalePerPixel);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScalePerPixel", "()F"));
			}
		}

		static Delegate cb_getVisibleRegion;
#pragma warning disable 0169
		static Delegate GetGetVisibleRegionHandler ()
		{
			if (cb_getVisibleRegion == null)
				cb_getVisibleRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVisibleRegion);
			return cb_getVisibleRegion;
		}

		static IntPtr n_GetVisibleRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VisibleRegion);
		}
#pragma warning restore 0169

		static IntPtr id_getVisibleRegion;
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.VisibleRegion VisibleRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='getVisibleRegion' and count(parameter)=0]"
			[Register ("getVisibleRegion", "()Lcom/tencent/mapsdk/raster/model/VisibleRegion;", "GetGetVisibleRegionHandler")]
			get {
				if (id_getVisibleRegion == IntPtr.Zero)
					id_getVisibleRegion = JNIEnv.GetMethodID (class_ref, "getVisibleRegion", "()Lcom/tencent/mapsdk/raster/model/VisibleRegion;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.VisibleRegion> (JNIEnv.CallObjectMethod  (Handle, id_getVisibleRegion), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.VisibleRegion> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVisibleRegion", "()Lcom/tencent/mapsdk/raster/model/VisibleRegion;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetDistanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler ()
		{
			if (cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == null)
				cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_DistanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_);
			return cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		}

		static double n_DistanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.DistanceBetween (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='distanceBetween' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='com.tencent.mapsdk.raster.model.GeoPoint']]"
		[Register ("distanceBetween", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/mapsdk/raster/model/GeoPoint;)D", "GetDistanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler")]
		public virtual double DistanceBetween (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p1)
		{
			if (id_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == IntPtr.Zero)
				id_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "distanceBetween", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/mapsdk/raster/model/GeoPoint;)D");

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "distanceBetween", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/mapsdk/raster/model/GeoPoint;)D"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetDistanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_DistanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static double n_DistanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p1, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.DistanceBetween (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='distanceBetween' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("distanceBetween", "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)D", "GetDistanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual double DistanceBetween (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1)
		{
			if (id_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "distanceBetween", "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)D");

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "distanceBetween", "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)D"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_fromPixels_II;
#pragma warning disable 0169
		static Delegate GetFromPixels_IIHandler ()
		{
			if (cb_fromPixels_II == null)
				cb_fromPixels_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_FromPixels_II);
			return cb_fromPixels_II;
		}

		static IntPtr n_FromPixels_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromPixels (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_fromPixels_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='fromPixels' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("fromPixels", "(II)Lcom/tencent/mapsdk/raster/model/GeoPoint;", "GetFromPixels_IIHandler")]
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint FromPixels (int p0, int p1)
		{
			if (id_fromPixels_II == IntPtr.Zero)
				id_fromPixels_II = JNIEnv.GetMethodID (class_ref, "fromPixels", "(II)Lcom/tencent/mapsdk/raster/model/GeoPoint;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_fromPixels_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromPixels", "(II)Lcom/tencent/mapsdk/raster/model/GeoPoint;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_fromScreenLocation_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetFromScreenLocation_Landroid_graphics_Point_Handler ()
		{
			if (cb_fromScreenLocation_Landroid_graphics_Point_ == null)
				cb_fromScreenLocation_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromScreenLocation_Landroid_graphics_Point_);
			return cb_fromScreenLocation_Landroid_graphics_Point_;
		}

		static IntPtr n_FromScreenLocation_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromScreenLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fromScreenLocation_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='fromScreenLocation' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("fromScreenLocation", "(Landroid/graphics/Point;)Lcom/tencent/mapsdk/raster/model/LatLng;", "GetFromScreenLocation_Landroid_graphics_Point_Handler")]
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.LatLng FromScreenLocation (global::Android.Graphics.Point p0)
		{
			if (id_fromScreenLocation_Landroid_graphics_Point_ == IntPtr.Zero)
				id_fromScreenLocation_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "fromScreenLocation", "(Landroid/graphics/Point;)Lcom/tencent/mapsdk/raster/model/LatLng;");

			global::Com.Tencent.Mapsdk.Raster.Model.LatLng __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_fromScreenLocation_Landroid_graphics_Point_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromScreenLocation", "(Landroid/graphics/Point;)Lcom/tencent/mapsdk/raster/model/LatLng;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_metersToEquatorPixels_F;
#pragma warning disable 0169
		static Delegate GetMetersToEquatorPixels_FHandler ()
		{
			if (cb_metersToEquatorPixels_F == null)
				cb_metersToEquatorPixels_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_MetersToEquatorPixels_F);
			return cb_metersToEquatorPixels_F;
		}

		static float n_MetersToEquatorPixels_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MetersToEquatorPixels (p0);
		}
#pragma warning restore 0169

		static IntPtr id_metersToEquatorPixels_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='metersToEquatorPixels' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("metersToEquatorPixels", "(F)F", "GetMetersToEquatorPixels_FHandler")]
		public virtual float MetersToEquatorPixels (float p0)
		{
			if (id_metersToEquatorPixels_F == IntPtr.Zero)
				id_metersToEquatorPixels_F = JNIEnv.GetMethodID (class_ref, "metersToEquatorPixels", "(F)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_metersToEquatorPixels_F, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "metersToEquatorPixels", "(F)F"), new JValue (p0));
		}

		static Delegate cb_metersToPixels_DD;
#pragma warning disable 0169
		static Delegate GetMetersToPixels_DDHandler ()
		{
			if (cb_metersToPixels_DD == null)
				cb_metersToPixels_DD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, float>) n_MetersToPixels_DD);
			return cb_metersToPixels_DD;
		}

		static float n_MetersToPixels_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MetersToPixels (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_metersToPixels_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='metersToPixels' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("metersToPixels", "(DD)F", "GetMetersToPixels_DDHandler")]
		public virtual float MetersToPixels (double p0, double p1)
		{
			if (id_metersToPixels_DD == IntPtr.Zero)
				id_metersToPixels_DD = JNIEnv.GetMethodID (class_ref, "metersToPixels", "(DD)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_metersToPixels_DD, new JValue (p0), new JValue (p1));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "metersToPixels", "(DD)F"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetToPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_Handler ()
		{
			if (cb_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_ == null)
				cb_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ToPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_);
			return cb_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_;
		}

		static IntPtr n_ToPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToPixels (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='toPixels' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("toPixels", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;", "GetToPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_Handler")]
		public virtual global::Android.Graphics.Point ToPixels (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Android.Graphics.Point p1)
		{
			if (id_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_ == IntPtr.Zero)
				id_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "toPixels", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toPixels", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetToScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static IntPtr n_ToScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToScreenLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='toScreenLocation' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("toScreenLocation", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Landroid/graphics/Point;", "GetToScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual global::Android.Graphics.Point ToScreenLocation (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "toScreenLocation", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toScreenLocation", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Landroid/graphics/Point;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
