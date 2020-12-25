/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public struct IVRNotifications // TypeDefIndex: 8171
	{
		// Fields
		internal _CreateNotification CreateNotification; // 0x00
		internal _RemoveNotification RemoveNotification; // 0x08
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId); // TypeDefIndex: 8172; 0x0000000181E648F0-0x0000000181E64D80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRNotificationError _RemoveNotification(uint notificationId); // TypeDefIndex: 8173; 0x0000000181AA8BF0-0x0000000181AA8ED0
	}
}
