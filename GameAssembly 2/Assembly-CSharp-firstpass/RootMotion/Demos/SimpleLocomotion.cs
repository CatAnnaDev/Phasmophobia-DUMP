/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.Demos
{
	// [RequireComponent] // 0x0000000180135680-0x00000001801356D0
	public class SimpleLocomotion : MonoBehaviour // TypeDefIndex: 6661
	{
		// Fields
		[SerializeField] // 0x0000000180135860-0x00000001801358B0
		// [Tooltip] // 0x0000000180135860-0x00000001801358B0
		private CameraController cameraController; // 0x18
		[SerializeField] // 0x0000000180135920-0x0000000180135970
		// [Tooltip] // 0x0000000180135920-0x0000000180135970
		private float accelerationTime; // 0x20
		[SerializeField] // 0x0000000180135AF0-0x0000000180135B40
		// [Tooltip] // 0x0000000180135AF0-0x0000000180135B40
		private float turnTime; // 0x24
		[SerializeField] // 0x0000000180135C60-0x0000000180135CB0
		// [Tooltip] // 0x0000000180135C60-0x0000000180135CB0
		private bool walkByDefault; // 0x28
		[SerializeField] // 0x0000000180135D60-0x0000000180135DB0
		// [Tooltip] // 0x0000000180135D60-0x0000000180135DB0
		private RotationMode rotationMode; // 0x2C
		[SerializeField] // 0x0000000180135E50-0x0000000180135EA0
		// [Tooltip] // 0x0000000180135E50-0x0000000180135EA0
		private float moveSpeed; // 0x30
		private Animator animator; // 0x38
		private float speed; // 0x40
		private float angleVel; // 0x44
		private float speedVel; // 0x48
		private Vector3 linearTargetDirection; // 0x4C
		private CharacterController characterController; // 0x58
	
		// Properties
		public bool isGrounded { get; private set; } // 0x000000018053C3D0-0x000000018053C3E0 0x000000018053C3E0-0x000000018053C3F0
	
		// Nested types
		[Serializable]
		public enum RotationMode // TypeDefIndex: 6662
		{
			Smooth = 0,
			Linear = 1
		}
	
		// Constructors
		public SimpleLocomotion() {} // 0x000000018053C3B0-0x000000018053C3D0
	
		// Methods
		private void Start() {} // 0x000000018053C2D0-0x000000018053C350
		private void Update() {} // 0x000000018053C350-0x000000018053C3B0
		private void LateUpdate() {} // 0x000000018053BA70-0x000000018053BAB0
		private void Rotate() {} // 0x000000018053BDD0-0x000000018053C2D0
		private void Move() {} // 0x000000018053BAB0-0x000000018053BDD0
		private Vector3 GetInputVector() => default; // 0x000000018053B960-0x000000018053BA70
		private Vector3 GetInputVectorRaw() => default; // 0x000000018053B8E0-0x000000018053B960
	}
}
