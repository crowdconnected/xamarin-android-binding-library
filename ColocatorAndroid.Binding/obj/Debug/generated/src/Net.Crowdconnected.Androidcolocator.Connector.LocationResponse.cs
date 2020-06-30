using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Net.Crowdconnected.Androidcolocator.Connector {

	// Metadata.xml XPath class reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']"
	[global::Android.Runtime.Register ("net/crowdconnected/androidcolocator/connector/LocationResponse", DoNotGenerateAcw=true)]
	public sealed partial class LocationResponse : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/field[@name='a']"
		[Register ("a")]
		public double A {
			get {
				const string __id = "a.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "a.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/field[@name='b']"
		[Register ("b")]
		public double B {
			get {
				const string __id = "b.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "b.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/field[@name='c']"
		[Register ("c")]
		public double C {
			get {
				const string __id = "c.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "c.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/field[@name='d']"
		[Register ("d")]
		public double D {
			get {
				const string __id = "d.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "d.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/field[@name='e']"
		[Register ("e")]
		public long E {
			get {
				const string __id = "e.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "e.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/field[@name='f']"
		[Register ("f")]
		public long F {
			get {
				const string __id = "f.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "f.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("net/crowdconnected/androidcolocator/connector/LocationResponse", typeof (LocationResponse));
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

		internal LocationResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/constructor[@name='LocationResponse' and count(parameter)=6 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='long'] and parameter[6][@type='long']]"
		[Register (".ctor", "(DDDDJJ)V", "")]
		public unsafe LocationResponse (double p0, double p1, double p2, double p3, long p4, long p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(DDDDJJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe double Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()D", "")]
			get {
				const string __id = "getError.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long Floor {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/method[@name='getFloor' and count(parameter)=0]"
			[Register ("getFloor", "()J", "")]
			get {
				const string __id = "getFloor.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe double HeadingOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/method[@name='getHeadingOffset' and count(parameter)=0]"
			[Register ("getHeadingOffset", "()D", "")]
			get {
				const string __id = "getHeadingOffset.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "")]
			get {
				const string __id = "getLatitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "")]
			get {
				const string __id = "getLongitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='net.crowdconnected.androidcolocator.connector']/class[@name='LocationResponse']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "")]
			get {
				const string __id = "getTimestamp.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
