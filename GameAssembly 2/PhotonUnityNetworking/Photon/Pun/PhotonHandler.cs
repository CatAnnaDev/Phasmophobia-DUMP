/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	public class PhotonHandler : ConnectionHandler, IInRoomCallbacks, IMatchmakingCallbacks // TypeDefIndex: 5308
	{
		// Fields
		private static PhotonHandler instance; // 0x00
		public static int MaxDatagrams; // 0x08
		public static bool SendAsap; // 0x0C
		private const int SerializeRateFrameCorrection = 8; // Metadata: 0x0064F6BC
		protected internal int UpdateInterval; // 0x38
		protected internal int UpdateIntervalOnSerialize; // 0x3C
		private int nextSendTickCount; // 0x40
		private int nextSendTickCountOnSerialize; // 0x44
		private SupportLogger supportLoggerComponent; // 0x48
		protected List<int> reusableIntList; // 0x50
	
		// Properties
		internal static PhotonHandler Instance { get => default; } // 0x00000001805A0050-0x00000001805A0240 
	
		// Constructors
		public PhotonHandler() {} // 0x000000018059FFE0-0x00000001805A0050
		static PhotonHandler() {} // 0x000000018059FFA0-0x000000018059FFE0
	
		// Methods
		protected override void Awake() {} // 0x000000018059E9B0-0x000000018059EAE0
		protected virtual void OnEnable() {} // 0x000000018059F010-0x000000018059F440
		protected void Start() {} // 0x000000018059FEC0-0x000000018059FFA0
		protected override void OnDisable() {} // 0x000000018059EFB0-0x000000018059F010
		protected void FixedUpdate() {} // 0x000000018059EC50-0x000000018059EC60
		protected void LateUpdate() {} // 0x000000018059EC60-0x000000018059EF50
		protected void Dispatch() {} // 0x000000018059EAE0-0x000000018059EC50
		public void OnCreatedRoom() {} // 0x000000018059EF50-0x000000018059EFB0
		public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) {} // 0x000000018059FE70-0x000000018059FEC0
		public void OnPlayerPropertiesUpdate(Photon.Realtime.Player targetPlayer, Hashtable changedProps) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnMasterClientSwitched(Photon.Realtime.Player newMasterClient) {} // 0x000000018059F7F0-0x000000018059F940
		public void OnFriendListUpdate(List<FriendInfo> friendList) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnCreateRoomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnJoinRoomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnJoinRandomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnJoinedRoom() {} // 0x000000018059F440-0x000000018059F7A0
		public void OnLeftRoom() {} // 0x000000018059F7A0-0x000000018059F7F0
		public void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer) {} // 0x000000018059F940-0x000000018059FBF0
		public void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer) {} // 0x000000018059FBF0-0x000000018059FE70
	}
}
