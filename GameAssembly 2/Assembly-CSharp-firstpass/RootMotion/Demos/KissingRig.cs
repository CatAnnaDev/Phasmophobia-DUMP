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
	public class KissingRig : MonoBehaviour // TypeDefIndex: 6622
	{
		// Fields
		public Partner partner1; // 0x18
		public Partner partner2; // 0x20
		public float weight; // 0x28
		public int iterations; // 0x2C
	
		// Nested types
		[Serializable]
		public class Partner // TypeDefIndex: 6623
		{
			// Fields
			public FullBodyBipedIK ik; // 0x10
			public Transform mouth; // 0x18
			public Transform mouthTarget; // 0x20
			public Transform touchTargetLeftHand; // 0x28
			public Transform touchTargetRightHand; // 0x30
			public float bodyWeightHorizontal; // 0x38
			public float bodyWeightVertical; // 0x3C
			public float neckRotationWeight; // 0x40
			public float headTiltAngle; // 0x44
			public Vector3 headTiltAxis; // 0x48
			private Quaternion neckRotation; // 0x54
	
			// Properties
			private Transform neck { get => default; } // 0x00000001804CC930-0x00000001804CC9A0 
	
			// Constructors
			public Partner() {} // 0x00000001804CC900-0x00000001804CC930
	
			// Methods
			public void Initiate() {} // 0x00000001804CBCB0-0x00000001804CBCE0
			public void Update(float weight) {} // 0x00000001804CBF10-0x00000001804CC900
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight) {} // 0x00000001804CBCE0-0x00000001804CBF10
		}
	
		// Constructors
		public KissingRig() {} // 0x00000001804C84D0-0x00000001804C84E0
	
		// Methods
		private void Start() {} // 0x00000001804C8480-0x00000001804C84D0
		private void LateUpdate() {} // 0x00000001804C8420-0x00000001804C8480
	}
}
