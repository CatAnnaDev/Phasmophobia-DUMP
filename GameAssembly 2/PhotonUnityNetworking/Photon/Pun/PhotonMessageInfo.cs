/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;

// Image 51: PhotonUnityNetworking.dll - Assembly: PhotonUnityNetworking, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5293-5359

namespace Photon.Pun
{
	public struct PhotonMessageInfo // TypeDefIndex: 5323
	{
		// Fields
		private readonly int timeInt; // 0x00
		public readonly Photon.Realtime.Player Sender; // 0x08
		public readonly PhotonView photonView; // 0x10
	
		// Properties
		[Obsolete] // 0x0000000180109040-0x0000000180109070
		public double timestamp { get => default; } // 0x000000018001E550-0x000000018001E590 
		public double SentServerTime { get => default; } // 0x000000018001E550-0x000000018001E590 
		public int SentServerTimestamp { get => default; } // 0x000000018000B580-0x000000018000B590 
	
		// Constructors
		public PhotonMessageInfo(Photon.Realtime.Player player, int timestamp, PhotonView view) : this() {
			timeInt = default;
			Sender = default;
			photonView = default;
		} // 0x000000018001E500-0x000000018001E550
	
		// Methods
		public override string ToString() => default; // 0x000000018001E490-0x000000018001E500
	}
}
