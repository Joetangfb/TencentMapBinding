using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/TencentMap", DoNotGenerateAcw=true)]
	public partial class TencentMap : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.InfoWindowAdapter']"
		[Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$InfoWindowAdapter", "", "Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IInfoWindowAdapterInvoker")]
		public partial interface IInfoWindowAdapter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.InfoWindowAdapter']/method[@name='getInfoWindow' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.Marker']]"
			[Register ("getInfoWindow", "(Lcom/tencent/mapsdk/raster/model/Marker;)Landroid/view/View;", "GetGetInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IInfoWindowAdapterInvoker, TencentMapBinding")]
			global::Android.Views.View GetInfoWindow (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.InfoWindowAdapter']/method[@name='onInfoWindowDettached' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.Marker'] and parameter[2][@type='android.view.View']]"
			[Register ("onInfoWindowDettached", "(Lcom/tencent/mapsdk/raster/model/Marker;Landroid/view/View;)V", "GetOnInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IInfoWindowAdapterInvoker, TencentMapBinding")]
			void OnInfoWindowDettached (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0, global::Android.Views.View p1);

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$InfoWindowAdapter", DoNotGenerateAcw=true)]
		internal class IInfoWindowAdapterInvoker : global::Java.Lang.Object, IInfoWindowAdapter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/TencentMap$InfoWindowAdapter");
			IntPtr class_ref;

			public static IInfoWindowAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInfoWindowAdapter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.TencentMap.InfoWindowAdapter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInfoWindowAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IInfoWindowAdapterInvoker); }
			}

			static Delegate cb_getInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_;
#pragma warning disable 0169
			static Delegate GetGetInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_Handler ()
			{
				if (cb_getInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_ == null)
					cb_getInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_);
				return cb_getInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_;
			}

			static IntPtr n_GetInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInfoWindow (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_;
			public global::Android.Views.View GetInfoWindow (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				if (id_getInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_ == IntPtr.Zero)
					id_getInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_ = JNIEnv.GetMethodID (class_ref, "getInfoWindow", "(Lcom/tencent/mapsdk/raster/model/Marker;)Landroid/view/View;");
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getInfoWindow_Lcom_tencent_mapsdk_raster_model_Marker_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_onInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_Handler ()
			{
				if (cb_onInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_ == null)
					cb_onInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_);
				return cb_onInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_;
			}

			static void n_OnInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnInfoWindowDettached (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_;
			public void OnInfoWindowDettached (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0, global::Android.Views.View p1)
			{
				if (id_onInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_ == IntPtr.Zero)
					id_onInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onInfoWindowDettached", "(Lcom/tencent/mapsdk/raster/model/Marker;Landroid/view/View;)V");
				JNIEnv.CallVoidMethod (Handle, id_onInfoWindowDettached_Lcom_tencent_mapsdk_raster_model_Marker_Landroid_view_View_, new JValue (p0), new JValue (p1));
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnInfoWindowClickListener']"
		[Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnInfoWindowClickListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnInfoWindowClickListenerInvoker")]
		public partial interface IOnInfoWindowClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnInfoWindowClickListener']/method[@name='onInfoWindowClick' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.Marker']]"
			[Register ("onInfoWindowClick", "(Lcom/tencent/mapsdk/raster/model/Marker;)V", "GetOnInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnInfoWindowClickListenerInvoker, TencentMapBinding")]
			void OnInfoWindowClick (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnInfoWindowClickListener", DoNotGenerateAcw=true)]
		internal class IOnInfoWindowClickListenerInvoker : global::Java.Lang.Object, IOnInfoWindowClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnInfoWindowClickListener");
			IntPtr class_ref;

			public static IOnInfoWindowClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnInfoWindowClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.TencentMap.OnInfoWindowClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnInfoWindowClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnInfoWindowClickListenerInvoker); }
			}

			static Delegate cb_onInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_Handler ()
			{
				if (cb_onInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_ == null)
					cb_onInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_);
				return cb_onInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_;
			}

			static void n_OnInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInfoWindowClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_;
			public void OnInfoWindowClick (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				if (id_onInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_ == IntPtr.Zero)
					id_onInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onInfoWindowClick", "(Lcom/tencent/mapsdk/raster/model/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onInfoWindowClick_Lcom_tencent_mapsdk_raster_model_Marker_, new JValue (p0));
			}

		}

		public partial class InfoWindowClickEventArgs : global::System.EventArgs {

			public InfoWindowClickEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Tencent.Mapsdk.Raster.Model.Marker p0;
			public global::Com.Tencent.Mapsdk.Raster.Model.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnInfoWindowClickListenerImplementor")]
		internal sealed class IOnInfoWindowClickListenerImplementor : global::Java.Lang.Object, IOnInfoWindowClickListener {

			object sender;

			public IOnInfoWindowClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnInfoWindowClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InfoWindowClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnInfoWindowClick (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new InfoWindowClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnInfoWindowClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMapCameraChangeListener']"
		[Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapCameraChangeListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMapCameraChangeListenerInvoker")]
		public partial interface IOnMapCameraChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMapCameraChangeListener']/method[@name='onCameraChange' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.CameraPosition']]"
			[Register ("onCameraChange", "(Lcom/tencent/mapsdk/raster/model/CameraPosition;)V", "GetOnCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMapCameraChangeListenerInvoker, TencentMapBinding")]
			void OnCameraChange (global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMapCameraChangeListener']/method[@name='onCameraChangeFinish' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.CameraPosition']]"
			[Register ("onCameraChangeFinish", "(Lcom/tencent/mapsdk/raster/model/CameraPosition;)V", "GetOnCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMapCameraChangeListenerInvoker, TencentMapBinding")]
			void OnCameraChangeFinish (global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0);

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapCameraChangeListener", DoNotGenerateAcw=true)]
		internal class IOnMapCameraChangeListenerInvoker : global::Java.Lang.Object, IOnMapCameraChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapCameraChangeListener");
			IntPtr class_ref;

			public static IOnMapCameraChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapCameraChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapCameraChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapCameraChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMapCameraChangeListenerInvoker); }
			}

			static Delegate cb_onCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_;
