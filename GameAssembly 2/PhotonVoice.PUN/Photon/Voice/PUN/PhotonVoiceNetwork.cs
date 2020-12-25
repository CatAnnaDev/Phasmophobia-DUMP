/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using Photon.Voice.Unity;
using UnityEngine;

// Image 57: PhotonVoice.PUN.dll - Assembly: PhotonVoice.PUN, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5663-5669

namespace Photon.Voice.PUN
{
	// [AddComponentMenu] // 0x0000000180148110-0x0000000180148180
	[DisallowMultipleComponent] // 0x0000000180148110-0x0000000180148180
	// [HelpURL] // 0x0000000180148110-0x0000000180148180
	public class PhotonVoiceNetwork : VoiceConnection // TypeDefIndex: 5664
	{
		// Fields
		public const string VoiceRoomNameSuffix = "_voice_"; // Metadata: 0x00650239
		public bool AutoConnectAndJoin; // 0xE8
		public bool AutoLeaveAndDisconnect; // 0xE9
		public bool WorkInOfflineMode; // 0xEA
		private EnterRoomParams voiceRoomParams; // 0xF0
		private bool clientCalledConnectAndJoin; // 0xF8
		private bool clientCalledDisconnect; // 0xF9
		private bool internalDisconnect; // 0xFA
		private static object instanceLock; // 0x00
		private static PhotonVoiceNetwork instance; // 0x08
		private static bool instantiated; // 0x10
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool usePunAppSettings; // 0xFB
	
		// Properties
		public static PhotonVoiceNetwork Instance { get => default; set {} } // 0x00000001820965A0-0x0000000182096CD0 0x0000000182096CE0-0x0000000182097220
		public bool UsePunAuthValues { get => default; set {} } // 0x0000000182096CD0-0x0000000182096CE0 0x0000000182097220-0x0000000182097230
	
		// Constructors
		public PhotonVoiceNetwork() {} // 0x00000001820964D0-0x00000001820965A0
		static PhotonVoiceNetwork() {} // 0x0000000182096470-0x00000001820964D0
	
		// Methods
		public bool ConnectAndJoinRoom() => default; // 0x00000001820946F0-0x0000000182094820
		public void Disconnect() {} // 0x00000001820950E0-0x00000001820951B0
		protected override void Awake() {} // 0x0000000182093DB0-0x0000000182093F40
		private void OnEnable() {} // 0x0000000182095B10-0x0000000182095BE0
		protected override void OnDisable() {} // 0x0000000182095A50-0x0000000182095B10
		protected override void OnDestroy() {} // 0x0000000182095790-0x0000000182095A50
		private void OnPunStateChanged(ClientState fromState, ClientState toState) {} // 0x0000000182095BE0-0x0000000182095DB0
		protected override void OnVoiceStateChanged(ClientState fromState, ClientState toState) {} // 0x0000000182095DB0-0x0000000182095E40
		private void FollowPun(ClientState toState) {} // 0x00000001820955E0-0x0000000182095600
		protected override Speaker SimpleSpeakerFactory(int playerId, byte voiceId, object userData) => default; // 0x0000000182095E40-0x0000000182096470
		internal static string GetVoiceRoomName() => default; // 0x0000000182095600-0x00000001820956A0
		private void ConnectOrJoin() {} // 0x0000000182094820-0x0000000182094BD0
		private bool Connect() => default; // 0x0000000182094BD0-0x00000001820950E0
		private bool JoinRoom(string voiceRoomName) => default; // 0x00000001820956A0-0x0000000182095790
		private void FollowPun() {} // 0x00000001820951B0-0x00000001820955E0
		internal void CheckLateLinking(Speaker speaker, int viewId) {} // 0x0000000182093F40-0x00000001820946F0
	}
}
