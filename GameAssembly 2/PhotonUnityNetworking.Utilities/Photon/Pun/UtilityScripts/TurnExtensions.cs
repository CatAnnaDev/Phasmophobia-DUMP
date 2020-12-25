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
	public static class TurnExtensions // TypeDefIndex: 5644
	{
		// Fields
		public static readonly string TurnPropKey; // 0x00
		public static readonly string TurnStartPropKey; // 0x08
		public static readonly string FinishedTurnPropKey; // 0x10
	
		// Constructors
		static TurnExtensions() {} // 0x0000000181284060-0x00000001812840F0
	
		// Extension methods
		public static void SetTurn(this Room room, int turn, bool setStartTime = false /* Metadata: 0x00650141 */) {} // 0x0000000181283ED0-0x0000000181284060
		public static int GetTurn(this RoomInfo room) => default; // 0x0000000181283C50-0x0000000181283D70
		public static int GetTurnStart(this RoomInfo room) => default; // 0x0000000181283B30-0x0000000181283C50
		public static int GetFinishedTurn(this Photon.Realtime.Player player) => default; // 0x00000001812839A0-0x0000000181283B30
		public static void SetFinishedTurn(this Photon.Realtime.Player player, int turn) {} // 0x0000000181283D70-0x0000000181283ED0
	}
}
