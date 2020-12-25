/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Voice.Unity;
using UnityEngine;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity.UtilityScripts
{
	// [RequireComponent] // 0x0000000180115D90-0x0000000180115DE0
	public class MicAmplifier : VoiceComponent // TypeDefIndex: 5394
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float boostValue; // 0x28
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float amplificationFactor; // 0x2C
		private MicAmplifierFloat floatProcessor; // 0x30
		private MicAmplifierShort shortProcessor; // 0x38
	
		// Properties
		public float AmplificationFactor { get => default; set {} } // 0x000000018036E6B0-0x000000018036E6C0 0x0000000180F3B340-0x0000000180F3B3A0
		public float BoostValue { get => default; set {} } // 0x000000018036E6C0-0x000000018036E6D0 0x0000000180F3B3A0-0x0000000180F3B400
	
		// Constructors
		public MicAmplifier() {} // 0x0000000180F3B320-0x0000000180F3B340
	
		// Methods
		private void OnEnable() {} // 0x0000000180F3AE80-0x0000000180F3AEA0
		private void OnDisable() {} // 0x0000000180F3AE60-0x0000000180F3AE80
		private void PhotonVoiceCreated(PhotonVoiceCreatedParams p) {} // 0x0000000180F3AEA0-0x0000000180F3B320
	}
}
