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
	public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 6726
	{
		// Fields
		public Transform transform; // 0x88
		public Vector3 axis; // 0x90
		public Vector3 poleAxis; // 0x9C
		public Vector3 polePosition; // 0xA8
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float poleWeight; // 0xB4
		public Transform poleTarget; // 0xB8
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float clampWeight; // 0xC0
		// [Range] // 0x00000001800DF770-0x00000001800DF790
		public int clampSmoothing; // 0xC4
		public IterationDelegate OnPreIteration; // 0xC8
		private float step; // 0xD0
		private Vector3 clampedIKPosition; // 0xD4
		private RotationLimit transformLimit; // 0xE0
		private Transform lastTransform; // 0xE8
	
		// Properties
		public Vector3 transformAxis { get => default; } // 0x00000001809B6EC0-0x00000001809B6FA0 
		public Vector3 transformPoleAxis { get => default; } // 0x00000001809B6FA0-0x00000001809B7080 
		protected override int minBones { get => default; } // 0x0000000180248DE0-0x0000000180248DF0 
		protected override Vector3 localDirection { get => default; } // 0x00000001809B6DF0-0x00000001809B6EC0 
	
		// Constructors
		public IKSolverAim() {} // 0x00000001809B6D40-0x00000001809B6DF0
	
		// Methods
		public float GetAngle() => default; // 0x00000001809B54B0-0x00000001809B55E0
		protected override void OnInitiate() {} // 0x00000001809B5AF0-0x00000001809B5E60
		protected override void OnUpdate() {} // 0x00000001809B5E60-0x00000001809B65B0
		private void Solve() {} // 0x00000001809B6C00-0x00000001809B6D40
		private Vector3 GetClampedIKPosition() => default; // 0x00000001809B55E0-0x00000001809B5AF0
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight) {} // 0x00000001809B65B0-0x00000001809B6C00
	}
}
