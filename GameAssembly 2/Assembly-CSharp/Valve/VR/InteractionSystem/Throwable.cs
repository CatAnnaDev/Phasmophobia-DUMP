/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	// [RequireComponent] // 0x000000018013F410-0x000000018013F4B0
	// [RequireComponent] // 0x000000018013F410-0x000000018013F4B0
	// [RequireComponent] // 0x000000018013F410-0x000000018013F4B0
	public class Throwable : MonoBehaviour // TypeDefIndex: 8396
	{
		// Fields
		[EnumFlags] // 0x000000018013F8B0-0x000000018013F900
		// [Tooltip] // 0x000000018013F8B0-0x000000018013F900
		public Hand.AttachmentFlags attachmentFlags; // 0x18
		// [Tooltip] // 0x000000018013FB20-0x000000018013FB50
		public string attachmentPoint; // 0x20
		// [Tooltip] // 0x000000018013FC90-0x000000018013FCC0
		public float catchSpeedThreshold; // 0x28
		// [Tooltip] // 0x000000018013FDC0-0x000000018013FDF0
		public bool restoreOriginalParent; // 0x2C
		public bool attachEaseIn; // 0x2D
		public AnimationCurve snapAttachEaseInCurve; // 0x30
		public float snapAttachEaseInTime; // 0x38
		public string[] attachEaseInAttachmentNames; // 0x40
		private VelocityEstimator velocityEstimator; // 0x48
		private bool attached; // 0x50
		private float attachTime; // 0x54
		private Vector3 attachPosition; // 0x58
		private Quaternion attachRotation; // 0x64
		private Transform attachEaseInTransform; // 0x78
		public UnityEvent onPickUp; // 0x80
		public UnityEvent onDetachFromHand; // 0x88
		public bool snapAttachEaseInCompleted; // 0x90
	
		// Constructors
		public Throwable() {} // 0x0000000180EF3840-0x0000000180EF38A0
	
		// Methods
		private void Awake() {} // 0x0000000180EF25F0-0x0000000180EF2670
		private void OnHandHoverBegin(Hand hand) {} // 0x0000000180EF36F0-0x0000000180EF37D0
		private void OnHandHoverEnd(Hand hand) {} // 0x0000000180EF37D0-0x0000000180EF3840
		private void HandHoverUpdate(Hand hand) {} // 0x0000000180EF2970-0x0000000180EF2A30
		private void OnAttachedToHand(Hand hand) {} // 0x0000000180EF2AC0-0x0000000180EF2D70
		private void OnDetachedFromHand(Hand hand) {} // 0x0000000180EF2D70-0x0000000180EF3640
		private void HandAttachedUpdate(Hand hand) {} // 0x0000000180EF2670-0x0000000180EF2970
		// [IteratorStateMachine] // 0x0000000180140020-0x0000000180140070
		private IEnumerator LateDetach(Hand hand) => default; // 0x0000000180EF2A30-0x0000000180EF2AC0
		private void OnHandFocusAcquired(Hand hand) {} // 0x0000000180EF3640-0x0000000180EF3680
		private void OnHandFocusLost(Hand hand) {} // 0x0000000180EF3680-0x0000000180EF36F0
	}
}
