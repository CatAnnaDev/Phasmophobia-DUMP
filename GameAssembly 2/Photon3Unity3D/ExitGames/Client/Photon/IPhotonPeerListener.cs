/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public interface IPhotonPeerListener // TypeDefIndex: 4254
	{
		// Methods
		void DebugReturn(DebugLevel level, string message);
		void OnOperationResponse(OperationResponse operationResponse);
		void OnStatusChanged(StatusCode statusCode);
		void OnEvent(EventData eventData);
	}
}
