/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamMatchmakingServers // TypeDefIndex: 6480
	{
		// Methods
		public static HServerListRequest RequestInternetServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) => default; // 0x00000001807A4940-0x00000001807A4A50
		public static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse) => default; // 0x00000001807A4A50-0x00000001807A4B10
		public static HServerListRequest RequestFriendsServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) => default; // 0x00000001807A4720-0x00000001807A4830
		public static HServerListRequest RequestFavoritesServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) => default; // 0x00000001807A4610-0x00000001807A4720
		public static HServerListRequest RequestHistoryServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) => default; // 0x00000001807A4830-0x00000001807A4940
		public static HServerListRequest RequestSpectatorServerList(AppId_t iApp, MatchMakingKeyValuePair_t[] ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse) => default; // 0x00000001807A4B10-0x00000001807A4C20
		public static void ReleaseRequest(HServerListRequest hServerListRequest) {} // 0x00000001807A45C0-0x00000001807A4610
		public static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) => default; // 0x00000001807A41F0-0x00000001807A4320
		public static void CancelQuery(HServerListRequest hRequest) {} // 0x00000001807A4100-0x00000001807A4150
		public static void RefreshQuery(HServerListRequest hRequest) {} // 0x00000001807A4510-0x00000001807A4560
		public static bool IsRefreshing(HServerListRequest hRequest) => default; // 0x00000001807A4320-0x00000001807A4370
		public static int GetServerCount(HServerListRequest hRequest) => default; // 0x00000001807A41A0-0x00000001807A41F0
		public static void RefreshServer(HServerListRequest hRequest, int iServer) {} // 0x00000001807A4560-0x00000001807A45C0
		public static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse) => default; // 0x00000001807A4370-0x00000001807A4440
		public static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse) => default; // 0x00000001807A4440-0x00000001807A4510
		public static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse) => default; // 0x00000001807A4C20-0x00000001807A4CF0
		public static void CancelServerQuery(HServerQuery hServerQuery) {} // 0x00000001807A4150-0x00000001807A41A0
	}
}
