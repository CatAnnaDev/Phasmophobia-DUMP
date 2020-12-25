/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x00000001801202C0-0x00000001801202E0
	public struct RequestPlayersForGameResultCallback_t // TypeDefIndex: 6222
	{
		// Fields
		public const int k_iCallback = 5212; // Metadata: 0x00650CE3
		public EResult m_eResult; // 0x00
		public ulong m_ullSearchID; // 0x08
		public CSteamID m_SteamIDPlayerFound; // 0x10
		public CSteamID m_SteamIDLobby; // 0x18
		public PlayerAcceptState_t m_ePlayerAcceptState; // 0x20
		public int m_nPlayerIndex; // 0x24
		public int m_nTotalPlayersFound; // 0x28
		public int m_nTotalPlayersAcceptedGame; // 0x2C
		public int m_nSuggestedTeamIndex; // 0x30
		public ulong m_ullUniqueGameID; // 0x38
	}
}
