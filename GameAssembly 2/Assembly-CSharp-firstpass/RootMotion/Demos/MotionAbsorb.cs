/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public class MotionAbsorb : OffsetModifier // TypeDefIndex: 6624
	{
		// Fields
		// [Tooltip] // 0x000000018012EF50-0x000000018012EF80
		public Mode mode; // 0x30
		// [Tooltip] // 0x000000018012F060-0x000000018012F090
		public Absorber[] absorbers; // 0x38
		// [Tooltip] // 0x000000018012F110-0x000000018012F140
		public AnimationCurve falloff; // 0x40
		// [Tooltip] // 0x000000018012F1A0-0x000000018012F1D0
		public float falloffSpeed; // 0x48
		private float timer; // 0x4C
		private float w; // 0x50
		private Mode initialMode; // 0x54
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 6625
		{
			Position = 0,
			PositionOffset = 1
		}
	
		[Serializable]
		public class Absorber // TypeDefIndex: 6626
		{
			// Fields
			// [Tooltip] // 0x000000018012F2D0-0x000000018012F300
			public FullBodyBipedEffector effector; // 0x10
			// [Tooltip] // 0x000000018012F350-0x000000018012F380
			public float weight; // 0x14
			private Vector3 position; // 0x18
			private Quaternion rotation; // 0x24
			private IKEffector e; // 0x38
	
			// Constructors
			public Absorber() {} // 0x00000001804AEDB0-0x00000001804AEE20
	
			// Methods
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode) {} // 0x00000001804AEC30-0x00000001804AED70
			public void UpdateEffectorWeights(float w) {} // 0x00000001804AED70-0x00000001804AEDB0
			public void SetPosition(float w) {} // 0x00000001804AE930-0x00000001804AEB00
			public void SetRotation(float w) {} // 0x00000001804AEB00-0x00000001804AEC30
		}
	
		// Constructors
		public MotionAbsorb() {} // 0x00000001804CB800-0x00000001804CB810
	
		// Methods
		protected override void Start() {} // 0x00000001804CB710-0x00000001804CB800
		private void OnCollisionEnter(Collision c) {} // 0x00000001804CB0E0-0x00000001804CB2B0
		protected override void OnModifyOffset() {} // 0x00000001804CB3C0-0x00000001804CB710
		private void AfterIK() {} // 0x00000001804CAF10-0x00000001804CB0E0
		protected override void OnDestroy() {} // 0x00000001804CB2B0-0x00000001804CB3C0
	}
}
