/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio // TypeDefIndex: 4676
	{
		// Fields
		private AudioUtil.VoiceDetectorDummy voiceDetector; // 0xA8
		private AudioUtil.LevelMeterDummy levelMeter; // 0xB0
		public static LocalVoiceAudioDummy Dummy; // 0x00
	
		// Properties
		public AudioUtil.IVoiceDetector VoiceDetector { get => default; } // 0x00000001802749A0-0x00000001802749B0 
		public AudioUtil.ILevelMeter LevelMeter { get => default; } // 0x0000000180464EB0-0x0000000180464EC0 
		public bool VoiceDetectorCalibrating { get => default; } // 0x0000000180250A70-0x0000000180250A80 
	
		// Constructors
		public LocalVoiceAudioDummy() {} // 0x0000000180F1EB90-0x0000000180F1ECA0
		static LocalVoiceAudioDummy() {} // 0x0000000180F1EA40-0x0000000180F1EB90
	
		// Methods
		public void VoiceDetectorCalibrate(int durationMs, Action<float> onCalibrated = null) {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
