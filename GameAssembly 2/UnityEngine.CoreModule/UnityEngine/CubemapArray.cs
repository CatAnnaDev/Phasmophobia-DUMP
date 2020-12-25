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
	// [NativeHeader] // 0x00000001800E2720-0x00000001800E2750
	public sealed class CubemapArray : Texture // TypeDefIndex: 3206
	{
		// Properties
		public override bool isReadable { get => default; } // 0x0000000180966190-0x00000001809661D0 
	
		// Constructors
		public CubemapArray() {} // Dummy constructor
		public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) {} // 0x0000000180965F30-0x0000000180966040
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) {} // 0x0000000180965E20-0x0000000180965F30
		public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) {} // 0x0000000180966040-0x0000000180966100
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool linear) {} // 0x0000000180965D00-0x0000000180965E20
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool linear) {} // 0x0000000180966140-0x0000000180966190
		public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) {} // 0x0000000180966100-0x0000000180966140
	
		// Methods
		[FreeFunction] // 0x00000001800E2830-0x00000001800E2860
		private static bool Internal_CreateImpl([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) => default; // 0x0000000180965BE0-0x0000000180965C40
		private static void Internal_Create([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureCreationFlags flags) {} // 0x0000000180965C40-0x0000000180965D00
	}
}
