/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Voice;
using UnityEngine;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice.Unity
{
	public class UnityAndroidAudioInAEC : IAudioPusher<short>, IResettable // TypeDefIndex: 4744
	{
		// Fields
		private AndroidJavaObject audioIn; // 0x10
		private IntPtr javaBuf; // 0x18
		private Photon.Voice.ILogger logger; // 0x20
		private int audioInSampleRate; // 0x28
		private DataCallback callback; // 0x30
	
		// Properties
		public int Channels { get => default; } // 0x0000000180248DE0-0x0000000180248DF0 
		public int SamplingRate { get => default; } // 0x000000018026C7E0-0x000000018026C7F0 
		public string Error { get; private set; } // 0x0000000180246FD0-0x0000000180246FE0 0x0000000180278400-0x0000000180278410
	
		// Nested types
		private class DataCallback : AndroidJavaProxy // TypeDefIndex: 4745
		{
			// Fields
			private Action<short[]> callback; // 0x20
			private IntPtr javaBuf; // 0x28
			private int cntFrame; // 0x30
			private int cntShort; // 0x34
	
			// Constructors
			public DataCallback() {} // 0x0000000180F1C600-0x0000000180F1C660
	
			// Methods
			public void SetCallback(Action<short[]> callback, IntPtr javaBuf) {} // 0x0000000180F1C5D0-0x0000000180F1C600
			public void OnData() {} // 0x0000000180F1C550-0x0000000180F1C5C0
			public void OnStop() {} // 0x0000000180F1C5C0-0x0000000180F1C5D0
		}
	
		// Constructors
		public UnityAndroidAudioInAEC() {} // Dummy constructor
		public UnityAndroidAudioInAEC(Photon.Voice.ILogger logger, bool enableAEC = false /* Metadata: 0x0064E6E7 */, bool enableAGC = false /* Metadata: 0x0064E6E8 */, bool enableNS = false /* Metadata: 0x0064E6E9 */) {} // 0x0000000180F2E3B0-0x0000000180F2F1D0
	
		// Methods
		public void SetCallback(Action<short[]> callback, ObjectFactory<short[], int> bufferFactory) {} // 0x0000000180F2E1B0-0x0000000180F2E3B0
		public void Reset() {} // 0x0000000180F2E150-0x0000000180F2E1B0
		public void Dispose() {} // 0x0000000180F2E0F0-0x0000000180F2E150
	}
}
