/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800E2030-0x00000001800E2060
	public sealed class Texture2DArray : Texture // TypeDefIndex: 3205
	{
		// Properties
		public static int allSlices { /* [NativeName] */ /* 0x00000001800E2150-0x00000001800E2180 */ get => default; } // 0x00000001808DFEC0-0x00000001808DFEF0 
		public override bool isReadable { get => default; } // 0x00000001808DFEF0-0x00000001808DFF30 
	
		// Constructors
		public Texture2DArray() {} // Dummy constructor
		public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) {} // 0x00000001808DF900-0x00000001808DFA70
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) {} // 0x00000001808DFBC0-0x00000001808DFD10
		public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) {} // 0x00000001808DFDB0-0x00000001808DFEC0
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool linear) {} // 0x00000001808DFA70-0x00000001808DFBC0
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool linear) {} // 0x00000001808DFD60-0x00000001808DFDB0
		public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) {} // 0x00000001808DFD10-0x00000001808DFD60
	
		// Methods
		[FreeFunction] // 0x00000001800E21E0-0x00000001800E2210
		private static bool Internal_CreateImpl([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) => default; // 0x00000001808DF7D0-0x00000001808DF830
		private static void Internal_Create([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) {} // 0x00000001808DF830-0x00000001808DF900
	}
}
