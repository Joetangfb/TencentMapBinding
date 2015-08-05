using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay", DoNotGenerateAcw=true)]
	public abstract partial class ItemizedOverlay : global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.BoundPos']"
		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos", DoNotGenerateAcw=true)]
		public sealed partial class BoundPos : global::Java.Lang.Enum {


			static IntPtr Center_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.BoundPos']/field[@name='Center']"
			[Register ("Center")]
			public static global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos Center {
				get {
					if (Center_jfieldId == IntPtr.Zero)
						Center_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Center", "Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Center_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (Center_jfieldId == IntPtr.Zero)
						Center_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Center", "Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, Center_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CenterBottom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.BoundPos']/field[@name='CenterBottom']"
			[Register ("CenterBottom")]
			public static global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos CenterBottom {
				get {
					if (CenterBottom_jfieldId == IntPtr.Zero)
						CenterBottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CenterBottom", "Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CenterBottom_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CenterBottom_jfieldId == IntPtr.Zero)
						CenterBottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CenterBottom", "Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CenterBottom_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr Normal_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.BoundPos']/field[@name='Normal']"
			[Register ("Normal")]
			public static global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos Normal {
				get {
					if (Normal_jfieldId == IntPtr.Zero)
						Normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Normal", "Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Normal_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.BoundPos> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (Normal_jfieldId == IntPtr.Zero)
						Normal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Normal", "Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, Normal_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$BoundPos", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BoundPos); }
			}

			internal BoundPos (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']"
		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$ItemsContainer", DoNotGenerateAcw=true)]
		public partial class ItemsContainer : global::Java.Lang.Object, global::Java.Util.IComparator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$ItemsContainer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ItemsContainer); }
			}

			protected ItemsContainer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/constructor[@name='ItemizedOverlay.ItemsContainer' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.ItemizedOverlay']]"
			[Register (".ctor", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay;)V", "")]
			public ItemsContainer (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ItemsContainer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_ == IntPtr.Zero)
					id_ctor_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_, new JValue (__self));
			}

			static Delegate cb_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
			static Delegate GetHandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
			{
				if (cb_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
					cb_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
				return cb_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
			}

			static bool n_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.HandleLongPress (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='HandleLongPress' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
			[Register ("HandleLongPress", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z", "GetHandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
			public virtual bool HandleLongPress (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
			{
				if (id_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == IntPtr.Zero)
					id_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNIEnv.GetMethodID (class_ref, "HandleLongPress", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_HandleLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_, new JValue (p0), new JValue (p1));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "HandleLongPress", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z"), new JValue (p0), new JValue (p1));
				return __ret;
			}

			static Delegate cb_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
			static Delegate GetHandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
			{
				if (cb_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
					cb_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
				return cb_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
			}

			static bool n_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.HandleTap (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='HandleTap' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
			[Register ("HandleTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z", "GetHandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
			public virtual bool HandleTap (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
			{
				if (id_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == IntPtr.Zero)
					id_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNIEnv.GetMethodID (class_ref, "HandleTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_HandleTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_, new JValue (p0), new JValue (p1));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "HandleTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z"), new JValue (p0), new JValue (p1));
				return __ret;
			}

			static Delegate cb_compare_Ljava_lang_Integer_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetCompare_Ljava_lang_Integer_Ljava_lang_Integer_Handler ()
			{
				if (cb_compare_Ljava_lang_Integer_Ljava_lang_Integer_ == null)
					cb_compare_Ljava_lang_Integer_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Ljava_lang_Integer_Ljava_lang_Integer_);
				return cb_compare_Ljava_lang_Integer_Ljava_lang_Integer_;
			}

			static int n_Compare_Ljava_lang_Integer_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Compare (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compare_Ljava_lang_Integer_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Integer']]"
			[Register ("compare", "(Ljava/lang/Integer;Ljava/lang/Integer;)I", "GetCompare_Ljava_lang_Integer_Ljava_lang_Integer_Handler")]
			public virtual int Compare (global::Java.Lang.Integer p0, global::Java.Lang.Integer p1)
			{
				if (id_compare_Ljava_lang_Integer_Ljava_lang_Integer_ == IntPtr.Zero)
					id_compare_Ljava_lang_Integer_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "compare", "(Ljava/lang/Integer;Ljava/lang/Integer;)I");

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compare_Ljava_lang_Integer_Ljava_lang_Integer_, new JValue (p0), new JValue (p1));
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compare", "(Ljava/lang/Integer;Ljava/lang/Integer;)I"), new JValue (p0), new JValue (p1));
				return __ret;
			}

			static Delegate cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler ()
			{
				if (cb_compare_Ljava_lang_Object_Ljava_lang_Object_ == null)
					cb_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Ljava_lang_Object_Ljava_lang_Object_);
				return cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
			}

			static int n_Compare_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Compare (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
			[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler")]
			public virtual int Compare (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				if (id_compare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compare_Ljava_lang_Object_Ljava_lang_Object_, new JValue (p0), new JValue (p1));
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"), new JValue (p0), new JValue (p1));
				return __ret;
			}

			static Delegate cb_count;
#pragma warning disable 0169
			static Delegate GetCountHandler ()
			{
				if (cb_count == null)
					cb_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Count);
				return cb_count;
			}

			static int n_Count (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Count ();
			}
#pragma warning restore 0169

			static IntPtr id_count;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='count' and count(parameter)=0]"
			[Register ("count", "()I", "GetCountHandler")]
			public virtual int Count ()
			{
				if (id_count == IntPtr.Zero)
					id_count = JNIEnv.GetMethodID (class_ref, "count", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_count);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "count", "()I"));
			}

			static Delegate cb_getPosByRank_I;
#pragma warning disable 0169
			static Delegate GetGetPosByRank_IHandler ()
			{
				if (cb_getPosByRank_I == null)
					cb_getPosByRank_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetPosByRank_I);
				return cb_getPosByRank_I;
			}

			static int n_GetPosByRank_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetPosByRank (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getPosByRank_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='getPosByRank' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getPosByRank", "(I)I", "GetGetPosByRank_IHandler")]
			public virtual int GetPosByRank (int p0)
			{
				if (id_getPosByRank_I == IntPtr.Zero)
					id_getPosByRank_I = JNIEnv.GetMethodID (class_ref, "getPosByRank", "(I)I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPosByRank_I, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosByRank", "(I)I"), new JValue (p0));
			}

			static Delegate cb_getSpan_Z;
#pragma warning disable 0169
			static Delegate GetGetSpan_ZHandler ()
			{
				if (cb_getSpan_Z == null)
					cb_getSpan_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, int>) n_GetSpan_Z);
				return cb_getSpan_Z;
			}

			static int n_GetSpan_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetSpan (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getSpan_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='getSpan' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("getSpan", "(Z)I", "GetGetSpan_ZHandler")]
			public virtual int GetSpan (bool p0)
			{
				if (id_getSpan_Z == IntPtr.Zero)
					id_getSpan_Z = JNIEnv.GetMethodID (class_ref, "getSpan", "(Z)I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSpan_Z, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpan", "(Z)I"), new JValue (p0));
			}

			static Delegate cb_release;
#pragma warning disable 0169
			static Delegate GetReleaseHandler ()
			{
				if (cb_release == null)
					cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
				return cb_release;
			}

			static void n_Release (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.ItemsContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Release ();
			}
#pragma warning restore 0169

			static IntPtr id_release;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay.ItemsContainer']/method[@name='release' and count(parameter)=0]"
			[Register ("release", "()V", "GetReleaseHandler")]
			public virtual void Release ()
			{
				if (id_release == IntPtr.Zero)
					id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='ItemizedOverlay.OnFocusChangeListener']"
		[Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay/IOnFocusChangeListenerInvoker")]
		public partial interface IOnFocusChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='ItemizedOverlay.OnFocusChangeListener']/method[@name='onFocusChanged' and count(parameter)=2 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.ItemizedOverlay'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.OverlayItem']]"
			[Register ("onFocusChanged", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay;Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;)V", "GetOnFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay/IOnFocusChangeListenerInvoker, TencentMapBinding")]
			void OnFocusChanged (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1);

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener", DoNotGenerateAcw=true)]
		internal class IOnFocusChangeListenerInvoker : global::Java.Lang.Object, IOnFocusChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener");
			IntPtr class_ref;

			public static IOnFocusChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnFocusChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.ItemizedOverlay.OnFocusChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnFocusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnFocusChangeListenerInvoker); }
			}

			static Delegate cb_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
#pragma warning disable 0169
			static Delegate GetOnFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_Handler ()
			{
				if (cb_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ == null)
					cb_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_);
				return cb_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
			}

			static void n_OnFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFocusChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
			public void OnFocusChanged (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1)
			{
				if (id_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ == IntPtr.Zero)
					id_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ = JNIEnv.GetMethodID (class_ref, "onFocusChanged", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay;Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;)V");
				JNIEnv.CallVoidMethod (Handle, id_onFocusChanged_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class FocusChangeEventArgs : global::System.EventArgs {

			public FocusChangeEventArgs (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0;
			public global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay P0 {
				get { return p0; }
			}

			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1;
			public global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/ItemizedOverlay_OnFocusChangeListenerImplementor")]
		internal sealed class IOnFocusChangeListenerImplementor : global::Java.Lang.Object, IOnFocusChangeListener {

			object sender;

			public IOnFocusChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/ItemizedOverlay_OnFocusChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FocusChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnFocusChanged (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new FocusChangeEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnFocusChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemizedOverlay); }
		}

		protected ItemizedOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/constructor[@name='ItemizedOverlay' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public ItemizedOverlay (global::Android.Graphics.Drawables.Drawable p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ItemizedOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/drawable/Drawable;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/drawable/Drawable;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_ctor_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_drawable_Drawable_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_drawable_Drawable_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/constructor[@name='ItemizedOverlay' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ItemizedOverlay (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ItemizedOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_getCenter;
#pragma warning disable 0169
		static Delegate GetGetCenterHandler ()
		{
			if (cb_getCenter == null)
				cb_getCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenter);
			return cb_getCenter;
		}

		static IntPtr n_GetCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Center);
		}
#pragma warning restore 0169

		static IntPtr id_getCenter;
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/tencent/mapsdk/raster/model/GeoPoint;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lcom/tencent/mapsdk/raster/model/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCenter", "()Lcom/tencent/mapsdk/raster/model/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFocus;
#pragma warning disable 0169
		static Delegate GetGetFocusHandler ()
		{
			if (cb_getFocus == null)
				cb_getFocus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocus);
			return cb_getFocus;
		}

		static IntPtr n_GetFocus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Focus);
		}
#pragma warning restore 0169

		static Delegate cb_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
#pragma warning disable 0169
		static Delegate GetSetFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_Handler ()
		{
			if (cb_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ == null)
				cb_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_);
			return cb_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
		}

		static void n_SetFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Focus = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFocus;
		static IntPtr id_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_;
		public virtual global::Java.Lang.Object Focus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getFocus' and count(parameter)=0]"
			[Register ("getFocus", "()Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;", "GetGetFocusHandler")]
			get {
				if (id_getFocus == IntPtr.Zero)
					id_getFocus = JNIEnv.GetMethodID (class_ref, "getFocus", "()Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getFocus), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFocus", "()Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='setFocus' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.OverlayItem']]"
			[Register ("setFocus", "(Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;)V", "GetSetFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_Handler")]
			set {
				if (id_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ == IntPtr.Zero)
					id_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_ = JNIEnv.GetMethodID (class_ref, "setFocus", "(Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFocus_Lcom_tencent_tencentmap_mapsdk_map_OverlayItem_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFocus", "(Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getLastFocusedIndex;
		public int LastFocusedIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getLastFocusedIndex' and count(parameter)=0]"
			[Register ("getLastFocusedIndex", "()I", "GetGetLastFocusedIndexHandler")]
			get {
				if (id_getLastFocusedIndex == IntPtr.Zero)
					id_getLastFocusedIndex = JNIEnv.GetMethodID (class_ref, "getLastFocusedIndex", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getLastFocusedIndex);
			}
		}

		static Delegate cb_getLatSpanE6;
#pragma warning disable 0169
		static Delegate GetGetLatSpanE6Handler ()
		{
			if (cb_getLatSpanE6 == null)
				cb_getLatSpanE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatSpanE6);
			return cb_getLatSpanE6;
		}

		static int n_GetLatSpanE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatSpanE6;
		}
#pragma warning restore 0169

		static IntPtr id_getLatSpanE6;
		public virtual int LatSpanE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getLatSpanE6' and count(parameter)=0]"
			[Register ("getLatSpanE6", "()I", "GetGetLatSpanE6Handler")]
			get {
				if (id_getLatSpanE6 == IntPtr.Zero)
					id_getLatSpanE6 = JNIEnv.GetMethodID (class_ref, "getLatSpanE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLatSpanE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatSpanE6", "()I"));
			}
		}

		static Delegate cb_getLonSpanE6;
