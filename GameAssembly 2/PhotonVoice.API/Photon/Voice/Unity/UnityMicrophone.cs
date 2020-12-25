/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice.Unity
{
	public static class UnityMicrophone // TypeDefIndex: 4747
	{
		// Properties
		public static string[] devices { get; } // 0x0000000180F30E80-0x0000000180F30E90 
	
		// Methods
		public static void End(string deviceName) {} // 0x0000000180F30E30-0x0000000180F30E40
		public static void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq) {
			minFreq = default;
			maxFreq = default;
		} // 0x0000000180F30E40-0x0000000180F30E50
		public static int GetPosition(string deviceName) => default; // 0x0000000180F30E50-0x0000000180F30E60
		public static bool IsRecording(string deviceName) => default; // 0x0000000180F30E60-0x0000000180F30E70
		public static AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency) => default; // 0x0000000180F30E70-0x0000000180F30E80
	}
}
