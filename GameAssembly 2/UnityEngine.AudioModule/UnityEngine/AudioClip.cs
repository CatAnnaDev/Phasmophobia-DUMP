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
	// [NativeHeader] // 0x00000001800E1A60-0x00000001800E1AC0
	// [StaticAccessor] // 0x00000001800E1A60-0x00000001800E1AC0
	public sealed class AudioClip : Object // TypeDefIndex: 3712
	{
		// Properties
		[NativeProperty] // 0x00000001800E2260-0x00000001800E2290
		public float length { get => default; } // 0x0000000180AEAC20-0x0000000180AEAC60 
		[NativeProperty] // 0x00000001800E22F0-0x00000001800E2320
		public int samples { get => default; } // 0x0000000180AEAC60-0x0000000180AEACA0 
		[NativeProperty] // 0x00000001800E2420-0x00000001800E2450
		public int channels { get => default; } // 0x0000000180AEABA0-0x0000000180AEABE0 
		public int frequency { get => default; } // 0x0000000180AEABE0-0x0000000180AEAC20 
	
		// Events
		private event PCMReaderCallback m_PCMReaderCallback;
		private event PCMSetPositionCallback m_PCMSetPositionCallback;
	
		// Nested types
		public delegate void PCMReaderCallback(float[] data); // TypeDefIndex: 3713; 0x0000000180A9FB80-0x0000000180A9FFF0
	
		public delegate void PCMSetPositionCallback(int position); // TypeDefIndex: 3714; 0x0000000180948F50-0x0000000180949220
	
		// Constructors
		private AudioClip() {} // 0x0000000180AEA9E0-0x0000000180AEAA60
	
		// Methods
		private static bool GetData(AudioClip clip, out float[] data, int numSamples, int samplesOffset) {
			data = default;
			return default;
		} // 0x0000000180AEA680-0x0000000180AEA6F0
		private static bool SetData(AudioClip clip, float[] data, int numsamples, int samplesOffset) => default; // 0x0000000180AEA970-0x0000000180AEA9E0
		private static AudioClip Construct_Internal() => default; // 0x0000000180AEA170-0x0000000180AEA1A0
		private string GetName() => default; // 0x0000000180AEA6F0-0x0000000180AEA730
		private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) {} // 0x0000000180AEA1A0-0x0000000180AEA210
		public bool GetData(float[] data, int offsetSamples) => default; // 0x0000000180AEA520-0x0000000180AEA680
		public bool SetData(float[] data, int offsetSamples) => default; // 0x0000000180AEA770-0x0000000180AEA970
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) => default; // 0x0000000180AEA210-0x0000000180AEA240
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback) => default; // 0x0000000180AEA240-0x0000000180AEA520
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private void InvokePCMReaderCallback_Internal(float[] data) {} // 0x0000000180AEA730-0x0000000180AEA750
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private void InvokePCMSetPositionCallback_Internal(int position) {} // 0x0000000180AEA750-0x0000000180AEA770
	}
}
