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
	public struct CSteamID : IEquatable<Steamworks.CSteamID>, IComparable<Steamworks.CSteamID> // TypeDefIndex: 6505
	{
		// Fields
		public static readonly CSteamID Nil; // 0x00
		public static readonly CSteamID OutofDateGS; // 0x08
		public static readonly CSteamID LanModeGS; // 0x10
		public static readonly CSteamID NotInitYetGS; // 0x18
		public static readonly CSteamID NonSteamGS; // 0x20
		public ulong m_SteamID; // 0x00
	
		// Constructors
		public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType) {
			m_SteamID = default;
		} // 0x000000018002DA20-0x000000018002DA40
		public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType) {
			m_SteamID = default;
		} // 0x000000018002D8C0-0x000000018002D8F0
		public CSteamID(ulong ulSteamID) {
			m_SteamID = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static CSteamID() {
			Nil = default;
			OutofDateGS = default;
			LanModeGS = default;
			NotInitYetGS = default;
			NonSteamGS = default;
		} // 0x00000001807CC930-0x00000001807CC9D0
	
		// Methods
		public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType) {} // 0x000000018002DA10-0x000000018002DA20
		public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType) {} // 0x000000018002D8C0-0x000000018002D8F0
		public void Clear() {} // 0x000000018002D560-0x000000018002D570
		public void CreateBlankAnonLogon(EUniverse eUniverse) {} // 0x000000018002D780-0x000000018002D7B0
		public void CreateBlankAnonUserLogon(EUniverse eUniverse) {} // 0x000000018002D7B0-0x000000018002D7E0
		public bool BBlankAnonAccount() => default; // 0x000000018002D680-0x000000018002D6B0
		public bool BGameServerAccount() => default; // 0x000000018002D720-0x000000018002D740
		public bool BPersistentGameServerAccount() => default; // 0x000000018002D760-0x000000018002D780
		public bool BAnonGameServerAccount() => default; // 0x000000018002D650-0x000000018002D660
		public bool BContentServerAccount() => default; // 0x000000018002D700-0x000000018002D720
		public bool BClanAccount() => default; // 0x000000018002D6C0-0x000000018002D6E0
		public bool BChatAccount() => default; // 0x000000018002D6B0-0x000000018002D6C0
		public bool IsLobby() => default; // 0x000000018002D8F0-0x000000018002D920
		public bool BIndividualAccount() => default; // 0x000000018002D740-0x000000018002D760
		public bool BAnonAccount() => default; // 0x000000018002D630-0x000000018002D650
		public bool BAnonUserAccount() => default; // 0x000000018002D660-0x000000018002D680
		public bool BConsoleUserAccount() => default; // 0x000000018002D6E0-0x000000018002D700
		public void SetAccountID(AccountID_t other) {} // 0x000000018002D990-0x000000018002D9B0
		public void SetAccountInstance(uint other) {} // 0x000000018002D9B0-0x000000018002D9D0
		public void SetEAccountType(EAccountType other) {} // 0x000000018002D9D0-0x000000018002D9F0
		public void SetEUniverse(EUniverse other) {} // 0x000000018002D9F0-0x000000018002DA10
		public AccountID_t GetAccountID() => default; // 0x000000018000B580-0x000000018000B590
		public uint GetUnAccountInstance() => default; // 0x000000018002D8B0-0x000000018002D8C0
		public EAccountType GetEAccountType() => default; // 0x000000018002D890-0x000000018002D8A0
		public EUniverse GetEUniverse() => default; // 0x000000018002D8A0-0x000000018002D8B0
		public bool IsValid() => default; // 0x000000018002D920-0x000000018002D990
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x000000018002D7E0-0x000000018002D890
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(CSteamID x, CSteamID y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(CSteamID x, CSteamID y) => default; // 0x00000001807CC9D0-0x00000001807CCA30
		public static explicit operator CSteamID(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(CSteamID that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(CSteamID other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(CSteamID other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
