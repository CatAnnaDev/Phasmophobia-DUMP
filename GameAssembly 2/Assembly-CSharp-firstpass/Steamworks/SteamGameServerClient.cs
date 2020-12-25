/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameServerClient // TypeDefIndex: 6466
	{
		// Methods
		public static HSteamPipe CreateSteamPipe() => default; // 0x0000000180951EC0-0x0000000180951F10
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe) => default; // 0x0000000180951D50-0x0000000180951DA0
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe) => default; // 0x0000000180951DF0-0x0000000180951E50
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType) {
			phSteamPipe = default;
			return default;
		} // 0x0000000180951E50-0x0000000180951EC0
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser) {} // 0x0000000180954110-0x0000000180954170
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180953D60-0x0000000180953EA0
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x00000001809526E0-0x0000000180952820
		public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort) {} // 0x0000000180954170-0x00000001809541D0
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180952320-0x0000000180952460
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180953EA0-0x0000000180953FD0
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180952FA0-0x00000001809530E0
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180952E60-0x0000000180952FA0
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180952820-0x0000000180952960
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180953C20-0x0000000180953D60
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x00000001809525A0-0x00000001809526E0
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x00000001809520A0-0x00000001809521E0
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180953360-0x00000001809534A0
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180953860-0x00000001809539A0
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x00000001809539A0-0x0000000180953AE0
		public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180952460-0x00000001809525A0
		public static uint GetIPCCallCount() => default; // 0x0000000180951F10-0x0000000180951F60
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) {} // 0x00000001809541D0-0x0000000180954220
		public static bool BShutdownIfAllPipesClosed() => default; // 0x0000000180951DA0-0x0000000180951DF0
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180952AA0-0x0000000180952BE0
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x00000001809521E0-0x0000000180952320
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180953AE0-0x0000000180953C20
		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180951F60-0x00000001809520A0
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180953220-0x0000000180953360
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x00000001809530E0-0x0000000180953220
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180952960-0x0000000180952AA0
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180952D20-0x0000000180952E60
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180953FD0-0x0000000180954110
		public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x00000001809534A0-0x00000001809535E0
		public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180952BE0-0x0000000180952D20
		public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x00000001809535E0-0x0000000180953720
		public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x0000000180953720-0x0000000180953860
	}
}
