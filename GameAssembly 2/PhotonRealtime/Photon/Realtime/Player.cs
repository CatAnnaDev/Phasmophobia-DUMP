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
	public class Player // TypeDefIndex: 4388
	{
		// Fields
		private int actorNumber; // 0x18
		public readonly bool IsLocal; // 0x1C
		private string nickName; // 0x20
		public object TagObject; // 0x40
	
		// Properties
		protected internal Room RoomReference { get; set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
		public int ActorNumber { get => default; } // 0x000000018027A800-0x000000018027A810 
		public bool HasRejoined { get; internal set; } // 0x00000001807465F0-0x0000000180746600 0x0000000180746620-0x0000000180746630
		public string NickName { get => default; set {} } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180746630-0x00000001807466B0
		public string UserId { get; internal set; } // 0x00000001802470A0-0x00000001802470B0 0x0000000180249810-0x0000000180249820
		public bool IsMasterClient { get => default; } // 0x0000000180746600-0x0000000180746620 
		public bool IsInactive { get; protected internal set; } // 0x00000001802FB160-0x00000001802FB170 0x00000001803C0D60-0x00000001803C0D70
		public Hashtable CustomProperties { get; set; } // 0x0000000180246FD0-0x0000000180246FE0 0x0000000180278400-0x0000000180278410
	
		// Constructors
		public Player() {} // Dummy constructor
		protected internal Player(string nickName, int actorNumber, bool isLocal) {} // 0x00000001807464F0-0x0000000180746510
		protected internal Player(string nickName, int actorNumber, bool isLocal, Hashtable playerProperties) {} // 0x0000000180746510-0x00000001807465F0
	
		// Methods
		public Player Get(int id) => default; // 0x0000000180745C70-0x0000000180745C90
		public Player GetNext() => default; // 0x0000000180745C60-0x0000000180745C70
		public Player GetNextFor(Player currentPlayer) => default; // 0x0000000180745C40-0x0000000180745C60
		public Player GetNextFor(int currentPlayerId) => default; // 0x0000000180745A10-0x0000000180745C40
		protected internal virtual void InternalCacheProperties(Hashtable properties) {} // 0x0000000180745C90-0x0000000180745F20
		public override string ToString() => default; // 0x0000000180746490-0x00000001807464F0
		public string ToStringFull() => default; // 0x0000000180746210-0x0000000180746490
		public override bool Equals(object p) => default; // 0x0000000180745940-0x0000000180745A10
		public override int GetHashCode() => default; // 0x000000018027A800-0x000000018027A810
		protected internal void ChangeLocalID(int newID) {} // 0x0000000180745930-0x0000000180745940
		public bool SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues = null, WebFlags webFlags = null) => default; // 0x0000000180745F20-0x0000000180746140
		private bool SetPlayerNameProperty() => default; // 0x0000000180746140-0x0000000180746210
	}
}
