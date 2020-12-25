/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using UnityEngine;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	public static class PhotonNetwork // TypeDefIndex: 5311
	{
		// Fields
		public const string PunVersion = "2.22"; // Metadata: 0x0064F6CC
		private static string gameVersion; // 0x00
		public static LoadBalancingClient NetworkingClient; // 0x08
		public static readonly int MAX_VIEW_IDS; // 0x10
		public const string ServerSettingsFileName = "PhotonServerSettings"; // Metadata: 0x0064F6D4
		private static ServerSettings photonServerSettings; // 0x18
		private const string PlayerPrefsKey = "PUNCloudBestRegion"; // Metadata: 0x0064F6EC
		public static ConnectMethod ConnectMethod; // 0x20
		public static PunLogLevel LogLevel; // 0x24
		public static float PrecisionForVectorSynchronization; // 0x28
		public static float PrecisionForQuaternionSynchronization; // 0x2C
		public static float PrecisionForFloatSynchronization; // 0x30
		private static bool offlineMode; // 0x34
		private static Room offlineModeRoom; // 0x38
		private static bool automaticallySyncScene; // 0x40
		private static int sendFrequency; // 0x44
		private static int serializationFrequency; // 0x48
		private static bool isMessageQueueRunning; // 0x4C
		private static double frametime; // 0x50
		private static int frame; // 0x58
		private static Stopwatch StartupStopwatch; // 0x60
		public static float MinimalTimeScaleToDispatchInFixedUpdate; // 0x68
		private static int lastUsedViewSubId; // 0x6C
		private static int lastUsedViewSubIdStatic; // 0x70
		private static readonly HashSet<string> PrefabsWithoutMagicCallback; // 0x78
		private static readonly Hashtable SendInstantiateEvHashtable; // 0x80
		private static readonly RaiseEventOptions SendInstantiateRaiseEventOptions; // 0x88
		private static HashSet<byte> allowedReceivingGroups; // 0x90
		private static HashSet<byte> blockedSendingGroups; // 0x98
		private static HashSet<PhotonView> reusablePVHashset; // 0xA0
		private static NonAllocDictionary<int, PhotonView> photonViewList; // 0xA8
		internal static byte currentLevelPrefix; // 0xC0
		internal static bool loadingLevelAndPausedNetwork; // 0xC1
		internal const string CurrentSceneProperty = "curScn"; // Metadata: 0x0064F702
		internal const string CurrentScenePropertyLoadAsync = "curScnLa"; // Metadata: 0x0064F70C
		private static IPunPrefabPool prefabPool; // 0xC8
		public static bool UseRpcMonoBehaviourCache; // 0xD0
		private static readonly Dictionary<Type, List<MethodInfo>> monoRPCMethodsCache; // 0xD8
		private static Dictionary<string, int> rpcShortcuts; // 0xE0
		public static bool RunRpcCoroutines; // 0xE8
		private static AsyncOperation _AsyncLevelLoadingOperation; // 0xF0
		private static float _levelLoadingProgress; // 0xF8
		private static readonly Type typePunRPC; // 0x100
		private static readonly Type typePhotonMessageInfo; // 0x108
		private static readonly object keyByteZero; // 0x110
		private static readonly object keyByteOne; // 0x118
		private static readonly object keyByteTwo; // 0x120
		private static readonly object keyByteThree; // 0x128
		private static readonly object keyByteFour; // 0x130
		private static readonly object keyByteFive; // 0x138
		private static readonly object keyByteSix; // 0x140
		private static readonly object keyByteSeven; // 0x148
		private static readonly object keyByteEight; // 0x150
		private static readonly object[] emptyObjectArray; // 0x158
		private static readonly Type[] emptyTypeArray; // 0x160
		internal static List<PhotonView> foundPVs; // 0x168
		private static readonly Hashtable removeFilter; // 0x170
		private static readonly Hashtable ServerCleanDestroyEvent; // 0x178
		private static readonly RaiseEventOptions ServerCleanOptions; // 0x180
		internal static RaiseEventOptions SendToAllOptions; // 0x188
		internal static RaiseEventOptions SendToOthersOptions; // 0x190
		internal static RaiseEventOptions SendToSingleOptions; // 0x198
		private static readonly Hashtable rpcFilterByViewId; // 0x1A0
		private static readonly RaiseEventOptions OpCleanRpcBufferOptions; // 0x1A8
		private static Hashtable rpcEvent; // 0x1B0
		private static RaiseEventOptions RpcOptionsToAll; // 0x1B8
		public static int ObjectsInOneUpdate; // 0x1C0
		private static readonly PhotonStream serializeStreamOut; // 0x1C8
		private static readonly PhotonStream serializeStreamIn; // 0x1D0
		private static RaiseEventOptions serializeRaiseEvOptions; // 0x1D8
		private static readonly Dictionary<RaiseEventBatch, SerializeViewBatch> serializeViewBatches; // 0x1E0
		public const int SyncViewId = 0; // Metadata: 0x0064F718
		public const int SyncCompressed = 1; // Metadata: 0x0064F71C
		public const int SyncNullValues = 2; // Metadata: 0x0064F720
		public const int SyncFirstValue = 3; // Metadata: 0x0064F724
		private static RegionHandler _cachedRegionHandler; // 0x1E8
	
		// Properties
		public static string GameVersion { get; set; } // 0x00000001805B5D00-0x00000001805B5D60 0x00000001805B7EB0-0x00000001805B7F60
		public static string AppVersion { get; } // 0x00000001805B5590-0x00000001805B5600 
		public static ServerSettings PhotonServerSettings { get; private set; } // 0x00000001805B6AB0-0x00000001805B6C50 0x00000001805B85C0-0x00000001805B8630
		public static string ServerAddress { get; } // 0x00000001805B7460-0x00000001805B7500 
		public static string CloudRegion { get; } // 0x00000001805B5740-0x00000001805B5840 
		public static string CurrentCluster { get; } // 0x00000001805B5A80-0x00000001805B5B20 
		public static string BestRegionSummaryInPreferences { get; internal set; } // 0x00000001805B5700-0x00000001805B5740 0x00000001805B7CE0-0x00000001805B7D60
		public static bool IsConnected { get; } // 0x00000001805B5F30-0x00000001805B6040 
		public static bool IsConnectedAndReady { get; } // 0x00000001805B5E20-0x00000001805B5F30 
		public static ClientState NetworkClientState { get; } // 0x00000001805B6730-0x00000001805B6880 
		public static ServerConnection Server { get; } // 0x00000001805B7690-0x00000001805B7730 
		public static AuthenticationValues AuthValues { get; set; } // 0x00000001805B5600-0x00000001805B56A0 0x00000001805B7B70-0x00000001805B7C20
		public static TypedLobby CurrentLobby { get; } // 0x00000001805B5B20-0x00000001805B5B90 
		public static Room CurrentRoom { get; } // 0x00000001805B5B90-0x00000001805B5C90 
		public static Photon.Realtime.Player LocalPlayer { get; } // 0x00000001805B6490-0x00000001805B6530 
		public static string NickName { get; set; } // 0x00000001805B6900-0x00000001805B6970 0x00000001805B8200-0x00000001805B8280
		public static Photon.Realtime.Player[] PlayerList { get; } // 0x00000001805B70D0-0x00000001805B7240 
		public static Photon.Realtime.Player[] PlayerListOthers { get; } // 0x00000001805B6EA0-0x00000001805B70D0 
		public static bool OfflineMode { get; set; } // 0x00000001805B6970-0x00000001805B6A30 0x00000001805B8280-0x00000001805B85C0
		public static bool AutomaticallySyncScene { get; set; } // 0x00000001805B56A0-0x00000001805B5700 0x00000001805B7C20-0x00000001805B7CE0
		public static bool EnableLobbyStatistics { get; } // 0x00000001805B5C90-0x00000001805B5D00 
		public static bool InLobby { get; } // 0x00000001805B5D60-0x00000001805B5DD0 
		public static int SendRate { get; set; } // 0x00000001805B73A0-0x00000001805B7400 0x00000001805B8790-0x00000001805B8970
		public static int SerializationRate { get; set; } // 0x00000001805B7400-0x00000001805B7460 0x00000001805B8970-0x00000001805B8BD0
		public static bool IsMessageQueueRunning { get; set; } // 0x00000001805B6190-0x00000001805B6250 0x00000001805B7F60-0x00000001805B7FF0
		public static double Time { get; } // 0x00000001805B7730-0x00000001805B7840 
		public static int ServerTimestamp { get; } // 0x00000001805B7500-0x00000001805B7690 
		public static float KeepAliveInBackground { get; set; } // 0x00000001805B6250-0x00000001805B6340 0x00000001805B7FF0-0x00000001805B80F0
		public static bool IsMasterClient { get; } // 0x00000001805B6040-0x00000001805B6190 
		public static Photon.Realtime.Player MasterClient { get; } // 0x00000001805B6530-0x00000001805B66C0 
		public static bool InRoom { get; } // 0x00000001805B5DD0-0x00000001805B5E20 
		public static int CountOfPlayersOnMaster { get; } // 0x00000001805B58B0-0x00000001805B5920 
		public static int CountOfPlayersInRooms { get; } // 0x00000001805B5840-0x00000001805B58B0 
		public static int CountOfPlayers { get; } // 0x00000001805B5920-0x00000001805B5990 
		public static int CountOfRooms { get; } // 0x00000001805B5990-0x00000001805B5A00 
		public static bool NetworkStatisticsEnabled { get; set; } // 0x00000001805B6880-0x00000001805B6900 0x00000001805B8180-0x00000001805B8200
		public static int ResentReliableCommands { get; } // 0x00000001805B7320-0x00000001805B73A0 
		public static bool CrcCheckEnabled { get; set; } // 0x00000001805B5A00-0x00000001805B5A80 0x00000001805B7D60-0x00000001805B7EB0
		public static int PacketLossByCrcCheck { get; } // 0x00000001805B6A30-0x00000001805B6AB0 
		public static int MaxResendsBeforeDisconnect { get; set; } // 0x00000001805B66C0-0x00000001805B6730 0x00000001805B80F0-0x00000001805B8180
		public static int QuickResends { get; set; } // 0x00000001805B72A0-0x00000001805B7320 0x00000001805B86F0-0x00000001805B8790
		public static bool UseAlternativeUdpPorts { get; set; } // 0x00000001805B7840-0x00000001805B78E0 0x00000001805B8BD0-0x00000001805B8C70
		[Obsolete] // 0x0000000180107EC0-0x0000000180107EF0
		public static PhotonView[] PhotonViews { get; } // 0x00000001805B6CE0-0x00000001805B6EA0 
		public static NonAllocDictionary<int, PhotonView> PhotonViewCollection { get; } // 0x00000001805B6C50-0x00000001805B6CE0 
		public static int ViewCount { get; } // 0x00000001805B78E0-0x00000001805B7950 
		public static IPunPrefabPool PrefabPool { get; set; } // 0x00000001805B7240-0x00000001805B72A0 0x00000001805B8630-0x00000001805B86F0
		public static float LevelLoadingProgress { get; } // 0x00000001805B6340-0x00000001805B6490 
	
		// Events
		private static event Action<PhotonView, Photon.Realtime.Player> OnOwnershipRequestEv;
		private static event Action<PhotonView, Photon.Realtime.Player> OnOwnershipTransferedEv;
	
		// Nested types
		private struct RaiseEventBatch : IEquatable<RaiseEventBatch> // TypeDefIndex: 5312
		{
			// Fields
			public byte Group; // 0x00
			public bool Reliable; // 0x01
	
			// Methods
			public override int GetHashCode() => default; // 0x000000018001E5B0-0x000000018001E750
			public bool Equals(RaiseEventBatch other) => default; // 0x000000018001E590-0x000000018001E5B0
		}
	
		private class SerializeViewBatch : IEquatable<SerializeViewBatch>, IEquatable<RaiseEventBatch> // TypeDefIndex: 5313
		{
			// Fields
			public readonly RaiseEventBatch Batch; // 0x10
			public List<object> ObjectUpdates; // 0x18
			private int defaultSize; // 0x20
			private int offset; // 0x24
	
			// Constructors
			public SerializeViewBatch() {} // Dummy constructor
			public SerializeViewBatch(RaiseEventBatch batch, int offset) {} // 0x00000001805B9880-0x00000001805B9980
	
			// Methods
			public override int GetHashCode() => default; // 0x00000001805B9860-0x00000001805B9880
			public bool Equals(SerializeViewBatch other) => default; // 0x00000001805B9750-0x00000001805B9790
			public bool Equals(RaiseEventBatch other) => default; // 0x00000001805B9840-0x00000001805B9860
			public override bool Equals(object obj) => default; // 0x00000001805B9790-0x00000001805B9840
			public void Clear() {} // 0x00000001805B96D0-0x00000001805B9750
			public void Add(List<object> viewData) {} // 0x00000001805B9620-0x00000001805B96D0
		}
	
		// Constructors
		static PhotonNetwork() {} // 0x00000001805B4960-0x00000001805B5370
	
		// Methods
		private static void StaticReset() {} // 0x00000001805B3D20-0x00000001805B4410
		public static bool ConnectUsingSettings() => default; // 0x00000001805A2200-0x00000001805A2300
		public static bool ConnectUsingSettings(AppSettings appSettings, bool startInOfflineMode = false /* Metadata: 0x0064F6C0 */) => default; // 0x00000001805A2300-0x00000001805A2B00
		public static bool ConnectToMaster(string masterServerAddress, int port, string appID) => default; // 0x00000001805A1BF0-0x00000001805A1FB0
		public static bool ConnectToBestCloudServer() => default; // 0x00000001805A1A10-0x00000001805A1BF0
		public static bool ConnectToRegion(string region) => default; // 0x00000001805A1FB0-0x00000001805A2200
		public static void Disconnect() {} // 0x00000001805A43A0-0x00000001805A4540
		public static bool Reconnect() => default; // 0x00000001805AF970-0x00000001805AFCC0
		public static void NetworkStatisticsReset() {} // 0x00000001805AA420-0x00000001805AA4A0
		public static string NetworkStatisticsToString() => default; // 0x00000001805AA4A0-0x00000001805AA5C0
		private static bool VerifyCanUseNetwork() => default; // 0x00000001805B4830-0x00000001805B48C0
		public static int GetPing() => default; // 0x00000001805A6900-0x00000001805A6980
		public static void FetchServerTimestamp() {} // 0x00000001805A6360-0x00000001805A6410
		public static void SendAllOutgoingCommands() {} // 0x00000001805B1AE0-0x00000001805B1B90
		public static bool CloseConnection(Photon.Realtime.Player kickPlayer) => default; // 0x00000001805A17E0-0x00000001805A1A10
		public static bool SetMasterClient(Photon.Realtime.Player masterClientPlayer) => default; // 0x00000001805B35E0-0x00000001805B3770
		public static bool JoinRandomRoom() => default; // 0x00000001805A7D10-0x00000001805A7D80
		public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers) => default; // 0x00000001805A7C90-0x00000001805A7D10
		public static bool JoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchingType, TypedLobby typedLobby, string sqlLobbyFilter, string[] expectedUsers = null) => default; // 0x00000001805A7660-0x00000001805A7C90
		public static bool CreateRoom(string roomName, RoomOptions roomOptions = null, TypedLobby typedLobby = null, string[] expectedUsers = null) => default; // 0x00000001805A2B00-0x00000001805A3120
		public static bool JoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby typedLobby, string[] expectedUsers = null) => default; // 0x00000001805A6FE0-0x00000001805A7660
		public static bool JoinRoom(string roomName, string[] expectedUsers = null) => default; // 0x00000001805A7D80-0x00000001805A8330
		public static bool RejoinRoom(string roomName) => default; // 0x00000001805AFF90-0x00000001805B04E0
		public static bool ReconnectAndRejoin() => default; // 0x00000001805AF660-0x00000001805AF970
		public static bool LeaveRoom(bool becomeInactive = true /* Metadata: 0x0064F6C1 */) => default; // 0x00000001805A8400-0x00000001805A8640
		private static void EnterOfflineRoom(string roomName, RoomOptions roomOptions, bool createdRoom) {} // 0x00000001805A4540-0x00000001805A4770
		public static bool JoinLobby() => default; // 0x00000001805A6E00-0x00000001805A6F10
		public static bool JoinLobby(TypedLobby typedLobby) => default; // 0x00000001805A6F10-0x00000001805A6FE0
		public static bool LeaveLobby() => default; // 0x00000001805A8330-0x00000001805A8400
		public static bool FindFriends(string[] friendsToFind) => default; // 0x00000001805A6410-0x00000001805A64F0
		public static bool GetCustomRoomList(TypedLobby typedLobby, string sqlLobbyFilter) => default; // 0x00000001805A6670-0x00000001805A6700
		public static bool SetPlayerCustomProperties(Hashtable customProperties) => default; // 0x00000001805B3770-0x00000001805B39A0
		public static void RemovePlayerCustomProperties(string[] customPropertiesToDelete) {} // 0x00000001805B0ED0-0x00000001805B1090
		public static bool RaiseEvent(byte eventCode, object eventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions) => default; // 0x00000001805AF3A0-0x00000001805AF660
		private static bool RaiseEventInternal(byte eventCode, object eventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions) => default; // 0x00000001805AF1F0-0x00000001805AF3A0
		public static bool AllocateViewID(PhotonView view) => default; // 0x00000001805A0B30-0x00000001805A0C10
		public static bool AllocateSceneViewID(PhotonView view) => default; // 0x00000001805A0590-0x00000001805A06C0
		public static int AllocateViewID(bool sceneObject) => default; // 0x00000001805A06C0-0x00000001805A07C0
		public static int AllocateViewID(int ownerId) => default; // 0x00000001805A07C0-0x00000001805A0B30
		public static GameObject Instantiate(string prefabName, Vector3 position, Quaternion rotation, byte group = 0 /* Metadata: 0x0064F6C2 */, object[] data = null) => default; // 0x00000001805A6BC0-0x00000001805A6E00
		public static GameObject InstantiateRoomObject(string prefabName, Vector3 position, Quaternion rotation, byte group = 0 /* Metadata: 0x0064F6C3 */, object[] data = null) => default; // 0x00000001805A6980-0x00000001805A6BC0
		private static GameObject NetworkInstantiate(Hashtable networkEvent, Photon.Realtime.Player creator) => default; // 0x00000001805A9D20-0x00000001805AA420
		private static GameObject NetworkInstantiate(InstantiateParameters parameters, bool sceneObject = false /* Metadata: 0x0064F6C4 */, bool instantiateEvent = false /* Metadata: 0x0064F6C5 */) => default; // 0x00000001805A9400-0x00000001805A9D20
		internal static bool SendInstantiate(InstantiateParameters parameters, bool sceneObject = false /* Metadata: 0x0064F6C6 */) => default; // 0x00000001805B1DB0-0x00000001805B24A0
		public static void Destroy(PhotonView targetView) {} // 0x00000001805A4280-0x00000001805A43A0
		public static void Destroy(GameObject targetGo) {} // 0x00000001805A41E0-0x00000001805A4280
		public static void DestroyPlayerObjects(Photon.Realtime.Player targetPlayer) {} // 0x00000001805A3FE0-0x00000001805A41E0
		public static void DestroyPlayerObjects(int targetPlayerId) {} // 0x00000001805A3E60-0x00000001805A3FE0
		public static void DestroyAll() {} // 0x00000001805A3520-0x00000001805A35D0
		public static void RemoveRPCs(Photon.Realtime.Player targetPlayer) {} // 0x00000001805B11D0-0x00000001805B12D0
		public static void RemoveRPCs(PhotonView targetPhotonView) {} // 0x00000001805B12D0-0x00000001805B1350
		internal static void RPC(PhotonView view, string methodName, RpcTarget target, bool encrypt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] parameters) {} // 0x00000001805ADFA0-0x00000001805AE160
		internal static void RPC(PhotonView view, string methodName, Photon.Realtime.Player targetPlayer, bool encrpyt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] parameters) {} // 0x00000001805AE160-0x00000001805AE360
		public static HashSet<GameObject> FindGameObjectsWithComponent(Type type) => default; // 0x00000001805A64F0-0x00000001805A6670
		public static void SetInterestGroups(byte group, bool enabled) {} // 0x00000001805B2A00-0x00000001805B2B30
		public static void LoadLevel(int levelNumber) {} // 0x00000001805A8F20-0x00000001805A9090
		public static void LoadLevel(string levelName) {} // 0x00000001805A8DD0-0x00000001805A8F20
		public static bool WebRpc(string name, object parameters, bool sendAuthCookie = false /* Metadata: 0x0064F6C7 */) => default; // 0x00000001805B48C0-0x00000001805B4960
		private static void SetupLogging() {} // 0x00000001805B3BE0-0x00000001805B3D20
		public static void AddCallbackTarget(object target) {} // 0x00000001805A0240-0x00000001805A0590
		public static void RemoveCallbackTarget(object target) {} // 0x00000001805B0630-0x00000001805B09C0
		internal static string CallbacksToString() => default; // 0x00000001805A1170-0x00000001805A12D0
		private static void LeftRoomCleanup() {} // 0x00000001805A8640-0x00000001805A8870
		internal static void LocalCleanupAnythingInstantiated(bool destroyInstantiatedGameObjects) {} // 0x00000001805A9120-0x00000001805A9400
		private static void ResetPhotonViewsOnSerialize() {} // 0x00000001805B1470-0x00000001805B1590
		internal static void ExecuteRpc(Hashtable rpcData, Photon.Realtime.Player sender) {} // 0x00000001805A4770-0x00000001805A6360
		private static bool CheckTypeMatch(ParameterInfo[] methodParameters, Type[] callParameterTypes) => default; // 0x00000001805A12D0-0x00000001805A14B0
		public static void DestroyPlayerObjects(int playerId, bool localOnly) {} // 0x00000001805A3800-0x00000001805A3E60
		public static void DestroyAll(bool localOnly) {} // 0x00000001805A35D0-0x00000001805A3800
		internal static void RemoveInstantiatedGO(GameObject go, bool localOnly) {} // 0x00000001805B09C0-0x00000001805B0ED0
		private static void ServerCleanInstantiateAndDestroy(PhotonView photonView) {} // 0x00000001805B2770-0x00000001805B2A00
		private static void SendDestroyOfPlayer(int actorNr) {} // 0x00000001805B1CA0-0x00000001805B1DB0
		private static void SendDestroyOfAll() {} // 0x00000001805B1B90-0x00000001805B1CA0
		private static void OpRemoveFromServerInstantiationsOfPlayer(int actorNr) {} // 0x00000001805ADD20-0x00000001805ADE30
		internal static void RequestOwnership(int viewID, int fromOwner) {} // 0x00000001805B1350-0x00000001805B1470
		internal static void TransferOwnership(int viewID, int playerID) {} // 0x00000001805B4410-0x00000001805B4830
		internal static void OwnershipUpdate(int[] viewOwnerPairs, int targetActor = -1 /* Metadata: 0x0064F6C8 */) {} // 0x00000001805ADE30-0x00000001805ADFA0
		public static bool LocalCleanPhotonView(PhotonView view) => default; // 0x00000001805A9090-0x00000001805A9120
		public static PhotonView GetPhotonView(int viewID) => default; // 0x00000001805A6870-0x00000001805A6900
		public static void RegisterPhotonView(PhotonView netView) {} // 0x00000001805AFCC0-0x00000001805AFF90
		public static void OpCleanActorRpcBuffer(int actorNumber) {} // 0x00000001805AD8F0-0x00000001805ADA00
		public static void OpRemoveCompleteCacheOfPlayer(int actorNumber) {} // 0x00000001805ADB40-0x00000001805ADC50
		public static void OpRemoveCompleteCache() {} // 0x00000001805ADC50-0x00000001805ADD20
		private static void RemoveCacheOfLeftPlayers() {} // 0x00000001805B04E0-0x00000001805B0630
		public static void CleanRpcBufferIfMine(PhotonView view) {} // 0x00000001805A14B0-0x00000001805A17E0
		public static void OpCleanRpcBuffer(PhotonView view) {} // 0x00000001805ADA00-0x00000001805ADB40
		public static void RemoveRPCsInGroup(int group) {} // 0x00000001805B1090-0x00000001805B11D0
		public static void SetLevelPrefix(byte prefix) {} // 0x00000001805B3580-0x00000001805B35E0
		internal static void RPC(PhotonView view, string methodName, RpcTarget target, Photon.Realtime.Player player, bool encrypt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] parameters) {} // 0x00000001805AE360-0x00000001805AF1F0
		public static void SetInterestGroups(byte[] disableGroups, byte[] enableGroups) {} // 0x00000001805B2B30-0x00000001805B2F90
		public static void SetSendingEnabled(byte group, bool enabled) {} // 0x00000001805B39A0-0x00000001805B3A80
		public static void SetSendingEnabled(byte[] disableGroups, byte[] enableGroups) {} // 0x00000001805B3A80-0x00000001805B3BE0
		internal static void NewSceneLoaded() {} // 0x00000001805AA5C0-0x00000001805AA900
		internal static void RunViewUpdate() {} // 0x00000001805B1590-0x00000001805B1AE0
		private static void SendSerializeViewBatch(SerializeViewBatch batch) {} // 0x00000001805B24A0-0x00000001805B2770
		private static List<object> OnSerializeWrite(PhotonView view) => default; // 0x00000001805AD3D0-0x00000001805AD8F0
		private static void OnSerializeRead(object[] data, Photon.Realtime.Player sender, int networkTime, short correctPrefix) {} // 0x00000001805AC8D0-0x00000001805AD3D0
		private static List<object> DeltaCompressionWrite(List<object> previousContent, List<object> currentContent) => default; // 0x00000001805A32D0-0x00000001805A3520
		private static object[] DeltaCompressionRead(object[] lastOnSerializeDataReceived, object[] incomingData) => default; // 0x00000001805A3120-0x00000001805A32D0
		private static bool AlmostEquals(IList<object> lastData, IList<object> currentContent) => default; // 0x00000001805A1040-0x00000001805A1170
		private static bool AlmostEquals(object one, object two) => default; // 0x00000001805A0C10-0x00000001805A1040
		internal static bool GetMethod(MonoBehaviour monob, string methodType, out MethodInfo mi) {
			mi = default;
			return default;
		} // 0x00000001805A6700-0x00000001805A6870
		internal static void LoadLevelIfSynced() {} // 0x00000001805A8870-0x00000001805A8DD0
		internal static void SetLevelInPropsIfSynced(object levelId) {} // 0x00000001805B2F90-0x00000001805B3580
		private static void OnEvent(EventData photonEvent) {} // 0x00000001805AAAB0-0x00000001805AC570
		private static void OnOperation(OperationResponse opResponse) {} // 0x00000001805AC570-0x00000001805AC780
		private static void OnClientStateChanged(ClientState previousState, ClientState state) {} // 0x00000001805AA900-0x00000001805AAAB0
		private static void OnRegionsPinged(RegionHandler regionHandler) {} // 0x00000001805AC780-0x00000001805AC8D0
	}
}
