using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Crowdconnected.Androidcolocator {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']"
	[global::Android.Runtime.Register ("net/crowdconnected/androidcolocator/CoLocator", DoNotGenerateAcw=true)]
	public partial class CoLocator : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/field[@name='c']"
		[Register ("c")]
		public global::Net.Crowdconnected.Androidcolocator.Service.CoLocatorService C {
			get {
				const string __id = "c.Lnet/crowdconnected/androidcolocator/service/CoLocatorService;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.Service.CoLocatorService> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lnet/crowdconnected/androidcolocator/service/CoLocatorService;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/field[@name='e']"
		[Register ("e")]
		public bool E {
			get {
				const string __id = "e.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "e.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/field[@name='f']"
		[Register ("f")]
		public global::Java.Lang.Boolean F {
			get {
				const string __id = "f.Ljava/lang/Boolean;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "f.Ljava/lang/Boolean;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/field[@name='g']"
		[Register ("g")]
		public global::System.Collections.IDictionary G {
			get {
				const string __id = "g.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "g.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/field[@name='h']"
		[Register ("h")]
		public global::System.Collections.IList H {
			get {
				const string __id = "h.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "h.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/field[@name='j']"
		[Register ("j")]
		public global::Net.Crowdconnected.Androidcolocator.ILocationCallback J {
			get {
				const string __id = "j.Lnet/crowdconnected/androidcolocator/LocationCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.ILocationCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "j.Lnet/crowdconnected/androidcolocator/LocationCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/field[@name='k']"
		[Register ("k")]
		public static global::Net.Crowdconnected.Androidcolocator.CoLocator K {
			get {
				const string __id = "k.Lnet/crowdconnected/androidcolocator/CoLocator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "k.Lnet/crowdconnected/androidcolocator/CoLocator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/field[@name='l']"
		[Register ("l")]
		public static bool L {
			get {
				const string __id = "l.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "l.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/crowdconnected/androidcolocator/CoLocator", typeof (CoLocator));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected CoLocator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/constructor[@name='CoLocator' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register (".ctor", "(Landroid/app/Application;)V", "")]
		public unsafe CoLocator (global::Android.App.Application p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Application;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public static unsafe bool Debugging {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='isDebugging' and count(parameter)=0]"
			[Register ("isDebugging", "()Z", "")]
			get {
				const string __id = "isDebugging.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='setDebugging' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugging", "(Z)V", "")]
			set {
				const string __id = "setDebugging.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.Crowdconnected.Androidcolocator.CoLocator __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				const string __id = "getDeviceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/app/Application;Ljava/lang/String;)V", "")]
		public static unsafe void A (global::Android.App.Application p0, string p1)
		{
			const string __id = "a.(Landroid/app/Application;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addAlias_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAlias_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addAlias_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addAlias_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAlias_Ljava_lang_String_Ljava_lang_String_);
			return cb_addAlias_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddAlias_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Net.Crowdconnected.Androidcolocator.CoLocator __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddAlias (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='addAlias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addAlias", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddAlias_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddAlias (string p0, string p1)
		{
			const string __id = "addAlias.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Net.Crowdconnected.Androidcolocator.CoLocator __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String']]"
		[Register ("init", "(Landroid/app/Application;Ljava/lang/String;)V", "")]
		public static unsafe void Init (global::Android.App.Application p0, string p1)
		{
			const string __id = "init.(Landroid/app/Application;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("init", "(Landroid/app/Application;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Init (global::Android.App.Application p0, string p1, string p2)
		{
			const string __id = "init.(Landroid/app/Application;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='instance' and count(parameter)=0]"
		[Register ("instance", "()Lnet/crowdconnected/androidcolocator/CoLocator;", "")]
		public static unsafe global::Net.Crowdconnected.Androidcolocator.CoLocator Instance ()
		{
			const string __id = "instance.()Lnet/crowdconnected/androidcolocator/CoLocator;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_registerLocationListener_Lnet_crowdconnected_androidcolocator_LocationCallback_;
#pragma warning disable 0169
		static Delegate GetRegisterLocationListener_Lnet_crowdconnected_androidcolocator_LocationCallback_Handler ()
		{
			if (cb_registerLocationListener_Lnet_crowdconnected_androidcolocator_LocationCallback_ == null)
				cb_registerLocationListener_Lnet_crowdconnected_androidcolocator_LocationCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterLocationListener_Lnet_crowdconnected_androidcolocator_LocationCallback_);
			return cb_registerLocationListener_Lnet_crowdconnected_androidcolocator_LocationCallback_;
		}

		static void n_RegisterLocationListener_Lnet_crowdconnected_androidcolocator_LocationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Net.Crowdconnected.Androidcolocator.CoLocator __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Net.Crowdconnected.Androidcolocator.ILocationCallback p0 = (global::Net.Crowdconnected.Androidcolocator.ILocationCallback)global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.ILocationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterLocationListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='registerLocationListener' and count(parameter)=1 and parameter[1][@type='net.crowdconnected.androidcolocator.LocationCallback']]"
		[Register ("registerLocationListener", "(Lnet/crowdconnected/androidcolocator/LocationCallback;)V", "GetRegisterLocationListener_Lnet_crowdconnected_androidcolocator_LocationCallback_Handler")]
		public virtual unsafe void RegisterLocationListener (global::Net.Crowdconnected.Androidcolocator.ILocationCallback p0)
		{
			const string __id = "registerLocationListener.(Lnet/crowdconnected/androidcolocator/LocationCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_requestLocation_Lnet_crowdconnected_androidcolocator_LocationCallback_;
#pragma warning disable 0169
		static Delegate GetRequestLocation_Lnet_crowdconnected_androidcolocator_LocationCallback_Handler ()
		{
			if (cb_requestLocation_Lnet_crowdconnected_androidcolocator_LocationCallback_ == null)
				cb_requestLocation_Lnet_crowdconnected_androidcolocator_LocationCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestLocation_Lnet_crowdconnected_androidcolocator_LocationCallback_);
			return cb_requestLocation_Lnet_crowdconnected_androidcolocator_LocationCallback_;
		}

		static void n_RequestLocation_Lnet_crowdconnected_androidcolocator_LocationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Net.Crowdconnected.Androidcolocator.CoLocator __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Net.Crowdconnected.Androidcolocator.ILocationCallback p0 = (global::Net.Crowdconnected.Androidcolocator.ILocationCallback)global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.ILocationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestLocation (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='requestLocation' and count(parameter)=1 and parameter[1][@type='net.crowdconnected.androidcolocator.LocationCallback']]"
		[Register ("requestLocation", "(Lnet/crowdconnected/androidcolocator/LocationCallback;)V", "GetRequestLocation_Lnet_crowdconnected_androidcolocator_LocationCallback_Handler")]
		public virtual unsafe void RequestLocation (global::Net.Crowdconnected.Androidcolocator.ILocationCallback p0)
		{
			const string __id = "requestLocation.(Lnet/crowdconnected/androidcolocator/LocationCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendUserLocation_DDDJ;
#pragma warning disable 0169
		static Delegate GetSendUserLocation_DDDJHandler ()
		{
			if (cb_sendUserLocation_DDDJ == null)
				cb_sendUserLocation_DDDJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, double, long>) n_SendUserLocation_DDDJ);
			return cb_sendUserLocation_DDDJ;
		}

		static void n_SendUserLocation_DDDJ (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2, long p3)
		{
			global::Net.Crowdconnected.Androidcolocator.CoLocator __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendUserLocation (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='sendUserLocation' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='long']]"
		[Register ("sendUserLocation", "(DDDJ)V", "GetSendUserLocation_DDDJHandler")]
		public virtual unsafe void SendUserLocation (double p0, double p1, double p2, long p3)
		{
			const string __id = "sendUserLocation.(DDDJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAlias_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAlias_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAlias_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAlias_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAlias_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAlias_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetAlias_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Net.Crowdconnected.Androidcolocator.CoLocator __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAlias (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='setAlias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAlias", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetAlias_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAlias (string p0, string p1)
		{
			const string __id = "setAlias.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='setServiceNotificationInfo' and count(parameter)=4 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("setServiceNotificationInfo", "(Landroid/app/Application;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public static unsafe void SetServiceNotificationInfo (global::Android.App.Application p0, string p1, int p2, string p3)
		{
			const string __id = "setServiceNotificationInfo.(Landroid/app/Application;Ljava/lang/String;ILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_setSurveyMode_Z;
#pragma warning disable 0169
		static Delegate GetSetSurveyMode_ZHandler ()
		{
			if (cb_setSurveyMode_Z == null)
				cb_setSurveyMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSurveyMode_Z);
			return cb_setSurveyMode_Z;
		}

		static void n_SetSurveyMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Net.Crowdconnected.Androidcolocator.CoLocator __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSurveyMode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='setSurveyMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSurveyMode", "(Z)V", "GetSetSurveyMode_ZHandler")]
		public virtual unsafe void SetSurveyMode (bool p0)
		{
			const string __id = "setSurveyMode.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='start' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String']]"
		[Register ("start", "(Landroid/app/Application;Ljava/lang/String;)V", "")]
		public static unsafe void Start (global::Android.App.Application p0, string p1)
		{
			const string __id = "start.(Landroid/app/Application;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='start' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("start", "(Landroid/app/Application;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Start (global::Android.App.Application p0, string p1, string p2)
		{
			const string __id = "start.(Landroid/app/Application;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.Crowdconnected.Androidcolocator.CoLocator __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unregisterLocationListener;
#pragma warning disable 0169
		static Delegate GetUnregisterLocationListenerHandler ()
		{
			if (cb_unregisterLocationListener == null)
				cb_unregisterLocationListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterLocationListener);
			return cb_unregisterLocationListener;
		}

		static void n_UnregisterLocationListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Net.Crowdconnected.Androidcolocator.CoLocator __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.CoLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterLocationListener ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/class[@name='CoLocator']/method[@name='unregisterLocationListener' and count(parameter)=0]"
		[Register ("unregisterLocationListener", "()V", "GetUnregisterLocationListenerHandler")]
		public virtual unsafe void UnregisterLocationListener ()
		{
			const string __id = "unregisterLocationListener.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
