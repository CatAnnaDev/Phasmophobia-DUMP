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
	// [RequireComponent] // 0x0000000180133F40-0x0000000180133F90
	public class CharacterAnimationThirdPerson : CharacterAnimationBase // TypeDefIndex: 6656
	{
		// Fields
		public CharacterThirdPerson characterController; // 0x60
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float turnSensitivity; // 0x68
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float turnSpeed; // 0x6C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float runCycleLegOffset; // 0x70
		// [Range] // 0x0000000180134130-0x0000000180134170
		[SerializeField] // 0x0000000180134130-0x0000000180134170
		private float animSpeedMultiplier; // 0x74
		protected Animator animator; // 0x78
		private Vector3 lastForward; // 0x80
		private const string groundedDirectional = "Grounded Directional"; // Metadata: 0x00652DC9
		private const string groundedStrafe = "Grounded Strafe"; // Metadata: 0x00652DE1
		private float deltaAngle; // 0x8C
	
		// Properties
		public override bool animationGrounded { get => default; } // 0x00000001804BE700-0x00000001804BE7F0 
	
		// Constructors
		public CharacterAnimationThirdPerson() {} // 0x00000001804BDF60-0x00000001804BDF90
	
		// Methods
		protected override void Start() {} // 0x00000001804BE190-0x00000001804BE220
		public override Vector3 GetPivotPoint() => default; // 0x00000001804BDF90-0x00000001804BDFD0
		protected virtual void Update() {} // 0x00000001804BE220-0x00000001804BE700
		private void OnAnimatorMove() {} // 0x00000001804BDFD0-0x00000001804BE190
	}
}
