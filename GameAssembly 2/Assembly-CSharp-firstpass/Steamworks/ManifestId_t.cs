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
	public struct ManifestId_t : IEquatable<Steamworks.ManifestId_t>, IComparable<Steamworks.ManifestId_t> // TypeDefIndex: 6555
	{
		// Fields
		public static readonly ManifestId_t Invalid; // 0x00
		public ulong m_ManifestId; // 0x00
	
		// Constructors
		public ManifestId_t(ulong value) {
			m_ManifestId = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static ManifestId_t() {
			Invalid = default;
		} // 0x00000001802A8A60-0x00000001802A8AA0
	
		// Methods
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x0000000180005210-0x00000001800052C0
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(ManifestId_t x, ManifestId_t y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(ManifestId_t x, ManifestId_t y) => default; // 0x00000001802A8AA0-0x00000001802A8B00
		public static explicit operator ManifestId_t(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(ManifestId_t that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(ManifestId_t other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(ManifestId_t other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
