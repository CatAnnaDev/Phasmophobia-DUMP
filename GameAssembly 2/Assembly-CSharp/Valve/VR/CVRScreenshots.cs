/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class CVRScreenshots // TypeDefIndex: 8222
	{
		// Fields
		private IVRScreenshots FnTable; // 0x10
	
		// Constructors
		public CVRScreenshots() {} // Dummy constructor
		internal CVRScreenshots(IntPtr pInterface) {} // 0x00000001811DFA10-0x00000001811DFB20
	
		// Methods
		public EVRScreenshotError RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename) => default; // 0x00000001811DF960-0x00000001811DF990
		public EVRScreenshotError HookScreenshot(EVRScreenshotType[] pSupportedTypes) => default; // 0x00000001811DF930-0x00000001811DF960
		public EVRScreenshotType GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError) => default; // 0x00000001811DF630-0x00000001811DF650
		public uint GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError) => default; // 0x00000001811DF900-0x00000001811DF930
		public EVRScreenshotError UpdateScreenshotProgress(uint screenshotHandle, float flProgress) => default; // 0x00000001811DF9F0-0x00000001811DFA10
		public EVRScreenshotError TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename) => default; // 0x00000001811DF9C0-0x00000001811DF9F0
		public EVRScreenshotError SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename) => default; // 0x00000001811DF990-0x00000001811DF9C0
	}
}
