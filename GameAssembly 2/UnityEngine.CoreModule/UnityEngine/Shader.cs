/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180147140-0x0000000180147250
	// [NativeHeader] // 0x0000000180147140-0x0000000180147250
	// [NativeHeader] // 0x0000000180147140-0x0000000180147250
	// [NativeHeader] // 0x0000000180147140-0x0000000180147250
	// [NativeHeader] // 0x0000000180147140-0x0000000180147250
	// [NativeHeader] // 0x0000000180147140-0x0000000180147250
	// [NativeHeader] // 0x0000000180147140-0x0000000180147250
	public sealed class Shader : Object // TypeDefIndex: 3157
	{
		// Properties
		public bool isSupported { [NativeMethod] /* 0x0000000180147740-0x0000000180147770 */ get => default; } // 0x00000001808DB650-0x00000001808DB690 
		public int renderQueue { [FreeFunction] /* 0x0000000180147A10-0x0000000180147A50 */ get => default; } // 0x00000001808DB690-0x00000001808DB6D0 
	
		// Constructors
		private Shader() {} // 0x00000001808DB5F0-0x00000001808DB650
	
		// Methods
		[FreeFunction] // 0x00000001801476A0-0x00000001801476D0
		public static Shader Find(string name) => default; // 0x00000001808DB300-0x00000001808DB340
		[FreeFunction] // 0x0000000180147830-0x0000000180147860
		public static void EnableKeyword(string keyword) {} // 0x00000001808DB2C0-0x00000001808DB300
		[FreeFunction] // 0x0000000180147920-0x0000000180147950
		public static void DisableKeyword(string keyword) {} // 0x00000001808DB280-0x00000001808DB2C0
		[FreeFunction] // 0x0000000180147AC0-0x0000000180147B00
		public static int PropertyToID(string name) => default; // 0x00000001808DB340-0x00000001808DB380
		[FreeFunction] // 0x0000000180147C20-0x0000000180147C50
		private static void SetGlobalFloatImpl(int name, float value) {} // 0x00000001808DB380-0x00000001808DB3D0
		[FreeFunction] // 0x0000000180147E30-0x0000000180147E60
		private static void SetGlobalVectorImpl(int name, Vector4 value) {} // 0x00000001808DB530-0x00000001808DB570
		[FreeFunction] // 0x0000000180147ED0-0x0000000180147F00
		private static void SetGlobalTextureImpl(int name, Texture value) {} // 0x00000001808DB440-0x00000001808DB480
		public static void SetGlobalFloat(string name, float value) {} // 0x00000001808DB3D0-0x00000001808DB440
		public static void SetGlobalFloat(int nameID, float value) {} // 0x00000001808DB380-0x00000001808DB3D0
		public static void SetGlobalVector(string name, Vector4 value) {} // 0x00000001808DB570-0x00000001808DB5F0
		public static void SetGlobalTexture(string name, Texture value) {} // 0x00000001808DB480-0x00000001808DB4F0
		private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) {} // 0x00000001808DB4F0-0x00000001808DB530
	}
}
