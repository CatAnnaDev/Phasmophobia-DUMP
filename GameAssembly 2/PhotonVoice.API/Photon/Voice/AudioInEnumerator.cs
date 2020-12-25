/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class AudioInEnumerator : IDisposable // TypeDefIndex: 4636
	{
		// Fields
		private const string lib_name = "AudioIn"; // Metadata: 0x0064E57D
		private IntPtr handle; // 0x10
		public readonly bool IsSupported; // 0x18
	
		// Properties
		public string Error { get; private set; } // 0x0000000180246FE0-0x0000000180246FF0 0x0000000180249080-0x0000000180249090
		public int Count { get => default; } // 0x0000000180F1B090-0x0000000180F1B120 
	
		// Constructors
		public AudioInEnumerator() {} // Dummy constructor
		public AudioInEnumerator(ILogger logger) {} // 0x0000000180F1AFF0-0x0000000180F1B090
	
		// Methods
		private static extern IntPtr Photon_Audio_In_CreateMicEnumerator(); // 0x0000000180F1ABA0-0x0000000180F1AC10
		private static extern void Photon_Audio_In_DestroyMicEnumerator(IntPtr handle); // 0x0000000180F1AC10-0x0000000180F1AC90
		private static extern int Photon_Audio_In_MicEnumerator_Count(IntPtr handle); // 0x0000000180F1AC90-0x0000000180F1AD10
		private static extern IntPtr Photon_Audio_In_MicEnumerator_NameAtIndex(IntPtr handle, int idx); // 0x0000000180F1ADA0-0x0000000180F1AE30
		private static extern int Photon_Audio_In_MicEnumerator_IDAtIndex(IntPtr handle, int idx); // 0x0000000180F1AD10-0x0000000180F1ADA0
		public void Refresh() {} // 0x0000000180F1AE30-0x0000000180F1AFF0
		public string NameAtIndex(int idx) => default; // 0x0000000180F1AAB0-0x0000000180F1ABA0
		public int IDAtIndex(int idx) => default; // 0x0000000180F1AA00-0x0000000180F1AAA0
		public bool IDIsValid(int id) => default; // 0x0000000180F1AAA0-0x0000000180F1AAB0
		public void Dispose() {} // 0x0000000180F1A930-0x0000000180F1AA00
	}
}
