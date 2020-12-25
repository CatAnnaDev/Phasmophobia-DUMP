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
	// [AddComponentMenu] // 0x000000018013D900-0x000000018013D930
	public class GrounderVRIK : Grounder // TypeDefIndex: 6687
	{
		// Fields
		// [Tooltip] // 0x000000018013D9E0-0x000000018013DA10
		public VRIK ik; // 0x40
		private Transform[] feet; // 0x48
	
		// Constructors
		public GrounderVRIK() {} // 0x00000001809A9190-0x00000001809A91F0
	
		// Methods
		// [ContextMenu] // 0x00000001800F4D60-0x00000001800F4D90
		private void OpenTutorial() {} // 0x0000000180246DB0-0x0000000180246DC0
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		protected override void OpenUserManual() {} // 0x0000000180246DB0-0x0000000180246DC0
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		protected override void OpenScriptReference() {} // 0x0000000180246DB0-0x0000000180246DC0
		public override void ResetPosition() {} // 0x0000000180535A10-0x0000000180535A30
		private bool IsReadyToInitiate() => default; // 0x00000001809A84F0-0x00000001809A8590
		private void Update() {} // 0x00000001809A9070-0x00000001809A9190
		private void Initiate() {} // 0x00000001809A8210-0x00000001809A84F0
		private void OnSolverUpdate() {} // 0x00000001809A8B30-0x00000001809A8F10
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg) {} // 0x00000001809A8F10-0x00000001809A9070
		private void OnPostSolverUpdate() {} // 0x00000001809A8890-0x00000001809A8B30
		private void OnDrawGizmosSelected() {} // 0x00000001809A8750-0x00000001809A8890
		private void OnDestroy() {} // 0x00000001809A8590-0x00000001809A8750
	}
}
