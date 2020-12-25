/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeClass] // 0x00000001800F1110-0x00000001800F11B0
	// [NativeHeader] // 0x00000001800F1110-0x00000001800F11B0
	[RequiredByNativeCode] // 0x00000001800F1110-0x00000001800F11B0
	public struct Vector4 : IEquatable<UnityEngine.Vector4> // TypeDefIndex: 3228
	{
		// Fields
		public const float kEpsilon = 1E-05f; // Metadata: 0x0064C14B
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
		private static readonly Vector4 zeroVector; // 0x00
		private static readonly Vector4 oneVector; // 0x10
		private static readonly Vector4 positiveInfinityVector; // 0x20
		private static readonly Vector4 negativeInfinityVector; // 0x30
	
		// Properties
		public float this[int index] { get => default; set {} } // 0x00000001800495A0-0x0000000180049650 0x00000001800496F0-0x0000000180049800
		public float sqrMagnitude { get => default; } // 0x0000000180049650-0x00000001800496F0 
		public static Vector4 zero { get => default; } // 0x0000000180AC8D20-0x0000000180AC8D90 
		public static Vector4 one { get => default; } // 0x0000000180AC8C10-0x0000000180AC8D20 
	
		// Constructors
		public Vector4(float x, float y, float z, float w) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			this.w = default;
		} // 0x000000018003BA40-0x000000018003BA60
		public Vector4(float x, float y, float z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			w = default;
		} // 0x0000000180049580-0x00000001800495A0
		static Vector4() {
			zeroVector = default;
			oneVector = default;
			positiveInfinityVector = default;
			negativeInfinityVector = default;
		} // 0x0000000180AC8AB0-0x0000000180AC8C10
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018003B7E0-0x000000018003B850
		public override bool Equals(object other) => default; // 0x0000000180049460-0x0000000180049520
		public bool Equals(Vector4 other) => default; // 0x0000000180049520-0x0000000180049570
		public static float Dot(Vector4 a, Vector4 b) => default; // 0x0000000180940E80-0x0000000180941040
		public static Vector4 operator *(Vector4 a, float d) => default; // 0x0000000180964360-0x00000001809643B0
		public static Vector4 operator *(float d, Vector4 a) => default; // 0x0000000180964290-0x00000001809642F0
		public static Vector4 operator /(Vector4 a, float d) => default; // 0x0000000180963FA0-0x0000000180963FF0
		public static bool operator ==(Vector4 lhs, Vector4 rhs) => default; // 0x0000000180AC8D90-0x0000000180AC8DF0
		public static bool operator !=(Vector4 lhs, Vector4 rhs) => default; // 0x0000000180AC8F00-0x0000000180AC90A0
		public static implicit operator Vector4(Vector3 v) => default; // 0x0000000180AC8E30-0x0000000180AC8E80
		public static implicit operator Vector3(Vector4 v) => default; // 0x0000000180AC8EB0-0x0000000180AC8F00
		public static implicit operator Vector4(Vector2 v) => default; // 0x0000000180AC8DF0-0x0000000180AC8E30
		public static implicit operator Vector2(Vector4 v) => default; // 0x0000000180AC8E80-0x0000000180AC8EB0
		public override string ToString() => default; // 0x0000000180049570-0x0000000180049580
	}
}
