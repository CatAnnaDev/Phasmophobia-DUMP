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
	// [AddComponentMenu] // 0x000000018013BF00-0x000000018013BF60
	// [HelpURL] // 0x000000018013BF00-0x000000018013BF60
	public class GrounderQuadruped : Grounder // TypeDefIndex: 6685
	{
		// Fields
		// [Tooltip] // 0x000000018013C090-0x000000018013C0C0
		public Grounding forelegSolver; // 0x40
		// [Range] // 0x000000018013C1F0-0x000000018013C250
		// [Tooltip] // 0x000000018013C1F0-0x000000018013C250
		public float rootRotationWeight; // 0x48
		// [Range] // 0x000000018013C330-0x000000018013C390
		// [Tooltip] // 0x000000018013C330-0x000000018013C390
		public float minRootRotation; // 0x4C
		// [Range] // 0x000000018013C470-0x000000018013C4D0
		// [Tooltip] // 0x000000018013C470-0x000000018013C4D0
		public float maxRootRotation; // 0x50
		// [Tooltip] // 0x000000018013C650-0x000000018013C680
		public float rootRotationSpeed; // 0x54
		// [Tooltip] // 0x000000018013C6E0-0x000000018013C710
		public float maxLegOffset; // 0x58
		// [Tooltip] // 0x000000018013C740-0x000000018013C770
		public float maxForeLegOffset; // 0x5C
		// [Range] // 0x000000018013C920-0x000000018013C980
		// [Tooltip] // 0x000000018013C920-0x000000018013C980
		public float maintainHeadRotationWeight; // 0x60
		// [Tooltip] // 0x000000018013BAE0-0x000000018013BB10
		public Transform characterRoot; // 0x68
		// [Tooltip] // 0x000000018013CB80-0x000000018013CBB0
		public Transform pelvis; // 0x70
		// [Tooltip] // 0x000000018013D460-0x000000018013D490
		public Transform lastSpineBone; // 0x78
		// [Tooltip] // 0x000000018013D570-0x000000018013D5A0
		public Transform head; // 0x80
		public IK[] legs; // 0x88
		public IK[] forelegs; // 0x90
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public Vector3 gravity; // 0x98
		private Foot[] feet; // 0xA8
		private Vector3 animatedPelvisLocalPosition; // 0xB0
		private Quaternion animatedPelvisLocalRotation; // 0xBC
		private Quaternion animatedHeadLocalRotation; // 0xCC
		private Vector3 solvedPelvisLocalPosition; // 0xDC
		private Quaternion solvedPelvisLocalRotation; // 0xE8
		private Quaternion solvedHeadLocalRotation; // 0xF8
		private int solvedFeet; // 0x108
		private bool solved; // 0x10C
		private float angle; // 0x110
		private Transform forefeetRoot; // 0x118
		private Quaternion headRotation; // 0x120
		private float lastWeight; // 0x130
	
		// Nested types
		public struct Foot // TypeDefIndex: 6686
		{
			// Fields
			public IKSolver solver; // 0x00
			public Transform transform; // 0x08
			public Quaternion rotation; // 0x10
			public Grounding.Leg leg; // 0x20
	
			// Constructors
			public Foot(IKSolver solver, Transform transform) {
				this.solver = default;
				this.transform = default;
				rotation = default;
				leg = default;
			} // 0x0000000180044650-0x00000001800446E0
		}
	
		// Constructors
		public GrounderQuadruped() {} // 0x0000000180538C50-0x0000000180538D90
	
		// Methods
		// [ContextMenu] // 0x00000001800D5050-0x00000001800D5080
		protected override void OpenUserManual() {} // 0x0000000180538040-0x0000000180538080
		// [ContextMenu] // 0x00000001800D50F0-0x00000001800D5120
		protected override void OpenScriptReference() {} // 0x0000000180538000-0x0000000180538040
		public override void ResetPosition() {} // 0x0000000180538080-0x00000001805380C0
		private bool IsReadyToInitiate() => default; // 0x0000000180536EF0-0x0000000180537040
		private bool IsReadyToInitiateLegs(IK[] ikComponents) => default; // 0x0000000180536DB0-0x0000000180536EF0
		private void OnDisable() {} // 0x00000001805371C0-0x0000000180537240
		private void Update() {} // 0x0000000180538A80-0x0000000180538C50
		private void Initiate() {} // 0x0000000180536A00-0x0000000180536DB0
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset) => default; // 0x00000001805365E0-0x0000000180536A00
		private void LateUpdate() {} // 0x0000000180537040-0x0000000180537180
		private void RootRotation() {} // 0x00000001805380C0-0x0000000180538520
		private void OnSolverUpdate() {} // 0x0000000180537630-0x0000000180538000
		private void UpdateForefeetRoot() {} // 0x0000000180538700-0x0000000180538A80
		private void SetFootIK(Foot foot, float maxOffset) {} // 0x0000000180538520-0x0000000180538700
		private void OnPostSolverUpdate() {} // 0x0000000180537240-0x0000000180537630
		private void OnDestroy() {} // 0x0000000180537180-0x00000001805371C0
		private void DestroyLegs(IK[] ikComponents) {} // 0x00000001805363E0-0x00000001805365E0
	}
}
