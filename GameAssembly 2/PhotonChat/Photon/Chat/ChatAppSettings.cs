/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 55: PhotonChat.dll - Assembly: PhotonChat, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5583-5604

namespace Photon.Chat
{
	[Serializable]
	public class ChatAppSettings // TypeDefIndex: 5586
	{
		// Fields
		public string AppId; // 0x10
		public string AppVersion; // 0x18
		public string FixedRegion; // 0x20
		public string Server; // 0x28
		public ConnectionProtocol Protocol; // 0x30
		public DebugLevel NetworkLogging; // 0x31
	
		// Properties
		public bool IsDefaultNameServer { get => default; } // 0x000000018204F900-0x000000018204F910 
	
		// Constructors
		public ChatAppSettings() {} // 0x000000018204F8F0-0x000000018204F900
	}
}
