/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityStandardAssets.Utility;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Effects
{
	public class Explosive : MonoBehaviour // TypeDefIndex: 5893
	{
		// Fields
		public Transform explosionPrefab; // 0x18
		public float detonationImpactVelocity; // 0x20
		public float sizeMultiplier; // 0x24
		public bool reset; // 0x28
		public float resetTimeDelay; // 0x2C
		private bool m_Exploded; // 0x30
		private ObjectResetter m_ObjectResetter; // 0x38
	
		// Constructors
		public Explosive() {} // 0x0000000180622480-0x00000001806224A0
	
		// Methods
		private void Start() {} // 0x0000000180622430-0x0000000180622480
		// [IteratorStateMachine] // 0x00000001800F9CE0-0x00000001800F9D30
		private IEnumerator OnCollisionEnter(Collision col) => default; // 0x0000000180622390-0x0000000180622420
		public void Reset() {} // 0x0000000180622420-0x0000000180622430
	}
}
