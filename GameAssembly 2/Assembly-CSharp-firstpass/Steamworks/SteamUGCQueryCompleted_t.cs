/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x0000000180124560-0x0000000180124580
	public struct SteamUGCQueryCompleted_t // TypeDefIndex: 6287
	{
		// Fields
		public const int k_iCallback = 3401; // Metadata: 0x00650DE7
		public UGCQueryHandle_t m_handle; // 0x00
		public EResult m_eResult; // 0x08
		public uint m_unNumResultsReturned; // 0x0C
		public uint m_unTotalMatchingResults; // 0x10
		public bool m_bCachedData; // 0x14
		public string m_rgchNextCursor; // 0x18
	}
}
