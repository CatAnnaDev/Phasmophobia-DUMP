/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamNetworkingUtils // TypeDefIndex: 6487
	{
		// Methods
		public static IntPtr AllocateMessage(int cbAllocateBuffer) => default; // 0x00000001807A9250-0x00000001807A92A0
		public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails) {
			pDetails = default;
			return default;
		} // 0x00000001807A9820-0x00000001807A9870
		public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result) {
			result = default;
			return default;
		} // 0x00000001807A9670-0x00000001807A96C0
		public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) => default; // 0x00000001807A93F0-0x00000001807A9450
		public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation) => default; // 0x00000001807A9450-0x00000001807A94A0
		public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize) {
			pszBuf = default;
		} // 0x00000001807A9300-0x00000001807A93F0
		public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result) {
			result = default;
			return default;
		} // 0x00000001807A9870-0x00000001807A99B0
		public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) => default; // 0x00000001807A92A0-0x00000001807A9300
		public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) {
			pViaRelayPoP = default;
			return default;
		} // 0x00000001807A97C0-0x00000001807A9820
		public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) => default; // 0x00000001807A95D0-0x00000001807A9620
		public static int GetPOPCount() => default; // 0x00000001807A9710-0x00000001807A9760
		public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz) {
			list = default;
			return default;
		} // 0x00000001807A9760-0x00000001807A97C0
		public static SteamNetworkingMicroseconds GetLocalTimestamp() => default; // 0x00000001807A96C0-0x00000001807A9710
		public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) {} // 0x00000001807A9A40-0x00000001807A9AA0
		public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) => default; // 0x00000001807A99B0-0x00000001807A9A40
		public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, out ulong cbResult) {
			pOutDataType = default;
			cbResult = default;
			return default;
		} // 0x00000001807A9530-0x00000001807A95D0
		public static bool GetConfigValueInfo(ESteamNetworkingConfigValue eValue, IntPtr pOutName, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope, out ESteamNetworkingConfigValue pOutNextValue) {
			pOutDataType = default;
			pOutScope = default;
			pOutNextValue = default;
			return default;
		} // 0x00000001807A94A0-0x00000001807A9530
		public static ESteamNetworkingConfigValue GetFirstConfigValue() => default; // 0x00000001807A9620-0x00000001807A9670
		public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort) {
			buf = default;
		} // 0x00000001807A9BE0-0x00000001807A9CE0
		public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr) {
			pAddr = default;
			return default;
		} // 0x00000001807A9AA0-0x00000001807A9BE0
		public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf) {
			buf = default;
		} // 0x00000001807A9E20-0x00000001807A9F10
		public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr) {
			pIdentity = default;
			return default;
		} // 0x00000001807A9CE0-0x00000001807A9E20
	}
}
