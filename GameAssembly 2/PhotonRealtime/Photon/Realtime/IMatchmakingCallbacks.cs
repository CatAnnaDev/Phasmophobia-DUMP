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
	public interface IMatchmakingCallbacks // TypeDefIndex: 4349
	{
		// Methods
		void OnFriendListUpdate(List<FriendInfo> friendList);
		void OnCreatedRoom();
		void OnCreateRoomFailed(short returnCode, string message);
		void OnJoinedRoom();
		void OnJoinRoomFailed(short returnCode, string message);
		void OnJoinRandomFailed(short returnCode, string message);
		void OnLeftRoom();
	}
}
