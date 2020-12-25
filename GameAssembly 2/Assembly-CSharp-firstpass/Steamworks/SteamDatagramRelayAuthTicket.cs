/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	[Serializable]
	public struct SteamDatagramRelayAuthTicket // TypeDefIndex: 6512
	{
		// Fields
		private SteamNetworkingIdentity m_identityGameserver; // 0x00
		private SteamNetworkingIdentity m_identityAuthorizedClient; // 0x10
		private uint m_unPublicIP; // 0x20
		private RTime32 m_rtimeTicketExpiry; // 0x24
		private SteamDatagramHostedAddress m_routing; // 0x28
		private uint m_nAppID; // 0x38
		private int m_nRestrictToVirtualPort; // 0x3C
		private const int k_nMaxExtraFields = 16; // Metadata: 0x00652CE0
		private int m_nExtraFields; // 0x40
		private ExtraField[] m_vecExtraFields; // 0x48
	
		// Nested types
		private struct ExtraField // TypeDefIndex: 6513
		{
			// Fields
			private EType m_eType; // 0x00
			private byte[] m_szName; // 0x08
			private OptionValue m_val; // 0x10
	
			// Nested types
			private enum EType // TypeDefIndex: 6514
			{
				k_EType_String = 0,
				k_EType_Int = 1,
				k_EType_Fixed64 = 2
			}
	
			private struct OptionValue // TypeDefIndex: 6515
			{
				// Fields
				private byte[] m_szStringValue; // 0x00
				private long m_nIntValue; // 0x00
				private ulong m_nFixed64Value; // 0x00
			}
		}
	
		// Methods
		public void Clear() {} // 0x0000000180002ED0-0x0000000180002EE0
	}
}
