using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/MapView", DoNotGenerateAcw=true)]
	public partial class MapView : global::Android.Widget.FrameLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']"
		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/MapView$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Widget.FrameLayout.LayoutParams {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='BOTTOM']"
			[Register ("BOTTOM")]
			public const int Bottom = (int) 80;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='BOTTOM_CENTER']"
			[Register ("BOTTOM_CENTER")]
			public const int BottomCenter = (int) 81;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='CENTER']"
			[Register ("CENTER")]
			public const int Center = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='CENTER_HORIZONTAL']"
			[Register ("CENTER_HORIZONTAL")]
			public const int CenterHorizontal = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='CENTER_VERTICAL']"
			[Register ("CENTER_VERTICAL")]
			public const int CenterVertical = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='LEFT']"
			[Register ("LEFT")]
			public const int Left = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='MODE_MAP']"
			[Register ("MODE_MAP")]
			public const int ModeMap = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='MODE_VIEW']"
			[Register ("MODE_VIEW")]
			public const int ModeView = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='RIGHT']"
			[Register ("RIGHT")]
			public const int Right = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='TOP']"
			[Register ("TOP")]
			public const int Top = (int) 48;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='TOP_LEFT']"
			[Register ("TOP_LEFT")]
			public const int TopLeft = (int) 51;

			static IntPtr mode_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='mode']"
			[Register ("mode")]
			public int Mode {
				get {
					if (mode_jfieldId == IntPtr.Zero)
						mode_jfieldId = JNIEnv.GetFieldID (class_ref, "mode", "I");
					return JNIEnv.GetIntField (Handle, mode_jfieldId);
				}
				set {
					if (mode_jfieldId == IntPtr.Zero)
						mode_jfieldId = JNIEnv.GetFieldID (class_ref, "mode", "I");
					JNIEnv.SetField (Handle, mode_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/MapView$LayoutParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LayoutParams); }
			}

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_ViewGroup_LayoutParams_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			protected LayoutParams (global::Android.Views.ViewGroup.LayoutParams p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/ViewGroup$LayoutParams;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/ViewGroup$LayoutParams;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
					id_ctor_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_ViewGroup_LayoutParams_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_ViewGroup_LayoutParams_, new JValue (p0));
			}

			static IntPtr id_ctor_IILcom_tencent_mapsdk_raster_model_GeoPoint_III;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
			[Register (".ctor", "(IILcom/tencent/mapsdk/raster/model/GeoPoint;III)V", "")]
			public LayoutParams (int p0, int p1, global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p2, int p3, int p4, int p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILcom/tencent/mapsdk/raster/model/GeoPoint;III)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILcom/tencent/mapsdk/raster/model/GeoPoint;III)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
					return;
				}

				if (id_ctor_IILcom_tencent_mapsdk_raster_model_GeoPoint_III == IntPtr.Zero)
					id_ctor_IILcom_tencent_mapsdk_raster_model_GeoPoint_III = JNIEnv.GetMethodID (class_ref, "<init>", "(IILcom/tencent/mapsdk/raster/model/GeoPoint;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILcom_tencent_mapsdk_raster_model_GeoPoint_III, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILcom_tencent_mapsdk_raster_model_GeoPoint_III, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
			}

			static IntPtr id_ctor_IILcom_tencent_mapsdk_raster_model_GeoPoint_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[4][@type='int']]"
			[Register (".ctor", "(IILcom/tencent/mapsdk/raster/model/GeoPoint;I)V", "")]
			public LayoutParams (int p0, int p1, global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILcom/tencent/mapsdk/raster/model/GeoPoint;I)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILcom/tencent/mapsdk/raster/model/GeoPoint;I)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
					return;
				}

				if (id_ctor_IILcom_tencent_mapsdk_raster_model_GeoPoint_I == IntPtr.Zero)
					id_ctor_IILcom_tencent_mapsdk_raster_model_GeoPoint_I = JNIEnv.GetMethodID (class_ref, "<init>", "(IILcom/tencent/mapsdk/raster/model/GeoPoint;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILcom_tencent_mapsdk_raster_model_GeoPoint_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILcom_tencent_mapsdk_raster_model_GeoPoint_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

			static IntPtr id_ctor_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public LayoutParams (int p0, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
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

			static IntPtr id_ctor_IILcom_tencent_mapsdk_raster_model_LatLng_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[4][@type='int']]"
			[Register (".ctor", "(IILcom/tencent/mapsdk/raster/model/LatLng;I)V", "")]
			public LayoutParams (int p0, int p1, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILcom/tencent/mapsdk/raster/model/LatLng;I)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILcom/tencent/mapsdk/raster/model/LatLng;I)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
					return;
				}

				if (id_ctor_IILcom_tencent_mapsdk_raster_model_LatLng_I == IntPtr.Zero)
					id_ctor_IILcom_tencent_mapsdk_raster_model_LatLng_I = JNIEnv.GetMethodID (class_ref, "<init>", "(IILcom/tencent/mapsdk/raster/model/LatLng;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILcom_tencent_mapsdk_raster_model_LatLng_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILcom_tencent_mapsdk_raster_model_LatLng_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

			static IntPtr id_ctor_IILcom_tencent_mapsdk_raster_model_LatLng_III;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
			[Register (".ctor", "(IILcom/tencent/mapsdk/raster/model/LatLng;III)V", "")]
			public LayoutParams (int p0, int p1, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p2, int p3, int p4, int p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILcom/tencent/mapsdk/raster/model/LatLng;III)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILcom/tencent/mapsdk/raster/model/LatLng;III)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
					return;
				}

				if (id_ctor_IILcom_tencent_mapsdk_raster_model_LatLng_III == IntPtr.Zero)
					id_ctor_IILcom_tencent_mapsdk_raster_model_LatLng_III = JNIEnv.GetMethodID (class_ref, "<init>", "(IILcom/tencent/mapsdk/raster/model/LatLng;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILcom_tencent_mapsdk_raster_model_LatLng_III, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILcom_tencent_mapsdk_raster_model_LatLng_III, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
			}

			static Delegate cb_getPoint;
