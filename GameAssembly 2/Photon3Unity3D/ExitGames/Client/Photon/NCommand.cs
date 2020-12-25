/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	internal class NCommand : IComparable<ExitGames.Client.Photon.NCommand> // TypeDefIndex: 4265
	{
		// Fields
		internal const byte FV_UNRELIABLE = 0; // Metadata: 0x0064D606
		internal const byte FV_RELIABLE = 1; // Metadata: 0x0064D607
		internal const byte FV_UNRELIABLE_UNSEQUENCED = 2; // Metadata: 0x0064D608
		internal const byte FV_RELIBALE_UNSEQUENCED = 3; // Metadata: 0x0064D609
		internal const byte CT_NONE = 0; // Metadata: 0x0064D60A
		internal const byte CT_ACK = 1; // Metadata: 0x0064D60B
		internal const byte CT_CONNECT = 2; // Metadata: 0x0064D60C
		internal const byte CT_VERIFYCONNECT = 3; // Metadata: 0x0064D60D
		internal const byte CT_DISCONNECT = 4; // Metadata: 0x0064D60E
		internal const byte CT_PING = 5; // Metadata: 0x0064D60F
		internal const byte CT_SENDRELIABLE = 6; // Metadata: 0x0064D610
		internal const byte CT_SENDUNRELIABLE = 7; // Metadata: 0x0064D611
		internal const byte CT_SENDFRAGMENT = 8; // Metadata: 0x0064D612
		internal const byte CT_SENDUNSEQUENCED = 11; // Metadata: 0x0064D613
		internal const byte CT_EG_SERVERTIME = 12; // Metadata: 0x0064D614
		internal const byte CT_EG_SEND_UNRELIABLE_PROCESSED = 13; // Metadata: 0x0064D615
		internal const byte CT_EG_SEND_RELIABLE_UNSEQUENCED = 14; // Metadata: 0x0064D616
		internal const byte CT_EG_SEND_FRAGMENT_UNSEQUENCED = 15; // Metadata: 0x0064D617
		internal const byte CT_EG_ACK_UNSEQUENCED = 16; // Metadata: 0x0064D618
		internal const int HEADER_UDP_PACK_LENGTH = 12; // Metadata: 0x0064D619
		internal const int CmdSizeMinimum = 12; // Metadata: 0x0064D61D
		internal const int CmdSizeAck = 20; // Metadata: 0x0064D621
		internal const int CmdSizeConnect = 44; // Metadata: 0x0064D625
		internal const int CmdSizeVerifyConnect = 44; // Metadata: 0x0064D629
		internal const int CmdSizeDisconnect = 12; // Metadata: 0x0064D62D
		internal const int CmdSizePing = 12; // Metadata: 0x0064D631
		internal const int CmdSizeReliableHeader = 12; // Metadata: 0x0064D635
		internal const int CmdSizeUnreliableHeader = 16; // Metadata: 0x0064D639
		internal const int CmdSizeUnsequensedHeader = 16; // Metadata: 0x0064D63D
		internal const int CmdSizeFragmentHeader = 32; // Metadata: 0x0064D641
		internal const int CmdSizeMaxHeader = 36; // Metadata: 0x0064D645
		internal byte commandFlags; // 0x10
		internal byte commandType; // 0x11
		internal byte commandChannelID; // 0x12
		internal int reliableSequenceNumber; // 0x14
		internal int unreliableSequenceNumber; // 0x18
		internal int unsequencedGroupNumber; // 0x1C
		internal byte reservedByte; // 0x20
		internal int startSequenceNumber; // 0x24
		internal int fragmentCount; // 0x28
		internal int fragmentNumber; // 0x2C
		internal int totalLength; // 0x30
		internal int fragmentOffset; // 0x34
		internal int fragmentsRemaining; // 0x38
		internal int commandSentTime; // 0x3C
		internal byte commandSentCount; // 0x40
		internal int roundTripTimeout; // 0x44
		internal int timeoutTime; // 0x48
		internal int ackReceivedReliableSequenceNumber; // 0x4C
		internal int ackReceivedSentTime; // 0x50
		internal int Size; // 0x54
		private byte[] commandHeader; // 0x58
		internal int SizeOfHeader; // 0x60
		internal StreamBuffer Payload; // 0x68
		internal NCommandPool returnPool; // 0x70
	
		// Properties
		protected internal int SizeOfPayload { get => default; } // 0x00000001806BC520-0x00000001806BC540 
		protected internal bool IsFlaggedUnsequenced { get => default; } // 0x00000001806BC510-0x00000001806BC520 
		protected internal bool IsFlaggedReliable { get => default; } // 0x00000001806BC500-0x00000001806BC510 
	
		// Constructors
		public NCommand() {} // Dummy constructor
		internal NCommand(EnetPeer peer, byte commandType, StreamBuffer payload, byte channel) {} // 0x00000001806BC430-0x00000001806BC4A0
		internal NCommand(EnetPeer peer, byte[] inBuff, ref int readingOffset) {} // 0x00000001806BC4A0-0x00000001806BC500
	
		// Methods
		internal static void CreateAck(byte[] buffer, int offset, NCommand commandToAck, int sentTime) {} // 0x00000001806BB190-0x00000001806BB310
		internal void Initialize(EnetPeer peer, byte commandType, StreamBuffer payload, byte channel) {} // 0x00000001806BB390-0x00000001806BB790
		internal void Initialize(EnetPeer peer, byte[] inBuff, ref int readingOffset) {} // 0x00000001806BB790-0x00000001806BBBC0
		public void Reset() {} // 0x00000001806BBBF0-0x00000001806BBC30
		internal void SerializeHeader(byte[] buffer, ref int bufferIndex) {} // 0x00000001806BBC30-0x00000001806BBE70
		internal byte[] Serialize() => default; // 0x00000001806BBE70-0x00000001806BBE90
		public void FreePayload() {} // 0x00000001806BB310-0x00000001806BB390
		public void Release() {} // 0x00000001806BBBC0-0x00000001806BBBF0
		public int CompareTo(NCommand other) => default; // 0x00000001806BB160-0x00000001806BB190
		public override string ToString() => default; // 0x00000001806BBE90-0x00000001806BC430
	}
}
