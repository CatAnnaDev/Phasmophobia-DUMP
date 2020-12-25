/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	internal class InRoomCallbacksContainer : List<Photon.Realtime.IInRoomCallbacks>, IInRoomCallbacks // TypeDefIndex: 4356
	{
		// Fields
		private readonly LoadBalancingClient client; // 0x28
	
		// Constructors
		public InRoomCallbacksContainer() {} // Dummy constructor
		public InRoomCallbacksContainer(LoadBalancingClient client) {} // 0x00000001807388C0-0x0000000180738940
	
		// Methods
		public void OnPlayerEnteredRoom(Player newPlayer) {} // 0x00000001807381B0-0x0000000180738370
		public void OnPlayerLeftRoom(Player otherPlayer) {} // 0x0000000180738370-0x0000000180738530
		public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) {} // 0x0000000180738700-0x00000001807388C0
		public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProp) {} // 0x0000000180738530-0x0000000180738700
		public void OnMasterClientSwitched(Player newMasterClient) {} // 0x0000000180737FF0-0x00000001807381B0
	}
}
