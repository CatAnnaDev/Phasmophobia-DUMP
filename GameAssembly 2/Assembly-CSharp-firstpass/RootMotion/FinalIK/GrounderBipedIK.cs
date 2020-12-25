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
	// [AddComponentMenu] // 0x0000000180139840-0x00000001801398A0
	// [HelpURL] // 0x0000000180139840-0x00000001801398A0
	public class GrounderBipedIK : Grounder // TypeDefIndex: 6681
	{
		// Fields
		// [Tooltip] // 0x0000000180139920-0x0000000180139950
		public BipedIK ik; // 0x40
		// [Tooltip] // 0x0000000180139A10-0x0000000180139A40
		public float spineBend; // 0x48
		// [Tooltip] // 0x0000000180139AC0-0x0000000180139AF0
		public float spineSpeed; // 0x4C
		private Transform[] feet; // 0x50
		private Quaternion[] footRotations; // 0x58
		private Vector3 animatedPelvisLocalPosition; // 0x60
		private Vector3 solvedPelvisLocalPosition; // 0x6C
		private Vector3 spineOffset; // 0x78
		private float lastWeight; // 0x84
	
		// Constructors
		public GrounderBipedIK() {} // 0x00000001805333B0-0x0000000180533490
	
		// Methods
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		protected override void OpenUserManual() {} // 0x00000001805330A0-0x00000001805330E0
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		protected override void OpenScriptReference() {} // 0x0000000180533060-0x00000001805330A0
		public override void ResetPosition() {} // 0x00000001805330E0-0x0000000180533160
		private bool IsReadyToInitiate() => default; // 0x0000000180532400-0x00000001805324C0
		private void Update() {} // 0x0000000180533270-0x00000001805333B0
		private void Initiate() {} // 0x0000000180532040-0x0000000180532400
		private void OnDisable() {} // 0x0000000180532680-0x00000001805326E0
		private void OnSolverUpdate() {} // 0x0000000180532920-0x0000000180533060
		private void SetLegIK(IKSolverLimb limb, int index) {} // 0x0000000180533160-0x0000000180533270
		private void OnPostSolverUpdate() {} // 0x00000001805326E0-0x0000000180532920
		private void OnDestroy() {} // 0x00000001805324C0-0x0000000180532680
	}
}
