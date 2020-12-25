/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public class RoomOptions // TypeDefIndex: 4378
	{
		// Fields
		private bool isVisible; // 0x10
		private bool isOpen; // 0x11
		public byte MaxPlayers; // 0x12
		public int PlayerTtl; // 0x14
		public int EmptyRoomTtl; // 0x18
		private bool cleanupCacheOnLeave; // 0x1C
		public Hashtable CustomRoomProperties; // 0x20
		public string[] CustomRoomPropertiesForLobby; // 0x28
		public string[] Plugins; // 0x30
		private bool broadcastPropsChangeToAll; // 0x3B
	
		// Properties
		public bool IsVisible { get => default; set {} } // 0x00000001803628F0-0x0000000180362930 0x00000001802F6FA0-0x00000001802F6FB0
		public bool IsOpen { get => default; set {} } // 0x00000001805DB450-0x00000001805DB460 0x00000001805DB460-0x00000001805DB470
		public bool CleanupCacheOnLeave { get => default; set {} } // 0x0000000180568740-0x0000000180568750 0x000000018062E0A0-0x000000018062E0B0
		public bool SuppressRoomEvents { get; set; } // 0x00000001803CD700-0x00000001803CD710 0x00000001803CD180-0x00000001803CD190
		public bool PublishUserId { get; set; } // 0x00000001803CD720-0x00000001803CD730 0x0000000180749890-0x00000001807498A0
		public bool DeleteNullProperties { get; set; } // 0x00000001803CD710-0x00000001803CD720 0x00000001803CD730-0x00000001803CD740
		public bool BroadcastPropsChangeToAll { get => default; set {} } // 0x0000000180749870-0x0000000180749880 0x0000000180749880-0x0000000180749890
	
		// Constructors
		public RoomOptions() {} // 0x0000000180749810-0x0000000180749870
	}
}
