/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	public class MonoBehaviourPunCallbacks : MonoBehaviourPun, IConnectionCallbacks, IMatchmakingCallbacks, IInRoomCallbacks, ILobbyCallbacks, IWebRpcCallback, IErrorInfoCallback // TypeDefIndex: 5322
	{
		// Constructors
		public MonoBehaviourPunCallbacks() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		public virtual void OnEnable() {} // 0x000000018059C960-0x000000018059C9C0
		public virtual void OnDisable() {} // 0x000000018059C900-0x000000018059C960
		public virtual void OnConnected() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnLeftRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnMasterClientSwitched(Photon.Realtime.Player newMasterClient) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnCreateRoomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnJoinRoomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnCreatedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnJoinedLobby() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnLeftLobby() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnDisconnected(DisconnectCause cause) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnRegionListReceived(RegionHandler regionHandler) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnRoomListUpdate(List<RoomInfo> roomList) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnJoinedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnJoinRandomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnConnectedToMaster() {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnPlayerPropertiesUpdate(Photon.Realtime.Player targetPlayer, Hashtable changedProps) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnFriendListUpdate(List<FriendInfo> friendList) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnCustomAuthenticationResponse(Dictionary<string, object> data) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnCustomAuthenticationFailed(string debugMessage) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnWebRpcResponse(OperationResponse response) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) {} // 0x0000000180246DB0-0x0000000180246DC0
		public virtual void OnErrorInfo(ErrorInfo errorInfo) {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
