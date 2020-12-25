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
	public struct SteamNetworkingMessage_t // TypeDefIndex: 6543
	{
		// Fields
		public IntPtr m_pData; // 0x00
		public int m_cbSize; // 0x08
		public HSteamNetConnection m_conn; // 0x0C
		public SteamNetworkingIdentity m_identityPeer; // 0x10
		public long m_nConnUserData; // 0x20
		public SteamNetworkingMicroseconds m_usecTimeReceived; // 0x28
		public long m_nMessageNumber; // 0x30
		internal IntPtr m_pfnFreeData; // 0x38
		internal IntPtr m_pfnRelease; // 0x40
		public int m_nChannel; // 0x48
		public int m_nFlags; // 0x4C
		public long m_nUserData; // 0x50
	
		// Methods
		public void Release() {} // 0x000000018002C910-0x000000018002CA70
	}
}
