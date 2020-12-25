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
	internal class LobbyCallbacksContainer : List<Photon.Realtime.ILobbyCallbacks>, ILobbyCallbacks // TypeDefIndex: 4357
	{
		// Fields
		private readonly LoadBalancingClient client; // 0x28
	
		// Constructors
		public LobbyCallbacksContainer() {} // Dummy constructor
		public LobbyCallbacksContainer(LoadBalancingClient client) {} // 0x0000000180744310-0x0000000180744390
	
		// Methods
		public void OnJoinedLobby() {} // 0x0000000180743C50-0x0000000180743DF0
		public void OnLeftLobby() {} // 0x0000000180743DF0-0x0000000180743F90
		public void OnRoomListUpdate(List<RoomInfo> roomList) {} // 0x0000000180744150-0x0000000180744310
		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) {} // 0x0000000180743F90-0x0000000180744150
	}
}
