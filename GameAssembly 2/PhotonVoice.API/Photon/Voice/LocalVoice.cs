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
	public class LocalVoice : IDisposable // TypeDefIndex: 4664
	{
		// Fields
		public const int DATA_POOL_CAPACITY = 50; // Metadata: 0x0064E5AF
		private bool transmitEnabled; // 0x11
		private bool debugEchoMode; // 0x28
		protected VoiceInfo info; // 0x30
		protected IEncoder encoder; // 0x58
		internal byte id; // 0x60
		internal int channelId; // 0x64
		internal byte evNumber; // 0x68
		protected VoiceClient voiceClient; // 0x70
		protected ArraySegment<byte> configFrame; // 0x78
		protected bool disposed; // 0x88
		protected object disposeLock; // 0x90
		private int noTransmitCnt; // 0x98
		internal Dictionary<byte, int> eventTimestamps; // 0xA0
	
		// Properties
		[Obsolete] // 0x000000018012BB30-0x000000018012BB60
		public byte Group { get => default; set {} } // 0x00000001803628F0-0x0000000180362930 0x00000001802F6FA0-0x00000001802F6FB0
		public byte InterestGroup { get; set; } // 0x00000001803628F0-0x0000000180362930 0x00000001802F6FA0-0x00000001802F6FB0
		public VoiceInfo Info { get => default; } // 0x0000000180F1F5D0-0x0000000180F1F5F0 
		public bool TransmitEnabled { get => default; set {} } // 0x00000001805DB450-0x00000001805DB460 0x0000000180F202C0-0x0000000180F20360
		public bool IsCurrentlyTransmitting { get; protected set; } // 0x000000018066E5E0-0x000000018066E5F0 0x0000000180F202B0-0x0000000180F202C0
		public int FramesSent { get; private set; } // 0x00000001802932A0-0x00000001802932B0 0x00000001802932F0-0x0000000180293300
		public int FramesSentBytes { get; private set; } // 0x000000018027A800-0x000000018027A810 0x000000018027AC40-0x000000018027AC50
		public bool Reliable { get; set; } // 0x0000000180568740-0x0000000180568750 0x000000018062E0A0-0x000000018062E0B0
		public bool Encrypt { get; set; } // 0x00000001807465F0-0x0000000180746600 0x0000000180746620-0x0000000180746630
		public IServiceable LocalUserServiceable { get; set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
		public bool DebugEchoMode { get => default; set {} } // 0x0000000180297A00-0x0000000180297A10 0x0000000180F20180-0x0000000180F202B0
		internal ILogger Logger { get => default; } // 0x0000000180F1F640-0x0000000180F1F660 
		internal string Name { get => default; } // 0x0000000180F1F660-0x0000000180F1F950 
		internal string LogPrefix { get => default; } // 0x0000000180F1F5F0-0x0000000180F1F640 
	
		// Constructors
		internal LocalVoice() {} // 0x0000000180F1F290-0x0000000180F1F330
		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId) {} // 0x0000000180F1F330-0x0000000180F1F5D0
	
		// Methods
		public virtual IEncoder CreateDefaultEncoder(VoiceInfo info) => default; // 0x0000000180F1F010-0x0000000180F1F0A0
		protected void resetNoTransmitCnt() {} // 0x0000000180F1F950-0x0000000180F1F960
		internal virtual void service() {} // 0x0000000180F1FFA0-0x0000000180F20180
		internal void sendConfigFrame(int targetPlayerId) {} // 0x0000000180F1F960-0x0000000180F1FA90
		internal void sendFrame(ArraySegment<byte> compressed, FrameFlags flags) {} // 0x0000000180F1FC50-0x0000000180F1FFA0
		internal void sendFrame0(ArraySegment<byte> compressed, FrameFlags flags, int targetPlayerId, bool reliable) {} // 0x0000000180F1FA90-0x0000000180F1FC50
		public void RemoveSelf() {} // 0x0000000180F1F110-0x0000000180F1F290
		public virtual void Dispose() {} // 0x0000000180F1F0A0-0x0000000180F1F110
	}
}
