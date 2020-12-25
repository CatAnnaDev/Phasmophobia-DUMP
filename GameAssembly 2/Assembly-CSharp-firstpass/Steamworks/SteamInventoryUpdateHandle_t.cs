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
	public struct SteamInventoryUpdateHandle_t : IEquatable<Steamworks.SteamInventoryUpdateHandle_t>, IComparable<Steamworks.SteamInventoryUpdateHandle_t> // TypeDefIndex: 6525
	{
		// Fields
		public static readonly SteamInventoryUpdateHandle_t Invalid; // 0x00
		public ulong m_SteamInventoryUpdateHandle; // 0x00
	
		// Constructors
		public SteamInventoryUpdateHandle_t(ulong value) {
			m_SteamInventoryUpdateHandle = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static SteamInventoryUpdateHandle_t() {
			Invalid = default;
		} // 0x00000001807A2380-0x00000001807A23C0
	
		// Methods
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x000000018002AD60-0x000000018002AE10
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y) => default; // 0x00000001807A23C0-0x00000001807A2420
		public static explicit operator SteamInventoryUpdateHandle_t(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(SteamInventoryUpdateHandle_t that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(SteamInventoryUpdateHandle_t other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(SteamInventoryUpdateHandle_t other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
