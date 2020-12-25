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
	public class SimpleAimingSystem : MonoBehaviour // TypeDefIndex: 6593
	{
		// Fields
		// [Tooltip] // 0x000000018012B140-0x000000018012B170
		public AimPoser aimPoser; // 0x18
		// [Tooltip] // 0x00000001800F89E0-0x00000001800F8A10
		public AimIK aim; // 0x20
		// [Tooltip] // 0x000000018012B230-0x000000018012B260
		public LookAtIK lookAt; // 0x28
		// [Tooltip] // 0x000000018012B3B0-0x000000018012B3E0
		public Animator animator; // 0x30
		// [Tooltip] // 0x000000018012B470-0x000000018012B4A0
		public float crossfadeTime; // 0x38
		// [Tooltip] // 0x000000018012B590-0x000000018012B5C0
		public float minAimDistance; // 0x3C
		private AimPoser.Pose aimPose; // 0x40
		private AimPoser.Pose lastPose; // 0x48
	
		// Constructors
		public SimpleAimingSystem() {} // 0x000000018053B8C0-0x000000018053B8E0
	
		// Methods
		private void Start() {} // 0x000000018053B880-0x000000018053B8C0
		private void LateUpdate() {} // 0x000000018053B0A0-0x000000018053B1E0
		private void Pose() {} // 0x000000018053B470-0x000000018053B880
		private void LimitAimTarget() {} // 0x000000018053B1E0-0x000000018053B470
		private void DirectCrossFade(string state, float target) {} // 0x000000018053AFB0-0x000000018053B0A0
	}
}
