using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Crowdconnected.Androidcolocator {

	// Metadata.xml XPath interface reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/interface[@name='LocationCallback']"
	[Register ("net/crowdconnected/androidcolocator/LocationCallback", "", "Net.Crowdconnected.Androidcolocator.ILocationCallbackInvoker")]
	public partial interface ILocationCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/interface[@name='LocationCallback']/method[@name='onLocationReceived' and count(parameter)=1 and parameter[1][@type='net.crowdconnected.androidcolocator.connector.LocationResponse']]"
		[Register ("onLocationReceived", "(Lnet/crowdconnected/androidcolocator/connector/LocationResponse;)V", "GetOnLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_Handler:Net.Crowdconnected.Androidcolocator.ILocationCallbackInvoker, ColocatorAndroid.Binding")]
		void OnLocationReceived (global::Net.Crowdconnected.Androidcolocator.Connector.LocationResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator']/interface[@name='LocationCallback']/method[@name='onLocationsReceived' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;net.crowdconnected.androidcolocator.connector.LocationResponse&gt;']]"
		[Register ("onLocationsReceived", "(Ljava/util/List;)V", "GetOnLocationsReceived_Ljava_util_List_Handler:Net.Crowdconnected.Androidcolocator.ILocationCallbackInvoker, ColocatorAndroid.Binding")]
		void OnLocationsReceived (global::System.Collections.Generic.IList<global::Net.Crowdconnected.Androidcolocator.Connector.LocationResponse> p0);

	}

	[global::Android.Runtime.Register ("net/crowdconnected/androidcolocator/LocationCallback", DoNotGenerateAcw=true)]
	internal partial class ILocationCallbackInvoker : global::Java.Lang.Object, ILocationCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("net/crowdconnected/androidcolocator/LocationCallback", typeof (ILocationCallbackInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ILocationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "net.crowdconnected.androidcolocator.LocationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_;
#pragma warning disable 0169
		static Delegate GetOnLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_Handler ()
		{
			if (cb_onLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_ == null)
				cb_onLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_);
			return cb_onLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_;
		}

		static void n_OnLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Net.Crowdconnected.Androidcolocator.ILocationCallback __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.ILocationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Net.Crowdconnected.Androidcolocator.Connector.LocationResponse p0 = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.Connector.LocationResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_;
		public unsafe void OnLocationReceived (global::Net.Crowdconnected.Androidcolocator.Connector.LocationResponse p0)
		{
			if (id_onLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_ == IntPtr.Zero)
				id_onLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_ = JNIEnv.GetMethodID (class_ref, "onLocationReceived", "(Lnet/crowdconnected/androidcolocator/connector/LocationResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationReceived_Lnet_crowdconnected_androidcolocator_connector_LocationResponse_, __args);
		}

		static Delegate cb_onLocationsReceived_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnLocationsReceived_Ljava_util_List_Handler ()
		{
			if (cb_onLocationsReceived_Ljava_util_List_ == null)
				cb_onLocationsReceived_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationsReceived_Ljava_util_List_);
			return cb_onLocationsReceived_Ljava_util_List_;
		}

		static void n_OnLocationsReceived_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Net.Crowdconnected.Androidcolocator.ILocationCallback __this = global::Java.Lang.Object.GetObject<global::Net.Crowdconnected.Androidcolocator.ILocationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Net.Crowdconnected.Androidcolocator.Connector.LocationResponse>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationsReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLocationsReceived_Ljava_util_List_;
		public unsafe void OnLocationsReceived (global::System.Collections.Generic.IList<global::Net.Crowdconnected.Androidcolocator.Connector.LocationResponse> p0)
		{
			if (id_onLocationsReceived_Ljava_util_List_ == IntPtr.Zero)
				id_onLocationsReceived_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onLocationsReceived", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Net.Crowdconnected.Androidcolocator.Connector.LocationResponse>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationsReceived_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
