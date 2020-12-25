/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamFriends // TypeDefIndex: 6463
	{
		// Methods
		public static string GetPersonaName() => default; // 0x000000018094F740-0x000000018094F790
		public static SteamAPICall_t SetPersonaName(string pchPersonaName) => default; // 0x0000000180950260-0x00000001809503B0
		public static EPersonaState GetPersonaState() => default; // 0x000000018094F790-0x000000018094F7E0
		public static int GetFriendCount(EFriendFlags iFriendFlags) => default; // 0x000000018094EDE0-0x000000018094EE30
		public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags) => default; // 0x000000018094EC00-0x000000018094ECA0
		public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend) => default; // 0x000000018094F190-0x000000018094F1E0
		public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend) => default; // 0x000000018094F140-0x000000018094F190
		public static string GetFriendPersonaName(CSteamID steamIDFriend) => default; // 0x000000018094F0E0-0x000000018094F140
		public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo) {
			pFriendGameInfo = default;
			return default;
		} // 0x000000018094EEE0-0x000000018094EF40
		public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName) => default; // 0x000000018094F070-0x000000018094F0E0
		public static int GetFriendSteamLevel(CSteamID steamIDFriend) => default; // 0x000000018094F3E0-0x000000018094F430
		public static string GetPlayerNickname(CSteamID steamIDPlayer) => default; // 0x000000018094F7E0-0x000000018094F840
		public static int GetFriendsGroupCount() => default; // 0x000000018094F430-0x000000018094F480
		public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG) => default; // 0x000000018094F480-0x000000018094F520
		public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID) => default; // 0x000000018094F5F0-0x000000018094F650
		public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID) => default; // 0x000000018094F520-0x000000018094F570
		public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount) {} // 0x000000018094F570-0x000000018094F5F0
		public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags) => default; // 0x000000018094F8E0-0x000000018094F940
		public static int GetClanCount() => default; // 0x000000018094E7D0-0x000000018094E820
		public static CSteamID GetClanByIndex(int iClan) => default; // 0x000000018094E5A0-0x000000018094E640
		public static string GetClanName(CSteamID steamIDClan) => default; // 0x000000018094E820-0x000000018094E880
		public static string GetClanTag(CSteamID steamIDClan) => default; // 0x000000018094EA20-0x000000018094EA80
		public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting) {
			pnOnline = default;
			pnInGame = default;
			pnChatting = default;
			return default;
		} // 0x000000018094E510-0x000000018094E5A0
		public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest) => default; // 0x000000018094E330-0x000000018094E3D0
		public static int GetFriendCountFromSource(CSteamID steamIDSource) => default; // 0x000000018094ED90-0x000000018094EDE0
		public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend) => default; // 0x000000018094EE30-0x000000018094EEE0
		public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource) => default; // 0x000000018094FC60-0x000000018094FCC0
		public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking) {} // 0x00000001809501B0-0x0000000180950210
		public static void ActivateGameOverlay(string pchDialog) {} // 0x000000018094E180-0x000000018094E290
		public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID) {} // 0x000000018094DF40-0x000000018094E060
		public static void ActivateGameOverlayToWebPage(string pchURL, EActivateGameOverlayToWebPageMode eMode = EActivateGameOverlayToWebPageMode.k_EActivateGameOverlayToWebPageMode_Default /* Metadata: 0x00652CA2 */) {} // 0x000000018094E060-0x000000018094E180
		public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag) {} // 0x000000018094DEE0-0x000000018094DF40
		public static void SetPlayedWith(CSteamID steamIDUserPlayedWith) {} // 0x00000001809503B0-0x0000000180950400
		public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby) {} // 0x000000018094DE40-0x000000018094DE90
		public static int GetSmallFriendAvatar(CSteamID steamIDFriend) => default; // 0x000000018094F840-0x000000018094F890
		public static int GetMediumFriendAvatar(CSteamID steamIDFriend) => default; // 0x000000018094F6A0-0x000000018094F6F0
		public static int GetLargeFriendAvatar(CSteamID steamIDFriend) => default; // 0x000000018094F650-0x000000018094F6A0
		public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly) => default; // 0x0000000180950010-0x0000000180950070
		public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan) => default; // 0x000000018094FF30-0x000000018094FFC0
		public static CSteamID GetClanOwner(CSteamID steamIDClan) => default; // 0x000000018094E980-0x000000018094EA20
		public static int GetClanOfficerCount(CSteamID steamIDClan) => default; // 0x000000018094E930-0x000000018094E980
		public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer) => default; // 0x000000018094E880-0x000000018094E930
		public static uint GetUserRestrictions() => default; // 0x000000018094F890-0x000000018094F8E0
		public static bool SetRichPresence(string pchKey, string pchValue) => default; // 0x0000000180950400-0x00000001809505A0
		public static void ClearRichPresence() {} // 0x000000018094E290-0x000000018094E2E0
		public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey) => default; // 0x000000018094F2A0-0x000000018094F3E0
		public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend) => default; // 0x000000018094F250-0x000000018094F2A0
		public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey) => default; // 0x000000018094F1E0-0x000000018094F250
		public static void RequestFriendRichPresence(CSteamID steamIDFriend) {} // 0x000000018094FFC0-0x0000000180950010
		public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString) => default; // 0x000000018094F940-0x000000018094FA80
		public static int GetCoplayFriendCount() => default; // 0x000000018094EA80-0x000000018094EAD0
		public static CSteamID GetCoplayFriend(int iCoplayFriend) => default; // 0x000000018094EAD0-0x000000018094EB70
		public static int GetFriendCoplayTime(CSteamID steamIDFriend) => default; // 0x000000018094ED40-0x000000018094ED90
		public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend) => default; // 0x000000018094ECA0-0x000000018094ED40
		public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan) => default; // 0x000000018094FCC0-0x000000018094FD50
		public static bool LeaveClanChatRoom(CSteamID steamIDClan) => default; // 0x000000018094FD50-0x000000018094FDA0
		public static int GetClanChatMemberCount(CSteamID steamIDClan) => default; // 0x000000018094E640-0x000000018094E690
		public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser) => default; // 0x000000018094E460-0x000000018094E510
		public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText) => default; // 0x0000000180950070-0x00000001809501B0
		public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter) {
			prgchText = default;
			peChatEntryType = default;
			psteamidChatter = default;
			return default;
		} // 0x000000018094E690-0x000000018094E7D0
		public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser) => default; // 0x000000018094FA80-0x000000018094FAE0
		public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat) => default; // 0x000000018094FAE0-0x000000018094FB30
		public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat) => default; // 0x000000018094FDA0-0x000000018094FDF0
		public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat) => default; // 0x000000018094E2E0-0x000000018094E330
		public static bool SetListenForFriendsMessages(bool bInterceptEnabled) => default; // 0x0000000180950210-0x0000000180950260
		public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend) => default; // 0x000000018094FDF0-0x000000018094FF30
		public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType) {
			pvData = default;
			peChatEntryType = default;
			return default;
		} // 0x000000018094EF40-0x000000018094F070
		public static SteamAPICall_t GetFollowerCount(CSteamID steamID) => default; // 0x000000018094EB70-0x000000018094EC00
		public static SteamAPICall_t IsFollowing(CSteamID steamID) => default; // 0x000000018094FBD0-0x000000018094FC60
		public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex) => default; // 0x000000018094E3D0-0x000000018094E460
		public static bool IsClanPublic(CSteamID steamIDClan) => default; // 0x000000018094FB80-0x000000018094FBD0
		public static bool IsClanOfficialGameGroup(CSteamID steamIDClan) => default; // 0x000000018094FB30-0x000000018094FB80
		public static int GetNumChatsWithUnreadPriorityMessages() => default; // 0x000000018094F6F0-0x000000018094F740
		public static void ActivateGameOverlayRemotePlayTogetherInviteDialog(CSteamID steamIDLobby) {} // 0x000000018094DE90-0x000000018094DEE0
	}
}
