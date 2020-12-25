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
	public struct CGameID : IEquatable<Steamworks.CGameID>, IComparable<Steamworks.CGameID> // TypeDefIndex: 6503
	{
		// Fields
		public ulong m_GameID; // 0x00
	
		// Nested types
		public enum EGameIDType // TypeDefIndex: 6504
		{
			k_EGameIDTypeApp = 0,
			k_EGameIDTypeGameMod = 1,
			k_EGameIDTypeShortcut = 2,
			k_EGameIDTypeP2P = 3
		}
	
		// Constructors
		public CGameID(ulong GameID) {
			m_GameID = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		public CGameID(AppId_t nAppID) {
			m_GameID = default;
		} // 0x000000018002D5C0-0x000000018002D5E0
		public CGameID(AppId_t nAppID, uint nModID) {
			m_GameID = default;
		} // 0x000000018002D5E0-0x000000018002D630
	
		// Methods
		public bool IsSteamApp() => default; // 0x000000018002D3E0-0x000000018002D3F0
		public bool IsMod() => default; // 0x000000018002D3B0-0x000000018002D3C0
		public bool IsShortcut() => default; // 0x000000018002D3D0-0x000000018002D3E0
		public bool IsP2PFile() => default; // 0x000000018002D3C0-0x000000018002D3D0
		public AppId_t AppID() => default; // 0x000000018002D310-0x000000018002D320
		public EGameIDType Type() => default; // 0x0000000180004220-0x0000000180004230
		public uint ModID() => default; // 0x000000018002D550-0x000000018002D560
		public bool IsValid() => default; // 0x000000018002D3F0-0x000000018002D550
		public void Reset() {} // 0x000000018002D560-0x000000018002D570
		public void Set(ulong GameID) {} // 0x0000000180004FE0-0x0000000180004FF0
		private void SetAppID(AppId_t other) {} // 0x000000018002D570-0x000000018002D580
		private void SetType(EGameIDType other) {} // 0x000000018002D5A0-0x000000018002D5C0
		private void SetModID(uint other) {} // 0x000000018002D580-0x000000018002D5A0
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x000000018002D320-0x000000018002D3B0
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(CGameID x, CGameID y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(CGameID x, CGameID y) => default; // 0x00000001802A78C0-0x00000001802A7960
		public static explicit operator CGameID(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(CGameID that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(CGameID other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(CGameID other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
