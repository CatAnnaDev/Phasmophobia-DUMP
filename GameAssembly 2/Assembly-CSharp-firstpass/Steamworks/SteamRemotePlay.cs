/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamRemotePlay // TypeDefIndex: 6489
	{
		// Methods
		public static uint GetSessionCount() => default; // 0x00000001807AB4D0-0x00000001807AB520
		public static RemotePlaySessionID_t GetSessionID(int iSessionIndex) => default; // 0x00000001807AB520-0x00000001807AB580
		public static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID) => default; // 0x00000001807AB580-0x00000001807AB620
		public static string GetSessionClientName(RemotePlaySessionID_t unSessionID) => default; // 0x00000001807AB470-0x00000001807AB4D0
		public static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID) => default; // 0x00000001807AB420-0x00000001807AB470
		public static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) {
			pnResolutionX = default;
			pnResolutionY = default;
			return default;
		} // 0x00000001807AB350-0x00000001807AB3D0
		public static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend) => default; // 0x00000001807AB3D0-0x00000001807AB420
	}
}
