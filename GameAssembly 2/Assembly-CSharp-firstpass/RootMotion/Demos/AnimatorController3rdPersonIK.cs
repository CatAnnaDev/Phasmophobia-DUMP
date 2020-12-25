/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	// [RequireComponent] // 0x000000018012DD80-0x000000018012DE00
	// [RequireComponent] // 0x000000018012DD80-0x000000018012DE00
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson // TypeDefIndex: 6605
	{
		// Fields
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float headLookWeight; // 0x60
		public Vector3 gunHoldOffset; // 0x64
		public Vector3 leftHandOffset; // 0x70
		public Recoil recoil; // 0x80
		private AimIK aim; // 0x88
		private FullBodyBipedIK ik; // 0x90
		private Vector3 headLookAxis; // 0x98
		private Vector3 leftHandPosRelToRightHand; // 0xA4
		private Quaternion leftHandRotRelToRightHand; // 0xB0
		private Vector3 aimTarget; // 0xC0
		private Quaternion rightHandRotation; // 0xCC
	
		// Constructors
		public AnimatorController3rdPersonIK() {} // 0x00000001804B0C90-0x00000001804B0CC0
	
		// Methods
		protected override void Start() {} // 0x00000001804B0A30-0x00000001804B0C90
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget) {} // 0x00000001804B00C0-0x00000001804B0360
		private void Read() {} // 0x00000001804B0880-0x00000001804B0A30
		private void AimIK() {} // 0x00000001804AF910-0x00000001804AF970
		private void FBBIK() {} // 0x00000001804AF970-0x00000001804AFE20
		private void OnPreRead() {} // 0x00000001804B0480-0x00000001804B0880
		private void HeadLookAt(Vector3 lookAtTarget) {} // 0x00000001804AFE20-0x00000001804B00C0
		private void OnDestroy() {} // 0x00000001804B0360-0x00000001804B0480
	}
}
