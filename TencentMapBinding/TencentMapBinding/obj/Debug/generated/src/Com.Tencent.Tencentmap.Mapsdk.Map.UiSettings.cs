using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/UiSettings", DoNotGenerateAcw=true)]
	public sealed partial class UiSettings : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_CENTER_BOTTOM']"
		[Register ("LOGO_POSITION_CENTER_BOTTOM")]
		public const int LogoPositionCenterBottom = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_CENTER_TOP']"
		[Register ("LOGO_POSITION_CENTER_TOP")]
		public const int LogoPositionCenterTop = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_LEFT_BOTTOM']"
		[Register ("LOGO_POSITION_LEFT_BOTTOM")]
		public const int LogoPositionLeftBottom = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_LEFT_TOP']"
		[Register ("LOGO_POSITION_LEFT_TOP")]
		public const int LogoPositionLeftTop = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_RIGHT_BOTTOM']"
		[Register ("LOGO_POSITION_RIGHT_BOTTOM")]
		public const int LogoPositionRightBottom = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='LOGO_POSITION_RIGHT_TOP']"
		[Register ("LOGO_POSITION_RIGHT_TOP")]
		public const int LogoPositionRightTop = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='SCALEVIEW_POSITION_CENTER_BOTTOM']"
		[Register ("SCALEVIEW_POSITION_CENTER_BOTTOM")]
		public const int ScaleviewPositionCenterBottom = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='SCALEVIEW_POSITION_LEFT_BOTTOM']"
		[Register ("SCALEVIEW_POSITION_LEFT_BOTTOM")]
		public const int ScaleviewPositionLeftBottom = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/field[@name='SCALEVIEW_POSITION_RIGHT_BOTTOM']"
		[Register ("SCALEVIEW_POSITION_RIGHT_BOTTOM")]
		public const int ScaleviewPositionRightBottom = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/UiSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UiSettings); }
		}

		internal UiSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isAnimationEnabled;
		static IntPtr id_setAnimationEnabled_Z;
		public bool AnimationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='isAnimationEnabled' and count(parameter)=0]"
			[Register ("isAnimationEnabled", "()Z", "GetIsAnimationEnabledHandler")]
			get {
				if (id_isAnimationEnabled == IntPtr.Zero)
					id_isAnimationEnabled = JNIEnv.GetMethodID (class_ref, "isAnimationEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isAnimationEnabled);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setAnimationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAnimationEnabled", "(Z)V", "GetSetAnimationEnabled_ZHandler")]
			set {
				if (id_setAnimationEnabled_Z == IntPtr.Zero)
					id_setAnimationEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAnimationEnabled", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setAnimationEnabled_Z, new JValue (value));
			}
		}

		static IntPtr id_isScaleControlsEnabled;
		protected bool IsScaleControlsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='isScaleControlsEnabled' and count(parameter)=0]"
			[Register ("isScaleControlsEnabled", "()Z", "GetIsScaleControlsEnabledHandler")]
			get {
				if (id_isScaleControlsEnabled == IntPtr.Zero)
					id_isScaleControlsEnabled = JNIEnv.GetMethodID (class_ref, "isScaleControlsEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isScaleControlsEnabled);
			}
		}

		static IntPtr id_isScrollGesturesEnabled;
		protected bool IsScrollGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='isScrollGesturesEnabled' and count(parameter)=0]"
			[Register ("isScrollGesturesEnabled", "()Z", "GetIsScrollGesturesEnabledHandler")]
			get {
				if (id_isScrollGesturesEnabled == IntPtr.Zero)
					id_isScrollGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isScrollGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isScrollGesturesEnabled);
			}
		}

		static IntPtr id_isZoomGesturesEnabled;
		protected bool IsZoomGesturesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='isZoomGesturesEnabled' and count(parameter)=0]"
			[Register ("isZoomGesturesEnabled", "()Z", "GetIsZoomGesturesEnabledHandler")]
			get {
				if (id_isZoomGesturesEnabled == IntPtr.Zero)
					id_isZoomGesturesEnabled = JNIEnv.GetMethodID (class_ref, "isZoomGesturesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isZoomGesturesEnabled);
			}
		}

		static IntPtr id_getLogoPosition;
		protected int LogoPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='getLogoPosition' and count(parameter)=0]"
			[Register ("getLogoPosition", "()I", "GetGetLogoPositionHandler")]
			get {
				if (id_getLogoPosition == IntPtr.Zero)
					id_getLogoPosition = JNIEnv.GetMethodID (class_ref, "getLogoPosition", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getLogoPosition);
			}
		}

		static IntPtr id_getScaleViewPosition;
		protected int ScaleViewPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='getScaleViewPosition' and count(parameter)=0]"
			[Register ("getScaleViewPosition", "()I", "GetGetScaleViewPositionHandler")]
			get {
				if (id_getScaleViewPosition == IntPtr.Zero)
					id_getScaleViewPosition = JNIEnv.GetMethodID (class_ref, "getScaleViewPosition", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getScaleViewPosition);
			}
		}

		static IntPtr id_setAllGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setAllGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllGesturesEnabled", "(Z)V", "")]
		protected void SetAllGesturesEnabled (bool p0)
		{
			if (id_setAllGesturesEnabled_Z == IntPtr.Zero)
				id_setAllGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAllGesturesEnabled", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setAllGesturesEnabled_Z, new JValue (p0));
		}

		static IntPtr id_setLogoPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setLogoPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogoPosition", "(I)V", "")]
		public void SetLogoPosition (int p0)
		{
			if (id_setLogoPosition_I == IntPtr.Zero)
				id_setLogoPosition_I = JNIEnv.GetMethodID (class_ref, "setLogoPosition", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setLogoPosition_I, new JValue (p0));
		}

		static IntPtr id_setScaleControlsEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setScaleControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScaleControlsEnabled", "(Z)V", "")]
		public void SetScaleControlsEnabled (bool p0)
		{
			if (id_setScaleControlsEnabled_Z == IntPtr.Zero)
				id_setScaleControlsEnabled_Z = JNIEnv.GetMethodID (class_ref, "setScaleControlsEnabled", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setScaleControlsEnabled_Z, new JValue (p0));
		}

		static IntPtr id_setScaleViewPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setScaleViewPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setScaleViewPosition", "(I)V", "")]
		public void SetScaleViewPosition (int p0)
		{
			if (id_setScaleViewPosition_I == IntPtr.Zero)
				id_setScaleViewPosition_I = JNIEnv.GetMethodID (class_ref, "setScaleViewPosition", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setScaleViewPosition_I, new JValue (p0));
		}

		static IntPtr id_setScrollGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScrollGesturesEnabled", "(Z)V", "")]
		public void SetScrollGesturesEnabled (bool p0)
		{
			if (id_setScrollGesturesEnabled_Z == IntPtr.Zero)
				id_setScrollGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setScrollGesturesEnabled", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setScrollGesturesEnabled_Z, new JValue (p0));
		}

		static IntPtr id_setZoomGesturesEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='UiSettings']/method[@name='setZoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setZoomGesturesEnabled", "(Z)V", "")]
		public void SetZoomGesturesEnabled (bool p0)
		{
			if (id_setZoomGesturesEnabled_Z == IntPtr.Zero)
				id_setZoomGesturesEnabled_Z = JNIEnv.GetMethodID (class_ref, "setZoomGesturesEnabled", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_setZoomGesturesEnabled_Z, new JValue (p0));
		}

	}
}
