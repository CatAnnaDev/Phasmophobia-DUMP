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
	public class LookatTarget : AbstractTargetFollower // TypeDefIndex: 6075
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Vector2 m_RotationRange; // 0x30
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float m_FollowSpeed; // 0x38
		private Vector3 m_FollowAngles; // 0x3C
		private Quaternion m_OriginalRotation; // 0x48
		protected Vector3 m_FollowVelocity; // 0x58
	
		// Constructors
		public LookatTarget() {} // 0x0000000180833B70-0x0000000180833B90
	
		// Methods
		protected override void Start() {} // 0x0000000180833AA0-0x0000000180833B70
		protected override void FollowTarget(float deltaTime) {} // 0x0000000180833690-0x0000000180833AA0
	}
}
