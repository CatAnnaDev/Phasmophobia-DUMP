/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameServer // TypeDefIndex: 6464
	{
		// Methods
		public static void SetProduct(string pszProduct) {} // 0x000000018095B150-0x000000018095B260
		public static void SetGameDescription(string pszGameDescription) {} // 0x000000018095AA90-0x000000018095ABA0
		public static void SetModDir(string pszModDir) {} // 0x000000018095AFF0-0x000000018095B100
		public static void SetDedicatedServer(bool bDedicated) {} // 0x000000018095A930-0x000000018095A980
		public static void LogOn(string pszToken) {} // 0x000000018095A690-0x000000018095A7A0
		public static void LogOnAnonymous() {} // 0x000000018095A640-0x000000018095A690
		public static void LogOff() {} // 0x000000018095A5F0-0x000000018095A640
		public static bool BLoggedOn() => default; // 0x0000000180959D20-0x0000000180959D70
		public static bool BSecure() => default; // 0x0000000180959D70-0x0000000180959DC0
		public static CSteamID GetSteamID() => default; // 0x000000018095A4D0-0x000000018095A560
		public static bool WasRestartRequested() => default; // 0x000000018095B640-0x000000018095B690
		public static void SetMaxPlayerCount(int cPlayersMax) {} // 0x000000018095AFA0-0x000000018095AFF0
		public static void SetBotPlayerCount(int cBotplayers) {} // 0x000000018095A8E0-0x000000018095A930
		public static void SetServerName(string pszServerName) {} // 0x000000018095B370-0x000000018095B480
		public static void SetMapName(string pszMapName) {} // 0x000000018095AE90-0x000000018095AFA0
		public static void SetPasswordProtected(bool bPasswordProtected) {} // 0x000000018095B100-0x000000018095B150
		public static void SetSpectatorPort(ushort unSpectatorPort) {} // 0x000000018095B480-0x000000018095B4D0
		public static void SetSpectatorServerName(string pszSpectatorServerName) {} // 0x000000018095B4D0-0x000000018095B5E0
		public static void ClearAllKeyValues() {} // 0x0000000180959FE0-0x000000018095A030
		public static void SetKeyValue(string pKey, string pValue) {} // 0x000000018095AD00-0x000000018095AE90
		public static void SetGameTags(string pchGameTags) {} // 0x000000018095ABA0-0x000000018095ACB0
		public static void SetGameData(string pchGameData) {} // 0x000000018095A980-0x000000018095AA90
		public static void SetRegion(string pszRegion) {} // 0x000000018095B260-0x000000018095B370
		public static bool SendUserConnectAndAuthenticate(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser) {
			pSteamIDUser = default;
			return default;
		} // 0x000000018095A800-0x000000018095A890
		public static CSteamID CreateUnauthenticatedUserConnection() => default; // 0x000000018095A0C0-0x000000018095A150
		public static void SendUserDisconnect(CSteamID steamIDUser) {} // 0x000000018095A890-0x000000018095A8E0
		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore) => default; // 0x0000000180959DC0-0x0000000180959F10
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket) {
			pcbTicket = default;
			return default;
		} // 0x000000018095A240-0x000000018095A300
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) => default; // 0x0000000180959F10-0x0000000180959F90
		public static void EndAuthSession(CSteamID steamID) {} // 0x000000018095A1A0-0x000000018095A1F0
		public static void CancelAuthTicket(HAuthTicket hAuthTicket) {} // 0x0000000180959F90-0x0000000180959FE0
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) => default; // 0x000000018095B5E0-0x000000018095B640
		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup) => default; // 0x000000018095A7A0-0x000000018095A800
		public static void GetGameplayStats() {} // 0x000000018095A300-0x000000018095A350
		public static SteamAPICall_t GetServerReputation() => default; // 0x000000018095A440-0x000000018095A4D0
		public static SteamIPAddress_t GetPublicIP() => default; // 0x000000018095A3E0-0x000000018095A440
		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort) => default; // 0x000000018095A560-0x000000018095A5F0
		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort) {
			pNetAdr = default;
			pPort = default;
			return default;
		} // 0x000000018095A350-0x000000018095A3E0
		public static void EnableHeartbeats(bool bActive) {} // 0x000000018095A150-0x000000018095A1A0
		public static void SetHeartbeatInterval(int iHeartbeatInterval) {} // 0x000000018095ACB0-0x000000018095AD00
		public static void ForceHeartbeat() {} // 0x000000018095A1F0-0x000000018095A240
		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan) => default; // 0x0000000180959C90-0x0000000180959D20
		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer) => default; // 0x000000018095A030-0x000000018095A0C0
	}
}
