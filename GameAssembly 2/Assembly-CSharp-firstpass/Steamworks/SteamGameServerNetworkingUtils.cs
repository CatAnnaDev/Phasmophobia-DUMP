/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameServerNetworkingUtils // TypeDefIndex: 6471
	{
		// Methods
		public static IntPtr AllocateMessage(int cbAllocateBuffer) => default; // 0x00000001809585E0-0x0000000180958630
		public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails) {
			pDetails = default;
			return default;
		} // 0x0000000180958BB0-0x0000000180958C00
		public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result) {
			result = default;
			return default;
		} // 0x0000000180958A00-0x0000000180958A50
		public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) => default; // 0x0000000180958780-0x00000001809587E0
		public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation) => default; // 0x00000001809587E0-0x0000000180958830
		public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize) {
			pszBuf = default;
		} // 0x0000000180958690-0x0000000180958780
		public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result) {
			result = default;
			return default;
		} // 0x0000000180958C00-0x0000000180958D40
		public static bool CheckPingDataUpToDate(float flMaxAgeSeconds) => default; // 0x0000000180958630-0x0000000180958690
		public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) {
			pViaRelayPoP = default;
			return default;
		} // 0x0000000180958B50-0x0000000180958BB0
		public static int GetDirectPingToPOP(SteamNetworkingPOPID popID) => default; // 0x0000000180958960-0x00000001809589B0
		public static int GetPOPCount() => default; // 0x0000000180958AA0-0x0000000180958AF0
		public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz) {
			list = default;
			return default;
		} // 0x0000000180958AF0-0x0000000180958B50
		public static SteamNetworkingMicroseconds GetLocalTimestamp() => default; // 0x0000000180958A50-0x0000000180958AA0
		public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) {} // 0x0000000180958DD0-0x0000000180958E30
		public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) => default; // 0x0000000180958D40-0x0000000180958DD0
		public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, out ulong cbResult) {
			pOutDataType = default;
			cbResult = default;
			return default;
		} // 0x00000001809588C0-0x0000000180958960
		public static bool GetConfigValueInfo(ESteamNetworkingConfigValue eValue, IntPtr pOutName, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope, out ESteamNetworkingConfigValue pOutNextValue) {
			pOutDataType = default;
			pOutScope = default;
			pOutNextValue = default;
			return default;
		} // 0x0000000180958830-0x00000001809588C0
		public static ESteamNetworkingConfigValue GetFirstConfigValue() => default; // 0x00000001809589B0-0x0000000180958A00
		public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort) {
			buf = default;
		} // 0x0000000180958F70-0x0000000180959070
		public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr) {
			pAddr = default;
			return default;
		} // 0x0000000180958E30-0x0000000180958F70
		public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf) {
			buf = default;
		} // 0x00000001809591B0-0x00000001809592A0
		public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr) {
			pIdentity = default;
			return default;
		} // 0x0000000180959070-0x00000001809591B0
	}
}
