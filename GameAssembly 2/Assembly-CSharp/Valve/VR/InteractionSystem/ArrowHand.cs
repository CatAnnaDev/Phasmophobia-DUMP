/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class ArrowHand : MonoBehaviour // TypeDefIndex: 8415
	{
		// Fields
		private Hand hand; // 0x18
		private Longbow bow; // 0x20
		private GameObject currentArrow; // 0x28
		public GameObject arrowPrefab; // 0x30
		public Transform arrowNockTransform; // 0x38
		public float nockDistance; // 0x40
		public float lerpCompleteDistance; // 0x44
		public float rotationLerpThreshold; // 0x48
		public float positionLerpThreshold; // 0x4C
		private bool allowArrowSpawn; // 0x50
		private bool nocked; // 0x51
		private bool inNockRange; // 0x52
		private bool arrowLerpComplete; // 0x53
		public SoundPlayOneshot arrowSpawnSound; // 0x58
		private AllowTeleportWhileAttachedToHand allowTeleport; // 0x60
		public int maxArrowCount; // 0x68
		private List<GameObject> arrowList; // 0x70
	
		// Constructors
		public ArrowHand() {} // 0x0000000180FB3F10-0x0000000180FB3F40
	
		// Methods
		private void Awake() {} // 0x0000000180FB2AF0-0x0000000180FB2B90
		private void OnAttachedToHand(Hand attachedHand) {} // 0x0000000180FB3DD0-0x0000000180FB3E50
		private GameObject InstantiateArrow() => default; // 0x0000000180FB3BB0-0x0000000180FB3DD0
		private void HandAttachedUpdate(Hand hand) {} // 0x0000000180FB3100-0x0000000180FB3BB0
		private void OnDetachedFromHand(Hand hand) {} // 0x0000000180FB3E50-0x0000000180FB3EB0
		private void FireArrow() {} // 0x0000000180FB2C00-0x0000000180FB3100
		private void EnableArrowSpawn() {} // 0x0000000180FB2B90-0x0000000180FB2BA0
		// [IteratorStateMachine] // 0x0000000180149A10-0x0000000180149A60
		private IEnumerator ArrowReleaseHaptics() => default; // 0x0000000180FB2A80-0x0000000180FB2AF0
		private void OnHandFocusLost(Hand hand) {} // 0x0000000180FB3EE0-0x0000000180FB3F10
		private void OnHandFocusAcquired(Hand hand) {} // 0x0000000180FB3EB0-0x0000000180FB3EE0
		private void FindBow() {} // 0x0000000180FB2BA0-0x0000000180FB2C00
	}
}
