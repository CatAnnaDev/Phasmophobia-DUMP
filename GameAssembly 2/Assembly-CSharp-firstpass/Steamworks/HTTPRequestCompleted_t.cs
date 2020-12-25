/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x000000018011CB40-0x000000018011CB60
	public struct HTTPRequestCompleted_t // TypeDefIndex: 6199
	{
		// Fields
		public const int k_iCallback = 2101; // Metadata: 0x00650C87
		public HTTPRequestHandle m_hRequest; // 0x00
		public ulong m_ulContextValue; // 0x08
		public bool m_bRequestSuccessful; // 0x10
		public EHTTPStatusCode m_eStatusCode; // 0x14
		public uint m_unBodySize; // 0x18
	}
}
