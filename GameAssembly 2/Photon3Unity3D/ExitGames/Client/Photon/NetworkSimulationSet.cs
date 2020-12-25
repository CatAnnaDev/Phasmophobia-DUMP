/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class NetworkSimulationSet // TypeDefIndex: 4267
	{
		// Fields
		private bool isSimulationEnabled; // 0x10
		private int outgoingLag; // 0x14
		private int outgoingJitter; // 0x18
		private int outgoingLossPercentage; // 0x1C
		private int incomingLag; // 0x20
		private int incomingJitter; // 0x24
		private int incomingLossPercentage; // 0x28
		internal PeerBase peerBase; // 0x30
		private Thread netSimThread; // 0x38
		protected internal readonly ManualResetEvent NetSimManualResetEvent; // 0x40
	
		// Properties
		protected internal bool IsSimulationEnabled { get => default; set {} } // 0x00000001806BC970-0x00000001806BC980 0x00000001806BC9B0-0x00000001806BD0D0
		public int OutgoingLag { get => default; set {} } // 0x00000001806BC990-0x00000001806BC9A0 0x00000001802932F0-0x0000000180293300
		public int OutgoingJitter { get => default; set {} } // 0x00000001806BC980-0x00000001806BC990 0x000000018027AC40-0x000000018027AC50
		public int OutgoingLossPercentage { get => default; set {} } // 0x00000001806BC9A0-0x00000001806BC9B0 0x00000001802D6530-0x00000001802D6540
		public int IncomingLag { get => default; set {} } // 0x00000001806BC960-0x00000001806BC970 0x0000000180293310-0x0000000180293320
		public int IncomingJitter { get => default; set {} } // 0x00000001806BC950-0x00000001806BC960 0x0000000180326FA0-0x0000000180326FB0
		public int IncomingLossPercentage { get => default; set {} } // 0x00000001806ACD50-0x00000001806ACD60 0x000000018026D130-0x000000018026D140
		public int LostPackagesOut { get; internal set; } // 0x00000001802456E0-0x00000001802456F0 0x0000000180428400-0x0000000180428410
		public int LostPackagesIn { get; internal set; } // 0x000000018038D7B0-0x000000018038D7C0 0x000000018038D730-0x000000018038D740
	
		// Constructors
		public NetworkSimulationSet() {} // 0x00000001806BC8C0-0x00000001806BC950
	
		// Methods
		public override string ToString() => default; // 0x00000001806BC540-0x00000001806BC8C0
	}
}
