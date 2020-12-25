/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public struct RemoteVoiceOptions // TypeDefIndex: 4665
	{
		// Properties
		public Action OnRemoteVoiceRemoveAction { get; set; } // 0x0000000180002410-0x0000000180002420 0x000000018000A570-0x000000018000A580
		public IDecoder Decoder { get; set; } // 0x00000001800024A0-0x0000000180002560 0x000000018000AC80-0x000000018000AEE0
		public ImageFormat OutputImageFormat { get; set; } // 0x0000000180009100-0x0000000180009110 0x000000018001EA40-0x000000018001EA50
		public Flip OutputImageFlip { get; set; } // 0x0000000180020E70-0x0000000180020E80 0x0000000180020E80-0x0000000180020F80
		internal OutputType outType { get; private set; } // 0x0000000180022390-0x00000001800223C0 0x0000000180022C80-0x0000000180022C90
		internal object output { get; private set; } // 0x00000001800069B0-0x00000001800069C0 0x00000001800144D0-0x00000001800144E0
	
		// Nested types
		internal enum OutputType // TypeDefIndex: 4666
		{
			None = 0,
			Float = 1,
			Short = 2,
			Image = 3
		}
	
		// Methods
		public void SetOutput(Action<FrameOut<float>> output) {} // 0x00000001801E1710-0x00000001801E1730
		public void SetOutput(Action<FrameOut<short>> output) {} // 0x00000001801E1750-0x00000001801E17F0
		public void SetOutput(Action<ImageOutputBuf> output) {} // 0x00000001801E1730-0x00000001801E1750
	}
}
