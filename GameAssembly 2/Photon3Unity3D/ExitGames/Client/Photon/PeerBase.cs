/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Photon.SocketServer.Security;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public abstract class PeerBase // TypeDefIndex: 4271
	{
		// Fields
		internal PhotonPeer photonPeer; // 0x10
		public IProtocol SerializationProtocol; // 0x18
		internal NCommandPool nCommandPool; // 0x20
		internal ConnectionProtocol usedTransportProtocol; // 0x28
		internal IPhotonSocket PhotonSocket; // 0x30
		internal ConnectionStateValue peerConnectionState; // 0x48
		internal int ByteCountLastOperation; // 0x4C
		internal int ByteCountCurrentDispatch; // 0x50
		internal NCommand CommandInCurrentDispatch; // 0x58
		internal int packetLossByCrc; // 0x60
		internal int packetLossByChallenge; // 0x64
		internal readonly Queue<MyAction> ActionQueue; // 0x68
		internal short peerID; // 0x70
		internal int serverTimeOffset; // 0x74
		internal bool serverTimeOffsetIsAvailable; // 0x78
		internal int roundTripTime; // 0x7C
		internal int roundTripTimeVariance; // 0x80
		internal int lastRoundTripTime; // 0x84
		internal int lowestRoundTripTime; // 0x88
		internal int highestRoundTripTimeVariance; // 0x8C
		internal int timestampOfLastReceive; // 0x90
		internal static short peerCount; // 0x00
		internal long bytesOut; // 0x98
		internal long bytesIn; // 0xA0
		internal object CustomInitData; // 0xA8
		public string AppId; // 0xB0
		internal EventData reusableEventData; // 0xB8
		internal int timeBase; // 0xC0
		internal int timeoutInt; // 0xC4
		internal int timeLastAckReceive; // 0xC8
		internal int longestSentCall; // 0xCC
		internal int timeLastSendAck; // 0xD0
		internal int timeLastSendOutgoing; // 0xD4
		internal bool ApplicationIsInitialized; // 0xD8
		internal bool isEncryptionAvailable; // 0xD9
		internal int outgoingCommandsInStream; // 0xDC
		protected internal static Queue<StreamBuffer> MessageBufferPool; // 0x08
		internal ICryptoProvider CryptoProvider; // 0xE0
		private readonly Random lagRandomizer; // 0xE8
		internal readonly LinkedList<SimulationItem> NetSimListOutgoing; // 0xF0
		internal readonly LinkedList<SimulationItem> NetSimListIncoming; // 0xF8
		private readonly NetworkSimulationSet networkSimulationSettings; // 0x100
		internal int TrafficPackageHeaderSize; // 0x108
	
		// Properties
		internal Type SocketImplementation { get; } // 0x00000001806C1020-0x00000001806C1040 
		public string ServerAddress { get; internal set; } // 0x0000000180246FD0-0x0000000180246FE0 0x0000000180278400-0x0000000180278410
		public string ProxyServerAddress { get; internal set; } // 0x0000000180249A10-0x0000000180249A20 0x0000000180249920-0x0000000180249930
		internal IPhotonPeerListener Listener { get; } // 0x00000001806C0FC0-0x00000001806C0FE0 
		public DebugLevel debugOut { get; } // 0x00000001806C10C0-0x00000001806C10E0 
		internal int DisconnectTimeout { get; } // 0x00000001806C0F60-0x00000001806C0F80 
		internal int timePingInterval { get; } // 0x00000001806C11C0-0x00000001806C11E0 
		internal byte ChannelCount { get; } // 0x00000001806C0F40-0x00000001806C0F60 
		internal long BytesOut { get; } // 0x00000001806C0F30-0x00000001806C0F40 
		internal long BytesIn { get; } // 0x00000001806C0F20-0x00000001806C0F30 
		internal abstract int QueuedIncomingCommandsCount { get; }
		internal abstract int QueuedOutgoingCommandsCount { get; }
		internal virtual int SentReliableCommandsCount { get; } // 0x00000001806C1010-0x00000001806C1020 
		public virtual string PeerID { get; } // 0x00000001806C0FF0-0x00000001806C1010 
		internal int timeInt { get; } // 0x00000001806C1160-0x00000001806C11C0 
		internal static int outgoingStreamBufferSize { get; } // 0x00000001806C1100-0x00000001806C1160 
		internal bool IsSendingOnlyAcks { get; } // 0x00000001806C0FA0-0x00000001806C0FC0 
		internal int mtu { get; } // 0x00000001806C10E0-0x00000001806C1100 
		protected internal bool IsIpv6 { get; } // 0x00000001806C0F80-0x00000001806C0FA0 
		public NetworkSimulationSet NetworkSimulationSettings { get; } // 0x00000001806C0FE0-0x00000001806C0FF0 
		internal bool TrafficStatsEnabled { get; } // 0x00000001806C1040-0x00000001806C1060 
		internal TrafficStats TrafficStatsIncoming { get; } // 0x00000001806C1080-0x00000001806C10A0 
		internal TrafficStats TrafficStatsOutgoing { get; } // 0x00000001806C10A0-0x00000001806C10C0 
		internal TrafficStatsGameLevel TrafficStatsGameLevel { get; } // 0x00000001806C1060-0x00000001806C1080 
	
		// Nested types
		internal delegate void MyAction(); // TypeDefIndex: 4272; 0x00000001803DC3F0-0x00000001803DC600
	
		// Constructors
		protected PeerBase() {} // 0x00000001806C0CB0-0x00000001806C0F20
		static PeerBase() {} // 0x00000001806C0C40-0x00000001806C0CB0
	
		// Methods
		public static StreamBuffer MessageBufferPoolGet() => default; // 0x00000001806BF1A0-0x00000001806BF360
		public static void MessageBufferPoolPut(StreamBuffer buff) {} // 0x00000001806BF360-0x00000001806BF4C0
		internal virtual void InitPeerBase() {} // 0x00000001806BEF10-0x00000001806BF1A0
		internal abstract bool Connect(string serverAddress, string appID, object customData = null);
		internal abstract bool Connect(string serverAddress, string proxyServerAddress, string appID, object customData);
		private string GetHttpKeyValueString(Dictionary<string, string> dic) => default; // 0x00000001806BEB50-0x00000001806BED50
		internal byte[] PrepareConnectData(string serverAddress, string appID, object custom) => default; // 0x00000001806BFBF0-0x00000001806C01C0
		internal string PepareWebSocketUrl(string serverAddress, string appId, object customData) => default; // 0x00000001806BF8E0-0x00000001806BFBF0
		public abstract void OnConnect();
		internal void InitCallback() {} // 0x00000001806BED50-0x00000001806BEDD0
		internal abstract void Disconnect();
		internal abstract void StopConnection();
		internal abstract void FetchServerTimestamp();
		internal abstract bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, SendOptions sendParams, EgMessageType messageType = EgMessageType.Operation /* Metadata: 0x0064D659 */);
		internal abstract StreamBuffer SerializeOperationToMessage(byte opCode, Dictionary<byte, object> parameters, EgMessageType messageType, bool encrypt);
		internal abstract bool EnqueueMessage(object message, SendOptions sendOptions);
		internal StreamBuffer SerializeMessageToMessage(object message, bool encrypt, byte[] messageHeader, bool writeLength = true /* Metadata: 0x0064D65A */) => default; // 0x00000001806C08D0-0x00000001806C0BA0
		internal abstract bool SendOutgoingCommands();
		internal virtual bool SendAcksOnly() => default; // 0x00000001806C0540-0x00000001806C0550
		internal abstract void ReceiveIncomingCommands(byte[] inBuff, int dataLength);
		internal abstract bool DispatchIncomingCommands();
		internal virtual bool DeserializeMessageAndCallback(StreamBuffer stream) => default; // 0x00000001806BD680-0x00000001806BE3A0
		internal void UpdateRoundTripTimeAndVariance(int lastRoundtripTime) {} // 0x00000001806C0BA0-0x00000001806C0C40
		internal bool ExchangeKeysForEncryption(object lockObject) => default; // 0x00000001806BE760-0x00000001806BEB50
		internal void DeriveSharedKey(OperationResponse operationResponse) {} // 0x00000001806BD470-0x00000001806BD680
		internal virtual void InitEncryption(byte[] secret) {} // 0x00000001806BEDD0-0x00000001806BEF10
		internal void EnqueueActionForDispatch(MyAction action) {} // 0x00000001806BE3A0-0x00000001806BE480
		internal void EnqueueDebugReturn(DebugLevel level, string debugReturn) {} // 0x00000001806BE480-0x00000001806BE600
		internal void EnqueueStatusCallback(StatusCode statusValue) {} // 0x00000001806BE600-0x00000001806BE760
		internal void SendNetworkSimulated(byte[] dataToSend) {} // 0x00000001806C0550-0x00000001806C08D0
		internal void ReceiveNetworkSimulated(byte[] dataReceived) {} // 0x00000001806C01C0-0x00000001806C0540
		protected internal void NetworkSimRun() {} // 0x00000001806BF4C0-0x00000001806BF8E0
	}
}
