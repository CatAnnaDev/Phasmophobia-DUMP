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
	// [RequireComponent] // 0x00000001801341C0-0x0000000180134240
	// [RequireComponent] // 0x00000001801341C0-0x0000000180134240
	public abstract class CharacterBase : MonoBehaviour // TypeDefIndex: 6657
	{
		// Fields
		// [Header] // 0x0000000180134330-0x0000000180134390
		// [Tooltip] // 0x0000000180134330-0x0000000180134390
		public Transform gravityTarget; // 0x18
		[SerializeField] // 0x0000000180134550-0x00000001801345A0
		// [Tooltip] // 0x0000000180134550-0x00000001801345A0
		protected float gravityMultiplier; // 0x20
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		protected float airborneThreshold; // 0x24
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float slopeStartAngle; // 0x28
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float slopeEndAngle; // 0x2C
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float spherecastRadius; // 0x30
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private LayerMask groundLayers; // 0x34
		private PhysicMaterial zeroFrictionMaterial; // 0x38
		private PhysicMaterial highFrictionMaterial; // 0x40
		protected Rigidbody r; // 0x48
		protected const float half = 0.5f; // Metadata: 0x00652DF4
		protected float originalHeight; // 0x50
		protected Vector3 originalCenter; // 0x54
		protected CapsuleCollider capsule; // 0x60
	
		// Constructors
		protected CharacterBase() {} // 0x00000001804BF560-0x00000001804BF590
	
		// Methods
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);
		protected Vector3 GetGravity() => default; // 0x00000001804BE8B0-0x00000001804BEA80
		protected virtual void Start() {} // 0x00000001804BF340-0x00000001804BF530
		protected virtual RaycastHit GetSpherecastHit() => default; // 0x00000001804BEB90-0x00000001804BEEE0
		public float GetAngleFromForward(Vector3 worldDirection) => default; // 0x00000001804BE7F0-0x00000001804BE8B0
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle) {} // 0x00000001804BEF10-0x00000001804BF120
		protected void ScaleCapsule(float mlp) {} // 0x00000001804BF120-0x00000001804BF340
		protected void HighFriction() {} // 0x00000001804BEEE0-0x00000001804BEF10
		protected void ZeroFriction() {} // 0x00000001804BF530-0x00000001804BF560
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal) => default; // 0x00000001804BEA80-0x00000001804BEB90
	}
}
