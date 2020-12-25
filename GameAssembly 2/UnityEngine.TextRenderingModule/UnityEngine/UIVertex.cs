/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 10: UnityEngine.TextRenderingModule.dll - Assembly: UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3692-3706

namespace UnityEngine
{
	[UsedByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
	public struct UIVertex // TypeDefIndex: 3704
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector3 normal; // 0x0C
		public Vector4 tangent; // 0x18
		public Color32 color; // 0x28
		public Vector2 uv0; // 0x2C
		public Vector2 uv1; // 0x34
		public Vector2 uv2; // 0x3C
		public Vector2 uv3; // 0x44
		private static readonly Color32 s_DefaultColor; // 0x00
		private static readonly Vector4 s_DefaultTangent; // 0x04
		public static UIVertex simpleVert; // 0x14
	
		// Constructors
		static UIVertex() {
			s_DefaultColor = default;
			s_DefaultTangent = default;
			simpleVert = default;
		} // 0x0000000180AE9F30-0x0000000180AEA170
	}
}
