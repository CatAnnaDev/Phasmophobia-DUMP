/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion
{
	[Serializable]
	public class BipedLimbOrientations // TypeDefIndex: 6570
	{
		// Fields
		public LimbOrientation leftArm; // 0x10
		public LimbOrientation rightArm; // 0x18
		public LimbOrientation leftLeg; // 0x20
		public LimbOrientation rightLeg; // 0x28
	
		// Properties
		public static BipedLimbOrientations UMA { get => default; } // 0x00000001804B2830-0x00000001804B2B60 
		public static BipedLimbOrientations MaxBiped { get => default; } // 0x00000001804B2500-0x00000001804B2830 
	
		// Nested types
		[Serializable]
		public class LimbOrientation // TypeDefIndex: 6571
		{
			// Fields
			public Vector3 upperBoneForwardAxis; // 0x10
			public Vector3 lowerBoneForwardAxis; // 0x1C
			public Vector3 lastBoneLeftAxis; // 0x28
	
			// Constructors
			public LimbOrientation() {} // Dummy constructor
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis) {} // 0x00000001804C84E0-0x00000001804C8550
		}
	
		// Constructors
		public BipedLimbOrientations() {} // Dummy constructor
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg) {} // 0x0000000180322390-0x0000000180322410
	}
}
