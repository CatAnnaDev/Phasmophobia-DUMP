/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class LoadBalancingTransport2 : LoadBalancingTransport // TypeDefIndex: 4729
	{
		// Fields
		private const int DATA_OFFSET = 4; // Metadata: 0x0064E6C3
	
		// Constructors
		public LoadBalancingTransport2() {} // Dummy constructor
		public LoadBalancingTransport2(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp /* Metadata: 0x0064E6C2 */) {} // 0x0000000180F1D2C0-0x0000000180F1D310
	
		// Methods
		public override void SendFrame(ArraySegment<byte> data, FrameFlags flags, byte evNumber, byte voiceId, int channelId, int targetPlayerId, bool reliable, LocalVoice localVoice) {} // 0x0000000180F1CFB0-0x0000000180F1D2C0
		protected override void onEventActionVoiceClient(EventData ev) {} // 0x0000000180F1D310-0x0000000180F1D400
		internal void onVoiceFrameEvent(object content0, int channelId, int playerId, int localPlayerId) {} // 0x0000000180F1D400-0x0000000180F1D670
	}
}
