/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 11: UnityEngine.AudioModule.dll - Assembly: UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3707-3728

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800DFED0-0x00000001800DFF30
	// [StaticAccessor] // 0x00000001800DFED0-0x00000001800DFF30
	public sealed class AudioSettings // TypeDefIndex: 3710
	{
		// Properties
		public static AudioSpeakerMode speakerMode { get => default; } // 0x0000000180AEB6C0-0x0000000180AEB6F0 
		public static double dspTime { [NativeMethod] /* 0x00000001800E0370-0x00000001800E03B0 */ get => default; } // 0x0000000180AEB7F0-0x0000000180AEB820 
		public static int outputSampleRate { get => default; } // 0x0000000180AEB690-0x0000000180AEB6C0 
	
		// Events
		public static event AudioConfigurationChangeHandler OnAudioConfigurationChanged;
	
		// Nested types
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged); // TypeDefIndex: 3711; 0x0000000180AEAE60-0x0000000180AEB150
	
		// Constructors
		public AudioSettings() {} // Dummy constructor
	
		// Methods
		private static AudioSpeakerMode GetSpeakerMode() => default; // 0x0000000180AEB6C0-0x0000000180AEB6F0
		[NativeMethod] // 0x00000001800E01D0-0x00000001800E0210
		private static int GetSampleRate() => default; // 0x0000000180AEB690-0x0000000180AEB6C0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) {} // 0x0000000180AEB6F0-0x0000000180AEB740
	}
}
