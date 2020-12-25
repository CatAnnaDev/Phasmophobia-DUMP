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

namespace Viveport
{
	public class MainThreadDispatcher : MonoBehaviour // TypeDefIndex: 7336
	{
		// Fields
		private static readonly Queue<Action> actions; // 0x00
		private static MainThreadDispatcher instance; // 0x08
	
		// Constructors
		public MainThreadDispatcher() {} // 0x0000000180276E90-0x0000000180276EA0
		static MainThreadDispatcher() {} // 0x0000000181B530C0-0x0000000181B53140
	
		// Methods
		private void Awake() {} // 0x0000000181B52A60-0x0000000181B52B70
		public void Update() {} // 0x0000000181B52F20-0x0000000181B530C0
		public static MainThreadDispatcher Instance() => default; // 0x0000000181B52DC0-0x0000000181B52EB0
		private void OnDestroy() {} // 0x0000000181B52EB0-0x0000000181B52F20
		public void Enqueue(IEnumerator action) {} // 0x0000000181B52BF0-0x0000000181B52DC0
		public void Enqueue(Action action) {} // 0x0000000181B52B70-0x0000000181B52BF0
		public void Enqueue<T1>(Action<T1> action, T1 param1) {}
		public void Enqueue<T1, T2>(Action<T1, T2> action, T1 param1, T2 param2) {}
		public void Enqueue<T1, T2, T3>(Action<T1, T2, T3> action, T1 param1, T2 param2, T3 param3) {}
		public void Enqueue<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 param1, T2 param2, T3 param3, T4 param4) {}
		// [IteratorStateMachine] // 0x0000000180123270-0x00000001801232C0
		private IEnumerator ActionWrapper(Action action) => default; // 0x0000000181B529F0-0x0000000181B52A60
		// [IteratorStateMachine] // 0x0000000180123490-0x00000001801234E0
		private IEnumerator ActionWrapper<T1>(Action<T1> action, T1 param1) => default;
		// [IteratorStateMachine] // 0x0000000180123670-0x00000001801236C0
		private IEnumerator ActionWrapper<T1, T2>(Action<T1, T2> action, T1 param1, T2 param2) => default;
		// [IteratorStateMachine] // 0x0000000180123820-0x0000000180123870
		private IEnumerator ActionWrapper<T1, T2, T3>(Action<T1, T2, T3> action, T1 param1, T2 param2, T3 param3) => default;
		// [IteratorStateMachine] // 0x00000001801239F0-0x0000000180123A40
		private IEnumerator ActionWrapper<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 param1, T2 param2, T3 param3, T4 param4) => default;
	}
}
