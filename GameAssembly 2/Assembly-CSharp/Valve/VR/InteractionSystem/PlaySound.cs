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
	// [RequireComponent] // 0x000000018013B9D0-0x000000018013BA20
	public class PlaySound : MonoBehaviour // TypeDefIndex: 8387
	{
		// Fields
		// [Tooltip] // 0x000000018013BA50-0x000000018013BA80
		public AudioClip[] waveFile; // 0x18
		// [Tooltip] // 0x000000018013BB40-0x000000018013BB70
		public bool stopOnPlay; // 0x20
		// [Tooltip] // 0x000000018013BC00-0x000000018013BC30
		public bool disableOnEnd; // 0x21
		// [Tooltip] // 0x000000018013BC90-0x000000018013BCC0
		public bool looping; // 0x22
		// [Tooltip] // 0x000000018013BD70-0x000000018013BDA0
		public bool stopOnEnd; // 0x23
		// [Tooltip] // 0x000000018013BDD0-0x000000018013BE00
		public bool playOnAwakeWithDelay; // 0x24
		// [Header] // 0x000000018013BED0-0x000000018013BF00
		public bool useRandomVolume; // 0x25
		// [Range] // 0x000000018013BF90-0x000000018013BFF0
		// [Tooltip] // 0x000000018013BF90-0x000000018013BFF0
		public float volMin; // 0x28
		// [Range] // 0x000000018013C160-0x000000018013C1C0
		// [Tooltip] // 0x000000018013C160-0x000000018013C1C0
		public float volMax; // 0x2C
		// [Header] // 0x000000018013C2D0-0x000000018013C330
		// [Tooltip] // 0x000000018013C2D0-0x000000018013C330
		public bool useRandomPitch; // 0x30
		// [Range] // 0x000000018013C3E0-0x000000018013C430
		// [Tooltip] // 0x000000018013C3E0-0x000000018013C430
		public float pitchMin; // 0x34
		// [Range] // 0x000000018013C5D0-0x000000018013C630
		// [Tooltip] // 0x000000018013C5D0-0x000000018013C630
		public float pitchMax; // 0x38
		// [Header] // 0x000000018013C680-0x000000018013C6E0
		// [Tooltip] // 0x000000018013C680-0x000000018013C6E0
		public bool useRetriggerTime; // 0x3C
		// [Range] // 0x000000018013C840-0x000000018013C8A0
		// [Tooltip] // 0x000000018013C840-0x000000018013C8A0
		public float timeInitial; // 0x40
		// [Range] // 0x000000018013CA00-0x000000018013CA50
		// [Tooltip] // 0x000000018013CA00-0x000000018013CA50
		public float timeMin; // 0x44
		// [Range] // 0x000000018013CB30-0x000000018013CB80
		// [Tooltip] // 0x000000018013CB30-0x000000018013CB80
		public float timeMax; // 0x48
		// [Header] // 0x000000018013D490-0x000000018013D4F0
		// [Tooltip] // 0x000000018013D490-0x000000018013D4F0
		public bool useRandomSilence; // 0x4C
		// [Range] // 0x000000018013D5A0-0x000000018013D5F0
		// [Tooltip] // 0x000000018013D5A0-0x000000018013D5F0
		public float percentToNotPlay; // 0x50
		// [Header] // 0x000000018013D6A0-0x000000018013D700
		// [Tooltip] // 0x000000018013D6A0-0x000000018013D700
		public float delayOffsetTime; // 0x54
		private AudioSource audioSource; // 0x58
		private AudioClip clip; // 0x60
	
		// Constructors
		public PlaySound() {} // 0x0000000180FC9F50-0x0000000180FC9F80
	
		// Methods
		private void Awake() {} // 0x0000000180FC9980-0x0000000180FC9AD0
		public void Play() {} // 0x0000000180FC9C90-0x0000000180FC9DF0
		public void PlayWithDelay(float delayTime) {} // 0x0000000180FC9C30-0x0000000180FC9C90
		public AudioClip PlayOneShotSound() => default; // 0x0000000180FC9B80-0x0000000180FC9C30
		public AudioClip PlayLooping() => default; // 0x0000000180FC9AD0-0x0000000180FC9B80
		public void Disable() {} // 0x0000000180FB3EE0-0x0000000180FB3F10
		public void Stop() {} // 0x0000000180FC9F30-0x0000000180FC9F50
		private void SetAudioSource() {} // 0x0000000180FC9DF0-0x0000000180FC9F30
	}
}
