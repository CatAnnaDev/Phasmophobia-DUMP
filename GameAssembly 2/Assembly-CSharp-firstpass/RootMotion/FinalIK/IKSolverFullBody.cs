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
	public class IKSolverFullBody : IKSolver // TypeDefIndex: 6730
	{
		// Fields
		// [Range] // 0x00000001800DF840-0x00000001800DF860
		public int iterations; // 0x58
		public FBIKChain[] chain; // 0x60
		public IKEffector[] effectors; // 0x68
		public IKMappingSpine spineMapping; // 0x70
		public IKMappingBone[] boneMappings; // 0x78
		public IKMappingLimb[] limbMappings; // 0x80
		public bool FABRIKPass; // 0x88
		public UpdateDelegate OnPreRead; // 0x90
		public UpdateDelegate OnPreSolve; // 0x98
		public IterationDelegate OnPreIteration; // 0xA0
		public IterationDelegate OnPostIteration; // 0xA8
		public UpdateDelegate OnPreBend; // 0xB0
		public UpdateDelegate OnPostSolve; // 0xB8
		public UpdateDelegate OnStoreDefaultLocalState; // 0xC0
		public UpdateDelegate OnFixTransforms; // 0xC8
	
		// Constructors
		public IKSolverFullBody() {} // 0x00000001809BF540-0x00000001809BF7D0
	
		// Methods
		public IKEffector GetEffector(Transform t) => default; // 0x00000001809BDC80-0x00000001809BDDA0
		public FBIKChain GetChain(Transform transform) => default; // 0x00000001809BDC30-0x00000001809BDC80
		public int GetChainIndex(Transform transform) => default; // 0x00000001809BDAC0-0x00000001809BDC30
		public Node GetNode(int chainIndex, int nodeIndex) => default; // 0x00000001809BDDA0-0x00000001809BDE10
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex) {
			chainIndex = default;
			nodeIndex = default;
		} // 0x00000001809BDA30-0x00000001809BDAC0
		public override Point[] GetPoints() => default; // 0x00000001809BDFD0-0x00000001809BE160
		public override Point GetPoint(Transform transform) => default; // 0x00000001809BDE10-0x00000001809BDFD0
		public override bool IsValid(ref string message) => default; // 0x00000001809BE160-0x00000001809BE3F0
		public override void StoreDefaultLocalState() {} // 0x00000001809BF1C0-0x00000001809BF400
		public override void FixTransforms() {} // 0x00000001809BD700-0x00000001809BDA30
		protected override void OnInitiate() {} // 0x00000001809BE3F0-0x00000001809BE5C0
		protected override void OnUpdate() {} // 0x00000001809BE5C0-0x00000001809BE840
		protected virtual void ReadPose() {} // 0x00000001809BE840-0x00000001809BED20
		protected virtual void Solve() {} // 0x00000001809BED20-0x00000001809BF1C0
		protected virtual void ApplyBendConstraints() {} // 0x00000001809BD6B0-0x00000001809BD700
		protected virtual void WritePose() {} // 0x00000001809BF400-0x00000001809BF540
	}
}
