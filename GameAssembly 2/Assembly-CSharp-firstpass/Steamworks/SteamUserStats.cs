/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamUserStats // TypeDefIndex: 6494
	{
		// Methods
		public static bool RequestCurrentStats() => default; // 0x000000018083D5E0-0x000000018083D630
		public static bool GetStat(string pchName, out int pData) {
			pData = default;
			return default;
		} // 0x000000018083CCC0-0x000000018083CE00
		public static bool GetStat(string pchName, out float pData) {
			pData = default;
			return default;
		} // 0x000000018083CE00-0x000000018083CF40
		public static bool SetStat(string pchName, int nData) => default; // 0x000000018083DAD0-0x000000018083DC10
		public static bool SetStat(string pchName, float fData) => default; // 0x000000018083D980-0x000000018083DAD0
		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength) => default; // 0x000000018083DC60-0x000000018083DDD0
		public static bool GetAchievement(string pchName, out bool pbAchieved) {
			pbAchieved = default;
			return default;
		} // 0x000000018083C150-0x000000018083C290
		public static bool SetAchievement(string pchName) => default; // 0x000000018083D850-0x000000018083D980
		public static bool ClearAchievement(string pchName) => default; // 0x000000018083B5F0-0x000000018083B720
		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime) {
			pbAchieved = default;
			punUnlockTime = default;
			return default;
		} // 0x000000018083BCC0-0x000000018083BE10
		public static bool StoreStats() => default; // 0x000000018083DC10-0x000000018083DC60
		public static int GetAchievementIcon(string pchName) => default; // 0x000000018083BFC0-0x000000018083C0F0
		public static string GetAchievementDisplayAttribute(string pchName, string pchKey) => default; // 0x000000018083BE10-0x000000018083BFC0
		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress) => default; // 0x000000018083D490-0x000000018083D5E0
		public static uint GetNumAchievements() => default; // 0x000000018083CBE0-0x000000018083CC30
		public static string GetAchievementName(uint iAchievement) => default; // 0x000000018083C0F0-0x000000018083C150
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) => default; // 0x000000018083D760-0x000000018083D800
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) {
			pData = default;
			return default;
		} // 0x000000018083D340-0x000000018083D490
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) {
			pData = default;
			return default;
		} // 0x000000018083D1F0-0x000000018083D340
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) {
			pbAchieved = default;
			return default;
		} // 0x000000018083D0A0-0x000000018083D1F0
		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime) {
			pbAchieved = default;
			punUnlockTime = default;
			return default;
		} // 0x000000018083CF40-0x000000018083D0A0
		public static bool ResetAllStats(bool bAchievementsToo) => default; // 0x000000018083D800-0x000000018083D850
		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType) => default; // 0x000000018083BA10-0x000000018083BB80
		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName) => default; // 0x000000018083B8B0-0x000000018083BA10
		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard) => default; // 0x000000018083C8E0-0x000000018083C940
		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard) => default; // 0x000000018083C890-0x000000018083C8E0
		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard) => default; // 0x000000018083C940-0x000000018083C990
		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard) => default; // 0x000000018083C840-0x000000018083C890
		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) => default; // 0x000000018083B7E0-0x000000018083B8B0
		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers) => default; // 0x000000018083B720-0x000000018083B7E0
		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax) {
			pLeaderboardEntry = default;
			return default;
		} // 0x000000018083C290-0x000000018083C320
		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount) => default; // 0x000000018083DDD0-0x000000018083DEB0
		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC) => default; // 0x000000018083B540-0x000000018083B5F0
		public static SteamAPICall_t GetNumberOfCurrentPlayers() => default; // 0x000000018083CC30-0x000000018083CCC0
		public static SteamAPICall_t RequestGlobalAchievementPercentages() => default; // 0x000000018083D630-0x000000018083D6C0
		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) {
			pchName = default;
			pflPercent = default;
			pbAchieved = default;
			return default;
		} // 0x000000018083C990-0x000000018083CAB0
		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) {
			pchName = default;
			pflPercent = default;
			pbAchieved = default;
			return default;
		} // 0x000000018083CAB0-0x000000018083CBE0
		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent) {
			pflPercent = default;
			return default;
		} // 0x000000018083BB80-0x000000018083BCC0
		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays) => default; // 0x000000018083D6C0-0x000000018083D760
		public static bool GetGlobalStat(string pchStatName, out long pData) {
			pData = default;
			return default;
		} // 0x000000018083C700-0x000000018083C840
		public static bool GetGlobalStat(string pchStatName, out double pData) {
			pData = default;
			return default;
		} // 0x000000018083C5C0-0x000000018083C700
		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData) => default; // 0x000000018083C470-0x000000018083C5C0
		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData) => default; // 0x000000018083C320-0x000000018083C470
	}
}
