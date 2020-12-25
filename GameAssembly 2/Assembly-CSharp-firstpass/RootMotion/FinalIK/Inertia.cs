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
	public class Inertia : OffsetModifier // TypeDefIndex: 6808
	{
		// Fields
		// [Tooltip] // 0x00000001800FF710-0x00000001800FF740
		public Body[] bodies; // 0x30
		// [Tooltip] // 0x00000001800FF7D0-0x00000001800FF800
		public OffsetLimits[] limits; // 0x38
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 6809
		{
			// Fields
			// [Tooltip] // 0x00000001800FF8B0-0x00000001800FF8E0
			public Transform transform; // 0x10
			// [Tooltip] // 0x00000001800FF9D0-0x00000001800FFA00
			public EffectorLink[] effectorLinks; // 0x18
			// [Tooltip] // 0x00000001800FFAB0-0x00000001800FFAE0
			public float speed; // 0x20
			// [Tooltip] // 0x00000001800FFB90-0x00000001800FFBC0
			public float acceleration; // 0x24
			// [Range] // 0x00000001800FFC70-0x00000001800FFCD0
			// [Tooltip] // 0x00000001800FFC70-0x00000001800FFCD0
			public float matchVelocity; // 0x28
			// [Tooltip] // 0x00000001800FFD90-0x00000001800FFDC0
			public float gravity; // 0x2C
			private Vector3 delta; // 0x30
			private Vector3 lazyPoint; // 0x3C
			private Vector3 direction; // 0x48
			private Vector3 lastPosition; // 0x54
			private bool firstUpdate; // 0x60
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 6810
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
			public Body() {} // 0x00000001807D9F40-0x00000001807D9F60
	
			// Methods
			public void Reset() {} // 0x00000001807D98D0-0x00000001807D99D0
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime) {} // 0x00000001807D99D0-0x00000001807D9F40
		}
	
		// Constructors
		public Inertia() {} // 0x000000018053ADA0-0x000000018053ADB0
	
		// Methods
		public void ResetBodies() {} // 0x00000001807DB820-0x00000001807DB890
		protected override void OnModifyOffset() {} // 0x00000001807DB6A0-0x00000001807DB820
	}
}
