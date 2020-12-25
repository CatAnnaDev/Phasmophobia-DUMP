/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

// Image 16: UnityEngine.Physics2DModule.dll - Assembly: UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3789-3798

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001801140E0-0x0000000180114160
	// [RequireComponent] // 0x00000001801140E0-0x0000000180114160
	public sealed class Rigidbody2D : Component // TypeDefIndex: 3797
	{
		// Properties
		public Vector2 position { get => default; set {} } // 0x0000000180AF1300-0x0000000180AF1350 0x0000000180AF14D0-0x0000000180AF1510
		public float rotation { get => default; set {} } // 0x0000000180AF1350-0x0000000180AF1390 0x0000000180AF1510-0x0000000180AF1560
		public Vector2 velocity { get => default; set {} } // 0x0000000180AF13E0-0x0000000180AF1430 0x0000000180AF15B0-0x0000000180AF15F0
		public float angularVelocity { get => default; set {} } // 0x0000000180AF1270-0x0000000180AF12B0 0x0000000180AF1430-0x0000000180AF1480
	
		// Constructors
		public Rigidbody2D() {} // Dummy constructor
	
		// Methods
		public void MoveRotation(float angle) {} // 0x0000000180AF1220-0x0000000180AF1270
		[NativeMethod] // 0x0000000180114300-0x0000000180114330
		private void MoveRotation_Angle(float angle) {} // 0x0000000180AF1220-0x0000000180AF1270
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void AddForce(Vector2 force) {} // 0x0000000180AF11E0-0x0000000180AF1220
		public void AddForce(Vector2 force, [DefaultValue] /* 0x00000001801143C0-0x00000001801143F0 */ ForceMode2D mode) {} // 0x0000000180AF1190-0x0000000180AF11E0
		private void get_position_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180AF12B0-0x0000000180AF1300
		private void set_position_Injected(ref Vector2 value) {} // 0x0000000180AF1480-0x0000000180AF14D0
		private void get_velocity_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180AF1390-0x0000000180AF13E0
		private void set_velocity_Injected(ref Vector2 value) {} // 0x0000000180AF1560-0x0000000180AF15B0
		private void AddForce_Injected(ref Vector2 force, [DefaultValue] /* 0x00000001801143C0-0x00000001801143F0 */ ForceMode2D mode) {} // 0x0000000180AF1130-0x0000000180AF1190
	}
}
