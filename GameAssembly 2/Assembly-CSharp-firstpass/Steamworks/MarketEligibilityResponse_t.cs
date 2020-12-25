/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x0000000180125AF0-0x0000000180125B10
	public struct MarketEligibilityResponse_t // TypeDefIndex: 6316
	{
		// Fields
		public const int k_iCallback = 166; // Metadata: 0x00650E5B
		public bool m_bAllowed; // 0x00
		public EMarketNotAllowedReasonFlags m_eNotAllowedReason; // 0x04
		public RTime32 m_rtAllowedAtTime; // 0x08
		public int m_cdaySteamGuardRequiredDays; // 0x0C
		public int m_cdayNewDeviceCooldown; // 0x10
	}
}
