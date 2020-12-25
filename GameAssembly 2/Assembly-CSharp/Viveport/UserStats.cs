/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using Viveport.Internal;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport
{
	public class UserStats // TypeDefIndex: 7354
	{
		// Fields
		private static StatusCallback isReadyIl2cppCallback; // 0x00
		private static StatusCallback downloadStatsIl2cppCallback; // 0x08
		private static StatusCallback uploadStatsIl2cppCallback; // 0x10
		private static StatusCallback downloadLeaderboardScoresIl2cppCallback; // 0x18
		private static StatusCallback uploadLeaderboardScoreIl2cppCallback; // 0x20
	
		// Nested types
		public enum LeaderBoardRequestType // TypeDefIndex: 7355
		{
			GlobalData = 0,
			GlobalDataAroundUser = 1,
			LocalData = 2,
			LocalDataAroundUser = 3
		}
	
		public enum LeaderBoardTimeRange // TypeDefIndex: 7356
		{
			AllTime = 0,
			Daily = 1,
			Weekly = 2,
			Monthly = 3
		}
	
		public enum LeaderBoardSortMethod // TypeDefIndex: 7357
		{
			None = 0,
			Ascending = 1,
			Descending = 2
		}
	
		public enum LeaderBoardDiaplayType // TypeDefIndex: 7358
		{
			None = 0,
			Numeric = 1,
			TimeSeconds = 2,
			TimeMilliSeconds = 3
		}
	
		public enum LeaderBoardScoreMethod // TypeDefIndex: 7359
		{
			None = 0,
			KeepBest = 1,
			ForceUpdate = 2
		}
	
		public enum AchievementDisplayAttribute // TypeDefIndex: 7360
		{
			Name = 0,
			Desc = 1,
			Hidden = 2
		}
	
		// Constructors
		public UserStats() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		// [MonoPInvokeCallback] // 0x00000001801264F0-0x0000000180126540
		private static void IsReadyIl2cppCallback(int errorCode) {} // 0x0000000181B58FB0-0x0000000181B59000
		public static int IsReady(StatusCallback callback) => default; // 0x0000000181B59080-0x0000000181B59350
		// [MonoPInvokeCallback] // 0x00000001801265B0-0x0000000180126600
		private static void DownloadStatsIl2cppCallback(int errorCode) {} // 0x0000000181B57510-0x0000000181B57560
		public static int DownloadStats(StatusCallback callback) => default; // 0x0000000181B575E0-0x0000000181B578C0
		public static int GetStat(string name, int defaultValue) => default; // 0x0000000181B58E30-0x0000000181B58FB0
		public static float GetStat(string name, float defaultValue) => default; // 0x0000000181B58B70-0x0000000181B58CF0
		public static void SetStat(string name, int value) {} // 0x0000000181B598E0-0x0000000181B59A60
		public static void SetStat(string name, float value) {} // 0x0000000181B59A60-0x0000000181B59BE0
		// [MonoPInvokeCallback] // 0x0000000180126800-0x0000000180126850
		private static void UploadStatsIl2cppCallback(int errorCode) {} // 0x0000000181B5A0B0-0x0000000181B5A100
		public static int UploadStats(StatusCallback callback) => default; // 0x0000000181B5A180-0x0000000181B5A460
		public static bool GetAchievement(string pchName) => default; // 0x0000000181B57D30-0x0000000181B57EB0
		public static int GetAchievementUnlockTime(string pchName) => default; // 0x0000000181B57A70-0x0000000181B57BF0
		public static string GetAchievementIcon(string pchName) => default; // 0x0000000181B579A0-0x0000000181B579D0
		public static string GetAchievementDisplayAttribute(string pchName, AchievementDisplayAttribute attr) => default; // 0x0000000181B57970-0x0000000181B579A0
		public static string GetAchievementDisplayAttribute(string pchName, AchievementDisplayAttribute attr, Locale locale) => default; // 0x0000000181B57940-0x0000000181B57970
		public static int SetAchievement(string pchName) => default; // 0x0000000181B59460-0x0000000181B595D0
		public static int ClearAchievement(string pchName) => default; // 0x0000000181B56DA0-0x0000000181B56F10
		// [MonoPInvokeCallback] // 0x0000000180126900-0x0000000180126950
		private static void DownloadLeaderboardScoresIl2cppCallback(int errorCode) {} // 0x0000000181B56FA0-0x0000000181B56FF0
		public static int DownloadLeaderboardScores(StatusCallback callback, string pchLeaderboardName, LeaderBoardRequestType eLeaderboardDataRequest, LeaderBoardTimeRange eLeaderboardDataTimeRange, int nRangeStart, int nRangeEnd) => default; // 0x0000000181B571B0-0x0000000181B57510
		// [MonoPInvokeCallback] // 0x0000000180126AB0-0x0000000180126B00
		private static void UploadLeaderboardScoreIl2cppCallback(int errorCode) {} // 0x0000000181B59BE0-0x0000000181B59C30
		public static int UploadLeaderboardScore(StatusCallback callback, string pchLeaderboardName, int nScore) => default; // 0x0000000181B59CE0-0x0000000181B5A000
		public static Leaderboard GetLeaderboardScore(int index) => default; // 0x0000000181B585B0-0x0000000181B58820
		public static int GetLeaderboardScoreCount() => default; // 0x0000000181B58240-0x0000000181B58370
		public static LeaderBoardSortMethod GetLeaderboardSortMethod() => default; // 0x0000000181B58890-0x0000000181B589C0
		public static LeaderBoardDiaplayType GetLeaderboardDisplayType() => default; // 0x0000000181B57FC0-0x0000000181B580F0
	}
}
