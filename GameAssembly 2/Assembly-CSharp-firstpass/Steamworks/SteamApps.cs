/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamApps // TypeDefIndex: 6459
	{
		// Methods
		public static bool BIsSubscribed() => default; // 0x00000001809499E0-0x0000000180949A30
		public static bool BIsLowViolence() => default; // 0x00000001809498A0-0x00000001809498F0
		public static bool BIsCybercafe() => default; // 0x0000000180949800-0x0000000180949850
		public static bool BIsVACBanned() => default; // 0x0000000180949A30-0x0000000180949A80
		public static string GetCurrentGameLanguage() => default; // 0x0000000180949DD0-0x0000000180949E20
		public static string GetAvailableGameLanguages() => default; // 0x0000000180949C80-0x0000000180949CD0
		public static bool BIsSubscribedApp(AppId_t appID) => default; // 0x00000001809498F0-0x0000000180949940
		public static bool BIsDlcInstalled(AppId_t appID) => default; // 0x0000000180949850-0x00000001809498A0
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID) => default; // 0x0000000180949EF0-0x0000000180949F40
		public static bool BIsSubscribedFromFreeWeekend() => default; // 0x0000000180949990-0x00000001809499E0
		public static int GetDLCCount() => default; // 0x0000000180949E20-0x0000000180949E70
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize) {
			pAppID = default;
			pbAvailable = default;
			pchName = default;
			return default;
		} // 0x0000000180949670-0x00000001809497B0
		public static void InstallDLC(AppId_t nAppID) {} // 0x000000018094A350-0x000000018094A3A0
		public static void UninstallDLC(AppId_t nAppID) {} // 0x000000018094A490-0x000000018094A4E0
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID) {} // 0x000000018094A440-0x000000018094A490
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize) {
			pchName = default;
			return default;
		} // 0x0000000180949CD0-0x0000000180949DD0
		public static bool MarkContentCorrupt(bool bMissingFilesOnly) => default; // 0x000000018094A3A0-0x000000018094A3F0
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots) => default; // 0x000000018094A090-0x000000018094A110
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize) {
			pchFolder = default;
			return default;
		} // 0x0000000180949AD0-0x0000000180949BF0
		public static bool BIsAppInstalled(AppId_t appID) => default; // 0x00000001809497B0-0x0000000180949800
		public static CSteamID GetAppOwner() => default; // 0x0000000180949BF0-0x0000000180949C80
		public static string GetLaunchQueryParam(string pchKey) => default; // 0x000000018094A210-0x000000018094A350
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal) {
			punBytesDownloaded = default;
			punBytesTotal = default;
			return default;
		} // 0x0000000180949E70-0x0000000180949EF0
		public static int GetAppBuildId() => default; // 0x0000000180949A80-0x0000000180949AD0
		public static void RequestAllProofOfPurchaseKeys() {} // 0x000000018094A3F0-0x000000018094A440
		public static SteamAPICall_t GetFileDetails(string pszFileName) => default; // 0x0000000180949F40-0x000000018094A090
		public static int GetLaunchCommandLine(out string pszCommandLine, int cubCommandLine) {
			pszCommandLine = default;
			return default;
		} // 0x000000018094A110-0x000000018094A210
		public static bool BIsSubscribedFromFamilySharing() => default; // 0x0000000180949940-0x0000000180949990
	}
}
