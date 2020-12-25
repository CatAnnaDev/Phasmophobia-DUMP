/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion
{
	public class CameraController : MonoBehaviour // TypeDefIndex: 6565
	{
		// Fields
		public Transform target; // 0x18
		public Transform rotationSpace; // 0x20
		public UpdateMode updateMode; // 0x28
		public bool lockCursor; // 0x2C
		// [Header] // 0x0000000180127D90-0x0000000180127DC0
		public bool smoothFollow; // 0x2D
		public Vector3 offset; // 0x30
		public float followSpeed; // 0x3C
		// [Header] // 0x0000000180127E40-0x0000000180127E70
		public float rotationSensitivity; // 0x40
		public float yMinLimit; // 0x44
		public float yMaxLimit; // 0x48
		public bool rotateAlways; // 0x4C
		public bool rotateOnLeftButton; // 0x4D
		public bool rotateOnRightButton; // 0x4E
		public bool rotateOnMiddleButton; // 0x4F
		// [Header] // 0x00000001801282C0-0x00000001801282F0
		public float distance; // 0x50
		public float minDistance; // 0x54
		public float maxDistance; // 0x58
		public float zoomSpeed; // 0x5C
		public float zoomSensitivity; // 0x60
		// [Header] // 0x0000000180128340-0x0000000180128370
		public LayerMask blockingLayers; // 0x64
		public float blockingRadius; // 0x68
		public float blockingSmoothTime; // 0x6C
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float blockedOffset; // 0x70
		private Vector3 targetDistance; // 0x80
		private Vector3 position; // 0x8C
		private Quaternion rotation; // 0x98
		private Vector3 smoothPosition; // 0xA8
		private Camera cam; // 0xB8
		private bool fixedFrame; // 0xC0
		private float fixedDeltaTime; // 0xC4
		private Quaternion r; // 0xC8
		private Vector3 lastUp; // 0xD8
		private float blockedDistance; // 0xE4
		private float blockedDistanceV; // 0xE8
	
		// Properties
		public float x { get; private set; } // 0x00000001804BCE60-0x00000001804BCE70 0x00000001804BCEF0-0x00000001804BCF00
		public float y { get; private set; } // 0x00000001804BCE70-0x00000001804BCE80 0x00000001804BCF00-0x00000001804BCF10
		public float distanceTarget { get; private set; } // 0x00000001804BCE50-0x00000001804BCE60 0x00000001804BCEE0-0x00000001804BCEF0
		private float zoomAdd { get => default; } // 0x00000001804BCE80-0x00000001804BCEE0 
	
		// Nested types
		[Serializable]
		public enum UpdateMode // TypeDefIndex: 6566
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2,
			FixedLateUpdate = 3
		}
	
		// Constructors
		public CameraController() {} // 0x00000001804BCD20-0x00000001804BCE50
	
		// Methods
		protected virtual void Awake() {} // 0x00000001804BBFF0-0x00000001804BC160
		protected virtual void Update() {} // 0x00000001804BCCF0-0x00000001804BCD20
		protected virtual void FixedUpdate() {} // 0x00000001804BC200-0x00000001804BC260
		protected virtual void LateUpdate() {} // 0x00000001804BC260-0x00000001804BC2D0
		public void UpdateInput() {} // 0x00000001804BC2D0-0x00000001804BC510
		public void UpdateTransform() {} // 0x00000001804BCCC0-0x00000001804BCCF0
		public void UpdateTransform(float deltaTime) {} // 0x00000001804BC510-0x00000001804BCCC0
		private float ClampAngle(float angle, float min, float max) => default; // 0x00000001804BC160-0x00000001804BC200
	}
}
