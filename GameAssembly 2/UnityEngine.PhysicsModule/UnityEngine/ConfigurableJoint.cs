/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 8: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3646-3679

namespace UnityEngine
{
	// [NativeClass] // 0x00000001801340D0-0x0000000180134130
	// [NativeHeader] // 0x00000001801340D0-0x0000000180134130
	public class ConfigurableJoint : Joint // TypeDefIndex: 3676
	{
		// Properties
		public Vector3 secondaryAxis { get => default; } // 0x0000000180ACA8F0-0x0000000180ACA960 
		public ConfigurableJointMotion xMotion { set {} } // 0x0000000180ACACF0-0x0000000180ACAD30
		public ConfigurableJointMotion yMotion { set {} } // 0x0000000180ACADD0-0x0000000180ACAE10
		public ConfigurableJointMotion zMotion { set {} } // 0x0000000180ACAEB0-0x0000000180ACAEF0
		public ConfigurableJointMotion angularXMotion { set {} } // 0x0000000180ACA960-0x0000000180ACA9A0
		public ConfigurableJointMotion angularYMotion { set {} } // 0x0000000180ACA9A0-0x0000000180ACA9E0
		public ConfigurableJointMotion angularZMotion { set {} } // 0x0000000180ACA9E0-0x0000000180ACAA20
		public SoftJointLimit linearLimit { get => default; set {} } // 0x0000000180ACA830-0x0000000180ACA8A0 0x0000000180ACAAC0-0x0000000180ACAB10
		public Vector3 targetPosition { set {} } // 0x0000000180ACAB60-0x0000000180ACABB0
		public Vector3 targetVelocity { set {} } // 0x0000000180ACAC00-0x0000000180ACAC50
		public JointDrive xDrive { set {} } // 0x0000000180ACACA0-0x0000000180ACACF0
		public JointDrive yDrive { set {} } // 0x0000000180ACAD80-0x0000000180ACADD0
		public JointDrive zDrive { set {} } // 0x0000000180ACAE60-0x0000000180ACAEB0
		public bool configuredInWorldSpace { set {} } // 0x0000000180ACAA20-0x0000000180ACAA70
	
		// Constructors
		public ConfigurableJoint() {} // Dummy constructor
	
		// Methods
		private void get_secondaryAxis_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180ACA8A0-0x0000000180ACA8F0
		private void get_linearLimit_Injected(out SoftJointLimit ret) {
			ret = default;
		} // 0x0000000180ACA7E0-0x0000000180ACA830
		private void set_linearLimit_Injected(ref SoftJointLimit value) {} // 0x0000000180ACAA70-0x0000000180ACAAC0
		private void set_targetPosition_Injected(ref Vector3 value) {} // 0x0000000180ACAB10-0x0000000180ACAB60
		private void set_targetVelocity_Injected(ref Vector3 value) {} // 0x0000000180ACABB0-0x0000000180ACAC00
		private void set_xDrive_Injected(ref JointDrive value) {} // 0x0000000180ACAC50-0x0000000180ACACA0
		private void set_yDrive_Injected(ref JointDrive value) {} // 0x0000000180ACAD30-0x0000000180ACAD80
		private void set_zDrive_Injected(ref JointDrive value) {} // 0x0000000180ACAE10-0x0000000180ACAE60
	}
}
