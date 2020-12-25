/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Voice;
using Photon.Voice.Unity;
using UnityEngine;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity.UtilityScripts
{
	[DisallowMultipleComponent] // 0x0000000180116900-0x0000000180116960
	// [RequireComponent] // 0x0000000180116900-0x0000000180116960
	public class SaveIncomingStreamToFile : VoiceComponent // TypeDefIndex: 5399
	{
		// Fields
		private VoiceConnection voiceConnection; // 0x28
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool muteLocalSpeaker; // 0x30
	
		// Constructors
		public SaveIncomingStreamToFile() {} // 0x0000000180F44D80-0x0000000180F44D90
	
		// Methods
		protected override void Awake() {} // 0x0000000180F443D0-0x0000000180F445B0
		private void OnSpeakerLinked(Speaker speaker) {} // 0x0000000180F44CF0-0x0000000180F44D80
		private void OnDestroy() {} // 0x0000000180F448E0-0x0000000180F44A90
		private void OnRemoteVoiceAdded(RemoteVoiceLink remoteVoiceLink) {} // 0x0000000180F44A90-0x0000000180F44CF0
		private string GetFilePath(RemoteVoiceLink remoteVoiceLink) => default; // 0x0000000180F445B0-0x0000000180F448E0
	}
}
