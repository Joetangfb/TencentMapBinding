using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='OnMapLongPressListener']"
	[Register ("com/tencent/tencentmap/mapsdk/map/OnMapLongPressListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListenerInvoker")]
	public partial interface IOnMapLongPressListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='OnMapLongPressListener']/method[@name='onMapLongPress' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("onMapLongPress", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetOnMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListenerInvoker, TencentMapBinding")]
		void OnMapLongPress (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0);

	}

	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/OnMapLongPressListener", DoNotGenerateAcw=true)]
	internal class IOnMapLongPressListenerInvoker : global::Java.Lang.Object, IOnMapLongPressListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/OnMapLongPressListener");
		IntPtr class_ref;

		public static IOnMapLongPressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnMapLongPressListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.OnMapLongPressListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnMapLongPressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnMapLongPressListenerInvoker); }
		}

		static Delegate cb_onMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetOnMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_onMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_onMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_onMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static void n_OnMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMapLongPress (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_;
		public void OnMapLongPress (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_onMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_onMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapLongPress", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V");
			JNIEnv.CallVoidMethod (Handle, id_onMapLongPress_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0));
		}

	}

	public partial class MapLongPressEventArgs : global::System.EventArgs {

		public MapLongPressEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			this.p0 = p0;
		}

		global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/OnMapLongPressListenerImplementor")]
	internal sealed class IOnMapLongPressListenerImplementor : global::Java.Lang.Object, IOnMapLongPressListener {

		object sender;

		public IOnMapLongPressListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/OnMapLongPressListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MapLongPressEventArgs> Handler;
#pragma warning restore 0649

		public void OnMapLongPress (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MapLongPressEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnMapLongPressListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
