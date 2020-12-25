/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR.InteractionSystem
{
	public class VelocityEstimator : MonoBehaviour // TypeDefIndex: 8405
	{
		// Fields
		// [Tooltip] // 0x0000000180146240-0x0000000180146270
		public int velocityAverageFrames; // 0x18
		// [Tooltip] // 0x0000000180146310-0x0000000180146340
		public int angularVelocityAverageFrames; // 0x1C
		public bool estimateOnAwake; // 0x20
		private Coroutine routine; // 0x28
		private int sampleCount; // 0x30
		private Vector3[] velocitySamples; // 0x38
		private Vector3[] angularVelocitySamples; // 0x40
	
		// Constructors
		public VelocityEstimator() {} // 0x0000000180EF72A0-0x0000000180EF72C0
	
		// Methods
		public void BeginEstimatingVelocity() {} // 0x0000000180EF6AD0-0x0000000180EF6B80
		public void FinishEstimatingVelocity() {} // 0x0000000180EF6BF0-0x0000000180EF6C30
		public Vector3 GetVelocityEstimate() => default; // 0x0000000180EF70B0-0x0000000180EF72A0
		public Vector3 GetAngularVelocityEstimate() => default; // 0x0000000180EF6EC0-0x0000000180EF70B0
		public Vector3 GetAccelerationEstimate() => default; // 0x0000000180EF6C30-0x0000000180EF6EC0
		private void Awake() {} // 0x0000000180EF6A50-0x0000000180EF6AD0
		// [IteratorStateMachine] // 0x0000000180146440-0x0000000180146490
		private IEnumerator EstimateVelocityCoroutine() => default; // 0x0000000180EF6B80-0x0000000180EF6BF0
	}
}
