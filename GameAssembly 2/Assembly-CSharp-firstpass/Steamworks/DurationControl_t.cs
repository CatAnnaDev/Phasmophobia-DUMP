/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	// [CallbackIdentity] // 0x0000000180125BC0-0x0000000180125BE0
	public struct DurationControl_t // TypeDefIndex: 6317
	{
		// Fields
		public const int k_iCallback = 167; // Metadata: 0x00650E5F
		public EResult m_eResult; // 0x00
		public AppId_t m_appid; // 0x04
		public bool m_bApplicable; // 0x08
		public int m_csecsLast5h; // 0x0C
		public EDurationControlProgress m_progress; // 0x10
		public EDurationControlNotification m_notification; // 0x14
		public int m_csecsToday; // 0x18
		public int m_csecsRemaining; // 0x1C
	}
}
