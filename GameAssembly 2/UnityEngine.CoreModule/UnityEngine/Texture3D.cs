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
	[ExcludeFromPreset] // 0x00000001800E03B0-0x00000001800E0400
	// [NativeHeader] // 0x00000001800E03B0-0x00000001800E0400
	public sealed class Texture3D : Texture // TypeDefIndex: 3204
	{
		// Properties
		public int depth { /* [NativeName] */ /* 0x00000001800E1850-0x00000001800E1880 */ get => default; } // 0x00000001808E1E20-0x00000001808E1E60 
		public override bool isReadable { get => default; } // 0x00000001808E1E60-0x00000001808E1EA0 
	
		// Constructors
		public Texture3D() {} // Dummy constructor
		public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) {} // 0x00000001808E1A40-0x00000001808E1BB0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) {} // 0x00000001808E17B0-0x00000001808E1900
		public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) {} // 0x00000001808E1D10-0x00000001808E1E20
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount) {} // 0x00000001808E1900-0x00000001808E1A40
		public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) {} // 0x00000001808E1BB0-0x00000001808E1D10
	
		// Methods
		[FreeFunction] // 0x00000001800E1960-0x00000001800E1990
		private static bool Internal_CreateImpl([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) => default; // 0x00000001808E15D0-0x00000001808E1630
		private static void Internal_Create([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) {} // 0x00000001808E1630-0x00000001808E1700
		[FreeFunction] // 0x00000001800E1C80-0x00000001800E1CC0
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) {} // 0x00000001808E1430-0x00000001808E1490
		[FreeFunction] // 0x00000001800E1D40-0x00000001800E1D80
		public void SetPixels(Color[] colors, int miplevel) {} // 0x00000001808E1700-0x00000001808E1760
		public void SetPixels(Color[] colors) {} // 0x00000001808E1760-0x00000001808E17B0
		public void Apply([DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool updateMipmaps, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool makeNoLongerReadable) {} // 0x00000001808E1490-0x00000001808E1540
		public void Apply() {} // 0x00000001808E1540-0x00000001808E15D0
	}
}
