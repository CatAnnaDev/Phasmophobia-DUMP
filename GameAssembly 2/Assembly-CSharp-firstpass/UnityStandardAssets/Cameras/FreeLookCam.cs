/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.Cameras
{
	public class FreeLookCam : PivotBasedCameraRig // TypeDefIndex: 6073
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_MoveSpeed; // 0x50
		// [Range] // 0x0000000180116010-0x0000000180116050
		[SerializeField] // 0x0000000180116010-0x0000000180116050
		private float m_TurnSpeed; // 0x54
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_TurnSmoothing; // 0x58
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_TiltMax; // 0x5C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_TiltMin; // 0x60
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool m_LockCursor; // 0x64
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool m_VerticalAutoReturn; // 0x65
		private float m_LookAngle; // 0x68
		private float m_TiltAngle; // 0x6C
		private const float k_LookDistance = 100f; // Metadata: 0x00650B25
		private Vector3 m_PivotEulers; // 0x70
		private Quaternion m_PivotTargetRot; // 0x7C
		private Quaternion m_TransformTargetRot; // 0x8C
	
		// Constructors
		public FreeLookCam() {} // 0x0000000180831BF0-0x0000000180831C20
	
		// Methods
		protected override void Awake() {} // 0x0000000180831490-0x00000001808315E0
		protected void Update() {} // 0x0000000180831BA0-0x0000000180831BF0
		private void OnDisable() {} // 0x0000000180831B80-0x0000000180831BA0
		protected override void FollowTarget(float deltaTime) {} // 0x00000001808315E0-0x00000001808317A0
		private void HandleRotationMovement() {} // 0x00000001808317A0-0x0000000180831B80
	}
}
