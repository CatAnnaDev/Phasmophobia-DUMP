/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion
{
	[Serializable]
	public class BipedReferences // TypeDefIndex: 6575
	{
		// Fields
		public Transform root; // 0x10
		public Transform pelvis; // 0x18
		public Transform leftThigh; // 0x20
		public Transform leftCalf; // 0x28
		public Transform leftFoot; // 0x30
		public Transform rightThigh; // 0x38
		public Transform rightCalf; // 0x40
		public Transform rightFoot; // 0x48
		public Transform leftUpperArm; // 0x50
		public Transform leftForearm; // 0x58
		public Transform leftHand; // 0x60
		public Transform rightUpperArm; // 0x68
		public Transform rightForearm; // 0x70
		public Transform rightHand; // 0x78
		public Transform head; // 0x80
		public Transform[] spine; // 0x88
		public Transform[] eyes; // 0x90
	
		// Properties
		public virtual bool isFilled { get => default; } // 0x00000001804BB870-0x00000001804BBCB0 
		public bool isEmpty { get => default; } // 0x000000018041F9D0-0x000000018041F9F0 
	
		// Nested types
		public struct AutoDetectParams // TypeDefIndex: 6576
		{
			// Fields
			public bool legsParentInSpine; // 0x00
			public bool includeEyes; // 0x01
	
			// Properties
			public static AutoDetectParams Default { get => default; } // 0x00000001804B1320-0x00000001804B1330 
	
			// Constructors
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes) : this() {
				this.legsParentInSpine = default;
				this.includeEyes = default;
			} // 0x0000000180019D80-0x0000000180019E40
		}
	
		// Constructors
		public BipedReferences() {} // 0x00000001804BB7F0-0x00000001804BB870
	
		// Methods
		public virtual bool IsEmpty(bool includeRoot) => default; // 0x00000001804B9D50-0x00000001804BA1D0
		public virtual bool Contains(Transform t, bool ignoreRoot = false /* Metadata: 0x00652D4A */) => default; // 0x00000001804B8640-0x00000001804B8AD0
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams) => default; // 0x00000001804B82B0-0x00000001804B8640
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams) {} // 0x00000001804B8C60-0x00000001804B97A0
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams) {} // 0x00000001804B7D40-0x00000001804B82B0
		public static bool SetupError(BipedReferences references, ref string errorMessage) => default; // 0x00000001804BB140-0x00000001804BB280
		public static bool SetupWarning(BipedReferences references, ref string warningMessage) => default; // 0x00000001804BB280-0x00000001804BB370
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm) => default; // 0x00000001804BA1D0-0x00000001804BA2C0
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams) => default; // 0x00000001804B79C0-0x00000001804B7AC0
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams) => default; // 0x00000001804B7BB0-0x00000001804B7D40
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms) {} // 0x00000001804B8AD0-0x00000001804B8C60
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform) {} // 0x00000001804B7AC0-0x00000001804B7BB0
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage) => default; // 0x00000001804BA2C0-0x00000001804BA9B0
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage) => default; // 0x00000001804BA9B0-0x00000001804BADD0
		private static bool SpineError(BipedReferences references, ref string errorMessage) => default; // 0x00000001804BB370-0x00000001804BB7F0
		private static bool SpineWarning(BipedReferences references, ref string warningMessage) => default; // 0x0000000180250A70-0x0000000180250A80
		private static bool EyesError(BipedReferences references, ref string errorMessage) => default; // 0x00000001804B97A0-0x00000001804B99A0
		private static bool EyesWarning(BipedReferences references, ref string warningMessage) => default; // 0x0000000180250A70-0x0000000180250A80
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage) => default; // 0x00000001804BADD0-0x00000001804BB140
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage) => default; // 0x00000001804B99A0-0x00000001804B9C30
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation) => default; // 0x00000001804B9C30-0x00000001804B9D50
	}
}
