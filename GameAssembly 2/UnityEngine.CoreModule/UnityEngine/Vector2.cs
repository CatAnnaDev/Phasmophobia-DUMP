/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeClass] // 0x00000001800F0E60-0x00000001800F0EE0
	[RequiredByNativeCode] // 0x00000001800F0E60-0x00000001800F0EE0
	public struct Vector2 : IEquatable<UnityEngine.Vector2> // TypeDefIndex: 3226
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		private static readonly Vector2 zeroVector; // 0x00
		private static readonly Vector2 oneVector; // 0x08
		private static readonly Vector2 upVector; // 0x10
		private static readonly Vector2 downVector; // 0x18
		private static readonly Vector2 leftVector; // 0x20
		private static readonly Vector2 rightVector; // 0x28
		private static readonly Vector2 positiveInfinityVector; // 0x30
		private static readonly Vector2 negativeInfinityVector; // 0x38
		public const float kEpsilon = 1E-05f; // Metadata: 0x0064C143
		public const float kEpsilonNormalSqrt = 1E-15f; // Metadata: 0x0064C147
	
		// Properties
		public float this[int index] { get => default; set {} } // 0x0000000180036080-0x0000000180036110 0x0000000180036170-0x0000000180036210
		public Vector2 normalized { get => default; } // 0x0000000180036120-0x0000000180036150 
		public float magnitude { get => default; } // 0x0000000180036110-0x0000000180036120 
		public float sqrMagnitude { get => default; } // 0x0000000180036150-0x0000000180036170 
		public static Vector2 zero { get => default; } // 0x00000001808E7B00-0x00000001808E7B70 
		public static Vector2 one { get => default; } // 0x00000001808E7990-0x00000001808E7A00 
		public static Vector2 up { get => default; } // 0x00000001808E7A90-0x00000001808E7B00 
		public static Vector2 right { get => default; } // 0x00000001808E7A00-0x00000001808E7A90 
	
		// Constructors
		public Vector2(float x, float y) : this() {
			this.x = default;
			this.y = default;
		} // 0x0000000180036070-0x0000000180036080
		static Vector2() {
			zeroVector = default;
			oneVector = default;
			upVector = default;
			downVector = default;
			leftVector = default;
			rightVector = default;
			positiveInfinityVector = default;
			negativeInfinityVector = default;
		} // 0x00000001808E7750-0x00000001808E7990
	
		// Methods
		public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) => default; // 0x00000001808E74C0-0x00000001808E7710
		public static Vector2 Scale(Vector2 a, Vector2 b) => default; // 0x00000001808E7710-0x00000001808E7750
		public void Normalize() {} // 0x0000000180035F00-0x0000000180035F10
		public override string ToString() => default; // 0x0000000180035F10-0x0000000180036070
		public override int GetHashCode() => default; // 0x0000000180035EC0-0x0000000180035F00
		public override bool Equals(object other) => default; // 0x0000000180035DF0-0x0000000180035E90
		public bool Equals(Vector2 other) => default; // 0x0000000180035E90-0x0000000180035EC0
		public static float Dot(Vector2 lhs, Vector2 rhs) => default; // 0x00000001808E7380-0x00000001808E74C0
		public static float Distance(Vector2 a, Vector2 b) => default; // 0x00000001808E72F0-0x00000001808E7380
		public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) => default; // 0x00000001808E71F0-0x00000001808E72F0
		public static Vector2 operator +(Vector2 a, Vector2 b) => default; // 0x00000001808E7B70-0x00000001808E7BB0
		public static Vector2 operator -(Vector2 a, Vector2 b) => default; // 0x00000001808E7D80-0x00000001808E7E60
		public static Vector2 operator *(Vector2 a, Vector2 b) => default; // 0x00000001808E7710-0x00000001808E7750
		public static Vector2 operator /(Vector2 a, Vector2 b) => default; // 0x00000001808E7BE0-0x00000001808E7C20
		public static Vector2 operator *(Vector2 a, float d) => default; // 0x00000001808E7D50-0x00000001808E7D80
		public static Vector2 operator /(Vector2 a, float d) => default; // 0x00000001808E7BB0-0x00000001808E7BE0
		public static bool operator ==(Vector2 lhs, Vector2 rhs) => default; // 0x00000001808E7C20-0x00000001808E7C70
		public static bool operator !=(Vector2 lhs, Vector2 rhs) => default; // 0x00000001808E7CD0-0x00000001808E7D50
		public static implicit operator Vector2(Vector3 v) => default; // 0x00000001808E7CB0-0x00000001808E7CD0
		public static implicit operator Vector3(Vector2 v) => default; // 0x00000001808E7C70-0x00000001808E7CB0
	}
}
