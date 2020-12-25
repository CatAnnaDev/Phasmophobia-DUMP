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
	public class TimedObjectActivator : MonoBehaviour // TypeDefIndex: 5875
	{
		// Fields
		public Entries entries; // 0x18
	
		// Nested types
		public enum Action // TypeDefIndex: 5876
		{
			Activate = 0,
			Deactivate = 1,
			Destroy = 2,
			ReloadLevel = 3,
			Call = 4
		}
	
		[Serializable]
		public class Entry // TypeDefIndex: 5877
		{
			// Fields
			public GameObject target; // 0x10
			public Action action; // 0x18
			public float delay; // 0x1C
	
			// Constructors
			public Entry() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		[Serializable]
		public class Entries // TypeDefIndex: 5878
		{
			// Fields
			public Entry[] entries; // 0x10
	
			// Constructors
			public Entries() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public TimedObjectActivator() {} // 0x0000000180A47E20-0x0000000180A47E90
	
		// Methods
		private void Awake() {} // 0x0000000180A47C00-0x0000000180A47D40
		// [IteratorStateMachine] // 0x00000001800F68C0-0x00000001800F6910
		private IEnumerator Activate(Entry entry) => default; // 0x0000000180A47B90-0x0000000180A47C00
		// [IteratorStateMachine] // 0x00000001800F6A00-0x00000001800F6A50
		private IEnumerator Deactivate(Entry entry) => default; // 0x0000000180A47D40-0x0000000180A47DB0
		// [IteratorStateMachine] // 0x00000001800F6A80-0x00000001800F6AD0
		private IEnumerator ReloadLevel(Entry entry) => default; // 0x0000000180A47DB0-0x0000000180A47E20
	}
}
