/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public static class SteamAppList // TypeDefIndex: 6458
	{
		// Methods
		public static uint GetNumInstalledApps() => default; // 0x0000000180949620-0x0000000180949670
		public static uint GetInstalledApps(AppId_t[] pvecAppID, uint unMaxAppIDs) => default; // 0x00000001809495C0-0x0000000180949620
		public static int GetAppName(AppId_t nAppID, out string pchName, int cchNameMax) {
			pchName = default;
			return default;
		} // 0x00000001809494A0-0x00000001809495C0
		public static int GetAppInstallDir(AppId_t nAppID, out string pchDirectory, int cchNameMax) {
			pchDirectory = default;
			return default;
		} // 0x0000000180949380-0x00000001809494A0
		public static int GetAppBuildId(AppId_t nAppID) => default; // 0x0000000180949330-0x0000000180949380
	}
}
