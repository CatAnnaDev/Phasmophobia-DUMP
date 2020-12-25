/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Voice;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice.Windows
{
	public class WindowsAudioInPusher : IAudioPusher<short> // TypeDefIndex: 4734
	{
		// Fields
		private IntPtr handle; // 0x10
		private int instanceID; // 0x18
		private Action<short[]> pushCallback; // 0x20
		private ObjectFactory<short[], int> bufferFactory; // 0x28
		private static int instanceCnt; // 0x00
		private static Dictionary<int, WindowsAudioInPusher> instancePerHandle; // 0x08
	
		// Properties
		public int Channels { get => default; } // 0x0000000180248DE0-0x0000000180248DF0 
		public int SamplingRate { get => default; } // 0x0000000180F39DD0-0x0000000180F39DE0 
		public string Error { get; private set; } // 0x00000001802470B0-0x00000001802470C0 0x0000000180249070-0x0000000180249080
	
		// Nested types
		private enum SystemMode // TypeDefIndex: 4735
		{
			SINGLE_CHANNEL_AEC = 0,
			OPTIBEAM_ARRAY_ONLY = 2,
			OPTIBEAM_ARRAY_AND_AEC = 4,
			SINGLE_CHANNEL_NSAGC = 5
		}
	
		private delegate void CallbackDelegate(int instanceID, IntPtr buf, int len); // TypeDefIndex: 4736; 0x0000000180F1C1F0-0x0000000180F1C550
	
		// Constructors
		public WindowsAudioInPusher() {} // Dummy constructor
		public WindowsAudioInPusher(int deviceID, ILogger logger) {} // 0x0000000180F39AC0-0x0000000180F39DD0
		static WindowsAudioInPusher() {} // 0x0000000180F39A50-0x0000000180F39AC0
	
		// Methods
		private static extern IntPtr Photon_Audio_In_Create(int instanceID, SystemMode systemMode, int micDevIdx, int spkDevIdx, Action<int, IntPtr, int> callback, bool featrModeOn, bool noiseSup, bool agc, bool cntrClip); // 0x0000000180F39890-0x0000000180F39990
		private static extern void Photon_Audio_In_Destroy(IntPtr handler); // 0x0000000180F39990-0x0000000180F39A10
		// [MonoPInvokeCallback] // 0x0000000180134DA0-0x0000000180134DF0
		private static void nativePushCallback(int instanceID, IntPtr buf, int len) {} // 0x0000000180F39DE0-0x0000000180F3A0A0
		public void SetCallback(Action<short[]> callback, ObjectFactory<short[], int> bufferFactory) {} // 0x0000000180F39A10-0x0000000180F39A50
		private void push(IntPtr buf, int lenBytes) {} // 0x0000000180F3A0A0-0x0000000180F3A1F0
		public void Dispose() {} // 0x0000000180F39670-0x0000000180F39890
	}
}
