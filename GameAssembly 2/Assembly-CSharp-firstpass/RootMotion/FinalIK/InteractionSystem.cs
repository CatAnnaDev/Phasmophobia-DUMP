/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	// [AddComponentMenu] // 0x00000001800F1770-0x00000001800F17D0
	// [HelpURL] // 0x00000001800F1770-0x00000001800F17D0
	public class InteractionSystem : MonoBehaviour // TypeDefIndex: 6764
	{
		// Fields
		// [Tooltip] // 0x00000001800F1870-0x00000001800F18A0
		public string targetTag; // 0x18
		// [Tooltip] // 0x00000001800F1960-0x00000001800F1990
		public float fadeInTime; // 0x20
		// [Tooltip] // 0x00000001800F1AC0-0x00000001800F1AF0
		public float speed; // 0x24
		// [Tooltip] // 0x00000001800F1BE0-0x00000001800F1C10
		public float resetToDefaultsSpeed; // 0x28
		// [FormerlySerializedAs] // 0x00000001800F1C50-0x00000001800F1CD0
		// [Header] // 0x00000001800F1C50-0x00000001800F1CD0
		// [Tooltip] // 0x00000001800F1C50-0x00000001800F1CD0
		public Collider characterCollider; // 0x30
		// [FormerlySerializedAs] // 0x00000001800F1E70-0x00000001800F1ED0
		// [Tooltip] // 0x00000001800F1E70-0x00000001800F1ED0
		public Transform FPSCamera; // 0x38
		// [Tooltip] // 0x00000001800F2090-0x00000001800F20C0
		public LayerMask camRaycastLayers; // 0x40
		// [Tooltip] // 0x00000001800F2190-0x00000001800F21C0
		public float camRaycastDistance; // 0x44
		private List<InteractionTrigger> inContact; // 0x50
		private List<int> bestRangeIndexes; // 0x58
		public InteractionDelegate OnInteractionStart; // 0x60
		public InteractionDelegate OnInteractionPause; // 0x68
		public InteractionDelegate OnInteractionPickUp; // 0x70
		public InteractionDelegate OnInteractionResume; // 0x78
		public InteractionDelegate OnInteractionStop; // 0x80
		public InteractionEventDelegate OnInteractionEvent; // 0x88
		public RaycastHit raycastHit; // 0x90
		[SerializeField] // 0x00000001800F22A0-0x00000001800F2300
		[Space] // 0x00000001800F22A0-0x00000001800F2300
		// [Tooltip] // 0x00000001800F22A0-0x00000001800F2300
		private FullBodyBipedIK fullBody; // 0xC0
		// [Tooltip] // 0x00000001800F23E0-0x00000001800F2410
		public InteractionLookAt lookAt; // 0xC8
		private InteractionEffector[] interactionEffectors; // 0xD0
		private bool initiated; // 0xD8
		private Collider lastCollider; // 0xE0
		private Collider c; // 0xE8
	
		// Properties
		public bool inInteraction { get => default; } // 0x00000001807E5A40-0x00000001807E5C00 
		public FullBodyBipedIK ik { get => default; set {} } // 0x00000001806F9940-0x00000001806F9950 0x00000001806F7580-0x00000001806F7590
		public List<InteractionTrigger> triggersInRange { get; private set; } // 0x00000001803F7AF0-0x00000001803F7B00 0x0000000180249C10-0x0000000180249C20
	
		// Nested types
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // TypeDefIndex: 6765; 0x0000000180275080-0x00000001802753A0
	
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent); // TypeDefIndex: 6766; 0x00000001807DDDE0-0x00000001807DE140
	
		// Constructors
		public InteractionSystem() {} // 0x00000001807E54F0-0x00000001807E5A40
	
		// Methods
		// [ContextMenu] // 0x00000001800EEB70-0x00000001800EEBA0
		private void OpenTutorial1() {} // 0x00000001807E2DC0-0x00000001807E2E00
		// [ContextMenu] // 0x00000001800EEC60-0x00000001800EEC90
		private void OpenTutorial2() {} // 0x00000001807E2E00-0x00000001807E2E40
		// [ContextMenu] // 0x00000001800EED80-0x00000001800EEDB0
		private void OpenTutorial3() {} // 0x00000001807E2E40-0x00000001807E2E80
		// [ContextMenu] // 0x00000001800EEEC0-0x00000001800EEEF0
		private void OpenTutorial4() {} // 0x00000001807E2E80-0x00000001807E2EC0
		// [ContextMenu] // 0x00000001800D51F0-0x00000001800D5220
		private void SupportGroup() {} // 0x00000001807E3E60-0x00000001807E3EA0
		// [ContextMenu] // 0x00000001800D5260-0x00000001800D5290
		private void ASThread() {} // 0x00000001807E05C0-0x00000001807E0600
		public bool IsInInteraction(FullBodyBipedEffector effectorType) => default; // 0x00000001807E16B0-0x00000001807E1830
		public bool IsPaused(FullBodyBipedEffector effectorType) => default; // 0x00000001807E1A00-0x00000001807E1B80
		public bool IsPaused() => default; // 0x00000001807E1B80-0x00000001807E1D40
		public bool IsInSync() => default; // 0x00000001807E1830-0x00000001807E1A00
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt) => default; // 0x00000001807E34F0-0x00000001807E36B0
		public bool PauseInteraction(FullBodyBipedEffector effectorType) => default; // 0x00000001807E3010-0x00000001807E3150
		public bool ResumeInteraction(FullBodyBipedEffector effectorType) => default; // 0x00000001807E33B0-0x00000001807E34F0
		public bool StopInteraction(FullBodyBipedEffector effectorType) => default; // 0x00000001807E3D20-0x00000001807E3E60
		public void PauseAll() {} // 0x00000001807E2F00-0x00000001807E3010
		public void ResumeAll() {} // 0x00000001807E32A0-0x00000001807E33B0
		public void StopAll() {} // 0x00000001807E3CA0-0x00000001807E3D20
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType) => default; // 0x00000001807E1050-0x00000001807E1180
		public float GetProgress(FullBodyBipedEffector effectorType) => default; // 0x00000001807E1380-0x00000001807E14C0
		public float GetMinActiveProgress() => default; // 0x00000001807E1180-0x00000001807E1380
		public bool TriggerInteraction(int index, bool interrupt) => default; // 0x00000001807E43D0-0x00000001807E4660
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject) {
			interactionObject = default;
			return default;
		} // 0x00000001807E4660-0x00000001807E4950
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget) {
			interactionTarget = default;
			return default;
		} // 0x00000001807E4950-0x00000001807E4D10
		public InteractionTrigger.Range GetClosestInteractionRange() => default; // 0x00000001807E09D0-0x00000001807E0B40
		public InteractionObject GetClosestInteractionObjectInRange() => default; // 0x00000001807E0820-0x00000001807E0870
		public InteractionTarget GetClosestInteractionTargetInRange() => default; // 0x00000001807E0B40-0x00000001807E0BE0
		public InteractionObject[] GetClosestInteractionObjectsInRange() => default; // 0x00000001807E0870-0x00000001807E09D0
		public InteractionTarget[] GetClosestInteractionTargetsInRange() => default; // 0x00000001807E0BE0-0x00000001807E0D70
		public bool TriggerEffectorsReady(int index) => default; // 0x00000001807E3EA0-0x00000001807E42D0
		public InteractionTrigger.Range GetTriggerRange(int index) => default; // 0x00000001807E14C0-0x00000001807E1670
		public int GetClosestTriggerIndex() => default; // 0x00000001807E0D70-0x00000001807E1050
		protected virtual void Start() {} // 0x00000001807E36B0-0x00000001807E3CA0
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x00000001807E1670-0x00000001807E1690
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x00000001807E1690-0x00000001807E16B0
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x00000001807E1690-0x00000001807E16B0
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject) {} // 0x00000001807E1E10-0x00000001807E20B0
		public void OnTriggerEnter(Collider c) {} // 0x00000001807E2BA0-0x00000001807E2CA0
		public void OnTriggerExit(Collider c) {} // 0x00000001807E2CA0-0x00000001807E2D80
		private bool ContactIsInRange(int index, out int bestRangeIndex) {
			bestRangeIndex = default;
			return default;
		} // 0x00000001807E0600-0x00000001807E0820
		private void OnDrawGizmosSelected() {} // 0x00000001807E24E0-0x00000001807E25E0
		private void Update() {} // 0x00000001807E5170-0x00000001807E54F0
		private void Raycasting() {} // 0x00000001807E3150-0x00000001807E32A0
		private void UpdateTriggerEventBroadcasting() {} // 0x00000001807E4E80-0x00000001807E5170
		private void UpdateEffectors() {} // 0x00000001807E4D10-0x00000001807E4E80
		private void OnPreFBBIK() {} // 0x00000001807E2870-0x00000001807E2BA0
		private void OnPostFBBIK() {} // 0x00000001807E2690-0x00000001807E2870
		private void OnFixTransforms() {} // 0x00000001807E25E0-0x00000001807E2690
		private void OnDestroy() {} // 0x00000001807E20B0-0x00000001807E24E0
		private bool IsValid(bool log) => default; // 0x00000001807E1D40-0x00000001807E1E10
		private bool TriggerIndexIsValid(int index) => default; // 0x00000001807E42D0-0x00000001807E43D0
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		private void OpenUserManual() {} // 0x00000001807E2EC0-0x00000001807E2F00
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		private void OpenScriptReference() {} // 0x00000001807E2D80-0x00000001807E2DC0
	}
}
