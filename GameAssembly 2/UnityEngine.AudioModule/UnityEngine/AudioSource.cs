/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Bindings;
using UnityEngine.Internal;

// Image 11: UnityEngine.AudioModule.dll - Assembly: UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3707-3728

namespace UnityEngine
{
	// [RequireComponent] // 0x00000001800E2750-0x00000001800E27D0
	// [StaticAccessor] // 0x00000001800E2750-0x00000001800E27D0
	public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 3717
	{
		// Properties
		public float volume { get => default; set {} } // 0x0000000180AEBED0-0x0000000180AEBF10 0x0000000180AEC210-0x0000000180AEC260
		public float pitch { get => default; set {} } // 0x0000000180AEB8D0-0x0000000180AEB910 0x0000000180AEBBF0-0x0000000180AEBC40
		[NativeProperty] // 0x00000001800E3F20-0x00000001800E3F50
		public int timeSamples { [NativeMethod] /* 0x00000001800D8420-0x00000001800D8450 */ get => default; } // 0x0000000180AEBE90-0x0000000180AEBED0 
		[NativeProperty] // 0x00000001800E3FC0-0x00000001800E3FF0
		public AudioClip clip { get => default; set {} } // 0x0000000180AEBD10-0x0000000180AEBD50 0x0000000180AEBF10-0x0000000180AEBF60
		public AudioMixerGroup outputAudioMixerGroup { get => default; set {} } // 0x0000000180AEBE10-0x0000000180AEBE50 0x0000000180AEC0A0-0x0000000180AEC0F0
		public bool isPlaying { /* [NativeName] */ /* 0x00000001800E3E60-0x00000001800E3E90 */ get => default; } // 0x0000000180AEBD50-0x0000000180AEBD90 
		public bool loop { get => default; set {} } // 0x0000000180AEBD90-0x0000000180AEBDD0 0x0000000180AEBF60-0x0000000180AEBFB0
		public bool playOnAwake { get => default; set {} } // 0x0000000180AEBE50-0x0000000180AEBE90 0x0000000180AEC0F0-0x0000000180AEC140
		[NativeProperty] // 0x00000001800E4060-0x00000001800E4090
		public float spatialBlend { set {} } // 0x0000000180AEC1C0-0x0000000180AEC210
		public int priority { set {} } // 0x0000000180AEC140-0x0000000180AEC180
		public bool mute { get => default; set {} } // 0x0000000180AEBDD0-0x0000000180AEBE10 0x0000000180AEC050-0x0000000180AEC0A0
		public float minDistance { set {} } // 0x0000000180AEC000-0x0000000180AEC050
		public float maxDistance { set {} } // 0x0000000180AEBFB0-0x0000000180AEC000
		public AudioRolloffMode rolloffMode { set {} } // 0x0000000180AEC180-0x0000000180AEC1C0
	
		// Constructors
		public AudioSource() {} // Dummy constructor
	
		// Methods
		private static float GetPitch([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ AudioSource source) => default; // 0x0000000180AEB8D0-0x0000000180AEB910
		private static void SetPitch([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ AudioSource source, float pitch) {} // 0x0000000180AEBBF0-0x0000000180AEBC40
		private static void PlayHelper([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ AudioSource source, ulong delay) {} // 0x0000000180AEB950-0x0000000180AEB9A0
		private static void PlayOneShotHelper([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ AudioSource source, AudioClip clip, float volumeScale) {} // 0x0000000180AEB9A0-0x0000000180AEBA00
		private void Stop(bool stopOneShots) {} // 0x0000000180AEBC80-0x0000000180AEBCD0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void Play() {} // 0x0000000180AEBBB0-0x0000000180AEBBF0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void PlayOneShot(AudioClip clip) {} // 0x0000000180AEBAE0-0x0000000180AEBBB0
		public void PlayOneShot(AudioClip clip, [DefaultValue] /* 0x00000001800E3E00-0x00000001800E3E30 */ float volumeScale) {} // 0x0000000180AEBA00-0x0000000180AEBAE0
		public void Stop() {} // 0x0000000180AEBC40-0x0000000180AEBC80
		public void Pause() {} // 0x0000000180AEB910-0x0000000180AEB950
		public void UnPause() {} // 0x0000000180AEBCD0-0x0000000180AEBD10
	}
}
