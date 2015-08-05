using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='OnMarkerPressListener']"
	[Register ("com/tencent/tencentmap/mapsdk/map/OnMarkerPressListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.IOnMarkerPressListenerInvoker")]
	public partial interface IOnMarkerPressListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='OnMarkerPressListener']/method[@name='onMarkerPressed' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.Marker']]"
		[Register ("onMarkerPressed", "(Lcom/tencent/mapsdk/raster/model/Marker;)V", "GetOnMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.IOnMarkerPressListenerInvoker, TencentMapBinding")]
		void OnMarkerPressed (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0);

	}

	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/OnMarkerPressListener", DoNotGenerateAcw=true)]
	internal class IOnMarkerPressListenerInvoker : global::Java.Lang.Object, IOnMarkerPressListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/OnMarkerPressListener");
		IntPtr class_ref;

		public static IOnMarkerPressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnMarkerPressListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.OnMarkerPressListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnMarkerPressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnMarkerPressListenerInvoker); }
		}

		static Delegate cb_onMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_;
#pragma warning disable 0169
		static Delegate GetOnMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_Handler ()
		{
			if (cb_onMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_ == null)
				cb_onMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_);
			return cb_onMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_;
		}

		static void n_OnMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMarkerPressListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMarkerPressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMarkerPressed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_;
		public void OnMarkerPressed (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
		{
			if (id_onMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_ == IntPtr.Zero)
				id_onMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerPressed", "(Lcom/tencent/mapsdk/raster/model/Marker;)V");
			JNIEnv.CallVoidMethod (Handle, id_onMarkerPressed_Lcom_tencent_mapsdk_raster_model_Marker_, new JValue (p0));
		}

	}

	public partial class MarkerPressEventArgs : global::System.EventArgs {

		public MarkerPressEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
		{
			this.p0 = p0;
		}

		global::Com.Tencent.Mapsdk.Raster.Model.Marker p0;
		public global::Com.Tencent.Mapsdk.Raster.Model.Marker P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/OnMarkerPressListenerImplementor")]
	internal sealed class IOnMarkerPressListenerImplementor : global::Java.Lang.Object, IOnMarkerPressListener {

		object sender;

		public IOnMarkerPressListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/OnMarkerPressListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MarkerPressEventArgs> Handler;
#pragma warning restore 0649

		public void OnMarkerPressed (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MarkerPressEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnMarkerPressListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
