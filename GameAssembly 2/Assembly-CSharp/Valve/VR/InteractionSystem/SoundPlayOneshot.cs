/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class SoundPlayOneshot : MonoBehaviour // TypeDefIndex: 8392
	{
		// Fields
		public AudioClip[] waveFiles; // 0x18
		private AudioSource thisAudioSource; // 0x20
		public float volMin; // 0x28
		public float volMax; // 0x2C
		public float pitchMin; // 0x30
		public float pitchMax; // 0x34
		public bool playOnAwake; // 0x38
	
		// Constructors
		public SoundPlayOneshot() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void Awake() {} // 0x0000000180FCC9A0-0x0000000180FCCA00
		public void Play() {} // 0x0000000180FCCA80-0x0000000180FCCBC0
		public void Pause() {} // 0x0000000180FCCA00-0x0000000180FCCA80
		public void UnPause() {} // 0x0000000180FCCBC0-0x0000000180FCCC40
	}
}
