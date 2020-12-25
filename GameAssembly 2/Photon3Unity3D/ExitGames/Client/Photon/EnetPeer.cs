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
	internal class EnetPeer : PeerBase // TypeDefIndex: 4252
	{
		// Fields
		private const int CRC_LENGTH = 4; // Metadata: 0x0064D575
		protected internal const int HMAC_SIZE = 32; // Metadata: 0x0064D579
		protected internal const int BLOCK_SIZE = 16; // Metadata: 0x0064D57D
		protected internal const int IV_SIZE = 16; // Metadata: 0x0064D581
		private const int EncryptedDataGramHeaderSize = 7; // Metadata: 0x0064D585
		private const int EncryptedHeaderSize = 5; // Metadata: 0x0064D589
		private List<NCommand> sentReliableCommands; // 0x110
		private StreamBuffer outgoingAcknowledgementsPool; // 0x118
		internal const int UnsequencedWindowSize = 128; // Metadata: 0x0064D58D
		internal readonly int[] unsequencedWindow; // 0x120
		internal int outgoingUnsequencedGroupNumber; // 0x128
		internal int incomingUnsequencedGroupNumber; // 0x12C
		private byte udpCommandCount; // 0x130
		private byte[] udpBuffer; // 0x138
		private int udpBufferIndex; // 0x140
		private byte[] bufferForEncryption; // 0x148
		private int commandBufferSize; // 0x150
		internal int challenge; // 0x154
		internal int reliableCommandsRepeated; // 0x158
		internal int reliableCommandsSent; // 0x15C
		internal int serverSentTime; // 0x160
		internal static readonly byte[] udpHeader0xF3; // 0x00
		internal static readonly byte[] messageHeader; // 0x08
		protected bool datagramEncryptedConnection; // 0x164
		private EnetChannel[] channelArray; // 0x168
		private const byte ControlChannelNumber = 255; // Metadata: 0x0064D591
		protected internal const short PeerIdForConnect = -1; // Metadata: 0x0064D592
		protected internal const short PeerIdForConnectTrace = -2; // Metadata: 0x0064D594
		private Queue<int> commandsToRemove; // 0x170
		private int fragmentLength; // 0x178
		private int fragmentLengthDatagramEncrypt; // 0x17C
		private int fragmentLengthMtuValue; // 0x180
		private readonly Queue<NCommand> commandsToResend; // 0x188
		private Queue<NCommand> CommandQueue; // 0x190
	
		// Properties
		internal override int QueuedIncomingCommandsCount { get => default; } // 0x00000001806B8270-0x00000001806B8400 
		internal override int QueuedOutgoingCommandsCount { get => default; } // 0x00000001806B8400-0x00000001806B8630 
		internal override int SentReliableCommandsCount { get => default; } // 0x00000001806B8630-0x00000001806B8670 
	
		// Constructors
		internal EnetPeer() {} // 0x00000001806B80E0-0x00000001806B8270
		static EnetPeer() {} // 0x00000001806B8030-0x00000001806B80E0
	
		// Methods
		internal override void InitPeerBase() {} // 0x00000001806B3490-0x00000001806B3990
		internal void ApplyRandomizedSequenceNumbers() {} // 0x00000001806AFF90-0x00000001806B03C0
		internal override bool Connect(string ipport, string appID, object custom = null) => default; // 0x00000001806B06D0-0x00000001806B0700
		internal override bool Connect(string ipport, string proxyServerAddress, string appID, object custom) => default; // 0x00000001806B0700-0x00000001806B0A20
		public override void OnConnect() {} // 0x00000001806B3990-0x00000001806B39E0
		internal override void Disconnect() {} // 0x00000001806B0EB0-0x00000001806B11F0
		internal override void StopConnection() {} // 0x00000001806B7F80-0x00000001806B8000
		internal override void FetchServerTimestamp() {} // 0x00000001806B32A0-0x00000001806B3390
		internal override bool DispatchIncomingCommands() => default; // 0x00000001806B11F0-0x00000001806B1B30
		private int GetFragmentLength() => default; // 0x00000001806B3400-0x00000001806B3490
		private int CalculatePacketSize(int inSize) => default; // 0x00000001806B0560-0x00000001806B0580
		private int CalculateInitialOffset() => default; // 0x00000001806B0520-0x00000001806B0560
		internal override bool SendAcksOnly() => default; // 0x00000001806B5B80-0x00000001806B6090
		internal override bool SendOutgoingCommands() => default; // 0x00000001806B6740-0x00000001806B7640
		private bool AreReliableCommandsInTransit() => default; // 0x00000001806B03C0-0x00000001806B0520
		internal override bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, SendOptions sendParams, EgMessageType messageType = EgMessageType.Operation /* Metadata: 0x0064D574 */) => default; // 0x00000001806B1F60-0x00000001806B23A0
		internal override bool EnqueueMessage(object message, SendOptions sendOptions) => default; // 0x00000001806B1B30-0x00000001806B1F60
		private EnetChannel GetChannel(byte channelNumber) => default; // 0x00000001806B3390-0x00000001806B3400
		internal bool CreateAndEnqueueCommand(byte commandType, StreamBuffer payload, byte channelNumber) => default; // 0x00000001806B0A20-0x00000001806B0EB0
		internal override StreamBuffer SerializeOperationToMessage(byte opCode, Dictionary<byte, object> parameters, EgMessageType messageType, bool encrypt) => default; // 0x00000001806B79F0-0x00000001806B7D10
		internal int SerializeAckToBuffer() => default; // 0x00000001806B77B0-0x00000001806B79F0
		internal int SerializeToBuffer(Queue<NCommand> commandList) => default; // 0x00000001806B7D10-0x00000001806B7F80
		internal void SendData(byte[] data, int length) {} // 0x00000001806B6400-0x00000001806B6740
		private void SendToSocket(byte[] data, int length) {} // 0x00000001806B7640-0x00000001806B77B0
		private void SendDataEncrypted(byte[] data, int length) {} // 0x00000001806B6090-0x00000001806B6400
		internal void QueueSentCommand(NCommand command) {} // 0x00000001806B4AF0-0x00000001806B4D60
		internal void QueueOutgoingReliableCommand(NCommand command) {} // 0x00000001806B4730-0x00000001806B48F0
		internal void QueueOutgoingUnreliableCommand(NCommand command) {} // 0x00000001806B48F0-0x00000001806B4AF0
		internal void QueueOutgoingAcknowledgement(NCommand readCommand, int sendTime) {} // 0x00000001806B4500-0x00000001806B4730
		internal override void ReceiveIncomingCommands(byte[] inBuff, int inDataLength) {} // 0x00000001806B4D60-0x00000001806B5850
		internal void ExecuteCommand(NCommand command) {} // 0x00000001806B23A0-0x00000001806B32A0
		internal bool QueueIncomingCommand(NCommand command) => default; // 0x00000001806B39E0-0x00000001806B4500
		internal NCommand RemoveSentReliableCommand(int ackReceivedReliableSequenceNumber, int ackReceivedChannel, bool isUnsequenced) => default; // 0x00000001806B5850-0x00000001806B5B80
		internal string CommandListToString(NCommand[] list) => default; // 0x00000001806B0580-0x00000001806B06D0
	}
}
