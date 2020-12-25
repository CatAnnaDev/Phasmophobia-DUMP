/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public interface ILocalVoiceAudio // TypeDefIndex: 4673
	{
		// Properties
		AudioUtil.IVoiceDetector VoiceDetector { get; }
		AudioUtil.ILevelMeter LevelMeter { get; }
		bool VoiceDetectorCalibrating { get; }
	
		// Methods
		void VoiceDetectorCalibrate(int durationMs, Action<float> onCalibrated = null);
	}
}
