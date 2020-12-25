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
	public class FireSource : MonoBehaviour // TypeDefIndex: 8424
	{
		// Fields
		public GameObject fireParticlePrefab; // 0x18
		public bool startActive; // 0x20
		private GameObject fireObject; // 0x28
		public ParticleSystem customParticles; // 0x30
		public bool isBurning; // 0x38
		public float burnTime; // 0x3C
		public float ignitionDelay; // 0x40
		private float ignitionTime; // 0x44
		private Hand hand; // 0x48
		public AudioSource ignitionSound; // 0x50
		public bool canSpreadFromThisSource; // 0x58
	
		// Constructors
		public FireSource() {} // 0x0000000180FC13C0-0x0000000180FC13D0
	
		// Methods
		private void Start() {} // 0x0000000180FC12C0-0x0000000180FC12D0
		private void Update() {} // 0x0000000180FC12D0-0x0000000180FC13C0
		private void OnTriggerEnter(Collider other) {} // 0x0000000180FC1040-0x0000000180FC10B0
		private void FireExposure() {} // 0x0000000180FC0F40-0x0000000180FC1040
		private void StartBurning() {} // 0x0000000180FC10B0-0x0000000180FC12C0
	}
}
