using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/Polyline", DoNotGenerateAcw=true)]
	public partial class Polyline : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/mapsdk/raster/model/Polyline", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Polyline); }
		}

		protected Polyline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Color = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		static IntPtr id_setColor_I;
		public virtual int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				if (id_setColor_I == IntPtr.Zero)
					id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_isDottedLine;
#pragma warning disable 0169
		static Delegate GetIsDottedLineHandler ()
		{
			if (cb_isDottedLine == null)
				cb_isDottedLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDottedLine);
			return cb_isDottedLine;
		}

		static bool n_IsDottedLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DottedLine;
		}
#pragma warning restore 0169

		static Delegate cb_setDottedLine_Z;
#pragma warning disable 0169
		static Delegate GetSetDottedLine_ZHandler ()
		{
			if (cb_setDottedLine_Z == null)
				cb_setDottedLine_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDottedLine_Z);
			return cb_setDottedLine_Z;
		}

		static void n_SetDottedLine_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DottedLine = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDottedLine;
		static IntPtr id_setDottedLine_Z;
		public virtual bool DottedLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='isDottedLine' and count(parameter)=0]"
			[Register ("isDottedLine", "()Z", "GetIsDottedLineHandler")]
			get {
				if (id_isDottedLine == IntPtr.Zero)
					id_isDottedLine = JNIEnv.GetMethodID (class_ref, "isDottedLine", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDottedLine);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDottedLine", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='setDottedLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDottedLine", "(Z)V", "GetSetDottedLine_ZHandler")]
			set {
				if (id_setDottedLine_Z == IntPtr.Zero)
					id_setDottedLine_Z = JNIEnv.GetMethodID (class_ref, "setDottedLine", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDottedLine_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDottedLine", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_isGeodesic;
#pragma warning disable 0169
		static Delegate GetIsGeodesicHandler ()
		{
			if (cb_isGeodesic == null)
				cb_isGeodesic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGeodesic);
			return cb_isGeodesic;
		}

		static bool n_IsGeodesic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Geodesic;
		}
#pragma warning restore 0169

		static Delegate cb_setGeodesic_Z;
#pragma warning disable 0169
		static Delegate GetSetGeodesic_ZHandler ()
		{
			if (cb_setGeodesic_Z == null)
				cb_setGeodesic_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetGeodesic_Z);
			return cb_setGeodesic_Z;
		}

		static void n_SetGeodesic_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Geodesic = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isGeodesic;
		static IntPtr id_setGeodesic_Z;
		public virtual bool Geodesic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='isGeodesic' and count(parameter)=0]"
			[Register ("isGeodesic", "()Z", "GetIsGeodesicHandler")]
			get {
				if (id_isGeodesic == IntPtr.Zero)
					id_isGeodesic = JNIEnv.GetMethodID (class_ref, "isGeodesic", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isGeodesic);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGeodesic", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='setGeodesic' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setGeodesic", "(Z)V", "GetSetGeodesic_ZHandler")]
			set {
				if (id_setGeodesic_Z == IntPtr.Zero)
					id_setGeodesic_Z = JNIEnv.GetMethodID (class_ref, "setGeodesic", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGeodesic_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGeodesic", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPoints;
#pragma warning disable 0169
		static Delegate GetGetPointsHandler ()
		{
			if (cb_getPoints == null)
				cb_getPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoints);
			return cb_getPoints;
		}

		static IntPtr n_GetPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Tencent.Mapsdk.Raster.Model.LatLng>.ToLocalJniHandle (__this.Points);
		}
#pragma warning restore 0169

		static Delegate cb_setPoints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPoints_Ljava_util_List_Handler ()
		{
			if (cb_setPoints_Ljava_util_List_ == null)
				cb_setPoints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoints_Ljava_util_List_);
			return cb_setPoints_Ljava_util_List_;
		}

		static void n_SetPoints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Tencent.Mapsdk.Raster.Model.LatLng> p0 = global::Android.Runtime.JavaList<global::Com.Tencent.Mapsdk.Raster.Model.LatLng>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Points = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPoints;
		static IntPtr id_setPoints_Ljava_util_List_;
		public virtual global::System.Collections.Generic.IList<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Tencent.Mapsdk.Raster.Model.LatLng>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Tencent.Mapsdk.Raster.Model.LatLng>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoints", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='setPoints' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setPoints", "(Ljava/util/List;)V", "GetSetPoints_Ljava_util_List_Handler")]
			set {
				if (id_setPoints_Ljava_util_List_ == IntPtr.Zero)
					id_setPoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Tencent.Mapsdk.Raster.Model.LatLng>.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPoints_Ljava_util_List_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPoints", "(Ljava/util/List;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public virtual bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVisible", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setVisible_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisible", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWidth);
			return cb_getWidth;
		}

		static float n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_F;
#pragma warning disable 0169
		static Delegate GetSetWidth_FHandler ()
		{
			if (cb_setWidth_F == null)
				cb_setWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetWidth_F);
			return cb_setWidth_F;
		}

		static void n_SetWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_F;
		public virtual float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWidth", "(F)V", "GetSetWidth_FHandler")]
			set {
				if (id_setWidth_F == IntPtr.Zero)
					id_setWidth_F = JNIEnv.GetMethodID (class_ref, "setWidth", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWidth_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getZIndex;
#pragma warning disable 0169
		static Delegate GetGetZIndexHandler ()
		{
			if (cb_getZIndex == null)
				cb_getZIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZIndex);
			return cb_getZIndex;
		}

		static float n_GetZIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setZIndex_F;
#pragma warning disable 0169
		static Delegate GetSetZIndex_FHandler ()
		{
			if (cb_setZIndex_F == null)
				cb_setZIndex_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZIndex_F);
			return cb_setZIndex_F;
		}

		static void n_SetZIndex_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZIndex;
		static IntPtr id_setZIndex_F;
		public virtual float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZIndex", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler")]
			set {
				if (id_setZIndex_F == IntPtr.Zero)
					id_setZIndex_F = JNIEnv.GetMethodID (class_ref, "setZIndex", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZIndex_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZIndex", "(F)V"), new JValue (value));
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_equals_Ljava_lang_Object_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_hashCode);
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Raster.Model.Polyline __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='Polyline']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler")]
		public virtual void Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "()V"));
		}

	}
}
