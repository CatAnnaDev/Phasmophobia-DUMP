/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport.Internal
{
	internal class Api // TypeDefIndex: 7395
	{
		// Constructors
		static Api() {} // 0x0000000181B455B0-0x0000000181B455F0
		public Api() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		internal static extern void GetLicense(GetLicenseCallback callback, string appId, string appKey); // 0x0000000181B44F90-0x0000000181B45050
		internal static extern void GetLicense_64(GetLicenseCallback callback, string appId, string appKey); // 0x0000000181B44ED0-0x0000000181B44F90
		internal static extern int Init(StatusCallback initCallback, string appId); // 0x0000000181B450F0-0x0000000181B45190
		internal static extern int Init_64(StatusCallback initCallback, string appId); // 0x0000000181B45050-0x0000000181B450F0
		internal static extern int Shutdown(StatusCallback initCallback); // 0x0000000181B45450-0x0000000181B454D0
		internal static extern int Shutdown_64(StatusCallback initCallback); // 0x0000000181B453D0-0x0000000181B45450
		internal static extern IntPtr Version(); // 0x0000000181B45540-0x0000000181B455B0
		internal static extern IntPtr Version_64(); // 0x0000000181B454D0-0x0000000181B45540
		internal static extern void QueryRuntimeMode(QueryRuntimeModeCallback queryRunTimeCallback); // 0x0000000181B45350-0x0000000181B453D0
		internal static extern void QueryRuntimeMode_64(QueryRuntimeModeCallback queryRunTimeCallback); // 0x0000000181B452D0-0x0000000181B45350
		internal static extern IntPtr LoadLibrary(string dllToLoad); // 0x0000000181B45230-0x0000000181B452D0
		internal static void LoadLibraryManually(string dllName) {} // 0x0000000181B45190-0x0000000181B45230
	}
}
