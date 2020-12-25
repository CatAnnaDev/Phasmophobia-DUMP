/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	public sealed class ShaderVariantCollection : Object // TypeDefIndex: 3306
	{
		// Nested types
		public struct ShaderVariant // TypeDefIndex: 3307
		{
			// Fields
			public Shader shader; // 0x00
			public PassType passType; // 0x08
			public string[] keywords; // 0x10
	
			// Constructors
			public ShaderVariant(Shader shader, PassType passType, params /* 0x00000001800D4E50-0x00000001800D4E60 */ string[] keywords) {
				this.shader = default;
				this.passType = default;
				this.keywords = default;
			} // 0x0000000180035770-0x00000001800357E0
		}
	
		// Constructors
		public ShaderVariantCollection() {} // Dummy constructor
	
		// Methods
		// [NativeName] // 0x00000001801011F0-0x0000000180101220
		public void WarmUp() {} // 0x00000001808DB1F0-0x00000001808DB280
	}
}
