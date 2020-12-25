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
	public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 6741
	{
		// Fields
		public Transform target; // 0x58
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float IKRotationWeight; // 0x60
		public Quaternion IKRotation; // 0x64
		public Vector3 bendNormal; // 0x74
		public TrigonometricBone bone1; // 0x80
		public TrigonometricBone bone2; // 0x88
		public TrigonometricBone bone3; // 0x90
		protected Vector3 weightIKPosition; // 0x98
		protected bool directHierarchy; // 0xA4
	
		// Nested types
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone // TypeDefIndex: 6742
		{
			// Fields
			private Quaternion targetToLocalSpace; // 0x80
			private Vector3 defaultLocalBendNormal; // 0x90
	
			// Constructors
			public TrigonometricBone() {} // 0x00000001809FE2F0-0x00000001809FE300
	
			// Methods
			public void Initiate(Vector3 childPosition, Vector3 bendNormal) {} // 0x00000001809FE590-0x00000001809FE770
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal) => default; // 0x00000001809FE4B0-0x00000001809FE590
			public Vector3 GetBendNormalFromCurrentRotation() => default; // 0x00000001809FE3D0-0x00000001809FE4B0
		}
	
		// Constructors
		public IKSolverTrigonometric() {} // 0x00000001809F24F0-0x00000001809F2630
	
		// Methods
		public void SetBendGoalPosition(Vector3 goalPosition, float weight) {} // 0x00000001809F1890-0x00000001809F1B00
		public void SetBendPlaneToCurrent() {} // 0x00000001809F1B00-0x00000001809F1D30
		public void SetIKRotation(Quaternion rotation) {} // 0x00000001809F1E30-0x00000001809F1E40
		public void SetIKRotationWeight(float weight) {} // 0x00000001809F1DC0-0x00000001809F1E30
		public Quaternion GetIKRotation() => default; // 0x00000001809EFFF0-0x00000001809F0000
		public float GetIKRotationWeight() => default; // 0x00000001809EFFE0-0x00000001809EFFF0
		public override Point[] GetPoints() => default; // 0x00000001809F0160-0x00000001809F02E0
		public override Point GetPoint(Transform transform) => default; // 0x00000001809F0000-0x00000001809F0160
		public override void StoreDefaultLocalState() {} // 0x00000001809F24A0-0x00000001809F24F0
		public override void FixTransforms() {} // 0x00000001809EF980-0x00000001809EF9E0
		public override bool IsValid(ref string message) => default; // 0x00000001809F0710-0x00000001809F0BE0
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root) => default; // 0x00000001809F1D30-0x00000001809F1DC0
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight) {} // 0x00000001809F1E40-0x00000001809F24A0
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) => default; // 0x00000001809EFD90-0x00000001809EFFE0
		protected override void OnInitiate() {} // 0x00000001809F0BE0-0x00000001809F0E50
		private bool IsDirectHierarchy() => default; // 0x00000001809F05E0-0x00000001809F0710
		private void InitiateBones() {} // 0x00000001809F02E0-0x00000001809F05E0
		protected override void OnUpdate() {} // 0x00000001809F0E50-0x00000001809F1890
		protected virtual void OnInitiateVirtual() {} // 0x0000000180246DB0-0x0000000180246DC0
		protected virtual void OnUpdateVirtual() {} // 0x0000000180246DB0-0x0000000180246DC0
		protected virtual void OnPostSolveVirtual() {} // 0x0000000180246DB0-0x0000000180246DC0
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal) => default; // 0x00000001809EF9E0-0x00000001809EFD90
	}
}
