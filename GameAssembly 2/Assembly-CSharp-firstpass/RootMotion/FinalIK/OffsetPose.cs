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
	public class OffsetPose : MonoBehaviour // TypeDefIndex: 6816
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x18
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 6817
		{
			// Fields
			public FullBodyBipedEffector effector; // 0x10
			public Vector3 offset; // 0x14
			public Vector3 pin; // 0x20
			public Vector3 pinWeight; // 0x2C
	
			// Constructors
			public EffectorLink() {} // 0x00000001802466A0-0x00000001802466B0
	
			// Methods
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation) {} // 0x00000001807DB2D0-0x00000001807DB6A0
		}
	
		// Constructors
		public OffsetPose() {} // 0x00000001807E7CF0-0x00000001807E7D40
	
		// Methods
		public void Apply(IKSolverFullBodyBiped solver, float weight) {} // 0x00000001807E7B30-0x00000001807E7C20
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation) {} // 0x00000001807E7C20-0x00000001807E7CF0
	}
}
