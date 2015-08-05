using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/Overlay", DoNotGenerateAcw=true)]
	public partial class Overlay : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/field[@name='SHADOW_X_SKEW']"
		[Register ("SHADOW_X_SKEW")]
		protected const float ShadowXSkew = (float) -0.890000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/field[@name='SHADOW_Y_SCALE']"
		[Register ("SHADOW_Y_SCALE")]
		protected const float ShadowYScale = (float) 0.500000;

		static IntPtr isVisible_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/field[@name='isVisible']"
		[Register ("isVisible")]
		protected bool IsVisible {
			get {
				if (isVisible_jfieldId == IntPtr.Zero)
					isVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "isVisible", "Z");
				return JNIEnv.GetBooleanField (Handle, isVisible_jfieldId);
			}
			set {
				if (isVisible_jfieldId == IntPtr.Zero)
					isVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "isVisible", "Z");
				JNIEnv.SetField (Handle, isVisible_jfieldId, value);
			}
		}

		static IntPtr mapView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/field[@name='mapView']"
		[Register ("mapView")]
		protected global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView MapView {
			get {
				if (mapView_jfieldId == IntPtr.Zero)
					mapView_jfieldId = JNIEnv.GetFieldID (class_ref, "mapView", "Lcom/tencent/tencentmap/mapsdk/map/MapView;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mapView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mapView_jfieldId == IntPtr.Zero)
					mapView_jfieldId = JNIEnv.GetFieldID (class_ref, "mapView", "Lcom/tencent/tencentmap/mapsdk/map/MapView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mapView_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/Overlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Overlay); }
		}

		protected Overlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/constructor[@name='Overlay' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Overlay () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Overlay)) {
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='getId' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public virtual bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVisible", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZIndex;
		static IntPtr id_setZIndex_F;
		public virtual float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				if (id_getZIndex == IntPtr.Zero)
					id_getZIndex = JNIEnv.GetMethodID (class_ref, "getZIndex", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getZIndex);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZIndex", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_checkInBounds;
#pragma warning disable 0169
		static Delegate GetCheckInBoundsHandler ()
		{
			if (cb_checkInBounds == null)
				cb_checkInBounds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckInBounds);
			return cb_checkInBounds;
		}

		static bool n_CheckInBounds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckInBounds ();
		}
#pragma warning restore 0169

		static IntPtr id_checkInBounds;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='checkInBounds' and count(parameter)=0]"
		[Register ("checkInBounds", "()Z", "GetCheckInBoundsHandler")]
		public virtual bool CheckInBounds ()
		{
			if (id_checkInBounds == IntPtr.Zero)
				id_checkInBounds = JNIEnv.GetMethodID (class_ref, "checkInBounds", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_checkInBounds);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkInBounds", "()Z"));
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_destroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public virtual void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), new JValue (p0));
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='draw' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lcom/tencent/tencentmap/mapsdk/map/MapView;)V", "GetDraw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		protected virtual void Draw (global::Android.Graphics.Canvas p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
		{
			if (id_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lcom/tencent/tencentmap/mapsdk/map/MapView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lcom/tencent/tencentmap/mapsdk/map/MapView;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_hashCodeRemote;
#pragma warning disable 0169
		static Delegate GetHashCodeRemoteHandler ()
		{
			if (cb_hashCodeRemote == null)
				cb_hashCodeRemote = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_HashCodeRemote);
			return cb_hashCodeRemote;
		}

		static int n_HashCodeRemote (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HashCodeRemote ();
		}
#pragma warning restore 0169

		static IntPtr id_hashCodeRemote;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='hashCodeRemote' and count(parameter)=0]"
		[Register ("hashCodeRemote", "()I", "GetHashCodeRemoteHandler")]
		public virtual int HashCodeRemote ()
		{
			if (id_hashCodeRemote == IntPtr.Zero)
				id_hashCodeRemote = JNIEnv.GetMethodID (class_ref, "hashCodeRemote", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_hashCodeRemote);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hashCodeRemote", "()I"));
		}

		static Delegate cb_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static void n_Init_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("init", "(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V", "GetInit_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual void Init (global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p0)
		{
			if (id_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == IntPtr.Zero)
				id_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V"), new JValue (p0));
		}

		static Delegate cb_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetOnEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler ()
		{
			if (cb_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == null)
				cb_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_);
			return cb_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		}

		static void n_OnEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEmptyTap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='onEmptyTap' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint']]"
		[Register ("onEmptyTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V", "GetOnEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler")]
		public virtual void OnEmptyTap (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0)
		{
			if (id_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == IntPtr.Zero)
				id_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "onEmptyTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onEmptyTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V"), new JValue (p0));
		}

		static Delegate cb_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetOnLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static bool n_OnLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p2 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnLongPress (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='onLongPress' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("onLongPress", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Landroid/view/MotionEvent;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z", "GetOnLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual bool OnLongPress (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Android.Views.MotionEvent p1, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p2)
		{
			if (id_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == IntPtr.Zero)
				id_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNIEnv.GetMethodID (class_ref, "onLongPress", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Landroid/view/MotionEvent;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLongPress", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Landroid/view/MotionEvent;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z"), new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static Delegate cb_onRemoveOverlay;
#pragma warning disable 0169
		static Delegate GetOnRemoveOverlayHandler ()
		{
			if (cb_onRemoveOverlay == null)
				cb_onRemoveOverlay = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRemoveOverlay);
			return cb_onRemoveOverlay;
		}

		static void n_OnRemoveOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoveOverlay ();
		}
#pragma warning restore 0169

		static IntPtr id_onRemoveOverlay;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='onRemoveOverlay' and count(parameter)=0]"
		[Register ("onRemoveOverlay", "()V", "GetOnRemoveOverlayHandler")]
		public virtual void OnRemoveOverlay ()
		{
			if (id_onRemoveOverlay == IntPtr.Zero)
				id_onRemoveOverlay = JNIEnv.GetMethodID (class_ref, "onRemoveOverlay", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onRemoveOverlay);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRemoveOverlay", "()V"));
		}

		static Delegate cb_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetOnTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static bool n_OnTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTap (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='onTap' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("onTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z", "GetOnTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual bool OnTap (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
		{
			if (id_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == IntPtr.Zero)
				id_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNIEnv.GetMethodID (class_ref, "onTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='onTouchEvent' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual bool OnTouchEvent (global::Android.Views.MotionEvent p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='remove' and count(parameter)=0]"
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
