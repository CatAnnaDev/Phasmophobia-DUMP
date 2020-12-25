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
	public class TrafficStats // TypeDefIndex: 4314
	{
		// Properties
		public int PackageHeaderSize { get; internal set; } // 0x0000000180245EA0-0x0000000180246600 0x00000001802932E0-0x00000001802932F0
		public int ReliableCommandCount { get; internal set; } // 0x00000001802932A0-0x00000001802932B0 0x00000001802932F0-0x0000000180293300
		public int UnreliableCommandCount { get; internal set; } // 0x000000018027A800-0x000000018027A810 0x000000018027AC40-0x000000018027AC50
		public int FragmentCommandCount { get; internal set; } // 0x000000018027A6E0-0x000000018027A6F0 0x00000001802D6530-0x00000001802D6540
		public int ControlCommandCount { get; internal set; } // 0x00000001802800D0-0x00000001802800E0 0x0000000180293310-0x0000000180293320
		public int TotalPacketCount { get; internal set; } // 0x000000018027A6B0-0x000000018027A6C0 0x0000000180326FA0-0x0000000180326FB0
		public int TotalCommandsInPackets { get; internal set; } // 0x000000018026C7E0-0x000000018026C7F0 0x000000018026D130-0x000000018026D140
		public int ReliableCommandBytes { get; internal set; } // 0x000000018026C890-0x000000018026C8A0 0x00000001803B49F0-0x00000001803B4A00
		public int UnreliableCommandBytes { get; internal set; } // 0x0000000180250A60-0x0000000180250A70 0x000000018041F060-0x000000018041F070
		public int FragmentCommandBytes { get; internal set; } // 0x0000000180293280-0x0000000180293290 0x00000001802932D0-0x00000001802932E0
		public int ControlCommandBytes { get; internal set; } // 0x00000001802932B0-0x00000001802932C0 0x00000001802D5D10-0x00000001802D5D20
		public int TotalCommandCount { get => default; } // 0x0000000180A91990-0x0000000180A919A0 
		public int TotalCommandBytes { get => default; } // 0x0000000180A91980-0x0000000180A91990 
		public int TotalPacketBytes { get => default; } // 0x0000000180A919A0-0x0000000180A919C0 
		public int TimestampOfLastAck { get; set; } // 0x00000001805156B0-0x00000001805156C0 0x0000000180400EC0-0x0000000180400ED0
		public int TimestampOfLastReliableCommand { get; set; } // 0x00000001802F3F40-0x00000001802F3F50 0x0000000180469EA0-0x0000000180469EB0
	
		// Constructors
		public TrafficStats() {} // Dummy constructor
		internal TrafficStats(int packageHeaderSize) {} // 0x0000000180293220-0x0000000180293250
	
		// Methods
		internal void CountControlCommand(int size) {} // 0x0000000180A91700-0x0000000180A91710
		internal void CountReliableOpCommand(int size) {} // 0x0000000180A91720-0x0000000180A91730
		internal void CountUnreliableOpCommand(int size) {} // 0x0000000180A91730-0x0000000180A91740
		internal void CountFragmentOpCommand(int size) {} // 0x0000000180A91710-0x0000000180A91720
		public override string ToString() => default; // 0x0000000180A91740-0x0000000180A91980
	}
}
