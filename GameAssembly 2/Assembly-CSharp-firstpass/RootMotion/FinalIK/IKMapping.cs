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
	public class IKMapping // TypeDefIndex: 6714
	{
		// Nested types
		[Serializable]
		public class BoneMap // TypeDefIndex: 6715
		{
			// Fields
			public Transform transform; // 0x10
			public int chainIndex; // 0x18
			public int nodeIndex; // 0x1C
			public Vector3 defaultLocalPosition; // 0x20
			public Quaternion defaultLocalRotation; // 0x2C
			public Vector3 localSwingAxis; // 0x3C
			public Vector3 localTwistAxis; // 0x48
			public Vector3 planePosition; // 0x54
			public Vector3 ikPosition; // 0x60
			public Quaternion defaultLocalTargetRotation; // 0x6C
			private Quaternion maintainRotation; // 0x7C
			public float length; // 0x8C
			public Quaternion animatedRotation; // 0x90
			private Transform planeBone1; // 0xA0
			private Transform planeBone2; // 0xA8
			private Transform planeBone3; // 0xB0
			private int plane1ChainIndex; // 0xB8
			private int plane1NodeIndex; // 0xBC
			private int plane2ChainIndex; // 0xC0
			private int plane2NodeIndex; // 0xC4
			private int plane3ChainIndex; // 0xC8
			private int plane3NodeIndex; // 0xCC
	
			// Properties
			public Vector3 swingDirection { get => default; } // 0x00000001809A71E0-0x00000001809A72B0 
			public bool isNodeBone { get => default; } // 0x00000001809A6F20-0x00000001809A6F30 
			private Quaternion lastAnimatedTargetRotation { get => default; } // 0x00000001809A6F30-0x00000001809A71E0 
	
			// Constructors
			public BoneMap() {} // 0x00000001809A6EF0-0x00000001809A6F20
	
			// Methods
			public void Initiate(Transform transform, IKSolverFullBody solver) {} // 0x00000001809A5D40-0x00000001809A5DA0
			public void StoreDefaultLocalState() {} // 0x00000001805396C0-0x0000000180539720
			public void FixTransform(bool position) {} // 0x00000001809A57A0-0x00000001809A5800
			public void SetLength(BoneMap nextBone) {} // 0x00000001809A62E0-0x00000001809A63D0
			public void SetLocalSwingAxis(BoneMap swingTarget) {} // 0x00000001809A63D0-0x00000001809A63E0
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2) {} // 0x00000001809A63E0-0x00000001809A6590
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection) {} // 0x00000001809A6590-0x00000001809A66B0
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3) {} // 0x00000001809A66B0-0x00000001809A67C0
			public void UpdatePlane(bool rotation, bool position) {} // 0x00000001809A6D10-0x00000001809A6EF0
			public void SetIKPosition() {} // 0x00000001809A62A0-0x00000001809A62E0
			public void MaintainRotation() {} // 0x00000001809A5DA0-0x00000001809A5DE0
			public void SetToIKPosition() {} // 0x00000001809A67C0-0x00000001809A6800
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null) {} // 0x00000001809A55C0-0x00000001809A57A0
			public Vector3 GetPlanePosition(IKSolverFullBody solver) => default; // 0x00000001809A5800-0x00000001809A59D0
			public void PositionToPlane(IKSolverFullBody solver) {} // 0x00000001809A5DE0-0x00000001809A5E30
			public void RotateToPlane(IKSolverFullBody solver, float weight) {} // 0x00000001809A6130-0x00000001809A62A0
			public void Swing(Vector3 swingTarget, float weight) {} // 0x00000001809A6A60-0x00000001809A6AF0
			public void Swing(Vector3 pos1, Vector3 pos2, float weight) {} // 0x00000001809A6800-0x00000001809A6A60
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight) {} // 0x00000001809A6AF0-0x00000001809A6D10
			public void RotateToMaintain(float weight) {} // 0x00000001809A6020-0x00000001809A6130
			public void RotateToEffector(IKSolverFullBody solver, float weight) {} // 0x00000001809A5E30-0x00000001809A6020
			private Quaternion GetTargetRotation(IKSolverFullBody solver) => default; // 0x00000001809A59D0-0x00000001809A5D40
		}
	
		// Constructors
		public IKMapping() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		public virtual bool IsValid(IKSolver solver, ref string message) => default; // 0x0000000180246BB0-0x0000000180246BC0
		public virtual void Initiate(IKSolverFullBody solver) {} // 0x0000000180246DB0-0x0000000180246DC0
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null) => default; // 0x00000001809B5260-0x00000001809B5370
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x00000001809B5370-0x00000001809B54B0
	}
}
