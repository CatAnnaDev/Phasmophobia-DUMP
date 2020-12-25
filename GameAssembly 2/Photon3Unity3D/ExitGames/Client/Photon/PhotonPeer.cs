/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon.Encryption;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class PhotonPeer // TypeDefIndex: 4278
	{
		// Fields
		[Obsolete] // 0x00000001800EE2B0-0x00000001800EE2E0
		public int WarningSize; // 0x18
		public const bool NoSocket = false; // Metadata: 0x0064D66D
		[Obsolete] // 0x00000001800EE340-0x00000001800EE370
		public const bool NativeDatagramEncrypt = true; // Metadata: 0x0064D66E
		public const bool DebugBuild = true; // Metadata: 0x0064D66F
		public const int NativeEncryptorApiVersion = 1; // Metadata: 0x0064D670
		public static bool NoNativeCallbacks; // 0x00
		protected internal byte ClientSdkId; // 0x1C
		private string clientVersion; // 0x20
		private static bool checkedNativeLibs; // 0x01
		private static bool useSocketNative; // 0x02
		private static bool useDiffieHellmanCryptoProvider; // 0x03
		private static bool useEncryptorNative; // 0x04
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig; // 0x30
		public DebugLevel DebugOut; // 0x40
		private bool reuseEventInstance; // 0x50
		private bool useByteArraySlicePoolForEvents; // 0x51
		public bool SendInCreationOrder; // 0x52
		[Obsolete] // 0x00000001800EE6F0-0x00000001800EE720
		public int CommandLogSize; // 0x54
		public ITrafficRecorder TrafficRecorder; // 0x58
		private byte quickResendAttempts; // 0x61
		public int RhttpMinConnections; // 0x64
		public int RhttpMaxConnections; // 0x68
		public byte ChannelCount; // 0x6C
		public bool EnableEncryptedFlag; // 0x6D
		private bool crcEnabled; // 0x6E
		public int SentCountAllowance; // 0x70
		public int InitialResendTimeMax; // 0x74
		public int TimePingInterval; // 0x78
		public int DisconnectTimeout; // 0x7C
		public static int OutgoingStreamBufferSize; // 0x08
		private int mtu; // 0x84
		public static bool AsyncKeyExchange; // 0x0C
		internal bool RandomizeSequenceNumbers; // 0x89
		internal byte[] RandomizedSequenceNumbers; // 0x90
		internal bool GcmDatagramEncryption; // 0x98
		private Stopwatch trafficStatsStopwatch; // 0xB8
		private bool trafficStatsEnabled; // 0xC0
		internal PeerBase peerBase; // 0xC8
		private readonly object SendOutgoingLockObject; // 0xD0
		private readonly object DispatchLockObject; // 0xD8
		private readonly object EnqueueLock; // 0xE0
		protected internal byte[] PayloadEncryptionSecret; // 0xE8
		private Type encryptorType; // 0xF0
		protected internal IPhotonEncryptor Encryptor; // 0xF8
	
		// Properties
		[Obsolete] // 0x00000001800F17D0-0x00000001800F1800
		public int CommandBufferSize { get; set; } // 0x0000000180245EA0-0x0000000180246600 0x00000001802932E0-0x00000001802932F0
		[Obsolete] // 0x00000001800F17D0-0x00000001800F1800
		public int LimitOfUnreliableCommands { get; set; } // 0x00000001802932A0-0x00000001802932B0 0x00000001802932F0-0x0000000180293300
		[Obsolete] // 0x00000001800F1990-0x00000001800F19C0
		public int LocalTimeInMilliSeconds { get => default; } // 0x00000001806C4AA0-0x00000001806C4AF0 
		protected internal byte ClientSdkIdShifted { get => default; } // 0x00000001806C4520-0x00000001806C4530 
		public string ClientVersion { get => default; } // 0x00000001806C4530-0x00000001806C4880 
		public static bool NativeSocketLibAvailable { get => default; } // 0x00000001806C4BF0-0x00000001806C4C50 
		public static bool NativePayloadEncryptionLibAvailable { get => default; } // 0x00000001806C4B90-0x00000001806C4BF0 
		public static bool NativeDatagramEncryptionLibAvailable { get => default; } // 0x00000001806C4B30-0x00000001806C4B90 
		public SerializationProtocol SerializationProtocolType { get; set; } // 0x000000018026C7E0-0x000000018026C7F0 0x000000018026D130-0x000000018026D140
		public Type SocketImplementation { get; internal set; } // 0x0000000180246FD0-0x0000000180246FE0 0x0000000180278400-0x0000000180278410
		public IPhotonPeerListener Listener { get; protected set; } // 0x00000001803F7AF0-0x00000001803F7B00 0x0000000180249C10-0x0000000180249C20
		public bool ReuseEventInstance { get => default; set {} } // 0x00000001806C4E90-0x00000001806C4EA0 0x00000001806C5600-0x00000001806C56E0
		public bool UseByteArraySlicePoolForEvents { get => default; set {} } // 0x00000001806C5070-0x00000001806C5080 0x00000001806C57D0-0x00000001806C57E0
		public ByteArraySlicePool ByteArraySlicePool { get => default; } // 0x00000001806C4450-0x00000001806C4480 
		public long BytesIn { get => default; } // 0x00000001806C44C0-0x00000001806C44F0 
		public long BytesOut { get => default; } // 0x00000001806C44F0-0x00000001806C4520 
		public int ByteCountCurrentDispatch { get => default; } // 0x00000001806C4480-0x00000001806C44A0 
		public string CommandInfoCurrentDispatch { get => default; } // 0x00000001806C4880-0x00000001806C4900 
		public int ByteCountLastOperation { get => default; } // 0x00000001806C44A0-0x00000001806C44C0 
		public bool EnableServerTracing { get; set; } // 0x00000001804033C0-0x00000001804033D0 0x00000001806C5150-0x00000001806C5160
		public byte QuickResendAttempts { get => default; set {} } // 0x00000001806C4DA0-0x00000001806C4DB0 0x00000001806C55E0-0x00000001806C5600
		public PeerStateValue PeerState { get => default; } // 0x00000001806C4CF0-0x00000001806C4D40 
		public string PeerID { get => default; } // 0x00000001806C4CC0-0x00000001806C4CF0 
		public int QueuedIncomingCommands { get => default; } // 0x00000001806C4D40-0x00000001806C4D70 
		public int QueuedOutgoingCommands { get => default; } // 0x00000001806C4D70-0x00000001806C4DA0 
		public bool CrcEnabled { get => default; set {} } // 0x00000001806C4980-0x00000001806C4990 0x00000001806C50B0-0x00000001806C5140
		public int PacketLossByCrc { get => default; } // 0x00000001806C4CA0-0x00000001806C4CC0 
		public int PacketLossByChallenge { get => default; } // 0x00000001806C4C80-0x00000001806C4CA0 
		public int SentReliableCommandsCount { get => default; } // 0x00000001806C4EF0-0x00000001806C4F20 
		public int ResentReliableCommands { get => default; } // 0x00000001806C4DB0-0x00000001806C4E90 
		public int ServerTimeInMilliSeconds { get => default; } // 0x00000001806C4F80-0x00000001806C5000 
		public SupportClass.IntegerMillisecondsDelegate LocalMsTimestampDelegate { set {} } // 0x00000001806C5360-0x00000001806C54A0
		public int ConnectionTime { get => default; } // 0x00000001806C4900-0x00000001806C4970 
		public int LastSendAckTime { get => default; } // 0x00000001806C4A40-0x00000001806C4A70 
		public int LastSendOutgoingTime { get => default; } // 0x00000001806C4A70-0x00000001806C4AA0 
		public int LongestSentCall { get => default; set {} } // 0x00000001806C4AF0-0x00000001806C4B20 0x00000001806C54A0-0x00000001806C54D0
		public int RoundTripTime { get => default; } // 0x00000001806C4ED0-0x00000001806C4EF0 
		public int RoundTripTimeVariance { get => default; } // 0x00000001806C4EA0-0x00000001806C4ED0 
		public int LastRoundTripTime { get => default; } // 0x00000001806C4A10-0x00000001806C4A40 
		public int TimestampOfLastSocketReceive { get => default; } // 0x00000001806C5000-0x00000001806C5030 
		public string ServerAddress { get => default; set {} } // 0x00000001806C4F20-0x00000001806C4F40 0x00000001806C56E0-0x00000001806C5740
		public string ServerIpAddress { get => default; } // 0x00000001806C4F40-0x00000001806C4F80 
		public ConnectionProtocol UsedProtocol { get => default; } // 0x00000001806C5080-0x00000001806C50A0 
		public ConnectionProtocol TransportProtocol { get; set; } // 0x000000018026C820-0x000000018026C830 0x000000018065F170-0x000000018065F180
		public virtual bool IsSimulationEnabled { get => default; set {} } // 0x00000001806C49E0-0x00000001806C4A10 0x00000001806C5250-0x00000001806C5360
		public NetworkSimulationSet NetworkSimulationSettings { get => default; } // 0x00000001806C4C50-0x00000001806C4C80 
		public int MaximumTransferUnit { get => default; set {} } // 0x00000001806C4B20-0x00000001806C4B30 0x00000001806C54D0-0x00000001806C55E0
		public bool IsEncryptionAvailable { get => default; } // 0x00000001806C49B0-0x00000001806C49E0 
		public bool IsSendingOnlyAcks { get; set; } // 0x00000001802E9350-0x00000001802E9360 0x00000001802E9980-0x00000001802E9990
		public TrafficStats TrafficStatsIncoming { get; internal set; } // 0x00000001802749B0-0x00000001802749C0 0x00000001803C9530-0x00000001803C9540
		public TrafficStats TrafficStatsOutgoing { get; internal set; } // 0x00000001802749A0-0x00000001802749B0 0x00000001806C57C0-0x00000001806C57D0
		public TrafficStatsGameLevel TrafficStatsGameLevel { get; internal set; } // 0x0000000180464EB0-0x0000000180464EC0 0x00000001806C57B0-0x00000001806C57C0
		public long TrafficStatsElapsedMs { get => default; } // 0x00000001806C5030-0x00000001806C5060 
		public bool TrafficStatsEnabled { get => default; set {} } // 0x00000001806C5060-0x00000001806C5070 0x00000001806C5740-0x00000001806C57B0
		public Type EncryptorType { get => default; set {} } // 0x00000001806C49A0-0x00000001806C49B0 0x00000001806C5160-0x00000001806C5250
		public int CountDiscarded { get; set; } // 0x00000001806C4970-0x00000001806C4980 0x00000001806C50A0-0x00000001806C50B0
		public int DeltaUnreliableNumber { get; set; } // 0x00000001806C4990-0x00000001806C49A0 0x00000001806C5140-0x00000001806C5150
	
		// Constructors
		public PhotonPeer() {} // Dummy constructor
		public PhotonPeer(ConnectionProtocol protocolType) {} // 0x00000001806C4320-0x00000001806C4450
		public PhotonPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType) {} // 0x00000001806C41D0-0x00000001806C4320
		static PhotonPeer() {} // 0x00000001806C4170-0x00000001806C41D0
	
		// Methods
		private static void CheckNativeLibsAvailability() {} // 0x00000001806C1260-0x00000001806C14F0
		[Obsolete] // 0x00000001800EE6F0-0x00000001800EE720
		public string CommandLogToString() => default; // 0x00000001806C14F0-0x00000001806C1530
		public static void MessageBufferPoolTrim(int countOfBuffers) {} // 0x00000001806C28E0-0x00000001806C2B50
		public static int MessageBufferPoolSize() => default; // 0x00000001806C2870-0x00000001806C28E0
		public void TrafficStatsReset() {} // 0x00000001806C38B0-0x00000001806C3930
		internal void InitializeTrafficStats() {} // 0x00000001806C2710-0x00000001806C2870
		public string VitalStatsToString(bool all) => default; // 0x00000001806C3960-0x00000001806C4170
		public virtual bool Connect(string serverAddress, string applicationName) => default; // 0x00000001806C1530-0x00000001806C1560
		public virtual bool Connect(string serverAddress, string applicationName, object custom) => default; // 0x00000001806C1560-0x00000001806C1590
		public virtual bool Connect(string serverAddress, string proxyServerAddress, string applicationName, object custom) => default; // 0x00000001806C1590-0x00000001806C18D0
		private void CreatePeerBase() {} // 0x00000001806C18D0-0x00000001806C1D80
		public virtual void Disconnect() {} // 0x00000001806C1D80-0x00000001806C1ED0
		public virtual void StopThread() {} // 0x00000001806C3760-0x00000001806C38B0
		public virtual void FetchServerTimestamp() {} // 0x00000001806C20F0-0x00000001806C2120
		public bool EstablishEncryption() => default; // 0x00000001806C1FF0-0x00000001806C20F0
		public bool InitDatagramEncryption(byte[] encryptionSecret, byte[] hmacSecret, bool randomizedSequenceNumbers = false /* Metadata: 0x0064D669 */, bool chaningModeGCM = false /* Metadata: 0x0064D66A */) => default; // 0x00000001806C2120-0x00000001806C2700
		public void InitPayloadEncryption(byte[] secret) {} // 0x00000001806C2700-0x00000001806C2710
		public virtual void Service() {} // 0x00000001806C3710-0x00000001806C3760
		public virtual bool SendOutgoingCommands() => default; // 0x00000001806C3600-0x00000001806C3710
		public virtual bool SendAcksOnly() => default; // 0x00000001806C3340-0x00000001806C3450
		public virtual bool DispatchIncomingCommands() => default; // 0x00000001806C1ED0-0x00000001806C1FF0
		public virtual bool SendOperation(byte operationCode, Dictionary<byte, object> operationParameters, SendOptions sendOptions) => default; // 0x00000001806C3450-0x00000001806C3600
		[Obsolete] // 0x00000001800F1560-0x00000001800F1590
		public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable, byte channelId = 0 /* Metadata: 0x0064D66B */, bool encrypt = false /* Metadata: 0x0064D66C */) => default; // 0x00000001806C2D30-0x00000001806C2F00
		[Obsolete] // 0x00000001800F1560-0x00000001800F1590
		public virtual bool OpCustom(OperationRequest operationRequest, bool sendReliable, byte channelId, bool encrypt) => default; // 0x00000001806C2B50-0x00000001806C2D30
		public static bool RegisterType(Type customType, byte code, SerializeMethod serializeMethod, DeserializeMethod constructor) => default; // 0x00000001806C2F00-0x00000001806C3120
		public static bool RegisterType(Type customType, byte code, SerializeStreamMethod serializeMethod, DeserializeStreamMethod constructor) => default; // 0x00000001806C3120-0x00000001806C3340
	}
}
