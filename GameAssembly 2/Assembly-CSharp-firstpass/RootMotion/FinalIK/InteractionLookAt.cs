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
	public class InteractionLookAt // TypeDefIndex: 6756
	{
		// Fields
		// [Tooltip] // 0x00000001800EE310-0x00000001800EE340
		public LookAtIK ik; // 0x10
		// [Tooltip] // 0x00000001800EE400-0x00000001800EE430
		public float lerpSpeed; // 0x18
		// [Tooltip] // 0x00000001800EE4D0-0x00000001800EE500
		public float weightSpeed; // 0x1C
		[HideInInspector] // 0x00000001800D4E50-0x00000001800D4E60
		public bool isPaused; // 0x20
		private Transform lookAtTarget; // 0x28
		private float stopLookTime; // 0x30
		private float weight; // 0x34
		private bool firstFBBIKSolve; // 0x38
	
		// Constructors
		public InteractionLookAt() {} // 0x00000001807DEA80-0x00000001807DEAA0
	
		// Methods
		public void Look(Transform target, float time) {} // 0x00000001807DE2E0-0x00000001807DE4E0
		public void OnFixTransforms() {} // 0x00000001807DE4E0-0x00000001807DE580
		public void Update() {} // 0x00000001807DE790-0x00000001807DEA80
		public void SolveSpine() {} // 0x00000001807DE660-0x00000001807DE790
		public void SolveHead() {} // 0x00000001807DE580-0x00000001807DE660
	}
}
