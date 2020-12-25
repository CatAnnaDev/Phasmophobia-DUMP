/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameServerUtils // TypeDefIndex: 6474
	{
		// Methods
		public static uint GetSecondsSinceAppActive() => default; // 0x000000018079DAE0-0x000000018079DB30
		public static uint GetSecondsSinceComputerActive() => default; // 0x000000018079DB30-0x000000018079DB80
		public static EUniverse GetConnectedUniverse() => default; // 0x000000018079D700-0x000000018079D750
		public static uint GetServerRealTime() => default; // 0x000000018079DB80-0x000000018079DBD0
		public static string GetIPCountry() => default; // 0x000000018079D940-0x000000018079D990
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) {
			pnWidth = default;
			pnHeight = default;
			return default;
		} // 0x000000018079DA60-0x000000018079DAE0
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize) => default; // 0x000000018079D9E0-0x000000018079DA60
		public static bool GetCSERIPPort(out uint unIP, out ushort usPort) {
			unIP = default;
			usPort = default;
			return default;
		} // 0x000000018079D6A0-0x000000018079D700
		public static byte GetCurrentBatteryPower() => default; // 0x000000018079D750-0x000000018079D7A0
		public static AppId_t GetAppID() => default; // 0x000000018079D610-0x000000018079D6A0
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition) {} // 0x000000018079DEC0-0x000000018079DF10
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed) {
			pbFailed = default;
			return default;
		} // 0x000000018079DC70-0x000000018079DCD0
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall) => default; // 0x000000018079D530-0x000000018079D580
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) {
			pbFailed = default;
			return default;
		} // 0x000000018079D580-0x000000018079D610
		public static uint GetIPCCallCount() => default; // 0x000000018079D8F0-0x000000018079D940
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) {} // 0x000000018079DF60-0x000000018079DFB0
		public static bool IsOverlayEnabled() => default; // 0x000000018079DCD0-0x000000018079DD20
		public static bool BOverlayNeedsPresent() => default; // 0x000000018079D1B0-0x000000018079D200
		public static SteamAPICall_t CheckFileSignature(string szFileName) => default; // 0x000000018079D200-0x000000018079D360
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText) => default; // 0x000000018079DFB0-0x000000018079E190
		public static uint GetEnteredGamepadTextLength() => default; // 0x000000018079D8A0-0x000000018079D8F0
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText) {
			pchText = default;
			return default;
		} // 0x000000018079D7A0-0x000000018079D8A0
		public static string GetSteamUILanguage() => default; // 0x000000018079DBD0-0x000000018079DC20
		public static bool IsSteamRunningInVR() => default; // 0x000000018079DDC0-0x000000018079DE10
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) {} // 0x000000018079DE60-0x000000018079DEC0
		public static bool IsSteamInBigPictureMode() => default; // 0x000000018079DD70-0x000000018079DDC0
		public static void StartVRDashboard() {} // 0x000000018079E190-0x000000018079E1E0
		public static bool IsVRHeadsetStreamingEnabled() => default; // 0x000000018079DE10-0x000000018079DE60
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled) {} // 0x000000018079DF10-0x000000018079DF60
		public static bool IsSteamChinaLauncher() => default; // 0x000000018079DD20-0x000000018079DD70
		public static bool InitFilterText() => default; // 0x000000018079DC20-0x000000018079DC70
		public static int FilterText(out string pchOutFilteredText, uint nByteSizeOutFilteredText, string pchInputMessage, bool bLegalOnly) {
			pchOutFilteredText = default;
			return default;
		} // 0x000000018079D360-0x000000018079D530
		public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol) => default; // 0x000000018079D990-0x000000018079D9E0
	}
}
