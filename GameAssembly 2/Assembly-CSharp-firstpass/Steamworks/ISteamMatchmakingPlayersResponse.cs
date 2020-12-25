/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public class ISteamMatchmakingPlayersResponse // TypeDefIndex: 6105
	{
		// Fields
		private VTable m_VTable; // 0x10
		private IntPtr m_pVTable; // 0x18
		private GCHandle m_pGCHandle; // 0x20
		private AddPlayerToList m_AddPlayerToList; // 0x28
		private PlayersFailedToRespond m_PlayersFailedToRespond; // 0x30
		private PlayersRefreshComplete m_PlayersRefreshComplete; // 0x38
	
		// Nested types
		public delegate void AddPlayerToList(string pchName, int nScore, float flTimePlayed); // TypeDefIndex: 6106; 0x00000001807CA3B0-0x00000001807CA9C0
	
		public delegate void PlayersFailedToRespond(); // TypeDefIndex: 6107; 0x00000001802D1BD0-0x00000001802D1D60
	
		public delegate void PlayersRefreshComplete(); // TypeDefIndex: 6108; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		public delegate void InternalAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed); // TypeDefIndex: 6109; 0x00000001807CF350-0x00000001807CF6F0
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		public delegate void InternalPlayersFailedToRespond(IntPtr thisptr); // TypeDefIndex: 6110; 0x00000001802A7CC0-0x00000001802A7E90
	
		// [UnmanagedFunctionPointer] // 0x00000001800F9050-0x00000001800F9070
		public delegate void InternalPlayersRefreshComplete(IntPtr thisptr); // TypeDefIndex: 6111; 0x00000001802A7CC0-0x00000001802A7E90
	
		private class VTable // TypeDefIndex: 6112
		{
			// Fields
			[NonSerialized]
			public InternalAddPlayerToList m_VTAddPlayerToList; // 0x10
			[NonSerialized]
			public InternalPlayersFailedToRespond m_VTPlayersFailedToRespond; // 0x18
			[NonSerialized]
			public InternalPlayersRefreshComplete m_VTPlayersRefreshComplete; // 0x20
	
			// Constructors
			public VTable() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public ISteamMatchmakingPlayersResponse() {} // Dummy constructor
		public ISteamMatchmakingPlayersResponse(AddPlayerToList onAddPlayerToList, PlayersFailedToRespond onPlayersFailedToRespond, PlayersRefreshComplete onPlayersRefreshComplete) {} // 0x00000001807CF010-0x00000001807CF280
	
		// Methods
		~ISteamMatchmakingPlayersResponse() {} // 0x00000001807CEE80-0x00000001807CEF80
		private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed) {} // 0x00000001807CEF80-0x00000001807CEFD0
		private void InternalOnPlayersFailedToRespond(IntPtr thisptr) {} // 0x00000001807CEFD0-0x00000001807CEFF0
		private void InternalOnPlayersRefreshComplete(IntPtr thisptr) {} // 0x00000001807CEFF0-0x00000001807CF010
		public static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that) => default; // 0x00000001802A72D0-0x00000001802A72F0
	}
}
