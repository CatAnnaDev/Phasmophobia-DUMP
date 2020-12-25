/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	public class ConnectAndJoinRandom : MonoBehaviourPunCallbacks // TypeDefIndex: 5628
	{
		// Fields
		public bool AutoConnect; // 0x20
		public byte Version; // 0x21
		// [Tooltip] // 0x0000000180145500-0x0000000180145530
		public byte MaxPlayers; // 0x22
		public int playerTTL; // 0x24
	
		// Constructors
		public ConnectAndJoinRandom() {} // 0x00000001812760D0-0x00000001812760F0
	
		// Methods
		public void Start() {} // 0x0000000181275FF0-0x00000001812760D0
		public void ConnectNow() {} // 0x0000000181275BA0-0x0000000181275C80
		public override void OnConnectedToMaster() {} // 0x0000000181275C80-0x0000000181275D20
		public override void OnJoinedLobby() {} // 0x0000000181275EC0-0x0000000181275F60
		public override void OnJoinRandomFailed(short returnCode, string message) {} // 0x0000000181275DB0-0x0000000181275EC0
		public override void OnDisconnected(DisconnectCause cause) {} // 0x0000000181275D20-0x0000000181275DB0
		public override void OnJoinedRoom() {} // 0x0000000181275F60-0x0000000181275FF0
	}
}
