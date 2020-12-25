/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	public interface IPunTurnManagerCallbacks // TypeDefIndex: 5643
	{
		// Methods
		void OnTurnBegins(int turn);
		void OnTurnCompleted(int turn);
		void OnPlayerMove(Photon.Realtime.Player player, int turn, object move);
		void OnPlayerFinished(Photon.Realtime.Player player, int turn, object move);
		void OnTurnTimeEnds(int turn);
	}
}
