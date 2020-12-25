/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio // TypeDefIndex: 4675
	{
		// Fields
		protected AudioUtil.VoiceDetector<T> voiceDetector;
		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;
		protected AudioUtil.LevelMeter<T> levelMeter;
		protected int channels;
		protected bool resampleSource;
	
		// Properties
		public virtual AudioUtil.IVoiceDetector VoiceDetector { get; }
		public virtual AudioUtil.ILevelMeter LevelMeter { get; }
		public bool VoiceDetectorCalibrating { get; }
	
		// Constructors
		protected LocalVoiceAudio() {} // Dummy constructor
		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId) {}
	
		// Methods
		public static LocalVoiceAudio<T> Create(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId) => default;
		public override IEncoder CreateDefaultEncoder(VoiceInfo info) => default;
		public void VoiceDetectorCalibrate(int durationMs, Action<float> onCalibrated = null) {}
		protected void initBuiltinProcessors() {}
	}
}
