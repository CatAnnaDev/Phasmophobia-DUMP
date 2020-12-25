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
	// [RequireComponent] // 0x000000018012DD30-0x000000018012DD80
	public class AnimatorController3rdPerson : MonoBehaviour // TypeDefIndex: 6604
	{
		// Fields
		public float rotateSpeed; // 0x18
		public float blendSpeed; // 0x1C
		public float maxAngle; // 0x20
		public float moveSpeed; // 0x24
		public float rootMotionWeight; // 0x28
		protected Animator animator; // 0x30
		protected Vector3 moveBlend; // 0x38
		protected Vector3 moveInput; // 0x44
		protected Vector3 velocity; // 0x50
	
		// Constructors
		public AnimatorController3rdPerson() {} // 0x00000001804B12B0-0x00000001804B12E0
	
		// Methods
		protected virtual void Start() {} // 0x00000001804B1260-0x00000001804B12B0
		private void OnAnimatorMove() {} // 0x00000001804B0FA0-0x00000001804B1260
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget) {} // 0x00000001804B0CC0-0x00000001804B0FA0
	}
}
