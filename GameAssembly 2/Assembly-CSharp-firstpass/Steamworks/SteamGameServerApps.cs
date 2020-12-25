/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameServerApps // TypeDefIndex: 6465
	{
		// Methods
		public static bool BIsSubscribed() => default; // 0x0000000180951250-0x00000001809512A0
		public static bool BIsLowViolence() => default; // 0x0000000180951110-0x0000000180951160
		public static bool BIsCybercafe() => default; // 0x0000000180951070-0x00000001809510C0
		public static bool BIsVACBanned() => default; // 0x00000001809512A0-0x00000001809512F0
		public static string GetCurrentGameLanguage() => default; // 0x0000000180951640-0x0000000180951690
		public static string GetAvailableGameLanguages() => default; // 0x00000001809514F0-0x0000000180951540
		public static bool BIsSubscribedApp(AppId_t appID) => default; // 0x0000000180951160-0x00000001809511B0
		public static bool BIsDlcInstalled(AppId_t appID) => default; // 0x00000001809510C0-0x0000000180951110
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID) => default; // 0x0000000180951760-0x00000001809517B0
		public static bool BIsSubscribedFromFreeWeekend() => default; // 0x0000000180951200-0x0000000180951250
		public static int GetDLCCount() => default; // 0x0000000180951690-0x00000001809516E0
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize) {
			pAppID = default;
			pbAvailable = default;
			pchName = default;
			return default;
		} // 0x0000000180950EE0-0x0000000180951020
		public static void InstallDLC(AppId_t nAppID) {} // 0x0000000180951BC0-0x0000000180951C10
		public static void UninstallDLC(AppId_t nAppID) {} // 0x0000000180951D00-0x0000000180951D50
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID) {} // 0x0000000180951CB0-0x0000000180951D00
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize) {
			pchName = default;
			return default;
		} // 0x0000000180951540-0x0000000180951640
		public static bool MarkContentCorrupt(bool bMissingFilesOnly) => default; // 0x0000000180951C10-0x0000000180951C60
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots) => default; // 0x0000000180951900-0x0000000180951980
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize) {
			pchFolder = default;
			return default;
		} // 0x0000000180951340-0x0000000180951460
		public static bool BIsAppInstalled(AppId_t appID) => default; // 0x0000000180951020-0x0000000180951070
		public static CSteamID GetAppOwner() => default; // 0x0000000180951460-0x00000001809514F0
		public static string GetLaunchQueryParam(string pchKey) => default; // 0x0000000180951A80-0x0000000180951BC0
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal) {
			punBytesDownloaded = default;
			punBytesTotal = default;
			return default;
		} // 0x00000001809516E0-0x0000000180951760
		public static int GetAppBuildId() => default; // 0x00000001809512F0-0x0000000180951340
		public static void RequestAllProofOfPurchaseKeys() {} // 0x0000000180951C60-0x0000000180951CB0
		public static SteamAPICall_t GetFileDetails(string pszFileName) => default; // 0x00000001809517B0-0x0000000180951900
		public static int GetLaunchCommandLine(out string pszCommandLine, int cubCommandLine) {
			pszCommandLine = default;
			return default;
		} // 0x0000000180951980-0x0000000180951A80
		public static bool BIsSubscribedFromFamilySharing() => default; // 0x00000001809511B0-0x0000000180951200
	}
}
