/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	[Serializable]
	public struct SteamIPAddress_t // TypeDefIndex: 6560
	{
		// Fields
		private long m_ip0; // 0x00
		private long m_ip1; // 0x08
		private ESteamIPType m_eType; // 0x10
	
		// Constructors
		public SteamIPAddress_t(IPAddress iPAddress) {
			m_ip0 = default;
			m_ip1 = default;
			m_eType = default;
		} // 0x000000018002AC30-0x000000018002AC90
	
		// Methods
		public IPAddress ToIPAddress() => default; // 0x000000018002ABE0-0x000000018002ABF0
		public override string ToString() => default; // 0x000000018002ABF0-0x000000018002AC30
		public ESteamIPType GetIPType() => default; // 0x0000000180009100-0x0000000180009110
		public bool IsSet() => default; // 0x000000018002ABC0-0x000000018002ABE0
	}
}
