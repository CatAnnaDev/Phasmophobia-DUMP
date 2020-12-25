/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamUser // TypeDefIndex: 6493
	{
		// Methods
		public static HSteamUser GetHSteamUser() => default; // 0x000000018083E580-0x000000018083E5D0
		public static bool BLoggedOn() => default; // 0x000000018083E0C0-0x000000018083E110
		public static CSteamID GetSteamID() => default; // 0x000000018083E6B0-0x000000018083E740
		public static int InitiateGameConnection(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) => default; // 0x000000018083E950-0x000000018083E9F0
		public static void TerminateGameConnection(uint unIPServer, ushort usPortServer) {} // 0x000000018083ECA0-0x000000018083ED00
		public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "" /* Metadata: 0x00652CCC */) {} // 0x000000018083ED00-0x000000018083EE40
		public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer) {
			pchBuffer = default;
			return default;
		} // 0x000000018083E740-0x000000018083E840
		public static void StartVoiceRecording() {} // 0x000000018083EC00-0x000000018083EC50
		public static void StopVoiceRecording() {} // 0x000000018083EC50-0x000000018083ECA0
		public static EVoiceResult GetAvailableVoice(out uint pcbCompressed) {
			pcbCompressed = default;
			return default;
		} // 0x000000018083E390-0x000000018083E410
		public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten) {
			nBytesWritten = default;
			return default;
		} // 0x000000018083E890-0x000000018083E950
		public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate) {
			nBytesWritten = default;
			return default;
		} // 0x000000018083E1E0-0x000000018083E280
		public static uint GetVoiceOptimalSampleRate() => default; // 0x000000018083E840-0x000000018083E890
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket) {
			pcbTicket = default;
			return default;
		} // 0x000000018083E2D0-0x000000018083E390
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) => default; // 0x000000018083E110-0x000000018083E190
		public static void EndAuthSession(CSteamID steamID) {} // 0x000000018083E280-0x000000018083E2D0
		public static void CancelAuthTicket(HAuthTicket hAuthTicket) {} // 0x000000018083E190-0x000000018083E1E0
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID) => default; // 0x000000018083EE40-0x000000018083EEA0
		public static bool BIsBehindNAT() => default; // 0x000000018083DF30-0x000000018083DF80
		public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer) {} // 0x000000018083DEB0-0x000000018083DF30
		public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude) => default; // 0x000000018083E9F0-0x000000018083EAA0
		public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket) {
			pcbTicket = default;
			return default;
		} // 0x000000018083E4A0-0x000000018083E520
		public static int GetGameBadgeLevel(int nSeries, bool bFoil) => default; // 0x000000018083E520-0x000000018083E580
		public static int GetPlayerSteamLevel() => default; // 0x000000018083E660-0x000000018083E6B0
		public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL) => default; // 0x000000018083EAA0-0x000000018083EC00
		public static bool BIsPhoneVerified() => default; // 0x000000018083E020-0x000000018083E070
		public static bool BIsTwoFactorEnabled() => default; // 0x000000018083E070-0x000000018083E0C0
		public static bool BIsPhoneIdentifying() => default; // 0x000000018083DF80-0x000000018083DFD0
		public static bool BIsPhoneRequiringVerification() => default; // 0x000000018083DFD0-0x000000018083E020
		public static SteamAPICall_t GetMarketEligibility() => default; // 0x000000018083E5D0-0x000000018083E660
		public static SteamAPICall_t GetDurationControl() => default; // 0x000000018083E410-0x000000018083E4A0
	}
}
