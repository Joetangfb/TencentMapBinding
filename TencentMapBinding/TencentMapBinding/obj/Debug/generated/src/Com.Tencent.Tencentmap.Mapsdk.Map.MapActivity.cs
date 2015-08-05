using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapActivity']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/MapActivity", DoNotGenerateAcw=true)]
	public abstract partial class MapActivity : global::Android.App.Activity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/MapActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapActivity); }
		}

		protected MapActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapActivity']/constructor[@name='MapActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MapActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapActivity)) {
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

		static Delegate cb_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetSetMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static void n_SetMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMapView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapActivity']/method[@name='setMapView' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("setMapView", "(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V", "GetSetMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual void SetMapView (global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p0)
		{
			if (id_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == IntPtr.Zero)
				id_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNIEnv.GetMethodID (class_ref, "setMapView", "(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapView", "(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V"), new JValue (p0));
		}

	}

	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/MapActivity", DoNotGenerateAcw=true)]
	internal partial class MapActivityInvoker : MapActivity {

		public MapActivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapActivityInvoker); }
		}

	}

}
