/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	public abstract class OffsetModifier : MonoBehaviour // TypeDefIndex: 6811
	{
		// Fields
		// [Tooltip] // 0x0000000180100020-0x0000000180100050
		public float weight; // 0x18
		// [Tooltip] // 0x0000000180100100-0x0000000180100130
		public FullBodyBipedIK ik; // 0x20
		protected float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x00000001807E7720-0x00000001807E7740 
	
		// Nested types
		[Serializable]
		public class OffsetLimits // TypeDefIndex: 6812
		{
			// Fields
			// [Tooltip] // 0x00000001801002E0-0x0000000180100310
			public FullBodyBipedEffector effector; // 0x10
			// [Tooltip] // 0x00000001801004A0-0x00000001801004D0
			public float spring; // 0x14
			// [Tooltip] // 0x0000000180100550-0x0000000180100580
			public bool x; // 0x18
			// [Tooltip] // 0x0000000180100550-0x0000000180100580
			public bool y; // 0x19
			// [Tooltip] // 0x0000000180100550-0x0000000180100580
			public bool z; // 0x1A
			// [Tooltip] // 0x0000000180100890-0x00000001801008C0
			public float minX; // 0x1C
			// [Tooltip] // 0x0000000180100890-0x00000001801008C0
			public float maxX; // 0x20
			// [Tooltip] // 0x0000000180100890-0x00000001801008C0
			public float minY; // 0x24
			// [Tooltip] // 0x0000000180100890-0x00000001801008C0
			public float maxY; // 0x28
			// [Tooltip] // 0x0000000180100890-0x00000001801008C0
			public float minZ; // 0x2C
			// [Tooltip] // 0x0000000180100890-0x00000001801008C0
			public float maxZ; // 0x30
	
			// Constructors
			public OffsetLimits() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public void Apply(IKEffector e, Quaternion rootRotation) {} // 0x00000001807E6EF0-0x00000001807E71F0
			private float SpringAxis(float value, float min, float max) => default; // 0x00000001807E71F0-0x00000001807E7330
			private float Spring(float value, float limit, bool negative) => default; // 0x00000001807E7330-0x00000001807E7420
		}
	
		// Constructors
		protected OffsetModifier() {} // 0x000000018053ADA0-0x000000018053ADB0
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start() {} // 0x00000001807E7AC0-0x00000001807E7B30
		// [IteratorStateMachine] // 0x0000000180100180-0x00000001801001D0
		private IEnumerator Initiate() => default; // 0x00000001807E7830-0x00000001807E78A0
		private void ModifyOffset() {} // 0x00000001807E78A0-0x00000001807E79B0
		protected void ApplyLimits(OffsetLimits[] limits) {} // 0x00000001807E7740-0x00000001807E7830
		protected virtual void OnDestroy() {} // 0x00000001807E79B0-0x00000001807E7AC0
	}
}
