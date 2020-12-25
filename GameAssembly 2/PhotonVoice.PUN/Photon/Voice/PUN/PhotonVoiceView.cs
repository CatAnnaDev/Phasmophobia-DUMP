/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using Photon.Voice.Unity;
using UnityEngine;

// Image 57: PhotonVoice.PUN.dll - Assembly: PhotonVoice.PUN, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5663-5669

namespace Photon.Voice.PUN
{
	// [AddComponentMenu] // 0x0000000180148510-0x00000001801485B0
	// [HelpURL] // 0x0000000180148510-0x00000001801485B0
	// [RequireComponent] // 0x0000000180148510-0x00000001801485B0
	public class PhotonVoiceView : VoiceComponent // TypeDefIndex: 5665
	{
		// Fields
		private PhotonView photonView; // 0x28
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Recorder recorderInUse; // 0x30
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Speaker speakerInUse; // 0x38
		private bool onEnableCalledOnce; // 0x40
		public bool AutoCreateRecorderIfNotFound; // 0x41
		public bool UsePrimaryRecorder; // 0x42
		public bool SetupDebugSpeaker; // 0x43
	
		// Properties
		public Recorder RecorderInUse { get => default; set {} } // 0x00000001802470B0-0x00000001802470C0 0x0000000182098A40-0x0000000182098B70
		public Speaker SpeakerInUse { get => default; set {} } // 0x0000000180246FD0-0x0000000180246FE0 0x0000000182098B70-0x0000000182098CB0
		public bool IsSetup { get => default; } // 0x00000001820988C0-0x0000000182098950 
		public bool IsSpeaker { get; private set; } // 0x0000000180A916A0-0x0000000180A916B0 0x0000000180A916F0-0x0000000180A91700
		public bool IsSpeaking { get => default; } // 0x0000000182098980-0x00000001820989B0 
		public bool IsRecorder { get; private set; } // 0x00000001812E8450-0x00000001812E8460 0x00000001812E8820-0x00000001812E8830
		public bool IsRecording { get => default; } // 0x0000000182098890-0x00000001820988C0 
		public bool IsSpeakerLinked { get => default; } // 0x0000000182098950-0x0000000182098980 
		public bool IsPhotonViewReady { get => default; } // 0x00000001820987D0-0x0000000182098890 
		internal bool RequiresSpeaker { get => default; } // 0x00000001820989F0-0x0000000182098A40 
		internal bool RequiresRecorder { get => default; } // 0x00000001820989B0-0x00000001820989F0 
	
		// Constructors
		public PhotonVoiceView() {} // 0x00000001820987C0-0x00000001820987D0
	
		// Methods
		protected override void Awake() {} // 0x0000000182097230-0x0000000182097290
		private void OnEnable() {} // 0x0000000182097640-0x0000000182097660
		private void Start() {} // 0x00000001820987B0-0x00000001820987C0
		private void CheckLateLinking() {} // 0x0000000182097290-0x0000000182097490
		internal void Setup() {} // 0x0000000182098690-0x00000001820987B0
		private bool SetupRecorder() => default; // 0x0000000182097BE0-0x0000000182097DF0
		private bool SetupRecorder(Recorder recorder) => default; // 0x0000000182097990-0x0000000182097BE0
		private bool SetupSpeaker() => default; // 0x0000000182097FA0-0x00000001820983D0
		private bool SetupSpeaker(Speaker speaker) => default; // 0x00000001820983D0-0x0000000182098690
		internal void SetupRecorderInUse() {} // 0x0000000182097660-0x0000000182097990
		internal void SetupSpeakerInUse() {} // 0x0000000182097DF0-0x0000000182097FA0
		public void Init() {} // 0x0000000182097490-0x0000000182097640
	}
}