#pragma warning disable 0169
			static Delegate GetGetPointHandler ()
			{
				if (cb_getPoint == null)
					cb_getPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoint);
				return cb_getPoint;
			}

			static IntPtr n_GetPoint (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView.LayoutParams __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Point);
			}
#pragma warning restore 0169

			static Delegate cb_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetSetPoint_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
			{
				if (cb_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
					cb_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoint_Lcom_tencent_mapsdk_raster_model_LatLng_);
				return cb_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_;
			}

			static void n_SetPoint_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView.LayoutParams __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Point = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getPoint;
			static IntPtr id_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_;
			public virtual global::Com.Tencent.Mapsdk.Raster.Model.LatLng Point {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/method[@name='getPoint' and count(parameter)=0]"
				[Register ("getPoint", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetPointHandler")]
				get {
					if (id_getPoint == IntPtr.Zero)
						id_getPoint = JNIEnv.GetMethodID (class_ref, "getPoint", "()Lcom/tencent/mapsdk/raster/model/LatLng;");

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getPoint), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoint", "()Lcom/tencent/mapsdk/raster/model/LatLng;")), JniHandleOwnership.TransferLocalRef);
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/method[@name='setPoint' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
				[Register ("setPoint", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetSetPoint_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
				set {
					if (id_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
						id_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setPoint", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V");

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (value));
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPoint", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V"), new JValue (value));
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/MapView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapView); }
		}

		protected MapView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public MapView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public MapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_isAppKeyAvailable;
		public bool IsAppKeyAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='isAppKeyAvailable' and count(parameter)=0]"
			[Register ("isAppKeyAvailable", "()Z", "GetIsAppKeyAvailableHandler")]
			get {
				if (id_isAppKeyAvailable == IntPtr.Zero)
					id_isAppKeyAvailable = JNIEnv.GetMethodID (class_ref, "isAppKeyAvailable", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isAppKeyAvailable);
			}
		}

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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeSpan;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitudeSpan;
		public virtual int LatitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getLatitudeSpan' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeSpan;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitudeSpan;
		public virtual int LongitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getLongitudeSpan' and count(parameter)=0]"
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

		static Delegate cb_getMap;
#pragma warning disable 0169
		static Delegate GetGetMapHandler ()
		{
			if (cb_getMap == null)
				cb_getMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMap);
			return cb_getMap;
		}

		static IntPtr n_GetMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map);
		}
