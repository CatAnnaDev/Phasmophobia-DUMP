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
	// [AddComponentMenu] // 0x0000000180137570-0x00000001801375D0
	// [HelpURL] // 0x0000000180137570-0x00000001801375D0
	public class BipedIK : SolverManager // TypeDefIndex: 6668
	{
		// Fields
		public BipedReferences references; // 0x38
		public BipedIKSolvers solvers; // 0x40
	
		// Constructors
		public BipedIK() {} // 0x0000000180522790-0x00000001805229A0
	
		// Methods
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		private void OpenUserManual() {} // 0x0000000180522010-0x0000000180522050
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		private void OpenScriptReference() {} // 0x0000000180521FD0-0x0000000180522010
		// [ContextMenu] // 0x00000001800D51F0-0x00000001800D5220
		private void SupportGroup() {} // 0x0000000180522520-0x0000000180522560
		// [ContextMenu] // 0x00000001800D5260-0x00000001800D5290
		private void ASThread() {} // 0x0000000180521850-0x0000000180521890
		public float GetIKPositionWeight(AvatarIKGoal goal) => default; // 0x00000001805219D0-0x0000000180521A40
		public float GetIKRotationWeight(AvatarIKGoal goal) => default; // 0x0000000180521AE0-0x0000000180521B50
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight) {} // 0x0000000180522050-0x00000001805220C0
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight) {} // 0x0000000180522140-0x00000001805221B0
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition) {} // 0x00000001805220C0-0x0000000180522140
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation) {} // 0x00000001805221B0-0x0000000180522220
		public Vector3 GetIKPosition(AvatarIKGoal goal) => default; // 0x0000000180521A40-0x0000000180521AE0
		public Quaternion GetIKRotation(AvatarIKGoal goal) => default; // 0x0000000180521B50-0x0000000180521BC0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes) {} // 0x0000000180522250-0x0000000180522290
		public void SetLookAtPosition(Vector3 lookAtPosition) {} // 0x0000000180522220-0x0000000180522250
		public void SetSpinePosition(Vector3 spinePosition) {} // 0x0000000180522290-0x00000001805222C0
		public void SetSpineWeight(float weight) {} // 0x00000001805222C0-0x00000001805222F0
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal) => default; // 0x0000000180521960-0x00000001805219D0
		public void InitiateBipedIK() {} // 0x0000000180277BB0-0x0000000180277BD0
		public void UpdateBipedIK() {} // 0x00000001803E89A0-0x00000001803E89C0
		public void SetToDefaults() {} // 0x00000001805222F0-0x0000000180522520
		protected override void FixTransforms() {} // 0x0000000180521890-0x0000000180521960
		protected override void InitiateSolver() {} // 0x0000000180521BC0-0x0000000180521FA0
		protected override void UpdateSolver() {} // 0x0000000180522560-0x0000000180522790
		public void LogWarning(string message) {} // 0x0000000180521FA0-0x0000000180521FD0
	}
}
