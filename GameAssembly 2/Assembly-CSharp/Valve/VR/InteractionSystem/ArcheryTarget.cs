/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class ArcheryTarget : MonoBehaviour // TypeDefIndex: 8412
	{
		// Fields
		public UnityEvent onTakeDamage; // 0x18
		public bool onceOnly; // 0x20
		public Transform targetCenter; // 0x28
		public Transform baseTransform; // 0x30
		public Transform fallenDownTransform; // 0x38
		public float fallTime; // 0x40
		private const float targetRadius = 0.25f; // Metadata: 0x006558C1
		private bool targetEnabled; // 0x44
	
		// Constructors
		public ArcheryTarget() {} // 0x0000000180FB2A60-0x0000000180FB2A80
	
		// Methods
		private void ApplyDamage() {} // 0x0000000180FB2940-0x0000000180FB2950
		private void FireExposure() {} // 0x0000000180FB2940-0x0000000180FB2950
		private void OnDamageTaken() {} // 0x0000000180FB29C0-0x0000000180FB2A60
		// [IteratorStateMachine] // 0x0000000180147FA0-0x0000000180147FF0
		private IEnumerator FallDown() => default; // 0x0000000180FB2950-0x0000000180FB29C0
	}
}
