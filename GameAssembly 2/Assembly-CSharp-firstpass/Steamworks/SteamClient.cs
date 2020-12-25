/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamClient // TypeDefIndex: 6460
	{
		// Nested types
		internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 6461
		{
			// Constructors
			public MonoPInvokeCallbackAttribute() {} // 0x0000000180289A80-0x0000000180289A90
		}
	
		// Methods
		public static HSteamPipe CreateSteamPipe() => default; // 0x000000018094A650-0x000000018094A6A0
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe) => default; // 0x000000018094A4E0-0x000000018094A530
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe) => default; // 0x000000018094A580-0x000000018094A5E0
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType) {
			phSteamPipe = default;
			return default;
		} // 0x000000018094A5E0-0x000000018094A650
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser) {} // 0x000000018094C8A0-0x000000018094C900
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094C4F0-0x000000018094C630
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094AE70-0x000000018094AFB0
		public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort) {} // 0x000000018094C900-0x000000018094C960
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094AAB0-0x000000018094ABF0
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094C630-0x000000018094C760
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094B730-0x000000018094B870
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094B5F0-0x000000018094B730
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094AFB0-0x000000018094B0F0
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094C3B0-0x000000018094C4F0
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094AD30-0x000000018094AE70
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094A830-0x000000018094A970
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094BAF0-0x000000018094BC30
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094BFF0-0x000000018094C130
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094C130-0x000000018094C270
		public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094ABF0-0x000000018094AD30
		public static uint GetIPCCallCount() => default; // 0x000000018094A6A0-0x000000018094A6F0
		[MonoPInvokeCallback] // 0x00000001800D4E50-0x00000001800D4E60
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) {} // 0x000000018094C960-0x000000018094C9B0
		public static bool BShutdownIfAllPipesClosed() => default; // 0x000000018094A530-0x000000018094A580
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094B230-0x000000018094B370
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094A970-0x000000018094AAB0
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094C270-0x000000018094C3B0
		public static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094A6F0-0x000000018094A830
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094B9B0-0x000000018094BAF0
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094B870-0x000000018094B9B0
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094B0F0-0x000000018094B230
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094B4B0-0x000000018094B5F0
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094C760-0x000000018094C8A0
		public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094BC30-0x000000018094BD70
		public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094B370-0x000000018094B4B0
		public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094BD70-0x000000018094BEB0
		public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion) => default; // 0x000000018094BEB0-0x000000018094BFF0
	}
}
