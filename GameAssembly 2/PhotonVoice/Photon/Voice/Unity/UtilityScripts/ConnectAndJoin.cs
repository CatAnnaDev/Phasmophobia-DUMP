/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using Photon.Voice.Unity;
using UnityEngine;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity.UtilityScripts
{
	// [RequireComponent] // 0x0000000180115D40-0x0000000180115D90
	public class ConnectAndJoin : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks // TypeDefIndex: 5393
	{
		// Fields
		private VoiceConnection voiceConnection; // 0x18
		public bool RandomRoom; // 0x20
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool autoConnect; // 0x21
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool autoTransmit; // 0x22
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool publishUserId; // 0x23
		public string RoomName; // 0x28
		private readonly EnterRoomParams enterRoomParams; // 0x30
	
		// Properties
		public bool IsConnected { get => default; } // 0x0000000180F3AC00-0x0000000180F3AC30 
	
		// Constructors
		public ConnectAndJoin() {} // 0x0000000180F3AB50-0x0000000180F3AC00
	
		// Methods
		private void Awake() {} // 0x0000000180F3A1F0-0x0000000180F3A240
		private void OnEnable() {} // 0x0000000180F3A630-0x0000000180F3A690
		private void OnDisable() {} // 0x0000000180F3A4F0-0x0000000180F3A530
		public void ConnectNow() {} // 0x0000000180F3A240-0x0000000180F3A270
		public void OnCreatedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnCreateRoomFailed(short returnCode, string message) {} // 0x0000000180F3A390-0x0000000180F3A4F0
		public void OnFriendListUpdate(List<FriendInfo> friendList) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnJoinedRoom() {} // 0x0000000180F3A9B0-0x0000000180F3AB50
		public void OnJoinRandomFailed(short returnCode, string message) {} // 0x0000000180F3A690-0x0000000180F3A7F0
		public void OnJoinRoomFailed(short returnCode, string message) {} // 0x0000000180F3A7F0-0x0000000180F3A9B0
		public void OnLeftRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnConnected() {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnConnectedToMaster() {} // 0x0000000180F3A270-0x0000000180F3A390
		public void OnDisconnected(DisconnectCause cause) {} // 0x0000000180F3A530-0x0000000180F3A630
		public void OnRegionListReceived(RegionHandler regionHandler) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnCustomAuthenticationFailed(string debugMessage) {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
