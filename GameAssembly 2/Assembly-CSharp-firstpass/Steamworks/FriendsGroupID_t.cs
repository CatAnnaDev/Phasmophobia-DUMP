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
	public struct FriendsGroupID_t : IEquatable<Steamworks.FriendsGroupID_t>, IComparable<Steamworks.FriendsGroupID_t> // TypeDefIndex: 6516
	{
		// Fields
		public static readonly FriendsGroupID_t Invalid; // 0x00
		public short m_FriendsGroupID; // 0x00
	
		// Constructors
		public FriendsGroupID_t(short value) {
			m_FriendsGroupID = default;
		} // 0x000000018002EA10-0x000000018002F040
		static FriendsGroupID_t() {
			Invalid = default;
		} // 0x00000001807CCF10-0x00000001807CCF50
	
		// Methods
		public override string ToString() => default; // 0x000000018002EA00-0x000000018002EA10
		public override bool Equals(object other) => default; // 0x000000018002E940-0x000000018002E9F0
		public override int GetHashCode() => default; // 0x000000018002E9F0-0x000000018002EA00
		public static bool operator ==(FriendsGroupID_t x, FriendsGroupID_t y) => default; // 0x00000001807CCF50-0x00000001807CCF60
		public static bool operator !=(FriendsGroupID_t x, FriendsGroupID_t y) => default; // 0x00000001807CCF60-0x00000001807CCFC0
		public static explicit operator FriendsGroupID_t(short value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		public static explicit operator short(FriendsGroupID_t that) => default; // 0x00000001803A5E00-0x00000001803A5E10
		public bool Equals(FriendsGroupID_t other) => default; // 0x00000001800248E0-0x00000001800248F0
		public int CompareTo(FriendsGroupID_t other) => default; // 0x000000018002E930-0x000000018002E940
	}
}
