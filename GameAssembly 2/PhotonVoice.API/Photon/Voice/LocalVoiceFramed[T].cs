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
	public class LocalVoiceFramed<T> : LocalVoiceFramedBase // TypeDefIndex: 4713
	{
		// Fields
		private Framer<T> framer;
		private int preProcessorsCnt;
		private List<IProcessor<T>> processors;
		private bool dataEncodeThreadStarted;
		private Queue<T[]> pushDataQueue;
		private AutoResetEvent pushDataQueueReady;
		private FactoryPrimitiveArrayPool<T> bufferFactory;
		private int framesSkippedNextLog;
		private int framesSkipped;
		private bool exitThread;
		private int processNullFramesCnt;
	
		// Properties
		public FactoryPrimitiveArrayPool<T> BufferFactory { get => default; }
		public bool PushDataAsyncReady { get => default; }
	
		// Constructors
		public LocalVoiceFramed() {} // Dummy constructor
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize) {}
	
		// Methods
		protected T[] processFrame(T[] buf) => default;
		public void AddPostProcessor(params /* 0x00000001800D4E50-0x00000001800D4E60 */ IProcessor<T>[] processors) {}
		public void AddPreProcessor(params /* 0x00000001800D4E50-0x00000001800D4E60 */ IProcessor<T>[] processors) {}
		public void ClearProcessors() {}
		public void PushDataAsync(T[] buf) {}
		private void PushDataAsyncThread() {}
		public void PushData(T[] buf) {}
		public override void Dispose() {}
	}
}
