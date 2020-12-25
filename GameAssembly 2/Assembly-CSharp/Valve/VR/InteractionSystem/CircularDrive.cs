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
	// [RequireComponent] // 0x0000000180134430-0x0000000180134480
	public class CircularDrive : MonoBehaviour // TypeDefIndex: 8341
	{
		// Fields
		// [Tooltip] // 0x00000001801345A0-0x00000001801345D0
		public Axis_t axisOfRotation; // 0x18
		// [Tooltip] // 0x0000000180134680-0x00000001801346B0
		public Collider childCollider; // 0x20
		// [Tooltip] // 0x0000000180134920-0x0000000180134950
		public LinearMapping linearMapping; // 0x28
		// [Tooltip] // 0x0000000180134950-0x0000000180134980
		public bool hoverLock; // 0x30
		// [Header] // 0x00000001801349B0-0x0000000180134A10
		// [Tooltip] // 0x00000001801349B0-0x0000000180134A10
		public bool limited; // 0x31
		public Vector2 frozenDistanceMinMaxThreshold; // 0x34
		public UnityEvent onFrozenDistanceThreshold; // 0x40
		// [Header] // 0x0000000180134C10-0x0000000180134C70
		// [Tooltip] // 0x0000000180134C10-0x0000000180134C70
		public float minAngle; // 0x48
		// [Tooltip] // 0x0000000180134D70-0x0000000180134DA0
		public bool freezeOnMin; // 0x4C
		// [Tooltip] // 0x0000000180134F40-0x0000000180134F70
		public UnityEvent onMinAngle; // 0x50
		// [Header] // 0x0000000180135030-0x0000000180135090
		// [Tooltip] // 0x0000000180135030-0x0000000180135090
		public float maxAngle; // 0x58
		// [Tooltip] // 0x00000001801352A0-0x00000001801352D0
		public bool freezeOnMax; // 0x5C
		// [Tooltip] // 0x0000000180135370-0x00000001801353A0
		public UnityEvent onMaxAngle; // 0x60
		// [Tooltip] // 0x00000001801354D0-0x0000000180135500
		public bool forceStart; // 0x68
		// [Tooltip] // 0x0000000180135650-0x0000000180135680
		public float startAngle; // 0x6C
		// [Tooltip] // 0x0000000180135830-0x0000000180135860
		public bool rotateGameObject; // 0x70
		// [Tooltip] // 0x00000001801358F0-0x0000000180135920
		public bool debugPath; // 0x71
		// [Tooltip] // 0x0000000180135A60-0x0000000180135A90
		public int dbgPathLimit; // 0x74
		// [Tooltip] // 0x0000000180135AC0-0x0000000180135AF0
		public TextMesh debugText; // 0x78
		// [Tooltip] // 0x0000000180135BD0-0x0000000180135C00
		public float outAngle; // 0x80
		private Quaternion start; // 0x84
		private Vector3 worldPlaneNormal; // 0x94
		private Vector3 localPlaneNormal; // 0xA0
		private Vector3 lastHandProjected; // 0xAC
		private Color red; // 0xB8
		private Color green; // 0xC8
		private GameObject[] dbgHandObjects; // 0xD8
		private GameObject[] dbgProjObjects; // 0xE0
		private GameObject dbgObjectsParent; // 0xE8
		private int dbgObjectCount; // 0xF0
		private int dbgObjectIndex; // 0xF4
		private bool driving; // 0xF8
		private float minMaxAngularThreshold; // 0xFC
		private bool frozen; // 0x100
		private float frozenAngle; // 0x104
		private Vector3 frozenHandWorldPos; // 0x108
		private Vector2 frozenSqDistanceMinMaxThreshold; // 0x114
		private Hand handHoverLocked; // 0x120
	
		// Nested types
		public enum Axis_t // TypeDefIndex: 8342
		{
			XAxis = 0,
			YAxis = 1,
			ZAxis = 2
		}
	
		// Constructors
		public CircularDrive() {} // 0x0000000180FB98D0-0x0000000180FB9AA0
	
		// Methods
		private void Freeze(Hand hand) {} // 0x0000000180FB8950-0x0000000180FB89D0
		private void UnFreeze() {} // 0x0000000180FB93E0-0x0000000180FB9410
		private void Start() {} // 0x0000000180FB8ED0-0x0000000180FB93E0
		private void OnDisable() {} // 0x0000000180FB8C70-0x0000000180FB8D70
		// [IteratorStateMachine] // 0x0000000180135CE0-0x0000000180135D30
		private IEnumerator HapticPulses(SteamVR_Controller.Device controller, float flMagnitude, int nCount) => default; // 0x0000000180FB8BE0-0x0000000180FB8C70
		private void OnHandHoverBegin(Hand hand) {} // 0x0000000180FB8D70-0x0000000180FB8DE0
		private void OnHandHoverEnd(Hand hand) {} // 0x0000000180FB8DE0-0x0000000180FB8ED0
		private void HandHoverUpdate(Hand hand) {} // 0x0000000180FB89D0-0x0000000180FB8BE0
		private Vector3 ComputeToTransformProjected(Transform xForm) => default; // 0x0000000180FB7DB0-0x0000000180FB80E0
		private void DrawDebugPath(Transform xForm, Vector3 toTransformProjected) {} // 0x0000000180FB80E0-0x0000000180FB8950
		private void UpdateLinearMapping() {} // 0x0000000180FB9800-0x0000000180FB98D0
		private void UpdateGameObject() {} // 0x0000000180FB96E0-0x0000000180FB9800
		private void UpdateDebugText() {} // 0x0000000180FB95F0-0x0000000180FB96E0
		private void UpdateAll() {} // 0x0000000180FB9410-0x0000000180FB95F0
		private void ComputeAngle(Hand hand) {} // 0x0000000180FB7890-0x0000000180FB7DB0
	}
}
