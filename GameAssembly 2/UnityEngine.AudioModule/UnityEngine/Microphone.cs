/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 11: UnityEngine.AudioModule.dll - Assembly: UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3707-3728

namespace UnityEngine
{
	// [StaticAccessor] // 0x00000001800E43C0-0x00000001800E43F0
	public sealed class Microphone // TypeDefIndex: 3720
	{
		// Properties
		public static string[] devices { /* [NativeName] */ /* 0x00000001800E44C0-0x00000001800E44F0 */ get => default; } // 0x0000000180AEC830-0x0000000180AEC860 
	
		// Constructors
		public Microphone() {} // Dummy constructor
	
		// Methods
		[NativeMethod] // 0x00000001800D8420-0x00000001800D8450
		private static int GetMicrophoneDeviceIDFromName(string name) => default; // 0x0000000180AEC3F0-0x0000000180AEC430
		private static AudioClip StartRecord(int deviceID, bool loop, float lengthSec, int frequency) => default; // 0x0000000180AEC590-0x0000000180AEC600
		private static void EndRecord(int deviceID) {} // 0x0000000180AEC260-0x0000000180AEC2A0
		private static bool IsRecording(int deviceID) => default; // 0x0000000180AEC550-0x0000000180AEC590
		[NativeMethod] // 0x00000001800D8420-0x00000001800D8450
		private static int GetRecordPosition(int deviceID) => default; // 0x0000000180AEC4A0-0x0000000180AEC4E0
		private static void GetDeviceCaps(int deviceID, out int minFreq, out int maxFreq) {
			minFreq = default;
			maxFreq = default;
		} // 0x0000000180AEC310-0x0000000180AEC360
		public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency) => default; // 0x0000000180AEC600-0x0000000180AEC830
		public static void End(string deviceName) {} // 0x0000000180AEC2A0-0x0000000180AEC310
		public static bool IsRecording(string deviceName) => default; // 0x0000000180AEC4E0-0x0000000180AEC550
		public static int GetPosition(string deviceName) => default; // 0x0000000180AEC430-0x0000000180AEC4A0
		public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq) {
			minFreq = default;
			maxFreq = default;
		} // 0x0000000180AEC360-0x0000000180AEC3F0
	}
}
