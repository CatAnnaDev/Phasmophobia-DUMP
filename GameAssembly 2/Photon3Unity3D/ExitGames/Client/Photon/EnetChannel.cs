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
	internal class EnetChannel // TypeDefIndex: 4251
	{
		// Fields
		internal byte ChannelNumber; // 0x10
		internal Dictionary<int, NCommand> incomingReliableCommandsList; // 0x18
		internal Dictionary<int, NCommand> incomingUnreliableCommandsList; // 0x20
		internal Queue<NCommand> incomingUnsequencedCommandsList; // 0x28
		internal Dictionary<int, NCommand> incomingUnsequencedFragments; // 0x30
		internal Queue<NCommand> outgoingReliableCommandsList; // 0x38
		internal Queue<NCommand> outgoingUnreliableCommandsList; // 0x40
		internal int incomingReliableSequenceNumber; // 0x48
		internal int incomingUnreliableSequenceNumber; // 0x4C
		internal int outgoingReliableSequenceNumber; // 0x50
		internal int outgoingUnreliableSequenceNumber; // 0x54
		internal int outgoingReliableUnsequencedNumber; // 0x58
		private int reliableUnsequencedNumbersCompletelyReceived; // 0x5C
		private HashSet<int> reliableUnsequencedNumbersReceived; // 0x60
	
		// Constructors
		public EnetChannel() {} // Dummy constructor
		public EnetChannel(byte channelNumber, int commandBufferSize) {} // 0x00000001806AFC90-0x00000001806AFE30
	
		// Methods
		public bool ContainsUnreliableSequenceNumber(int unreliableSequenceNumber) => default; // 0x00000001806AF930-0x00000001806AF990
		public NCommand FetchUnreliableSequenceNumber(int unreliableSequenceNumber) => default; // 0x00000001806AF9F0-0x00000001806AFA50
		public bool ContainsReliableSequenceNumber(int reliableSequenceNumber) => default; // 0x00000001806AF8D0-0x00000001806AF930
		public NCommand FetchReliableSequenceNumber(int reliableSequenceNumber) => default; // 0x00000001806AF990-0x00000001806AF9F0
		public bool TryGetFragment(int reliableSequenceNumber, bool isSequenced, out NCommand fragment) {
			fragment = default;
			return default;
		} // 0x00000001806AFC10-0x00000001806AFC90
		public void RemoveFragment(int reliableSequenceNumber, bool isSequenced) {} // 0x00000001806AFBA0-0x00000001806AFC10
		public void clearAll() {} // 0x00000001806AFE30-0x00000001806AFF90
		public bool QueueIncomingReliableUnsequenced(NCommand command) => default; // 0x00000001806AFA50-0x00000001806AFBA0
	}
}
