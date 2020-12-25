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
	public class AudioClipWrapper : IAudioReader<float> // TypeDefIndex: 4737
	{
		// Fields
		private AudioClip audioClip; // 0x10
		private int readPos; // 0x18
		private float startTime; // 0x1C
		private bool playing; // 0x21
	
		// Properties
		public bool Loop { get; set; } // 0x000000018027A6C0-0x000000018027A6D0 0x00000001802840E0-0x00000001802840F0
		public int SamplingRate { get => default; } // 0x0000000180F1A890-0x0000000180F1A8B0 
		public int Channels { get => default; } // 0x0000000180F1A870-0x0000000180F1A890 
		public string Error { get; private set; } // 0x00000001802470A0-0x00000001802470B0 0x0000000180249810-0x0000000180249820
	
		// Constructors
		public AudioClipWrapper() {} // Dummy constructor
		public AudioClipWrapper(AudioClip audioClip) {} // 0x0000000180F1A820-0x0000000180F1A870
	
		// Methods
		public bool Read(float[] buffer) => default; // 0x0000000180F1A6F0-0x0000000180F1A820
		public void Dispose() {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
