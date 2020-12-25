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
	public abstract class Poser : SolverManager // TypeDefIndex: 6777
	{
		// Fields
		public Transform poseRoot; // 0x38
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float weight; // 0x40
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float localRotationWeight; // 0x44
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float localPositionWeight; // 0x48
		private bool initiated; // 0x4C
	
		// Constructors
		protected Poser() {} // 0x00000001807E7DE0-0x00000001807E7E00
	
		// Methods
		public abstract void AutoMapping();
		protected abstract void InitiatePoser();
		protected abstract void UpdatePoser();
		protected abstract void FixPoserTransforms();
		protected override void UpdateSolver() {} // 0x00000001807E7D90-0x00000001807E7DE0
		protected override void InitiateSolver() {} // 0x00000001807E7D60-0x00000001807E7D90
		protected override void FixTransforms() {} // 0x00000001807E7D40-0x00000001807E7D60
	}
}
