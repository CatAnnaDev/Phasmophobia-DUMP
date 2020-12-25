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
	// [AddComponentMenu] // 0x00000001800D65B0-0x00000001800D65E0
	public class VRIK : IK // TypeDefIndex: 6703
	{
		// Fields
		// [ContextMenuItem] // 0x00000001800D65E0-0x00000001800D6660
		// [Tooltip] // 0x00000001800D65E0-0x00000001800D6660
		public References references; // 0x38
		// [Tooltip] // 0x00000001800D6770-0x00000001800D67A0
		public IKSolverVR solver; // 0x40
	
		// Nested types
		[Serializable]
		public class References // TypeDefIndex: 6704
		{
			// Fields
			public Transform root; // 0x10
			public Transform pelvis; // 0x18
			public Transform spine; // 0x20
			public Transform chest; // 0x28
			public Transform neck; // 0x30
			public Transform head; // 0x38
			public Transform leftShoulder; // 0x40
			public Transform leftUpperArm; // 0x48
			public Transform leftForearm; // 0x50
			public Transform leftHand; // 0x58
			public Transform rightShoulder; // 0x60
			public Transform rightUpperArm; // 0x68
			public Transform rightForearm; // 0x70
			public Transform rightHand; // 0x78
			public Transform leftThigh; // 0x80
			public Transform leftCalf; // 0x88
			public Transform leftFoot; // 0x90
			public Transform leftToes; // 0x98
			public Transform rightThigh; // 0xA0
			public Transform rightCalf; // 0xA8
			public Transform rightFoot; // 0xB0
			public Transform rightToes; // 0xB8
	
			// Properties
			public bool isFilled { get => default; } // 0x00000001807D3820-0x00000001807D3BE0 
			public bool isEmpty { get => default; } // 0x00000001807D3310-0x00000001807D3820 
	
			// Constructors
			public References() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public Transform[] GetTransforms() => default; // 0x00000001807D2AB0-0x00000001807D3310
			public static bool AutoDetectReferences(Transform root, out References references) {
				references = default;
				return default;
			} // 0x00000001807D25F0-0x00000001807D2AB0
		}
	
		// Constructors
		public VRIK() {} // 0x00000001807D9390-0x00000001807D9420
	
		// Methods
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		protected override void OpenUserManual() {} // 0x00000001807D9340-0x00000001807D9390
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		protected override void OpenScriptReference() {} // 0x00000001807D92B0-0x00000001807D9300
		// [ContextMenu] // 0x00000001800D69C0-0x00000001800D69F0
		private void OpenSetupTutorial() {} // 0x00000001807D9300-0x00000001807D9340
		// [ContextMenu] // 0x00000001800D6AF0-0x00000001800D6B20
		public void AutoDetectReferences() {} // 0x00000001807D91D0-0x00000001807D9200
		// [ContextMenu] // 0x00000001800D6B50-0x00000001800D6B80
		public void GuessHandOrientations() {} // 0x00000001807D9200-0x00000001807D9230
		public override IKSolver GetIKSolver() => default; // 0x0000000180249A10-0x0000000180249A20
		protected override void InitiateSolver() {} // 0x00000001807D9230-0x00000001807D92B0
	}
}
