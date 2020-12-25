/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public struct SteamNetConnectionInfo_t // TypeDefIndex: 6455
	{
		// Fields
		public SteamNetworkingIdentity m_identityRemote; // 0x00
		public long m_nUserData; // 0x10
		public HSteamListenSocket m_hListenSocket; // 0x18
		public SteamNetworkingIPAddr m_addrRemote; // 0x20
		public ushort m__pad1; // 0x30
		public SteamNetworkingPOPID m_idPOPRemote; // 0x34
		public SteamNetworkingPOPID m_idPOPRelay; // 0x38
		public ESteamNetworkingConnectionState m_eState; // 0x3C
		public int m_eEndReason; // 0x40
		public string m_szEndDebug; // 0x48
		public string m_szConnectionDescription; // 0x50
		public uint[] reserved; // 0x58
	}
}
