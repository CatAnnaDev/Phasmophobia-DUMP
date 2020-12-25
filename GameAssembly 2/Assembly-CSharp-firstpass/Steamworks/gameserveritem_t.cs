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
	public class gameserveritem_t // TypeDefIndex: 6497
	{
		// Fields
		public servernetadr_t m_NetAdr; // 0x10
		public int m_nPing; // 0x18
		public bool m_bHadSuccessfulResponse; // 0x1C
		public bool m_bDoNotRefresh; // 0x1D
		private byte[] m_szGameDir; // 0x20
		private byte[] m_szMap; // 0x28
		private byte[] m_szGameDescription; // 0x30
		public uint m_nAppID; // 0x38
		public int m_nPlayers; // 0x3C
		public int m_nMaxPlayers; // 0x40
		public int m_nBotPlayers; // 0x44
		public bool m_bPassword; // 0x48
		public bool m_bSecure; // 0x49
		public uint m_ulTimeLastPlayed; // 0x4C
		public int m_nServerVersion; // 0x50
		private byte[] m_szServerName; // 0x58
		private byte[] m_szGameTags; // 0x60
		public CSteamID m_steamID; // 0x68
	
		// Constructors
		public gameserveritem_t() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		public string GetGameDir() => default; // 0x00000001808403E0-0x0000000180840460
		public void SetGameDir(string dir) {} // 0x00000001808406B0-0x0000000180840740
		public string GetMap() => default; // 0x00000001808404E0-0x0000000180840560
		public void SetMap(string map) {} // 0x00000001808407D0-0x0000000180840860
		public string GetGameDescription() => default; // 0x0000000180840360-0x00000001808403E0
		public void SetGameDescription(string desc) {} // 0x0000000180840620-0x00000001808406B0
		public string GetServerName() => default; // 0x0000000180840560-0x0000000180840620
		public void SetServerName(string name) {} // 0x0000000180840860-0x00000001808408F0
		public string GetGameTags() => default; // 0x0000000180840460-0x00000001808404E0
		public void SetGameTags(string tags) {} // 0x0000000180840740-0x00000001808407D0
	}
}
