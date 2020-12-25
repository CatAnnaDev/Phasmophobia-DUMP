/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	public class PlayerNumbering : MonoBehaviourPunCallbacks // TypeDefIndex: 5618
	{
		// Fields
		public static PlayerNumbering instance; // 0x00
		public static Photon.Realtime.Player[] SortedPlayers; // 0x08
		public const string RoomPlayerIndexedProp = "pNr"; // Metadata: 0x00650102
		public bool dontDestroyOnLoad; // 0x20
	
		// Events
		public static event PlayerNumberingChanged OnPlayerNumberingChanged;
	
		// Nested types
		public delegate void PlayerNumberingChanged(); // TypeDefIndex: 5619; 0x00000001802D1BD0-0x00000001802D1D60
	
		// Constructors
		public PlayerNumbering() {} // 0x000000018026EAB0-0x000000018026EAC0
	
		// Methods
		public void Awake() {} // 0x000000018127E210-0x000000018127E3D0
		public override void OnJoinedRoom() {} // 0x000000018127E3D0-0x000000018127E3E0
		public override void OnLeftRoom() {} // 0x000000018127E3E0-0x000000018127E450
		public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer) {} // 0x000000018127E3D0-0x000000018127E3E0
		public override void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer) {} // 0x000000018127E3D0-0x000000018127E3E0
		public override void OnPlayerPropertiesUpdate(Photon.Realtime.Player targetPlayer, Hashtable changedProps) {} // 0x000000018127E450-0x000000018127E4B0
		public void RefreshData() {} // 0x000000018127E4B0-0x000000018127ECA0
	}
}
