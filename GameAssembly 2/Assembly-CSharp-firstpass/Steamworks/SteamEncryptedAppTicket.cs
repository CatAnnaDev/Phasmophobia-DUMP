/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamEncryptedAppTicket // TypeDefIndex: 6131
	{
		// Methods
		public static bool BDecryptTicket(byte[] rgubTicketEncrypted, uint cubTicketEncrypted, byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, byte[] rgubKey, int cubKey) => default; // 0x000000018094DB80-0x000000018094DBE0
		public static bool BIsTicketForApp(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) => default; // 0x000000018094DBE0-0x000000018094DC20
		public static uint GetTicketIssueTime(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) => default; // 0x000000018094DD20-0x000000018094DD50
		public static void GetTicketSteamID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID) {
			psteamID = default;
		} // 0x000000018094DD50-0x000000018094DD90
		public static uint GetTicketAppID(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) => default; // 0x000000018094DCF0-0x000000018094DD20
		public static bool BUserOwnsAppInTicket(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) => default; // 0x000000018094DCB0-0x000000018094DCF0
		public static bool BUserIsVacBanned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted) => default; // 0x000000018094DC80-0x000000018094DCB0
		public static byte[] GetUserVariableData(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData) {
			pcubUserData = default;
			return default;
		} // 0x000000018094DD90-0x000000018094DE40
		public static bool BIsTicketSigned(byte[] rgubTicketDecrypted, uint cubTicketDecrypted, byte[] pubRSAKey, uint cubRSAKey) => default; // 0x000000018094DC20-0x000000018094DC80
	}
}
