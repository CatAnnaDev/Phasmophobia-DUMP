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
	public class MicAmplifierShort : IProcessor<short> // TypeDefIndex: 5396
	{
		// Properties
		public short AmplificationFactor { get; set; } // 0x0000000180998910-0x0000000180998920 0x0000000180998920-0x0000000180998930
		public short BoostValue { get; set; } // 0x0000000180F3AE00-0x0000000180F3AE10 0x0000000180F3AE30-0x0000000180F3AE40
		public short MaxBefore { get; private set; } // 0x0000000180F3AE20-0x0000000180F3AE30 0x0000000180F3AE50-0x0000000180F3AE60
		public short MaxAfter { get; private set; } // 0x0000000180F3AE10-0x0000000180F3AE20 0x0000000180F3AE40-0x0000000180F3AE50
		public bool Disabled { get; set; } // 0x00000001802D9720-0x00000001802D9730 0x00000001803DE8D0-0x00000001803DE8E0
	
		// Constructors
		public MicAmplifierShort() {} // Dummy constructor
		public MicAmplifierShort(short amplificationFactor, short boostValue) {} // 0x00000001805054E0-0x0000000180505520
	
		// Methods
		public short[] Process(short[] buf) => default; // 0x0000000180F3AD40-0x0000000180F3AE00
		public void Dispose() {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
