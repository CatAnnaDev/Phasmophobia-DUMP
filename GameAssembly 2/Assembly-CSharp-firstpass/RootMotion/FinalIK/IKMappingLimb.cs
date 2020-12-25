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
	public class IKMappingLimb : IKMapping // TypeDefIndex: 6717
	{
		// Fields
		public Transform parentBone; // 0x10
		public Transform bone1; // 0x18
		public Transform bone2; // 0x20
		public Transform bone3; // 0x28
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float maintainRotationWeight; // 0x30
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float weight; // 0x34
		private BoneMap boneMapParent; // 0x38
		private BoneMap boneMap1; // 0x40
		private BoneMap boneMap2; // 0x48
		private BoneMap boneMap3; // 0x50
	
		// Nested types
		[Serializable]
		public enum BoneMapType // TypeDefIndex: 6718
		{
			Parent = 0,
			Bone1 = 1,
			Bone2 = 2,
			Bone3 = 3
		}
	
		// Constructors
		public IKMappingLimb() {} // 0x00000001809B2740-0x00000001809B28D0
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null) {} // 0x00000001809B2550-0x00000001809B2740
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message) => default; // 0x00000001809B19E0-0x00000001809B1A80
		public BoneMap GetBoneMap(BoneMapType boneMap) => default; // 0x00000001809B1540-0x00000001809B1600
		public void SetLimbOrientation(Vector3 upper, Vector3 lower) {} // 0x00000001809B1C40-0x00000001809B2010
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null) {} // 0x00000001809B1BD0-0x00000001809B1C40
		public void StoreDefaultLocalState() {} // 0x00000001809B2010-0x00000001809B21D0
		public void FixTransforms() {} // 0x00000001809B13F0-0x00000001809B1540
		public override void Initiate(IKSolverFullBody solver) {} // 0x00000001809B1600-0x00000001809B19E0
		public void ReadPose() {} // 0x00000001809B1A80-0x00000001809B1BD0
		public void WritePose(IKSolverFullBody solver, bool fullBody) {} // 0x00000001809B21D0-0x00000001809B2550
	}
}
