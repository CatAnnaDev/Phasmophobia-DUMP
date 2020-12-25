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
	internal interface IVoiceTransport : ILogger // TypeDefIndex: 4680
	{
		// Methods
		bool IsChannelJoined(int channelId);
		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);
		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);
		void SendFrame(ArraySegment<byte> data, FrameFlags flags, byte evNumber, byte voiceId, int channelId, int targetPlayerId, bool reliable, LocalVoice localVoice);
		string ChannelIdStr(int channelId);
		string PlayerIdStr(int playerId);
	}
}
