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
	public interface IConnectionCallbacks // TypeDefIndex: 4347
	{
		// Methods
		void OnConnected();
		void OnConnectedToMaster();
		void OnDisconnected(DisconnectCause cause);
		void OnRegionListReceived(RegionHandler regionHandler);
		void OnCustomAuthenticationResponse(Dictionary<string, object> data);
		void OnCustomAuthenticationFailed(string debugMessage);
	}
}
