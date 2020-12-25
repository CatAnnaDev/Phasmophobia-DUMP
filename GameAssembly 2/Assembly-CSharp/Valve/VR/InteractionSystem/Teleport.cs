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
	public class Teleport : MonoBehaviour // TypeDefIndex: 8437
	{
		// Fields
		public LayerMask traceLayerMask; // 0x18
		public LayerMask floorFixupTraceLayerMask; // 0x1C
		public float floorFixupMaximumTraceDistance; // 0x20
		public Material areaVisibleMaterial; // 0x28
		public Material areaLockedMaterial; // 0x30
		public Material areaHighlightedMaterial; // 0x38
		public Material pointVisibleMaterial; // 0x40
		public Material pointLockedMaterial; // 0x48
		public Material pointHighlightedMaterial; // 0x50
		public Transform destinationReticleTransform; // 0x58
		public Transform invalidReticleTransform; // 0x60
		public GameObject playAreaPreviewCorner; // 0x68
		public GameObject playAreaPreviewSide; // 0x70
		public Color pointerValidColor; // 0x78
		public Color pointerInvalidColor; // 0x88
		public Color pointerLockedColor; // 0x98
		public bool showPlayAreaMarker; // 0xA8
		public float teleportFadeTime; // 0xAC
		public float meshFadeTime; // 0xB0
		public float arcDistance; // 0xB4
		// [Header] // 0x00000001800D72B0-0x00000001800D72E0
		public Transform onActivateObjectTransform; // 0xB8
		public Transform onDeactivateObjectTransform; // 0xC0
		public float activateObjectTime; // 0xC8
		public float deactivateObjectTime; // 0xCC
		// [Header] // 0x00000001800D7400-0x00000001800D7430
		public AudioSource pointerAudioSource; // 0xD0
		public AudioSource loopingAudioSource; // 0xD8
		public AudioSource headAudioSource; // 0xE0
		public AudioSource reticleAudioSource; // 0xE8
		// [Header] // 0x00000001800D7510-0x00000001800D7540
		public AudioClip teleportSound; // 0xF0
		public AudioClip pointerStartSound; // 0xF8
		public AudioClip pointerLoopSound; // 0x100
		public AudioClip pointerStopSound; // 0x108
		public AudioClip goodHighlightSound; // 0x110
		public AudioClip badHighlightSound; // 0x118
		// [Header] // 0x00000001800D7660-0x00000001800D7690
		public bool debugFloor; // 0x120
		public bool showOffsetReticle; // 0x121
		public Transform offsetReticleTransform; // 0x128
		public MeshRenderer floorDebugSphere; // 0x130
		public LineRenderer floorDebugLine; // 0x138
		private LineRenderer pointerLineRenderer; // 0x140
		private GameObject teleportPointerObject; // 0x148
		private Transform pointerStartTransform; // 0x150
		private Hand pointerHand; // 0x158
		private Player player; // 0x160
		private TeleportArc teleportArc; // 0x168
		private bool visible; // 0x170
		private TeleportMarkerBase[] teleportMarkers; // 0x178
		private TeleportMarkerBase pointedAtTeleportMarker; // 0x180
		private TeleportMarkerBase teleportingToMarker; // 0x188
		private Vector3 pointedAtPosition; // 0x190
		private Vector3 prevPointedAtPosition; // 0x19C
		private bool teleporting; // 0x1A8
		private float currentFadeTime; // 0x1AC
		private float meshAlphaPercent; // 0x1B0
		private float pointerShowStartTime; // 0x1B4
		private float pointerHideStartTime; // 0x1B8
		private bool meshFading; // 0x1BC
		private float fullTintAlpha; // 0x1C0
		private float invalidReticleMinScale; // 0x1C4
		private float invalidReticleMaxScale; // 0x1C8
		private float invalidReticleMinScaleDistance; // 0x1CC
		private float invalidReticleMaxScaleDistance; // 0x1D0
		private Vector3 invalidReticleScale; // 0x1D4
		private Quaternion invalidReticleTargetRotation; // 0x1E0
		private Transform playAreaPreviewTransform; // 0x1F0
		private Transform[] playAreaPreviewCorners; // 0x1F8
		private Transform[] playAreaPreviewSides; // 0x200
		private float loopingAudioMaxVolume; // 0x208
		private Coroutine hintCoroutine; // 0x210
		private bool originalHoverLockState; // 0x218
		private Interactable originalHoveringInteractable; // 0x220
		private AllowTeleportWhileAttachedToHand allowTeleportWhileAttached; // 0x228
		private Vector3 startingFeetOffset; // 0x230
		private bool movedFeetFarEnough; // 0x23C
		private SteamVR_Events.Action chaperoneInfoInitializedAction; // 0x240
		public static SteamVR_Events.Event<float> ChangeScene; // 0x00
		public static SteamVR_Events.Event<TeleportMarkerBase> Player; // 0x08
		public static SteamVR_Events.Event<TeleportMarkerBase> PlayerPre; // 0x10
		private static Teleport _instance; // 0x18
	
		// Properties
		public static Teleport instance { get => default; } // 0x0000000180EF24C0-0x0000000180EF25F0 
	
		// Constructors
		public Teleport() {} // 0x0000000180EF2380-0x0000000180EF24C0
		static Teleport() {} // 0x0000000180EF22A0-0x0000000180EF2380
	
		// Methods
		public static SteamVR_Events.Action<float> ChangeSceneAction(UnityAction<float> action) => default; // 0x0000000180EECDA0-0x0000000180EECE40
		public static SteamVR_Events.Action<TeleportMarkerBase> PlayerAction(UnityAction<TeleportMarkerBase> action) => default; // 0x0000000180EEF7D0-0x0000000180EEF870
		public static SteamVR_Events.Action<TeleportMarkerBase> PlayerPreAction(UnityAction<TeleportMarkerBase> action) => default; // 0x0000000180EEF870-0x0000000180EEF910
		private void Awake() {} // 0x0000000180EECA90-0x0000000180EECCB0
		private void Start() {} // 0x0000000180EF0210-0x0000000180EF0480
		private void OnEnable() {} // 0x0000000180EEF700-0x0000000180EEF740
		private void OnDisable() {} // 0x0000000180EEF6C0-0x0000000180EEF700
		private void CheckForSpawnPoint() {} // 0x0000000180EECE40-0x0000000180EECF80
		public void HideTeleportPointer() {} // 0x0000000180EEDA40-0x0000000180EEDAC0
		private void Update() {} // 0x0000000180EF1C40-0x0000000180EF2120
		private void UpdatePointer() {} // 0x0000000180EF0BC0-0x0000000180EF1B10
		private void FixedUpdate() {} // 0x0000000180EECF80-0x0000000180EED550
		private void OnChaperoneInfoInitialized() {} // 0x0000000180EEE330-0x0000000180EEF6C0
		private void HidePointer() {} // 0x0000000180EED610-0x0000000180EEDA40
		private void ShowPointer(Hand newPointerHand, Hand oldPointerHand) {} // 0x0000000180EEF9A0-0x0000000180EF0180
		private void UpdateTeleportColors() {} // 0x0000000180EF1B10-0x0000000180EF1C40
		private void PlayAudioClip(AudioSource source, AudioClip clip) {} // 0x0000000180EEF740-0x0000000180EEF780
		private void PlayPointerHaptic(bool validLocation) {} // 0x0000000180EEF780-0x0000000180EEF7D0
		private void TryTeleportPlayer() {} // 0x0000000180EF0B00-0x0000000180EF0BC0
		private void InitiateTeleportFade() {} // 0x0000000180EEDE00-0x0000000180EEE0B0
		private void TeleportPlayer() {} // 0x0000000180EF04F0-0x0000000180EF0B00
		private void HighlightSelected(TeleportMarkerBase hitTeleportMarker) {} // 0x0000000180EEDAC0-0x0000000180EEDE00
		public void ShowTeleportHint() {} // 0x0000000180EF0180-0x0000000180EF0210
		public void CancelTeleportHint() {} // 0x0000000180EECCB0-0x0000000180EECDA0
		// [IteratorStateMachine] // 0x00000001800D7720-0x00000001800D7770
		private IEnumerator TeleportHintCoroutine() => default; // 0x0000000180EF0480-0x0000000180EF04F0
		public bool IsEligibleForTeleport(Hand hand) => default; // 0x0000000180EEE0B0-0x0000000180EEE270
		private bool ShouldOverrideHoverLock() => default; // 0x0000000180EEF910-0x0000000180EEF9A0
		private bool WasTeleportButtonReleased(Hand hand) => default; // 0x0000000180EF21E0-0x0000000180EF22A0
		private bool IsTeleportButtonDown(Hand hand) => default; // 0x0000000180EEE270-0x0000000180EEE330
		private bool WasTeleportButtonPressed(Hand hand) => default; // 0x0000000180EF2120-0x0000000180EF21E0
		private Transform GetPointerStartTransform(Hand hand) => default; // 0x0000000180EED550-0x0000000180EED610
	}
}
