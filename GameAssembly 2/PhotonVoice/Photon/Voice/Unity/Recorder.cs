/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Voice;
using UnityEngine;
using UnityEngine.Serialization;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity
{
	// [AddComponentMenu] // 0x000000018010E350-0x000000018010E3B0
	// [HelpURL] // 0x000000018010E350-0x000000018010E3B0
	public class Recorder : VoiceComponent // TypeDefIndex: 5377
	{
		// Fields
		public const int MIN_OPUS_BITRATE = 6000; // Metadata: 0x0064FA17
		public const int MAX_OPUS_BITRATE = 510000; // Metadata: 0x0064FA1B
		private static readonly Array samplingRateValues; // 0x00
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool voiceDetection; // 0x28
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float voiceDetectionThreshold; // 0x2C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int voiceDetectionDelayMs; // 0x30
		private object userData; // 0x38
		private LocalVoice voice; // 0x40
		private string unityMicrophoneDevice; // 0x48
		private int photonMicrophoneDeviceId; // 0x50
		private IAudioDesc inputSource; // 0x58
		private VoiceClient client; // 0x60
		// [FormerlySerializedAs] // 0x000000018010E570-0x000000018010E5C0
		[SerializeField] // 0x000000018010E570-0x000000018010E5C0
		private byte interestGroup; // 0x68
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool debugEchoMode; // 0x69
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool reliableMode; // 0x6A
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool encrypt; // 0x6B
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool transmitEnabled; // 0x6C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 samplingRate; // 0x70
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private OpusCodec.FrameDuration frameDuration; // 0x74
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int bitrate; // 0x78
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private InputSourceType sourceType; // 0x7C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private MicType microphoneType; // 0x80
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private AudioClip audioClip; // 0x88
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool loopAudioClip; // 0x90
		private bool isRecording; // 0x91
		private Func<IAudioDesc> inputFactory; // 0x98
		private static AudioInEnumerator photonMicrophoneEnumerator; // 0x08
		private AudioInChangeNotifier photonMicChangeNotifier; // 0xA0
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool reactOnSystemChanges; // 0xA8
		private bool subscribedToSystemChangesPhoton; // 0xA9
		private bool subscribedToSystemChangesUnity; // 0xAA
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool autoStart; // 0xAB
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool recordOnlyWhenEnabled; // 0xAC
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool skipDeviceChangeChecks; // 0xAD
		private bool wasRecordingBeforePause; // 0xAE
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool stopRecordingWhenPaused; // 0xAF
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool useOnAudioFilterRead; // 0xB0
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool trySamplingRateMatch; // 0xB1
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool useMicrophoneTypeFallback; // 0xB2
	
		// Properties
		private bool subscribedToSystemChanges { get => default; } // 0x0000000180F42570-0x0000000180F42590 
		public static AudioInEnumerator PhotonMicrophoneEnumerator { get => default; } // 0x0000000180F41F40-0x0000000180F42150 
		public bool IsInitialized { get => default; } // 0x000000018071EAF0-0x000000018071EB00 
		[Obsolete] // 0x000000018010F5D0-0x000000018010F600
		public bool RequiresInit { get => default; } // 0x0000000180F42170-0x0000000180F42180 
		public bool RequiresRestart { get; protected set; } // 0x0000000180F42170-0x0000000180F42180 0x0000000180F434E0-0x0000000180F434F0
		public bool TransmitEnabled { get => default; set {} } // 0x0000000180F421A0-0x0000000180F421B0 0x0000000180F43650-0x0000000180F436F0
		public bool Encrypt { get => default; set {} } // 0x0000000180F41CF0-0x0000000180F41D00 0x0000000180F42CE0-0x0000000180F42D10
		public bool DebugEchoMode { get => default; set {} } // 0x0000000180F41C70-0x0000000180F41CF0 0x0000000180F42B50-0x0000000180F42CE0
		public bool ReliableMode { get => default; set {} } // 0x0000000180F42160-0x0000000180F42170 0x0000000180F43450-0x0000000180F434E0
		public bool VoiceDetection { get => default; set {} } // 0x0000000180F423E0-0x0000000180F42400 0x0000000180F43F60-0x0000000180F43FE0
		public float VoiceDetectionThreshold { get => default; set {} } // 0x0000000180F423C0-0x0000000180F423E0 0x0000000180F43DC0-0x0000000180F43F60
		public int VoiceDetectionDelayMs { get => default; set {} } // 0x0000000180F423A0-0x0000000180F423C0 0x0000000180F43D40-0x0000000180F43DC0
		public object UserData { get => default; set {} } // 0x0000000180246FD0-0x0000000180246FE0 0x0000000180F43C20-0x0000000180F43D40
		public Func<IAudioDesc> InputFactory { get => default; set {} } // 0x0000000180274970-0x0000000180274980 0x0000000180F42E20-0x0000000180F42F50
		public AudioUtil.IVoiceDetector VoiceDetector { get => default; } // 0x0000000180F424C0-0x0000000180F42570 
		public string UnityMicrophoneDevice { get => default; set {} } // 0x0000000180F421C0-0x0000000180F42390 0x0000000180F43710-0x0000000180F43B00
		public int PhotonMicrophoneDeviceId { get => default; set {} } // 0x0000000180F41DD0-0x0000000180F41F40 0x0000000180F43160-0x0000000180F433A0
		[Obsolete] // 0x000000018010F720-0x000000018010F750
		public byte AudioGroup { get => default; set {} } // 0x0000000180F41C10-0x0000000180F41C60 0x0000000180F42730-0x0000000180F42860
		public byte InterestGroup { get => default; set {} } // 0x0000000180F41C10-0x0000000180F41C60 0x0000000180F42730-0x0000000180F42860
		public bool IsCurrentlyTransmitting { get => default; } // 0x0000000180F41D00-0x0000000180F41D20 
		public AudioUtil.ILevelMeter LevelMeter { get => default; } // 0x0000000180F41D20-0x0000000180F41DD0 
		public bool VoiceDetectorCalibrating { get => default; } // 0x0000000180F42400-0x0000000180F424C0 
		protected ILocalVoiceAudio voiceAudio { get => default; } // 0x0000000180F42590-0x0000000180F425D0 
		public InputSourceType SourceType { get => default; set {} } // 0x0000000180422DD0-0x0000000180422DE0 0x0000000180F43510-0x0000000180F43640
		public MicType MicrophoneType { get => default; set {} } // 0x00000001804FA0E0-0x00000001804FA0F0 0x0000000180F43040-0x0000000180F43160
		[Obsolete] // 0x000000018010F840-0x000000018010F870
		public SampleTypeConv TypeConvert { get; set; } // 0x0000000180274950-0x0000000180274960 0x0000000180274E10-0x0000000180274E20
		public AudioClip AudioClip { get => default; set {} } // 0x000000018024B310-0x000000018024B320 0x0000000180F425D0-0x0000000180F42730
		public bool LoopAudioClip { get => default; set {} } // 0x000000018042DAB0-0x000000018042DAC0 0x0000000180F42F70-0x0000000180F43040
		public u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 SamplingRate { get => default; set {} } // 0x00000001805105C0-0x00000001805105D0 0x0000000180F434F0-0x0000000180F43500
		public OpusCodec.FrameDuration FrameDuration { get => default; set {} } // 0x00000001802DEA90-0x00000001802DEAA0 0x0000000180F42D10-0x0000000180F42E20
		public int Bitrate { get => default; set {} } // 0x00000001804019C0-0x00000001804019D0 0x0000000180F42870-0x0000000180F42B50
		public bool IsRecording { get => default; set {} } // 0x000000018042DAC0-0x000000018042DAD0 0x0000000180F42F50-0x0000000180F42F70
		public bool ReactOnSystemChanges { get => default; set {} } // 0x000000018047AAF0-0x000000018047AB00 0x0000000180F433A0-0x0000000180F433F0
		public bool AutoStart { get => default; set {} } // 0x0000000180F41C60-0x0000000180F41C70 0x0000000180F42860-0x0000000180F42870
		public bool RecordOnlyWhenEnabled { get => default; set {} } // 0x0000000180F42150-0x0000000180F42160 0x0000000180F433F0-0x0000000180F43450
		public bool SkipDeviceChangeChecks { get => default; set {} } // 0x0000000180F42180-0x0000000180F42190 0x0000000180F43500-0x0000000180F43510
		public bool StopRecordingWhenPaused { get => default; set {} } // 0x0000000180F42190-0x0000000180F421A0 0x0000000180F43640-0x0000000180F43650
		public bool UseOnAudioFilterRead { get => default; set {} } // 0x00000001802748F0-0x0000000180274900 0x0000000180F43B10-0x0000000180F43C20
		public bool TrySamplingRateMatch { get => default; set {} } // 0x0000000180F421B0-0x0000000180F421C0 0x0000000180F436F0-0x0000000180F43710
		public bool UseMicrophoneTypeFallback { get => default; set {} } // 0x0000000180F42390-0x0000000180F423A0 0x0000000180F43B00-0x0000000180F43B10
	
		// Nested types
		public enum InputSourceType // TypeDefIndex: 5378
		{
			Microphone = 0,
			AudioClip = 1,
			Factory = 2
		}
	
		public enum MicType // TypeDefIndex: 5379
		{
			Unity = 0,
			Photon = 1
		}
	
		[Obsolete] // 0x000000018010F8C0-0x000000018010F8F0
		public enum SampleTypeConv // TypeDefIndex: 5380
		{
			None = 0,
			Short = 1
		}
	
		[Obsolete] // 0x000000018010F9C0-0x000000018010F9F0
		public class PhotonVoiceCreatedParams : Unity.PhotonVoiceCreatedParams // TypeDefIndex: 5381
		{
			// Constructors
			public PhotonVoiceCreatedParams() {} // 0x0000000180289A80-0x0000000180289A90
		}
	
		// Constructors
		public Recorder() {} // 0x0000000180F41B50-0x0000000180F41C10
		static Recorder() {} // 0x0000000180F41AB0-0x0000000180F41B50
	
		// Methods
		[Obsolete] // 0x000000018010F360-0x000000018010F390
		public void Init(VoiceClient voiceClient, object customObj = null) {} // 0x0000000180F3FEA0-0x0000000180F3FFE0
		public void Init(VoiceConnection voiceConnection) {} // 0x0000000180F3FFE0-0x0000000180F40210
		[Obsolete] // 0x000000018010F410-0x000000018010F440
		public void ReInit() {} // 0x0000000180F40890-0x0000000180F408A0
		public void RestartRecording(bool force = false /* Metadata: 0x0064FA16 */) {} // 0x0000000180F40B90-0x0000000180F40DC0
		public void VoiceDetectorCalibrate(int durationMs, Action<float> detectionEndedCallback = null) {} // 0x0000000180F418B0-0x0000000180F41AB0
		public void StartRecording() {} // 0x0000000180F41150-0x0000000180F412A0
		public void StopRecording() {} // 0x0000000180F412A0-0x0000000180F413A0
		public bool ResetLocalAudio() => default; // 0x0000000180F40A40-0x0000000180F40B90
		private void Setup() {} // 0x0000000180F40E80-0x0000000180F41150
		private LocalVoice CreateLocalVoiceAudioAndSource() => default; // 0x0000000180F3D9F0-0x0000000180F3EC90
		protected virtual void SendPhotonVoiceCreatedMessage() {} // 0x0000000180F40DC0-0x0000000180F40E80
		private void OnDestroy() {} // 0x0000000180F407A0-0x0000000180F407B0
		private void RemoveVoice(bool sendUnityMsg) {} // 0x0000000180F408A0-0x0000000180F40A40
		private void OnAudioConfigChanged(bool deviceWasChanged) {} // 0x0000000180F40660-0x0000000180F407A0
		private void PhotonMicrophoneChangeDetected() {} // 0x0000000180F40800-0x0000000180F40890
		private void HandleDeviceChange() {} // 0x0000000180F3FCB0-0x0000000180F3FEA0
		private void SubscribeToSystemChanges() {} // 0x0000000180F413A0-0x0000000180F41690
		private void UnsubscribeFromSystemChanges() {} // 0x0000000180F41760-0x0000000180F418B0
		private void GetThresholdFromDetector() {} // 0x0000000180F3F7B0-0x0000000180F3FB10
		private void GetActivityDelayFromDetector() {} // 0x0000000180F3EC90-0x0000000180F3EE90
		private void GetStatusFromDetector() {} // 0x0000000180F3EE90-0x0000000180F3F080
		public static bool CompareUnityMicNames(string mic1, string mic2) => default; // 0x0000000180F3D8C0-0x0000000180F3D9F0
		public static bool IsDefaultUnityMic(string mic) => default; // 0x0000000180F40210-0x0000000180F40270
		private static bool IsValidUnityMic(string mic) => default; // 0x0000000180F40270-0x0000000180F402D0
		private void OnEnable() {} // 0x0000000180F407D0-0x0000000180F40800
		private void OnDisable() {} // 0x0000000180F407B0-0x0000000180F407D0
		private bool CheckIfPhotonMicrophoneIdIsValid(AudioInEnumerator audioInEnumerator, int id) => default; // 0x0000000180F3D820-0x0000000180F3D8C0
		private bool TryGetPhotonMicrophoneNameFromId(AudioInEnumerator audioInEnumerator, int id, out string photonMicName) {
			photonMicName = default;
			return default;
		} // 0x0000000180F41690-0x0000000180F41760
		private void OnApplicationPause(bool paused) {} // 0x0000000180F40520-0x0000000180F40660
		private void OnApplicationFocus(bool focused) {} // 0x0000000180F402D0-0x0000000180F40520
		private void HandleApplicationPause(bool paused) {} // 0x0000000180F3FB10-0x0000000180F3FCB0
		private u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 GetSupportedSamplingRate(int requested) => default; // 0x0000000180F3F0F0-0x0000000180F3F360
		private u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 GetSupportedSamplingRateForUnityMicrophone(u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 requested) => default; // 0x0000000180F3F080-0x0000000180F3F0F0
		private u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 GetSupportedSamplingRate(u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 requested, int minFreq, int maxFreq) => default; // 0x0000000180F3F360-0x0000000180F3F610
		private u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 GetSupportedSamplingRate(u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 sR) => default; // 0x0000000180F3F610-0x0000000180F3F7B0
		private void CheckAndSetSamplingRate(u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 sR) {} // 0x0000000180F3D470-0x0000000180F3D820
		private void CheckAndSetSamplingRate() {} // 0x0000000180F3D460-0x0000000180F3D470
	}
}