#pragma warning disable 0169
			static Delegate GetOnCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_Handler ()
			{
				if (cb_onCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_ == null)
					cb_onCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_);
				return cb_onCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_;
			}

			static void n_OnCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_;
			public void OnCameraChange (global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0)
			{
				if (id_onCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_ == IntPtr.Zero)
					id_onCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_ = JNIEnv.GetMethodID (class_ref, "onCameraChange", "(Lcom/tencent/mapsdk/raster/model/CameraPosition;)V");
				JNIEnv.CallVoidMethod (Handle, id_onCameraChange_Lcom_tencent_mapsdk_raster_model_CameraPosition_, new JValue (p0));
			}

			static Delegate cb_onCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_;
#pragma warning disable 0169
			static Delegate GetOnCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_Handler ()
			{
				if (cb_onCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_ == null)
					cb_onCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_);
				return cb_onCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_;
			}

			static void n_OnCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraChangeFinish (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_;
			public void OnCameraChangeFinish (global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0)
			{
				if (id_onCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_ == IntPtr.Zero)
					id_onCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_ = JNIEnv.GetMethodID (class_ref, "onCameraChangeFinish", "(Lcom/tencent/mapsdk/raster/model/CameraPosition;)V");
				JNIEnv.CallVoidMethod (Handle, id_onCameraChangeFinish_Lcom_tencent_mapsdk_raster_model_CameraPosition_, new JValue (p0));
			}

		}

		public partial class CameraChangeEventArgs : global::System.EventArgs {

			public CameraChangeEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0)
			{
				this.p0 = p0;
			}

			global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0;
			public global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition P0 {
				get { return p0; }
			}
		}

		public partial class CameraChangeFinishEventArgs : global::System.EventArgs {

			public CameraChangeFinishEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0)
			{
				this.p0 = p0;
			}

			global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0;
			public global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMapCameraChangeListenerImplementor")]
		internal sealed class IOnMapCameraChangeListenerImplementor : global::Java.Lang.Object, IOnMapCameraChangeListener {

			object sender;

			public IOnMapCameraChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMapCameraChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CameraChangeEventArgs> OnCameraChangeHandler;
#pragma warning restore 0649

			public void OnCameraChange (global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0)
			{
				var __h = OnCameraChangeHandler;
				if (__h != null)
					__h (sender, new CameraChangeEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<CameraChangeFinishEventArgs> OnCameraChangeFinishHandler;
#pragma warning restore 0649

			public void OnCameraChangeFinish (global::Com.Tencent.Mapsdk.Raster.Model.CameraPosition p0)
			{
				var __h = OnCameraChangeFinishHandler;
				if (__h != null)
					__h (sender, new CameraChangeFinishEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapCameraChangeListenerImplementor value)
			{
				return value.OnCameraChangeHandler == null && value.OnCameraChangeFinishHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMapClickListener']"
		[Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapClickListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMapClickListenerInvoker")]
		public partial interface IOnMapClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMapClickListener']/method[@name='onMapClick' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
			[Register ("onMapClick", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetOnMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMapClickListenerInvoker, TencentMapBinding")]
			void OnMapClick (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapClickListenerInvoker : global::Java.Lang.Object, IOnMapClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapClickListener");
			IntPtr class_ref;

			public static IOnMapClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMapClickListenerInvoker); }
			}

			static Delegate cb_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
			{
				if (cb_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
					cb_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_);
				return cb_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_;
			}

			static void n_OnMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_;
			public void OnMapClick (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
			{
				if (id_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
					id_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapClick", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0));
			}

		}

		public partial class MapClickEventArgs : global::System.EventArgs {

			public MapClickEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0;
			public global::Com.Tencent.Mapsdk.Raster.Model.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMapClickListenerImplementor")]
		internal sealed class IOnMapClickListenerImplementor : global::Java.Lang.Object, IOnMapClickListener {

			object sender;

			public IOnMapClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMapClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapClick (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMapLoadedListener']"
		[Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLoadedListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMapLoadedListenerInvoker")]
		public partial interface IOnMapLoadedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMapLoadedListener']/method[@name='onMapLoaded' and count(parameter)=0]"
			[Register ("onMapLoaded", "()V", "GetOnMapLoadedHandler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMapLoadedListenerInvoker, TencentMapBinding")]
			void OnMapLoaded ();

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLoadedListener", DoNotGenerateAcw=true)]
		internal class IOnMapLoadedListenerInvoker : global::Java.Lang.Object, IOnMapLoadedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLoadedListener");
			IntPtr class_ref;

			public static IOnMapLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapLoadedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapLoadedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMapLoadedListenerInvoker); }
			}

			static Delegate cb_onMapLoaded;
#pragma warning disable 0169
			static Delegate GetOnMapLoadedHandler ()
			{
				if (cb_onMapLoaded == null)
					cb_onMapLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMapLoaded);
				return cb_onMapLoaded;
			}

			static void n_OnMapLoaded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMapLoaded ();
			}
#pragma warning restore 0169

			IntPtr id_onMapLoaded;
			public void OnMapLoaded ()
			{
				if (id_onMapLoaded == IntPtr.Zero)
					id_onMapLoaded = JNIEnv.GetMethodID (class_ref, "onMapLoaded", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onMapLoaded);
			}

		}

		[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMapLoadedListenerImplementor")]
		internal sealed class IOnMapLoadedListenerImplementor : global::Java.Lang.Object, IOnMapLoadedListener {

			object sender;

			public IOnMapLoadedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMapLoadedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnMapLoaded ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnMapLoadedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMapLongClickListener']"
		[Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLongClickListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMapLongClickListenerInvoker")]
		public partial interface IOnMapLongClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMapLongClickListener']/method[@name='onMapLongClick' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
			[Register ("onMapLongClick", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetOnMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMapLongClickListenerInvoker, TencentMapBinding")]
			void OnMapLongClick (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLongClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapLongClickListenerInvoker : global::Java.Lang.Object, IOnMapLongClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLongClickListener");
			IntPtr class_ref;

			public static IOnMapLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMapLongClickListenerInvoker); }
			}

			static Delegate cb_onMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
			{
				if (cb_onMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
					cb_onMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_);
				return cb_onMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_;
			}

			static void n_OnMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapLongClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_;
			public void OnMapLongClick (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
			{
				if (id_onMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
					id_onMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapLongClick", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMapLongClick_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0));
			}

		}

		public partial class MapLongClickEventArgs : global::System.EventArgs {

			public MapLongClickEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0;
			public global::Com.Tencent.Mapsdk.Raster.Model.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMapLongClickListenerImplementor")]
		internal sealed class IOnMapLongClickListenerImplementor : global::Java.Lang.Object, IOnMapLongClickListener {

			object sender;

			public IOnMapLongClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMapLongClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapLongClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapLongClick (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapLongClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMarkerClickListener']"
		[Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerClickListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMarkerClickListenerInvoker")]
		public partial interface IOnMarkerClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMarkerClickListener']/method[@name='onMarkerClick' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.Marker']]"
			[Register ("onMarkerClick", "(Lcom/tencent/mapsdk/raster/model/Marker;)Z", "GetOnMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMarkerClickListenerInvoker, TencentMapBinding")]
			bool OnMarkerClick (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerClickListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerClickListenerInvoker : global::Java.Lang.Object, IOnMarkerClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerClickListener");
			IntPtr class_ref;

			public static IOnMarkerClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.TencentMap.OnMarkerClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMarkerClickListenerInvoker); }
			}

			static Delegate cb_onMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_Handler ()
			{
				if (cb_onMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_ == null)
					cb_onMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_);
				return cb_onMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_;
			}

			static bool n_OnMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMarkerClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_;
			public bool OnMarkerClick (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				if (id_onMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_ == IntPtr.Zero)
					id_onMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerClick", "(Lcom/tencent/mapsdk/raster/model/Marker;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onMarkerClick_Lcom_tencent_mapsdk_raster_model_Marker_, new JValue (p0));
				return __ret;
			}

		}

		public partial class MarkerClickEventArgs : global::System.EventArgs {

			public MarkerClickEventArgs (bool handled, global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Tencent.Mapsdk.Raster.Model.Marker p0;
			public global::Com.Tencent.Mapsdk.Raster.Model.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMarkerClickListenerImplementor")]
		internal sealed class IOnMarkerClickListenerImplementor : global::Java.Lang.Object, IOnMarkerClickListener {

			object sender;

			public IOnMarkerClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMarkerClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMarkerClick (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MarkerClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMarkerClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMarkerDraggedListener']"
		[Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerDraggedListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMarkerDraggedListenerInvoker")]
		public partial interface IOnMarkerDraggedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMarkerDraggedListener']/method[@name='onMarkerDrag' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.Marker']]"
			[Register ("onMarkerDrag", "(Lcom/tencent/mapsdk/raster/model/Marker;)V", "GetOnMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMarkerDraggedListenerInvoker, TencentMapBinding")]
			void OnMarkerDrag (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMarkerDraggedListener']/method[@name='onMarkerDragEnd' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.Marker']]"
			[Register ("onMarkerDragEnd", "(Lcom/tencent/mapsdk/raster/model/Marker;)V", "GetOnMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMarkerDraggedListenerInvoker, TencentMapBinding")]
			void OnMarkerDragEnd (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnMarkerDraggedListener']/method[@name='onMarkerDragStart' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.Marker']]"
			[Register ("onMarkerDragStart", "(Lcom/tencent/mapsdk/raster/model/Marker;)V", "GetOnMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnMarkerDraggedListenerInvoker, TencentMapBinding")]
			void OnMarkerDragStart (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0);

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerDraggedListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerDraggedListenerInvoker : global::Java.Lang.Object, IOnMarkerDraggedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerDraggedListener");
			IntPtr class_ref;

			public static IOnMarkerDraggedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerDraggedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.TencentMap.OnMarkerDraggedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerDraggedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMarkerDraggedListenerInvoker); }
			}

			static Delegate cb_onMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_Handler ()
			{
				if (cb_onMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_ == null)
					cb_onMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_);
				return cb_onMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_;
			}

			static void n_OnMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDrag (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_;
			public void OnMarkerDrag (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				if (id_onMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_ == IntPtr.Zero)
					id_onMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDrag", "(Lcom/tencent/mapsdk/raster/model/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMarkerDrag_Lcom_tencent_mapsdk_raster_model_Marker_, new JValue (p0));
			}

			static Delegate cb_onMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_Handler ()
			{
				if (cb_onMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_ == null)
					cb_onMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_);
				return cb_onMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_;
			}

			static void n_OnMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragEnd (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_;
			public void OnMarkerDragEnd (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				if (id_onMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_ == IntPtr.Zero)
					id_onMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragEnd", "(Lcom/tencent/mapsdk/raster/model/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMarkerDragEnd_Lcom_tencent_mapsdk_raster_model_Marker_, new JValue (p0));
			}

			static Delegate cb_onMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_Handler ()
			{
				if (cb_onMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_ == null)
					cb_onMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_);
				return cb_onMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_;
			}

			static void n_OnMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragStart (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_;
			public void OnMarkerDragStart (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				if (id_onMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_ == IntPtr.Zero)
					id_onMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragStart", "(Lcom/tencent/mapsdk/raster/model/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMarkerDragStart_Lcom_tencent_mapsdk_raster_model_Marker_, new JValue (p0));
			}

		}

		public partial class MarkerDragEventArgs : global::System.EventArgs {

			public MarkerDragEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Tencent.Mapsdk.Raster.Model.Marker p0;
			public global::Com.Tencent.Mapsdk.Raster.Model.Marker P0 {
				get { return p0; }
			}
		}

		public partial class MarkerDragEndEventArgs : global::System.EventArgs {

			public MarkerDragEndEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Tencent.Mapsdk.Raster.Model.Marker p0;
			public global::Com.Tencent.Mapsdk.Raster.Model.Marker P0 {
				get { return p0; }
			}
		}

		public partial class MarkerDragStartEventArgs : global::System.EventArgs {

			public MarkerDragStartEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Tencent.Mapsdk.Raster.Model.Marker p0;
			public global::Com.Tencent.Mapsdk.Raster.Model.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMarkerDraggedListenerImplementor")]
		internal sealed class IOnMarkerDraggedListenerImplementor : global::Java.Lang.Object, IOnMarkerDraggedListener {

			object sender;

			public IOnMarkerDraggedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnMarkerDraggedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerDragEventArgs> OnMarkerDragHandler;
#pragma warning restore 0649

			public void OnMarkerDrag (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				var __h = OnMarkerDragHandler;
				if (__h != null)
					__h (sender, new MarkerDragEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragEndEventArgs> OnMarkerDragEndHandler;
#pragma warning restore 0649

			public void OnMarkerDragEnd (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				var __h = OnMarkerDragEndHandler;
				if (__h != null)
					__h (sender, new MarkerDragEndEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragStartEventArgs> OnMarkerDragStartHandler;
#pragma warning restore 0649

			public void OnMarkerDragStart (global::Com.Tencent.Mapsdk.Raster.Model.Marker p0)
			{
				var __h = OnMarkerDragStartHandler;
				if (__h != null)
					__h (sender, new MarkerDragStartEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMarkerDraggedListenerImplementor value)
			{
				return value.OnMarkerDragHandler == null && value.OnMarkerDragEndHandler == null && value.OnMarkerDragStartHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnScreenShotListener']"
		[Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnScreenShotListenerInvoker")]
		public partial interface IOnScreenShotListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='TencentMap.OnScreenShotListener']/method[@name='onMapScreenShot' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("onMapScreenShot", "(Landroid/graphics/Bitmap;)V", "GetOnMapScreenShot_Landroid_graphics_Bitmap_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap/IOnScreenShotListenerInvoker, TencentMapBinding")]
			void OnMapScreenShot (global::Android.Graphics.Bitmap p0);

		}

		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener", DoNotGenerateAcw=true)]
		internal class IOnScreenShotListenerInvoker : global::Java.Lang.Object, IOnScreenShotListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener");
			IntPtr class_ref;

			public static IOnScreenShotListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnScreenShotListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.TencentMap.OnScreenShotListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnScreenShotListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnScreenShotListenerInvoker); }
			}

			static Delegate cb_onMapScreenShot_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetOnMapScreenShot_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_onMapScreenShot_Landroid_graphics_Bitmap_ == null)
					cb_onMapScreenShot_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapScreenShot_Landroid_graphics_Bitmap_);
				return cb_onMapScreenShot_Landroid_graphics_Bitmap_;
			}

			static void n_OnMapScreenShot_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapScreenShot (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapScreenShot_Landroid_graphics_Bitmap_;
			public void OnMapScreenShot (global::Android.Graphics.Bitmap p0)
			{
				if (id_onMapScreenShot_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_onMapScreenShot_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onMapScreenShot", "(Landroid/graphics/Bitmap;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMapScreenShot_Landroid_graphics_Bitmap_, new JValue (p0));
			}

		}

		public partial class ScreenShotEventArgs : global::System.EventArgs {

			public ScreenShotEventArgs (global::Android.Graphics.Bitmap p0)
			{
				this.p0 = p0;
			}

			global::Android.Graphics.Bitmap p0;
			public global::Android.Graphics.Bitmap P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnScreenShotListenerImplementor")]
		internal sealed class IOnScreenShotListenerImplementor : global::Java.Lang.Object, IOnScreenShotListener {

			object sender;

			public IOnScreenShotListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/TencentMap_OnScreenShotListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ScreenShotEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapScreenShot (global::Android.Graphics.Bitmap p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ScreenShotEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnScreenShotListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/TencentMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TencentMap); }
		}

		protected TencentMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isAppKeyAvailable;
		public bool IsAppKeyAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='isAppKeyAvailable' and count(parameter)=0]"
			[Register ("isAppKeyAvailable", "()Z", "GetIsAppKeyAvailableHandler")]
			get {
				if (id_isAppKeyAvailable == IntPtr.Zero)
					id_isAppKeyAvailable = JNIEnv.GetMethodID (class_ref, "isAppKeyAvailable", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isAppKeyAvailable);
			}
		}

		static Delegate cb_getMapCenter;
#pragma warning disable 0169
		static Delegate GetGetMapCenterHandler ()
		{
			if (cb_getMapCenter == null)
				cb_getMapCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapCenter);
			return cb_getMapCenter;
		}

		static IntPtr n_GetMapCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapCenter);
		}
#pragma warning restore 0169

		static IntPtr id_getMapCenter;
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.LatLng MapCenter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='getMapCenter' and count(parameter)=0]"
			[Register ("getMapCenter", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetMapCenterHandler")]
			get {
				if (id_getMapCenter == IntPtr.Zero)
					id_getMapCenter = JNIEnv.GetMethodID (class_ref, "getMapCenter", "()Lcom/tencent/mapsdk/raster/model/LatLng;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getMapCenter), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapCenter", "()Lcom/tencent/mapsdk/raster/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMaxZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomLevelHandler ()
		{
			if (cb_getMaxZoomLevel == null)
				cb_getMaxZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxZoomLevel);
			return cb_getMaxZoomLevel;
		}

		static int n_GetMaxZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxZoomLevel;
		public virtual int MaxZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
			[Register ("getMaxZoomLevel", "()I", "GetGetMaxZoomLevelHandler")]
			get {
				if (id_getMaxZoomLevel == IntPtr.Zero)
					id_getMaxZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaxZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMaxZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxZoomLevel", "()I"));
			}
		}

		static Delegate cb_getMinZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMinZoomLevelHandler ()
		{
			if (cb_getMinZoomLevel == null)
				cb_getMinZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinZoomLevel);
			return cb_getMinZoomLevel;
		}

		static int n_GetMinZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMinZoomLevel;
		public virtual int MinZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='getMinZoomLevel' and count(parameter)=0]"
			[Register ("getMinZoomLevel", "()I", "GetGetMinZoomLevelHandler")]
			get {
				if (id_getMinZoomLevel == IntPtr.Zero)
					id_getMinZoomLevel = JNIEnv.GetMethodID (class_ref, "getMinZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMinZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinZoomLevel", "()I"));
			}
		}

		static IntPtr id_isSatelliteEnabled;
		static IntPtr id_setSatelliteEnabled_Z;
		public bool SatelliteEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='isSatelliteEnabled' and count(parameter)=0]"
			[Register ("isSatelliteEnabled", "()Z", "GetIsSatelliteEnabledHandler")]
			get {
				if (id_isSatelliteEnabled == IntPtr.Zero)
					id_isSatelliteEnabled = JNIEnv.GetMethodID (class_ref, "isSatelliteEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isSatelliteEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setSatelliteEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSatelliteEnabled", "(Z)V", "GetSetSatelliteEnabled_ZHandler")]
			set {
				if (id_setSatelliteEnabled_Z == IntPtr.Zero)
					id_setSatelliteEnabled_Z = JNIEnv.GetMethodID (class_ref, "setSatelliteEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSatelliteEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSatelliteEnabled", "(Z)V"), new JValue (value));
			}
		}

		static IntPtr id_getVersion;
		public string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetZoomLevelHandler ()
		{
			if (cb_getZoomLevel == null)
				cb_getZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZoomLevel);
			return cb_getZoomLevel;
		}

		static int n_GetZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomLevel;
		public virtual int ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()I", "GetGetZoomLevelHandler")]
			get {
				if (id_getZoomLevel == IntPtr.Zero)
					id_getZoomLevel = JNIEnv.GetMethodID (class_ref, "getZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoomLevel", "()I"));
			}
		}

		static Delegate cb_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_;
