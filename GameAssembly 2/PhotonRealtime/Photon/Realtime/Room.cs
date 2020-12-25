/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public class Room : RoomInfo // TypeDefIndex: 4395
	{
		// Fields
		private bool isOffline; // 0x68
		private Dictionary<int, Player> players; // 0x70
	
		// Properties
		public LoadBalancingClient LoadBalancingClient { get; set; } // 0x0000000180274940-0x0000000180274950 0x0000000180280570-0x0000000180280580
		public new string Name { get => default; internal set {} } // 0x0000000180249A10-0x0000000180249A20 0x0000000180249920-0x0000000180249930
		public bool IsOffline { get => default; private set {} } // 0x00000001802FF6E0-0x00000001802FF6F0 0x00000001802FF710-0x00000001802FF720
		public new bool IsOpen { get => default; set {} } // 0x00000001803CD700-0x00000001803CD710 0x000000018074A830-0x000000018074A920
		public new bool IsVisible { get => default; set {} } // 0x00000001803CD720-0x00000001803CD730 0x000000018074A920-0x000000018074AA10
		public new byte MaxPlayers { get => default; set {} } // 0x000000018027A6C0-0x000000018027A6D0 0x000000018074AA10-0x000000018074AB00
		public new byte PlayerCount { get => default; } // 0x000000018074A730-0x000000018074A780 
		public Dictionary<int, Player> Players { get => default; private set {} } // 0x0000000180274980-0x0000000180274990 0x0000000180280510-0x0000000180280520
		public string[] ExpectedUsers { get => default; } // 0x00000001802470B0-0x00000001802470C0 
		public int PlayerTtl { get => default; set {} } // 0x000000018026C7E0-0x000000018026C7F0 0x000000018074AB00-0x000000018074AB90
		public int EmptyRoomTtl { get => default; set {} } // 0x000000018027A6B0-0x000000018027A6C0 0x000000018074A7A0-0x000000018074A830
		public int MasterClientId { get => default; } // 0x00000001802456E0-0x00000001802456F0 
		public string[] PropertiesListedInLobby { get => default; private set {} } // 0x00000001802505D0-0x00000001802505E0 0x000000018027AC50-0x000000018027AC60
		public bool AutoCleanUp { get => default; } // 0x00000001803CD710-0x00000001803CD720 
		public bool BroadcastPropertiesChangeToAll { get; private set; } // 0x000000018074A720-0x000000018074A730 0x000000018074A790-0x000000018074A7A0
		public bool SuppressRoomEvents { get; private set; } // 0x000000018074A780-0x000000018074A790 0x000000018074AB90-0x000000018074ABA0
	
		// Constructors
		public Room() {} // Dummy constructor
		public Room(string roomName, RoomOptions options, bool isOffline = false /* Metadata: 0x0064E03D */) {} // 0x000000018074A640-0x000000018074A720
	
		// Methods
		internal void InternalCacheRoomFlags(int roomFlags) {} // 0x0000000180749B30-0x0000000180749B50
		protected internal override void InternalCacheProperties(Hashtable propertiesToCache) {} // 0x0000000180749AC0-0x0000000180749B30
		public virtual bool SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null) => default; // 0x0000000180749C00-0x0000000180749D60
		public bool SetPropertiesListedInLobby(string[] lobbyProps) => default; // 0x0000000180749EC0-0x0000000180749F80
		protected internal virtual void RemovePlayer(Player player) {} // 0x0000000180749B50-0x0000000180749BC0
		protected internal virtual void RemovePlayer(int id) {} // 0x0000000180749BC0-0x0000000180749C00
		public bool SetMasterClient(Player masterClientPlayer) => default; // 0x0000000180749D60-0x0000000180749EC0
		public virtual bool AddPlayer(Player player) => default; // 0x00000001807498A0-0x0000000180749930
		public virtual Player StorePlayer(Player player) => default; // 0x0000000180749F80-0x000000018074A000
		public virtual Player GetPlayer(int id) => default; // 0x0000000180749A50-0x0000000180749AC0
		public bool ClearExpectedUsers() => default; // 0x0000000180749930-0x0000000180749A50
		public override string ToString() => default; // 0x000000018074A380-0x000000018074A640
		public new string ToStringFull() => default; // 0x000000018074A000-0x000000018074A380
	}
}
