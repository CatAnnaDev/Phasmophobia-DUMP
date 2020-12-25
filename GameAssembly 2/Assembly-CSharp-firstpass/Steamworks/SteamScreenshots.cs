/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamScreenshots // TypeDefIndex: 6491
	{
		// Methods
		public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight) => default; // 0x00000001808374C0-0x0000000180837590
		public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight) => default; // 0x0000000180836DE0-0x0000000180836FE0
		public static void TriggerScreenshot() {} // 0x0000000180837470-0x00000001808374C0
		public static void HookScreenshots(bool bHook) {} // 0x00000001808371D0-0x0000000180837220
		public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation) => default; // 0x0000000180837270-0x00000001808373B0
		public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID) => default; // 0x0000000180837410-0x0000000180837470
		public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID) => default; // 0x00000001808373B0-0x0000000180837410
		public static bool IsScreenshotsHooked() => default; // 0x0000000180837220-0x0000000180837270
		public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename) => default; // 0x0000000180836FE0-0x00000001808371D0
	}
}
