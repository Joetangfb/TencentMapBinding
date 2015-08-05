using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/Marker", DoNotGenerateAcw=true)]
	public sealed partial class Marker : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/Marker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Marker); }
		}

		internal Marker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAlpha;
		static IntPtr id_setAlpha_F;
		public float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				if (id_getAlpha == IntPtr.Zero)
					id_getAlpha = JNIEnv.GetMethodID (class_ref, "getAlpha", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getAlpha);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAlpha", "(F)V", "GetSetAlpha_FHandler")]
			set {
				if (id_setAlpha_F == IntPtr.Zero)
					id_setAlpha_F = JNIEnv.GetMethodID (class_ref, "setAlpha", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setAlpha_F, new JValue (value));
			}
		}

		static IntPtr id_isDraggable;
		static IntPtr id_setDraggable_Z;
		public bool Draggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				if (id_isDraggable == IntPtr.Zero)
					id_isDraggable = JNIEnv.GetMethodID (class_ref, "isDraggable", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isDraggable);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setDraggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDraggable", "(Z)V", "GetSetDraggable_ZHandler")]
			set {
				if (id_setDraggable_Z == IntPtr.Zero)
					id_setDraggable_Z = JNIEnv.GetMethodID (class_ref, "setDraggable", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setDraggable_Z, new JValue (value));
			}
		}

		static IntPtr id_getId;
		public string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_isInfoWindowShown;
		public bool IsInfoWindowShown {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='isInfoWindowShown' and count(parameter)=0]"
			[Register ("isInfoWindowShown", "()Z", "GetIsInfoWindowShownHandler")]
			get {
				if (id_isInfoWindowShown == IntPtr.Zero)
					id_isInfoWindowShown = JNIEnv.GetMethodID (class_ref, "isInfoWindowShown", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isInfoWindowShown);
			}
		}

		static IntPtr id_getMarkerView;
		static IntPtr id_setMarkerView_Landroid_view_View_;
		public global::Android.Views.View MarkerView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='getMarkerView' and count(parameter)=0]"
			[Register ("getMarkerView", "()Landroid/view/View;", "GetGetMarkerViewHandler")]
			get {
				if (id_getMarkerView == IntPtr.Zero)
					id_getMarkerView = JNIEnv.GetMethodID (class_ref, "getMarkerView", "()Landroid/view/View;");
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getMarkerView), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setMarkerView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setMarkerView", "(Landroid/view/View;)V", "GetSetMarkerView_Landroid_view_View_Handler")]
			set {
				if (id_setMarkerView_Landroid_view_View_ == IntPtr.Zero)
					id_setMarkerView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setMarkerView", "(Landroid/view/View;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setMarkerView_Landroid_view_View_, new JValue (value));
			}
		}

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_Lcom_tencent_mapsdk_raster_model_LatLng_;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/tencent/mapsdk/raster/model/LatLng;");
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
			[Register ("setPosition", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetSetPosition_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
			set {
				if (id_setPosition_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
					id_setPosition_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V");
				JNIEnv.CallVoidMethod  (Handle, id_setPosition_Lcom_tencent_mapsdk_raster_model_LatLng_, new JValue (value));
			}
		}

		static IntPtr id_getRotation;
		static IntPtr id_setRotation_F;
		public float Rotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='getRotation' and count(parameter)=0]"
			[Register ("getRotation", "()F", "GetGetRotationHandler")]
			get {
				if (id_getRotation == IntPtr.Zero)
					id_getRotation = JNIEnv.GetMethodID (class_ref, "getRotation", "()F");
				return JNIEnv.CallFloatMethod  (Handle, id_getRotation);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRotation", "(F)V", "GetSetRotation_FHandler")]
			set {
				if (id_setRotation_F == IntPtr.Zero)
					id_setRotation_F = JNIEnv.GetMethodID (class_ref, "setRotation", "(F)V");
				JNIEnv.CallVoidMethod  (Handle, id_setRotation_F, new JValue (value));
			}
		}

		static IntPtr id_getSnippet;
		static IntPtr id_setSnippet_Ljava_lang_String_;
		public string Snippet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='getSnippet' and count(parameter)=0]"
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler")]
			get {
				if (id_getSnippet == IntPtr.Zero)
					id_getSnippet = JNIEnv.GetMethodID (class_ref, "getSnippet", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSnippet), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setSnippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSnippet", "(Ljava/lang/String;)V", "GetSetSnippet_Ljava_lang_String_Handler")]
			set {
				if (id_setSnippet_Ljava_lang_String_ == IntPtr.Zero)
					id_setSnippet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSnippet", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setSnippet_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setVisible_Z, new JValue (value));
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_hashCode);
		}

		static IntPtr id_hideInfoWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='hideInfoWindow' and count(parameter)=0]"
		[Register ("hideInfoWindow", "()V", "")]
		public void HideInfoWindow ()
		{
			if (id_hideInfoWindow == IntPtr.Zero)
				id_hideInfoWindow = JNIEnv.GetMethodID (class_ref, "hideInfoWindow", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_hideInfoWindow);
		}

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "")]
		public void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_remove);
		}

		static IntPtr id_set2Top;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='set2Top' and count(parameter)=0]"
		[Register ("set2Top", "()V", "")]
		public void Set2Top ()
		{
			if (id_set2Top == IntPtr.Zero)
				id_set2Top = JNIEnv.GetMethodID (class_ref, "set2Top", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_set2Top);
		}

		static IntPtr id_setAnchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setAnchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setAnchor", "(FF)V", "")]
		public void SetAnchor (float p0, float p1)
		{
			if (id_setAnchor_FF == IntPtr.Zero)
				id_setAnchor_FF = JNIEnv.GetMethodID (class_ref, "setAnchor", "(FF)V");
			JNIEnv.CallVoidMethod  (Handle, id_setAnchor_FF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setIcon_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.BitmapDescriptor']]"
		[Register ("setIcon", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)V", "")]
		public void SetIcon (global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor p0)
		{
			if (id_setIcon_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_ == IntPtr.Zero)
				id_setIcon_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setIcon_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_, new JValue (p0));
		}

		static IntPtr id_setInfoWindowHideAnimation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setInfoWindowHideAnimation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setInfoWindowHideAnimation", "(I)V", "")]
		public void SetInfoWindowHideAnimation (int p0)
		{
			if (id_setInfoWindowHideAnimation_I == IntPtr.Zero)
				id_setInfoWindowHideAnimation_I = JNIEnv.GetMethodID (class_ref, "setInfoWindowHideAnimation", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setInfoWindowHideAnimation_I, new JValue (p0));
		}

		static IntPtr id_setInfoWindowShowAnimation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='setInfoWindowShowAnimation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setInfoWindowShowAnimation", "(I)V", "")]
		public void SetInfoWindowShowAnimation (int p0)
		{
			if (id_setInfoWindowShowAnimation_I == IntPtr.Zero)
				id_setInfoWindowShowAnimation_I = JNIEnv.GetMethodID (class_ref, "setInfoWindowShowAnimation", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setInfoWindowShowAnimation_I, new JValue (p0));
		}

		static IntPtr id_showInfoWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Marker']/method[@name='showInfoWindow' and count(parameter)=0]"
		[Register ("showInfoWindow", "()V", "")]
		public void ShowInfoWindow ()
		{
			if (id_showInfoWindow == IntPtr.Zero)
				id_showInfoWindow = JNIEnv.GetMethodID (class_ref, "showInfoWindow", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_showInfoWindow);
		}

	}
}
