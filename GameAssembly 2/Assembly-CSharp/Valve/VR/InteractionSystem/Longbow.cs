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
	// [RequireComponent] // 0x000000018014A270-0x000000018014A2C0
	public class Longbow : MonoBehaviour // TypeDefIndex: 8425
	{
		// Fields
		public Handedness currentHandGuess; // 0x18
		private float timeOfPossibleHandSwitch; // 0x1C
		private float timeBeforeConfirmingHandSwitch; // 0x20
		private bool possibleHandSwitch; // 0x24
		public Transform pivotTransform; // 0x28
		public Transform handleTransform; // 0x30
		private Hand hand; // 0x38
		private ArrowHand arrowHand; // 0x40
		public Transform nockTransform; // 0x48
		public Transform nockRestTransform; // 0x50
		public bool autoSpawnArrowHand; // 0x58
		public ItemPackage arrowHandItemPackage; // 0x60
		public GameObject arrowHandPrefab; // 0x68
		public bool nocked; // 0x70
		public bool pulled; // 0x71
		private const float minPull = 0.05f; // Metadata: 0x00655905
		private const float maxPull = 0.5f; // Metadata: 0x00655909
		private float nockDistanceTravelled; // 0x74
		private float hapticDistanceThreshold; // 0x78
		private float lastTickDistance; // 0x7C
		private const float bowPullPulseStrengthLow = 100f; // Metadata: 0x0065590D
		private const float bowPullPulseStrengthHigh = 500f; // Metadata: 0x00655911
		private Vector3 bowLeftVector; // 0x80
		public float arrowMinVelocity; // 0x8C
		public float arrowMaxVelocity; // 0x90
		private float arrowVelocity; // 0x94
		private float minStrainTickTime; // 0x98
		private float maxStrainTickTime; // 0x9C
		private float nextStrainTick; // 0xA0
		private bool lerpBackToZeroRotation; // 0xA4
		private float lerpStartTime; // 0xA8
		private float lerpDuration; // 0xAC
		private Quaternion lerpStartRotation; // 0xB0
		private float nockLerpStartTime; // 0xC0
		private Quaternion nockLerpStartRotation; // 0xC4
		public float drawOffset; // 0xD4
		public LinearMapping bowDrawLinearMapping; // 0xD8
		private bool deferNewPoses; // 0xE0
		private Vector3 lateUpdatePos; // 0xE4
		private Quaternion lateUpdateRot; // 0xF0
		public SoundBowClick drawSound; // 0x100
		private float drawTension; // 0x108
		public SoundPlayOneshot arrowSlideSound; // 0x110
		public SoundPlayOneshot releaseSound; // 0x118
		public SoundPlayOneshot nockSound; // 0x120
		private SteamVR_Events.Action newPosesAppliedAction; // 0x128
	
		// Nested types
		public enum Handedness // TypeDefIndex: 8426
		{
			Left = 0,
			Right = 1
		}
	
		// Constructors
		public Longbow() {} // 0x0000000180FC9920-0x0000000180FC9980
	
		// Methods
		private void OnAttachedToHand(Hand attachedHand) {} // 0x0000000180278400-0x0000000180278410
		private void Awake() {} // 0x0000000180FC8420-0x0000000180FC84B0
		private void OnEnable() {} // 0x0000000180FC9370-0x0000000180FC93A0
		private void OnDisable() {} // 0x0000000180FC9340-0x0000000180FC9370
		private void LateUpdate() {} // 0x0000000180FC9250-0x0000000180FC92D0
		private void OnNewPosesApplied() {} // 0x0000000180FC93F0-0x0000000180FC9480
		private void HandAttachedUpdate(Hand hand) {} // 0x0000000180FC8630-0x0000000180FC9250
		public void ArrowReleased() {} // 0x0000000180FC82D0-0x0000000180FC8420
		// [IteratorStateMachine] // 0x000000018014A3E0-0x000000018014A430
		private IEnumerator ResetDrawAnim() => default; // 0x0000000180FC9540-0x0000000180FC95B0
		public float GetArrowVelocity() => default; // 0x0000000180FC8620-0x0000000180FC8630
		public void StartRotationLerp() {} // 0x0000000180FC98C0-0x0000000180FC9920
		public void StartNock(ArrowHand currentArrowHand) {} // 0x0000000180FC97A0-0x0000000180FC98C0
		private void EvaluateHandedness() {} // 0x0000000180FC8540-0x0000000180FC8620
		private void DoHandednessCheck() {} // 0x0000000180FC84B0-0x0000000180FC8540
		public void ArrowInPosition() {} // 0x0000000180FC8240-0x0000000180FC82D0
		public void ReleaseNock() {} // 0x0000000180FC9480-0x0000000180FC9540
		private void ShutDown() {} // 0x0000000180FC95B0-0x0000000180FC97A0
		private void OnHandFocusLost(Hand hand) {} // 0x0000000180FB3EE0-0x0000000180FB3F10
		private void OnHandFocusAcquired(Hand hand) {} // 0x0000000180FC93A0-0x0000000180FC93F0
		private void OnDetachedFromHand(Hand hand) {} // 0x0000000180FC92E0-0x0000000180FC9340
		private void OnDestroy() {} // 0x0000000180FC92D0-0x0000000180FC92E0
	}
}
