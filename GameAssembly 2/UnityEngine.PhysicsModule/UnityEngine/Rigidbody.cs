/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

// Image 8: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3646-3679

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180132110-0x0000000180132190
	// [RequireComponent] // 0x0000000180132110-0x0000000180132190
	public class Rigidbody : Component // TypeDefIndex: 3663
	{
		// Properties
		public Vector3 velocity { get => default; set {} } // 0x0000000180AD2770-0x0000000180AD27E0 0x0000000180AD2E10-0x0000000180AD2E60
		public Vector3 angularVelocity { get => default; set {} } // 0x0000000180AD2340-0x0000000180AD23B0 0x0000000180AD2940-0x0000000180AD2990
		public float drag { get => default; set {} } // 0x0000000180AD2470-0x0000000180AD24B0 0x0000000180AD2A60-0x0000000180AD2AB0
		public float angularDrag { get => default; set {} } // 0x0000000180AD22B0-0x0000000180AD22F0 0x0000000180AD28A0-0x0000000180AD28F0
		public float mass { set {} } // 0x0000000180AD2B90-0x0000000180AD2BE0
		public bool useGravity { get => default; set {} } // 0x0000000180AD26E0-0x0000000180AD2720 0x0000000180AD2D70-0x0000000180AD2DC0
		public bool isKinematic { get => default; set {} } // 0x0000000180AD24F0-0x0000000180AD2530 0x0000000180AD2B40-0x0000000180AD2B90
		public bool freezeRotation { set {} } // 0x0000000180AD2AB0-0x0000000180AD2B00
		public RigidbodyConstraints constraints { set {} } // 0x0000000180AD29D0-0x0000000180AD2A10
		public CollisionDetectionMode collisionDetectionMode { set {} } // 0x0000000180AD2990-0x0000000180AD29D0
		public Vector3 centerOfMass { get => default; } // 0x0000000180AD2400-0x0000000180AD2470 
		public Vector3 worldCenterOfMass { get => default; } // 0x0000000180AD2830-0x0000000180AD28A0 
		public bool detectCollisions { set {} } // 0x0000000180AD2A10-0x0000000180AD2A60
		public Vector3 position { get => default; set {} } // 0x0000000180AD25C0-0x0000000180AD2630 0x0000000180AD2C80-0x0000000180AD2CD0
		public Quaternion rotation { get => default; set {} } // 0x0000000180AD2680-0x0000000180AD26E0 0x0000000180AD2D20-0x0000000180AD2D70
		public RigidbodyInterpolation interpolation { get => default; set {} } // 0x0000000180AD24B0-0x0000000180AD24F0 0x0000000180AD2B00-0x0000000180AD2B40
		public float maxAngularVelocity { get => default; set {} } // 0x0000000180AD2530-0x0000000180AD2570 0x0000000180AD2BE0-0x0000000180AD2C30
	
		// Constructors
		public Rigidbody() {} // 0x00000001808E4F10-0x00000001808E4F20
	
		// Methods
		public void MovePosition(Vector3 position) {} // 0x0000000180AD2140-0x0000000180AD2190
		public void MoveRotation(Quaternion rot) {} // 0x0000000180AD21E0-0x0000000180AD2230
		public void Sleep() {} // 0x0000000180AD2230-0x0000000180AD2270
		public void WakeUp() {} // 0x0000000180AD2270-0x0000000180AD22B0
		public Vector3 GetPointVelocity(Vector3 worldPoint) => default; // 0x0000000180AD2070-0x0000000180AD20F0
		public void AddForce(Vector3 force, [DefaultValue] /* 0x00000001801322E0-0x0000000180132310 */ ForceMode mode) {} // 0x0000000180AD1CD0-0x0000000180AD1D30
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void AddForce(Vector3 force) {} // 0x0000000180AD1C80-0x0000000180AD1CD0
		public void AddRelativeForce(Vector3 force, [DefaultValue] /* 0x00000001801322E0-0x0000000180132310 */ ForceMode mode) {} // 0x0000000180AD1DE0-0x0000000180AD1E40
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void AddRelativeForce(Vector3 force) {} // 0x0000000180AD1D90-0x0000000180AD1DE0
		public void AddTorque(Vector3 torque, [DefaultValue] /* 0x00000001801322E0-0x0000000180132310 */ ForceMode mode) {} // 0x0000000180AD1F60-0x0000000180AD1FC0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void AddTorque(Vector3 torque) {} // 0x0000000180AD1FC0-0x0000000180AD2010
		public void AddRelativeTorque(Vector3 torque, [DefaultValue] /* 0x00000001801322E0-0x0000000180132310 */ ForceMode mode) {} // 0x0000000180AD1EA0-0x0000000180AD1F00
		public void AddForceAtPosition(Vector3 force, Vector3 position, [DefaultValue] /* 0x00000001801322E0-0x0000000180132310 */ ForceMode mode) {} // 0x0000000180AD1BB0-0x0000000180AD1C20
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void AddForceAtPosition(Vector3 force, Vector3 position) {} // 0x0000000180AD1B40-0x0000000180AD1BB0
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, [DefaultValue] /* 0x000000018012F090-0x000000018012F0C0 */ float upwardsModifier, [DefaultValue] /* 0x0000000180132CD0-0x0000000180132D00 */ ForceMode mode) {} // 0x0000000180AD1A50-0x0000000180AD1AD0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) {} // 0x0000000180AD19D0-0x0000000180AD1A50
		private void get_velocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180AD2720-0x0000000180AD2770
		private void set_velocity_Injected(ref Vector3 value) {} // 0x0000000180AD2DC0-0x0000000180AD2E10
		private void get_angularVelocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180AD22F0-0x0000000180AD2340
		private void set_angularVelocity_Injected(ref Vector3 value) {} // 0x0000000180AD28F0-0x0000000180AD2940
		private void get_centerOfMass_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180AD23B0-0x0000000180AD2400
		private void get_worldCenterOfMass_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180AD27E0-0x0000000180AD2830
		private void get_position_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180AD2570-0x0000000180AD25C0
		private void set_position_Injected(ref Vector3 value) {} // 0x0000000180AD2C30-0x0000000180AD2C80
		private void get_rotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x0000000180AD2630-0x0000000180AD2680
		private void set_rotation_Injected(ref Quaternion value) {} // 0x0000000180AD2CD0-0x0000000180AD2D20
		private void MovePosition_Injected(ref Vector3 position) {} // 0x0000000180AD20F0-0x0000000180AD2140
		private void MoveRotation_Injected(ref Quaternion rot) {} // 0x0000000180AD2190-0x0000000180AD21E0
		private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret) {
			ret = default;
		} // 0x0000000180AD2010-0x0000000180AD2070
		private void AddForce_Injected(ref Vector3 force, [DefaultValue] /* 0x00000001801322E0-0x0000000180132310 */ ForceMode mode) {} // 0x0000000180AD1C20-0x0000000180AD1C80
		private void AddRelativeForce_Injected(ref Vector3 force, [DefaultValue] /* 0x00000001801322E0-0x0000000180132310 */ ForceMode mode) {} // 0x0000000180AD1D30-0x0000000180AD1D90
		private void AddTorque_Injected(ref Vector3 torque, [DefaultValue] /* 0x00000001801322E0-0x0000000180132310 */ ForceMode mode) {} // 0x0000000180AD1F00-0x0000000180AD1F60
		private void AddRelativeTorque_Injected(ref Vector3 torque, [DefaultValue] /* 0x00000001801322E0-0x0000000180132310 */ ForceMode mode) {} // 0x0000000180AD1E40-0x0000000180AD1EA0
		private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, [DefaultValue] /* 0x00000001801322E0-0x0000000180132310 */ ForceMode mode) {} // 0x0000000180AD1AD0-0x0000000180AD1B40
		private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, [DefaultValue] /* 0x000000018012F090-0x000000018012F0C0 */ float upwardsModifier, [DefaultValue] /* 0x0000000180132CD0-0x0000000180132D00 */ ForceMode mode) {} // 0x0000000180AD1960-0x0000000180AD19D0
	}
}
