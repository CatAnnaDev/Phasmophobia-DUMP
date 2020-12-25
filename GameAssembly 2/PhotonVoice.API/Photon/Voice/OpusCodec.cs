/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class OpusCodec // TypeDefIndex: 4647
	{
		// Properties
		public static string Version { get => default; } // 0x0000000180F240F0-0x0000000180F24100 
	
		// Nested types
		public enum FrameDuration // TypeDefIndex: 4648
		{
			Frame2dot5ms = 2500,
			Frame5ms = 5000,
			Frame10ms = 10000,
			Frame20ms = 20000,
			Frame40ms = 40000,
			Frame60ms = 60000
		}
	
		public static class Factory // TypeDefIndex: 4649
		{
			// Methods
			public static IEncoder CreateEncoder<B>(VoiceInfo i, ILogger logger) => default;
		}
	
		public static class DecoderFactory // TypeDefIndex: 4650
		{
			// Methods
			public static IEncoder Create<T>(VoiceInfo i, ILogger logger) => default;
		}
	
		public abstract class Encoder<T> : IEncoderDirect<T[]> // TypeDefIndex: 4651
		{
			// Fields
			protected u0921u0926u0929u0928u091Cu0929u091Bu091Fu091Cu0929u091D encoder;
			protected bool disposed;
			private static readonly ArraySegment<byte> EmptyBuffer;
	
			// Properties
			public string Error { get; private set; }
			public Action<ArraySegment<byte>, FrameFlags> Output { get; set; }
			public VoiceInfo Info { get; }
	
			// Constructors
			protected Encoder() {} // Dummy constructor
			protected Encoder(VoiceInfo i, ILogger logger) {}
			static Encoder() {}
	
			// Methods
			public void Input(T[] buf) {}
			public void EndOfStream() {}
			public ArraySegment<byte> DequeueOutput(out FrameFlags flags) {
				flags = default;
				return default;
			}
			protected abstract ArraySegment<byte> encodeTyped(T[] buf);
			public void Dispose() {}
		}
	
		public class EncoderFloat : Encoder<float> // TypeDefIndex: 4652
		{
			// Constructors
			public EncoderFloat() {} // Dummy constructor
			internal EncoderFloat(VoiceInfo i, ILogger logger) {} // 0x0000000180F1C660-0x0000000180F1C700
	
			// Methods
			protected override ArraySegment<byte> encodeTyped(float[] buf) => default; // 0x0000000180F1C700-0x0000000180F1C740
		}
	
		public class EncoderShort : Encoder<short> // TypeDefIndex: 4653
		{
			// Constructors
			public EncoderShort() {} // Dummy constructor
			internal EncoderShort(VoiceInfo i, ILogger logger) {} // 0x0000000180F1C740-0x0000000180F1C7E0
	
			// Methods
			protected override ArraySegment<byte> encodeTyped(short[] buf) => default; // 0x0000000180F1C7E0-0x0000000180F1C820
		}
	
		public class Decoder<T> : IDecoder // TypeDefIndex: 4654
		{
			// Fields
			protected u091Au091Fu0923u0920u0920u0928u091Du091Cu0925u091Bu091C<T> decoder;
			private ILogger logger;
			private Action<FrameOut<T>> output;
			private FrameOut<T> frameOut;
	
			// Properties
			public string Error { get; private set; }
			public VoiceInfo Info { get; }
	
			// Constructors
			public Decoder() {} // Dummy constructor
			public Decoder(Action<FrameOut<T>> output, ILogger logger) {}
	
			// Methods
			public void Open(VoiceInfo i) {}
			public void Dispose() {}
			public void Input(byte[] buf, FrameFlags flags) {}
		}
	
		public class Util // TypeDefIndex: 4655
		{
			// Constructors
			public Util() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			internal static int bestEncoderSampleRate(int f) => default; // 0x0000000180F31150-0x0000000180F313A0
		}
	
		// Constructors
		public OpusCodec() {} // 0x00000001802466A0-0x00000001802466B0
	}
}
