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
	public class ExplosionDemo : MonoBehaviour // TypeDefIndex: 6609
	{
		// Fields
		public SimpleLocomotion character; // 0x18
		public float forceMlp; // 0x20
		public float upForce; // 0x24
		public float weightFalloffSpeed; // 0x28
		public AnimationCurve weightFalloff; // 0x30
		public AnimationCurve explosionForceByDistance; // 0x38
		public AnimationCurve scale; // 0x40
		private float weight; // 0x48
		private Vector3 defaultScale; // 0x4C
		private Rigidbody r; // 0x58
		private FullBodyBipedIK ik; // 0x60
	
		// Constructors
		public ExplosionDemo() {} // 0x00000001804C40B0-0x00000001804C4140
	
		// Methods
		private void Start() {} // 0x00000001804C3930-0x00000001804C39E0
		private void Update() {} // 0x00000001804C39E0-0x00000001804C40B0
		private void SetEffectorWeights(float w) {} // 0x00000001804C3870-0x00000001804C3930
	}
}