#pragma warning restore 0169

		static IntPtr id_getMap;
		public virtual global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getMap' and count(parameter)=0]"
			[Register ("getMap", "()Lcom/tencent/tencentmap/mapsdk/map/TencentMap;", "GetGetMapHandler")]
			get {
				if (id_getMap == IntPtr.Zero)
					id_getMap = JNIEnv.GetMethodID (class_ref, "getMap", "()Lcom/tencent/tencentmap/mapsdk/map/TencentMap;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (JNIEnv.CallObjectMethod  (Handle, id_getMap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMap", "()Lcom/tencent/tencentmap/mapsdk/map/TencentMap;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapCenter);
		}
#pragma warning restore 0169

		static IntPtr id_getMapCenter;
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.LatLng MapCenter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getMapCenter' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxZoomLevel;
		public virtual int MaxZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMinZoomLevel;
		public virtual int MinZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getMinZoomLevel' and count(parameter)=0]"
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

		static Delegate cb_getProjection;
#pragma warning disable 0169
		static Delegate GetGetProjectionHandler ()
		{
			if (cb_getProjection == null)
				cb_getProjection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProjection);
			return cb_getProjection;
		}

		static IntPtr n_GetProjection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Projection);
		}
#pragma warning restore 0169

		static IntPtr id_getProjection;
		public virtual global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Lcom/tencent/tencentmap/mapsdk/map/Projection;", "GetGetProjectionHandler")]
			get {
				if (id_getProjection == IntPtr.Zero)
					id_getProjection = JNIEnv.GetMethodID (class_ref, "getProjection", "()Lcom/tencent/tencentmap/mapsdk/map/Projection;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (JNIEnv.CallObjectMethod  (Handle, id_getProjection), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProjection", "()Lcom/tencent/tencentmap/mapsdk/map/Projection;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isSatellite;
#pragma warning disable 0169
		static Delegate GetIsSatelliteHandler ()
		{
			if (cb_isSatellite == null)
				cb_isSatellite = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSatellite);
			return cb_isSatellite;
		}

		static bool n_IsSatellite (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Satellite;
		}
#pragma warning restore 0169

		static Delegate cb_setSatellite_Z;
#pragma warning disable 0169
		static Delegate GetSetSatellite_ZHandler ()
		{
			if (cb_setSatellite_Z == null)
				cb_setSatellite_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSatellite_Z);
			return cb_setSatellite_Z;
		}

		static void n_SetSatellite_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Satellite = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSatellite;
		static IntPtr id_setSatellite_Z;
		public virtual bool Satellite {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='isSatellite' and count(parameter)=0]"
			[Register ("isSatellite", "()Z", "GetIsSatelliteHandler")]
			get {
				if (id_isSatellite == IntPtr.Zero)
					id_isSatellite = JNIEnv.GetMethodID (class_ref, "isSatellite", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSatellite);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSatellite", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setSatellite' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSatellite", "(Z)V", "GetSetSatellite_ZHandler")]
			set {
				if (id_setSatellite_Z == IntPtr.Zero)
					id_setSatellite_Z = JNIEnv.GetMethodID (class_ref, "setSatellite", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSatellite_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSatellite", "(Z)V"), new JValue (value));
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScalePerPixel;
		}
#pragma warning restore 0169

		static IntPtr id_getScalePerPixel;
		public virtual float ScalePerPixel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getScalePerPixel' and count(parameter)=0]"
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

		static Delegate cb_getUiSettings;
#pragma warning disable 0169
		static Delegate GetGetUiSettingsHandler ()
		{
			if (cb_getUiSettings == null)
				cb_getUiSettings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUiSettings);
			return cb_getUiSettings;
		}

		static IntPtr n_GetUiSettings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UiSettings);
		}
