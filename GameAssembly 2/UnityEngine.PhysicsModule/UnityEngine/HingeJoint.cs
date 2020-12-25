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
	// [NativeClass] // 0x0000000180133D40-0x0000000180133DA0
	// [NativeHeader] // 0x0000000180133D40-0x0000000180133DA0
	public class HingeJoint : Joint // TypeDefIndex: 3672
	{
		// Properties
		public JointLimits limits { get => default; set {} } // 0x0000000180ACB160-0x0000000180ACB1E0 0x0000000180ACB330-0x0000000180ACB380
		public JointSpring spring { get => default; set {} } // 0x0000000180ACB230-0x0000000180ACB2A0 0x0000000180ACB3D0-0x0000000180ACB420
		public bool useLimits { set {} } // 0x0000000180ACB420-0x0000000180ACB470
		public bool useSpring { get => default; set {} } // 0x0000000180ACB2A0-0x0000000180ACB2E0 0x0000000180ACB470-0x0000000180ACB4C0
		public float angle { get => default; } // 0x0000000180ACB0D0-0x0000000180ACB110 
	
		// Constructors
		public HingeJoint() {} // Dummy constructor
	
		// Methods
		private void get_limits_Injected(out JointLimits ret) {
			ret = default;
		} // 0x0000000180ACB110-0x0000000180ACB160
		private void set_limits_Injected(ref JointLimits value) {} // 0x0000000180ACB2E0-0x0000000180ACB330
		private void get_spring_Injected(out JointSpring ret) {
			ret = default;
		} // 0x0000000180ACB1E0-0x0000000180ACB230
		private void set_spring_Injected(ref JointSpring value) {} // 0x0000000180ACB380-0x0000000180ACB3D0
	}
}
