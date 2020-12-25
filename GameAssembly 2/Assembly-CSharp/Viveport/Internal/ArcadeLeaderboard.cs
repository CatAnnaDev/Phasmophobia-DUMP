/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport.Internal
{
	internal class ArcadeLeaderboard // TypeDefIndex: 7394
	{
		// Constructors
		static ArcadeLeaderboard() {} // 0x0000000181B46F10-0x0000000181B46F60
		public ArcadeLeaderboard() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		internal static extern void IsReady(StatusCallback IsReadyCallback); // 0x0000000181B46690-0x0000000181B46710
		internal static extern void IsReady_64(StatusCallback IsReadyCallback); // 0x0000000181B46610-0x0000000181B46690
		internal static extern void DownloadLeaderboardScores(StatusCallback downloadLeaderboardScoresCB, string pchLeaderboardName, ELeaderboardDataTimeRange eLeaderboardDataTimeRange, int nCount); // 0x0000000181B45700-0x0000000181B457C0
		internal static extern void DownloadLeaderboardScores_64(StatusCallback downloadLeaderboardScoresCB, string pchLeaderboardName, ELeaderboardDataTimeRange eLeaderboardDataTimeRange, int nCount); // 0x0000000181B45640-0x0000000181B45700
		internal static extern void UploadLeaderboardScore(StatusCallback uploadLeaderboardScoreCB, string pchLeaderboardName, string pchUserName, int nScore); // 0x0000000181B46B00-0x0000000181B46BD0
		internal static extern void UploadLeaderboardScore_64(StatusCallback uploadLeaderboardScoreCB, string pchLeaderboardName, string pchUserName, int nScore); // 0x0000000181B46A30-0x0000000181B46B00
		internal static extern void GetLeaderboardScore(int index, ref LeaderboardEntry_t pLeaderboardEntry); // 0x0000000181B46080-0x0000000181B461A0
		internal static extern void GetLeaderboardScore_64(int index, ref LeaderboardEntry_t pLeaderboardEntry); // 0x0000000181B45CF0-0x0000000181B45E10
		internal static extern int GetLeaderboardScoreCount(); // 0x0000000181B45B50-0x0000000181B45BC0
		internal static extern int GetLeaderboardScoreCount_64(); // 0x0000000181B45AE0-0x0000000181B45B50
		internal static extern int GetLeaderboardUserRank(); // 0x0000000181B46210-0x0000000181B46280
		internal static extern int GetLeaderboardUserRank_64(); // 0x0000000181B461A0-0x0000000181B46210
		internal static extern int GetLeaderboardUserScore(); // 0x0000000181B46420-0x0000000181B46490
		internal static extern int GetLeaderboardUserScore_64(); // 0x0000000181B463B0-0x0000000181B46420
	}
}
