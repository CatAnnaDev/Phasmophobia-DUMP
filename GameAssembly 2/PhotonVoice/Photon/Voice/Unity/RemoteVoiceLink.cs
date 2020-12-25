/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Voice;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity
{
	public class RemoteVoiceLink // TypeDefIndex: 5383
	{
		// Properties
		public VoiceInfo Info { get; private set; } // 0x0000000180F25E30-0x0000000180F25E50 0x0000000180F25E50-0x0000000180F25EA0
		public int PlayerId { get; private set; } // 0x00000001802932B0-0x00000001802932C0 0x00000001802D5D10-0x00000001802D5D20
		public int VoiceId { get; private set; } // 0x00000001805156B0-0x00000001805156C0 0x0000000180400EC0-0x0000000180400ED0
		public int ChannelId { get; private set; } // 0x00000001802F3F40-0x00000001802F3F50 0x0000000180469EA0-0x0000000180469EB0
	
		// Events
		public event Action<FrameOut<float>> FloatFrameDecoded;
		public event Action RemoteVoiceRemoved;
	
		// Constructors
		public RemoteVoiceLink() {} // Dummy constructor
		public RemoteVoiceLink(VoiceInfo info, int playerId, int voiceId, int channelId, ref RemoteVoiceOptions options) {} // 0x0000000180F44050-0x0000000180F44150
	
		// Methods
		private void OnRemoteVoiceRemoveAction() {} // 0x0000000180F44030-0x0000000180F44050
		private void OnDecodedFrameFloatAction(FrameOut<float> floats) {} // 0x0000000180F43FE0-0x0000000180F44030
	}
}
