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
	public class FingerRig : SolverManager // TypeDefIndex: 6678
	{
		// Fields
		// [Range] // 0x0000000180138E80-0x0000000180138EE0
		// [Tooltip] // 0x0000000180138E80-0x0000000180138EE0
		public float weight; // 0x38
		public Finger[] fingers; // 0x40
	
		// Properties
		public bool initiated { get; private set; } // 0x00000001802968B0-0x00000001802968C0 0x00000001802FF720-0x00000001802FF790
	
		// Constructors
		public FingerRig() {} // 0x0000000180530120-0x0000000180530180
	
		// Methods
		public bool IsValid(ref string errorMessage) => default; // 0x000000018052FE80-0x000000018052FF10
		// [ContextMenu] // 0x0000000180139370-0x00000001801393A0
		public void AutoDetect() {} // 0x000000018052F9E0-0x000000018052FC60
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null) {} // 0x000000018052F810-0x000000018052F9E0
		public void RemoveFinger(int index) {} // 0x000000018052FF10-0x0000000180530090
		private void AddChildrenRecursive(Transform parent, ref Transform[] array) {} // 0x000000018052F710-0x000000018052F810
		protected override void InitiateSolver() {} // 0x000000018052FDA0-0x000000018052FE80
		public void UpdateFingerSolvers() {} // 0x0000000180530090-0x0000000180530120
		public void FixFingerTransforms() {} // 0x000000018052FC60-0x000000018052FDA0
		protected override void UpdateSolver() {} // 0x0000000180530090-0x0000000180530120
		protected override void FixTransforms() {} // 0x000000018052FC60-0x000000018052FDA0
	}
}
