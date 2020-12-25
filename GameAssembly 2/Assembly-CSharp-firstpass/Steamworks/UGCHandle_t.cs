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
	public struct UGCHandle_t : IEquatable<Steamworks.UGCHandle_t>, IComparable<Steamworks.UGCHandle_t> // TypeDefIndex: 6549
	{
		// Fields
		public static readonly UGCHandle_t Invalid; // 0x00
		public ulong m_UGCHandle; // 0x00
	
		// Constructors
		public UGCHandle_t(ulong value) {
			m_UGCHandle = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static UGCHandle_t() {
			Invalid = default;
		} // 0x0000000180840180-0x00000001808401C0
	
		// Methods
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x0000000180030DD0-0x0000000180030E80
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(UGCHandle_t x, UGCHandle_t y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(UGCHandle_t x, UGCHandle_t y) => default; // 0x00000001808401C0-0x0000000180840220
		public static explicit operator UGCHandle_t(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(UGCHandle_t that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(UGCHandle_t other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(UGCHandle_t other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
