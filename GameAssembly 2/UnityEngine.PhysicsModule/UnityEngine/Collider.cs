/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 8: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3646-3679

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001801331F0-0x0000000180133280
	// [RequireComponent] // 0x00000001801331F0-0x0000000180133280
	[RequiredByNativeCode] // 0x00000001801331F0-0x0000000180133280
	public class Collider : Component // TypeDefIndex: 3664
	{
		// Properties
		public bool enabled { get => default; set {} } // 0x0000000180ACA500-0x0000000180ACA540 0x0000000180ACA5C0-0x0000000180ACA610
		public Rigidbody attachedRigidbody { [NativeMethod] /* 0x00000001801333D0-0x0000000180133400 */ get => default; } // 0x0000000180ACA400-0x0000000180ACA440 
		public bool isTrigger { get => default; set {} } // 0x0000000180ACA540-0x0000000180ACA580 0x0000000180ACA610-0x0000000180ACA660
		public Bounds bounds { get => default; } // 0x0000000180ACA490-0x0000000180ACA500 
		[NativeMethod] // 0x00000001801334E0-0x0000000180133510
		public PhysicMaterial sharedMaterial { get => default; } // 0x0000000180ACA580-0x0000000180ACA5C0 
		public PhysicMaterial material { [NativeMethod] /* 0x00000001801334B0-0x00000001801334E0 */ set {} } // 0x0000000180ACA660-0x0000000180ACA6B0
	
		// Constructors
		public Collider() {} // 0x00000001808E4F10-0x00000001808E4F20
	
		// Methods
		public Vector3 ClosestPoint(Vector3 position) => default; // 0x0000000180ACA170-0x0000000180ACA1F0
		private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) => default; // 0x0000000180ACA260-0x0000000180ACA320
		public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) {
			hitInfo = default;
			return default;
		} // 0x0000000180ACA320-0x0000000180ACA400
		private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x0000000180ACA110-0x0000000180ACA170
		private void get_bounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x0000000180ACA440-0x0000000180ACA490
		private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) {
			ret = default;
		} // 0x0000000180ACA1F0-0x0000000180ACA260
	}
}
