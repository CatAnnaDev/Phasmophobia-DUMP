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
	public class LoadBalancingClient : IPhotonPeerListener // TypeDefIndex: 4345
	{
		// Fields
		public AuthModeOption AuthMode; // 0x30
		public EncryptionMode EncryptionMode; // 0x34
		private string tokenCache; // 0x40
		public string NameServerHost; // 0x50
		public string NameServerHttp; // 0x58
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort; // 0x00
		public string ProxyServerAddress; // 0x80
		private ClientState state; // 0x88
		public ConnectionCallbacksContainer ConnectionCallbackTargets; // 0xA8
		public MatchMakingCallbacksContainer MatchMakingCallbackTargets; // 0xB0
		internal InRoomCallbacksContainer InRoomCallbackTargets; // 0xB8
		internal LobbyCallbacksContainer LobbyCallbackTargets; // 0xC0
		internal WebRpcCallbacksContainer WebRpcCallbackTargets; // 0xC8
		internal ErrorInfoCallbacksContainer ErrorInfoCallbackTargets; // 0xD0
		public bool EnableLobbyStatistics; // 0xE8
		private readonly List<TypedLobbyInfo> lobbyStatistics; // 0xF0
		private JoinType lastJoinType; // 0x114
		private EnterRoomParams enterRoomParamsCache; // 0x118
		private OperationResponse failedRoomEntryOperation; // 0x120
		private const int FriendRequestListMax = 512; // Metadata: 0x0064DEFF
		private string[] friendListRequested; // 0x128
		public RegionHandler RegionHandler; // 0x140
		private string bestRegionSummaryFromStorage; // 0x148
		public string SummaryToCache; // 0x150
		private bool connectToBestRegion; // 0x158
		private readonly Queue<CallbackTargetChange> callbackTargetChanges; // 0x160
		private readonly HashSet<object> callbackTargets; // 0x168
		public int NameServerPortOverride; // 0x170
	
		// Properties
		public LoadBalancingPeer LoadBalancingPeer { get; private set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
		public SerializationProtocol SerializationProtocol { get => default; set {} } // 0x0000000180740740-0x0000000180740760 0x00000001807409E0-0x0000000180740A00
		public string AppVersion { get; set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
		public string AppId { get; set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
		public AuthenticationValues AuthValues { get; set; } // 0x00000001802470A0-0x00000001802470B0 0x0000000180249810-0x0000000180249820
		public ConnectionProtocol? ExpectedProtocol { get; private set; } // 0x000000018050D1A0-0x000000018050D1B0 0x000000018050D1B0-0x000000018050F180
		private string TokenForInit { get => default; } // 0x0000000180740760-0x0000000180740780 
		public bool IsUsingNameServer { get; set; } // 0x00000001802968B0-0x00000001802968C0 0x00000001802FF720-0x00000001802FF790
		public string NameServerAddress { get => default; } // 0x0000000180740710-0x0000000180740720 
		public bool UseAlternativeUdpPorts { get; set; } // 0x00000001804033C0-0x00000001804033D0 0x00000001806C5150-0x00000001806C5160
		public bool EnableProtocolFallback { get; set; } // 0x00000001806995D0-0x00000001806995E0 0x0000000180256400-0x0000000180256410
		public string CurrentServerAddress { get => default; } // 0x0000000180740640-0x0000000180740660 
		public string MasterServerAddress { get; set; } // 0x0000000180274930-0x0000000180274940 0x00000001803CD190-0x00000001803CD1A0
		public string GameServerAddress { get; protected internal set; } // 0x0000000180274980-0x0000000180274990 0x0000000180280510-0x0000000180280520
		public ServerConnection Server { get; private set; } // 0x00000001804019C0-0x00000001804019D0 0x00000001804019D0-0x00000001804019E0
		public ClientState State { get => default; set {} } // 0x00000001802800E0-0x00000001802800F0 0x0000000180740A00-0x0000000180740A60
		public bool IsConnected { get => default; } // 0x00000001807406E0-0x0000000180740700 
		public bool IsConnectedAndReady { get => default; } // 0x0000000180740690-0x00000001807406E0 
		public DisconnectCause DisconnectedCause { get; protected set; } // 0x00000001806A1160-0x00000001806A1170 0x0000000180740980-0x0000000180740990
		public bool InLobby { get => default; } // 0x0000000180740660-0x0000000180740670 
		public TypedLobby CurrentLobby { get; internal set; } // 0x0000000180740630-0x0000000180740640 0x0000000180740970-0x0000000180740980
		public Player LocalPlayer { get; internal set; } // 0x000000018035C8A0-0x000000018035C8B0 0x000000018035C8C0-0x000000018035C8D0
		public string NickName { get => default; set {} } // 0x0000000180740720-0x0000000180740740 0x0000000180740990-0x00000001807409B0
		public string UserId { get => default; set {} } // 0x0000000180740780-0x0000000180740790 0x0000000180740A60-0x0000000180740B00
		public Room CurrentRoom { get; set; } // 0x0000000180352920-0x0000000180352930 0x0000000180352960-0x0000000180352970
		public bool InRoom { get => default; } // 0x0000000180740670-0x0000000180740690 
		public int PlayersOnMasterCount { get; internal set; } // 0x00000001806AB080-0x00000001806AB090 0x00000001807409C0-0x00000001807409D0
		public int PlayersInRoomsCount { get; internal set; } // 0x00000001806AB100-0x00000001806AB110 0x00000001807409B0-0x00000001807409C0
		public int RoomsCount { get; internal set; } // 0x00000001802E9450-0x00000001802E9460 0x00000001807409D0-0x00000001807409E0
		public bool IsFetchingFriendList { get => default; } // 0x0000000180740700-0x0000000180740710 
		public string CloudRegion { get; private set; } // 0x000000018026C860-0x000000018026C870 0x000000018026F6D0-0x000000018026F6E0
		public string CurrentCluster { get; private set; } // 0x000000018035CDF0-0x000000018035CE00 0x000000018035CE40-0x000000018035D140
	
		// Events
		public event Action<ClientState, ClientState> StateChanged;
		public event Action<EventData> EventReceived;
		public event Action<OperationResponse> OpResponseReceived;
	
		// Nested types
		private class CallbackTargetChange // TypeDefIndex: 4346
		{
			// Fields
			public readonly object Target; // 0x10
			public readonly bool AddTarget; // 0x18
	
			// Constructors
			public CallbackTargetChange() {} // Dummy constructor
			public CallbackTargetChange(object target, bool addTarget) {} // 0x0000000180328A50-0x0000000180328AA0
		}
	
		// Constructors
		public LoadBalancingClient() {} // Dummy constructor
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp /* Metadata: 0x0064DEF7 */) {} // 0x000000018073FF50-0x0000000180740450
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp /* Metadata: 0x0064DEF8 */) {} // 0x000000018073FEE0-0x000000018073FF50
		static LoadBalancingClient() {} // 0x000000018073FE10-0x000000018073FEE0
	
		// Methods
		private string GetNameServerAddress() => default; // 0x000000018073A7F0-0x000000018073AA10
		public virtual bool ConnectUsingSettings(AppSettings appSettings) => default; // 0x0000000180739BC0-0x0000000180739EA0
		[Obsolete] // 0x00000001800FFDC0-0x00000001800FFDF0
		public bool Connect() => default; // 0x00000001804478C0-0x00000001804478E0
		public virtual bool ConnectToMasterServer() => default; // 0x0000000180739720-0x0000000180739820
		public bool ConnectToNameServer() => default; // 0x0000000180739820-0x00000001807399B0
		public bool ConnectToRegionMaster(string region) => default; // 0x00000001807399B0-0x0000000180739BC0
		// [Conditional] // 0x00000001800FFEB0-0x00000001800FFEE0
		private void CheckConnectSetupWebGl() {} // 0x0000000180738D50-0x0000000180738DD0
		// [Conditional] // 0x00000001800FFFF0-0x0000000180100020
		private void CheckConnectSetupXboxOne() {} // 0x0000000180738DD0-0x0000000180738F30
		private bool Connect(string serverAddress, string proxyServerAddress, ServerConnection serverType) => default; // 0x0000000180739EA0-0x0000000180739FF0
		public bool ReconnectToMaster() => default; // 0x000000018073F590-0x000000018073F660
		public bool ReconnectAndRejoin() => default; // 0x000000018073F440-0x000000018073F590
		public void Disconnect(DisconnectCause cause = DisconnectCause.DisconnectByClientLogic /* Metadata: 0x0064DEF9 */) {} // 0x000000018073A3C0-0x000000018073A460
		private void DisconnectToReconnect() {} // 0x000000018073A290-0x000000018073A3C0
		public void SimulateConnectionLoss(bool simulateTimeout) {} // 0x000000018073F990-0x000000018073FA70
		private bool CallAuthenticate() => default; // 0x00000001807389D0-0x0000000180738B40
		public void Service() {} // 0x000000018073F6F0-0x000000018073F710
		private bool OpGetRegions() => default; // 0x000000018073DB60-0x000000018073DBE0
		public bool OpFindFriends(string[] friendsToFind, FindFriendsOptions options = null) => default; // 0x000000018073D750-0x000000018073DAC0
		public bool OpJoinLobby(TypedLobby lobby) => default; // 0x000000018073DBE0-0x000000018073DD30
		public bool OpLeaveLobby() => default; // 0x000000018073E2C0-0x000000018073E340
		public bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams = null) => default; // 0x000000018073DFD0-0x000000018073E170
		public bool OpJoinRandomOrCreateRoom(OpJoinRandomRoomParams opJoinRandomRoomParams, EnterRoomParams createRoomParams) => default; // 0x000000018073DE10-0x000000018073DFD0
		public bool OpCreateRoom(EnterRoomParams enterRoomParams) => default; // 0x000000018073D620-0x000000018073D750
		public bool OpJoinOrCreateRoom(EnterRoomParams enterRoomParams) => default; // 0x000000018073DD30-0x000000018073DE10
		public bool OpJoinRoom(EnterRoomParams enterRoomParams) => default; // 0x000000018073E170-0x000000018073E2C0
		public bool OpRejoinRoom(string roomName) => default; // 0x000000018073E4F0-0x000000018073E610
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false /* Metadata: 0x0064DEFD */) => default; // 0x000000018073E340-0x000000018073E430
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter) => default; // 0x000000018073DAC0-0x000000018073DB60
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null) => default; // 0x000000018073E610-0x000000018073E7F0
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, Hashtable expectedProperties = null, WebFlags webFlags = null) => default; // 0x000000018073E930-0x000000018073EAC0
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties = null, WebFlags webFlags = null) => default; // 0x000000018073E7F0-0x000000018073E930
		protected internal bool OpSetPropertyOfRoom(byte propCode, object value) => default; // 0x000000018073EC20-0x000000018073ECE0
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, Hashtable expectedProperties = null, WebFlags webFlags = null) => default; // 0x000000018073EAC0-0x000000018073EC20
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions) => default; // 0x000000018073E430-0x000000018073E4F0
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd) => default; // 0x000000018073D570-0x000000018073D620
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr) {} // 0x000000018073EF70-0x000000018073F440
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr) => default; // 0x000000018073EE70-0x000000018073EF70
		public void ChangeLocalID(int newID) {} // 0x0000000180738BE0-0x0000000180738D50
		private void GameEnteredOnGameServer(OperationResponse operationResponse) {} // 0x000000018073A460-0x000000018073A7F0
		private void UpdatedActorList(int[] actorsInGame) {} // 0x000000018073FCE0-0x000000018073FE10
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties) => default; // 0x0000000180739FF0-0x000000018073A080
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt) => default; // 0x000000018073A080-0x000000018073A170
		private bool CheckIfOpAllowedOnServer(byte opCode, ServerConnection serverConnection) => default; // 0x0000000180739080-0x00000001807391F0
		private bool CheckIfOpCanBeSent(byte opCode, ServerConnection serverConnection, string opName) => default; // 0x00000001807391F0-0x0000000180739720
		private bool CheckIfClientIsReadyToCallOperation(byte opCode) => default; // 0x0000000180738F30-0x0000000180739080
		public virtual void DebugReturn(DebugLevel level, string message) {} // 0x000000018073A170-0x000000018073A290
		private void CallbackRoomEnterFailed(OperationResponse operationResponse) {} // 0x0000000180738B40-0x0000000180738BE0
		public virtual void OnOperationResponse(OperationResponse operationResponse) {} // 0x000000018073B6F0-0x000000018073CBF0
		public virtual void OnStatusChanged(StatusCode statusCode) {} // 0x000000018073CC50-0x000000018073D570
		public virtual void OnEvent(EventData photonEvent) {} // 0x000000018073AA10-0x000000018073B690
		public virtual void OnMessage(object message) {} // 0x000000018073B690-0x000000018073B6F0
		private void OnRegionPingCompleted(RegionHandler regionHandler) {} // 0x000000018073CBF0-0x000000018073CC50
		private void SetupEncryption(Dictionary<byte, object> encryptionData) {} // 0x000000018073F710-0x000000018073F990
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false /* Metadata: 0x0064DEFE */) => default; // 0x000000018073ECE0-0x000000018073EE70
		public void AddCallbackTarget(object target) {} // 0x0000000180738940-0x00000001807389D0
		public void RemoveCallbackTarget(object target) {} // 0x000000018073F660-0x000000018073F6F0
		protected internal void UpdateCallbackTargets() {} // 0x000000018073FA70-0x000000018073FCE0
		private void UpdateCallbackTarget<T>(CallbackTargetChange change, List<T> container)
			where T : class {}
	}
}
