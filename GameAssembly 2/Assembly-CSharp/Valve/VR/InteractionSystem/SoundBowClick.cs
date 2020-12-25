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
	public class SoundBowClick : MonoBehaviour // TypeDefIndex: 8428
	{
		// Fields
		public AudioClip bowClick; // 0x18
		public AnimationCurve pitchTensionCurve; // 0x20
		public float minPitch; // 0x28
		public float maxPitch; // 0x2C
		private AudioSource thisAudioSource; // 0x30
	
		// Constructors
		public SoundBowClick() {} // 0x0000000180276E90-0x0000000180276EA0
	
		// Methods
		private void Awake() {} // 0x0000000180FCC7C0-0x0000000180FCC810
		public void PlayBowTensionClicks(float normalizedTension) {} // 0x0000000180FCC810-0x0000000180FCC870
	}
}
