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
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 6736
	{
		// Fields
		public AvatarIKGoal goal; // 0xA8
		public BendModifier bendModifier; // 0xAC
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float maintainRotationWeight; // 0xB0
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float bendModifierWeight; // 0xB4
		public Transform bendGoal; // 0xB8
		private bool maintainBendFor1Frame; // 0xC0
		private bool maintainRotationFor1Frame; // 0xC1
		private Quaternion defaultRootRotation; // 0xC4
		private Quaternion parentDefaultRotation; // 0xD4
		private Quaternion bone3RotationBeforeSolve; // 0xE4
		private Quaternion maintainRotation; // 0xF4
		private Quaternion bone3DefaultRotation; // 0x104
		private Vector3 _bendNormal; // 0x114
		private Vector3 animationNormal; // 0x120
		private AxisDirection[] axisDirectionsLeft; // 0x130
		private AxisDirection[] axisDirectionsRight; // 0x138
	
		// Properties
		private AxisDirection[] axisDirections { get => default; } // 0x00000001809ECDA0-0x00000001809ECDC0 
	
		// Nested types
		[Serializable]
		public enum BendModifier // TypeDefIndex: 6737
		{
			Animation = 0,
			Target = 1,
			Parent = 2,
			Arm = 3,
			Goal = 4
		}
	
		[Serializable]
		public struct AxisDirection // TypeDefIndex: 6738
		{
			// Fields
			public Vector3 direction; // 0x00
			public Vector3 axis; // 0x0C
			public float dot; // 0x18
	
			// Constructors
			public AxisDirection(Vector3 direction, Vector3 axis) {
				this.direction = default;
				this.axis = default;
				dot = default;
			} // 0x00000001800446E0-0x00000001800448D0
		}
	
		// Constructors
		public IKSolverLimb() {} // 0x00000001809ECD10-0x00000001809ECDA0
		public IKSolverLimb(AvatarIKGoal goal) {} // 0x00000001809ECC70-0x00000001809ECD10
	
		// Methods
		public void MaintainRotation() {} // 0x00000001809EC0E0-0x00000001809EC130
		public void MaintainBend() {} // 0x00000001809EC090-0x00000001809EC0E0
		protected override void OnInitiateVirtual() {} // 0x00000001809EC130-0x00000001809EC540
		protected override void OnUpdateVirtual() {} // 0x00000001809EC6B0-0x00000001809EC800
		protected override void OnPostSolveVirtual() {} // 0x00000001809EC540-0x00000001809EC6B0
		private void StoreAxisDirections(ref AxisDirection[] axisDirections) {} // 0x00000001809EC800-0x00000001809ECC70
		private Vector3 GetModifiedBendNormal() => default; // 0x00000001809EB290-0x00000001809EC090
	}
}
