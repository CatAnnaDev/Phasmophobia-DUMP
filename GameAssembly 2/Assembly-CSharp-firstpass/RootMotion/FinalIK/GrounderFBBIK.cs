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
	// [AddComponentMenu] // 0x0000000180139C10-0x0000000180139C70
	// [HelpURL] // 0x0000000180139C10-0x0000000180139C70
	public class GrounderFBBIK : Grounder // TypeDefIndex: 6682
	{
		// Fields
		// [Tooltip] // 0x0000000180139CC0-0x0000000180139CF0
		public FullBodyBipedIK ik; // 0x40
		// [Tooltip] // 0x0000000180139A10-0x0000000180139A40
		public float spineBend; // 0x48
		// [Tooltip] // 0x0000000180139AC0-0x0000000180139AF0
		public float spineSpeed; // 0x4C
		public SpineEffector[] spine; // 0x50
		private Transform[] feet; // 0x58
		private Vector3 spineOffset; // 0x60
		private bool firstSolve; // 0x6C
	
		// Nested types
		[Serializable]
		public class SpineEffector // TypeDefIndex: 6683
		{
			// Fields
			// [Tooltip] // 0x000000018013B2F0-0x000000018013B320
			public FullBodyBipedEffector effectorType; // 0x10
			// [Tooltip] // 0x000000018013B3D0-0x000000018013B400
			public float horizontalWeight; // 0x14
			// [Tooltip] // 0x000000018013B820-0x000000018013B850
			public float verticalWeight; // 0x18
	
			// Constructors
			public SpineEffector() {} // 0x00000001804C2F30-0x00000001804C2F40
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight) {} // 0x000000018053C6F0-0x000000018053C740
		}
	
		// Constructors
		public GrounderFBBIK() {} // 0x0000000180534820-0x0000000180534900
	
		// Methods
		// [ContextMenu] // 0x00000001800F4D60-0x00000001800F4D90
		private void OpenTutorial() {} // 0x00000001805343B0-0x00000001805343F0
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		protected override void OpenUserManual() {} // 0x00000001805343F0-0x0000000180534430
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		protected override void OpenScriptReference() {} // 0x0000000180534370-0x00000001805343B0
		public override void ResetPosition() {} // 0x0000000180534430-0x00000001805344B0
		private bool IsReadyToInitiate() => default; // 0x00000001805339E0-0x0000000180533A80
		private void Update() {} // 0x0000000180534700-0x0000000180534820
		private void FixedUpdate() {} // 0x0000000180533710-0x0000000180533720
		private void LateUpdate() {} // 0x0000000180533710-0x0000000180533720
		private void Initiate() {} // 0x0000000180533720-0x00000001805339E0
		private void OnSolverUpdate() {} // 0x0000000180533CD0-0x0000000180534370
		private void SetLegIK(IKEffector effector, Grounding.Leg leg) {} // 0x00000001805344B0-0x0000000180534700
		private void OnDrawGizmosSelected() {} // 0x0000000180533B90-0x0000000180533CD0
		private void OnDestroy() {} // 0x0000000180533A80-0x0000000180533B90
	}
}
