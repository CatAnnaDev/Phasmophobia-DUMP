/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKConstraintBend // TypeDefIndex: 6712
	{
		// Fields
		public Transform bone1; // 0x10
		public Transform bone2; // 0x18
		public Transform bone3; // 0x20
		public Transform bendGoal; // 0x28
		public Vector3 direction; // 0x30
		public Quaternion rotationOffset; // 0x3C
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float weight; // 0x4C
		public Vector3 defaultLocalDirection; // 0x50
		public Vector3 defaultChildDirection; // 0x5C
		[NonSerialized]
		public float clampF; // 0x68
		private int chainIndex1; // 0x6C
		private int nodeIndex1; // 0x70
		private int chainIndex2; // 0x74
		private int nodeIndex2; // 0x78
		private int chainIndex3; // 0x7C
		private int nodeIndex3; // 0x80
	
		// Properties
		public bool initiated { get; private set; } // 0x00000001809AE610-0x00000001809AE620 0x00000001809AE620-0x00000001809AE630
	
		// Constructors
		public IKConstraintBend() {} // 0x00000001809AE4C0-0x00000001809AE540
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3) {} // 0x00000001809AE540-0x00000001809AE610
	
		// Methods
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger) => default; // 0x00000001809AD640-0x00000001809AD860
		public void SetBones(Transform bone1, Transform bone2, Transform bone3) {} // 0x00000001809AE210-0x00000001809AE270
		public void Initiate(IKSolverFullBody solver) {} // 0x00000001809AD2C0-0x00000001809AD640
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last) {} // 0x00000001809AE270-0x00000001809AE4C0
		public void LimitBend(float solverWeight, float positionWeight) {} // 0x00000001809AD860-0x00000001809ADE20
		public Vector3 GetDir(IKSolverFullBody solver) => default; // 0x00000001809ACA10-0x00000001809AD2C0
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent) => default; // 0x00000001809AE010-0x00000001809AE210
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent) => default; // 0x00000001809ADE20-0x00000001809AE010
	}
}
