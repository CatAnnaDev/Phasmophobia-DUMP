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
	public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 6728
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
		private bool[] limitedBones; // 0x90
		private Vector3[] solverLocalPositions; // 0x98
	
		// Properties
		protected override bool boneLengthCanBeZero { get => default; } // 0x0000000180250A70-0x0000000180250A80 
	
		// Constructors
		public IKSolverFABRIK() {} // 0x00000001809BD630-0x00000001809BD6B0
	
		// Methods
		public void SolveForward(Vector3 position) {} // 0x00000001809BCD20-0x00000001809BCDC0
		public void SolveBackward(Vector3 position) {} // 0x00000001809BCC60-0x00000001809BCD20
		public override Vector3 GetIKPosition() => default; // 0x00000001809BAB30-0x00000001809BABE0
		protected override void OnInitiate() {} // 0x00000001809BBC50-0x00000001809BC0B0
		protected override void OnUpdate() {} // 0x00000001809BC8A0-0x00000001809BCC60
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length) => default; // 0x00000001809BCDC0-0x00000001809BCF20
		private void OnPreSolve() {} // 0x00000001809BC210-0x00000001809BC8A0
		private void OnPostSolve() {} // 0x00000001809BC0B0-0x00000001809BC210
		private void Solve(Vector3 targetPosition) {} // 0x00000001809BCF20-0x00000001809BCFD0
		private void ForwardReach(Vector3 position) {} // 0x00000001809BA750-0x00000001809BAB30
		private void SolverMove(int index, Vector3 offset) {} // 0x00000001809BD290-0x00000001809BD3D0
		private void SolverRotate(int index, Quaternion rotation, bool recursive) {} // 0x00000001809BD4F0-0x00000001809BD630
		private void SolverRotateChildren(int index, Quaternion rotation) {} // 0x00000001809BD3D0-0x00000001809BD4F0
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation) {} // 0x00000001809BCFD0-0x00000001809BD290
		private Quaternion GetParentSolverRotation(int index) => default; // 0x00000001809BAF40-0x00000001809BB0D0
		private Vector3 GetParentSolverPosition(int index) => default; // 0x00000001809BADA0-0x00000001809BAF40
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed) {
			changed = default;
			return default;
		} // 0x00000001809BABE0-0x00000001809BADA0
		private void LimitForward(int rotateBone, int limitBone) {} // 0x00000001809BB0D0-0x00000001809BB970
		private void BackwardReach(Vector3 position) {} // 0x00000001809BA710-0x00000001809BA750
		private void BackwardReachUnlimited(Vector3 position) {} // 0x00000001809BA480-0x00000001809BA710
		private void BackwardReachLimited(Vector3 position) {} // 0x00000001809B9C80-0x00000001809BA480
		private void MapToSolverPositions() {} // 0x00000001809BBA80-0x00000001809BBC50
		private void MapToSolverPositionsLimited() {} // 0x00000001809BB970-0x00000001809BBA80
	}
}
