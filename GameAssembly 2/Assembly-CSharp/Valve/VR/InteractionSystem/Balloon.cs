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
	public class Balloon : MonoBehaviour // TypeDefIndex: 8418
	{
		// Fields
		private Hand hand; // 0x18
		public GameObject popPrefab; // 0x20
		public float maxVelocity; // 0x28
		public float lifetime; // 0x2C
		public bool burstOnLifetimeEnd; // 0x30
		public GameObject lifetimeEndParticlePrefab; // 0x38
		public SoundPlayOneshot lifetimeEndSound; // 0x40
		private float destructTime; // 0x48
		private float releaseTime; // 0x4C
		public SoundPlayOneshot collisionSound; // 0x50
		private float lastSoundTime; // 0x58
		private float soundDelay; // 0x5C
		private Rigidbody balloonRigidbody; // 0x60
		private bool bParticlesSpawned; // 0x68
		private static float s_flLastDeathSound; // 0x00
	
		// Nested types
		public enum BalloonColor // TypeDefIndex: 8419
		{
			Red = 0,
			OrangeRed = 1,
			Orange = 2,
			YellowOrange = 3,
			Yellow = 4,
			GreenYellow = 5,
			Green = 6,
			BlueGreen = 7,
			Blue = 8,
			VioletBlue = 9,
			Violet = 10,
			RedViolet = 11,
			LightGray = 12,
			DarkGray = 13,
			Random = 14
		}
	
		// Constructors
		public Balloon() {} // 0x0000000180FB72D0-0x0000000180FB7300
		static Balloon() {} // 0x0000000180246DB0-0x0000000180246DC0
	
		// Methods
		private void Start() {} // 0x0000000180FB7190-0x0000000180FB7230
		private void Update() {} // 0x0000000180FB7230-0x0000000180FB72D0
		private void SpawnParticles(GameObject particlePrefab, SoundPlayOneshot sound) {} // 0x0000000180FB6F10-0x0000000180FB7190
		private void FixedUpdate() {} // 0x0000000180FB6970-0x0000000180FB6A90
		private void ApplyDamage() {} // 0x0000000180FB6650-0x0000000180FB66C0
		private void OnCollisionEnter(Collision collision) {} // 0x0000000180FB6A90-0x0000000180FB6E70
		public void SetColor(BalloonColor color) {} // 0x0000000180FB6E70-0x0000000180FB6F10
		private Color BalloonColorToRGB(BalloonColor balloonColorVar) => default; // 0x0000000180FB66C0-0x0000000180FB6970
	}
}
