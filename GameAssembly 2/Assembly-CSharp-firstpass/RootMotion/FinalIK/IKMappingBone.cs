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
	public class IKMappingBone : IKMapping // TypeDefIndex: 6716
	{
		// Fields
		public Transform bone; // 0x10
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float maintainRotationWeight; // 0x18
		private BoneMap boneMap; // 0x20
	
		// Constructors
		public IKMappingBone() {} // 0x00000001809B12A0-0x00000001809B1340
		public IKMappingBone(Transform bone) {} // 0x00000001809B1340-0x00000001809B13F0
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message) => default; // 0x00000001809B1130-0x00000001809B11D0
		public void StoreDefaultLocalState() {} // 0x00000001809B1210-0x00000001809B1270
		public void FixTransforms() {} // 0x00000001809B1000-0x00000001809B1040
		public override void Initiate(IKSolverFullBody solver) {} // 0x00000001809B1040-0x00000001809B1130
		public void ReadPose() {} // 0x00000001809B11D0-0x00000001809B1210
		public void WritePose(float solverWeight) {} // 0x00000001809B1270-0x00000001809B12A0
	}
}
