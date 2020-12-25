/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public struct IVRExtendedDisplay // TypeDefIndex: 7950
	{
		// Fields
		internal _GetWindowBounds GetWindowBounds; // 0x00
		internal _GetEyeOutputViewport GetEyeOutputViewport; // 0x08
		internal _GetDXGIOutputInfo GetDXGIOutputInfo; // 0x10
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 7951; 0x000000018047D8F0-0x000000018047DC40
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 7952; 0x0000000181E66D60-0x0000000181E67130
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex); // TypeDefIndex: 7953; 0x000000018047CEC0-0x000000018047D1A0
	}
}
