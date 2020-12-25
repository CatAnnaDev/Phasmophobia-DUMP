/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public class RegionHandler // TypeDefIndex: 4390
	{
		// Fields
		public static Type PingImplementation; // 0x00
		private string availableRegionCodes; // 0x18
		private Region bestRegionCache; // 0x20
		private List<RegionPinger> pingerList; // 0x28
		private Action<RegionHandler> onCompleteCall; // 0x30
		private int previousPing; // 0x38
		private string previousSummaryProvided; // 0x40
	
		// Properties
		public List<Region> EnabledRegions { get; protected internal set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
		public Region BestRegion { get => default; } // 0x0000000180747700-0x0000000180747870 
		public string SummaryToCache { get => default; } // 0x0000000180747870-0x0000000180747B10 
		public bool IsPinging { get; private set; } // 0x0000000180293290-0x00000001802932A0 0x0000000180474BD0-0x0000000180474BE0
	
		// Constructors
		public RegionHandler() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		public string GetResults() => default; // 0x00000001807467F0-0x0000000180746BA0
		public void SetRegions(OperationResponse opGetRegions) {} // 0x00000001807474E0-0x0000000180747700
		public bool PingMinimumOfRegions(Action<RegionHandler> onCompleteCallback, string previousSummary) => default; // 0x00000001807471C0-0x00000001807474E0
		private void OnPreferredRegionPinged(Region preferredRegion) {} // 0x0000000180746BA0-0x0000000180746C30
		private bool PingEnabledRegions() => default; // 0x0000000180746E70-0x00000001807471C0
		private void OnRegionDone(Region region) {} // 0x0000000180746C30-0x0000000180746E70
	}
}
