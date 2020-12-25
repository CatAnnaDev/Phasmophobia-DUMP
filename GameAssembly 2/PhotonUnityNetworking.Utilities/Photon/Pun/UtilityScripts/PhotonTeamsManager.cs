/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;
using UnityEngine;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	[DisallowMultipleComponent] // 0x00000001800D4E50-0x00000001800D4E60
	public class PhotonTeamsManager : MonoBehaviour, IMatchmakingCallbacks, IInRoomCallbacks // TypeDefIndex: 5616
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private List<PhotonTeam> teamsList; // 0x18
		private Dictionary<byte, PhotonTeam> teamsByCode; // 0x20
		private Dictionary<string, PhotonTeam> teamsByName; // 0x28
		private Dictionary<byte, HashSet<Photon.Realtime.Player>> playersPerTeam; // 0x30
		public const string TeamPlayerProp = "_pt"; // Metadata: 0x006500FB
		private static PhotonTeamsManager instance; // 0x10
	
		// Properties
		public static PhotonTeamsManager Instance { get => default; } // 0x000000018127D9B0-0x000000018127DB20 
	
		// Events
		public static event Action<Photon.Realtime.Player, PhotonTeam> PlayerJoinedTeam;
		public static event Action<Photon.Realtime.Player, PhotonTeam> PlayerLeftTeam;
	
		// Constructors
		public PhotonTeamsManager() {} // 0x000000018127D730-0x000000018127D850
	
		// Methods
		private void Awake() {} // 0x000000018127BA40-0x000000018127BB20
		private void OnEnable() {} // 0x000000018127C1A0-0x000000018127C200
		private void OnDisable() {} // 0x000000018127C140-0x000000018127C1A0
		private void Init() {} // 0x000000018127BE80-0x000000018127C140
		void IMatchmakingCallbacks.OnJoinedRoom() {} // 0x000000018127CEB0-0x000000018127CEC0
		void IMatchmakingCallbacks.OnLeftRoom() {} // 0x000000018127CEC0-0x000000018127CED0
		void IInRoomCallbacks.OnPlayerPropertiesUpdate(Photon.Realtime.Player targetPlayer, Hashtable changedProps) {} // 0x000000018127C700-0x000000018127CEB0
		void IInRoomCallbacks.OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer) {} // 0x000000018127C540-0x000000018127C700
		void IInRoomCallbacks.OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer) {} // 0x000000018127C200-0x000000018127C540
		private void UpdateTeams() {} // 0x000000018127D610-0x000000018127D730
		private void ClearTeams() {} // 0x000000018127BB20-0x000000018127BC80
		public bool TryGetTeamByCode(byte code, out PhotonTeam team) {
			team = default;
			return default;
		} // 0x000000018127CED0-0x000000018127CF40
		public bool TryGetTeamByName(string teamName, out PhotonTeam team) {
			team = default;
			return default;
		} // 0x000000018127CF40-0x000000018127CFB0
		public PhotonTeam[] GetAvailableTeams() => default; // 0x000000018127BC80-0x000000018127BCD0
		public bool TryGetTeamMembers(byte code, out Photon.Realtime.Player[] members) {
			members = default;
			return default;
		} // 0x000000018127D3F0-0x000000018127D610
		public bool TryGetTeamMembers(string teamName, out Photon.Realtime.Player[] members) {
			members = default;
			return default;
		} // 0x000000018127D340-0x000000018127D3F0
		public bool TryGetTeamMembers(PhotonTeam team, out Photon.Realtime.Player[] members) {
			members = default;
			return default;
		} // 0x000000018127D2D0-0x000000018127D340
		public bool TryGetTeamMatesOfPlayer(Photon.Realtime.Player player, out Photon.Realtime.Player[] teamMates) {
			teamMates = default;
			return default;
		} // 0x000000018127CFB0-0x000000018127D2D0
		public int GetTeamMembersCount(byte code) => default; // 0x000000018127BD60-0x000000018127BDF0
		public int GetTeamMembersCount(string name) => default; // 0x000000018127BDF0-0x000000018127BE80
		public int GetTeamMembersCount(PhotonTeam team) => default; // 0x000000018127BCD0-0x000000018127BD60
		void IMatchmakingCallbacks.OnFriendListUpdate(List<FriendInfo> friendList) {} // 0x0000000180246DB0-0x0000000180246DC0
		void IMatchmakingCallbacks.OnCreatedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
		void IMatchmakingCallbacks.OnCreateRoomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		void IMatchmakingCallbacks.OnJoinRoomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		void IMatchmakingCallbacks.OnJoinRandomFailed(short returnCode, string message) {} // 0x0000000180246DB0-0x0000000180246DC0
		void IInRoomCallbacks.OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) {} // 0x0000000180246DB0-0x0000000180246DC0
		void IInRoomCallbacks.OnMasterClientSwitched(Photon.Realtime.Player newMasterClient) {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
