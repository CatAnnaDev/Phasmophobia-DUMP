/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Realtime;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class LoadBalancingTransport : LoadBalancingClient, IVoiceTransport, IDisposable // TypeDefIndex: 4727
	{
		// Fields
		internal const int VOICE_CHANNEL = 0; // Metadata: 0x0064E6BE
		protected VoiceClient voiceClient; // 0x178
		private PhotonTransportProtocol protocol; // 0x180
		private object sendLock; // 0x188
	
		// Properties
		public VoiceClient VoiceClient { get => default; } // 0x0000000180275EE0-0x0000000180275EF0 
		[Obsolete] // 0x0000000180134A10-0x0000000180134A40
		public byte GlobalAudioGroup { get => default; set {} } // 0x0000000180F1E510-0x0000000180F1E530 0x0000000180F1E910-0x0000000180F1EA40
		public byte GlobalInterestGroup { get => default; set {} } // 0x0000000180F1E510-0x0000000180F1E530 0x0000000180F1E910-0x0000000180F1EA40
	
		// Constructors
		public LoadBalancingTransport() {} // Dummy constructor
		public LoadBalancingTransport(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp /* Metadata: 0x0064E6BD */) {} // 0x0000000180F1E1F0-0x0000000180F1E510
	
		// Methods
		public void LogError(string fmt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180F1D720-0x0000000180F1D760
		public void LogWarning(string fmt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180F1D7A0-0x0000000180F1D7E0
		public void LogInfo(string fmt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180F1D760-0x0000000180F1D7A0
		public void LogDebug(string fmt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180F1D6E0-0x0000000180F1D720
		internal byte photonChannelForCodec(Codec c) => default; // 0x0000000180F1E850-0x0000000180F1E910
		public bool IsChannelJoined(int channelId) => default; // 0x0000000180F1D6D0-0x0000000180F1D6E0
		public new void Service() {} // 0x0000000180F1E1C0-0x0000000180F1E1F0
		[Obsolete] // 0x0000000180134980-0x00000001801349B0
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd) => default; // 0x0000000180F1D670-0x0000000180F1D6A0
		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId) {} // 0x0000000180F1DD80-0x0000000180F1E1C0
		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId) {} // 0x0000000180F1DAF0-0x0000000180F1DD80
		public virtual void SendFrame(ArraySegment<byte> data, FrameFlags flags, byte evNumber, byte voiceId, int channelId, int targetPlayerId, bool reliable, LocalVoice localVoice) {} // 0x0000000180F1D7E0-0x0000000180F1DAF0
		public string ChannelIdStr(int channelId) => default; // 0x0000000180246C90-0x0000000180246CA0
		public string PlayerIdStr(int playerId) => default; // 0x0000000180246C90-0x0000000180246CA0
		protected virtual void onEventActionVoiceClient(EventData ev) {} // 0x0000000180F1E530-0x0000000180F1E730
		private void onStateChangeVoiceClient(ClientState fromState, ClientState state) {} // 0x0000000180F1E730-0x0000000180F1E850
		public void Dispose() {} // 0x0000000180F1D6A0-0x0000000180F1D6D0
	}
}
