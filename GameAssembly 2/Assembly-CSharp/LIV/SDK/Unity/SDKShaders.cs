/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace LIV.SDK.Unity
{
	internal static class SDKShaders // TypeDefIndex: 8576
	{
		// Fields
		public static readonly int LIV_TESSELLATION_PROPERTY; // 0x00
		public static readonly int LIV_CLIP_PLANE_HEIGHT_MAP_PROPERTY; // 0x04
		public const string LIV_MR_FOREGROUND_KEYWORD = "LIV_MR_FOREGROUND"; // Metadata: 0x00655B71
		public const string LIV_MR_BACKGROUND_KEYWORD = "LIV_MR_BACKGROUND"; // Metadata: 0x00655B86
		public const string LIV_MR_KEYWORD = "LIV_MR"; // Metadata: 0x00655B9B
		public const string LIV_CLIP_PLANE_SIMPLE_SHADER = "Hidden/LIV_ClipPlaneSimple"; // Metadata: 0x00655BA5
		public const string LIV_CLIP_PLANE_SIMPLE_DEBUG_SHADER = "Hidden/LIV_ClipPlaneSimpleDebug"; // Metadata: 0x00655BC3
		public const string LIV_CLIP_PLANE_COMPLEX_SHADER = "Hidden/LIV_ClipPlaneComplex"; // Metadata: 0x00655BE6
		public const string LIV_CLIP_PLANE_COMPLEX_DEBUG_SHADER = "Hidden/LIV_ClipPlaneComplexDebug"; // Metadata: 0x00655C05
		public const string LIV_CLIP_PLANE_FIX_ALPHA_SHADER = "Hidden/LIV_ClipPlaneFixAlpha"; // Metadata: 0x00655C29
		public const string LIV_ADD_ALPHA_SHADER = "Hidden/LIV_AddAlpha"; // Metadata: 0x00655C49
		public const string LIV_WRITE_ALPHA_SHADER = "Hidden/LIV_WriteAlpha"; // Metadata: 0x00655C60
		public const string LIV_FORCE_FORWARD_RENDERING_SHADER = "Hidden/LIV_ForceForwardRendering"; // Metadata: 0x00655C79
	
		// Constructors
		static SDKShaders() {} // 0x000000018113B440-0x000000018113B990
	
		// Methods
		public static void StartRendering() {} // 0x000000018113B340-0x000000018113B380
		public static void StopRendering() {} // 0x000000018113B400-0x000000018113B440
		public static void StartForegroundRendering() {} // 0x000000018113B300-0x000000018113B340
		public static void StopForegroundRendering() {} // 0x000000018113B3C0-0x000000018113B400
		public static void StartBackgroundRendering() {} // 0x000000018113B2C0-0x000000018113B300
		public static void StopBackgroundRendering() {} // 0x000000018113B380-0x000000018113B3C0
	}
}
