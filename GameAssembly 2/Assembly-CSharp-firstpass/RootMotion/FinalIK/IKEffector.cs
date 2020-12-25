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
	public class IKEffector // TypeDefIndex: 6713
	{
		// Fields
		public Transform bone; // 0x10
		public Transform target; // 0x18
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float positionWeight; // 0x20
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float rotationWeight; // 0x24
		public Vector3 position; // 0x28
		public Quaternion rotation; // 0x34
		public Vector3 positionOffset; // 0x44
		public bool effectChildNodes; // 0x51
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float maintainRelativePositionWeight; // 0x54
		public Transform[] childBones; // 0x58
		public Transform planeBone1; // 0x60
		public Transform planeBone2; // 0x68
		public Transform planeBone3; // 0x70
		public Quaternion planeRotationOffset; // 0x78
		private float posW; // 0x88
		private float rotW; // 0x8C
		private Vector3[] localPositions; // 0x90
		private bool usePlaneNodes; // 0x98
		private Quaternion animatedPlaneRotation; // 0x9C
		private Vector3 animatedPosition; // 0xAC
		private bool firstUpdate; // 0xB8
		private int chainIndex; // 0xBC
		private int nodeIndex; // 0xC0
		private int plane1ChainIndex; // 0xC4
		private int plane1NodeIndex; // 0xC8
		private int plane2ChainIndex; // 0xCC
		private int plane2NodeIndex; // 0xD0
		private int plane3ChainIndex; // 0xD4
		private int plane3NodeIndex; // 0xD8
		private int[] childChainIndexes; // 0xE0
		private int[] childNodeIndexes; // 0xE8
	
		// Properties
		public bool isEndEffector { get; private set; } // 0x00000001802800C0-0x00000001802800D0 0x0000000180400ED0-0x0000000180400EE0
	
		// Constructors
		public IKEffector() {} // 0x00000001809B0B40-0x00000001809B0CC0
		public IKEffector(Transform bone, Transform[] childBones) {} // 0x00000001809B0980-0x00000001809B0B40
	
		// Methods
		public IKSolver.Node GetNode(IKSolverFullBody solver) => default; // 0x00000001809AE630-0x00000001809AE6A0
		public void PinToBone(float positionWeight, float rotationWeight) {} // 0x00000001809B0030-0x00000001809B0120
		public bool IsValid(IKSolver solver, ref string message) => default; // 0x00000001809AF360-0x00000001809AF690
		public void Initiate(IKSolverFullBody solver) {} // 0x00000001809AEEA0-0x00000001809AF360
		public void ResetOffset(IKSolverFullBody solver) {} // 0x00000001809B0120-0x00000001809B0360
		public void SetToTarget() {} // 0x00000001809B0360-0x00000001809B0410
		public void OnPreSolve(IKSolverFullBody solver) {} // 0x00000001809AF700-0x00000001809B0030
		public void OnPostWrite() {} // 0x00000001809AF690-0x00000001809AF700
		private Quaternion GetPlaneRotation(IKSolverFullBody solver) => default; // 0x00000001809AE6A0-0x00000001809AEA10
		public void Update(IKSolverFullBody solver) {} // 0x00000001809B0410-0x00000001809B0980
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset) {
			planeRotationOffset = default;
			return default;
		} // 0x00000001809AEA10-0x00000001809AEEA0
	}
}
