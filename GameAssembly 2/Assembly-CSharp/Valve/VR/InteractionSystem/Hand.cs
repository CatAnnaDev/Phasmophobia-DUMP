/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class Hand : MonoBehaviour // TypeDefIndex: 8359
	{
		// Fields
		public const AttachmentFlags defaultAttachmentFlags = AttachmentFlags.SnapOnAttach | AttachmentFlags.DetachOthers | AttachmentFlags.DetachFromOtherHand | AttachmentFlags.ParentToHand; // Metadata: 0x00655851
		public Hand otherHand; // 0x18
		public HandType startingHandType; // 0x20
		public Transform hoverSphereTransform; // 0x28
		public float hoverSphereRadius; // 0x30
		public LayerMask hoverLayerMask; // 0x34
		public float hoverUpdateInterval; // 0x38
		public Camera noSteamVRFallbackCamera; // 0x40
		public float noSteamVRFallbackMaxDistanceNoItem; // 0x48
		public float noSteamVRFallbackMaxDistanceWithItem; // 0x4C
		private float noSteamVRFallbackInteractorDistance; // 0x50
		public SteamVR_Controller.Device controller; // 0x58
		public GameObject controllerPrefab; // 0x60
		private GameObject controllerObject; // 0x68
		public bool showDebugText; // 0x70
		public bool spewDebugText; // 0x71
		private List<AttachedObject> attachedObjects; // 0x78
		private Interactable _hoveringInteractable; // 0x88
		private TextMesh debugText; // 0x90
		private int prevOverlappingColliders; // 0x98
		private const int ColliderArraySize = 16; // Metadata: 0x00655855
		private Collider[] overlappingColliders; // 0xA0
		private Player playerInstance; // 0xA8
		private GameObject applicationLostFocusObject; // 0xB0
		private SteamVR_Events.Action inputFocusAction; // 0xB8
	
		// Properties
		public ReadOnlyCollection<AttachedObject> AttachedObjects { get => default; } // 0x0000000180FC46C0-0x0000000180FC4710 
		public bool hoverLocked { get; private set; } // 0x000000018026C820-0x000000018026C830 0x000000018065F170-0x000000018065F180
		public Interactable hoveringInteractable { get => default; set {} } // 0x000000018024B310-0x000000018024B320 0x0000000180FC47A0-0x0000000180FC4A10
		public GameObject currentAttachedObject { get => default; } // 0x0000000180FC4710-0x0000000180FC47A0 
	
		// Nested types
		public enum HandType // TypeDefIndex: 8360
		{
			Left = 0,
			Right = 1,
			Any = 2
		}
	
		[Flags] // 0x00000001800D4E50-0x00000001800D4E60
		public enum AttachmentFlags // TypeDefIndex: 8361
		{
			SnapOnAttach = 1,
			DetachOthers = 2,
			DetachFromOtherHand = 4,
			ParentToHand = 8
		}
	
		public struct AttachedObject // TypeDefIndex: 8362
		{
			// Fields
			public GameObject attachedObject; // 0x00
			public GameObject originalParent; // 0x08
			public bool isParentedToHand; // 0x10
		}
	
		// Constructors
		public Hand() {} // 0x0000000180FC4620-0x0000000180FC46C0
	
		// Methods
		public Transform GetAttachmentTransform(string attachmentPoint = "" /* Metadata: 0x00655844 */) => default; // 0x0000000180FC1FC0-0x0000000180FC2080
		public HandType GuessCurrentHandType() => default; // 0x0000000180FC2450-0x0000000180FC2580
		public void AttachObject(GameObject objectToAttach, AttachmentFlags flags = AttachmentFlags.SnapOnAttach | AttachmentFlags.DetachOthers | AttachmentFlags.DetachFromOtherHand | AttachmentFlags.ParentToHand /* Metadata: 0x00655848 */, string attachmentPoint = "" /* Metadata: 0x0065584C */) {} // 0x0000000180FC13D0-0x0000000180FC1990
		public void DetachObject(GameObject objectToDetach, bool restoreOriginalParent = true /* Metadata: 0x00655850 */) {} // 0x0000000180FC1C10-0x0000000180FC1FB0
		public Vector3 GetTrackedObjectVelocity() => default; // 0x0000000180FC2340-0x0000000180FC2450
		public Vector3 GetTrackedObjectAngularVelocity() => default; // 0x0000000180FC2230-0x0000000180FC2340
		private void CleanUpAttachedObjectStack() {} // 0x0000000180FC1B10-0x0000000180FC1C10
		private void Awake() {} // 0x0000000180FC1990-0x0000000180FC1B10
		// [IteratorStateMachine] // 0x0000000180138880-0x00000001801388D0
		private IEnumerator Start() => default; // 0x0000000180FC2F80-0x0000000180FC2FF0
		private void UpdateHovering() {} // 0x0000000180FC3840-0x0000000180FC4040
		private void UpdateNoSteamVRFallback() {} // 0x0000000180FC4040-0x0000000180FC4510
		private void UpdateDebugText() {} // 0x0000000180FC2FF0-0x0000000180FC36B0
		private void OnEnable() {} // 0x0000000180FC2D80-0x0000000180FC2E80
		private void OnDisable() {} // 0x0000000180FC2C30-0x0000000180FC2C70
		private void Update() {} // 0x0000000180FC4510-0x0000000180FC4620
		private void LateUpdate() {} // 0x0000000180FC2B90-0x0000000180FC2C30
		private void OnInputFocus(bool hasFocus) {} // 0x0000000180FC2E80-0x0000000180FC2F80
		private void FixedUpdate() {} // 0x0000000180FC1FB0-0x0000000180FC1FC0
		private void OnDrawGizmos() {} // 0x0000000180FC2C70-0x0000000180FC2D80
		private void HandDebugLog(string msg) {} // 0x0000000180FC2580-0x0000000180FC2620
		private void UpdateHandPoses() {} // 0x0000000180FC36B0-0x0000000180FC3840
		public void HoverLock(Interactable interactable) {} // 0x0000000180FC2620-0x0000000180FC2690
		public void HoverUnlock(Interactable interactable) {} // 0x0000000180FC2690-0x0000000180FC2730
		public bool GetStandardInteractionButtonDown() => default; // 0x0000000180FC2080-0x0000000180FC2110
		public bool GetStandardInteractionButtonUp() => default; // 0x0000000180FC2110-0x0000000180FC21A0
		public bool GetStandardInteractionButton() => default; // 0x0000000180FC21A0-0x0000000180FC2230
		private void InitController(int index) {} // 0x0000000180FC2730-0x0000000180FC2B90
	}
}
