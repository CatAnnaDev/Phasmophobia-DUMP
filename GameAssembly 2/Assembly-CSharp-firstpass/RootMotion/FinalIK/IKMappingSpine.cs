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
	public class IKMappingSpine : IKMapping // TypeDefIndex: 6719
	{
		// Fields
		public Transform[] spineBones; // 0x10
		public Transform leftUpperArmBone; // 0x18
		public Transform rightUpperArmBone; // 0x20
		public Transform leftThighBone; // 0x28
		public Transform rightThighBone; // 0x30
		// [Range] // 0x00000001800DF130-0x00000001800DF150
		public int iterations; // 0x38
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float twistWeight; // 0x3C
		private int rootNodeIndex; // 0x40
		private BoneMap[] spine; // 0x48
		private BoneMap leftUpperArm; // 0x50
		private BoneMap rightUpperArm; // 0x58
		private BoneMap leftThigh; // 0x60
		private BoneMap rightThigh; // 0x68
		private bool useFABRIK; // 0x70
	
		// Constructors
		public IKMappingSpine() {} // 0x00000001809B50B0-0x00000001809B5260
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) {} // 0x00000001809B4E80-0x00000001809B50B0
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message) => default; // 0x00000001809B3960-0x00000001809B3D00
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) {} // 0x00000001809B4700-0x00000001809B4780
		public void StoreDefaultLocalState() {} // 0x00000001809B4780-0x00000001809B4840
		public void FixTransforms() {} // 0x00000001809B2B20-0x00000001809B2BC0
		public override void Initiate(IKSolverFullBody solver) {} // 0x00000001809B2E30-0x00000001809B3960
		private bool UseFABRIK() => default; // 0x00000001809B4840-0x00000001809B4870
		public void ReadPose() {} // 0x00000001809B4280-0x00000001809B4700
		public void WritePose(IKSolverFullBody solver) {} // 0x00000001809B4870-0x00000001809B4E80
		public void ForwardReach(Vector3 position) {} // 0x00000001809B2BC0-0x00000001809B2E30
		private void BackwardReach(Vector3 position) {} // 0x00000001809B28D0-0x00000001809B2B20
		private void MapToSolverPositions(IKSolverFullBody solver) {} // 0x00000001809B3D00-0x00000001809B4280
	}
}
