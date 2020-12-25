/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Voice;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity.UtilityScripts
{
	internal class ToneAudioReader : IAudioReader<float> // TypeDefIndex: 5406
	{
		// Fields
		private double k; // 0x10
		private long timeSamples; // 0x18
	
		// Properties
		public int Channels { get => default; } // 0x00000001803EB7E0-0x00000001803EB7F0 
		public int SamplingRate { get => default; } // 0x0000000180F47610-0x0000000180F47620 
		public string Error { get => default; } // 0x0000000180246C90-0x0000000180246CA0 
	
		// Constructors
		public ToneAudioReader() {} // 0x0000000180F475E0-0x0000000180F47610
	
		// Methods
		public void Dispose() {} // 0x0000000180246DB0-0x0000000180246DC0
		public bool Read(float[] buf) => default; // 0x0000000180F47310-0x0000000180F475E0
	}
}
