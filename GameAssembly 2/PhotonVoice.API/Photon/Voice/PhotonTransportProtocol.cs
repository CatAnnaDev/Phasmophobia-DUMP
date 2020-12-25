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
	internal class PhotonTransportProtocol // TypeDefIndex: 4730
	{
		// Fields
		private VoiceClient voiceClient; // 0x10
		private ILogger logger; // 0x18
	
		// Nested types
		private enum EventSubcode : byte // TypeDefIndex: 4731
		{
			VoiceInfo = 1,
			VoiceRemove = 2,
			Frame = 3
		}
	
		private enum EventParam : byte // TypeDefIndex: 4732
		{
			VoiceId = 1,
			SamplingRate = 2,
			Channels = 3,
			FrameDurationUs = 4,
			Bitrate = 5,
			Width = 6,
			Height = 7,
			UserData = 10,
			EventNumber = 11,
			Codec = 12
		}
	
		// Constructors
		public PhotonTransportProtocol() {} // Dummy constructor
		public PhotonTransportProtocol(VoiceClient voiceClient, ILogger logger) {} // 0x0000000180294750-0x00000001802947A0
	
		// Methods
		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo) => default; // 0x0000000180F245A0-0x0000000180F24DD0
		internal object[] buildVoiceRemoveMessage(LocalVoice v) => default; // 0x0000000180F24340-0x0000000180F245A0
		internal object[] buildFrameMessage(byte voiceId, byte evNumber, ArraySegment<byte> data, FrameFlags flags) => default; // 0x0000000180F24100-0x0000000180F24340
		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId) {} // 0x0000000180F250A0-0x0000000180F254C0
		private void onVoiceInfo(int channelId, int playerId, object payload) {} // 0x0000000180F254C0-0x0000000180F25700
		private void onVoiceRemove(int channelId, int playerId, object payload) {} // 0x0000000180F25700-0x0000000180F257B0
		private VoiceInfo createVoiceInfoFromEventPayload(Dictionary<byte, object> h) => default; // 0x0000000180F24DD0-0x0000000180F250A0
	}
}
