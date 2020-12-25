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
	public class IKSolverFABRIKRoot : IKSolver // TypeDefIndex: 6729
	{
		// Fields
		public int iterations; // 0x58
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float rootPin; // 0x5C
		public FABRIKChain[] chains; // 0x60
		private bool zeroWeightApplied; // 0x68
		private bool[] isRoot; // 0x70
		private Vector3 rootDefaultPosition; // 0x78
	
		// Constructors
		public IKSolverFABRIKRoot() {} // 0x00000001809B9C10-0x00000001809B9C80
	
		// Methods
		public override bool IsValid(ref string message) => default; // 0x00000001809B8A30-0x00000001809B9660
		public override void StoreDefaultLocalState() {} // 0x00000001809B9B40-0x00000001809B9C10
		public override void FixTransforms() {} // 0x00000001809B8130-0x00000001809B8200
		protected override void OnInitiate() {} // 0x00000001809B9660-0x00000001809B9870
		private bool IsRoot(int index) => default; // 0x00000001809B8950-0x00000001809B8A30
		protected override void OnUpdate() {} // 0x00000001809B9870-0x00000001809B9B40
		public override Point[] GetPoints() => default; // 0x00000001809B8750-0x00000001809B8950
		public override Point GetPoint(Transform transform) => default; // 0x00000001809B86A0-0x00000001809B8750
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain) {} // 0x00000001809B7FC0-0x00000001809B8130
		private Vector3 GetCentroid() => default; // 0x00000001809B8200-0x00000001809B86A0
	}
}
