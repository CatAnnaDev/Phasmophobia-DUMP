/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x00000001801200F0-0x0000000180120110
	public struct SearchForGameProgressCallback_t // TypeDefIndex: 6219
	{
		// Fields
		public const int k_iCallback = 5201; // Metadata: 0x00650CD7
		public ulong m_ullSearchID; // 0x00
		public EResult m_eResult; // 0x08
		public CSteamID m_lobbyID; // 0x0C
		public CSteamID m_steamIDEndedSearch; // 0x14
		public int m_nSecondsRemainingEstimate; // 0x1C
		public int m_cPlayersSearching; // 0x20
	}
}
