/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamHTTP // TypeDefIndex: 6476
	{
		// Methods
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL) => default; // 0x000000018079F8F0-0x000000018079FA50
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue) => default; // 0x00000001807A03E0-0x00000001807A0440
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds) => default; // 0x00000001807A0820-0x00000001807A0880
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue) => default; // 0x00000001807A0660-0x00000001807A0820
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue) => default; // 0x00000001807A04A0-0x00000001807A0660
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) {
			pCallHandle = default;
			return default;
		} // 0x00000001807A00D0-0x00000001807A0130
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) {
			pCallHandle = default;
			return default;
		} // 0x00000001807A0070-0x00000001807A00D0
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest) => default; // 0x000000018079FA50-0x000000018079FAA0
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest) => default; // 0x000000018079FF80-0x000000018079FFD0
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize) {
			unResponseHeaderSize = default;
			return default;
		} // 0x000000018079FC40-0x000000018079FD90
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize) => default; // 0x000000018079FD90-0x000000018079FEF0
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize) {
			unBodySize = default;
			return default;
		} // 0x000000018079FBE0-0x000000018079FC40
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize) => default; // 0x000000018079FB60-0x000000018079FBE0
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize) => default; // 0x000000018079FEF0-0x000000018079FF80
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest) => default; // 0x00000001807A0020-0x00000001807A0070
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut) {
			pflPercentOut = default;
			return default;
		} // 0x000000018079FAA0-0x000000018079FB00
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen) => default; // 0x00000001807A0880-0x00000001807A09E0
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify) => default; // 0x000000018079F850-0x000000018079F8F0
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer) => default; // 0x000000018079FFD0-0x00000001807A0020
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie) => default; // 0x00000001807A0130-0x00000001807A0380
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) => default; // 0x00000001807A0440-0x00000001807A04A0
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo) => default; // 0x00000001807A0A40-0x00000001807A10C0
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) => default; // 0x00000001807A09E0-0x00000001807A0A40
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds) => default; // 0x00000001807A0380-0x00000001807A03E0
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut) {
			pbWasTimedOut = default;
			return default;
		} // 0x000000018079FB00-0x000000018079FB60
	}
}
