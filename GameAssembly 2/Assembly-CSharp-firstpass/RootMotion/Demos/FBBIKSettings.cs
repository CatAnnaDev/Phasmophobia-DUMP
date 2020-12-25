/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public class FBBIKSettings : MonoBehaviour // TypeDefIndex: 6610
	{
		// Fields
		public FullBodyBipedIK ik; // 0x18
		public bool disableAfterStart; // 0x20
		public Limb leftArm; // 0x28
		public Limb rightArm; // 0x30
		public Limb leftLeg; // 0x38
		public Limb rightLeg; // 0x40
		public float rootPin; // 0x48
		public bool bodyEffectChildNodes; // 0x4C
	
		// Nested types
		[Serializable]
		public class Limb // TypeDefIndex: 6611
		{
			// Fields
			public FBIKChain.Smoothing reachSmoothing; // 0x10
			public float maintainRelativePositionWeight; // 0x14
			public float mappingWeight; // 0x18
	
			// Constructors
			public Limb() {} // 0x00000001804C85D0-0x00000001804C85E0
	
			// Methods
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver) {} // 0x00000001804C8550-0x00000001804C85D0
		}
	
		// Constructors
		public FBBIKSettings() {} // 0x00000001804C4350-0x00000001804C4360
	
		// Methods
		public void UpdateSettings() {} // 0x00000001804C41C0-0x00000001804C4340
		private void Start() {} // 0x00000001804C4140-0x00000001804C41C0
		private void Update() {} // 0x00000001804C4340-0x00000001804C4350
	}
}