#pragma warning restore 0169

		static IntPtr id_getUiSettings;
		public virtual global::Com.Tencent.Tencentmap.Mapsdk.Map.UiSettings UiSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getUiSettings' and count(parameter)=0]"
			[Register ("getUiSettings", "()Lcom/tencent/tencentmap/mapsdk/map/UiSettings;", "GetGetUiSettingsHandler")]
			get {
				if (id_getUiSettings == IntPtr.Zero)
					id_getUiSettings = JNIEnv.GetMethodID (class_ref, "getUiSettings", "()Lcom/tencent/tencentmap/mapsdk/map/UiSettings;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.UiSettings> (JNIEnv.CallObjectMethod  (Handle, id_getUiSettings), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.UiSettings> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUiSettings", "()Lcom/tencent/tencentmap/mapsdk/map/UiSettings;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getVersion;
		public string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getVersion' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomLevel;
		public virtual int ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getZoomLevel' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCircle (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addCircle' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.CircleOptions']]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddGroundOverlay (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addGroundOverlay' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.GroundOverlayOptions']]"
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

		static IntPtr id_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.MarkerOptions']]"
		[Register ("addMarker", "(Lcom/tencent/mapsdk/raster/model/MarkerOptions;)Lcom/tencent/mapsdk/raster/model/Marker;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.Marker AddMarker (global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions p0)
		{
			if (id_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_ == IntPtr.Zero)
				id_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_ = JNIEnv.GetMethodID (class_ref, "addMarker", "(Lcom/tencent/mapsdk/raster/model/MarkerOptions;)Lcom/tencent/mapsdk/raster/model/Marker;");
			global::Com.Tencent.Mapsdk.Raster.Model.Marker __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (JNIEnv.CallObjectMethod  (Handle, id_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetAddOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static IntPtr n_AddOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p2 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOverlay (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addOverlay' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[3][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("addOverlay", "(Landroid/graphics/Bitmap;Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;", "GetAddOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay AddOverlay (global::Android.Graphics.Bitmap p0, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p2)
		{
			if (id_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "addOverlay", "(Landroid/graphics/Bitmap;Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;");

			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay> (JNIEnv.CallObjectMethod  (Handle, id_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOverlay", "(Landroid/graphics/Bitmap;Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;"), new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_addOverlay_Lcom_tencent_tencentmap_mapsdk_map_Overlay_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addOverlay' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.Overlay']]"
		[Register ("addOverlay", "(Lcom/tencent/tencentmap/mapsdk/map/Overlay;)Z", "")]
		public bool AddOverlay (global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay p0)
		{
			if (id_addOverlay_Lcom_tencent_tencentmap_mapsdk_map_Overlay_ == IntPtr.Zero)
				id_addOverlay_Lcom_tencent_tencentmap_mapsdk_map_Overlay_ = JNIEnv.GetMethodID (class_ref, "addOverlay", "(Lcom/tencent/tencentmap/mapsdk/map/Overlay;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_addOverlay_Lcom_tencent_tencentmap_mapsdk_map_Overlay_, new JValue (p0));
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPolygon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addPolygon' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.PolygonOptions']]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPolyline (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addPolyline' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.PolylineOptions']]"
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

		static IntPtr id_clearAllOverlays;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='clearAllOverlays' and count(parameter)=0]"
		[Register ("clearAllOverlays", "()V", "")]
		public void ClearAllOverlays ()
		{
			if (id_clearAllOverlays == IntPtr.Zero)
				id_clearAllOverlays = JNIEnv.GetMethodID (class_ref, "clearAllOverlays", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_clearAllOverlays);
		}

		static Delegate cb_layout;
#pragma warning disable 0169
		static Delegate GetLayoutHandler ()
		{
			if (cb_layout == null)
				cb_layout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Layout);
			return cb_layout;
		}

		static void n_Layout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Layout ();
		}
#pragma warning restore 0169

		static IntPtr id_layout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='layout' and count(parameter)=0]"
		[Register ("layout", "()V", "GetLayoutHandler")]
		public virtual void Layout ()
		{
			if (id_layout == IntPtr.Zero)
				id_layout = JNIEnv.GetMethodID (class_ref, "layout", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_layout);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "layout", "()V"));
		}

		static Delegate cb_layout_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetLayout_Landroid_view_View_Handler ()
		{
			if (cb_layout_Landroid_view_View_ == null)
				cb_layout_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Layout_Landroid_view_View_);
			return cb_layout_Landroid_view_View_;
		}

		static void n_Layout_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Layout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_layout_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='layout' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("layout", "(Landroid/view/View;)V", "GetLayout_Landroid_view_View_Handler")]
		public virtual void Layout (global::Android.Views.View p0)
		{
			if (id_layout_Landroid_view_View_ == IntPtr.Zero)
				id_layout_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "layout", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_layout_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "layout", "(Landroid/view/View;)V"), new JValue (p0));
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.CameraUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.CameraUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveCamera (p0);
		}
#pragma warning restore 0169

		static IntPtr id_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='moveCamera' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.CameraUpdate']]"
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

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), new JValue (p0));
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
		}

		static Delegate cb_onDestroyView;