#pragma warning disable 0169
		static Delegate GetAddCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_Handler ()
		{
			if (cb_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_ == null)
				cb_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_);
			return cb_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_;
		}

		static IntPtr n_AddCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCircle (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='addCircle' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.CircleOptions']]"
		[Register ("addCircle", "(Lcom/tencent/mapsdk/raster/model/CircleOptions;)Lcom/tencent/mapsdk/raster/model/Circle;", "GetAddCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_Handler")]
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.Circle AddCircle (global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions p0)
		{
			if (id_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_ == IntPtr.Zero)
				id_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_ = JNIEnv.GetMethodID (class_ref, "addCircle", "(Lcom/tencent/mapsdk/raster/model/CircleOptions;)Lcom/tencent/mapsdk/raster/model/Circle;");

			global::Com.Tencent.Mapsdk.Raster.Model.Circle __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Circle> (JNIEnv.CallObjectMethod  (Handle, id_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Circle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCircle", "(Lcom/tencent/mapsdk/raster/model/CircleOptions;)Lcom/tencent/mapsdk/raster/model/Circle;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_;
#pragma warning disable 0169
		static Delegate GetAddGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_Handler ()
		{
			if (cb_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_ == null)
				cb_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_);
			return cb_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_;
		}

		static IntPtr n_AddGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddGroundOverlay (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='addGroundOverlay' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.GroundOverlayOptions']]"
		[Register ("addGroundOverlay", "(Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;", "GetAddGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_Handler")]
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay AddGroundOverlay (global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions p0)
		{
			if (id_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_ == IntPtr.Zero)
				id_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_ = JNIEnv.GetMethodID (class_ref, "addGroundOverlay", "(Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;");

			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay> (JNIEnv.CallObjectMethod  (Handle, id_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addGroundOverlay", "(Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_;
#pragma warning disable 0169
		static Delegate GetAddMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_Handler ()
		{
			if (cb_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_ == null)
				cb_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_);
			return cb_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_;
		}

		static IntPtr n_AddMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMarker (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.MarkerOptions']]"
		[Register ("addMarker", "(Lcom/tencent/mapsdk/raster/model/MarkerOptions;)Lcom/tencent/mapsdk/raster/model/Marker;", "GetAddMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_Handler")]
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.Marker AddMarker (global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions p0)
		{
			if (id_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_ == IntPtr.Zero)
				id_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_ = JNIEnv.GetMethodID (class_ref, "addMarker", "(Lcom/tencent/mapsdk/raster/model/MarkerOptions;)Lcom/tencent/mapsdk/raster/model/Marker;");

			global::Com.Tencent.Mapsdk.Raster.Model.Marker __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (JNIEnv.CallObjectMethod  (Handle, id_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMarker", "(Lcom/tencent/mapsdk/raster/model/MarkerOptions;)Lcom/tencent/mapsdk/raster/model/Marker;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_;
#pragma warning disable 0169
		static Delegate GetAddPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_Handler ()
		{
			if (cb_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_ == null)
				cb_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_);
			return cb_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_;
		}

		static IntPtr n_AddPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPolygon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='addPolygon' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.PolygonOptions']]"
		[Register ("addPolygon", "(Lcom/tencent/mapsdk/raster/model/PolygonOptions;)Lcom/tencent/mapsdk/raster/model/Polygon;", "GetAddPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_Handler")]
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.Polygon AddPolygon (global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions p0)
		{
			if (id_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_ == IntPtr.Zero)
				id_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_ = JNIEnv.GetMethodID (class_ref, "addPolygon", "(Lcom/tencent/mapsdk/raster/model/PolygonOptions;)Lcom/tencent/mapsdk/raster/model/Polygon;");

			global::Com.Tencent.Mapsdk.Raster.Model.Polygon __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polygon> (JNIEnv.CallObjectMethod  (Handle, id_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polygon> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPolygon", "(Lcom/tencent/mapsdk/raster/model/PolygonOptions;)Lcom/tencent/mapsdk/raster/model/Polygon;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_;
#pragma warning disable 0169
		static Delegate GetAddPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_Handler ()
		{
			if (cb_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_ == null)
				cb_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_);
			return cb_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_;
		}

		static IntPtr n_AddPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPolyline (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='addPolyline' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.PolylineOptions']]"
		[Register ("addPolyline", "(Lcom/tencent/mapsdk/raster/model/PolylineOptions;)Lcom/tencent/mapsdk/raster/model/Polyline;", "GetAddPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_Handler")]
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.Polyline AddPolyline (global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions p0)
		{
			if (id_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_ == IntPtr.Zero)
				id_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_ = JNIEnv.GetMethodID (class_ref, "addPolyline", "(Lcom/tencent/mapsdk/raster/model/PolylineOptions;)Lcom/tencent/mapsdk/raster/model/Polyline;");

			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (JNIEnv.CallObjectMethod  (Handle, id_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPolyline", "(Lcom/tencent/mapsdk/raster/model/PolylineOptions;)Lcom/tencent/mapsdk/raster/model/Polyline;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static void n_AnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='animateTo' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("animateTo", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetAnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual void AnimateTo (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "animateTo", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateTo", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V"), new JValue (p0));
		}

		static Delegate cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_Handler ()
		{
			if (cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_ == null)
				cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_);
			return cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_;
		}

		static void n_AnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p1 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='animateTo' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("animateTo", "(Lcom/tencent/mapsdk/raster/model/LatLng;Ljava/lang/Runnable;)V", "GetAnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_Handler")]
		public virtual void AnimateTo (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, global::Java.Lang.IRunnable p1)
		{
			if (id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "animateTo", "(Lcom/tencent/mapsdk/raster/model/LatLng;Ljava/lang/Runnable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_Ljava_lang_Runnable_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateTo", "(Lcom/tencent/mapsdk/raster/model/LatLng;Ljava/lang/Runnable;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_Handler ()
		{
			if (cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ == null)
				cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_AnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_);
			return cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
		}

		static void n_AnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback p2 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='animateTo' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='long'] and parameter[3][@type='com.tencent.tencentmap.mapsdk.map.CancelableCallback']]"
		[Register ("animateTo", "(Lcom/tencent/mapsdk/raster/model/LatLng;JLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V", "GetAnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_Handler")]
		public virtual void AnimateTo (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, long p1, global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback p2)
		{
			if (id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ == IntPtr.Zero)
				id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ = JNIEnv.GetMethodID (class_ref, "animateTo", "(Lcom/tencent/mapsdk/raster/model/LatLng;JLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateTo", "(Lcom/tencent/mapsdk/raster/model/LatLng;JLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_clearAllOverlays;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='clearAllOverlays' and count(parameter)=0]"
		[Register ("clearAllOverlays", "()V", "")]
		public void ClearAllOverlays ()
		{
			if (id_clearAllOverlays == IntPtr.Zero)
				id_clearAllOverlays = JNIEnv.GetMethodID (class_ref, "clearAllOverlays", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_clearAllOverlays);
		}

		static Delegate cb_clearCache;
#pragma warning disable 0169
		static Delegate GetClearCacheHandler ()
		{
			if (cb_clearCache == null)
				cb_clearCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ClearCache);
			return cb_clearCache;
		}

		static bool n_ClearCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearCache ();
		}
#pragma warning restore 0169

		static IntPtr id_clearCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='clearCache' and count(parameter)=0]"
		[Register ("clearCache", "()Z", "GetClearCacheHandler")]
		public virtual bool ClearCache ()
		{
			if (id_clearCache == IntPtr.Zero)
				id_clearCache = JNIEnv.GetMethodID (class_ref, "clearCache", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_clearCache);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearCache", "()Z"));
		}

		static Delegate cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_;
#pragma warning disable 0169
		static Delegate GetGetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Handler ()
		{
			if (cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_ == null)
				cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_);
			return cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_;
		}

		static void n_GetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetScreenShot (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='getScreenShot' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnScreenShotListener']]"
		[Register ("getScreenShot", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener;)V", "GetGetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Handler")]
		public virtual void GetScreenShot (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener p0)
		{
			if (id_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_ == IntPtr.Zero)
				id_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_ = JNIEnv.GetMethodID (class_ref, "getScreenShot", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScreenShot", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener;)V"), new JValue (p0));
		}

		static Delegate cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetGetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_Handler ()
		{
			if (cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_ == null)
				cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_);
			return cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_;
		}

		static void n_GetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetScreenShot (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='getScreenShot' and count(parameter)=2 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnScreenShotListener'] and parameter[2][@type='android.graphics.Rect']]"
		[Register ("getScreenShot", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener;Landroid/graphics/Rect;)V", "GetGetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_Handler")]
		public virtual void GetScreenShot (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener p0, global::Android.Graphics.Rect p1)
		{
			if (id_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "getScreenShot", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener;Landroid/graphics/Rect;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScreenShot", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener;Landroid/graphics/Rect;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_;
#pragma warning disable 0169
		static Delegate GetMoveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_Handler ()
		{
			if (cb_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_ == null)
				cb_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MoveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_);
			return cb_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_;
		}

		static void n_MoveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.CameraUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.CameraUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveCamera (p0);
		}
#pragma warning restore 0169

		static IntPtr id_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='moveCamera' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.CameraUpdate']]"
		[Register ("moveCamera", "(Lcom/tencent/tencentmap/mapsdk/map/CameraUpdate;)V", "GetMoveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_Handler")]
		public virtual void MoveCamera (global::Com.Tencent.Tencentmap.Mapsdk.Map.CameraUpdate p0)
		{
			if (id_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_ == IntPtr.Zero)
				id_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_ = JNIEnv.GetMethodID (class_ref, "moveCamera", "(Lcom/tencent/tencentmap/mapsdk/map/CameraUpdate;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveCamera", "(Lcom/tencent/tencentmap/mapsdk/map/CameraUpdate;)V"), new JValue (p0));
		}

		static Delegate cb_removeOverlay_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveOverlay_Ljava_lang_Object_Handler ()
		{
			if (cb_removeOverlay_Ljava_lang_Object_ == null)
				cb_removeOverlay_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOverlay_Ljava_lang_Object_);
			return cb_removeOverlay_Ljava_lang_Object_;
		}

		static void n_RemoveOverlay_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOverlay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeOverlay_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='removeOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeOverlay", "(Ljava/lang/Object;)V", "GetRemoveOverlay_Ljava_lang_Object_Handler")]
		public virtual void RemoveOverlay (global::Java.Lang.Object p0)
		{
			if (id_removeOverlay_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeOverlay_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeOverlay", "(Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeOverlay_Ljava_lang_Object_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOverlay", "(Ljava/lang/Object;)V"), new JValue (p0));
		}

		static Delegate cb_scrollBy_FF;
#pragma warning disable 0169
		static Delegate GetScrollBy_FFHandler ()
		{
			if (cb_scrollBy_FF == null)
				cb_scrollBy_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_ScrollBy_FF);
			return cb_scrollBy_FF;
		}

		static void n_ScrollBy_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollBy (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_scrollBy_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='scrollBy' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("scrollBy", "(FF)V", "GetScrollBy_FFHandler")]
		public virtual void ScrollBy (float p0, float p1)
		{
			if (id_scrollBy_FF == IntPtr.Zero)
				id_scrollBy_FF = JNIEnv.GetMethodID (class_ref, "scrollBy", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_scrollBy_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scrollBy", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
#pragma warning disable 0169
		static Delegate GetScrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_Handler ()
		{
			if (cb_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ == null)
				cb_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, long, IntPtr>) n_ScrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_);
			return cb_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
		}

		static void n_ScrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ (IntPtr jnienv, IntPtr native__this, float p0, float p1, long p2, IntPtr native_p3)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback p3 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ScrollBy (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='scrollBy' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='long'] and parameter[4][@type='com.tencent.tencentmap.mapsdk.map.CancelableCallback']]"
		[Register ("scrollBy", "(FFJLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V", "GetScrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_Handler")]
		public virtual void ScrollBy (float p0, float p1, long p2, global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback p3)
		{
			if (id_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ == IntPtr.Zero)
				id_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ = JNIEnv.GetMethodID (class_ref, "scrollBy", "(FFJLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scrollBy", "(FFJLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetCenter_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenter_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static void n_SetCenter_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCenter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("setCenter", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetSetCenter_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual void SetCenter (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setCenter", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCenter_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCenter", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V"), new JValue (p0));
		}

		static Delegate cb_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_;
#pragma warning disable 0169
		static Delegate GetSetInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_Handler ()
		{
			if (cb_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_ == null)
				cb_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_);
			return cb_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_;
		}

		static void n_SetInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInfoWindowAdapter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setInfoWindowAdapter' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.InfoWindowAdapter']]"
		[Register ("setInfoWindowAdapter", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$InfoWindowAdapter;)V", "GetSetInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_Handler")]
		public virtual void SetInfoWindowAdapter (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter p0)
		{
			if (id_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_ == IntPtr.Zero)
				id_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_ = JNIEnv.GetMethodID (class_ref, "setInfoWindowAdapter", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$InfoWindowAdapter;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInfoWindowAdapter", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$InfoWindowAdapter;)V"), new JValue (p0));
		}

		static Delegate cb_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_Handler ()
		{
			if (cb_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_ == null)
				cb_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_);
			return cb_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_;
		}

		static void n_SetOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnInfoWindowClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setOnInfoWindowClickListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnInfoWindowClickListener']]"
		[Register ("setOnInfoWindowClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnInfoWindowClickListener;)V", "GetSetOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_Handler")]
		public virtual void SetOnInfoWindowClickListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener p0)
		{
			if (id_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_ == IntPtr.Zero)
				id_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnInfoWindowClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnInfoWindowClickListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnInfoWindowClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnInfoWindowClickListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_Handler ()
		{
			if (cb_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_ == null)
				cb_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_);
			return cb_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_;
		}

		static void n_SetOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapCameraChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setOnMapCameraChangeListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapCameraChangeListener']]"
		[Register ("setOnMapCameraChangeListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapCameraChangeListener;)V", "GetSetOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_Handler")]
		public virtual void SetOnMapCameraChangeListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener p0)
		{
			if (id_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_ == IntPtr.Zero)
				id_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapCameraChangeListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapCameraChangeListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMapCameraChangeListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapCameraChangeListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_Handler ()
		{
			if (cb_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_ == null)
				cb_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_);
			return cb_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_;
		}

		static void n_SetOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setOnMapClickListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapClickListener']]"
		[Register ("setOnMapClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapClickListener;)V", "GetSetOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_Handler")]
		public virtual void SetOnMapClickListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener p0)
		{
			if (id_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_ == IntPtr.Zero)
				id_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapClickListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMapClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapClickListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_Handler ()
		{
			if (cb_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_ == null)
				cb_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_);
			return cb_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_;
		}

		static void n_SetOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapLoadedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setOnMapLoadedListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapLoadedListener']]"
		[Register ("setOnMapLoadedListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLoadedListener;)V", "GetSetOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_Handler")]
		public virtual void SetOnMapLoadedListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener p0)
		{
			if (id_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_ == IntPtr.Zero)
				id_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapLoadedListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLoadedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMapLoadedListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLoadedListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_Handler ()
		{
			if (cb_setOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_ == null)
				cb_setOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_);
			return cb_setOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_;
		}

		static void n_SetOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapLongClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setOnMapLongClickListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapLongClickListener']]"
		[Register ("setOnMapLongClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLongClickListener;)V", "GetSetOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_Handler")]
		public virtual void SetOnMapLongClickListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener p0)
		{
			if (id_setOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_ == IntPtr.Zero)
				id_setOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMapLongClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLongClickListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnMapLongClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMapLongClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLongClickListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_Handler ()
		{
			if (cb_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_ == null)
				cb_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_);
			return cb_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_;
		}

		static void n_SetOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMarkerClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setOnMarkerClickListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMarkerClickListener']]"
		[Register ("setOnMarkerClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerClickListener;)V", "GetSetOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_Handler")]
		public virtual void SetOnMarkerClickListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener p0)
		{
			if (id_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_ == IntPtr.Zero)
				id_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMarkerClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerClickListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMarkerClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerClickListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_Handler ()
		{
			if (cb_setOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_ == null)
				cb_setOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_);
			return cb_setOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_;
		}

		static void n_SetOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMarkerDraggedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setOnMarkerDraggedListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMarkerDraggedListener']]"
		[Register ("setOnMarkerDraggedListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerDraggedListener;)V", "GetSetOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_Handler")]
		public virtual void SetOnMarkerDraggedListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener p0)
		{
			if (id_setOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_ == IntPtr.Zero)
				id_setOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_ = JNIEnv.GetMethodID (class_ref, "setOnMarkerDraggedListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerDraggedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnMarkerDraggedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMarkerDraggedListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerDraggedListener;)V"), new JValue (p0));
		}

		static Delegate cb_setZoom_I;
