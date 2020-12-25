/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	// [RequireComponent] // 0x0000000180133CF0-0x0000000180133D40
	public class CharacterAnimationSimple : CharacterAnimationBase // TypeDefIndex: 6655
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private CharacterThirdPerson characterController; // 0x60
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float pivotOffset; // 0x68
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private AnimationCurve moveSpeed; // 0x70
		private Animator animator; // 0x78
	
		// Constructors
		public CharacterAnimationSimple() {} // 0x00000001804BD5B0-0x00000001804BD5D0
	
		// Methods
		protected override void Start() {} // 0x00000001804BD770-0x00000001804BD7D0
		public override Vector3 GetPivotPoint() => default; // 0x00000001804BD5D0-0x00000001804BD770
		private void Update() {} // 0x00000001804BD7D0-0x00000001804BD990
	}
}
