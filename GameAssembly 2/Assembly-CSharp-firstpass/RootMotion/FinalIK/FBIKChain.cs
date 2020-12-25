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
	public class FBIKChain // TypeDefIndex: 6709
	{
		// Fields
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float pin; // 0x10
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float pull; // 0x14
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float push; // 0x18
		// [Range] // 0x00000001800DD220-0x00000001800DD240
		public float pushParent; // 0x1C
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float reach; // 0x20
		public Smoothing reachSmoothing; // 0x24
		public Smoothing pushSmoothing; // 0x28
		public IKSolver.Node[] nodes; // 0x30
		public int[] children; // 0x38
		public ChildConstraint[] childConstraints; // 0x40
		public IKConstraintBend bendConstraint; // 0x48
		private float rootLength; // 0x50
		private bool initiated; // 0x54
		private float length; // 0x58
		private float distance; // 0x5C
		private IKSolver.Point p; // 0x60
		private float reachForce; // 0x68
		private float pullParentSum; // 0x6C
		private float[] crossFades; // 0x70
		private float sqrMag1; // 0x78
		private float sqrMag2; // 0x7C
		private float sqrMagDif; // 0x80
		private const float maxLimbLength = 0.99999f; // Metadata: 0x00652E21
	
		// Nested types
		[Serializable]
		public class ChildConstraint // TypeDefIndex: 6710
		{
			// Fields
			public float pushElasticity; // 0x10
			public float pullElasticity; // 0x14
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private Transform bone1; // 0x18
			[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
			private Transform bone2; // 0x20
			private float crossFade; // 0x30
			private float inverseCrossFade; // 0x34
			private int chain1Index; // 0x38
			private int chain2Index; // 0x3C
	
			// Properties
			public float nominalDistance { get; private set; } // 0x000000018036E6C0-0x000000018036E6D0 0x0000000180523C30-0x0000000180523C40
			public bool isRigid { get; private set; } // 0x0000000180482A30-0x0000000180482A40 0x0000000180482A90-0x0000000180482AA0
	
			// Constructors
			public ChildConstraint() {} // Dummy constructor
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f /* Metadata: 0x00652E25 */, float pullElasticity = 0f /* Metadata: 0x00652E29 */) {} // 0x0000000180523BC0-0x0000000180523C30
	
			// Methods
			public void Initiate(IKSolverFullBody solver) {} // 0x0000000180523470-0x00000001805234D0
			public void OnPreSolve(IKSolverFullBody solver) {} // 0x00000001805234D0-0x0000000180523770
			public void Solve(IKSolverFullBody solver) {} // 0x0000000180523770-0x0000000180523BC0
		}
	
		[Serializable]
		public enum Smoothing // TypeDefIndex: 6711
		{
			None = 0,
			Exponential = 1,
			Cubic = 2
		}
	
		// Constructors
		public FBIKChain() {} // 0x000000018052F630-0x000000018052F710
		public FBIKChain(float pin, float pull, params /* 0x00000001800D4E50-0x00000001800D4E60 */ Transform[] nodeTransforms) {} // 0x000000018052F3F0-0x000000018052F630
	
		// Methods
		public void SetNodes(params /* 0x00000001800D4E50-0x00000001800D4E60 */ Transform[] boneTransforms) {} // 0x000000018052DD50-0x000000018052DEA0
		public int GetNodeIndex(Transform boneTransform) => default; // 0x000000018052C700-0x000000018052C7F0
		public bool IsValid(ref string message) => default; // 0x000000018052CA10-0x000000018052CB30
		public void Initiate(IKSolverFullBody solver) {} // 0x000000018052C7F0-0x000000018052CA10
		public void ReadPose(IKSolverFullBody solver, bool fullBody) {} // 0x000000018052D5D0-0x000000018052DD50
		private void CalculateBoneLengths(IKSolverFullBody solver) {} // 0x000000018052BAE0-0x000000018052C240
		public void Reach(IKSolverFullBody solver) {} // 0x000000018052D0B0-0x000000018052D5D0
		public Vector3 Push(IKSolverFullBody solver) => default; // 0x000000018052CB30-0x000000018052D0B0
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false /* Metadata: 0x00652E20 */) {} // 0x000000018052E6E0-0x000000018052EB80
		public void Stage1(IKSolverFullBody solver) {} // 0x000000018052EB80-0x000000018052F220
		public void Stage2(IKSolverFullBody solver, Vector3 position) {} // 0x000000018052F220-0x000000018052F3F0
		public void SolveConstraintSystems(IKSolverFullBody solver) {} // 0x000000018052DF30-0x000000018052E320
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x000000018052E320-0x000000018052E460
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude) => default; // 0x000000018052C4A0-0x000000018052C700
		private void SolveChildConstraints(IKSolverFullBody solver) {} // 0x000000018052DEA0-0x000000018052DF30
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance) {} // 0x000000018052E460-0x000000018052E6E0
		public void ForwardReach(Vector3 position) {} // 0x000000018052C240-0x000000018052C4A0
		private void BackwardReach(Vector3 position) {} // 0x000000018052B750-0x000000018052BAE0
	}
}
