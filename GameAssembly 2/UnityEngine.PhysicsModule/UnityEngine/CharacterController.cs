/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 8: UnityEngine.PhysicsModule.dll - Assembly: UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3646-3679

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180133570-0x00000001801335A0
	public class CharacterController : Collider // TypeDefIndex: 3665
	{
		// Properties
		public Vector3 velocity { get => default; } // 0x0000000180ACA0A0-0x0000000180ACA110 
		public bool isGrounded { /* [NativeName] */ /* 0x00000001801335A0-0x00000001801335D0 */ get => default; } // 0x0000000180AC9F90-0x0000000180AC9FD0 
		public float radius { get => default; } // 0x0000000180AC9FD0-0x0000000180ACA010 
		public float height { get => default; } // 0x0000000180AC9F50-0x0000000180AC9F90 
		public float skinWidth { get => default; } // 0x0000000180ACA010-0x0000000180ACA050 
	
		// Constructors
		public CharacterController() {} // Dummy constructor
	
		// Methods
		public bool SimpleMove(Vector3 speed) => default; // 0x0000000180AC9F00-0x0000000180AC9F50
		public CollisionFlags Move(Vector3 motion) => default; // 0x0000000180AC9E60-0x0000000180AC9EB0
		private bool SimpleMove_Injected(ref Vector3 speed) => default; // 0x0000000180AC9EB0-0x0000000180AC9F00
		private CollisionFlags Move_Injected(ref Vector3 motion) => default; // 0x0000000180AC9E10-0x0000000180AC9E60
		private void get_velocity_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180ACA050-0x0000000180ACA0A0
	}
}
