/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamHTMLSurface // TypeDefIndex: 6475
	{
		// Methods
		public static bool Init() => default; // 0x000000018079EA10-0x000000018079EA60
		public static bool Shutdown() => default; // 0x000000018079F710-0x000000018079F760
		public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS) => default; // 0x000000018079E440-0x000000018079E610
		public static void RemoveBrowser(HHTMLBrowser unBrowserHandle) {} // 0x000000018079F0F0-0x000000018079F140
		public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData) {} // 0x000000018079EC50-0x000000018079EE00
		public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) {} // 0x000000018079F630-0x000000018079F6B0
		public static void StopLoad(HHTMLBrowser unBrowserHandle) {} // 0x000000018079F7B0-0x000000018079F800
		public static void Reload(HHTMLBrowser unBrowserHandle) {} // 0x000000018079F0A0-0x000000018079F0F0
		public static void GoBack(HHTMLBrowser unBrowserHandle) {} // 0x000000018079E970-0x000000018079E9C0
		public static void GoForward(HHTMLBrowser unBrowserHandle) {} // 0x000000018079E9C0-0x000000018079EA10
		public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue) {} // 0x000000018079E1E0-0x000000018079E390
		public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript) {} // 0x000000018079E610-0x000000018079E740
		public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) {} // 0x000000018079EF40-0x000000018079EFA0
		public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) {} // 0x000000018079EE60-0x000000018079EEC0
		public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) {} // 0x000000018079EE00-0x000000018079EE60
		public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y) {} // 0x000000018079EEC0-0x000000018079EF40
		public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta) {} // 0x000000018079EFA0-0x000000018079F000
		public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey = false /* Metadata: 0x00652CB3 */) {} // 0x000000018079EB40-0x000000018079EBD0
		public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers) {} // 0x000000018079EBD0-0x000000018079EC50
		public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers) {} // 0x000000018079EAC0-0x000000018079EB40
		public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) {} // 0x000000018079F4E0-0x000000018079F540
		public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) {} // 0x000000018079F6B0-0x000000018079F710
		public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) {} // 0x000000018079F540-0x000000018079F5A0
		public static void ViewSource(HHTMLBrowser unBrowserHandle) {} // 0x000000018079F800-0x000000018079F850
		public static void CopyToClipboard(HHTMLBrowser unBrowserHandle) {} // 0x000000018079E3F0-0x000000018079E440
		public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle) {} // 0x000000018079F050-0x000000018079F0A0
		public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse) {} // 0x000000018079E7A0-0x000000018079E8F0
		public static void StopFind(HHTMLBrowser unBrowserHandle) {} // 0x000000018079F760-0x000000018079F7B0
		public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y) {} // 0x000000018079E8F0-0x000000018079E970
		public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/" /* Metadata: 0x00652CB4 */, uint nExpires = 0 /* Metadata: 0x00652CB9 */, bool bSecure = false /* Metadata: 0x00652CBD */, bool bHTTPOnly = false /* Metadata: 0x00652CBE */) {} // 0x000000018079F1A0-0x000000018079F480
		public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) {} // 0x000000018079F5A0-0x000000018079F630
		public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode) {} // 0x000000018079F140-0x000000018079F1A0
		public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling) {} // 0x000000018079F480-0x000000018079F4E0
		public static void OpenDeveloperTools(HHTMLBrowser unBrowserHandle) {} // 0x000000018079F000-0x000000018079F050
		public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed) {} // 0x000000018079E390-0x000000018079E3F0
		public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult) {} // 0x000000018079EA60-0x000000018079EAC0
		public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles) {} // 0x000000018079E740-0x000000018079E7A0
	}
}
