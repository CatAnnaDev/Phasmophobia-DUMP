/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public class MechSpiderLeg : MonoBehaviour // TypeDefIndex: 6598
	{
		// Fields
		public MechSpider mechSpider; // 0x18
		public MechSpiderLeg unSync; // 0x20
		public Vector3 offset; // 0x28
		public float minDelay; // 0x34
		public float maxOffset; // 0x38
		public float stepSpeed; // 0x3C
		public float footHeight; // 0x40
		public float velocityPrediction; // 0x44
		public float raycastFocus; // 0x48
		public AnimationCurve yOffset; // 0x50
		public ParticleSystem sand; // 0x58
		private IK ik; // 0x60
		private float stepProgress; // 0x68
		private float lastStepTime; // 0x6C
		private Vector3 defaultPosition; // 0x70
		private RaycastHit hit; // 0x7C
	
		// Properties
		public bool isStepping { get => default; } // 0x00000001804C96E0-0x00000001804C96F0 
		public Vector3 position { get => default; set {} } // 0x00000001804C96F0-0x00000001804C9750 0x00000001804C9750-0x00000001804C97A0
	
		// Constructors
		public MechSpiderLeg() {} // 0x00000001804C96A0-0x00000001804C96E0
	
		// Methods
		private void Start() {} // 0x00000001804C8F90-0x00000001804C92A0
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance) {
			stepFound = default;
			return default;
		} // 0x00000001804C8A00-0x00000001804C8F90
		private void Update() {} // 0x00000001804C9340-0x00000001804C96A0
		// [IteratorStateMachine] // 0x000000018012BD10-0x000000018012BD60
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition) => default; // 0x00000001804C92A0-0x00000001804C9340
	}
}
