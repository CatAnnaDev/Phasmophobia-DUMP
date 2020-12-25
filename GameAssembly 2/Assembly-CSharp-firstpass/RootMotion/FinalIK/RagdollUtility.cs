/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	// [RequireComponent] // 0x00000001800F6200-0x00000001800F6250
	public class RagdollUtility : MonoBehaviour // TypeDefIndex: 6778
	{
		// Fields
		// [Tooltip] // 0x00000001800F62E0-0x00000001800F6310
		public IK ik; // 0x18
		// [Tooltip] // 0x00000001800F63A0-0x00000001800F63D0
		public float ragdollToAnimationTime; // 0x20
		// [Tooltip] // 0x00000001800F64F0-0x00000001800F6520
		public bool applyIkOnRagdoll; // 0x24
		// [Tooltip] // 0x00000001800F6730-0x00000001800F6760
		public float applyVelocity; // 0x28
		// [Tooltip] // 0x00000001800F67E0-0x00000001800F6810
		public float applyAngularVelocity; // 0x2C
		private Animator animator; // 0x30
		private Rigidbone[] rigidbones; // 0x38
		private Child[] children; // 0x40
		private bool enableRagdollFlag; // 0x48
		private AnimatorUpdateMode animatorUpdateMode; // 0x4C
		private IK[] allIKComponents; // 0x50
		private bool[] fixTransforms; // 0x58
		private float ragdollWeight; // 0x60
		private float ragdollWeightV; // 0x64
		private bool fixedFrame; // 0x68
		private bool[] disabledIKComponents; // 0x70
	
		// Properties
		private bool isRagdoll { get => default; } // 0x00000001807E9870-0x00000001807E98E0 
		private bool ikUsed { get => default; } // 0x00000001807E9730-0x00000001807E9870 
	
		// Nested types
		public class Rigidbone // TypeDefIndex: 6779
		{
			// Fields
			public Rigidbody r; // 0x10
			public Transform t; // 0x18
			public Collider collider; // 0x20
			public Joint joint; // 0x28
			public Rigidbody c; // 0x30
			public bool updateAnchor; // 0x38
			public Vector3 deltaPosition; // 0x3C
			public Quaternion deltaRotation; // 0x48
			public float deltaTime; // 0x58
			public Vector3 lastPosition; // 0x5C
			public Quaternion lastRotation; // 0x68
	
			// Constructors
			public Rigidbone() {} // Dummy constructor
			public Rigidbone(Rigidbody r) {} // 0x00000001807EC2A0-0x00000001807EC450
	
			// Methods
			public void RecordVelocity() {} // 0x00000001807EBE20-0x00000001807EBFA0
			public void WakeUp(float velocityWeight, float angularVelocityWeight) {} // 0x00000001807EBFA0-0x00000001807EC2A0
		}
	
		public class Child // TypeDefIndex: 6780
		{
			// Fields
			public Transform t; // 0x10
			public Vector3 localPosition; // 0x18
			public Quaternion localRotation; // 0x24
	
			// Constructors
			public Child() {} // Dummy constructor
			public Child(Transform transform) {} // 0x00000001807DB240-0x00000001807DB2D0
	
			// Methods
			public void FixTransform(float weight) {} // 0x00000001807DAFC0-0x00000001807DB1E0
			public void StoreLocalState() {} // 0x00000001807DB1E0-0x00000001807DB240
		}
	
		// Constructors
		public RagdollUtility() {} // 0x00000001807E9650-0x00000001807E9730
	
		// Methods
		public void EnableRagdoll() {} // 0x00000001807E8030-0x00000001807E80B0
		public void DisableRagdoll() {} // 0x00000001807E7F30-0x00000001807E8030
		public void Start() {} // 0x00000001807E8D20-0x00000001807E9210
		// [IteratorStateMachine] // 0x00000001800F6870-0x00000001800F68C0
		private IEnumerator DisableRagdollSmooth() => default; // 0x00000001807E7EC0-0x00000001807E7F30
		private void Update() {} // 0x00000001807E92C0-0x00000001807E9650
		private void FixedUpdate() {} // 0x00000001807E8330-0x00000001807E83C0
		private void LateUpdate() {} // 0x00000001807E83C0-0x00000001807E84A0
		private void AfterLastIK() {} // 0x00000001807E7E90-0x00000001807E7EC0
		private void AfterAnimation() {} // 0x00000001807E7E00-0x00000001807E7E90
		private void OnFinalPose() {} // 0x00000001807E85C0-0x00000001807E8830
		private void RagdollEnabler() {} // 0x00000001807E8830-0x00000001807E8B30
		private void RecordVelocities() {} // 0x00000001807E8B30-0x00000001807E8D20
		private void StoreLocalState() {} // 0x00000001807E9210-0x00000001807E92C0
		private void FixTransforms(float weight) {} // 0x00000001807E80B0-0x00000001807E8330
		private void OnDestroy() {} // 0x00000001807E84A0-0x00000001807E85C0
	}
}
