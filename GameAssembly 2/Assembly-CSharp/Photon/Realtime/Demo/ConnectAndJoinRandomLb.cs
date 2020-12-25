/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Photon.Realtime.Demo
{
	public class ConnectAndJoinRandomLb : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, ILobbyCallbacks // TypeDefIndex: 8444
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private AppSettings appSettings; // 0x18
		private LoadBalancingClient lbc; // 0x20
		private ConnectionHandler ch; // 0x28
		public UnityEngine.UI.Text StateUiText; // 0x30
	
		// Constructors
		public ConnectAndJoinRandomLb() {} // 0x000000018125B180-0x000000018125B1F0
	
		// Methods
		public void Start() {} // 0x000000018125AEC0-0x000000018125B040
		public void Update() {} // 0x000000018125B040-0x000000018125B180
		public void OnConnected() {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnConnectedToMaster() {} // 0x000000018125AB30-0x000000018125ABA0
		public void OnDisconnected(DisconnectCause cause) {} // 0x000000018125ABA0-0x000000018125AC30
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnCustomAuthenticationFailed(string debugMessage) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnRegionListReceived(RegionHandler regionHandler) {} // 0x000000018125AD20-0x000000018125ADD0
		public void OnRoomListUpdate(List<RoomInfo> roomList) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnJoinedLobby() {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnLeftLobby() {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnFriendListUpdate(List<FriendInfo> friendList) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnCreatedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnCreateRoomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnJoinedRoom() {} // 0x000000018125ACD0-0x000000018125AD20
		public void OnJoinRoomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnJoinRandomFailed(short returnCode, string message) {} // 0x000000018125AC30-0x000000018125ACD0
		public void OnLeftRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
		private void OnRegionPingCompleted(RegionHandler regionHandler) {} // 0x000000018125ADD0-0x000000018125AEC0
	}
}
