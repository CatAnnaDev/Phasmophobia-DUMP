/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class RawCodec // TypeDefIndex: 4656
	{
		// Nested types
		public class Encoder<T> : IEncoderDirect<T[]> // TypeDefIndex: 4657
		{
			// Fields
			private static readonly ArraySegment<byte> EmptyBuffer;
	
			// Properties
			public string Error { get; private set; }
			public Action<ArraySegment<byte>, FrameFlags> Output { get; set; }
			public VoiceInfo Info { get; }
	
			// Constructors
			public Encoder() {}
			static Encoder() {}
	
			// Methods
			public ArraySegment<byte> DequeueOutput(out FrameFlags flags) {
				flags = default;
				return default;
			}
			public void EndOfStream() {}
			public void Dispose() {}
			public void Input(T[] buf) {}
		}
	
		public class Decoder<T> : IDecoder // TypeDefIndex: 4658
		{
			// Fields
			private Type outType;
			private Action<FrameOut<T>> output;
	
			// Properties
			public string Error { get; private set; }
	
			// Constructors
			public Decoder() {} // Dummy constructor
			public Decoder(Action<FrameOut<T>> output) {}
	
			// Methods
			public void Open(VoiceInfo info) {}
			public void Input(byte[] buf, FrameFlags flags) {}
			public void Dispose() {}
		}
	
		// Constructors
		public RawCodec() {} // 0x00000001802466A0-0x00000001802466B0
	}
}
