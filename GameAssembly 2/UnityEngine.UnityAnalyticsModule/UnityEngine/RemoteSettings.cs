/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 34: UnityEngine.UnityAnalyticsModule.dll - Assembly: UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4189-4201

namespace UnityEngine
{
	// [NativeHeader] // 0x000000018013BA80-0x000000018013BAE0
	// [NativeHeader] // 0x000000018013BA80-0x000000018013BAE0
	public static class RemoteSettings // TypeDefIndex: 4190
	{
		// Nested types
		public delegate void UpdatedEventHandler(); // TypeDefIndex: 4191; 0x00000001802D1BD0-0x00000001802D1D60
	
		// Methods
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) {} // 0x0000000180AF7C50-0x0000000180AF7E30
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void RemoteSettingsBeforeFetchFromServer() {} // 0x0000000180AF7B80-0x0000000180AF7BD0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) {} // 0x0000000180AF7BD0-0x0000000180AF7C50
		public static void ForceUpdate() {} // 0x0000000180AF7B50-0x0000000180AF7B80
	}
}
