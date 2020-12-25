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
	public class LoadBalancingPeer : PhotonPeer // TypeDefIndex: 4361
	{
		// Fields
		private readonly Pool<Dictionary<byte, object>> paramDictionaryPool; // 0x108
	
		// Properties
		[Obsolete] // 0x0000000180100150-0x0000000180100180
		protected internal static Type PingImplementation { get => default; set {} } // 0x0000000180743BC0-0x0000000180743C00 0x0000000180743C00-0x0000000180743C50
	
		// Constructors
		public LoadBalancingPeer() {} // Dummy constructor
		public LoadBalancingPeer(ConnectionProtocol protocolType) {} // 0x0000000180743920-0x0000000180743B40
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType) {} // 0x0000000180743B40-0x0000000180743BC0
	
		// Methods
		// [Conditional] // 0x0000000180100050-0x0000000180100080
		private void ConfigUnitySockets() {} // 0x0000000180740B00-0x0000000180740CE0
		public virtual bool OpGetRegions(string appId) => default; // 0x0000000180741C40-0x0000000180741D10
		public virtual bool OpJoinLobby(TypedLobby lobby = null) => default; // 0x0000000180741D10-0x0000000180741E60
		public virtual bool OpLeaveLobby() => default; // 0x00000001807427A0-0x0000000180742850
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions, bool usePropertiesKey = false /* Metadata: 0x0064DF03 */) {} // 0x00000001807434F0-0x0000000180743920
		public virtual bool OpCreateRoom(EnterRoomParams opParams) => default; // 0x0000000180741670-0x00000001807418D0
		public virtual bool OpJoinRoom(EnterRoomParams opParams) => default; // 0x00000001807424C0-0x00000001807427A0
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams) => default; // 0x00000001807421D0-0x00000001807424C0
		public virtual bool OpJoinRandomOrCreateRoom(OpJoinRandomRoomParams opJoinRandomRoomParams, EnterRoomParams createRoomParams) => default; // 0x0000000180741E60-0x00000001807421D0
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false /* Metadata: 0x0064DF04 */) => default; // 0x0000000180742850-0x0000000180742990
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData) => default; // 0x0000000180741A20-0x0000000180741C40
		public virtual bool OpFindFriends(string[] friendsToFind, FindFriendsOptions options = null) => default; // 0x00000001807418D0-0x0000000180741A20
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties) => default; // 0x0000000180742D80-0x0000000180742E10
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, WebFlags webflags = null) => default; // 0x0000000180742E90-0x00000001807430D0
		protected bool OpSetPropertyOfRoom(byte propCode, object value) => default; // 0x00000001807432D0-0x0000000180743390
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties) => default; // 0x0000000180742E10-0x0000000180742E90
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webflags = null) => default; // 0x00000001807430D0-0x00000001807432D0
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics) => default; // 0x00000001807412A0-0x0000000180741530
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol) => default; // 0x0000000180740CE0-0x00000001807412A0
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd) => default; // 0x0000000180741530-0x0000000180741670
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions) => default; // 0x0000000180742990-0x0000000180742D80
		public virtual bool OpSettings(bool receiveLobbyStats) => default; // 0x0000000180743390-0x00000001807434F0
	}
}