#pragma warning disable 0169
		static Delegate GetSetZoom_IHandler ()
		{
			if (cb_setZoom_I == null)
				cb_setZoom_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZoom_I);
			return cb_setZoom_I;
		}

		static void n_SetZoom_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoom (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoom_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setZoom", "(I)V", "GetSetZoom_IHandler")]
		public virtual void SetZoom (int p0)
		{
			if (id_setZoom_I == IntPtr.Zero)
				id_setZoom_I = JNIEnv.GetMethodID (class_ref, "setZoom", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setZoom_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoom", "(I)V"), new JValue (p0));
		}

		static Delegate cb_stopAnimation;
#pragma warning disable 0169
		static Delegate GetStopAnimationHandler ()
		{
			if (cb_stopAnimation == null)
				cb_stopAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAnimation);
			return cb_stopAnimation;
		}

		static void n_StopAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnimation ();
		}
#pragma warning restore 0169

		static IntPtr id_stopAnimation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='stopAnimation' and count(parameter)=0]"
		[Register ("stopAnimation", "()V", "GetStopAnimationHandler")]
		public virtual void StopAnimation ()
		{
			if (id_stopAnimation == IntPtr.Zero)
				id_stopAnimation = JNIEnv.GetMethodID (class_ref, "stopAnimation", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopAnimation);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopAnimation", "()V"));
		}

		static Delegate cb_zoomIn;
