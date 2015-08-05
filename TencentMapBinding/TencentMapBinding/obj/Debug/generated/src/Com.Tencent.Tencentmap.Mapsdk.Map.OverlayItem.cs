using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/OverlayItem", DoNotGenerateAcw=true)]
	public partial class OverlayItem : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr boDragable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/field[@name='boDragable']"
		[Register ("boDragable")]
		protected bool BoDragable {
			get {
				if (boDragable_jfieldId == IntPtr.Zero)
					boDragable_jfieldId = JNIEnv.GetFieldID (class_ref, "boDragable", "Z");
				return JNIEnv.GetBooleanField (Handle, boDragable_jfieldId);
			}
			set {
				if (boDragable_jfieldId == IntPtr.Zero)
					boDragable_jfieldId = JNIEnv.GetFieldID (class_ref, "boDragable", "Z");
				JNIEnv.SetField (Handle, boDragable_jfieldId, value);
			}
		}

		static IntPtr mPoint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/field[@name='mPoint']"
		[Register ("mPoint")]
		protected global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint MPoint {
			get {
				if (mPoint_jfieldId == IntPtr.Zero)
					mPoint_jfieldId = JNIEnv.GetFieldID (class_ref, "mPoint", "Lcom/tencent/mapsdk/raster/model/GeoPoint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPoint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPoint_jfieldId == IntPtr.Zero)
					mPoint_jfieldId = JNIEnv.GetFieldID (class_ref, "mPoint", "Lcom/tencent/mapsdk/raster/model/GeoPoint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPoint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSnippet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/field[@name='mSnippet']"
		[Register ("mSnippet")]
		protected string MSnippet {
			get {
				if (mSnippet_jfieldId == IntPtr.Zero)
					mSnippet_jfieldId = JNIEnv.GetFieldID (class_ref, "mSnippet", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSnippet_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSnippet_jfieldId == IntPtr.Zero)
					mSnippet_jfieldId = JNIEnv.GetFieldID (class_ref, "mSnippet", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mSnippet_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mTitle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/field[@name='mTitle']"
		[Register ("mTitle")]
		protected string MTitle {
			get {
				if (mTitle_jfieldId == IntPtr.Zero)
					mTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "mTitle", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTitle_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTitle_jfieldId == IntPtr.Zero)
					mTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "mTitle", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mTitle_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tencent/tencentmap/mapsdk/map/OverlayItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayItem); }
		}

		protected OverlayItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/constructor[@name='OverlayItem' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public OverlayItem (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = JNIEnv.NewString (p2);;
			if (GetType () != typeof (OverlayItem)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/constructor[@name='OverlayItem' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected OverlayItem (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OverlayItem)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
				id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0));
		}

		static Delegate cb_isDragable;
#pragma warning disable 0169
		static Delegate GetIsDragableHandler ()
		{
			if (cb_isDragable == null)
				cb_isDragable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDragable);
			return cb_isDragable;
		}

		static bool n_IsDragable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dragable;
		}
#pragma warning restore 0169

		static Delegate cb_setDragable_Z;
#pragma warning disable 0169
		static Delegate GetSetDragable_ZHandler ()
		{
			if (cb_setDragable_Z == null)
				cb_setDragable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDragable_Z);
			return cb_setDragable_Z;
		}

		static void n_SetDragable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dragable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDragable;
		static IntPtr id_setDragable_Z;
		public virtual bool Dragable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/method[@name='isDragable' and count(parameter)=0]"
			[Register ("isDragable", "()Z", "GetIsDragableHandler")]
			get {
				if (id_isDragable == IntPtr.Zero)
					id_isDragable = JNIEnv.GetMethodID (class_ref, "isDragable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDragable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDragable", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/method[@name='setDragable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDragable", "(Z)V", "GetSetDragable_ZHandler")]
			set {
				if (id_setDragable_Z == IntPtr.Zero)
					id_setDragable_Z = JNIEnv.GetMethodID (class_ref, "setDragable", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDragable_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDragable", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getMarker;
#pragma warning disable 0169
		static Delegate GetGetMarkerHandler ()
		{
			if (cb_getMarker == null)
				cb_getMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarker);
			return cb_getMarker;
		}

		static IntPtr n_GetMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Marker);
		}
#pragma warning restore 0169

		static Delegate cb_setMarker_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetMarker_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setMarker_Landroid_graphics_drawable_Drawable_ == null)
				cb_setMarker_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarker_Landroid_graphics_drawable_Drawable_);
			return cb_setMarker_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetMarker_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Marker = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMarker;
		static IntPtr id_setMarker_Landroid_graphics_drawable_Drawable_;
		public virtual global::Android.Graphics.Drawables.Drawable Marker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Landroid/graphics/drawable/Drawable;", "GetGetMarkerHandler")]
			get {
				if (id_getMarker == IntPtr.Zero)
					id_getMarker = JNIEnv.GetMethodID (class_ref, "getMarker", "()Landroid/graphics/drawable/Drawable;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getMarker), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarker", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/method[@name='setMarker' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setMarker", "(Landroid/graphics/drawable/Drawable;)V", "GetSetMarker_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				if (id_setMarker_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setMarker_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setMarker", "(Landroid/graphics/drawable/Drawable;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMarker_Landroid_graphics_drawable_Drawable_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMarker", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (value));
			}
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Point);
		}
#pragma warning restore 0169

		static Delegate cb_setPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetSetPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler ()
		{
			if (cb_setPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == null)
				cb_setPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_);
			return cb_setPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		}

		static void n_SetPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Point = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPoint;
		static IntPtr id_setPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		public virtual global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint Point {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/method[@name='getPoint' and count(parameter)=0]"
			[Register ("getPoint", "()Lcom/tencent/mapsdk/raster/model/GeoPoint;", "GetGetPointHandler")]
			get {
				if (id_getPoint == IntPtr.Zero)
					id_getPoint = JNIEnv.GetMethodID (class_ref, "getPoint", "()Lcom/tencent/mapsdk/raster/model/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getPoint), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoint", "()Lcom/tencent/mapsdk/raster/model/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/method[@name='setPoint' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint']]"
			[Register ("setPoint", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V", "GetSetPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler")]
			set {
				if (id_setPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == IntPtr.Zero)
					id_setPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "setPoint", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPoint", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V"), new JValue (value));
			}
		}

		static Delegate cb_getSnippet;
#pragma warning disable 0169
		static Delegate GetGetSnippetHandler ()
		{
			if (cb_getSnippet == null)
				cb_getSnippet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSnippet);
			return cb_getSnippet;
		}

		static IntPtr n_GetSnippet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Snippet);
		}
#pragma warning restore 0169

		static IntPtr id_getSnippet;
		public virtual string Snippet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/method[@name='getSnippet' and count(parameter)=0]"
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler")]
			get {
				if (id_getSnippet == IntPtr.Zero)
					id_getSnippet = JNIEnv.GetMethodID (class_ref, "getSnippet", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSnippet), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSnippet", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='OverlayItem']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), new JValue (p0), new JValue ((int) p1));
		}

	}
}
