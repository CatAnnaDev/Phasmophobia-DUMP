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
	public struct DepotId_t : IEquatable<Steamworks.DepotId_t>, IComparable<Steamworks.DepotId_t> // TypeDefIndex: 6554
	{
		// Fields
		public static readonly DepotId_t Invalid; // 0x00
		public uint m_DepotId; // 0x00
	
		// Constructors
		public DepotId_t(uint value) {
			m_DepotId = default;
		} // 0x00000001800163C0-0x00000001800163D0
		static DepotId_t() {
			Invalid = default;
		} // 0x00000001807CCDE0-0x00000001807CCE20
	
		// Methods
		public override string ToString() => default; // 0x00000001800262C0-0x0000000180026340
		public override bool Equals(object other) => default; // 0x000000018002DEC0-0x000000018002E930
		public override int GetHashCode() => default; // 0x000000018000DD00-0x000000018000DD10
		public static bool operator ==(DepotId_t x, DepotId_t y) => default; // 0x00000001803DE020-0x00000001803DE090
		public static bool operator !=(DepotId_t x, DepotId_t y) => default; // 0x00000001807CCE20-0x00000001807CCE80
		public static explicit operator DepotId_t(uint value) => default; // 0x0000000180322710-0x00000001803232A0
		public static explicit operator uint(DepotId_t that) => default; // 0x0000000180322710-0x00000001803232A0
		public bool Equals(DepotId_t other) => default; // 0x0000000180016320-0x0000000180016330
		public int CompareTo(DepotId_t other) => default; // 0x000000018002CB20-0x000000018002CB30
	}
}
