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
	public struct SiteId_t : IEquatable<Steamworks.SiteId_t>, IComparable<Steamworks.SiteId_t> // TypeDefIndex: 6558
	{
		// Fields
		public static readonly SiteId_t Invalid; // 0x00
		public ulong m_SiteId; // 0x00
	
		// Constructors
		public SiteId_t(ulong value) {
			m_SiteId = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static SiteId_t() {
			Invalid = default;
		} // 0x0000000180948D00-0x0000000180948D40
	
		// Methods
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x0000000180041880-0x0000000180041930
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(SiteId_t x, SiteId_t y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(SiteId_t x, SiteId_t y) => default; // 0x0000000180948D40-0x0000000180948DA0
		public static explicit operator SiteId_t(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(SiteId_t that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(SiteId_t other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(SiteId_t other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
