/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public struct VoiceInfo // TypeDefIndex: 4714
	{
		// Properties
		public Codec Codec { get; set; } // 0x000000018000B580-0x000000018000B590 0x00000001800163C0-0x00000001800163D0
		public int SamplingRate { get; set; } // 0x0000000180022C20-0x0000000180022C30 0x0000000180022C60-0x0000000180022C70
		public int Channels { get; set; } // 0x0000000180006CC0-0x0000000180006D60 0x0000000180008030-0x0000000180008060
		public int FrameDurationUs { get; set; } // 0x0000000180006B70-0x0000000180006C90 0x0000000180022C70-0x0000000180022C80
		public int Bitrate { get; set; } // 0x0000000180009100-0x0000000180009110 0x000000018001EA40-0x000000018001EA50
		public int Width { get; set; } // 0x0000000180020E70-0x0000000180020E80 0x0000000180020E80-0x0000000180020F80
		public int Height { get; set; } // 0x0000000180022390-0x00000001800223C0 0x0000000180022C80-0x0000000180022C90
		public object UserData { get; set; } // 0x00000001800069B0-0x00000001800069C0 0x00000001800144D0-0x00000001800144E0
		public int FrameDurationSamples { get => default; } // 0x00000001801E1800-0x00000001801E1830 
		public int FrameSize { get => default; } // 0x00000001801E1830-0x00000001801E3530 
	
		// Methods
		public static VoiceInfo CreateAudioOpus(u091Cu0925u091Au091Cu0923u0929u091Bu0922u091Eu091Fu0921 samplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, object userdata = null) => default; // 0x0000000180F365B0-0x0000000180F36630
		public static VoiceInfo CreateAudio(Codec codec, int samplingRate, int channels, int frameDurationUs, object userdata = null) => default; // 0x0000000180F36630-0x0000000180F36F10
		public override string ToString() => default; // 0x00000001801E17F0-0x00000001801E1800
	}
}
