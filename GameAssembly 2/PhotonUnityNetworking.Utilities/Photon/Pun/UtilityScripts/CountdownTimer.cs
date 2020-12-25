/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	public class CountdownTimer : MonoBehaviourPunCallbacks // TypeDefIndex: 5640
	{
		// Fields
		public const string CountdownStartTime = "StartTime"; // Metadata: 0x00650131
		// [Header] // 0x0000000180146B40-0x0000000180146B70
		public float Countdown; // 0x20
		private bool isTimerRunning; // 0x24
		private int startTime; // 0x28
		// [Header] // 0x0000000180146C30-0x0000000180146C60
		public UnityEngine.UI.Text Text; // 0x30
	
		// Events
		public static event CountdownTimerHasExpired OnCountdownTimerHasExpired;
	
		// Nested types
		public delegate void CountdownTimerHasExpired(); // TypeDefIndex: 5641; 0x00000001802D1BD0-0x00000001802D1D60
	
		// Constructors
		public CountdownTimer() {} // 0x0000000181276C90-0x0000000181276CA0
	
		// Methods
		public void Start() {} // 0x00000001812769F0-0x0000000181276A90
		public override void OnEnable() {} // 0x0000000181276500-0x0000000181276570
		public override void OnDisable() {} // 0x00000001812764A0-0x0000000181276500
		public void Update() {} // 0x0000000181276BD0-0x0000000181276C90
		private void OnTimerRuns() {} // 0x0000000181276870-0x0000000181276880
		private void OnTimerEnds() {} // 0x0000000181276620-0x0000000181276870
		public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) {} // 0x0000000181276570-0x0000000181276620
		private void Initialize() {} // 0x00000001812760F0-0x00000001812764A0
		private float TimeRemaining() => default; // 0x0000000181276A90-0x0000000181276B00
		public static bool TryGetStartTime(out int startTimestamp) {
			startTimestamp = default;
			return default;
		} // 0x0000000181276B00-0x0000000181276BD0
		public static void SetStartTime() {} // 0x0000000181276880-0x00000001812769F0
	}
}
