/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class VoiceClient : IDisposable // TypeDefIndex: 4681
	{
		// Fields
		internal IVoiceTransport transport; // 0x10
		private int prevRtt; // 0x3C
		private byte globalInterestGroup; // 0x40
		private byte voiceIdCnt; // 0x41
		private Dictionary<byte, LocalVoice> localVoices; // 0x48
		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel; // 0x50
		private Dictionary<int, Dictionary<byte, RemoteVoice>> remoteVoices; // 0x58
		private Random rnd; // 0x60
	
		// Properties
		public int FramesLost { get; internal set; } // 0x000000018027A800-0x000000018027A810 0x000000018027AC40-0x000000018027AC50
		public int FramesReceived { get; private set; } // 0x000000018027A6E0-0x000000018027A6F0 0x00000001802D6530-0x00000001802D6540
		public int FramesSent { get => default; } // 0x0000000180F33E40-0x0000000180F33F90 
		public int FramesSentBytes { get => default; } // 0x0000000180F33CF0-0x0000000180F33E40 
		public int RoundTripTime { get; private set; } // 0x00000001802800D0-0x00000001802800E0 0x0000000180293310-0x0000000180293320
		public int RoundTripTimeVariance { get; private set; } // 0x000000018027A6B0-0x000000018027A6C0 0x0000000180326FA0-0x0000000180326FB0
		public bool SuppressInfoDuplicateWarning { get; set; } // 0x0000000180297A00-0x0000000180297A10 0x00000001804554D0-0x00000001804554E0
		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction { get; set; } // 0x00000001802470B0-0x00000001802470C0 0x0000000180249070-0x0000000180249080
		public int DebugLostPercent { get; set; } // 0x00000001802932B0-0x00000001802932C0 0x00000001802D5D10-0x00000001802D5D20
		public IEnumerable<LocalVoice> LocalVoices { get => default; } // 0x0000000180F33F90-0x0000000180F34030 
		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos { /* [IteratorStateMachine] */ /* 0x000000018012EBF0-0x000000018012EC40 */ get => default; } // 0x0000000180F34030-0x0000000180F340A0 
		internal byte GlobalInterestGroup { get => default; set {} } // 0x0000000180247090-0x00000001802470A0 0x0000000180F361E0-0x0000000180F36320
	
		// Nested types
		public delegate void RemoteVoiceInfoDelegate(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options); // TypeDefIndex: 4682; 0x0000000180F258A0-0x0000000180F25DC0
	
		// Constructors
		public VoiceClient() {} // Dummy constructor
		internal VoiceClient(IVoiceTransport transport) {} // 0x0000000180F32970-0x0000000180F32A80
	
		// Methods
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId) => default; // 0x0000000180F32310-0x0000000180F323D0
		public void LogRemoteVoiceStates() {} // 0x0000000180F323D0-0x0000000180F326A0
		public void Service() {} // 0x0000000180F32820-0x0000000180F32970
		private LocalVoice createLocalVoice(int channelId, Func<byte, int, LocalVoice> voiceFactory) => default; // 0x0000000180F33860-0x0000000180F33AF0
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = 0 /* Metadata: 0x0064E5CF */, IEncoder encoder = null) => default; // 0x0000000180F31EC0-0x0000000180F31FC0
		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = 0 /* Metadata: 0x0064E5D3 */, IEncoder encoder = null) => default;
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, IAudioDesc audioSourceDesc, int channelId = 0 /* Metadata: 0x0064E5D7 */, IEncoder encoder = null) => default;
		public LocalVoice CreateLocalVoiceAudioFromSource(VoiceInfo voiceInfo, IAudioDesc source, AudioSampleType sampleType, int channelId = 0 /* Metadata: 0x0064E5DB */, IEncoder encoder = null) => default; // 0x0000000180F313A0-0x0000000180F31EC0
		private byte getNewVoiceId() => default; // 0x0000000180F33AF0-0x0000000180F33CF0
		private void addVoice(byte newId, int channelId, LocalVoice v) {} // 0x0000000180F32A80-0x0000000180F32C00
		public void RemoveLocalVoice(LocalVoice voice) {} // 0x0000000180F326A0-0x0000000180F32820
		private void sendChannelVoicesInfo(int channelId, int targetPlayerId) {} // 0x0000000180F35CF0-0x0000000180F35DA0
		internal void sendVoicesInfoAndConfigFrame(IEnumerable<LocalVoice> voiceList, int channelId, int targetPlayerId) {} // 0x0000000180F35DA0-0x0000000180F361E0
		private void clearRemoteVoices() {} // 0x0000000180F335A0-0x0000000180F33860
		private void clearRemoteVoicesInChannel(int channelId) {} // 0x0000000180F33140-0x0000000180F335A0
		private void clearRemoteVoicesInChannelForPlayer(int channelId, int playerId) {} // 0x0000000180F32E50-0x0000000180F33140
		internal void onJoinChannel(int channel) {} // 0x0000000180F34850-0x0000000180F34860
		internal void onLeaveChannel(int channel) {} // 0x0000000180F34870-0x0000000180F34880
		internal void onLeaveAllChannels() {} // 0x0000000180F34860-0x0000000180F34870
		internal void onPlayerJoin(int channelId, int playerId) {} // 0x0000000180F34880-0x0000000180F34890
		internal void onPlayerLeave(int channelId, int playerId) {} // 0x0000000180F34890-0x0000000180F348A0
		internal void onVoiceInfo(int channelId, int playerId, byte voiceId, byte eventNumber, VoiceInfo info) {} // 0x0000000180F348A0-0x0000000180F35280
		internal void onVoiceRemove(int channelId, int playerId, byte[] voiceIds) {} // 0x0000000180F35280-0x0000000180F35AA0
		internal void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes, FrameFlags flags, bool isLocalPlayer) {} // 0x0000000180F340A0-0x0000000180F34850
		internal string channelStr(int channelId) => default; // 0x0000000180F32C00-0x0000000180F32E50
		internal string playerStr(int playerId) => default; // 0x0000000180F35AA0-0x0000000180F35CF0
		public void Dispose() {} // 0x0000000180F31FC0-0x0000000180F32310
	}
}
