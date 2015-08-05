using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/MarkerOptions", DoNotGenerateAcw=true)]
	public sealed partial class MarkerOptions : global::Java.Lang.Object {


		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/field[@name='id']"
		[Register ("id")]
		protected string Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, id_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/MarkerOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarkerOptions); }
		}

		internal MarkerOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/constructor[@name='MarkerOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MarkerOptions () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MarkerOptions)) {
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

		static IntPtr id_getAlpha;
		public float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				if (id_getAlpha == IntPtr.Zero)
					id_getAlpha = JNIEnv.GetMethodID (class_ref, "getAlpha", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAlpha);
			}
		}

		static IntPtr id_getAnchorU;
		public float AnchorU {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getAnchorU' and count(parameter)=0]"
			[Register ("getAnchorU", "()F", "GetGetAnchorUHandler")]
			get {
				if (id_getAnchorU == IntPtr.Zero)
					id_getAnchorU = JNIEnv.GetMethodID (class_ref, "getAnchorU", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAnchorU);
			}
		}

		static IntPtr id_getAnchorV;
		public float AnchorV {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getAnchorV' and count(parameter)=0]"
			[Register ("getAnchorV", "()F", "GetGetAnchorVHandler")]
			get {
				if (id_getAnchorV == IntPtr.Zero)
					id_getAnchorV = JNIEnv.GetMethodID (class_ref, "getAnchorV", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAnchorV);
			}
		}

		static IntPtr id_getIcon;
		public global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "GetGetIconHandler")]
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (JNIEnv.CallObjectMethod  (Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getInfoWindowHideAnimation;
		public int InfoWindowHideAnimation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getInfoWindowHideAnimation' and count(parameter)=0]"
			[Register ("getInfoWindowHideAnimation", "()I", "GetGetInfoWindowHideAnimationHandler")]
			get {
				if (id_getInfoWindowHideAnimation == IntPtr.Zero)
					id_getInfoWindowHideAnimation = JNIEnv.GetMethodID (class_ref, "getInfoWindowHideAnimation", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getInfoWindowHideAnimation);
			}
		}

		static IntPtr id_getInfoWindowShowAnimation;
		public int InfoWindowShowAnimation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getInfoWindowShowAnimation' and count(parameter)=0]"
			[Register ("getInfoWindowShowAnimation", "()I", "GetGetInfoWindowShowAnimationHandler")]
			get {
				if (id_getInfoWindowShowAnimation == IntPtr.Zero)
					id_getInfoWindowShowAnimation = JNIEnv.GetMethodID (class_ref, "getInfoWindowShowAnimation", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getInfoWindowShowAnimation);
			}
		}

		static IntPtr id_isDraggable;
		public bool IsDraggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				if (id_isDraggable == IntPtr.Zero)
					id_isDraggable = JNIEnv.GetMethodID (class_ref, "isDraggable", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isDraggable);
			}
		}

		static IntPtr id_isGps;
		public bool IsGps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='isGps' and count(parameter)=0]"
			[Register ("isGps", "()Z", "GetIsGpsHandler")]
			get {
				if (id_isGps == IntPtr.Zero)
					id_isGps = JNIEnv.GetMethodID (class_ref, "isGps", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isGps);
			}
		}

		static IntPtr id_isVisible;
		public bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
		}

		static IntPtr id_getMarkerView;
		public global::Android.Views.View MarkerView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getMarkerView' and count(parameter)=0]"
			[Register ("getMarkerView", "()Landroid/view/View;", "GetGetMarkerViewHandler")]
			get {
				if (id_getMarkerView == IntPtr.Zero)
					id_getMarkerView = JNIEnv.GetMethodID (class_ref, "getMarkerView", "()Landroid/view/View;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getMarkerView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPosition;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getRotation;
		public float Rotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getRotation' and count(parameter)=0]"
			[Register ("getRotation", "()F", "GetGetRotationHandler")]
			get {
				if (id_getRotation == IntPtr.Zero)
					id_getRotation = JNIEnv.GetMethodID (class_ref, "getRotation", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getRotation);
			}
		}

		static IntPtr id_getSnippet;
		public string Snippet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getSnippet' and count(parameter)=0]"
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler")]
			get {
				if (id_getSnippet == IntPtr.Zero)
					id_getSnippet = JNIEnv.GetMethodID (class_ref, "getSnippet", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSnippet), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getTitle;
		public string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_alpha_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='alpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alpha", "(F)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeAlpha (float p0)
		{
			if (id_alpha_F == IntPtr.Zero)
				id_alpha_F = JNIEnv.GetMethodID (class_ref, "alpha", "(F)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_alpha_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_anchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='anchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("anchor", "(FF)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions Anchor (float p0, float p1)
		{
			if (id_anchor_FF == IntPtr.Zero)
				id_anchor_FF = JNIEnv.GetMethodID (class_ref, "anchor", "(FF)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_anchor_FF, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_draggable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='draggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("draggable", "(Z)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions Draggable (bool p0)
		{
			if (id_draggable_Z == IntPtr.Zero)
				id_draggable_Z = JNIEnv.GetMethodID (class_ref, "draggable", "(Z)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_draggable_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_icon_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='icon' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.BitmapDescriptor']]"
		[Register ("icon", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeIcon (global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor p0)
		{
			if (id_icon_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_ == IntPtr.Zero)
				id_icon_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "icon", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_icon_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_infoWindowHideAnimation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='infoWindowHideAnimation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("infoWindowHideAnimation", "(I)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeInfoWindowHideAnimation (int p0)
		{
			if (id_infoWindowHideAnimation_I == IntPtr.Zero)
				id_infoWindowHideAnimation_I = JNIEnv.GetMethodID (class_ref, "infoWindowHideAnimation", "(I)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_infoWindowHideAnimation_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_infoWindowShowAnimation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='infoWindowShowAnimation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("infoWindowShowAnimation", "(I)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeInfoWindowShowAnimation (int p0)
		{
			if (id_infoWindowShowAnimation_I == IntPtr.Zero)
				id_infoWindowShowAnimation_I = JNIEnv.GetMethodID (class_ref, "infoWindowShowAnimation", "(I)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_infoWindowShowAnimation_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_markerView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='markerView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("markerView", "(Landroid/view/View;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeMarkerView (global::Android.Views.View p0)
		{
			if (id_markerView_Landroid_view_View_ == IntPtr.Zero)
				id_markerView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "markerView", "(Landroid/view/View;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_markerView_Landroid_view_View_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_position_Lcom_tencent_mapsdk_raster_model_LatLng_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='position' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("position", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokePosition (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_position_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_position_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "position", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_position_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_rotation_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='rotation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotation", "(F)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeRotation (float p0)
		{
			if (id_rotation_F == IntPtr.Zero)
				id_rotation_F = JNIEnv.GetMethodID (class_ref, "rotation", "(F)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_rotation_F, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_snippet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='snippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("snippet", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeSnippet (string p0)
		{
			if (id_snippet_Ljava_lang_String_ == IntPtr.Zero)
				id_snippet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "snippet", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_snippet_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_title_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='title' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("title", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeTitle (string p0)
		{
			if (id_title_Ljava_lang_String_ == IntPtr.Zero)
				id_title_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "title", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions __ret = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_title_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_visible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions Visible (bool p0)
		{
			if (id_visible_Z == IntPtr.Zero)
				id_visible_Z = JNIEnv.GetMethodID (class_ref, "visible", "(Z)Lcom/tencent/mapsdk/raster/model/MarkerOptions;");
			return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (JNIEnv.CallObjectMethod  (Handle, id_visible_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
