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
	public class PlatformSpecificContent : MonoBehaviour // TypeDefIndex: 5871
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private BuildTargetGroup m_BuildTargetGroup; // 0x18
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private GameObject[] m_Content; // 0x20
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private MonoBehaviour[] m_MonoBehaviours; // 0x28
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool m_ChildrenOfThisObject; // 0x30
	
		// Nested types
		private enum BuildTargetGroup // TypeDefIndex: 5872
		{
			Standalone = 0,
			Mobile = 1
		}
	
		// Constructors
		public PlatformSpecificContent() {} // 0x0000000180A42430-0x0000000180A424A0
	
		// Methods
		private void OnEnable() {} // 0x0000000180A41FB0-0x0000000180A41FD0
		private void CheckEnableContent() {} // 0x0000000180A41FB0-0x0000000180A41FD0
		private void EnableContent(bool enabled) {} // 0x0000000180A41FD0-0x0000000180A42430
	}
}
