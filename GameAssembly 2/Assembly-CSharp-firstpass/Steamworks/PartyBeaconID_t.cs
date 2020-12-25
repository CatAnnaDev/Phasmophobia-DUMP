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
	public struct PartyBeaconID_t : IEquatable<Steamworks.PartyBeaconID_t>, IComparable<Steamworks.PartyBeaconID_t> // TypeDefIndex: 6556
	{
		// Fields
		public static readonly PartyBeaconID_t Invalid; // 0x00
		public ulong m_PartyBeaconID; // 0x00
	
		// Constructors
		public PartyBeaconID_t(ulong value) {
			m_PartyBeaconID = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static PartyBeaconID_t() {
			Invalid = default;
		} // 0x00000001809489D0-0x0000000180948A10
	
		// Methods
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x000000018003DC30-0x000000018003DCE0
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(PartyBeaconID_t x, PartyBeaconID_t y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(PartyBeaconID_t x, PartyBeaconID_t y) => default; // 0x0000000180948A10-0x0000000180948B20
		public static explicit operator PartyBeaconID_t(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(PartyBeaconID_t that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(PartyBeaconID_t other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(PartyBeaconID_t other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
