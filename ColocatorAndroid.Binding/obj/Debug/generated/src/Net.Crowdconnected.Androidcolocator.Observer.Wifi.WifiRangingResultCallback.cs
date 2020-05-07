using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Crowdconnected.Androidcolocator.Observer.Wifi {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.crowdconnected.androidcolocator.observer.wifi']/class[@name='WifiRangingResultCallback']"
	[global::Android.Runtime.Register ("net/crowdconnected/androidcolocator/observer/wifi/WifiRangingResultCallback", DoNotGenerateAcw=true)]
	public partial class WifiRangingResultCallback : global::Android.Net.Wifi.Rtt.RangingResultCallback {



		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator.observer.wifi']/class[@name='WifiRangingResultCallback']/field[@name='applicationContext']"
		[Register ("applicationContext")]
		public global::Android.Content.Context ApplicationContext {
			get {
				const string __id = "applicationContext.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "applicationContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator.observer.wifi']/class[@name='WifiRangingResultCallback']/field[@name='handler']"
		[Register ("handler")]
		public global::Android.OS.Handler Handler {
			get {
				const string __id = "handler.Landroid/os/Handler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "handler.Landroid/os/Handler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator.observer.wifi']/class[@name='WifiRangingResultCallback']/field[@name='scanResults']"
		[Register ("scanResults")]
		public global::System.Collections.IDictionary ScanResults {
			get {
				const string __id = "scanResults.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "scanResults.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/crowdconnected/androidcolocator/observer/wifi/WifiRangingResultCallback", typeof (WifiRangingResultCallback));
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

		protected WifiRangingResultCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.crowdconnected.androidcolocator.observer.wifi']/class[@name='WifiRangingResultCallback']/constructor[@name='WifiRangingResultCallback' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, android.net.wifi.ScanResult&gt;'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='android.content.Context']]"
		[Register (".ctor", "(Ljava/util/Map;Landroid/os/Handler;Landroid/content/Context;)V", "")]
		public unsafe WifiRangingResultCallback (global::System.Collections.Generic.IDictionary<string, global::Android.Net.Wifi.ScanResult> p0, global::Android.OS.Handler p1, global::Android.Content.Context p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Map;Landroid/os/Handler;Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Android.Net.Wifi.ScanResult>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onRangingFailure_I;
#pragma warning disable 0169
		static Delegate GetOnRangingFailure_IHandler ()
		{
			if (cb_onRangingFailure_I == null)
				cb_onRangingFailure_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnRangingFailure_I);
			return cb_onRangingFailure_I;
		}

		static void n_OnRangingFailure_I (IntPtr jnienv, IntPtr native__this, int native_p0)
		{
			global::Net.Crowdconnected.Androidcolocator.Observer.Wifi.WifiRangingResultCallback __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.Observer.Wifi.WifiRangingResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Wifi.Rtt.RangingResultStatusCode p0 = (global::Android.Net.Wifi.Rtt.RangingResultStatusCode) native_p0;
			__this.OnRangingFailure (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator.observer.wifi']/class[@name='WifiRangingResultCallback']/method[@name='onRangingFailure' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onRangingFailure", "(I)V", "GetOnRangingFailure_IHandler")]
		public override unsafe void OnRangingFailure ([global::Android.Runtime.GeneratedEnum] global::Android.Net.Wifi.Rtt.RangingResultStatusCode p0)
		{
			const string __id = "onRangingFailure.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((int) p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onRangingResults_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnRangingResults_Ljava_util_List_Handler ()
		{
			if (cb_onRangingResults_Ljava_util_List_ == null)
				cb_onRangingResults_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRangingResults_Ljava_util_List_);
			return cb_onRangingResults_Ljava_util_List_;
		}

		static void n_OnRangingResults_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Net.Crowdconnected.Androidcolocator.Observer.Wifi.WifiRangingResultCallback __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.Observer.Wifi.WifiRangingResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Android.Net.Wifi.Rtt.RangingResult>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRangingResults (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator.observer.wifi']/class[@name='WifiRangingResultCallback']/method[@name='onRangingResults' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.net.wifi.rtt.RangingResult&gt;']]"
		[Register ("onRangingResults", "(Ljava/util/List;)V", "GetOnRangingResults_Ljava_util_List_Handler")]
		public override unsafe void OnRangingResults (global::System.Collections.Generic.IList<global::Android.Net.Wifi.Rtt.RangingResult> p0)
		{
			const string __id = "onRangingResults.(Ljava/util/List;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Net.Wifi.Rtt.RangingResult>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
