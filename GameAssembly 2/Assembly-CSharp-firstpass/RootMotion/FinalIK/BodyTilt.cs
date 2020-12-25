/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	public class BodyTilt : OffsetModifier // TypeDefIndex: 6795
	{
		// Fields
		// [Tooltip] // 0x00000001800FBA80-0x00000001800FBAB0
		public float tiltSpeed; // 0x30
		// [Tooltip] // 0x00000001800FBB80-0x00000001800FBBB0
		public float tiltSensitivity; // 0x34
		// [Tooltip] // 0x00000001800FBCA0-0x00000001800FBCD0
		public OffsetPose poseLeft; // 0x38
		// [Tooltip] // 0x00000001800FBCA0-0x00000001800FBCD0
		public OffsetPose poseRight; // 0x40
		private float tiltAngle; // 0x48
		private Vector3 lastForward; // 0x4C
	
		// Constructors
		public BodyTilt() {} // 0x0000000180522C70-0x0000000180522C90
	
		// Methods
		protected override void Start() {} // 0x0000000180522C20-0x0000000180522C70
		protected override void OnModifyOffset() {} // 0x00000001805229A0-0x0000000180522C20
	}
}
