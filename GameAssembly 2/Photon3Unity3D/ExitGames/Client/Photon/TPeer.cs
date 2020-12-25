/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	internal class TPeer : PeerBase // TypeDefIndex: 4312
	{
		// Fields
		internal const int TCP_HEADER_BYTES = 7; // Metadata: 0x0064D70E
		internal const int MSG_HEADER_BYTES = 2; // Metadata: 0x0064D712
		public const int ALL_HEADER_BYTES = 9; // Metadata: 0x0064D716
		private Queue<byte[]> incomingList; // 0x110
		internal List<StreamBuffer> outgoingStream; // 0x118
		private int lastPingResult; // 0x120
		private byte[] pingRequest; // 0x128
		internal static readonly byte[] tcpFramedMessageHead; // 0x00
		internal static readonly byte[] tcpMsgHead; // 0x08
		internal byte[] messageHeader; // 0x130
		protected internal bool DoFraming; // 0x138
	
		// Properties
		internal override int QueuedIncomingCommandsCount { get => default; } // 0x0000000180A90E50-0x0000000180A90E90 
		internal override int QueuedOutgoingCommandsCount { get => default; } // 0x0000000180A90E90-0x0000000180A90EA0 
	
		// Constructors
		internal TPeer() {} // 0x0000000180A90D60-0x0000000180A90E50
		static TPeer() {} // 0x0000000180A90C80-0x0000000180A90D60
	
		// Methods
		internal override void InitPeerBase() {} // 0x0000000180A8F960-0x0000000180A8FA00
		internal override bool Connect(string serverAddress, string appID, object customData = null) => default; // 0x00000001806B06D0-0x00000001806B0700
		internal override bool Connect(string serverAddress, string proxyServerAddress, string appID, object customData) => default; // 0x0000000180A8E300-0x0000000180A8E6B0
		public override void OnConnect() {} // 0x0000000180A8FA00-0x0000000180A8FAB0
		internal override void Disconnect() {} // 0x0000000180A8E6B0-0x0000000180A8E750
		internal override void StopConnection() {} // 0x0000000180A90B60-0x0000000180A90C80
		internal override void FetchServerTimestamp() {} // 0x0000000180A8F830-0x0000000180A8F960
		private void EnqueueInit(byte[] data) {} // 0x0000000180A8EAC0-0x0000000180A8ED10
		internal override bool DispatchIncomingCommands() => default; // 0x0000000180A8E750-0x0000000180A8EAC0
		internal override bool SendOutgoingCommands() => default; // 0x0000000180A90410-0x0000000180A90660
		internal override bool SendAcksOnly() => default; // 0x0000000180A90180-0x0000000180A90230
		internal override bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, SendOptions sendParams, EgMessageType messageType) => default; // 0x0000000180A8F410-0x0000000180A8F830
		internal override bool EnqueueMessage(object msg, SendOptions sendOptions) => default; // 0x0000000180A8F050-0x0000000180A8F410
		internal override StreamBuffer SerializeOperationToMessage(byte opCode, Dictionary<byte, object> parameters, EgMessageType messageType, bool encrypt) => default; // 0x0000000180A908B0-0x0000000180A90B60
		internal bool EnqueueMessageAsPayload(DeliveryMode deliveryMode, StreamBuffer opMessage, byte channelId) => default; // 0x0000000180A8ED10-0x0000000180A8F050
		internal void SendPing() {} // 0x0000000180A90660-0x0000000180A908B0
		internal void SendData(byte[] data, int length) {} // 0x0000000180A90230-0x0000000180A90410
		internal override void ReceiveIncomingCommands(byte[] inbuff, int dataLength) {} // 0x0000000180A8FD40-0x0000000180A90180
		private void ReadPingResult(byte[] inbuff) {} // 0x0000000180A8FC20-0x0000000180A8FD40
		protected internal void ReadPingResult(OperationResponse operationResponse) {} // 0x0000000180A8FAB0-0x0000000180A8FC20
	}
}
