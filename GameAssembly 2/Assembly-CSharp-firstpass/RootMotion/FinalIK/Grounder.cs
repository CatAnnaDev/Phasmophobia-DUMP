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
	public abstract class Grounder : MonoBehaviour // TypeDefIndex: 6679
	{
		// Fields
		// [Range] // 0x0000000180139410-0x0000000180139470
		// [Tooltip] // 0x0000000180139410-0x0000000180139470
		public float weight; // 0x18
		// [Tooltip] // 0x00000001801397A0-0x00000001801397D0
		public Grounding solver; // 0x20
		public GrounderDelegate OnPreGrounder; // 0x28
		public GrounderDelegate OnPostGrounder; // 0x30
		protected bool initiated; // 0x38
	
		// Nested types
		public delegate void GrounderDelegate(); // TypeDefIndex: 6680; 0x0000000180533490-0x0000000180533710
	
		// Constructors
		protected Grounder() {} // 0x00000001805395F0-0x0000000180539660
	
		// Methods
		public abstract void ResetPosition();
		protected Vector3 GetSpineOffsetTarget() => default; // 0x0000000180539230-0x00000001805395F0
		protected void LogWarning(string message) {} // 0x0000000180521FA0-0x0000000180521FD0
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg) => default; // 0x0000000180538D90-0x0000000180538FA0
		private Vector3 GetLegSpineTangent(Grounding.Leg leg) => default; // 0x0000000180538FA0-0x0000000180539230
		protected abstract void OpenUserManual();
		protected abstract void OpenScriptReference();
	}
}
