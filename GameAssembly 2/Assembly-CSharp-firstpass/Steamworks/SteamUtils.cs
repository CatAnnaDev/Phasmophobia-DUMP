/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamUtils // TypeDefIndex: 6495
	{
		// Methods
		public static uint GetSecondsSinceAppActive() => default; // 0x000000018083F7D0-0x000000018083F820
		public static uint GetSecondsSinceComputerActive() => default; // 0x000000018083F820-0x000000018083F870
		public static EUniverse GetConnectedUniverse() => default; // 0x000000018083F3F0-0x000000018083F440
		public static uint GetServerRealTime() => default; // 0x000000018083F870-0x000000018083F8C0
		public static string GetIPCountry() => default; // 0x000000018083F630-0x000000018083F680
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) {
			pnWidth = default;
			pnHeight = default;
			return default;
		} // 0x000000018083F750-0x000000018083F7D0
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize) => default; // 0x000000018083F6D0-0x000000018083F750
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort) {
			unIP = default;
			usPort = default;
			return default;
		} // 0x000000018083F390-0x000000018083F3F0
		public static byte GetCurrentBatteryPower() => default; // 0x000000018083F440-0x000000018083F490
		public static AppId_t GetAppID() => default; // 0x000000018083F300-0x000000018083F390
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition) {} // 0x000000018083FBB0-0x000000018083FC00
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed) {
			pbFailed = default;
			return default;
		} // 0x000000018083F960-0x000000018083F9C0
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall) => default; // 0x000000018083F220-0x000000018083F270
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) {
			pbFailed = default;
			return default;
		} // 0x000000018083F270-0x000000018083F300
		public static uint GetIPCCallCount() => default; // 0x000000018083F5E0-0x000000018083F630
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) {} // 0x000000018083FC50-0x000000018083FCA0
		public static bool IsOverlayEnabled() => default; // 0x000000018083F9C0-0x000000018083FA10
		public static bool BOverlayNeedsPresent() => default; // 0x000000018083EEA0-0x000000018083EEF0
		public static SteamAPICall_t CheckFileSignature(string szFileName) => default; // 0x000000018083EEF0-0x000000018083F050
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText) => default; // 0x000000018083FCA0-0x000000018083FE80
		public static uint GetEnteredGamepadTextLength() => default; // 0x000000018083F590-0x000000018083F5E0
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText) {
			pchText = default;
			return default;
		} // 0x000000018083F490-0x000000018083F590
		public static string GetSteamUILanguage() => default; // 0x000000018083F8C0-0x000000018083F910
		public static bool IsSteamRunningInVR() => default; // 0x000000018083FAB0-0x000000018083FB00
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) {} // 0x000000018083FB50-0x000000018083FBB0
		public static bool IsSteamInBigPictureMode() => default; // 0x000000018083FA60-0x000000018083FAB0
		public static void StartVRDashboard() {} // 0x000000018083FE80-0x000000018083FED0
		public static bool IsVRHeadsetStreamingEnabled() => default; // 0x000000018083FB00-0x000000018083FB50
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled) {} // 0x000000018083FC00-0x000000018083FC50
		public static bool IsSteamChinaLauncher() => default; // 0x000000018083FA10-0x000000018083FA60
		public static bool InitFilterText() => default; // 0x000000018083F910-0x000000018083F960
		public static int FilterText(out string pchOutFilteredText, uint nByteSizeOutFilteredText, string pchInputMessage, bool bLegalOnly) {
			pchOutFilteredText = default;
			return default;
		} // 0x000000018083F050-0x000000018083F220
		public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol) => default; // 0x000000018083F680-0x000000018083F6D0
	}
}
