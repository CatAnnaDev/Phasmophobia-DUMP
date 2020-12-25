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
	[Serializable]
	public class IKSolverLookAt : IKSolver // TypeDefIndex: 6739
	{
		// Fields
		public Transform target; // 0x58
		public LookAtBone[] spine; // 0x60
		public LookAtBone head; // 0x68
		public LookAtBone[] eyes; // 0x70
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float bodyWeight; // 0x78
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float headWeight; // 0x7C
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float eyesWeight; // 0x80
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float clampWeight; // 0x84
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float clampWeightHead; // 0x88
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float clampWeightEyes; // 0x8C
		// [Range] // 0x00000001800DF770-0x00000001800DF790
		public int clampSmoothing; // 0x90
		public AnimationCurve spineWeightCurve; // 0x98
		public Vector3 spineTargetOffset; // 0xA0
		private Vector3[] spineForwards; // 0xB0
		private Vector3[] headForwards; // 0xB8
		private Vector3[] eyeForward; // 0xC0
	
		// Properties
		private bool spineIsValid { get => default; } // 0x00000001809EF890-0x00000001809EF980 
		private bool spineIsEmpty { get => default; } // 0x00000001809EF870-0x00000001809EF890 
		private bool headIsValid { get => default; } // 0x00000001809EF860-0x00000001809EF870 
		private bool headIsEmpty { get => default; } // 0x00000001809EF7F0-0x00000001809EF860 
		private bool eyesIsValid { get => default; } // 0x00000001809EF700-0x00000001809EF7F0 
		private bool eyesIsEmpty { get => default; } // 0x00000001809EF6E0-0x00000001809EF700 
	
		// Nested types
		[Serializable]
		public class LookAtBone : IKSolver.Bone // TypeDefIndex: 6740
		{
			// Properties
			public Vector3 forward { get => default; } // 0x00000001809FE300-0x00000001809FE3D0 
	
			// Constructors
			public LookAtBone() {} // 0x00000001809FE2F0-0x00000001809FE300
			public LookAtBone(Transform transform) {} // 0x00000001809FE2C0-0x00000001809FE2F0
	
			// Methods
			public void Initiate(Transform root) {} // 0x00000001809FE020-0x00000001809FE150
			public void LookAt(Vector3 direction, float weight) {} // 0x00000001809FE150-0x00000001809FE2C0
		}
	
		// Constructors
		public IKSolverLookAt() {} // 0x00000001809EF470-0x00000001809EF6E0
	
		// Methods
		public void SetLookAtWeight(float weight) {} // 0x00000001809EE890-0x00000001809EE900
		public void SetLookAtWeight(float weight, float bodyWeight) {} // 0x00000001809EE5E0-0x00000001809EE680
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) {} // 0x00000001809EE510-0x00000001809EE5E0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) {} // 0x00000001809EE680-0x00000001809EE770
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) {} // 0x00000001809EE770-0x00000001809EE890
		public void SetLookAtWeight(float weight, float bodyWeight = 0f /* Metadata: 0x00652EA1 */, float headWeight = 1f /* Metadata: 0x00652EA5 */, float eyesWeight = 0.5f /* Metadata: 0x00652EA9 */, float clampWeight = 0.5f /* Metadata: 0x00652EAD */, float clampWeightHead = 0.5f /* Metadata: 0x00652EB1 */, float clampWeightEyes = 0.3f /* Metadata: 0x00652EB5 */) {} // 0x00000001809EE3C0-0x00000001809EE510
		public override void StoreDefaultLocalState() {} // 0x00000001809EF310-0x00000001809EF470
		public override void FixTransforms() {} // 0x00000001809ECDC0-0x00000001809ECF40
		public override bool IsValid(ref string message) => default; // 0x00000001809ED880-0x00000001809EDB70
		public override Point[] GetPoints() => default; // 0x00000001809ED5A0-0x00000001809ED880
		public override Point GetPoint(Transform transform) => default; // 0x00000001809ED3E0-0x00000001809ED5A0
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) => default; // 0x00000001809EE300-0x00000001809EE3C0
		protected override void OnInitiate() {} // 0x00000001809EDB70-0x00000001809EE030
		protected override void OnUpdate() {} // 0x00000001809EE030-0x00000001809EE140
		private void SolveSpine() {} // 0x00000001809EF000-0x00000001809EF310
		private void SolveHead() {} // 0x00000001809EEC80-0x00000001809EF000
		private void SolveEyes() {} // 0x00000001809EE900-0x00000001809EEC80
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) => default; // 0x00000001809ECF40-0x00000001809ED3E0
		private void SetBones(Transform[] array, ref LookAtBone[] bones) {} // 0x00000001809EE140-0x00000001809EE300
	}
}
