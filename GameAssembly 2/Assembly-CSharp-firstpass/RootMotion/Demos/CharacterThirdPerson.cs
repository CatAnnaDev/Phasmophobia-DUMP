/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public class CharacterThirdPerson : CharacterBase // TypeDefIndex: 6658
	{
		// Fields
		// [Header] // 0x0000000180134B30-0x0000000180134B60
		public CharacterAnimationBase characterAnimation; // 0x68
		public UserControlThirdPerson userControl; // 0x70
		public CameraController cam; // 0x78
		// [Header] // 0x0000000180134CD0-0x0000000180134D00
		public MoveMode moveMode; // 0x80
		public bool smoothPhysics; // 0x84
		public float smoothAccelerationTime; // 0x88
		public float linearAccelerationSpeed; // 0x8C
		public float platformFriction; // 0x90
		public float groundStickyEffect; // 0x94
		public float maxVerticalVelocityOnGround; // 0x98
		public float velocityToGroundTangentWeight; // 0x9C
		// [Header] // 0x0000000180127E40-0x0000000180127E70
		public bool lookInCameraDirection; // 0xA0
		public float turnSpeed; // 0xA4
		public float stationaryTurnSpeedMlp; // 0xA8
		// [Header] // 0x0000000180134EA0-0x0000000180134ED0
		public float airSpeed; // 0xAC
		public float airControl; // 0xB0
		public float jumpPower; // 0xB4
		public float jumpRepeatDelayTime; // 0xB8
		// [Header] // 0x0000000180134F70-0x0000000180134FC0
		[SerializeField] // 0x0000000180134F70-0x0000000180134FC0
		private LayerMask wallRunLayers; // 0xBC
		public float wallRunMaxLength; // 0xC0
		public float wallRunMinMoveMag; // 0xC4
		public float wallRunMinVelocityY; // 0xC8
		public float wallRunRotationSpeed; // 0xCC
		public float wallRunMaxRotationAngle; // 0xD0
		public float wallRunWeightSpeed; // 0xD4
		// [Header] // 0x0000000180135190-0x00000001801351C0
		public float crouchCapsuleScaleMlp; // 0xD8
		public AnimState animState; // 0xE0
		protected Vector3 moveDirection; // 0xF4
		private Animator animator; // 0x100
		private Vector3 normal; // 0x108
		private Vector3 platformVelocity; // 0x114
		private Vector3 platformAngularVelocity; // 0x120
		private RaycastHit hit; // 0x12C
		private float jumpLeg; // 0x158
		private float jumpEndTime; // 0x15C
		private float forwardMlp; // 0x160
		private float groundDistance; // 0x164
		private float lastAirTime; // 0x168
		private float stickyForce; // 0x16C
		private Vector3 wallNormal; // 0x170
		private Vector3 moveDirectionVelocity; // 0x17C
		private float wallRunWeight; // 0x188
		private float lastWallRunWeight; // 0x18C
		private Vector3 fixedDeltaPosition; // 0x190
		private Quaternion fixedDeltaRotation; // 0x19C
		private bool fixedFrame; // 0x1AC
		private float wallRunEndTime; // 0x1B0
		private Vector3 gravity; // 0x1B4
		private Vector3 verticalVelocity; // 0x1C0
		private float velocityY; // 0x1CC
	
		// Properties
		public bool onGround { get; private set; } // 0x00000001804C2E30-0x00000001804C2E40 0x00000001804C2E40-0x00000001804C2E50
	
		// Nested types
		[Serializable]
		public enum MoveMode // TypeDefIndex: 6659
		{
			Directional = 0,
			Strafe = 1
		}
	
		public struct AnimState // TypeDefIndex: 6660
		{
			// Fields
			public Vector3 moveDirection; // 0x00
			public bool jump; // 0x0C
			public bool crouch; // 0x0D
			public bool onGround; // 0x0E
			public bool isStrafing; // 0x0F
			public float yVelocity; // 0x10
		}
	
		// Constructors
		public CharacterThirdPerson() {} // 0x00000001804C2CB0-0x00000001804C2E30
	
		// Methods
		protected override void Start() {} // 0x00000001804C20F0-0x00000001804C22A0
		private void OnAnimatorMove() {} // 0x00000001804C1AC0-0x00000001804C1B60
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation) {} // 0x00000001804C1990-0x00000001804C1AC0
		private void FixedUpdate() {} // 0x00000001804BFB50-0x00000001804C0330
		protected virtual void Update() {} // 0x00000001804C22A0-0x00000001804C23A0
		protected virtual void LateUpdate() {} // 0x00000001804C1090-0x00000001804C1170
		private void MoveFixed(Vector3 deltaPosition) {} // 0x00000001804C1170-0x00000001804C1990
		private void WallRun() {} // 0x00000001804C23A0-0x00000001804C2CB0
		private bool CanWallRun() => default; // 0x00000001804BFAB0-0x00000001804BFB50
		private Vector3 GetMoveDirection() => default; // 0x00000001804C0550-0x00000001804C0910
		protected virtual void Rotate() {} // 0x00000001804C1B60-0x00000001804C20F0
		private Vector3 GetForwardDirection() => default; // 0x00000001804C0330-0x00000001804C0550
		protected virtual bool Jump() => default; // 0x00000001804C0E40-0x00000001804C1090
		private void GroundCheck() {} // 0x00000001804C0910-0x00000001804C0E40
	}
}
