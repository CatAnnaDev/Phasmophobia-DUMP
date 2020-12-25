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
	// [AddComponentMenu] // 0x000000018014A110-0x000000018014A170
	// [HelpURL] // 0x000000018014A110-0x000000018014A170
	public class FullBodyBipedIK : IK // TypeDefIndex: 6696
	{
		// Fields
		public BipedReferences references; // 0x38
		public IKSolverFullBodyBiped solver; // 0x40
	
		// Constructors
		public FullBodyBipedIK() {} // 0x0000000180531740-0x00000001805317D0
	
		// Methods
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		protected override void OpenUserManual() {} // 0x0000000180530F80-0x0000000180530FC0
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		protected override void OpenScriptReference() {} // 0x0000000180530F00-0x0000000180530F40
		// [ContextMenu] // 0x000000018014A590-0x000000018014A5C0
		private void OpenSetupTutorial() {} // 0x0000000180530F40-0x0000000180530F80
		// [ContextMenu] // 0x000000018014B950-0x000000018014B980
		private void OpenInspectorTutorial() {} // 0x0000000180530EC0-0x0000000180530F00
		// [ContextMenu] // 0x00000001800D51F0-0x00000001800D5220
		private void SupportGroup() {} // 0x0000000180531700-0x0000000180531740
		// [ContextMenu] // 0x00000001800D5260-0x00000001800D5290
		private void ASThread() {} // 0x0000000180530D90-0x0000000180530DD0
		public void SetReferences(BipedReferences references, Transform rootNode) {} // 0x00000001805316B0-0x0000000180531700
		public override IKSolver GetIKSolver() => default; // 0x0000000180249A10-0x0000000180249A20
		public bool ReferencesError(ref string errorMessage) => default; // 0x0000000180530FC0-0x0000000180531220
		public bool ReferencesWarning(ref string warningMessage) => default; // 0x0000000180531220-0x0000000180531650
		// [ContextMenu] // 0x000000018014BDA0-0x000000018014BDD0
		private void Reinitiate() {} // 0x0000000180531650-0x00000001805316B0
		// [ContextMenu] // 0x00000001800D6AF0-0x00000001800D6B20
		private void AutoDetectReferences() {} // 0x0000000180530DD0-0x0000000180530EC0
	}
}
