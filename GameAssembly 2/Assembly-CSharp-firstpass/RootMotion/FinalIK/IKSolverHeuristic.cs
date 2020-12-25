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
	public class IKSolverHeuristic : IKSolver // TypeDefIndex: 6734
	{
		// Fields
		public Transform target; // 0x58
		public float tolerance; // 0x60
		public int maxIterations; // 0x64
		public bool useRotationLimits; // 0x68
		public bool XY; // 0x69
		public Bone[] bones; // 0x70
		protected Vector3 lastLocalDirection; // 0x78
		protected float chainLength; // 0x84
	
		// Properties
		protected virtual int minBones { get => default; } // 0x00000001803EB7E0-0x00000001803EB7F0 
		protected virtual bool boneLengthCanBeZero { get => default; } // 0x0000000180246BB0-0x0000000180246BC0 
		protected virtual bool allowCommonParent { get => default; } // 0x0000000180250A70-0x0000000180250A80 
		protected virtual Vector3 localDirection { get => default; } // 0x00000001809E9A60-0x00000001809E9C30 
		protected float positionOffset { get => default; } // 0x00000001809E9C30-0x00000001809E9D10 
	
		// Constructors
		public IKSolverHeuristic() {} // 0x00000001809E9A00-0x00000001809E9A60
	
		// Methods
		public bool SetChain(Transform[] hierarchy, Transform root) => default; // 0x00000001809E9440-0x00000001809E95F0
		public void AddBone(Transform bone) {} // 0x00000001809E8070-0x00000001809E8240
		public override void StoreDefaultLocalState() {} // 0x00000001809E9980-0x00000001809E9A00
		public override void FixTransforms() {} // 0x00000001809E8240-0x00000001809E82D0
		public override bool IsValid(ref string message) => default; // 0x00000001809E8FF0-0x00000001809E9440
		public override Point[] GetPoints() => default; // 0x0000000180274980-0x0000000180274990
		public override Point GetPoint(Transform transform) => default; // 0x00000001809E82D0-0x00000001809E83F0
		protected override void OnInitiate() {} // 0x0000000180246DB0-0x0000000180246DC0
		protected override void OnUpdate() {} // 0x0000000180246DB0-0x0000000180246DC0
		protected void InitiateBones() {} // 0x00000001809E88B0-0x00000001809E8FF0
		protected Vector3 GetSingularityOffset() => default; // 0x00000001809E83F0-0x00000001809E88B0
		private bool SingularityDetected() => default; // 0x00000001809E95F0-0x00000001809E9980
	}
}
