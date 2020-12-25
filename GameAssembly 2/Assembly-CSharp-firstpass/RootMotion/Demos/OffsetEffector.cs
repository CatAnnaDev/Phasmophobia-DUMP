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
	public class OffsetEffector : OffsetModifier // TypeDefIndex: 6628
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x30
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 6629
		{
			// Fields
			public FullBodyBipedEffector effectorType; // 0x10
			public float weightMultiplier; // 0x14
			[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
			public Vector3 localPosition; // 0x18
	
			// Constructors
			public EffectorLink() {} // 0x00000001804C2F30-0x00000001804C2F40
		}
	
		// Constructors
		public OffsetEffector() {} // 0x00000001804AF900-0x00000001804AF910
	
		// Methods
		protected override void Start() {} // 0x00000001804CBB60-0x00000001804CBCB0
		protected override void OnModifyOffset() {} // 0x00000001804CB810-0x00000001804CBB60
	}
}
