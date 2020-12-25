/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Voice;
using UnityEngine;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice.Unity
{
	public class UnityAudioOut : IAudioOut<float> // TypeDefIndex: 4746
	{
		// Fields
		private int frameSamples; // 0x10
		private int frameSize; // 0x14
		private int bufferSamples; // 0x18
		private int clipWriteSamplePos; // 0x1C
		private int playSamplePosPrev; // 0x20
		private int sourceTimeSamplesPrev; // 0x24
		private int playLoopCount; // 0x28
		private readonly AudioSource source; // 0x30
		private int channels; // 0x38
		private bool started; // 0x3C
		private bool flushed; // 0x3D
		private const int MAX_DELAY_MS = 3000; // Metadata: 0x0064E6EA
		private const int RESAMPLE_RAMP_END_MS = 2000; // Metadata: 0x0064E6EE
		private int targetDelaySamples; // 0x40
		private int upperTargetDelaySamples; // 0x44
		private int lowerTargetDelaySamples; // 0x48
		private int maxDelaySamples; // 0x4C
		private int resampleRampEndDelaySamples; // 0x50
		private readonly Photon.Voice.ILogger logger; // 0x58
		private readonly string logPrefix; // 0x60
		private readonly bool debugInfo; // 0x68
		private float[] zeroFrame; // 0x70
		private float[] resampledFrame; // 0x78
		private Queue<float[]> frameQueue; // 0x80
		public const int FRAME_POOL_CAPACITY = 50; // Metadata: 0x0064E6F2
		private PrimitiveArrayPool<float> framePool; // 0x88
		private bool catchingUp; // 0x90
	
		// Properties
		public int Lag { get => default; } // 0x0000000180F30DD0-0x0000000180F30E30 
		public bool IsPlaying { get => default; } // 0x0000000180F30DB0-0x0000000180F30DD0 
	
		// Constructors
		public UnityAudioOut() {} // Dummy constructor
		public UnityAudioOut(AudioSource audioSource, Photon.Voice.ILogger logger, string logPrefix, bool debugInfo) {} // 0x0000000180F30CA0-0x0000000180F30DB0
	
		// Methods
		public void Start(int frequency, int channels, int frameSamples, int playDelayMs) {} // 0x0000000180F30630-0x0000000180F30C10
		public void Service() {} // 0x0000000180F2F5D0-0x0000000180F30630
		public void Push(float[] frame) {} // 0x0000000180F2F2C0-0x0000000180F2F5D0
		public void Flush() {} // 0x0000000180F2F1D0-0x0000000180F2F2C0
		public void Stop() {} // 0x0000000180F30C10-0x0000000180F30CA0
	}
}
