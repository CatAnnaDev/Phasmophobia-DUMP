﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	public interface IPunOwnershipCallbacks // TypeDefIndex: 5305
	{
		// Methods
		void OnOwnershipRequest(PhotonView targetView, Photon.Realtime.Player requestingPlayer);
		void OnOwnershipTransfered(PhotonView targetView, Photon.Realtime.Player previousOwner);
	}
}
