/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public class RegionPinger // TypeDefIndex: 4393
	{
		// Fields
		public static int Attempts; // 0x00
		public static bool IgnoreInitialAttempt; // 0x04
		public static int MaxMilliseconsPerPing; // 0x08
		public static int PingWhenFailed; // 0x0C
		private Region region; // 0x10
		private string regionAddress; // 0x18
		public int CurrentAttempt; // 0x20
		private Action<Region> onDoneCall; // 0x28
		private PhotonPing ping; // 0x30
		private List<int> rttResults; // 0x38
	
		// Properties
		public bool Done { get; private set; } // 0x00000001802932C0-0x00000001802932D0 0x0000000180457830-0x0000000180457840
	
		// Constructors
		public RegionPinger() {} // Dummy constructor
		public RegionPinger(Region region, Action<Region> onDoneCallback) {} // 0x0000000180748640-0x0000000180748700
		static RegionPinger() {} // 0x00000001807485C0-0x0000000180748640
	
		// Methods
		private PhotonPing GetPingImplementation() => default; // 0x0000000180747B10-0x0000000180747D60
		public bool Start() => default; // 0x00000001807483A0-0x00000001807485C0
		protected internal void RegionPingPooled(object context) {} // 0x0000000180747E90-0x0000000180747EA0
		protected internal bool RegionPingThreaded() => default; // 0x0000000180747EA0-0x00000001807481B0
		// [IteratorStateMachine] // 0x00000001801067C0-0x0000000180106810
		protected internal IEnumerator RegionPingCoroutine() => default; // 0x0000000180747E20-0x0000000180747E90
		public string GetResults() => default; // 0x0000000180747D60-0x0000000180747E20
		public static string ResolveHost(string hostName) => default; // 0x00000001807481B0-0x00000001807483A0
	}
}
