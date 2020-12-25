/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using RootMotion.FinalIK;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	public class FPSAiming : MonoBehaviour // TypeDefIndex: 6615
	{
		// Fields
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float aimWeight; // 0x18
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float sightWeight; // 0x1C
		// [Range] // 0x00000001800F6E60-0x00000001800F6E80
		public float maxAngle; // 0x20
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private bool animatePhysics; // 0x24
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform gun; // 0x28
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Transform gunTarget; // 0x30
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private FullBodyBipedIK ik; // 0x38
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private AimIK gunAim; // 0x40
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private CameraControllerFPS cam; // 0x48
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Recoil recoil; // 0x50
		// [Range] // 0x0000000180114160-0x00000001801141A0
		[SerializeField] // 0x0000000180114160-0x00000001801141A0
		private float cameraRecoilWeight; // 0x58
		private Vector3 gunTargetDefaultLocalPosition; // 0x5C
		private Quaternion gunTargetDefaultLocalRotation; // 0x68
		private Vector3 camDefaultLocalPosition; // 0x78
		private Vector3 camRelativeToGunTarget; // 0x84
		private bool updateFrame; // 0x90
	
		// Constructors
		public FPSAiming() {} // 0x00000001804C6570-0x00000001804C65A0
	
		// Methods
		private void Start() {} // 0x00000001804C63E0-0x00000001804C6570
		private void FixedUpdate() {} // 0x00000001804C51F0-0x00000001804C5200
		private void LateUpdate() {} // 0x00000001804C5200-0x00000001804C5320
		private void Aiming() {} // 0x00000001804C4FC0-0x00000001804C51F0
		private void LookDownTheSight() {} // 0x00000001804C5320-0x00000001804C6080
		private void RotateCharacter() {} // 0x00000001804C6080-0x00000001804C63E0
	}
}
