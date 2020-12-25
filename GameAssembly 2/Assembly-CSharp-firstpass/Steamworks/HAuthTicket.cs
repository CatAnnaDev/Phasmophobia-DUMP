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
	public struct HAuthTicket : IEquatable<Steamworks.HAuthTicket>, IComparable<Steamworks.HAuthTicket> // TypeDefIndex: 6506
	{
		// Fields
		public static readonly HAuthTicket Invalid; // 0x00
		public uint m_HAuthTicket; // 0x00
	
		// Constructors
		public HAuthTicket(uint value) {
			m_HAuthTicket = default;
		} // 0x00000001800163C0-0x00000001800163D0
		static HAuthTicket() {
			Invalid = default;
		} // 0x00000001807CD680-0x00000001807CD6C0
	
		// Methods
		public override string ToString() => default; // 0x00000001800262C0-0x0000000180026340
		public override bool Equals(object other) => default; // 0x000000018002F040-0x000000018002F0F0
		public override int GetHashCode() => default; // 0x000000018000DD00-0x000000018000DD10
		public static bool operator ==(HAuthTicket x, HAuthTicket y) => default; // 0x00000001803DE020-0x00000001803DE090
		public static bool operator !=(HAuthTicket x, HAuthTicket y) => default; // 0x00000001807CD6C0-0x00000001807CD720
		public static explicit operator HAuthTicket(uint value) => default; // 0x0000000180322710-0x00000001803232A0
		public static explicit operator uint(HAuthTicket that) => default; // 0x0000000180322710-0x00000001803232A0
		public bool Equals(HAuthTicket other) => default; // 0x0000000180016320-0x0000000180016330
		public int CompareTo(HAuthTicket other) => default; // 0x000000018002CB20-0x000000018002CB30
	}
}
