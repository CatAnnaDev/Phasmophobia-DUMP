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

namespace UnityStandardAssets.Utility
{
	public class ObjectResetter : MonoBehaviour // TypeDefIndex: 5867
	{
		// Fields
		private Vector3 originalPosition; // 0x18
		private Quaternion originalRotation; // 0x24
		private List<Transform> originalStructure; // 0x38
		private Rigidbody Rigidbody; // 0x40
	
		// Constructors
		public ObjectResetter() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void Start() {} // 0x0000000180A41E10-0x0000000180A41F10
		public void DelayedReset(float delay) {} // 0x0000000180A41D00-0x0000000180A41D90
		// [IteratorStateMachine] // 0x00000001800F5940-0x00000001800F5990
		public IEnumerator ResetCoroutine(float delay) => default; // 0x0000000180A41D90-0x0000000180A41E10
	}
}
