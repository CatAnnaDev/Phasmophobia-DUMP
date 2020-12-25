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
	[ExecuteInEditMode] // 0x00000001800D4E50-0x00000001800D4E60
	public class AutoCam : PivotBasedCameraRig // TypeDefIndex: 6072
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_MoveSpeed; // 0x50
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_TurnSpeed; // 0x54
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_RollSpeed; // 0x58
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool m_FollowVelocity; // 0x5C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool m_FollowTilt; // 0x5D
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_SpinTurnLimit; // 0x60
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_TargetVelocityLowerLimit; // 0x64
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_SmoothTurnTime; // 0x68
		private float m_LastFlatAngle; // 0x6C
		private float m_CurrentTurnAmount; // 0x70
		private float m_TurnSpeedVelocityChange; // 0x74
		private Vector3 m_RollUp; // 0x78
	
		// Constructors
		public AutoCam() {} // 0x000000018082BBD0-0x000000018082BC80
	
		// Methods
		protected override void FollowTarget(float deltaTime) {} // 0x000000018082B4C0-0x000000018082BBD0
	}
}
