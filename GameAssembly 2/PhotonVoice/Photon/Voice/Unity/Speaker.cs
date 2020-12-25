/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using Photon.Voice;
using UnityEngine;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity
{
	// [AddComponentMenu] // 0x0000000180110510-0x0000000180110590
	// [RequireComponent] // 0x0000000180110510-0x0000000180110590
	public class Speaker : VoiceComponent // TypeDefIndex: 5384
	{
		// Fields
		private IAudioOut<float> audioOutput; // 0x28
		private RemoteVoiceLink remoteVoiceLink; // 0x30
		private bool initialized; // 0x38
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool playbackOnlyWhenEnabled; // 0x39
		private bool useSeparateCoroutine; // 0x3A
		private Coroutine playbackCoroutine; // 0x40
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int playDelayMs; // 0x48
	
		// Properties
		public int PlayDelayMs { get => default; set {} } // 0x00000001802456E0-0x00000001802456F0 0x0000000180F46E00-0x0000000180F46F90
		public bool IsPlaying { get => default; } // 0x0000000180F46D60-0x0000000180F46DB0 
		public int Lag { get => default; } // 0x0000000180F46DB0-0x0000000180F46E00 
		public Action<Speaker> OnRemoteVoiceRemoveAction { get; set; } // 0x00000001802505D0-0x00000001802505E0 0x000000018027AC50-0x000000018027AC60
		public Photon.Realtime.Player Actor { get; protected internal set; } // 0x0000000180246F30-0x0000000180246F40 0x00000001802470C0-0x00000001802470D0
		public bool IsLinked { get => default; } // 0x0000000180448BE0-0x0000000180448BF0 
		public bool PlaybackOnlyWhenEnabled { get => default; set {} } // 0x00000001803CD720-0x00000001803CD730 0x0000000180F46F90-0x0000000180F46FF0
		public bool PlaybackStarted { get; private set; } // 0x00000001804033C0-0x00000001804033D0 0x00000001806C5150-0x00000001806C5160
	
		// Constructors
		public Speaker() {} // 0x0000000180F46D40-0x0000000180F46D60
	
		// Methods
		private void OnEnable() {} // 0x0000000180F45A10-0x0000000180F45A30
		private void OnDisable() {} // 0x0000000180F459F0-0x0000000180F45A10
		private void Initialize() {} // 0x0000000180F456B0-0x0000000180F45840
		internal bool OnRemoteVoiceInfo(RemoteVoiceLink stream) => default; // 0x0000000180F45A30-0x0000000180F46090
		internal void OnRemoteVoiceRemove() {} // 0x0000000180F46090-0x0000000180F46280
		internal void OnAudioFrame(FrameOut<float> frame) {} // 0x0000000180F45840-0x0000000180F45940
		private bool StartPlaying() => default; // 0x0000000180F46330-0x0000000180F46930
		private void OnDestroy() {} // 0x0000000180F45940-0x0000000180F459F0
		private bool StopPlaying() => default; // 0x0000000180F469B0-0x0000000180F46C60
		private void CleanUp() {} // 0x0000000180F45520-0x0000000180F456B0
		// [IteratorStateMachine] // 0x0000000180110DE0-0x0000000180110E30
		private IEnumerator PlaybackCoroutine() => default; // 0x0000000180F46280-0x0000000180F462F0
		// [IteratorStateMachine] // 0x0000000180110F50-0x0000000180110FA0
		private IEnumerator Start() => default; // 0x0000000180F46930-0x0000000180F469A0
		public bool StartPlayback() => default; // 0x0000000180F46320-0x0000000180F46330
		public bool StopPlayback() => default; // 0x0000000180F469A0-0x0000000180F469B0
		public bool RestartPlayback() => default; // 0x0000000180F462F0-0x0000000180F46320
	}
}
