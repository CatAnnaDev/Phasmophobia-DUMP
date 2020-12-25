/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamGameServerHTTP // TypeDefIndex: 6467
	{
		// Methods
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL) => default; // 0x00000001809542C0-0x0000000180954420
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) => default; // 0x0000000180954DB0-0x0000000180954E10
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) => default; // 0x00000001809551F0-0x0000000180955250
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue) => default; // 0x0000000180955030-0x00000001809551F0
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue) => default; // 0x0000000180954E70-0x0000000180955030
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) {
			pCallHandle = default;
			return default;
		} // 0x0000000180954AA0-0x0000000180954B00
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) {
			pCallHandle = default;
			return default;
		} // 0x0000000180954A40-0x0000000180954AA0
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) => default; // 0x0000000180954420-0x0000000180954470
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) => default; // 0x0000000180954950-0x00000001809549A0
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize) {
			unResponseHeaderSize = default;
			return default;
		} // 0x0000000180954610-0x0000000180954760
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize) => default; // 0x0000000180954760-0x00000001809548C0
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize) {
			unBodySize = default;
			return default;
		} // 0x00000001809545B0-0x0000000180954610
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize) => default; // 0x0000000180954530-0x00000001809545B0
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize) => default; // 0x00000001809548C0-0x0000000180954950
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) => default; // 0x00000001809549F0-0x0000000180954A40
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut) {
			pflPercentOut = default;
			return default;
		} // 0x0000000180954470-0x00000001809544D0
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen) => default; // 0x0000000180955250-0x00000001809553B0
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) => default; // 0x0000000180954220-0x00000001809542C0
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) => default; // 0x00000001809549A0-0x00000001809549F0
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie) => default; // 0x0000000180954B00-0x0000000180954D50
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) => default; // 0x0000000180954E10-0x0000000180954E70
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo) => default; // 0x0000000180955410-0x0000000180955550
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) => default; // 0x00000001809553B0-0x0000000180955410
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) => default; // 0x0000000180954D50-0x0000000180954DB0
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut) {
			pbWasTimedOut = default;
			return default;
		} // 0x00000001809544D0-0x0000000180954530
	}
}
