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
	public class IKSolverLeg : IKSolver // TypeDefIndex: 6735
	{
		// Fields
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float IKRotationWeight; // 0x58
		public Quaternion IKRotation; // 0x5C
		public Point pelvis; // 0x70
		public Point thigh; // 0x78
		public Point calf; // 0x80
		public Point foot; // 0x88
		public Point toe; // 0x90
		public IKSolverVR.Leg leg; // 0x98
		public Vector3 heelOffset; // 0xA0
		private Vector3[] positions; // 0xB0
		private Quaternion[] rotations; // 0xB8
	
		// Constructors
		public IKSolverLeg() {} // 0x00000001809EB0D0-0x00000001809EB290
	
		// Methods
		public override bool IsValid(ref string message) => default; // 0x00000001809EA1C0-0x00000001809EA590
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root) => default; // 0x00000001809EAC90-0x00000001809EAD60
		public override Point[] GetPoints() => default; // 0x00000001809E9F90-0x00000001809EA1C0
		public override Point GetPoint(Transform transform) => default; // 0x00000001809E9D80-0x00000001809E9F90
		public override void StoreDefaultLocalState() {} // 0x00000001809EAEC0-0x00000001809EAF20
		public override void FixTransforms() {} // 0x00000001809E9D10-0x00000001809E9D80
		protected override void OnInitiate() {} // 0x00000001809EA590-0x00000001809EA610
		protected override void OnUpdate() {} // 0x00000001809EA610-0x00000001809EA780
		private void Solve() {} // 0x00000001809EAD60-0x00000001809EAEC0
		private void Read() {} // 0x00000001809EA780-0x00000001809EAC90
		private void Write() {} // 0x00000001809EAF20-0x00000001809EB0D0
	}
}
