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
	[Serializable]
	public class FOVKick // TypeDefIndex: 5861
	{
		// Fields
		public Camera Camera; // 0x10
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public float originalFov; // 0x18
		public float FOVIncrease; // 0x1C
		public float TimeToIncrease; // 0x20
		public float TimeToDecrease; // 0x24
		public AnimationCurve IncreaseCurve; // 0x28
	
		// Constructors
		public FOVKick() {} // 0x0000000180A3E1C0-0x0000000180A3E1E0
	
		// Methods
		public void Setup(Camera camera) {} // 0x0000000180A3E0C0-0x0000000180A3E1C0
		private void CheckStatus(Camera camera) {} // 0x0000000180A3DF10-0x0000000180A3DFE0
		public void ChangeCamera(Camera camera) {} // 0x0000000180248410-0x0000000180248420
		// [IteratorStateMachine] // 0x00000001800F47F0-0x00000001800F4840
		public IEnumerator FOVKickUp() => default; // 0x0000000180A3E050-0x0000000180A3E0C0
		// [IteratorStateMachine] // 0x00000001800F4950-0x00000001800F49A0
		public IEnumerator FOVKickDown() => default; // 0x0000000180A3DFE0-0x0000000180A3E050
	}
}
