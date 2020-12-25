/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public class Region // TypeDefIndex: 4389
	{
		// Properties
		public string Code { get; private set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
		public string Cluster { get; private set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
		public string HostAndPort { get; protected internal set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
		public int Ping { get; set; } // 0x000000018026C7E0-0x000000018026C7F0 0x000000018026D130-0x000000018026D140
		public bool WasPinged { get => default; } // 0x0000000180748A20-0x0000000180748A30 
	
		// Constructors
		public Region() {} // Dummy constructor
		public Region(string code, string address) {} // 0x0000000180748980-0x00000001807489E0
		public Region(string code, int ping) {} // 0x00000001807489E0-0x0000000180748A20
	
		// Methods
		private void SetCodeAndCluster(string codeAsString) {} // 0x0000000180748700-0x0000000180748810
		public override string ToString() => default; // 0x00000001807488E0-0x0000000180748980
		public string ToString(bool compact = false /* Metadata: 0x0064E03C */) => default; // 0x0000000180748810-0x00000001807488E0
	}
}
