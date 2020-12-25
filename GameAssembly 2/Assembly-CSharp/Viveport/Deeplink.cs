/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using Viveport.Internal;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport
{
	public class Deeplink // TypeDefIndex: 7377
	{
		// Fields
		private const int MaxIdLength = 256; // Metadata: 0x0065368A
		private static StatusCallback isReadyIl2cppCallback; // 0x00
		private static StatusCallback2 goToAppIl2cppCallback; // 0x08
		private static StatusCallback2 goToAppWithBranchNameIl2cppCallback; // 0x10
		private static StatusCallback2 goToStoreIl2cppCallback; // 0x18
		private static StatusCallback2 goToAppOrGoToStoreIl2cppCallback; // 0x20
	
		// Constructors
		public Deeplink() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		// [MonoPInvokeCallback] // 0x0000000180130B70-0x0000000180130BC0
		private static void IsReadyIl2cppCallback(int errorCode) {} // 0x0000000181B49330-0x0000000181B49380
		public static void IsReady(StatusCallback callback) {} // 0x0000000181B49400-0x0000000181B496D0
		// [MonoPInvokeCallback] // 0x0000000180130CF0-0x0000000180130D40
		private static void GoToAppIl2cppCallback(int errorCode, string message) {} // 0x0000000181B47EC0-0x0000000181B47F20
		public static void GoToApp(StatusCallback2 callback, string viveportId, string launchData) {} // 0x0000000181B487E0-0x0000000181B48B20
		// [MonoPInvokeCallback] // 0x0000000180131620-0x0000000180131670
		private static void GoToAppWithBranchNameIl2cppCallback(int errorCode, string message) {} // 0x0000000181B48440-0x0000000181B484A0
		public static void GoToApp(StatusCallback2 callback, string viveportId, string launchData, string branchName) {} // 0x0000000181B48B20-0x0000000181B48E90
		// [MonoPInvokeCallback] // 0x0000000180131710-0x0000000180131760
		private static void GoToStoreIl2cppCallback(int errorCode, string message) {} // 0x0000000181B48E90-0x0000000181B48EF0
		public static void GoToStore(StatusCallback2 callback, string viveportId = "" /* Metadata: 0x00653686 */) {} // 0x0000000181B49030-0x0000000181B49330
		// [MonoPInvokeCallback] // 0x0000000180131850-0x00000001801318A0
		private static void GoToAppOrGoToStoreIl2cppCallback(int errorCode, string message) {} // 0x0000000181B47F20-0x0000000181B47F80
		public static void GoToAppOrGoToStore(StatusCallback2 callback, string viveportId, string launchData) {} // 0x0000000181B48100-0x0000000181B48440
		public static string GetAppLaunchData() => default; // 0x0000000181B47C50-0x0000000181B47E10
	}
}
