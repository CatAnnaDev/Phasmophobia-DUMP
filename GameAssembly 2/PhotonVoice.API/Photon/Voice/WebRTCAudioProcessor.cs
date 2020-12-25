/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class WebRTCAudioProcessor : WebRTCAudioLib, IProcessor<short> // TypeDefIndex: 4722
	{
		// Fields
		private const int REVERSE_BUFFER_POOL_CAPACITY = 50; // Metadata: 0x0064E62F
		private int reverseStreamDelayMs; // 0x10
		private bool aec; // 0x14
		private bool aecHighPass; // 0x15
		private bool aecm; // 0x16
		private bool highPass; // 0x17
		private bool ns; // 0x18
		private bool agc; // 0x19
		private int agcCompressionGain; // 0x1C
		private int agcTargetLevel; // 0x20
		private bool agc2; // 0x24
		private bool vad; // 0x25
		private bool reverseStreamThreadRunning; // 0x26
		private Queue<short[]> reverseStreamQueue; // 0x28
		private AutoResetEvent reverseStreamQueueReady; // 0x30
		private FactoryPrimitiveArrayPool<short> reverseBufferFactory; // 0x38
		private bool bypass; // 0x40
		private int inFrameSize; // 0x44
		private int processFrameSize; // 0x48
		private int samplingRate; // 0x4C
		private int channels; // 0x50
		private IntPtr proc; // 0x58
		private bool disposed; // 0x60
		private Framer<float> reverseFramer; // 0x68
		private int reverseSamplingRate; // 0x70
		private int reverseChannels; // 0x74
		private ILogger logger; // 0x78
		private const int supportedFrameLenMs = 10; // Metadata: 0x0064E633
		public static readonly int[] SupportedSamplingRates; // 0x00
		private bool aecInited; // 0x80
		private int lastProcessErr; // 0x84
		private int lastProcessReverseErr; // 0x88
	
		// Properties
		public int AECStreamDelayMs { set {} } // 0x0000000180F39030-0x0000000180F390A0
		public bool AEC { set {} } // 0x0000000180F390A0-0x0000000180F39130
		public bool AECHighPass { set {} } // 0x0000000180F38F30-0x0000000180F38FA0
		public bool AECMobile { set {} } // 0x0000000180F38FA0-0x0000000180F39030
		public bool HighPass { set {} } // 0x0000000180F39520-0x0000000180F39590
		public bool NoiseSuppression { set {} } // 0x0000000180F39590-0x0000000180F39600
		public bool AGC { set {} } // 0x0000000180F39400-0x0000000180F39470
		public int AGCCompressionGain { set {} } // 0x0000000180F391A0-0x0000000180F392D0
		public int AGCTargetLevel { set {} } // 0x0000000180F392D0-0x0000000180F39400
		public bool AGC2 { set {} } // 0x0000000180F39130-0x0000000180F391A0
		public bool VAD { set {} } // 0x0000000180F39600-0x0000000180F39670
		public bool Bypass { private get => default; set {} } // 0x0000000180247090-0x00000001802470A0 0x0000000180F39470-0x0000000180F39520
	
		// Constructors
		public WebRTCAudioProcessor() {} // Dummy constructor
		public WebRTCAudioProcessor(ILogger logger, int frameSize, int samplingRate, int channels, int reverseSamplingRate, int reverseChannels) {} // 0x0000000180F38500-0x0000000180F38C50
		static WebRTCAudioProcessor() {} // 0x0000000180F38490-0x0000000180F38500
	
		// Methods
		private void InitReverseStream() {} // 0x0000000180F374C0-0x0000000180F379A0
		public short[] Process(short[] buf) => default; // 0x0000000180F37D60-0x0000000180F38080
		public void OnAudioOutFrameFloat(float[] data) {} // 0x0000000180F379A0-0x0000000180F37D60
		private void ReverseStreamThread() {} // 0x0000000180F38080-0x0000000180F38490
		private int setParam(Param param, int v) => default; // 0x0000000180F38C50-0x0000000180F38F30
		public void Dispose() {} // 0x0000000180F372B0-0x0000000180F374C0
	}
}
