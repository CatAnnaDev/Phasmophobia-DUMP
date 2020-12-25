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
	public struct UGCQueryHandle_t : IEquatable<Steamworks.UGCQueryHandle_t>, IComparable<Steamworks.UGCQueryHandle_t> // TypeDefIndex: 6561
	{
		// Fields
		public static readonly UGCQueryHandle_t Invalid; // 0x00
		public ulong m_UGCQueryHandle; // 0x00
	
		// Constructors
		public UGCQueryHandle_t(ulong value) {
			m_UGCQueryHandle = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static UGCQueryHandle_t() {
			Invalid = default;
		} // 0x0000000180840220-0x0000000180840260
	
		// Methods
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x0000000180030E80-0x0000000180030F30
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y) => default; // 0x0000000180840260-0x00000001808402C0
		public static explicit operator UGCQueryHandle_t(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(UGCQueryHandle_t that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(UGCQueryHandle_t other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(UGCQueryHandle_t other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