#pragma warning disable 0169
		static Delegate GetOnDestroyViewHandler ()
		{
			if (cb_onDestroyView == null)
				cb_onDestroyView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroyView);
			return cb_onDestroyView;
		}

		static void n_OnDestroyView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroyView ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroyView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onDestroyView' and count(parameter)=0]"
		[Register ("onDestroyView", "()V", "GetOnDestroyViewHandler")]
		public virtual void OnDestroyView ()
		{
			if (id_onDestroyView == IntPtr.Zero)
				id_onDestroyView = JNIEnv.GetMethodID (class_ref, "onDestroyView", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDestroyView);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroyView", "()V"));
		}

		static Delegate cb_onLowMemory;
#pragma warning disable 0169
		static Delegate GetOnLowMemoryHandler ()
		{
			if (cb_onLowMemory == null)
				cb_onLowMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLowMemory);
			return cb_onLowMemory;
		}

		static void n_OnLowMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLowMemory ();
		}
#pragma warning restore 0169

		static IntPtr id_onLowMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onLowMemory' and count(parameter)=0]"
		[Register ("onLowMemory", "()V", "GetOnLowMemoryHandler")]
		public virtual void OnLowMemory ()
		{
			if (id_onLowMemory == IntPtr.Zero)
				id_onLowMemory = JNIEnv.GetMethodID (class_ref, "onLowMemory", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLowMemory);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLowMemory", "()V"));
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPause);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "()V"));
		}

		static Delegate cb_onRestart;
#pragma warning disable 0169
		static Delegate GetOnRestartHandler ()
		{
			if (cb_onRestart == null)
				cb_onRestart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRestart);
			return cb_onRestart;
		}

		static void n_OnRestart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRestart ();
		}
#pragma warning restore 0169

		static IntPtr id_onRestart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onRestart' and count(parameter)=0]"
		[Register ("onRestart", "()V", "GetOnRestartHandler")]
		public virtual void OnRestart ()
		{
			if (id_onRestart == IntPtr.Zero)
				id_onRestart = JNIEnv.GetMethodID (class_ref, "onRestart", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onRestart);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestart", "()V"));
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onResume);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
		}

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSaveInstanceState_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"), new JValue (p0));
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onStop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStop", "()V"));
		}

		static Delegate cb_refreshMap;
#pragma warning disable 0169
		static Delegate GetRefreshMapHandler ()
		{
			if (cb_refreshMap == null)
				cb_refreshMap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RefreshMap);
			return cb_refreshMap;
		}

		static void n_RefreshMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RefreshMap ();
		}
