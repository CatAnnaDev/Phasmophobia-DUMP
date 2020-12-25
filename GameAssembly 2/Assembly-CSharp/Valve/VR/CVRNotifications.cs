/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class CVRNotifications // TypeDefIndex: 8220
	{
		// Fields
		private IVRNotifications FnTable; // 0x10
	
		// Constructors
		public CVRNotifications() {} // Dummy constructor
		internal CVRNotifications(IntPtr pInterface) {} // 0x00000001811DDF10-0x00000001811DE000
	
		// Methods
		public EVRNotificationError CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId) => default; // 0x00000001811DDEB0-0x00000001811DDEF0
		public EVRNotificationError RemoveNotification(uint notificationId) => default; // 0x00000001811DDEF0-0x00000001811DDF10
	}
}
