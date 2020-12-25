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
	public class MicAmplifierFloat : IProcessor<float> // TypeDefIndex: 5395
	{
		// Properties
		public float AmplificationFactor { get; set; } // 0x00000001803847C0-0x00000001803847D0 0x0000000180384800-0x0000000180384810
		public float BoostValue { get; set; } // 0x000000018036CBE0-0x000000018036CBF0 0x00000001803847F0-0x0000000180384800
		public float MaxBefore { get; private set; } // 0x00000001803847D0-0x00000001803847E0 0x0000000180384810-0x0000000180384820
		public float MaxAfter { get; private set; } // 0x00000001803847E0-0x00000001803847F0 0x0000000180384820-0x0000000180384830
		public bool Disabled { get; set; } // 0x000000018027A6C0-0x000000018027A6D0 0x00000001802840E0-0x00000001802840F0
	
		// Constructors
		public MicAmplifierFloat() {} // Dummy constructor
		public MicAmplifierFloat(float amplificationFactor, float boostValue) {} // 0x0000000180F3AD00-0x0000000180F3AD40
	
		// Methods
		public float[] Process(float[] buf) => default; // 0x0000000180F3AC40-0x0000000180F3AD00
		public void Dispose() {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
