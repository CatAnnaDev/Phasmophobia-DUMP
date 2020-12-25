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
	public class Amplifier : OffsetModifier // TypeDefIndex: 6792
	{
		// Fields
		// [Tooltip] // 0x00000001800F9DF0-0x00000001800F9E20
		public Body[] bodies; // 0x30
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 6793
		{
			// Fields
			// [Tooltip] // 0x00000001800F9E20-0x00000001800F9E50
			public Transform transform; // 0x10
			// [Tooltip] // 0x00000001800F9EE0-0x00000001800F9F10
			public Transform relativeTo; // 0x18
			// [Tooltip] // 0x00000001800FB300-0x00000001800FB330
			public EffectorLink[] effectorLinks; // 0x20
			// [Tooltip] // 0x00000001800FB3E0-0x00000001800FB410
			public float verticalWeight; // 0x28
			// [Tooltip] // 0x00000001800FB550-0x00000001800FB580
			public float horizontalWeight; // 0x2C
			// [Tooltip] // 0x00000001800FB6D0-0x00000001800FB700
			public float speed; // 0x30
			private Vector3 lastRelativePos; // 0x34
			private Vector3 smoothDelta; // 0x40
			private bool firstUpdate; // 0x4C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 6794
			{
				// Fields
				// [Tooltip] // 0x00000001800FB880-0x00000001800FB8B0
				public FullBodyBipedEffector effector; // 0x10
				// [Tooltip] // 0x00000001800FB910-0x00000001800FB940
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink() {} // 0x00000001802466A0-0x00000001802466B0
			}
	
			// Constructors
			public Body() {} // 0x00000001805232E0-0x0000000180523300
	
			// Methods
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime) {} // 0x0000000180522CF0-0x00000001805232E0
			private static Vector3 Multiply(Vector3 v1, Vector3 v2) => default; // 0x0000000180522C90-0x0000000180522CF0
		}
	
		// Constructors
		public Amplifier() {} // 0x00000001804AF900-0x00000001804AF910
	
		// Methods
		protected override void OnModifyOffset() {} // 0x0000000180520D40-0x0000000180520E80
	}
}
