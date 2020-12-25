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
	public struct servernetadr_t // TypeDefIndex: 6498
	{
		// Fields
		private ushort m_usConnectionPort; // 0x00
		private ushort m_usQueryPort; // 0x02
		private uint m_unIP; // 0x04
	
		// Methods
		public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort) {} // 0x00000001800331C0-0x00000001800331D0
		public ushort GetQueryPort() => default; // 0x00000001800331B0-0x00000001800331C0
		public void SetQueryPort(ushort usPort) {} // 0x00000001800331D0-0x00000001800331F0
		public ushort GetConnectionPort() => default; // 0x0000000180004230-0x0000000180004240
		public void SetConnectionPort(ushort usPort) {} // 0x000000018002EA10-0x000000018002F040
		public uint GetIP() => default; // 0x0000000180022C20-0x0000000180022C30
		public void SetIP(uint unIP) {} // 0x0000000180022C60-0x0000000180022C70
		public string GetConnectionAddressString() => default; // 0x0000000180033140-0x0000000180033150
		public string GetQueryAddressString() => default; // 0x00000001800331A0-0x00000001800331B0
		public static string ToString(uint unIP, ushort usPort) => default; // 0x00000001808408F0-0x0000000180840BB0
		public static bool operator <(servernetadr_t x, servernetadr_t y) => default; // 0x0000000180840C60-0x0000000180840C90
		public static bool operator >(servernetadr_t x, servernetadr_t y) => default; // 0x0000000180840BF0-0x0000000180840C20
		public override bool Equals(object other) => default; // 0x0000000180033060-0x0000000180033110
		public override int GetHashCode() => default; // 0x0000000180033150-0x00000001800331A0
		public static bool operator ==(servernetadr_t x, servernetadr_t y) => default; // 0x0000000180840BB0-0x0000000180840BF0
		public static bool operator !=(servernetadr_t x, servernetadr_t y) => default; // 0x0000000180840C20-0x0000000180840C60
		public bool Equals(servernetadr_t other) => default; // 0x0000000180033110-0x0000000180033140
		public int CompareTo(servernetadr_t other) => default; // 0x0000000180032FF0-0x0000000180033060
	}
}
