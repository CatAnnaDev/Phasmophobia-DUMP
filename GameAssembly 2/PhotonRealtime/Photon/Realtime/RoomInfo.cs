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
	public class RoomInfo // TypeDefIndex: 4396
	{
		// Fields
		public bool RemovedFromList; // 0x10
		private Hashtable customProperties; // 0x18
		protected byte maxPlayers; // 0x20
		protected int emptyRoomTtl; // 0x24
		protected int playerTtl; // 0x28
		protected string[] expectedUsers; // 0x30
		protected bool isOpen; // 0x38
		protected bool isVisible; // 0x39
		protected bool autoCleanUp; // 0x3A
		protected string name; // 0x40
		public int masterClientId; // 0x48
		protected string[] propertiesListedInLobby; // 0x50
	
		// Properties
		public Hashtable CustomProperties { get => default; } // 0x0000000180246BC0-0x0000000180246BD0 
		public string Name { get => default; } // 0x0000000180249A10-0x0000000180249A20 
		public int PlayerCount { get; private set; } // 0x00000001802D59E0-0x00000001802D59F0 0x00000001802D5EE0-0x00000001802D5EF0
		public byte MaxPlayers { get => default; } // 0x000000018027A6C0-0x000000018027A6D0 
		public bool IsOpen { get => default; } // 0x00000001803CD700-0x00000001803CD710 
		public bool IsVisible { get => default; } // 0x00000001803CD720-0x00000001803CD730 
	
		// Constructors
		public RoomInfo() {} // Dummy constructor
		protected internal RoomInfo(string roomName, Hashtable roomProperties) {} // 0x0000000180749760-0x0000000180749810
	
		// Methods
		public override bool Equals(object other) => default; // 0x0000000180748A30-0x0000000180748AD0
		public override int GetHashCode() => default; // 0x0000000180748AD0-0x0000000180748B00
		public override string ToString() => default; // 0x00000001807494E0-0x0000000180749760
		public string ToStringFull() => default; // 0x0000000180749190-0x00000001807494E0
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache) {} // 0x0000000180748B00-0x0000000180749190
	}
}
