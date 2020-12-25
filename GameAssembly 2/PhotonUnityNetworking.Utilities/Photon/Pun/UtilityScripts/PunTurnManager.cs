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
	public class PunTurnManager : MonoBehaviourPunCallbacks, IOnEventCallback // TypeDefIndex: 5642
	{
		// Fields
		private Photon.Realtime.Player sender; // 0x20
		public float TurnDuration; // 0x28
		public IPunTurnManagerCallbacks TurnManagerListener; // 0x30
		private readonly HashSet<Photon.Realtime.Player> finishedPlayers; // 0x38
		public const byte TurnManagerEventOffset = 0; // Metadata: 0x0065013E
		public const byte EvMove = 1; // Metadata: 0x0065013F
		public const byte EvFinalMove = 2; // Metadata: 0x00650140
		private bool _isOverCallProcessed; // 0x40
	
		// Properties
		public int Turn { get => default; private set {} } // 0x00000001812808C0-0x0000000181280A50 0x0000000181280A50-0x0000000181280C30
		public float ElapsedTimeInTurn { get => default; } // 0x00000001812804D0-0x0000000181280680 
		public float RemainingSecondsInTurn { get => default; } // 0x0000000181280840-0x00000001812808C0 
		public bool IsCompletedByAll { get => default; } // 0x0000000181280680-0x0000000181280740 
		public bool IsFinishedByMe { get => default; } // 0x0000000181280740-0x00000001812807B0 
		public bool IsOver { get => default; } // 0x00000001812807B0-0x0000000181280840 
	
		// Constructors
		public PunTurnManager() {} // 0x0000000181280460-0x00000001812804D0
	
		// Methods
		private void Start() {} // 0x0000000180246DB0-0x0000000180246DC0
		private void Update() {} // 0x0000000181280360-0x0000000181280460
		public void BeginTurn() {} // 0x000000018127FA90-0x000000018127FAC0
		public void SendMove(object move, bool finished) {} // 0x000000018127FF80-0x0000000181280360
		public bool GetPlayerFinishedTurn(Photon.Realtime.Player player) => default; // 0x000000018127FAC0-0x000000018127FB30
		private void ProcessOnEvent(byte eventCode, object content, int senderId) {} // 0x000000018127FC40-0x000000018127FF80
		public void OnEvent(EventData photonEvent) {} // 0x000000018127FB30-0x000000018127FBA0
		public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged) {} // 0x000000018127FBA0-0x000000018127FC40
	}
}
