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
	public class MicWrapper : IAudioReader<float> // TypeDefIndex: 4742
	{
		// Fields
		private AudioClip mic; // 0x10
		private string device; // 0x18
		private Photon.Voice.ILogger logger; // 0x20
		private int micPrevPos; // 0x30
		private int micLoopCnt; // 0x34
		private int readAbsPos; // 0x38
	
		// Properties
		public int SamplingRate { get => default; } // 0x0000000180F240C0-0x0000000180F240F0 
		public int Channels { get => default; } // 0x0000000180F24090-0x0000000180F240C0 
		public string Error { get; private set; } // 0x00000001802470A0-0x00000001802470B0 0x0000000180249810-0x0000000180249820
	
		// Constructors
		public MicWrapper() {} // Dummy constructor
		public MicWrapper(string device, int suggestedFrequency, Photon.Voice.ILogger logger) {} // 0x0000000180F239C0-0x0000000180F24090
	
		// Methods
		public void Dispose() {} // 0x0000000180F23810-0x0000000180F23820
		public bool Read(float[] buffer) => default; // 0x0000000180F23820-0x0000000180F239C0
	}
}
