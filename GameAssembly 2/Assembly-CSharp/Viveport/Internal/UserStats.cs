/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport.Internal
{
	internal class UserStats // TypeDefIndex: 7397
	{
		// Constructors
		static UserStats() {} // 0x0000000181B5A4E0-0x0000000181B5A530
		public UserStats() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		internal static extern int IsReady(StatusCallback IsReadyCallback); // 0x0000000181B59350-0x0000000181B593D0
		internal static extern int IsReady_64(StatusCallback IsReadyCallback); // 0x0000000181B59000-0x0000000181B59080
		internal static extern int DownloadStats(StatusCallback downloadStatsCallback); // 0x0000000181B578C0-0x0000000181B57940
		internal static extern int DownloadStats_64(StatusCallback downloadStatsCallback); // 0x0000000181B57560-0x0000000181B575E0
		internal static extern int GetStat(string pchName, ref int pnData); // 0x0000000181B58CF0-0x0000000181B58D90
		internal static extern int GetStat_64(string pchName, ref int pnData); // 0x0000000181B58A30-0x0000000181B58AD0
		internal static extern int GetStat(string pchName, ref float pfData); // 0x0000000181B58D90-0x0000000181B58E30
		internal static extern int GetStat_64(string pchName, ref float pfData); // 0x0000000181B58AD0-0x0000000181B58B70
		internal static extern int SetStat(string pchName, int nData); // 0x0000000181B597A0-0x0000000181B59840
		internal static extern int SetStat_64(string pchName, int nData); // 0x0000000181B59660-0x0000000181B59700
		internal static extern int SetStat(string pchName, float fData); // 0x0000000181B59840-0x0000000181B598E0
		internal static extern int SetStat_64(string pchName, float fData); // 0x0000000181B59700-0x0000000181B597A0
		internal static extern int UploadStats(StatusCallback uploadStatsCallback); // 0x0000000181B5A460-0x0000000181B5A4E0
		internal static extern int UploadStats_64(StatusCallback uploadStatsCallback); // 0x0000000181B5A100-0x0000000181B5A180
		internal static extern int GetAchievement(string pchName, ref int pbAchieved); // 0x0000000181B57EB0-0x0000000181B57F50
		internal static extern int GetAchievement_64(string pchName, ref int pbAchieved); // 0x0000000181B57C90-0x0000000181B57D30
		internal static extern int GetAchievementUnlockTime(string pchName, ref int punUnlockTime); // 0x0000000181B57BF0-0x0000000181B57C90
		internal static extern int GetAchievementUnlockTime_64(string pchName, ref int punUnlockTime); // 0x0000000181B579D0-0x0000000181B57A70
		internal static extern int SetAchievement(string pchName); // 0x0000000181B595D0-0x0000000181B59660
		internal static extern int SetAchievement_64(string pchName); // 0x0000000181B593D0-0x0000000181B59460
		internal static extern int ClearAchievement(string pchName); // 0x0000000181B56F10-0x0000000181B56FA0
		internal static extern int ClearAchievement_64(string pchName); // 0x0000000181B56D10-0x0000000181B56DA0
		internal static extern int DownloadLeaderboardScores(StatusCallback downloadLeaderboardScoresCB, string pchLeaderboardName, ELeaderboardDataRequest eLeaderboardDataRequest, ELeaderboardDataTimeRange eLeaderboardDataTimeRange, int nRangeStart, int nRangeEnd); // 0x0000000181B570D0-0x0000000181B571B0
		internal static extern int DownloadLeaderboardScores_64(StatusCallback downloadLeaderboardScoresCB, string pchLeaderboardName, ELeaderboardDataRequest eLeaderboardDataRequest, ELeaderboardDataTimeRange eLeaderboardDataTimeRange, int nRangeStart, int nRangeEnd); // 0x0000000181B56FF0-0x0000000181B570D0
		internal static extern int UploadLeaderboardScore(StatusCallback uploadLeaderboardScoreCB, string pchLeaderboardName, int nScore); // 0x0000000181B5A000-0x0000000181B5A0B0
		internal static extern int UploadLeaderboardScore_64(StatusCallback uploadLeaderboardScoreCB, string pchLeaderboardName, int nScore); // 0x0000000181B59C30-0x0000000181B59CE0
		internal static extern int GetLeaderboardScore(int index, ref LeaderboardEntry_t pLeaderboardEntry); // 0x0000000181B58490-0x0000000181B585B0
		internal static extern int GetLeaderboardScore_64(int index, ref LeaderboardEntry_t pLeaderboardEntry); // 0x0000000181B58370-0x0000000181B58490
		internal static extern int GetLeaderboardScoreCount(); // 0x0000000181B581D0-0x0000000181B58240
		internal static extern int GetLeaderboardScoreCount_64(); // 0x0000000181B58160-0x0000000181B581D0
		internal static extern ELeaderboardSortMethod GetLeaderboardSortMethod(); // 0x0000000181B589C0-0x0000000181B58A30
		internal static extern ELeaderboardSortMethod GetLeaderboardSortMethod_64(); // 0x0000000181B58820-0x0000000181B58890
		internal static extern ELeaderboardDisplayType GetLeaderboardDisplayType(); // 0x0000000181B580F0-0x0000000181B58160
		internal static extern ELeaderboardDisplayType GetLeaderboardDisplayType_64(); // 0x0000000181B57F50-0x0000000181B57FC0
	}
}
