/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x00000001801261B0-0x00000001801261D0
	public struct LeaderboardScoreUploaded_t // TypeDefIndex: 6323
	{
		// Fields
		public const int k_iCallback = 1106; // Metadata: 0x00650E77
		public byte m_bSuccess; // 0x00
		public SteamLeaderboard_t m_hSteamLeaderboard; // 0x08
		public int m_nScore; // 0x10
		public byte m_bScoreChanged; // 0x14
		public int m_nGlobalRankNew; // 0x18
		public int m_nGlobalRankPrevious; // 0x1C
	}
}
