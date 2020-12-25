/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class AudioSyncBuffer<T> : IAudioOut<T> // TypeDefIndex: 4638
	{
		// Fields
		private int curPlayingFrameSamplePos;
		private int sampleRate;
		private int channels;
		private int frameSamples;
		private int frameSize;
		private bool started;
		private int maxDevPlayDelaySamples;
		private int targetPlayDelaySamples;
		private readonly ILogger logger;
		private readonly string logPrefix;
		private readonly bool debugInfo;
		private readonly int elementSize;
		private T[] emptyFrame;
		private Queue<T[]> frameQueue;
		public const int FRAME_POOL_CAPACITY = 50; // Metadata: 0x0064E593
		private PrimitiveArrayPool<T> framePool;
	
		// Properties
		public int Lag { get => default; }
		public bool IsPlaying { get => default; }
	
		// Constructors
		public AudioSyncBuffer() {} // Dummy constructor
		public AudioSyncBuffer(ILogger logger, string logPrefix, bool debugInfo) {}
	
		// Methods
		public void Start(int sampleRate, int channels, int frameSamples, int playDelayMs) {}
		public void Service() {}
		public void Read(T[] outBuf, int outChannels, int outSampleRate) {}
		public void Push(T[] frame) {}
		public void Flush() {}
		public void Stop() {}
		private void dequeueFrameQueue() {}
		private void syncFrameQueue() {}
	}
}
