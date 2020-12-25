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
	public struct PublishedFileId_t : IEquatable<Steamworks.PublishedFileId_t>, IComparable<Steamworks.PublishedFileId_t> // TypeDefIndex: 6546
	{
		// Fields
		public static readonly PublishedFileId_t Invalid; // 0x00
		public ulong m_PublishedFileId; // 0x00
	
		// Constructors
		public PublishedFileId_t(ulong value) {
			m_PublishedFileId = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static PublishedFileId_t() {
			Invalid = default;
		} // 0x0000000180948B20-0x0000000180948B60
	
		// Methods
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x000000018003DCE0-0x000000018003DD90
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(PublishedFileId_t x, PublishedFileId_t y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(PublishedFileId_t x, PublishedFileId_t y) => default; // 0x0000000180948B60-0x0000000180948BC0
		public static explicit operator PublishedFileId_t(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(PublishedFileId_t that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(PublishedFileId_t other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(PublishedFileId_t other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
