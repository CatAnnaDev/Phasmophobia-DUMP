/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	public class Recoil : OffsetModifier // TypeDefIndex: 6818
	{
		// Fields
		// [Tooltip] // 0x0000000180101700-0x0000000180101730
		public AimIK aimIK; // 0x30
		// [Tooltip] // 0x00000001801018B0-0x00000001801018E0
		public bool aimIKSolvedLast; // 0x38
		// [Tooltip] // 0x0000000180101A60-0x0000000180101A90
		public Handedness handedness; // 0x3C
		// [Tooltip] // 0x0000000180101B40-0x0000000180101B70
		public bool twoHanded; // 0x40
		// [Tooltip] // 0x0000000180101D10-0x0000000180101D40
		public AnimationCurve recoilWeight; // 0x48
		// [Tooltip] // 0x0000000180101DB0-0x0000000180101DE0
		public float magnitudeRandom; // 0x50
		// [Tooltip] // 0x0000000180101F60-0x0000000180101F90
		public Vector3 rotationRandom; // 0x54
		// [Tooltip] // 0x0000000180102010-0x0000000180102040
		public Vector3 handRotationOffset; // 0x60
		// [Tooltip] // 0x0000000180102110-0x0000000180102140
		public float blendTime; // 0x6C
		[Space] // 0x00000001801022D0-0x0000000180102320
		// [Tooltip] // 0x00000001801022D0-0x0000000180102320
		public RecoilOffset[] offsets; // 0x70
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public Quaternion rotationOffset; // 0x78
		private float magnitudeMlp; // 0x88
		private float endTime; // 0x8C
		private Quaternion handRotation; // 0x90
		private Quaternion secondaryHandRelativeRotation; // 0xA0
		private Quaternion randomRotation; // 0xB0
		private float length; // 0xC0
		private bool initiated; // 0xC4
		private float blendWeight; // 0xC8
		private float w; // 0xCC
		private Quaternion primaryHandRotation; // 0xD0
		private bool handRotationsSet; // 0xE0
		private Vector3 aimIKAxis; // 0xE4
	
		// Properties
		public bool isFinished { get => default; } // 0x00000001807EBCC0-0x00000001807EBCE0 
		private IKEffector primaryHandEffector { get => default; } // 0x00000001807EBCE0-0x00000001807EBD30 
		private IKEffector secondaryHandEffector { get => default; } // 0x00000001807EBD80-0x00000001807EBDD0 
		private Transform primaryHand { get => default; } // 0x00000001807EBD30-0x00000001807EBD80 
		private Transform secondaryHand { get => default; } // 0x00000001807EBDD0-0x00000001807EBE20 
	
		// Nested types
		[Serializable]
		public class RecoilOffset // TypeDefIndex: 6819
		{
			// Fields
			// [Tooltip] // 0x00000001801024E0-0x0000000180102510
			public Vector3 offset; // 0x10
			// [Range] // 0x0000000180102690-0x00000001801026F0
			// [Tooltip] // 0x0000000180102690-0x00000001801026F0
			public float additivity; // 0x1C
			// [Tooltip] // 0x0000000180102880-0x00000001801028B0
			public float maxAdditiveOffsetMag; // 0x20
			// [Tooltip] // 0x0000000180102A60-0x0000000180102A90
			public EffectorLink[] effectorLinks; // 0x28
			private Vector3 additiveOffset; // 0x30
			private Vector3 lastOffset; // 0x3C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 6820
			{
				// Fields
				// [Tooltip] // 0x00000001800FB880-0x00000001800FB8B0
				public FullBodyBipedEffector effector; // 0x10
				// [Tooltip] // 0x00000001800FB910-0x00000001800FB940
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink() {} // 0x00000001802466A0-0x00000001802466B0
			}
	
			// Constructors
			public RecoilOffset() {} // 0x00000001807EA3F0-0x00000001807EA410
	
			// Methods
			public void Start() {} // 0x00000001807EA310-0x00000001807EA3F0
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft) {} // 0x00000001807EA000-0x00000001807EA310
		}
	
		[Serializable]
		public enum Handedness // TypeDefIndex: 6821
		{
			Right = 0,
			Left = 1
		}
	
		// Constructors
		public Recoil() {} // 0x00000001807EBC10-0x00000001807EBCC0
	
		// Methods
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) {} // 0x00000001807EBBE0-0x00000001807EBC10
		public void Fire(float magnitude) {} // 0x00000001807EA670-0x00000001807EA940
		protected override void OnModifyOffset() {} // 0x00000001807EABF0-0x00000001807EBBE0
		private void AfterFBBIK() {} // 0x00000001807EA460-0x00000001807EA670
		private void AfterAimIK() {} // 0x00000001807EA410-0x00000001807EA460
		protected override void OnDestroy() {} // 0x00000001807EA940-0x00000001807EABF0
	}
}
