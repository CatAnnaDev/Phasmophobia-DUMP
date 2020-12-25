/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Utility
{
	public class ActivateTrigger : MonoBehaviour // TypeDefIndex: 5849
	{
		// Fields
		public Mode action; // 0x18
		public UnityEngine.Object target; // 0x20
		public GameObject source; // 0x28
		public int triggerCount; // 0x30
		public bool repeatTrigger; // 0x34
	
		// Nested types
		public enum Mode // TypeDefIndex: 5850
		{
			Trigger = 0,
			Replace = 1,
			Activate = 2,
			Enable = 3,
			Animate = 4,
			Deactivate = 5
		}
	
		// Constructors
		public ActivateTrigger() {} // 0x0000000180A37480-0x0000000180A374A0
	
		// Methods
		private void DoActivateTrigger() {} // 0x0000000180A37080-0x0000000180A37470
		private void OnTriggerEnter(Collider other) {} // 0x0000000180A37470-0x0000000180A37480
	}
}
