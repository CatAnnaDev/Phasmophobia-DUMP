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
	public class TrafficStatsGameLevel // TypeDefIndex: 4313
	{
		// Fields
		private int timeOfLastDispatchCall; // 0x10
		private int timeOfLastSendCall; // 0x14
	
		// Properties
		public int OperationByteCount { get; set; } // 0x000000018027A800-0x000000018027A810 0x000000018027AC40-0x000000018027AC50
		public int OperationCount { get; set; } // 0x000000018027A6E0-0x000000018027A6F0 0x00000001802D6530-0x00000001802D6540
		public int ResultByteCount { get; set; } // 0x00000001802800D0-0x00000001802800E0 0x0000000180293310-0x0000000180293320
		public int ResultCount { get; set; } // 0x000000018027A6B0-0x000000018027A6C0 0x0000000180326FA0-0x0000000180326FB0
		public int EventByteCount { get; set; } // 0x000000018026C7E0-0x000000018026C7F0 0x000000018026D130-0x000000018026D140
		public int EventCount { get; set; } // 0x000000018026C890-0x000000018026C8A0 0x00000001803B49F0-0x00000001803B4A00
		public int LongestOpResponseCallback { get; set; } // 0x0000000180250A60-0x0000000180250A70 0x000000018041F060-0x000000018041F070
		public byte LongestOpResponseCallbackOpCode { get; set; } // 0x000000018053C3D0-0x000000018053C3E0 0x000000018053C3E0-0x000000018053C3F0
		public int LongestEventCallback { get; set; } // 0x00000001802932B0-0x00000001802932C0 0x00000001802D5D10-0x00000001802D5D20
		public int LongestMessageCallback { get; set; } // 0x00000001805156B0-0x00000001805156C0 0x0000000180400EC0-0x0000000180400ED0
		public int LongestRawMessageCallback { get; set; } // 0x00000001802F3F40-0x00000001802F3F50 0x0000000180469EA0-0x0000000180469EB0
		public byte LongestEventCallbackCode { get; set; } // 0x0000000180A916A0-0x0000000180A916B0 0x0000000180A916F0-0x0000000180A91700
		public int LongestDeltaBetweenDispatching { get; set; } // 0x00000001802456E0-0x00000001802456F0 0x0000000180428400-0x0000000180428410
		public int LongestDeltaBetweenSending { get; set; } // 0x000000018038D7B0-0x000000018038D7C0 0x000000018038D730-0x000000018038D740
		[Obsolete] // 0x00000001800F5DB0-0x00000001800F5DE0
		public int DispatchCalls { get => default; } // 0x0000000180A91690-0x0000000180A916A0 
		public int DispatchIncomingCommandsCalls { get; set; } // 0x0000000180255F80-0x0000000180255F90 0x0000000180422DE0-0x0000000180422DF0
		public int SendOutgoingCommandsCalls { get; set; } // 0x0000000180400CB0-0x0000000180400CC0 0x0000000180400D60-0x0000000180400D70
		public int TotalByteCount { get => default; } // 0x0000000180A916B0-0x0000000180A916C0 
		public int TotalMessageCount { get => default; } // 0x0000000180A916E0-0x0000000180A916F0 
		public int TotalIncomingByteCount { get => default; } // 0x0000000180A916C0-0x0000000180A916D0 
		public int TotalIncomingMessageCount { get => default; } // 0x0000000180A916D0-0x0000000180A916E0 
		public int TotalOutgoingByteCount { get => default; } // 0x00000001806BC980-0x00000001806BC990 
		public int TotalOutgoingMessageCount { get => default; } // 0x00000001806BC9A0-0x00000001806BC9B0 
	
		// Constructors
		public TrafficStatsGameLevel() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		internal void CountOperation(int operationBytes) {} // 0x0000000180A91060-0x0000000180A91070
		internal void CountResult(int resultBytes) {} // 0x0000000180A91070-0x0000000180A91080
		internal void CountEvent(int eventBytes) {} // 0x0000000180A91050-0x0000000180A91060
		internal void TimeForResponseCallback(byte code, int time) {} // 0x0000000180A911F0-0x0000000180A91200
		internal void TimeForEventCallback(byte code, int time) {} // 0x0000000180A911C0-0x0000000180A911D0
		internal void TimeForMessageCallback(int time) {} // 0x0000000180A911D0-0x0000000180A911E0
		internal void TimeForRawMessageCallback(int time) {} // 0x0000000180A911E0-0x0000000180A911F0
		internal void DispatchIncomingCommandsCalled() {} // 0x0000000180A91080-0x0000000180A91110
		internal void SendOutgoingCommandsCalled() {} // 0x0000000180A91130-0x0000000180A911C0
		public void ResetMaximumCounters() {} // 0x0000000180A91110-0x0000000180A91130
		public override string ToString() => default; // 0x0000000180A915F0-0x0000000180A91690
		public string ToStringVitalStats() => default; // 0x0000000180A91200-0x0000000180A915F0
	}
}
