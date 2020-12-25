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
	public class AimController : MonoBehaviour // TypeDefIndex: 6789
	{
		// Fields
		// [Tooltip] // 0x00000001800F89E0-0x00000001800F8A10
		public AimIK ik; // 0x18
		// [Range] // 0x00000001800F8B60-0x00000001800F8BC0
		// [Tooltip] // 0x00000001800F8B60-0x00000001800F8BC0
		public float weight; // 0x20
		// [Header] // 0x00000001800F8DC0-0x00000001800F8E20
		// [Tooltip] // 0x00000001800F8DC0-0x00000001800F8E20
		public Transform target; // 0x28
		// [Tooltip] // 0x00000001800F90A0-0x00000001800F90D0
		public float targetSwitchSmoothTime; // 0x30
		// [Tooltip] // 0x00000001800F9140-0x00000001800F9170
		public float weightSmoothTime; // 0x34
		// [Header] // 0x00000001800F92E0-0x00000001800F9340
		// [Tooltip] // 0x00000001800F92E0-0x00000001800F9340
		public bool smoothTurnTowardsTarget; // 0x38
		// [Tooltip] // 0x00000001800F9480-0x00000001800F94B0
		public float maxRadiansDelta; // 0x3C
		// [Tooltip] // 0x00000001800F95F0-0x00000001800F9620
		public float maxMagnitudeDelta; // 0x40
		// [Tooltip] // 0x00000001800F96B0-0x00000001800F96E0
		public float slerpSpeed; // 0x44
		// [Tooltip] // 0x00000001800F9830-0x00000001800F9860
		public Vector3 pivotOffsetFromRoot; // 0x48
		// [Tooltip] // 0x00000001800F9940-0x00000001800F9970
		public float minDistance; // 0x54
		// [Tooltip] // 0x00000001800F99F0-0x00000001800F9A20
		public Vector3 offset; // 0x58
		// [Header] // 0x00000001800F9AF0-0x00000001800F9B70
		// [Range] // 0x00000001800F9AF0-0x00000001800F9B70
		// [Tooltip] // 0x00000001800F9AF0-0x00000001800F9B70
		public float maxRootAngle; // 0x64
		// [Header] // 0x00000001800F9C50-0x00000001800F9CB0
		// [Tooltip] // 0x00000001800F9C50-0x00000001800F9CB0
		public bool useAnimatedAimDirection; // 0x68
		// [Tooltip] // 0x00000001800F9DC0-0x00000001800F9DF0
		public Vector3 animatedAimDirection; // 0x6C
		private Transform lastTarget; // 0x78
		private float switchWeight; // 0x80
		private float switchWeightV; // 0x84
		private float weightV; // 0x88
		private Vector3 lastPosition; // 0x8C
		private Vector3 dir; // 0x98
		private bool lastSmoothTowardsTarget; // 0xA4
	
		// Properties
		private Vector3 pivot { get => default; } // 0x00000001805207F0-0x0000000180520980 
	
		// Constructors
		public AimController() {} // 0x0000000180520720-0x00000001805207F0
	
		// Methods
		private void Start() {} // 0x00000001805205D0-0x0000000180520720
		private void LateUpdate() {} // 0x000000018051F760-0x0000000180520270
		private void ApplyMinDistance() {} // 0x000000018051F550-0x000000018051F760
		private void RootRotation() {} // 0x0000000180520270-0x00000001805205D0
	}
}
