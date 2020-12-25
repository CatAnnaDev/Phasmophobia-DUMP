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
	public class BalloonSpawner : MonoBehaviour // TypeDefIndex: 8422
	{
		// Fields
		public float minSpawnTime; // 0x18
		public float maxSpawnTime; // 0x1C
		private float nextSpawnTime; // 0x20
		public GameObject balloonPrefab; // 0x28
		public bool autoSpawn; // 0x30
		public bool spawnAtStartup; // 0x31
		public bool playSounds; // 0x32
		public SoundPlayOneshot inflateSound; // 0x38
		public SoundPlayOneshot stretchSound; // 0x40
		public bool sendSpawnMessageToParent; // 0x48
		public float scale; // 0x4C
		public Transform spawnDirectionTransform; // 0x50
		public float spawnForce; // 0x58
		public bool attachBalloon; // 0x5C
		public Balloon.BalloonColor color; // 0x60
	
		// Constructors
		public BalloonSpawner() {} // 0x0000000180FB6620-0x0000000180FB6650
	
		// Methods
		private void Start() {} // 0x0000000180FB64B0-0x0000000180FB6560
		private void Update() {} // 0x0000000180FB6560-0x0000000180FB6620
		public GameObject SpawnBalloon(Balloon.BalloonColor color = Balloon.BalloonColor.Red /* Metadata: 0x00655901 */) => default; // 0x0000000180FB6030-0x0000000180FB64B0
		public void SpawnBalloonFromEvent(int color) {} // 0x0000000180FB6020-0x0000000180FB6030
	}
}
