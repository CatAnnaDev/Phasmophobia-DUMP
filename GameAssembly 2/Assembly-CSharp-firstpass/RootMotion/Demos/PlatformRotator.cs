/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public class PlatformRotator : MonoBehaviour // TypeDefIndex: 6646
	{
		// Fields
		public float maxAngle; // 0x18
		public float switchRotationTime; // 0x1C
		public float random; // 0x20
		public float rotationSpeed; // 0x24
		public Vector3 movePosition; // 0x28
		public float moveSpeed; // 0x34
		public int characterLayer; // 0x38
		private Quaternion defaultRotation; // 0x3C
		private Quaternion targetRotation; // 0x4C
		private Vector3 targetPosition; // 0x5C
		private Vector3 velocity; // 0x68
		private Rigidbody r; // 0x78
	
		// Constructors
		public PlatformRotator() {} // 0x000000018053A6A0-0x000000018053A6D0
	
		// Methods
		private void Start() {} // 0x000000018053A4A0-0x000000018053A630
		private void FixedUpdate() {} // 0x000000018053A020-0x000000018053A310
		// [IteratorStateMachine] // 0x0000000180133160-0x00000001801331B0
		private IEnumerator SwitchRotation() => default; // 0x000000018053A630-0x000000018053A6A0
		private void OnCollisionEnter(Collision collision) {} // 0x000000018053A310-0x000000018053A3E0
		private void OnCollisionExit(Collision collision) {} // 0x000000018053A3E0-0x000000018053A4A0
	}
}
