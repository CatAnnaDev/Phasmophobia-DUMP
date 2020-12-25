/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameSearch // TypeDefIndex: 6481
	{
		// Methods
		public static EGameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind) => default; // 0x00000001809505F0-0x0000000180950790
		public static EGameSearchErrorCode_t SearchForGameWithLobby(CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax) => default; // 0x0000000180950B10-0x0000000180950B90
		public static EGameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax) => default; // 0x0000000180950AB0-0x0000000180950B10
		public static EGameSearchErrorCode_t AcceptGame() => default; // 0x00000001809505A0-0x00000001809505F0
		public static EGameSearchErrorCode_t DeclineGame() => default; // 0x00000001809507E0-0x0000000180950830
		public static EGameSearchErrorCode_t RetrieveConnectionDetails(CSteamID steamIDHost, out string pchConnectionDetails, int cubConnectionDetails) {
			pchConnectionDetails = default;
			return default;
		} // 0x0000000180950990-0x0000000180950AB0
		public static EGameSearchErrorCode_t EndGameSearch() => default; // 0x0000000180950830-0x0000000180950880
		public static EGameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue) => default; // 0x0000000180950CC0-0x0000000180950E60
		public static EGameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails) => default; // 0x0000000180950B90-0x0000000180950CC0
		public static EGameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize) => default; // 0x0000000180950920-0x0000000180950990
		public static EGameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID) => default; // 0x00000001809508D0-0x0000000180950920
		public static EGameSearchErrorCode_t CancelRequestPlayersForGame() => default; // 0x0000000180950790-0x00000001809507E0
		public static EGameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult) => default; // 0x0000000180950E60-0x0000000180950EE0
		public static EGameSearchErrorCode_t EndGame(ulong ullUniqueGameID) => default; // 0x0000000180950880-0x00000001809508D0
	}
}
