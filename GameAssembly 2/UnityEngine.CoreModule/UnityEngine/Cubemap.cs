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
	[ExcludeFromPreset] // 0x00000001800DFDE0-0x00000001800DFE30
	// [NativeHeader] // 0x00000001800DFDE0-0x00000001800DFE30
	public sealed class Cubemap : Texture // TypeDefIndex: 3203
	{
		// Properties
		public override bool isReadable { get => default; } // 0x00000001809667D0-0x0000000180966810 
	
		// Constructors
		public Cubemap() {} // Dummy constructor
		public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags) {} // 0x00000001809663B0-0x00000001809664A0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags) {} // 0x0000000180966530-0x0000000180966610
		public Cubemap(int width, TextureFormat format, int mipCount) {} // 0x0000000180966340-0x00000001809663B0
		public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) {} // 0x0000000180966610-0x00000001809666C0
		internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) {} // 0x00000001809666C0-0x00000001809667D0
		internal Cubemap(int width, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) {} // 0x0000000180966300-0x0000000180966340
		public Cubemap(int width, TextureFormat textureFormat, bool mipChain) {} // 0x00000001809664A0-0x0000000180966530
	
		// Methods
		[FreeFunction] // 0x00000001800DFF80-0x00000001800DFFB0
		private static bool Internal_CreateImpl([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) => default; // 0x00000001809661D0-0x0000000180966230
		private static void Internal_Create([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, IntPtr nativeTex) {} // 0x0000000180966230-0x0000000180966300
	}
}
