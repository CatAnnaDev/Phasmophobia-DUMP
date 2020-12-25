/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityStandardAssets.Utility;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Characters.FirstPerson
{
	// [RequireComponent] // 0x0000000180114010-0x0000000180114090
	// [RequireComponent] // 0x0000000180114010-0x0000000180114090
	public class FirstPersonController : MonoBehaviour // TypeDefIndex: 6064
	{
		// Fields
		public bool stopMovement; // 0x18
		public bool m_IsWalking; // 0x19
		// [Range] // 0x0000000180114160-0x00000001801141A0
		[SerializeField] // 0x0000000180114160-0x00000001801141A0
		private float m_RunstepLenghten; // 0x1C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_JumpSpeed; // 0x20
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_StickToGroundForce; // 0x24
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_GravityMultiplier; // 0x28
		public MouseLook m_MouseLook; // 0x30
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool m_UseFovKick; // 0x38
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private FOVKick m_FovKick; // 0x40
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool m_UseHeadBob; // 0x48
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private CurveControlledBob m_HeadBob; // 0x50
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private LerpControlledBob m_JumpBob; // 0x58
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_StepInterval; // 0x60
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Camera m_Camera; // 0x68
		private bool m_Jump; // 0x70
		private float m_YRotation; // 0x74
		private Vector2 m_Input; // 0x78
		private Vector3 m_MoveDir; // 0x80
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private CharacterController m_CharacterController; // 0x90
		private CollisionFlags m_CollisionFlags; // 0x98
		private bool m_PreviouslyGrounded; // 0x9C
		private Vector3 m_OriginalCameraPosition; // 0xA0
		private float m_StepCycle; // 0xAC
		private float m_NextStep; // 0xB0
		private bool m_Jumping; // 0xB4
		private float horizontalMovement; // 0xB8
		private float verticalMovement; // 0xBC
	
		// Constructors
		public FirstPersonController() {} // 0x0000000180831320-0x0000000180831420
	
		// Methods
		private void Start() {} // 0x0000000180830F60-0x0000000180831080
		private void Update() {} // 0x0000000180830F00-0x0000000180830F60
		private void PlayLandingSound() {} // 0x0000000180830D80-0x0000000180830DA0
		private void FixedUpdate() {} // 0x0000000180830230-0x0000000180830980
		private void ProgressStepCycle(float speed) {} // 0x0000000180830DA0-0x0000000180830F00
		private void UpdateCameraPosition(float speed) {} // 0x0000000180831080-0x0000000180831320
		private void GetInput(out float speed) {
			speed = default;
		} // 0x0000000180830980-0x0000000180830AC0
		private void RotateView() {} // 0x0000000180830F00-0x0000000180830F60
		private void OnControllerColliderHit(ControllerColliderHit hit) {} // 0x0000000180830BA0-0x0000000180830D30
		public void Move(InputAction.CallbackContext context) {} // 0x0000000180830B30-0x0000000180830BA0
		public void OnRun(InputAction.CallbackContext context) {} // 0x0000000180830D30-0x0000000180830D80
		public void Look(InputAction.CallbackContext context) {} // 0x0000000180830AC0-0x0000000180830B30
	}
}
