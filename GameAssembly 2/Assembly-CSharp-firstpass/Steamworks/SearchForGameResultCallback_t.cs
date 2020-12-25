/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x0000000180120140-0x0000000180120160
	public struct SearchForGameResultCallback_t // TypeDefIndex: 6220
	{
		// Fields
		public const int k_iCallback = 5202; // Metadata: 0x00650CDB
		public ulong m_ullSearchID; // 0x00
		public EResult m_eResult; // 0x08
		public int m_nCountPlayersInGame; // 0x0C
		public int m_nCountAcceptedGame; // 0x10
		public CSteamID m_steamIDHost; // 0x14
		public bool m_bFinalCallback; // 0x1C
	}
}
