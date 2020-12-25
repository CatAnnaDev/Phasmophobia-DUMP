/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Characters.FirstPerson
{
	// [RequireComponent] // 0x0000000180115AC0-0x0000000180115B40
	// [RequireComponent] // 0x0000000180115AC0-0x0000000180115B40
	public class RigidbodyFirstPersonController : MonoBehaviour // TypeDefIndex: 6067
	{
		// Fields
		public Camera cam; // 0x18
		public MovementSettings movementSettings; // 0x20
		public MouseLook mouseLook; // 0x28
		public AdvancedSettings advancedSettings; // 0x30
		private Rigidbody m_RigidBody; // 0x38
		private CapsuleCollider m_Capsule; // 0x40
		private float m_YRotation; // 0x48
		private Vector3 m_GroundContactNormal; // 0x4C
		private bool m_Jump; // 0x58
		private bool m_PreviouslyGrounded; // 0x59
		private bool m_Jumping; // 0x5A
		private bool m_IsGrounded; // 0x5B
	
		// Properties
		public Vector3 Velocity { get => default; } // 0x0000000180836C40-0x0000000180836C80 
		public bool Grounded { get => default; } // 0x0000000180836C00-0x0000000180836C10 
		public bool Jumping { get => default; } // 0x0000000180836C10-0x0000000180836C20 
		public bool Running { get => default; } // 0x0000000180836C20-0x0000000180836C40 
	
		// Nested types
		[Serializable]
		public class MovementSettings // TypeDefIndex: 6068
		{
			// Fields
			public float ForwardSpeed; // 0x10
			public float BackwardSpeed; // 0x14
			public float StrafeSpeed; // 0x18
			public float RunMultiplier; // 0x1C
			public KeyCode RunKey; // 0x20
			public float JumpForce; // 0x24
			public AnimationCurve SlopeCurveModifier; // 0x28
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public float CurrentTargetSpeed; // 0x30
			private bool m_Running; // 0x34
	
			// Properties
			public bool Running { get => default; } // 0x000000018053C3D0-0x000000018053C3E0 
	
			// Constructors
			public MovementSettings() {} // 0x0000000180834150-0x0000000180834350
	
			// Methods
			public void UpdateDesiredTargetSpeed(Vector2 input) {} // 0x0000000180834070-0x0000000180834150
		}
	
		[Serializable]
		public class AdvancedSettings // TypeDefIndex: 6069
		{
			// Fields
			public float groundCheckDistance; // 0x10
			public float stickToGroundHelperDistance; // 0x14
			public float slowDownRate; // 0x18
			public bool airControl; // 0x1C
			// [Tooltip] // 0x0000000180115B70-0x0000000180115BA0
			public float shellOffset; // 0x20
	
			// Constructors
			public AdvancedSettings() {} // 0x0000000180829190-0x00000001808291B0
		}
	
		// Constructors
		public RigidbodyFirstPersonController() {} // 0x0000000180836920-0x0000000180836C00
	
		// Methods
		private void Start() {} // 0x0000000180836480-0x0000000180836560
		private void Update() {} // 0x00000001808368B0-0x0000000180836920
		private void FixedUpdate() {} // 0x00000001808355E0-0x0000000180835DB0
		private float SlopeMultiplier() => default; // 0x00000001808363C0-0x0000000180836480
		private void StickToGroundHelper() {} // 0x0000000180836560-0x00000001808368B0
		private Vector2 GetInput() => default; // 0x0000000180835DB0-0x0000000180835F10
		private void RotateView() {} // 0x0000000180836180-0x00000001808363C0
		private void GroundCheck() {} // 0x0000000180835F10-0x0000000180836180
	}
}
