/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Voice;
using Photon.Voice.Unity;
using UnityEngine;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity.UtilityScripts
{
	[DisallowMultipleComponent] // 0x0000000180117F40-0x0000000180117FA0
	// [RequireComponent] // 0x0000000180117F40-0x0000000180117FA0
	public class SaveOutgoingStreamToFile : VoiceComponent // TypeDefIndex: 5401
	{
		// Fields
		private u091Du091Du091Cu0920u0923u0928u0924u091Au0923u0924u0924 wavWriter; // 0x28
	
		// Nested types
		private class OutgoingStreamSaverFloat : IProcessor<float> // TypeDefIndex: 5402
		{
			// Fields
			private u091Du091Du091Cu0920u0923u0928u0924u091Au0923u0924u0924 wavWriter; // 0x10
	
			// Constructors
			public OutgoingStreamSaverFloat() {} // Dummy constructor
			public OutgoingStreamSaverFloat(u091Du091Du091Cu0920u0923u0928u0924u091Au0923u0924u0924 waveWriter) {} // 0x000000018024B380-0x000000018024B3B0
	
			// Methods
			public float[] Process(float[] buf) => default; // 0x0000000180F3B440-0x0000000180F3B480
			public void Dispose() {} // 0x0000000180F3B400-0x0000000180F3B440
		}
	
		private class OutgoingStreamSaverShort : IProcessor<short> // TypeDefIndex: 5403
		{
			// Fields
			private u091Du091Du091Cu0920u0923u0928u0924u091Au0923u0924u0924 wavWriter; // 0x10
	
			// Constructors
			public OutgoingStreamSaverShort() {} // Dummy constructor
			public OutgoingStreamSaverShort(u091Du091Du091Cu0920u0923u0928u0924u091Au0923u0924u0924 waveWriter) {} // 0x000000018024B380-0x000000018024B3B0
	
			// Methods
			public short[] Process(short[] buf) => default; // 0x0000000180F3B480-0x0000000180F3B580
			public void Dispose() {} // 0x0000000180F3B400-0x0000000180F3B440
		}
	
		// Constructors
		public SaveOutgoingStreamToFile() {} // 0x0000000180F44D80-0x0000000180F44D90
	
		// Methods
		private void PhotonVoiceCreated(PhotonVoiceCreatedParams photonVoiceCreatedParams) {} // 0x0000000180F44E80-0x0000000180F45430
		private string GetFilePath() => default; // 0x0000000180F44D90-0x0000000180F44E80
		private void PhotonVoiceRemoved() {} // 0x0000000180F45430-0x0000000180F45520
	}
}
