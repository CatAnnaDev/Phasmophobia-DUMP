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
	public class ResetInteractionObject : MonoBehaviour // TypeDefIndex: 6636
	{
		// Fields
		public float resetDelay; // 0x18
		private Vector3 defaultPosition; // 0x1C
		private Quaternion defaultRotation; // 0x28
		private Transform defaultParent; // 0x38
		private Rigidbody r; // 0x40
	
		// Constructors
		public ResetInteractionObject() {} // 0x000000018053ADA0-0x000000018053ADB0
	
		// Methods
		private void Start() {} // 0x000000018053AEE0-0x000000018053AFB0
		private void OnPickUp(Transform t) {} // 0x000000018053ADB0-0x000000018053AE60
		// [IteratorStateMachine] // 0x0000000180131C50-0x0000000180131CA0
		private IEnumerator ResetObject(float resetTime) => default; // 0x000000018053AE60-0x000000018053AEE0
	}
}
