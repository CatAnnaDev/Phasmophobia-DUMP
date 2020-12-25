/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public class WebFlags // TypeDefIndex: 4399
	{
		// Fields
		public static readonly WebFlags Default; // 0x00
		public byte WebhookFlags; // 0x10
		public const byte HttpForwardConst = 1; // Metadata: 0x0064E03E
		public const byte SendAuthCookieConst = 2; // Metadata: 0x0064E03F
		public const byte SendSyncConst = 4; // Metadata: 0x0064E040
		public const byte SendStateConst = 8; // Metadata: 0x0064E041
	
		// Properties
		public bool HttpForward { get => default; set {} } // 0x000000018036E560-0x000000018036E570 0x000000018074EDA0-0x000000018074EDD0
		public bool SendAuthCookie { get => default; set {} } // 0x000000018074ED70-0x000000018074ED80 0x000000018074EDD0-0x000000018074EE00
		public bool SendSync { get => default; set {} } // 0x000000018074ED90-0x000000018074EDA0 0x000000018074EE30-0x000000018074EE60
		public bool SendState { get => default; set {} } // 0x000000018074ED80-0x000000018074ED90 0x000000018074EE00-0x000000018074EE30
	
		// Constructors
		public WebFlags() {} // Dummy constructor
		public WebFlags(byte webhookFlags) {} // 0x000000018070F560-0x000000018070F590
		static WebFlags() {} // 0x000000018074ED10-0x000000018074ED70
	}
}
