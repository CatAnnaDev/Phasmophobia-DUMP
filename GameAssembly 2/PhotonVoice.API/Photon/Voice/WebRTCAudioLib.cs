/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class WebRTCAudioLib // TypeDefIndex: 4723
	{
		// Fields
		private const string lib_name = "webrtc-audio"; // Metadata: 0x0064E637
	
		// Nested types
		public enum Error // TypeDefIndex: 4724
		{
			kBadStreamParameterWarning = -13,
			kNotEnabledError = -12,
			kStreamParameterNotSetError = -11,
			kFileError = -10,
			kBadNumberChannelsError = -9,
			kBadDataLengthError = -8,
			kBadSampleRateError = -7,
			kBadParameterError = -6,
			kNullPointerError = -5,
			kUnsupportedFunctionError = -4,
			kUnsupportedComponentError = -3,
			kCreationFailedError = -2,
			kUnspecifiedError = -1,
			kNoError = 0
		}
	
		public enum Param // TypeDefIndex: 4725
		{
			REVERSE_STREAM_DELAY_MS = 1,
			AEC = 10,
			AEC_HIGH_PASS_FILTER = 11,
			AECM = 20,
			HIGH_PASS_FILTER = 31,
			NS = 41,
			NS_LEVEL = 42,
			AGC = 51,
			AGC_TARGET_LEVEL_DBFS = 55,
			AGC_COMPRESSION_GAIN = 56,
			AGC_LIMITER = 57,
			VAD = 61,
			VAD_FRAME_SIZE_MS = 62,
			VAD_LIKELIHOOD = 63,
			AGC2 = 71
		}
	
		// Constructors
		public WebRTCAudioLib() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		public static extern IntPtr webrtc_audio_processor_create(int samplingRate, int channels, int frameSize, int revSamplingRate, int revChannels); // 0x0000000180F36F10-0x0000000180F36FC0
		public static extern int webrtc_audio_processor_init(IntPtr proc); // 0x0000000180F37040-0x0000000180F370C0
		public static extern int webrtc_audio_processor_set_param(IntPtr proc, int param, int v); // 0x0000000180F37220-0x0000000180F372B0
		public static extern int webrtc_audio_processor_process(IntPtr proc, short[] buffer, int offset, out bool voiceDetected); // 0x0000000180F370C0-0x0000000180F37180
		public static extern int webrtc_audio_processor_process_reverse(IntPtr proc, short[] buffer, int bufferSize); // 0x0000000180F37180-0x0000000180F37220
		public static extern void webrtc_audio_processor_destroy(IntPtr proc); // 0x0000000180F36FC0-0x0000000180F37040
	}
}
