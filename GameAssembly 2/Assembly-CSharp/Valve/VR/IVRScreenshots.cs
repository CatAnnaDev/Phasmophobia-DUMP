/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public struct IVRScreenshots // TypeDefIndex: 8187
	{
		// Fields
		internal _RequestScreenshot RequestScreenshot; // 0x00
		internal _HookScreenshot HookScreenshot; // 0x08
		internal _GetScreenshotPropertyType GetScreenshotPropertyType; // 0x10
		internal _GetScreenshotPropertyFilename GetScreenshotPropertyFilename; // 0x18
		internal _UpdateScreenshotProgress UpdateScreenshotProgress; // 0x20
		internal _TakeStereoScreenshot TakeStereoScreenshot; // 0x28
		internal _SubmitScreenshot SubmitScreenshot; // 0x30
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRScreenshotError _RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename); // TypeDefIndex: 8188; 0x0000000181F400D0-0x0000000181F40440
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRScreenshotError _HookScreenshot([In, Out] EVRScreenshotType[] pSupportedTypes, int numTypes); // TypeDefIndex: 8189; 0x0000000181E67270-0x0000000181E67560
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRScreenshotType _GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError); // TypeDefIndex: 8190; 0x00000001811ED1B0-0x00000001811ED4D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError); // TypeDefIndex: 8191; 0x0000000181F3C870-0x0000000181F3CAF0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRScreenshotError _UpdateScreenshotProgress(uint screenshotHandle, float flProgress); // TypeDefIndex: 8192; 0x0000000181F44750-0x0000000181F44A70
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRScreenshotError _TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename); // TypeDefIndex: 8193; 0x0000000181F43F80-0x0000000181F442A0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRScreenshotError _SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename); // TypeDefIndex: 8194; 0x0000000181F37770-0x0000000181F37B00
	}
}
