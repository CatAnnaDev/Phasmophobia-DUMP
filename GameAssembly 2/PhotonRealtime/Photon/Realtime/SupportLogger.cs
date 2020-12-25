/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	// [AddComponentMenu] // 0x0000000180107160-0x00000001801071B0
	[DisallowMultipleComponent] // 0x0000000180107160-0x00000001801071B0
	public class SupportLogger : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, IInRoomCallbacks, ILobbyCallbacks, IErrorInfoCallback // TypeDefIndex: 4397
	{
		// Fields
		public bool LogTrafficStats; // 0x18
		private bool loggedStillOfflineMessage; // 0x19
		private LoadBalancingClient client; // 0x20
		private Stopwatch startStopwatch; // 0x28
		private int pingMax; // 0x30
		private int pingMin; // 0x34
	
		// Properties
		public LoadBalancingClient Client { get => default; set {} } // 0x0000000180246FE0-0x0000000180246FF0 0x000000018074E1B0-0x000000018074E2F0
	
		// Constructors
		public SupportLogger() {} // 0x000000018074E1A0-0x000000018074E1B0
	
		// Methods
		protected void Start() {} // 0x000000018074E060-0x000000018074E0E0
		protected void OnApplicationPause(bool pause) {} // 0x000000018074BA00-0x000000018074BCD0
		protected void OnApplicationQuit() {} // 0x000000018074BCD0-0x000000018074BCE0
		public void StartLogStats() {} // 0x000000018074DFC0-0x000000018074E010
		public void StopLogStats() {} // 0x000000018074E0E0-0x000000018074E120
		private void StartTrackValues() {} // 0x000000018074E010-0x000000018074E060
		private void StopTrackValues() {} // 0x000000018074E120-0x000000018074E160
		private string GetFormattedTimestamp() => default; // 0x000000018074ABA0-0x000000018074ACC0
		private void TrackValues() {} // 0x000000018074E160-0x000000018074E1A0
		public void LogStats() {} // 0x000000018074B650-0x000000018074BA00
		private void LogBasics() {} // 0x000000018074ACC0-0x000000018074B650
		public void OnConnected() {} // 0x000000018074BD50-0x000000018074BED0
		public void OnConnectedToMaster() {} // 0x000000018074BCE0-0x000000018074BD50
		public void OnFriendListUpdate(List<FriendInfo> friendList) {} // 0x000000018074C9F0-0x000000018074CA60
		public void OnJoinedLobby() {} // 0x000000018074D060-0x000000018074D290
		public void OnLeftLobby() {} // 0x000000018074D5F0-0x000000018074D660
		public void OnCreateRoomFailed(short returnCode, string message) {} // 0x000000018074BED0-0x000000018074C1D0
		public void OnJoinedRoom() {} // 0x000000018074D290-0x000000018074D5F0
		public void OnJoinRoomFailed(short returnCode, string message) {} // 0x000000018074CD60-0x000000018074D060
		public void OnJoinRandomFailed(short returnCode, string message) {} // 0x000000018074CA60-0x000000018074CD60
		public void OnCreatedRoom() {} // 0x000000018074C1D0-0x000000018074C530
		public void OnLeftRoom() {} // 0x000000018074D660-0x000000018074D6D0
		public void OnDisconnected(DisconnectCause cause) {} // 0x000000018074C6C0-0x000000018074C970
		public void OnRegionListReceived(RegionHandler regionHandler) {} // 0x000000018074DE10-0x000000018074DEA0
		public void OnRoomListUpdate(List<RoomInfo> roomList) {} // 0x000000018074DEA0-0x000000018074DF50
		public void OnPlayerEnteredRoom(Player newPlayer) {} // 0x000000018074D960-0x000000018074DB80
		public void OnPlayerLeftRoom(Player otherPlayer) {} // 0x000000018074DB80-0x000000018074DDA0
		public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) {} // 0x000000018074DF50-0x000000018074DFC0
		public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps) {} // 0x000000018074DDA0-0x000000018074DE10
		public void OnMasterClientSwitched(Player newMasterClient) {} // 0x000000018074D740-0x000000018074D960
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data) {} // 0x000000018074C5C0-0x000000018074C6C0
		public void OnCustomAuthenticationFailed(string debugMessage) {} // 0x000000018074C530-0x000000018074C5C0
		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) {} // 0x000000018074D6D0-0x000000018074D740
		public void OnErrorInfo(ErrorInfo errorInfo) {} // 0x000000018074C970-0x000000018074C9F0
	}
}
