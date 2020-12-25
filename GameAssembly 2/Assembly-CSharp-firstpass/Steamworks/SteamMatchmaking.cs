/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamMatchmaking // TypeDefIndex: 6479
	{
		// Methods
		public static int GetFavoriteGameCount() => default; // 0x00000001807A54B0-0x00000001807A5500
		public static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) {
			pnAppID = default;
			pnIP = default;
			pnConnPort = default;
			pnQueryPort = default;
			punFlags = default;
			pRTime32LastPlayedOnServer = default;
			return default;
		} // 0x00000001807A5500-0x00000001807A55B0
		public static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) => default; // 0x00000001807A4CF0-0x00000001807A4D90
		public static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) => default; // 0x00000001807A5F40-0x00000001807A5FD0
		public static SteamAPICall_t RequestLobbyList() => default; // 0x00000001807A6020-0x00000001807A60B0
		public static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType) {} // 0x00000001807A5130-0x00000001807A52D0
		public static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType) {} // 0x00000001807A4FA0-0x00000001807A50E0
		public static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo) {} // 0x00000001807A4E80-0x00000001807A4FA0
		public static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable) {} // 0x00000001807A4E30-0x00000001807A4E80
		public static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter) {} // 0x00000001807A4DE0-0x00000001807A4E30
		public static void AddRequestLobbyListResultCountFilter(int cMaxResults) {} // 0x00000001807A50E0-0x00000001807A5130
		public static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby) {} // 0x00000001807A4D90-0x00000001807A4DE0
		public static CSteamID GetLobbyByIndex(int iLobby) => default; // 0x00000001807A55B0-0x00000001807A5650
		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers) => default; // 0x00000001807A52D0-0x00000001807A5370
		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby) => default; // 0x00000001807A5E50-0x00000001807A5EF0
		public static void LeaveLobby(CSteamID steamIDLobby) {} // 0x00000001807A5EF0-0x00000001807A5F40
		public static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee) => default; // 0x00000001807A5DF0-0x00000001807A5E50
		public static int GetNumLobbyMembers(CSteamID steamIDLobby) => default; // 0x00000001807A5DA0-0x00000001807A5DF0
		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember) => default; // 0x00000001807A5AB0-0x00000001807A5B60
		public static string GetLobbyData(CSteamID steamIDLobby, string pchKey) => default; // 0x00000001807A58E0-0x00000001807A5A20
		public static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue) => default; // 0x00000001807A6190-0x00000001807A6350
		public static int GetLobbyDataCount(CSteamID steamIDLobby) => default; // 0x00000001807A5890-0x00000001807A58E0
		public static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize) {
			pchKey = default;
			pchValue = default;
			return default;
		} // 0x00000001807A56F0-0x00000001807A5890
		public static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey) => default; // 0x00000001807A5370-0x00000001807A54B0
		public static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey) => default; // 0x00000001807A5B60-0x00000001807A5CB0
		public static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue) {} // 0x00000001807A6440-0x00000001807A65E0
		public static bool SendLobbyChatMsg(CSteamID steamIDLobby, byte[] pvMsgBody, int cubMsgBody) => default; // 0x00000001807A60B0-0x00000001807A6130
		public static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, byte[] pvData, int cubData, out EChatEntryType peChatEntryType) {
			pSteamIDUser = default;
			peChatEntryType = default;
			return default;
		} // 0x00000001807A5650-0x00000001807A56F0
		public static bool RequestLobbyData(CSteamID steamIDLobby) => default; // 0x00000001807A5FD0-0x00000001807A6020
		public static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer) {} // 0x00000001807A6350-0x00000001807A63E0
		public static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer) {
			punGameServerIP = default;
			punGameServerPort = default;
			psteamIDGameServer = default;
			return default;
		} // 0x00000001807A5A20-0x00000001807A5AB0
		public static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers) => default; // 0x00000001807A65E0-0x00000001807A6640
		public static int GetLobbyMemberLimit(CSteamID steamIDLobby) => default; // 0x00000001807A5CB0-0x00000001807A5D00
		public static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType) => default; // 0x00000001807A66A0-0x00000001807A6700
		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable) => default; // 0x00000001807A63E0-0x00000001807A6440
		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby) => default; // 0x00000001807A5D00-0x00000001807A5DA0
		public static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner) => default; // 0x00000001807A6640-0x00000001807A66A0
		public static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent) => default; // 0x00000001807A6130-0x00000001807A6190
	}
}
