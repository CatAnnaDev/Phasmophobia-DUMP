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
	internal class RemoteVoice : IDisposable // TypeDefIndex: 4667
	{
		// Fields
		internal RemoteVoiceOptions options; // 0x38
		internal int channelId; // 0x60
		private int playerId; // 0x64
		private byte voiceId; // 0x68
		private bool disposed; // 0x69
		private object disposeLock; // 0x70
		private SpacingProfile receiveSpacingProfile; // 0x78
		internal byte lastEvNumber; // 0x80
		private VoiceClient voiceClient; // 0x88
		private Queue<byte[]> frameQueue; // 0x90
		private Queue<FrameFlags> frameFlagsQueue; // 0x98
		private AutoResetEvent frameQueueReady; // 0xA0
	
		// Properties
		internal VoiceInfo Info { get; private set; } // 0x0000000180F25E30-0x0000000180F25E50 0x0000000180F25E50-0x0000000180F25EA0
		public string Name { get => default; } // 0x0000000180F27660-0x0000000180F27A30 
		public string LogPrefix { get => default; } // 0x0000000180F27610-0x0000000180F27660 
		public string ReceiveSpacingProfileDump { get => default; } // 0x0000000180F27A30-0x0000000180F27A50 
		public int ReceiveSpacingProfileMax { get => default; } // 0x0000000180F27A50-0x0000000180F27A70 
	
		// Constructors
		public RemoteVoice() {} // Dummy constructor
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber) {} // 0x0000000180F26060-0x0000000180F262E0
	
		// Methods
		public void ReceiveSpacingProfileStart() {} // 0x0000000180F25F90-0x0000000180F26050
		private static byte byteDiff(byte latest, byte last) => default; // 0x0000000180F262E0-0x0000000180F262F0
		internal void receiveBytes(byte[] receivedBytes, FrameFlags flags, byte evNumber) {} // 0x0000000180F27A70-0x0000000180F28440
		private void receiveFrame(byte[] frame, FrameFlags flags) {} // 0x0000000180F28440-0x0000000180F28670
		private void receiveNullFrames(int count) {} // 0x0000000180F28670-0x0000000180F288A0
		private IDecoder createDefaultDecoder() => default; // 0x0000000180F262F0-0x0000000180F26C20
		private void decodeThread() {} // 0x0000000180F26C20-0x0000000180F27610
		internal void removeAndDispose() {} // 0x0000000180F288A0-0x0000000180F288D0
		public void Dispose() {} // 0x0000000180F25EA0-0x0000000180F25F90
	}
}
