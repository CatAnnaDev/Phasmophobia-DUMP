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
	public struct SteamNetworkingIdentity : IEquatable<Steamworks.SteamNetworkingIdentity> // TypeDefIndex: 6542
	{
		// Fields
		public ESteamNetworkingIdentityType m_eType; // 0x00
		private int m_cbSize; // 0x04
		private uint[] m_reserved; // 0x08
		public const int k_cchMaxString = 128; // Metadata: 0x00652CF6
		public const int k_cchMaxGenericString = 32; // Metadata: 0x00652CFA
		public const int k_cbMaxGenericBytes = 32; // Metadata: 0x00652CFE
	
		// Methods
		public void Clear() {} // 0x000000018002C2E0-0x000000018002C2F0
		public bool IsInvalid() => default; // 0x000000018002C3E0-0x000000018002C3F0
		public void SetSteamID(CSteamID steamID) {} // 0x000000018002C480-0x000000018002C4F0
		public CSteamID GetSteamID() => default; // 0x000000018002C380-0x000000018002C3E0
		public void SetSteamID64(ulong steamID) {} // 0x000000018002C470-0x000000018002C480
		public ulong GetSteamID64() => default; // 0x000000018002C370-0x000000018002C380
		public void SetIPAddr(SteamNetworkingIPAddr addr) {} // 0x000000018002C430-0x000000018002C460
		public SteamNetworkingIPAddr GetIPAddr() => default; // 0x000000018002C350-0x000000018002C370
		public void SetLocalHost() {} // 0x000000018002C460-0x000000018002C470
		public bool IsLocalHost() => default; // 0x000000018002C3F0-0x000000018002C400
		public bool SetGenericString(string pszString) => default; // 0x000000018002C420-0x000000018002C430
		public string GetGenericString() => default; // 0x000000018002C330-0x000000018002C350
		public bool SetGenericBytes(byte[] data, uint cbLen) => default; // 0x000000018002C410-0x000000018002C420
		public byte[] GetGenericBytes(out int cbLen) {
			cbLen = default;
			return default;
		} // 0x000000018002C320-0x000000018002C330
		public bool Equals(SteamNetworkingIdentity x) => default; // 0x000000018002C2F0-0x000000018002C320
		public void ToString(out string buf) {
			buf = default;
		} // 0x000000018002C4F0-0x000000018002C910
		public bool ParseString(string pszStr) => default; // 0x000000018002C400-0x000000018002C410
	}
}
