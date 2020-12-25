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
	public class MicWrapperPusher : IAudioPusher<float> // TypeDefIndex: 4743
	{
		// Fields
		private AudioSource audioSource; // 0x10
		private AudioClip mic; // 0x18
		private string device; // 0x20
		private Photon.Voice.ILogger logger; // 0x28
		private AudioOutCapture audioOutCapture; // 0x30
		private int sampleRate; // 0x38
		private int channels; // 0x3C
		private bool destroyGameObjectOnStop; // 0x40
		private float[] frame2; // 0x48
		private Action<float[]> pushCallback; // 0x50
	
		// Properties
		public int SamplingRate { get => default; } // 0x0000000180F23800-0x0000000180F23810 
		public int Channels { get => default; } // 0x0000000180F237F0-0x0000000180F23800 
		public string Error { get; private set; } // 0x0000000180246F30-0x0000000180246F40 0x00000001802470C0-0x00000001802470D0
	
		// Constructors
		public MicWrapperPusher() {} // Dummy constructor
		public MicWrapperPusher(string device, AudioSource aS, int suggestedFrequency, Photon.Voice.ILogger lg, bool destroyOnStop = true /* Metadata: 0x0064E6E4 */) {} // 0x0000000180F21B90-0x0000000180F22A40
		public MicWrapperPusher(string device, GameObject gO, int suggestedFrequency, Photon.Voice.ILogger lg, bool destroyOnStop = true /* Metadata: 0x0064E6E5 */) {} // 0x0000000180F20A00-0x0000000180F21B90
		public MicWrapperPusher(string device, Transform parentTransform, int suggestedFrequency, Photon.Voice.ILogger lg, bool destroyOnStop = true /* Metadata: 0x0064E6E6 */) {} // 0x0000000180F22A40-0x0000000180F237F0
	
		// Methods
		private void AudioOutCaptureOnOnAudioFrame(float[] frame, int channelsNumber) {} // 0x0000000180F20520-0x0000000180F20740
		public void SetCallback(Action<float[]> callback, ObjectFactory<float[], int> bufferFactory) {} // 0x0000000180F20900-0x0000000180F20A00
		public void Dispose() {} // 0x0000000180F20740-0x0000000180F20900
	}
}
