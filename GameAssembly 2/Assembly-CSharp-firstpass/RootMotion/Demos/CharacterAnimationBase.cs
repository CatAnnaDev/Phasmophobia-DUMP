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
	public abstract class CharacterAnimationBase : MonoBehaviour // TypeDefIndex: 6654
	{
		// Fields
		public bool smoothFollow; // 0x18
		public float smoothFollowSpeed; // 0x1C
		protected bool animatePhysics; // 0x20
		private Vector3 lastPosition; // 0x24
		private Vector3 localPosition; // 0x30
		private Quaternion localRotation; // 0x3C
		private Quaternion lastRotation; // 0x4C
	
		// Properties
		public virtual bool animationGrounded { get; } // 0x0000000180246BB0-0x0000000180246BC0 
	
		// Constructors
		protected CharacterAnimationBase() {} // 0x00000001804BD5B0-0x00000001804BD5D0
	
		// Methods
		public virtual Vector3 GetPivotPoint() => default; // 0x00000001804BCFE0-0x00000001804BD030
		public float GetAngleFromForward(Vector3 worldDirection) => default; // 0x00000001804BCF20-0x00000001804BCFE0
		protected virtual void Start() {} // 0x00000001804BD320-0x00000001804BD5B0
		protected virtual void LateUpdate() {} // 0x00000001804BD030-0x00000001804BD040
		protected virtual void FixedUpdate() {} // 0x00000001804BCF10-0x00000001804BCF20
		private void SmoothFollow() {} // 0x00000001804BD040-0x00000001804BD320
	}
}
