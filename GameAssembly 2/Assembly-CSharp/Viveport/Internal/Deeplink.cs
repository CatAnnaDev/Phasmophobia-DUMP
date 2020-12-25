/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport.Internal
{
	internal class Deeplink // TypeDefIndex: 7402
	{
		// Constructors
		static Deeplink() {} // 0x0000000181B49750-0x0000000181B497A0
		public Deeplink() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		internal static extern void IsReady(StatusCallback IsReadyCallback); // 0x0000000181B496D0-0x0000000181B49750
		internal static extern void IsReady_64(StatusCallback IsReadyCallback); // 0x0000000181B49380-0x0000000181B49400
		internal static extern void GoToApp(StatusCallback2 GoToAppCallback, string ViveportId, string LaunchData); // 0x0000000181B48720-0x0000000181B487E0
		internal static extern void GoToApp_64(StatusCallback2 GoToAppCallback, string ViveportId, string LaunchData); // 0x0000000181B484A0-0x0000000181B48560
		internal static extern void GoToApp(StatusCallback2 GoToAppCallback, string ViveportId, string LaunchData, string branchName); // 0x0000000181B48640-0x0000000181B48720
		internal static extern void GoToApp_64(StatusCallback2 GoToAppCallback, string ViveportId, string LaunchData, string branchName); // 0x0000000181B48560-0x0000000181B48640
		internal static extern void GoToStore(StatusCallback2 GetSessionTokenCallback, string ViveportId); // 0x0000000181B48F90-0x0000000181B49030
		internal static extern void GoToStore_64(StatusCallback2 GetSessionTokenCallback, string ViveportId); // 0x0000000181B48EF0-0x0000000181B48F90
		internal static extern void GoToAppOrGoToStore(StatusCallback2 GoToAppCallback, string ViveportId, string LaunchData); // 0x0000000181B48040-0x0000000181B48100
		internal static extern void GoToAppOrGoToStore_64(StatusCallback2 GoToAppCallback, string ViveportId, string LaunchData); // 0x0000000181B47F80-0x0000000181B48040
		internal static extern int GetAppLaunchData(StringBuilder userId, int size); // 0x0000000181B47E10-0x0000000181B47EC0
		internal static extern int GetAppLaunchData_64(StringBuilder userId, int size); // 0x0000000181B47BA0-0x0000000181B47C50
	}
}
