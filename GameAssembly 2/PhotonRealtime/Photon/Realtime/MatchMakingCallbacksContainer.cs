/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public class MatchMakingCallbacksContainer : List<Photon.Realtime.IMatchmakingCallbacks>, IMatchmakingCallbacks // TypeDefIndex: 4355
	{
		// Fields
		private readonly LoadBalancingClient client; // 0x28
	
		// Constructors
		public MatchMakingCallbacksContainer() {} // Dummy constructor
		public MatchMakingCallbacksContainer(LoadBalancingClient client) {} // 0x0000000180744FA0-0x0000000180745020
	
		// Methods
		public void OnCreatedRoom() {} // 0x0000000180744560-0x0000000180744700
		public void OnJoinedRoom() {} // 0x0000000180744C60-0x0000000180744E00
		public void OnCreateRoomFailed(short returnCode, string message) {} // 0x0000000180744390-0x0000000180744560
		public void OnJoinRandomFailed(short returnCode, string message) {} // 0x00000001807448C0-0x0000000180744A90
		public void OnJoinRoomFailed(short returnCode, string message) {} // 0x0000000180744A90-0x0000000180744C60
		public void OnLeftRoom() {} // 0x0000000180744E00-0x0000000180744FA0
		public void OnFriendListUpdate(List<FriendInfo> friendList) {} // 0x0000000180744700-0x00000001807448C0
	}
}