#pragma warning restore 0169

		static IntPtr id_refreshMap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='refreshMap' and count(parameter)=0]"
		[Register ("refreshMap", "()V", "GetRefreshMapHandler")]
		public virtual void RefreshMap ()
		{
			if (id_refreshMap == IntPtr.Zero)
				id_refreshMap = JNIEnv.GetMethodID (class_ref, "refreshMap", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_refreshMap);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshMap", "()V"));
		}

		static IntPtr id_removeOverlay_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='removeOverlay' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeOverlay", "(Ljava/lang/Object;)V", "")]
		public void RemoveOverlay (global::Java.Lang.Object p0)
		{
			if (id_removeOverlay_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeOverlay_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeOverlay", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_removeOverlay_Ljava_lang_Object_, new JValue (p0));
		}

		static Delegate cb_setLogoPosition_I;
#pragma warning disable 0169
		static Delegate GetSetLogoPosition_IHandler ()
		{
			if (cb_setLogoPosition_I == null)
				cb_setLogoPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLogoPosition_I);
			return cb_setLogoPosition_I;
		}

		static void n_SetLogoPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogoPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLogoPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setLogoPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogoPosition", "(I)V", "GetSetLogoPosition_IHandler")]
		public virtual void SetLogoPosition (int p0)
		{
			if (id_setLogoPosition_I == IntPtr.Zero)
				id_setLogoPosition_I = JNIEnv.GetMethodID (class_ref, "setLogoPosition", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLogoPosition_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogoPosition", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setPinchEnabeled_Z;
#pragma warning disable 0169
		static Delegate GetSetPinchEnabeled_ZHandler ()
		{
			if (cb_setPinchEnabeled_Z == null)
				cb_setPinchEnabeled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPinchEnabeled_Z);
			return cb_setPinchEnabeled_Z;
		}

		static void n_SetPinchEnabeled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPinchEnabeled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPinchEnabeled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setPinchEnabeled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPinchEnabeled", "(Z)V", "GetSetPinchEnabeled_ZHandler")]
		public virtual void SetPinchEnabeled (bool p0)
		{
			if (id_setPinchEnabeled_Z == IntPtr.Zero)
				id_setPinchEnabeled_Z = JNIEnv.GetMethodID (class_ref, "setPinchEnabeled", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPinchEnabeled_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPinchEnabeled", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setScalControlsEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetScalControlsEnable_ZHandler ()
		{
			if (cb_setScalControlsEnable_Z == null)
				cb_setScalControlsEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScalControlsEnable_Z);
			return cb_setScalControlsEnable_Z;
		}

		static void n_SetScalControlsEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScalControlsEnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScalControlsEnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setScalControlsEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScalControlsEnable", "(Z)V", "GetSetScalControlsEnable_ZHandler")]
		public virtual void SetScalControlsEnable (bool p0)
		{
			if (id_setScalControlsEnable_Z == IntPtr.Zero)
				id_setScalControlsEnable_Z = JNIEnv.GetMethodID (class_ref, "setScalControlsEnable", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setScalControlsEnable_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScalControlsEnable", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setScaleControlsEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleControlsEnable_ZHandler ()
		{
			if (cb_setScaleControlsEnable_Z == null)
				cb_setScaleControlsEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScaleControlsEnable_Z);
			return cb_setScaleControlsEnable_Z;
		}

		static void n_SetScaleControlsEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleControlsEnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScaleControlsEnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setScaleControlsEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScaleControlsEnable", "(Z)V", "GetSetScaleControlsEnable_ZHandler")]
		public virtual void SetScaleControlsEnable (bool p0)
		{
			if (id_setScaleControlsEnable_Z == IntPtr.Zero)
				id_setScaleControlsEnable_Z = JNIEnv.GetMethodID (class_ref, "setScaleControlsEnable", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setScaleControlsEnable_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleControlsEnable", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setScaleViewPosition_I;
#pragma warning disable 0169
		static Delegate GetSetScaleViewPosition_IHandler ()
		{
			if (cb_setScaleViewPosition_I == null)
				cb_setScaleViewPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScaleViewPosition_I);
			return cb_setScaleViewPosition_I;
		}

		static void n_SetScaleViewPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleViewPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScaleViewPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setScaleViewPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setScaleViewPosition", "(I)V", "GetSetScaleViewPosition_IHandler")]
		public virtual void SetScaleViewPosition (int p0)
		{
			if (id_setScaleViewPosition_I == IntPtr.Zero)
				id_setScaleViewPosition_I = JNIEnv.GetMethodID (class_ref, "setScaleViewPosition", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setScaleViewPosition_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleViewPosition", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setScrollGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetScrollGesturesEnabled_ZHandler ()
		{
			if (cb_setScrollGesturesEnabled_Z == null)
				cb_setScrollGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScrollGesturesEnabled_Z);
			return cb_setScrollGesturesEnabled_Z;
		}

		static void n_SetScrollGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrollGesturesEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScrollGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScrollGesturesEnabled", "(Z)V", "GetSetScrollGesturesEnabled_ZHandler")]
		public virtual void SetScrollGesturesEnabled (bool p0)
		{
			if (id_setScrollGesturesEnabled_Z == IntPtr.Zero)
				id_setScrollGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setScrollGesturesEnabled", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setScrollGesturesEnabled_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrollGesturesEnabled", "(Z)V"), new JValue (p0));
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnimation ();
		}
#pragma warning restore 0169

		static IntPtr id_stopAnimation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='stopAnimation' and count(parameter)=0]"
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

	}
}
