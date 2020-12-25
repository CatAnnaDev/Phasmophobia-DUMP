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

namespace RootMotion.FinalIK
{
	public abstract class OffsetModifierVRIK : MonoBehaviour // TypeDefIndex: 6814
	{
		// Fields
		// [Tooltip] // 0x0000000180100020-0x0000000180100050
		public float weight; // 0x18
		// [Tooltip] // 0x0000000180101280-0x00000001801012B0
		public VRIK ik; // 0x20
		private float lastTime; // 0x28
	
		// Properties
		protected float deltaTime { get; } // 0x00000001807E7720-0x00000001807E7740 
	
		// Constructors
		protected OffsetModifierVRIK() {} // 0x000000018053ADA0-0x000000018053ADB0
	
		// Methods
		protected abstract void OnModifyOffset();
		protected virtual void Start() {} // 0x00000001807E76B0-0x00000001807E7720
		// [IteratorStateMachine] // 0x0000000180101370-0x00000001801013C0
		private IEnumerator Initiate() => default; // 0x00000001807E7420-0x00000001807E7490
		private void ModifyOffset() {} // 0x00000001807E7490-0x00000001807E75A0
		protected virtual void OnDestroy() {} // 0x00000001807E75A0-0x00000001807E76B0
	}
}
