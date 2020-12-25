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
	// [RequireComponent] // 0x00000001800D5A50-0x00000001800D5AA0
	public class InteractableExample : MonoBehaviour // TypeDefIndex: 8432
	{
		// Fields
		private TextMesh textMesh; // 0x18
		private Vector3 oldPosition; // 0x20
		private Quaternion oldRotation; // 0x2C
		private float attachTime; // 0x3C
		private Hand.AttachmentFlags attachmentFlags; // 0x40
	
		// Constructors
		public InteractableExample() {} // 0x0000000180FC58E0-0x0000000180FC58F0
	
		// Methods
		private void Awake() {} // 0x0000000180FC53B0-0x0000000180FC5420
		private void OnHandHoverBegin(Hand hand) {} // 0x0000000180FC5810-0x0000000180FC5890
		private void OnHandHoverEnd(Hand hand) {} // 0x0000000180FC5890-0x0000000180FC58E0
		private void HandHoverUpdate(Hand hand) {} // 0x0000000180FC54E0-0x0000000180FC5700
		private void OnAttachedToHand(Hand hand) {} // 0x0000000180FC5700-0x0000000180FC5790
		private void OnDetachedFromHand(Hand hand) {} // 0x0000000180FC5790-0x0000000180FC5810
		private void HandAttachedUpdate(Hand hand) {} // 0x0000000180FC5420-0x0000000180FC54E0
		private void OnHandFocusAcquired(Hand hand) {} // 0x0000000180246DB0-0x0000000180246DC0
		private void OnHandFocusLost(Hand hand) {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
