using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='OnLoadedListener']"
	[Register ("com/tencent/tencentmap/mapsdk/map/OnLoadedListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.IOnLoadedListenerInvoker")]
	public partial interface IOnLoadedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='OnLoadedListener']/method[@name='onMapLoaded' and count(parameter)=0]"
		[Register ("onMapLoaded", "()V", "GetOnMapLoadedHandler:Com.Tencent.Tencentmap.Mapsdk.Map.IOnLoadedListenerInvoker, TencentMapBinding")]
		void OnMapLoaded ();

	}

	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/OnLoadedListener", DoNotGenerateAcw=true)]
	internal class IOnLoadedListenerInvoker : global::Java.Lang.Object, IOnLoadedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/OnLoadedListener");
		IntPtr class_ref;

		public static IOnLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnLoadedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.OnLoadedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnLoadedListenerInvoker); }
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnLoadedListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnLoadedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/OnLoadedListenerImplementor")]
	internal sealed class IOnLoadedListenerImplementor : global::Java.Lang.Object, IOnLoadedListener {

		object sender;

		public IOnLoadedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/OnLoadedListenerImplementor", "()V"),
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

		internal static bool __IsEmpty (IOnLoadedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
