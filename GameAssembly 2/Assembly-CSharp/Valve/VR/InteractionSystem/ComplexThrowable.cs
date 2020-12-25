/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	// [RequireComponent] // 0x0000000180136150-0x00000001801361A0
	public class ComplexThrowable : MonoBehaviour // TypeDefIndex: 8344
	{
		// Fields
		public float attachForce; // 0x18
		public float attachForceDamper; // 0x1C
		public AttachMode attachMode; // 0x20
		[EnumFlags] // 0x0000000180107390-0x00000001801073A0
		public Hand.AttachmentFlags attachmentFlags; // 0x24
		private List<Hand> holdingHands; // 0x28
		private List<Rigidbody> holdingBodies; // 0x30
		private List<Vector3> holdingPoints; // 0x38
		private List<Rigidbody> rigidBodies; // 0x40
	
		// Nested types
		public enum AttachMode // TypeDefIndex: 8345
		{
			FixedJoint = 0,
			Force = 1
		}
	
		// Constructors
		public ComplexThrowable() {} // 0x0000000180FBA7B0-0x0000000180FBA8B0
	
		// Methods
		private void Awake() {} // 0x0000000180FB9AA0-0x0000000180FB9AE0
		private void Update() {} // 0x0000000180FBA660-0x0000000180FBA7B0
		private void OnHandHoverBegin(Hand hand) {} // 0x0000000180FB9ED0-0x0000000180FB9F50
		private void OnHandHoverEnd(Hand hand) {} // 0x0000000180FB9F50-0x0000000180FB9FD0
		private void HandHoverUpdate(Hand hand) {} // 0x0000000180FB9E80-0x0000000180FB9ED0
		private void PhysicsAttach(Hand hand) {} // 0x0000000180FB9FD0-0x0000000180FBA4C0
		private bool PhysicsDetach(Hand hand) => default; // 0x0000000180FBA4C0-0x0000000180FBA660
		private void FixedUpdate() {} // 0x0000000180FB9AE0-0x0000000180FB9E80
	}
}
