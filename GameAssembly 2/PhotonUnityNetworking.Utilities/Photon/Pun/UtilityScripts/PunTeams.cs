/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	[Obsolete] // 0x000000018013FF00-0x000000018013FF30
	public class PunTeams : MonoBehaviourPunCallbacks // TypeDefIndex: 5624
	{
		// Fields
		[Obsolete] // 0x00000001801400A0-0x00000001801400D0
		public static Dictionary<Team, List<Photon.Realtime.Player>> PlayersPerTeam; // 0x00
		[Obsolete] // 0x0000000180140230-0x0000000180140260
		public const string TeamPlayerProp = "team"; // Metadata: 0x00650112
	
		// Nested types
		[Obsolete] // 0x0000000180143870-0x00000001801438A0
		public enum Team : byte // TypeDefIndex: 5625
		{
			none = 0,
			red = 1,
			blue = 2
		}
	
		// Constructors
		public PunTeams() {} // 0x000000018026EAB0-0x000000018026EAC0
	
		// Methods
		public void Start() {} // 0x000000018127F460-0x000000018127F720
		public override void OnDisable() {} // 0x000000018127F420-0x000000018127F440
		public override void OnJoinedRoom() {} // 0x000000018127F440-0x000000018127F450
		public override void OnLeftRoom() {} // 0x000000018127F450-0x000000018127F460
		public override void OnPlayerPropertiesUpdate(Photon.Realtime.Player targetPlayer, Hashtable changedProps) {} // 0x000000018127F440-0x000000018127F450
		public override void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer) {} // 0x000000018127F440-0x000000018127F450
		public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer) {} // 0x000000018127F440-0x000000018127F450
		[Obsolete] // 0x00000001801403B0-0x00000001801403E0
		public void UpdateTeams() {} // 0x000000018127F720-0x000000018127FA90
	}
}
