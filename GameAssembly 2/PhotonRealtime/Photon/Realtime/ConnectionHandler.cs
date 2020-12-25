/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public class ConnectionHandler : MonoBehaviour // TypeDefIndex: 4336
	{
		// Fields
		private byte fallbackThreadId; // 0x20
		private bool didSendAcks; // 0x21
		private int startedAckingTimestamp; // 0x24
		private int deltaSinceStartedToAck; // 0x28
		public int KeepAliveInBackground; // 0x2C
		public bool ApplyDontDestroyOnLoad; // 0x34
		[NonSerialized]
		public static bool AppQuits; // 0x00
	
		// Properties
		public LoadBalancingClient Client { get; set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
		public int CountSendAcksOnly { get; private set; } // 0x0000000180250A60-0x0000000180250A70 0x000000018041F060-0x000000018041F070
		public bool FallbackThreadRunning { get => default; } // 0x0000000180736E90-0x0000000180736EA0 
	
		// Constructors
		public ConnectionHandler() {} // 0x0000000180736E70-0x0000000180736E90
	
		// Methods
		[RuntimeInitializeOnLoadMethod] // 0x00000001800F9050-0x00000001800F9070
		private static void StaticReset() {} // 0x0000000180736DC0-0x0000000180736E00
		protected void OnApplicationQuit() {} // 0x0000000180736B00-0x0000000180736B40
		protected virtual void Awake() {} // 0x0000000180736A90-0x0000000180736B00
		protected virtual void OnDisable() {} // 0x0000000180736B40-0x0000000180736C50
		public void StartFallbackSendAckThread() {} // 0x0000000180736D20-0x0000000180736DC0
		public void StopFallbackSendAckThread() {} // 0x0000000180736E00-0x0000000180736E70
		public bool RealtimeFallbackThread() => default; // 0x0000000180736C50-0x0000000180736D20
	}
}
