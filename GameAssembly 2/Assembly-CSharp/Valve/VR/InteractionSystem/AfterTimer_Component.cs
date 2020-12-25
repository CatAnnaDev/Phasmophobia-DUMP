/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	[Serializable]
	public class AfterTimer_Component : MonoBehaviour // TypeDefIndex: 8403
	{
		// Fields
		private Action callback; // 0x18
		private float triggerTime; // 0x20
		private bool timerActive; // 0x24
		private bool triggerOnEarlyDestroy; // 0x25
	
		// Constructors
		public AfterTimer_Component() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		public void Init(float _time, Action _callback, bool earlydestroy) {} // 0x0000000180FB2790-0x0000000180FB2820
		// [IteratorStateMachine] // 0x0000000180145E10-0x0000000180145E60
		private IEnumerator Wait() => default; // 0x0000000180FB28C0-0x0000000180FB2930
		private void OnDestroy() {} // 0x0000000180FB2820-0x0000000180FB28C0
	}
}
