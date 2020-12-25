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
	public struct SendOptions // TypeDefIndex: 4294
	{
		// Fields
		public static readonly SendOptions SendReliable; // 0x00
		public static readonly SendOptions SendUnreliable; // 0x08
		public DeliveryMode DeliveryMode; // 0x00
		public bool Encrypt; // 0x04
		public byte Channel; // 0x05
	
		// Properties
		public bool Reliability { get => default; set {} } // 0x00000001800448D0-0x00000001800448E0 0x00000001800448E0-0x0000000180044930
	
		// Constructors
		static SendOptions() {
			SendReliable = default;
			SendUnreliable = default;
		} // 0x0000000180A0DC90-0x0000000180A0DD00
	}
}
