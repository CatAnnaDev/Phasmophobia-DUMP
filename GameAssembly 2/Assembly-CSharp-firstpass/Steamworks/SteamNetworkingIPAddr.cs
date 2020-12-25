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
	public struct SteamNetworkingIPAddr : IEquatable<Steamworks.SteamNetworkingIPAddr> // TypeDefIndex: 6541
	{
		// Fields
		public byte[] m_ipv6; // 0x00
		public ushort m_port; // 0x08
		public const int k_cchMaxString = 48; // Metadata: 0x00652CF2
	
		// Methods
		public void Clear() {} // 0x000000018002BF70-0x000000018002BF80
		public bool IsIPv6AllZeros() => default; // 0x000000018002BFD0-0x000000018002BFE0
		public void SetIPv6(byte[] ipv6, ushort nPort) {} // 0x000000018002C020-0x000000018002C030
		public void SetIPv4(uint nIP, ushort nPort) {} // 0x000000018002C000-0x000000018002C010
		public bool IsIPv4() => default; // 0x000000018002BFC0-0x000000018002BFD0
		public uint GetIPv4() => default; // 0x000000018002BFB0-0x000000018002BFC0
		public void SetIPv6LocalHost(ushort nPort = 0 /* Metadata: 0x00652CF0 */) {} // 0x000000018002C010-0x000000018002C020
		public bool IsLocalHost() => default; // 0x000000018002BFE0-0x000000018002BFF0
		public void ToString(out string buf, bool bWithPort) {
			buf = default;
		} // 0x000000018002C030-0x000000018002C2E0
		public bool ParseString(string pszStr) => default; // 0x000000018002BFF0-0x000000018002C000
		public bool Equals(SteamNetworkingIPAddr x) => default; // 0x000000018002BF80-0x000000018002BFB0
	}
}
