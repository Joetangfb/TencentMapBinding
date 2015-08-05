using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='CancelableCallback']"
	[Register ("com/tencent/tencentmap/mapsdk/map/CancelableCallback", "", "Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallbackInvoker")]
	public partial interface ICancelableCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='CancelableCallback']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler:Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallbackInvoker, TencentMapBinding")]
		void OnCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='CancelableCallback']/method[@name='onFinish' and count(parameter)=0]"
		[Register ("onFinish", "()V", "GetOnFinishHandler:Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallbackInvoker, TencentMapBinding")]
		void OnFinish ();

	}

	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/CancelableCallback", DoNotGenerateAcw=true)]
	internal class ICancelableCallbackInvoker : global::Java.Lang.Object, ICancelableCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/CancelableCallback");
		IntPtr class_ref;

		public static ICancelableCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICancelableCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.CancelableCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICancelableCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICancelableCallbackInvoker); }
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		IntPtr id_onCancel;
		public void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onCancel);
		}

		static Delegate cb_onFinish;
#pragma warning disable 0169
		static Delegate GetOnFinishHandler ()
		{
			if (cb_onFinish == null)
				cb_onFinish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinish);
			return cb_onFinish;
		}

		static void n_OnFinish (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFinish ();
		}
#pragma warning restore 0169

		IntPtr id_onFinish;
		public void OnFinish ()
		{
			if (id_onFinish == IntPtr.Zero)
				id_onFinish = JNIEnv.GetMethodID (class_ref, "onFinish", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onFinish);
		}

	}

}
