/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 45: PhotonRealtime.dll - Assembly: PhotonRealtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4334-4405

namespace Photon.Realtime
{
	public interface IInRoomCallbacks // TypeDefIndex: 4350
	{
		// Methods
		void OnPlayerEnteredRoom(Player newPlayer);
		void OnPlayerLeftRoom(Player otherPlayer);
		void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged);
		void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps);
		void OnMasterClientSwitched(Player newMasterClient);
	}
}
