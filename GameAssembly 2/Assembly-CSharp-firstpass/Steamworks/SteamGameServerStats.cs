/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameServerStats // TypeDefIndex: 6472
	{
		// Methods
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser) => default; // 0x0000000180798B50-0x0000000180798BF0
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData) {
			pData = default;
			return default;
		} // 0x00000001807988B0-0x0000000180798A00
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData) {
			pData = default;
			return default;
		} // 0x0000000180798A00-0x0000000180798B50
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved) {
			pbAchieved = default;
			return default;
		} // 0x0000000180798760-0x00000001807988B0
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData) => default; // 0x0000000180798E80-0x0000000180798FD0
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData) => default; // 0x0000000180798D30-0x0000000180798E80
		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength) => default; // 0x0000000180799070-0x00000001807991E0
		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName) => default; // 0x0000000180798BF0-0x0000000180798D30
		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName) => default; // 0x0000000180798620-0x0000000180798760
		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser) => default; // 0x0000000180798FD0-0x0000000180799070
	}
}
