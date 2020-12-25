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
	// [AddComponentMenu] // 0x000000018013B970-0x000000018013B9D0
	// [HelpURL] // 0x000000018013B970-0x000000018013B9D0
	public class GrounderIK : Grounder // TypeDefIndex: 6684
	{
		// Fields
		public IK[] legs; // 0x40
		// [Tooltip] // 0x000000018013BA20-0x000000018013BA50
		public Transform pelvis; // 0x48
		// [Tooltip] // 0x000000018013BAE0-0x000000018013BB10
		public Transform characterRoot; // 0x50
		// [Range] // 0x000000018013BB70-0x000000018013BBD0
		// [Tooltip] // 0x000000018013BB70-0x000000018013BBD0
		public float rootRotationWeight; // 0x58
		// [Tooltip] // 0x000000018013BC60-0x000000018013BC90
		public float rootRotationSpeed; // 0x5C
		// [Tooltip] // 0x000000018013BD40-0x000000018013BD70
		public float maxRootRotationAngle; // 0x60
		private Transform[] feet; // 0x68
		private Quaternion[] footRotations; // 0x70
		private Vector3 animatedPelvisLocalPosition; // 0x78
		private Vector3 solvedPelvisLocalPosition; // 0x84
		private int solvedFeet; // 0x90
		private bool solved; // 0x94
		private float lastWeight; // 0x98
	
		// Constructors
		public GrounderIK() {} // 0x0000000180536310-0x00000001805363E0
	
		// Methods
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		protected override void OpenUserManual() {} // 0x00000001805359D0-0x0000000180535A10
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		protected override void OpenScriptReference() {} // 0x0000000180535990-0x00000001805359D0
		public override void ResetPosition() {} // 0x0000000180535A10-0x0000000180535A30
		private bool IsReadyToInitiate() => default; // 0x0000000180534E50-0x0000000180534FE0
		private void OnDisable() {} // 0x00000001805351F0-0x0000000180535330
		private void Update() {} // 0x0000000180535EC0-0x0000000180536310
		private void Initiate() {} // 0x0000000180534900-0x0000000180534E50
		private void OnSolverUpdate() {} // 0x0000000180535590-0x0000000180535990
		private void SetLegIK(int index) {} // 0x0000000180535A30-0x0000000180535EC0
		private void OnPostSolverUpdate() {} // 0x0000000180535330-0x0000000180535590
		private void OnDestroy() {} // 0x0000000180534FE0-0x00000001805351F0
	}
}
