/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamMusicRemote // TypeDefIndex: 6484
	{
		// Methods
		public static bool RegisterSteamMusicRemote(string pchName) => default; // 0x00000001807A6C00-0x00000001807A6D40
		public static bool DeregisterSteamMusicRemote() => default; // 0x00000001807A6890-0x00000001807A68E0
		public static bool BIsCurrentMusicRemote() => default; // 0x00000001807A6750-0x00000001807A67A0
		public static bool BActivationSuccess(bool bValue) => default; // 0x00000001807A6700-0x00000001807A6750
		public static bool SetDisplayName(string pchDisplayName) => default; // 0x00000001807A6E80-0x00000001807A6FC0
		public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength) => default; // 0x00000001807A6FC0-0x00000001807A7020
		public static bool EnablePlayPrevious(bool bValue) => default; // 0x00000001807A6980-0x00000001807A69D0
		public static bool EnablePlayNext(bool bValue) => default; // 0x00000001807A6930-0x00000001807A6980
		public static bool EnableShuffled(bool bValue) => default; // 0x00000001807A6A70-0x00000001807A6AC0
		public static bool EnableLooped(bool bValue) => default; // 0x00000001807A68E0-0x00000001807A6930
		public static bool EnableQueue(bool bValue) => default; // 0x00000001807A6A20-0x00000001807A6A70
		public static bool EnablePlaylists(bool bValue) => default; // 0x00000001807A69D0-0x00000001807A6A20
		public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus) => default; // 0x00000001807A7500-0x00000001807A7550
		public static bool UpdateShuffled(bool bValue) => default; // 0x00000001807A7550-0x00000001807A75A0
		public static bool UpdateLooped(bool bValue) => default; // 0x00000001807A74B0-0x00000001807A7500
		public static bool UpdateVolume(float flValue) => default; // 0x00000001807A75A0-0x00000001807A7600
		public static bool CurrentEntryWillChange() => default; // 0x00000001807A6840-0x00000001807A6890
		public static bool CurrentEntryIsAvailable(bool bAvailable) => default; // 0x00000001807A67F0-0x00000001807A6840
		public static bool UpdateCurrentEntryText(string pchText) => default; // 0x00000001807A7370-0x00000001807A74B0
		public static bool UpdateCurrentEntryElapsedSeconds(int nValue) => default; // 0x00000001807A7320-0x00000001807A7370
		public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength) => default; // 0x00000001807A72C0-0x00000001807A7320
		public static bool CurrentEntryDidChange() => default; // 0x00000001807A67A0-0x00000001807A67F0
		public static bool QueueWillChange() => default; // 0x00000001807A6BB0-0x00000001807A6C00
		public static bool ResetQueueEntries() => default; // 0x00000001807A6D90-0x00000001807A6DE0
		public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText) => default; // 0x00000001807A7170-0x00000001807A72C0
		public static bool SetCurrentQueueEntry(int nID) => default; // 0x00000001807A6E30-0x00000001807A6E80
		public static bool QueueDidChange() => default; // 0x00000001807A6B60-0x00000001807A6BB0
		public static bool PlaylistWillChange() => default; // 0x00000001807A6B10-0x00000001807A6B60
		public static bool ResetPlaylistEntries() => default; // 0x00000001807A6D40-0x00000001807A6D90
		public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText) => default; // 0x00000001807A7020-0x00000001807A7170
		public static bool SetCurrentPlaylistEntry(int nID) => default; // 0x00000001807A6DE0-0x00000001807A6E30
		public static bool PlaylistDidChange() => default; // 0x00000001807A6AC0-0x00000001807A6B10
	}
}
