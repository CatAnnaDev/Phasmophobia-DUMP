/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 6733
	{
		// Fields
		public Transform rootNode; // 0xD0
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float spineStiffness; // 0xD8
		// [Range] // 0x00000001800DD220-0x00000001800DD240
		public float pullBodyVertical; // 0xDC
		// [Range] // 0x00000001800DD220-0x00000001800DD240
		public float pullBodyHorizontal; // 0xE0
		private Vector3 offset; // 0xF0
	
		// Properties
		public IKEffector bodyEffector { get => default; } // 0x00000001809E7BF0-0x00000001809E7C30 
		public IKEffector leftShoulderEffector { get => default; } // 0x00000001809E7DB0-0x00000001809E7DF0 
		public IKEffector rightShoulderEffector { get => default; } // 0x00000001809E7FD0-0x00000001809E8010 
		public IKEffector leftThighEffector { get => default; } // 0x00000001809E7DF0-0x00000001809E7E30 
		public IKEffector rightThighEffector { get => default; } // 0x00000001809E8010-0x00000001809E8050 
		public IKEffector leftHandEffector { get => default; } // 0x00000001809E7CF0-0x00000001809E7D30 
		public IKEffector rightHandEffector { get => default; } // 0x00000001809E7F10-0x00000001809E7F50 
		public IKEffector leftFootEffector { get => default; } // 0x00000001809E7CB0-0x00000001809E7CF0 
		public IKEffector rightFootEffector { get => default; } // 0x00000001809E7ED0-0x00000001809E7F10 
		public FBIKChain leftArmChain { get => default; } // 0x00000001809E7C30-0x00000001809E7C70 
		public FBIKChain rightArmChain { get => default; } // 0x00000001809E7E50-0x00000001809E7E90 
		public FBIKChain leftLegChain { get => default; } // 0x00000001809E7D30-0x00000001809E7D70 
		public FBIKChain rightLegChain { get => default; } // 0x00000001809E7F50-0x00000001809E7F90 
		public IKMappingLimb leftArmMapping { get => default; } // 0x00000001809E7C70-0x00000001809E7CB0 
		public IKMappingLimb rightArmMapping { get => default; } // 0x00000001809E7E90-0x00000001809E7ED0 
		public IKMappingLimb leftLegMapping { get => default; } // 0x00000001809E7D70-0x00000001809E7DB0 
		public IKMappingLimb rightLegMapping { get => default; } // 0x00000001809E7F90-0x00000001809E7FD0 
		public IKMappingBone headMapping { get => default; } // 0x00000001809E4A90-0x00000001809E4AD0 
		public Vector3 pullBodyOffset { get; private set; } // 0x00000001809E7E30-0x00000001809E7E50 0x00000001809E8050-0x00000001809E8070
	
		// Constructors
		public IKSolverFullBodyBiped() {} // 0x00000001809E7BD0-0x00000001809E7BF0
	
		// Methods
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f /* Metadata: 0x00652E89 */) {} // 0x00000001809E5750-0x00000001809E57C0
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight) {} // 0x00000001809E57C0-0x00000001809E58B0
		public FBIKChain GetChain(FullBodyBipedChain c) => default; // 0x00000001809E4410-0x00000001809E44E0
		public FBIKChain GetChain(FullBodyBipedEffector effector) => default; // 0x00000001809E4220-0x00000001809E4410
		public IKEffector GetEffector(FullBodyBipedEffector effector) => default; // 0x00000001809E44E0-0x00000001809E46F0
		public IKEffector GetEndEffector(FullBodyBipedChain c) => default; // 0x00000001809E46F0-0x00000001809E47C0
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain) => default; // 0x00000001809E4B90-0x00000001809E4C60
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector) => default; // 0x00000001809E4C60-0x00000001809E4E40
		public IKMappingSpine GetSpineMapping() => default; // 0x0000000180274980-0x0000000180274990
		public IKMappingBone GetHeadMapping() => default; // 0x00000001809E4A90-0x00000001809E4AD0
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb) => default; // 0x00000001809E3E00-0x00000001809E3ED0
		public override bool IsValid(ref string message) => default; // 0x00000001809E4F00-0x00000001809E50E0
		public void SetToReferences(BipedReferences references, Transform rootNode = null) {} // 0x00000001809E5BF0-0x00000001809E7A80
		public static Transform DetectRootNodeBone(BipedReferences references) => default; // 0x00000001809E3940-0x00000001809E3E00
		public void SetLimbOrientations(BipedLimbOrientations o) {} // 0x00000001809E5B80-0x00000001809E5BF0
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation) {} // 0x00000001809E58B0-0x00000001809E5B80
		private static Transform GetLeftClavicle(BipedReferences references) => default; // 0x00000001809E4AD0-0x00000001809E4B90
		private static Transform GetRightClavicle(BipedReferences references) => default; // 0x00000001809E4E40-0x00000001809E4F00
		private static bool Contains(Transform[] array, Transform transform) => default; // 0x00000001809E3880-0x00000001809E3940
		protected override void ReadPose() {} // 0x00000001809E5340-0x00000001809E5750
		private void PullBody() {} // 0x00000001809E50E0-0x00000001809E5340
		private Vector3 GetBodyOffset() => default; // 0x00000001809E3ED0-0x00000001809E4220
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset) => default; // 0x00000001809E47C0-0x00000001809E4A90
		protected override void ApplyBendConstraints() {} // 0x00000001809E3350-0x00000001809E3880
		protected override void WritePose() {} // 0x00000001809E7A80-0x00000001809E7BD0
	}
}
