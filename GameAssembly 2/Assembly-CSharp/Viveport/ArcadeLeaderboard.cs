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
	public class ArcadeLeaderboard // TypeDefIndex: 7361
	{
		// Fields
		private static StatusCallback isReadyIl2cppCallback; // 0x00
		private static StatusCallback downloadLeaderboardScoresIl2cppCallback; // 0x08
		private static StatusCallback uploadLeaderboardScoreIl2cppCallback; // 0x10
	
		// Nested types
		public enum LeaderboardTimeRange // TypeDefIndex: 7362
		{
			AllTime = 0
		}
	
		// Constructors
		public ArcadeLeaderboard() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		// [MonoPInvokeCallback] // 0x0000000180126C10-0x0000000180126C60
		private static void IsReadyIl2cppCallback(int errorCode) {} // 0x0000000181B465C0-0x0000000181B46610
		public static void IsReady(StatusCallback callback) {} // 0x0000000181B46710-0x0000000181B469E0
		// [MonoPInvokeCallback] // 0x0000000180126D60-0x0000000180126DB0
		private static void DownloadLeaderboardScoresIl2cppCallback(int errorCode) {} // 0x0000000181B455F0-0x0000000181B45640
		public static void DownloadLeaderboardScores(StatusCallback callback, string pchLeaderboardName, LeaderboardTimeRange eLeaderboardDataTimeRange, int nCount) {} // 0x0000000181B457C0-0x0000000181B45AE0
		// [MonoPInvokeCallback] // 0x0000000180126E00-0x0000000180126E50
		private static void UploadLeaderboardScoreIl2cppCallback(int errorCode) {} // 0x0000000181B469E0-0x0000000181B46A30
		public static void UploadLeaderboardScore(StatusCallback callback, string pchLeaderboardName, string pchUserName, int nScore) {} // 0x0000000181B46BD0-0x0000000181B46F10
		public static Leaderboard GetLeaderboardScore(int index) => default; // 0x0000000181B45E10-0x0000000181B46080
		public static int GetLeaderboardScoreCount() => default; // 0x0000000181B45BC0-0x0000000181B45CF0
		public static int GetLeaderboardUserRank() => default; // 0x0000000181B46280-0x0000000181B463B0
		public static int GetLeaderboardUserScore() => default; // 0x0000000181B46490-0x0000000181B465C0
	}
}