#pragma warning disable 0169
		static Delegate GetGetLonSpanE6Handler ()
		{
			if (cb_getLonSpanE6 == null)
				cb_getLonSpanE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLonSpanE6);
			return cb_getLonSpanE6;
		}

		static int n_GetLonSpanE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LonSpanE6;
		}
#pragma warning restore 0169

		static IntPtr id_getLonSpanE6;
		public virtual int LonSpanE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getLonSpanE6' and count(parameter)=0]"
			[Register ("getLonSpanE6", "()I", "GetGetLonSpanE6Handler")]
			get {
				if (id_getLonSpanE6 == IntPtr.Zero)
					id_getLonSpanE6 = JNIEnv.GetMethodID (class_ref, "getLonSpanE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLonSpanE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLonSpanE6", "()I"));
			}
		}

		static Delegate cb_isShadowEnable;
#pragma warning disable 0169
		static Delegate GetIsShadowEnableHandler ()
		{
			if (cb_isShadowEnable == null)
				cb_isShadowEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShadowEnable);
			return cb_isShadowEnable;
		}

		static bool n_IsShadowEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetShadowEnable_ZHandler ()
		{
			if (cb_setShadowEnable_Z == null)
				cb_setShadowEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShadowEnable_Z);
			return cb_setShadowEnable_Z;
		}

		static void n_SetShadowEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowEnable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShadowEnable;
		static IntPtr id_setShadowEnable_Z;
		public virtual bool ShadowEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='isShadowEnable' and count(parameter)=0]"
			[Register ("isShadowEnable", "()Z", "GetIsShadowEnableHandler")]
			get {
				if (id_isShadowEnable == IntPtr.Zero)
					id_isShadowEnable = JNIEnv.GetMethodID (class_ref, "isShadowEnable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShadowEnable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShadowEnable", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='setShadowEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShadowEnable", "(Z)V", "GetSetShadowEnable_ZHandler")]
			set {
				if (id_setShadowEnable_Z == IntPtr.Zero)
					id_setShadowEnable_Z = JNIEnv.GetMethodID (class_ref, "setShadowEnable", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShadowEnable_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShadowEnable", "(Z)V"), new JValue (value));
			}
		}

		static IntPtr id_boundCenter_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='boundCenter' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("boundCenter", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "")]
		public static global::Android.Graphics.Drawables.Drawable BoundCenter (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_boundCenter_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_boundCenter_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetStaticMethodID (class_ref, "boundCenter", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;");
			global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_boundCenter_Landroid_graphics_drawable_Drawable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_boundCenterBottom_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='boundCenterBottom' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("boundCenterBottom", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "")]
		public static global::Android.Graphics.Drawables.Drawable BoundCenterBottom (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_boundCenterBottom_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_boundCenterBottom_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetStaticMethodID (class_ref, "boundCenterBottom", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;");
			global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_boundCenterBottom_Landroid_graphics_drawable_Drawable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_createItem_I;
#pragma warning disable 0169
		static Delegate GetCreateItem_IHandler ()
		{
			if (cb_createItem_I == null)
				cb_createItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_CreateItem_I);
			return cb_createItem_I;
		}

		static IntPtr n_CreateItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateItem (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='createItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createItem", "(I)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;", "GetCreateItem_IHandler")]
		protected abstract global::Java.Lang.Object CreateItem (int p0);

		static Delegate cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='draw' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lcom/tencent/tencentmap/mapsdk/map/MapView;)V", "GetDraw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual void Draw (global::Android.Graphics.Canvas p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
		{
			if (id_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lcom/tencent/tencentmap/mapsdk/map/MapView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lcom/tencent/tencentmap/mapsdk/map/MapView;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getIndexToDraw_I;
#pragma warning disable 0169
		static Delegate GetGetIndexToDraw_IHandler ()
		{
			if (cb_getIndexToDraw_I == null)
				cb_getIndexToDraw_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetIndexToDraw_I);
			return cb_getIndexToDraw_I;
		}

		static int n_GetIndexToDraw_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexToDraw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getIndexToDraw_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getIndexToDraw' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIndexToDraw", "(I)I", "GetGetIndexToDraw_IHandler")]
		protected virtual int GetIndexToDraw (int p0)
		{
			if (id_getIndexToDraw_I == IntPtr.Zero)
				id_getIndexToDraw_I = JNIEnv.GetMethodID (class_ref, "getIndexToDraw", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getIndexToDraw_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexToDraw", "(I)I"), new JValue (p0));
		}

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;", "")]
		public global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_nextFocus_Z;
#pragma warning disable 0169
		static Delegate GetNextFocus_ZHandler ()
		{
			if (cb_nextFocus_Z == null)
				cb_nextFocus_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_NextFocus_Z);
			return cb_nextFocus_Z;
		}

		static IntPtr n_NextFocus_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextFocus (p0));
		}
#pragma warning restore 0169

		static IntPtr id_nextFocus_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='nextFocus' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("nextFocus", "(Z)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;", "GetNextFocus_ZHandler")]
		public virtual global::Java.Lang.Object NextFocus (bool p0)
		{
			if (id_nextFocus_Z == IntPtr.Zero)
				id_nextFocus_Z = JNIEnv.GetMethodID (class_ref, "nextFocus", "(Z)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_nextFocus_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextFocus", "(Z)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onTap_I;
#pragma warning disable 0169
		static Delegate GetOnTap_IHandler ()
		{
			if (cb_onTap_I == null)
				cb_onTap_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_OnTap_I);
			return cb_onTap_I;
		}

		static bool n_OnTap_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnTap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onTap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='onTap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTap", "(I)Z", "GetOnTap_IHandler")]
		protected virtual bool OnTap (int p0)
		{
			if (id_onTap_I == IntPtr.Zero)
				id_onTap_I = JNIEnv.GetMethodID (class_ref, "onTap", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_onTap_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTap", "(I)Z"), new JValue (p0));
		}

		static IntPtr id_populate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='populate' and count(parameter)=0]"
		[Register ("populate", "()V", "")]
		protected void Populate ()
		{
			if (id_populate == IntPtr.Zero)
				id_populate = JNIEnv.GetMethodID (class_ref, "populate", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_populate);
		}

		static Delegate cb_setDrawFocusedItem_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawFocusedItem_ZHandler ()
		{
			if (cb_setDrawFocusedItem_Z == null)
				cb_setDrawFocusedItem_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawFocusedItem_Z);
			return cb_setDrawFocusedItem_Z;
		}

		static void n_SetDrawFocusedItem_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawFocusedItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDrawFocusedItem_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='setDrawFocusedItem' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawFocusedItem", "(Z)V", "GetSetDrawFocusedItem_ZHandler")]
		public virtual void SetDrawFocusedItem (bool p0)
		{
			if (id_setDrawFocusedItem_Z == IntPtr.Zero)
				id_setDrawFocusedItem_Z = JNIEnv.GetMethodID (class_ref, "setDrawFocusedItem", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDrawFocusedItem_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDrawFocusedItem", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setLastFocusedIndex_I;
#pragma warning disable 0169
		static Delegate GetSetLastFocusedIndex_IHandler ()
		{
			if (cb_setLastFocusedIndex_I == null)
				cb_setLastFocusedIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLastFocusedIndex_I);
			return cb_setLastFocusedIndex_I;
		}

		static void n_SetLastFocusedIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLastFocusedIndex (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLastFocusedIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='setLastFocusedIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLastFocusedIndex", "(I)V", "GetSetLastFocusedIndex_IHandler")]
		protected virtual void SetLastFocusedIndex (int p0)
		{
			if (id_setLastFocusedIndex_I == IntPtr.Zero)
				id_setLastFocusedIndex_I = JNIEnv.GetMethodID (class_ref, "setLastFocusedIndex", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLastFocusedIndex_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastFocusedIndex", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_Handler ()
		{
			if (cb_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_ == null)
				cb_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_);
			return cb_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_;
		}

		static void n_SetOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnFocusChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='setOnFocusChangeListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.ItemizedOverlay.OnFocusChangeListener']]"
		[Register ("setOnFocusChangeListener", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener;)V", "GetSetOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_Handler")]
		public virtual void SetOnFocusChangeListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener p0)
		{
			if (id_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_ == IntPtr.Zero)
				id_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnFocusChangeListener", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnFocusChangeListener_Lcom_tencent_tencentmap_mapsdk_map_ItemizedOverlay_OnFocusChangeListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnFocusChangeListener", "(Lcom/tencent/tencentmap/mapsdk/map/ItemizedOverlay$OnFocusChangeListener;)V"), new JValue (p0));
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public abstract int Size ();

#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.FocusChangeEventArgs> FocusChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListenerImplementor>(
						ref weak_implementor_SetOnFocusChangeListener,
						__CreateIOnFocusChangeListenerImplementor,
						SetOnFocusChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListenerImplementor>(
						ref weak_implementor_SetOnFocusChangeListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListenerImplementor.__IsEmpty,
						__v => SetOnFocusChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnFocusChangeListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListenerImplementor __CreateIOnFocusChangeListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.ItemizedOverlay.IOnFocusChangeListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/ItemizedOverlay", DoNotGenerateAcw=true)]
	internal partial class ItemizedOverlayInvoker : ItemizedOverlay {

		public ItemizedOverlayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemizedOverlayInvoker); }
		}

		static IntPtr id_createItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='createItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createItem", "(I)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;", "GetCreateItem_IHandler")]
		protected override global::Java.Lang.Object CreateItem (int p0)
		{
			if (id_createItem_I == IntPtr.Zero)
				id_createItem_I = JNIEnv.GetMethodID (class_ref, "createItem", "(I)Lcom/tencent/tencentmap/mapsdk/map/OverlayItem;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_createItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='ItemizedOverlay']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_size);
		}

	}

}
