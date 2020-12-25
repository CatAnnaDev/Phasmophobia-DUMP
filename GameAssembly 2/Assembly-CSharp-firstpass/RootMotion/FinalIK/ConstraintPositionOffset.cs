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
	public class ConstraintPositionOffset : Constraint // TypeDefIndex: 6672
	{
		// Fields
		public Vector3 offset; // 0x20
		private Vector3 defaultLocalPosition; // 0x2C
		private Vector3 lastLocalPosition; // 0x38
		private bool initiated; // 0x44
	
		// Properties
		private bool positionChanged { get => default; } // 0x0000000180523F40-0x0000000180524000 
	
		// Constructors
		public ConstraintPositionOffset() {} // 0x00000001802466A0-0x00000001802466B0
		public ConstraintPositionOffset(Transform transform) {} // 0x000000018024B380-0x000000018024B3B0
	
		// Methods
		public override void UpdateConstraint() {} // 0x0000000180523C40-0x0000000180523F40
	}
}
