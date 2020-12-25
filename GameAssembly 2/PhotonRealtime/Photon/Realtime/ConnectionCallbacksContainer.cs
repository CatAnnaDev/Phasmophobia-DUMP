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
	public class ConnectionCallbacksContainer : List<Photon.Realtime.IConnectionCallbacks>, IConnectionCallbacks // TypeDefIndex: 4354
	{
		// Fields
		private readonly LoadBalancingClient client; // 0x28
	
		// Constructors
		public ConnectionCallbacksContainer() {} // Dummy constructor
		public ConnectionCallbacksContainer(LoadBalancingClient client) {} // 0x0000000180736A10-0x0000000180736A90
	
		// Methods
		public void OnConnected() {} // 0x0000000180736170-0x0000000180736310
		public void OnConnectedToMaster() {} // 0x0000000180735FD0-0x0000000180736170
		public void OnRegionListReceived(RegionHandler regionHandler) {} // 0x0000000180736850-0x0000000180736A10
		public void OnDisconnected(DisconnectCause cause) {} // 0x0000000180736690-0x0000000180736850
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data) {} // 0x00000001807364D0-0x0000000180736690
		public void OnCustomAuthenticationFailed(string debugMessage) {} // 0x0000000180736310-0x00000001807364D0
	}
}
