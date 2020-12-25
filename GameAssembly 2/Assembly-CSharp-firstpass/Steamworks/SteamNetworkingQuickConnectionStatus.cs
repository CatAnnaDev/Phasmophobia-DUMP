/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public struct SteamNetworkingQuickConnectionStatus // TypeDefIndex: 6456
	{
		// Fields
		public ESteamNetworkingConnectionState m_eState; // 0x00
		public int m_nPing; // 0x04
		public float m_flConnectionQualityLocal; // 0x08
		public float m_flConnectionQualityRemote; // 0x0C
		public float m_flOutPacketsPerSec; // 0x10
		public float m_flOutBytesPerSec; // 0x14
		public float m_flInPacketsPerSec; // 0x18
		public float m_flInBytesPerSec; // 0x1C
		public int m_nSendRateBytesPerSecond; // 0x20
		public int m_cbPendingUnreliable; // 0x24
		public int m_cbPendingReliable; // 0x28
		public int m_cbSentUnackedReliable; // 0x2C
		public SteamNetworkingMicroseconds m_usecQueueTime; // 0x30
		public uint[] reserved; // 0x38
	}
}
