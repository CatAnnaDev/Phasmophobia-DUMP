/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 10: UnityEngine.TextRenderingModule.dll - Assembly: UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3692-3706

namespace UnityEngine
{
	// [NativeClass] // 0x00000001800D94F0-0x00000001800D95A0
	// [NativeHeader] // 0x00000001800D94F0-0x00000001800D95A0
	// [NativeHeader] // 0x00000001800D94F0-0x00000001800D95A0
	// [StaticAccessor] // 0x00000001800D94F0-0x00000001800D95A0
	public sealed class Font : Object // TypeDefIndex: 3705
	{
		// Properties
		public Material material { get => default; } // 0x0000000180AE7D70-0x0000000180AE7DB0 
		public bool dynamic { get => default; } // 0x0000000180AE7CF0-0x0000000180AE7D30 
		public int fontSize { get => default; } // 0x0000000180AE7D30-0x0000000180AE7D70 
	
		// Events
		public static event Action<Font> textureRebuilt;
	
		// Nested types
		public delegate void FontTextureRebuildCallback(); // TypeDefIndex: 3706; 0x00000001803DC3F0-0x00000001803DC600
	
		// Constructors
		public Font() {} // 0x0000000180AE7BC0-0x0000000180AE7C40
	
		// Methods
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void InvokeTextureRebuilt_Internal(Font font) {} // 0x0000000180AE7B50-0x0000000180AE7BC0
		public bool HasCharacter(char c) => default; // 0x0000000180AE7A70-0x0000000180AE7AC0
		private bool HasCharacter(int c) => default; // 0x0000000180AE7AC0-0x0000000180AE7B00
		private static void Internal_CreateFont([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Font self, string name) {} // 0x0000000180AE7B00-0x0000000180AE7B50
	}
}
