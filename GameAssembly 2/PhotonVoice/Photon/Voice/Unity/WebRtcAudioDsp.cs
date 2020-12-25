/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Voice;
using UnityEngine;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity
{
	// [RequireComponent] // 0x00000001801145B0-0x0000000180114600
	public class WebRtcAudioDsp : VoiceComponent // TypeDefIndex: 5392
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool aec; // 0x28
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool aecHighPass; // 0x29
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool agc; // 0x2A
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int agcCompressionGain; // 0x2C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool vad; // 0x30
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool highPass; // 0x31
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool bypass; // 0x32
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool noiseSuppression; // 0x33
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int reverseStreamDelayMs; // 0x34
		private int reverseChannels; // 0x38
		private WebRTCAudioProcessor proc; // 0x40
		private AudioOutCapture ac; // 0x48
		private bool started; // 0x50
		private static readonly Dictionary<AudioSpeakerMode, int> channelsMap; // 0x00
		private LocalVoice localVoice; // 0x58
		private int outputSampleRate; // 0x60
		private Recorder recorder; // 0x68
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool forceNormalAecInMobile; // 0x70
		[Obsolete] // 0x0000000180115BF0-0x0000000180115C20
		public bool AECMobileComfortNoise; // 0x71
	
		// Properties
		public bool AEC { get => default; set {} } // 0x0000000180297A00-0x0000000180297A10 0x0000000180F58930-0x0000000180F58970
		[Obsolete] // 0x0000000180115CC0-0x0000000180115CF0
		public bool AECMobile { get => default; set {} } // 0x0000000180297A00-0x0000000180297A10 0x0000000180F58930-0x0000000180F58970
		public bool AecHighPass { get => default; set {} } // 0x00000001804918D0-0x00000001804918E0 0x0000000180F58990-0x0000000180F589B0
		public int ReverseStreamDelayMs { get => default; set {} } // 0x0000000180293280-0x0000000180293290 0x0000000180F58B50-0x0000000180F58B70
		public bool NoiseSuppression { get => default; set {} } // 0x00000001806FF6C0-0x00000001806FF6D0 0x0000000180F58B30-0x0000000180F58B50
		public bool HighPass { get => default; set {} } // 0x00000001802FB170-0x00000001802FB180 0x0000000180F58B10-0x0000000180F58B30
		public bool Bypass { get => default; set {} } // 0x0000000180510610-0x0000000180510620 0x0000000180F58AF0-0x0000000180F58B10
		public bool AGC { get => default; set {} } // 0x00000001804918E0-0x00000001804918F0 0x0000000180F58970-0x0000000180F58990
		public int AgcCompressionGain { get => default; set {} } // 0x000000018026C890-0x000000018026C8A0 0x0000000180F589B0-0x0000000180F58AF0
		public bool VAD { get => default; set {} } // 0x00000001802FB160-0x00000001802FB170 0x0000000180F58B70-0x0000000180F58B90
		public bool ForceNormalAecInMobile { get => default; set {} } // 0x00000001803CA870-0x00000001803CA880 0x00000001803CA880-0x00000001803CA890
	
		// Constructors
		public WebRtcAudioDsp() {} // 0x0000000180F58900-0x0000000180F58930
		static WebRtcAudioDsp() {} // 0x0000000180F587E0-0x0000000180F58900
	
		// Methods
		protected override void Awake() {} // 0x0000000180F573E0-0x0000000180F576A0
		private void OnEnable() {} // 0x0000000180F57BA0-0x0000000180F57C60
		private void OnDisable() {} // 0x0000000180F57B90-0x0000000180F57BA0
		private void SetOutputListener() {} // 0x0000000180F587D0-0x0000000180F587E0
		private void SetOutputListener(bool on) {} // 0x0000000180F586B0-0x0000000180F587D0
		private void OnAudioOutFrameFloat(float[] data, int outChannels) {} // 0x0000000180F57930-0x0000000180F57B40
		private void PhotonVoiceCreated(PhotonVoiceCreatedParams p) {} // 0x0000000180F57C60-0x0000000180F58000
		private void PhotonVoiceRemoved() {} // 0x0000000180F57B40-0x0000000180F57B90
		private void OnDestroy() {} // 0x0000000180F57B40-0x0000000180F57B90
		private void Reset() {} // 0x0000000180F57B40-0x0000000180F57B90
		private void Restart() {} // 0x0000000180F58000-0x0000000180F58060
		private void Init() {} // 0x0000000180F576A0-0x0000000180F57930
		private bool SetOrSwitchAudioListener(AudioListener audioListener, bool extraChecks) => default; // 0x0000000180F58070-0x0000000180F582A0
		private bool SetOrSwitchAudioOutCapture(AudioOutCapture audioOutCapture, bool extraChecks) => default; // 0x0000000180F582A0-0x0000000180F586A0
		public bool SetOrSwitchAudioListener(AudioListener audioListener) => default; // 0x0000000180F58060-0x0000000180F58070
		public bool SetOrSwitchAudioOutCapture(AudioOutCapture audioOutCapture) => default; // 0x0000000180F586A0-0x0000000180F586B0
	}
}
