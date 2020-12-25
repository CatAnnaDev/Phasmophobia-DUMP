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
	public class AutoMobileShaderSwitch : MonoBehaviour // TypeDefIndex: 5851
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private ReplacementList m_ReplacementList; // 0x18
	
		// Nested types
		[Serializable]
		public class ReplacementDefinition // TypeDefIndex: 5852
		{
			// Fields
			public Shader original; // 0x10
			public Shader replacement; // 0x18
	
			// Constructors
			public ReplacementDefinition() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		[Serializable]
		public class ReplacementList // TypeDefIndex: 5853
		{
			// Fields
			public ReplacementDefinition[] items; // 0x10
	
			// Constructors
			public ReplacementList() {} // 0x0000000180A44B50-0x0000000180A44BA0
		}
	
		// Constructors
		public AutoMobileShaderSwitch() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void OnEnable() {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