#pragma warning disable 0169
		static Delegate GetZoomInHandler ()
		{
			if (cb_zoomIn == null)
				cb_zoomIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomIn);
			return cb_zoomIn;
		}

		static void n_ZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomIn ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomIn;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()V", "GetZoomInHandler")]
		public virtual void ZoomIn ()
		{
			if (id_zoomIn == IntPtr.Zero)
				id_zoomIn = JNIEnv.GetMethodID (class_ref, "zoomIn", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomIn);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomIn", "()V"));
		}

		static Delegate cb_zoomInFixing_II;
#pragma warning disable 0169
		static Delegate GetZoomInFixing_IIHandler ()
		{
			if (cb_zoomInFixing_II == null)
				cb_zoomInFixing_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ZoomInFixing_II);
			return cb_zoomInFixing_II;
		}

		static void n_ZoomInFixing_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomInFixing (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_zoomInFixing_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='zoomInFixing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("zoomInFixing", "(II)V", "GetZoomInFixing_IIHandler")]
		public virtual void ZoomInFixing (int p0, int p1)
		{
			if (id_zoomInFixing_II == IntPtr.Zero)
				id_zoomInFixing_II = JNIEnv.GetMethodID (class_ref, "zoomInFixing", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomInFixing_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomInFixing", "(II)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_zoomOut;
#pragma warning disable 0169
		static Delegate GetZoomOutHandler ()
		{
			if (cb_zoomOut == null)
				cb_zoomOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomOut);
			return cb_zoomOut;
		}

		static void n_ZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOut ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()V", "GetZoomOutHandler")]
		public virtual void ZoomOut ()
		{
			if (id_zoomOut == IntPtr.Zero)
				id_zoomOut = JNIEnv.GetMethodID (class_ref, "zoomOut", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomOut);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomOut", "()V"));
		}

		static Delegate cb_zoomOutFixing_II;
#pragma warning disable 0169
		static Delegate GetZoomOutFixing_IIHandler ()
		{
			if (cb_zoomOutFixing_II == null)
				cb_zoomOutFixing_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ZoomOutFixing_II);
			return cb_zoomOutFixing_II;
		}

		static void n_ZoomOutFixing_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOutFixing (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_zoomOutFixing_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='zoomOutFixing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("zoomOutFixing", "(II)V", "GetZoomOutFixing_IIHandler")]
		public virtual void ZoomOutFixing (int p0, int p1)
		{
			if (id_zoomOutFixing_II == IntPtr.Zero)
				id_zoomOutFixing_II = JNIEnv.GetMethodID (class_ref, "zoomOutFixing", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomOutFixing_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomOutFixing", "(II)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_zoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetZoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_zoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_zoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ZoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_zoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static void n_ZoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_zoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='zoomToSpan' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("zoomToSpan", "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetZoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual void ZoomToSpan (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1)
		{
			if (id_zoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_zoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "zoomToSpan", "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomToSpan_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomToSpan", "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_zoomToSpan_DD;
#pragma warning disable 0169
		static Delegate GetZoomToSpan_DDHandler ()
		{
			if (cb_zoomToSpan_DD == null)
				cb_zoomToSpan_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_ZoomToSpan_DD);
			return cb_zoomToSpan_DD;
		}

		static void n_ZoomToSpan_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_zoomToSpan_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='TencentMap']/method[@name='zoomToSpan' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("zoomToSpan", "(DD)V", "GetZoomToSpan_DDHandler")]
		public virtual void ZoomToSpan (double p0, double p1)
		{
			if (id_zoomToSpan_DD == IntPtr.Zero)
				id_zoomToSpan_DD = JNIEnv.GetMethodID (class_ref, "zoomToSpan", "(DD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomToSpan_DD, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomToSpan", "(DD)V"), new JValue (p0), new JValue (p1));
		}

#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.InfoWindowClickEventArgs> InfoWindowClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListenerImplementor>(
						ref weak_implementor_SetOnInfoWindowClickListener,
						__CreateIOnInfoWindowClickListenerImplementor,
						SetOnInfoWindowClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListenerImplementor>(
						ref weak_implementor_SetOnInfoWindowClickListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListenerImplementor.__IsEmpty,
						__v => SetOnInfoWindowClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnInfoWindowClickListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListenerImplementor __CreateIOnInfoWindowClickListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.CameraChangeEventArgs> CameraChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnMapCameraChangeListener,
						__CreateIOnMapCameraChangeListenerImplementor,
						SetOnMapCameraChangeListener,
						__h => __h.OnCameraChangeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnMapCameraChangeListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapCameraChangeListener (null),
						__h => __h.OnCameraChangeHandler -= value);
			}
		}

		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.CameraChangeFinishEventArgs> CameraChangeFinish {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnMapCameraChangeListener,
						__CreateIOnMapCameraChangeListenerImplementor,
						SetOnMapCameraChangeListener,
						__h => __h.OnCameraChangeFinishHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnMapCameraChangeListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapCameraChangeListener (null),
						__h => __h.OnCameraChangeFinishHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapCameraChangeListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor __CreateIOnMapCameraChangeListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MapClickEventArgs> MapClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						__CreateIOnMapClickListenerImplementor,
						SetOnMapClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListenerImplementor.__IsEmpty,
						__v => SetOnMapClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapClickListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListenerImplementor __CreateIOnMapClickListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener"
		public event EventHandler MapLoaded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListenerImplementor>(
						ref weak_implementor_SetOnMapLoadedListener,
						__CreateIOnMapLoadedListenerImplementor,
						SetOnMapLoadedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListenerImplementor>(
						ref weak_implementor_SetOnMapLoadedListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListenerImplementor.__IsEmpty,
						__v => SetOnMapLoadedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapLoadedListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListenerImplementor __CreateIOnMapLoadedListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MapLongClickEventArgs> MapLongClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickListener,
						__CreateIOnMapLongClickListenerImplementor,
						SetOnMapLongClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListenerImplementor.__IsEmpty,
						__v => SetOnMapLongClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapLongClickListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListenerImplementor __CreateIOnMapLongClickListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MarkerClickEventArgs> MarkerClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						__CreateIOnMarkerClickListenerImplementor,
						SetOnMarkerClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListenerImplementor.__IsEmpty,
						__v => SetOnMarkerClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerClickListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListenerImplementor __CreateIOnMarkerClickListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MarkerDragEventArgs> MarkerDrag {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDraggedListener,
						__CreateIOnMarkerDraggedListenerImplementor,
						SetOnMarkerDraggedListener,
						__h => __h.OnMarkerDragHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDraggedListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDraggedListener (null),
						__h => __h.OnMarkerDragHandler -= value);
			}
		}

		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MarkerDragEndEventArgs> MarkerDragEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDraggedListener,
						__CreateIOnMarkerDraggedListenerImplementor,
						SetOnMarkerDraggedListener,
						__h => __h.OnMarkerDragEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDraggedListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDraggedListener (null),
						__h => __h.OnMarkerDragEndHandler -= value);
			}
		}

		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MarkerDragStartEventArgs> MarkerDragStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDraggedListener,
						__CreateIOnMarkerDraggedListenerImplementor,
						SetOnMarkerDraggedListener,
						__h => __h.OnMarkerDragStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDraggedListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDraggedListener (null),
						__h => __h.OnMarkerDragStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerDraggedListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor __CreateIOnMarkerDraggedListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor (this);
		}
#endregion
	}
}
