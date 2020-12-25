/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeClass] // 0x00000001800EDFB0-0x00000001800EE0A0
	// [NativeHeader] // 0x00000001800EDFB0-0x00000001800EE0A0
	// [NativeHeader] // 0x00000001800EDFB0-0x00000001800EE0A0
	[NativeType] // 0x00000001800EDFB0-0x00000001800EE0A0
	[RequiredByNativeCode] // 0x00000001800EDFB0-0x00000001800EE0A0
	public struct Vector3 : IEquatable<UnityEngine.Vector3> // TypeDefIndex: 3223
	{
		// Fields
		public const float kEpsilon = 1E-05f; // Metadata: 0x0064C137
		public const float kEpsilonNormalSqrt = 1E-15f; // Metadata: 0x0064C13B
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		private static readonly Vector3 zeroVector; // 0x00
		private static readonly Vector3 oneVector; // 0x0C
		private static readonly Vector3 upVector; // 0x18
		private static readonly Vector3 downVector; // 0x24
		private static readonly Vector3 leftVector; // 0x30
		private static readonly Vector3 rightVector; // 0x3C
		private static readonly Vector3 forwardVector; // 0x48
		private static readonly Vector3 backVector; // 0x54
		private static readonly Vector3 positiveInfinityVector; // 0x60
		private static readonly Vector3 negativeInfinityVector; // 0x6C
	
		// Properties
		public float this[int index] { get => default; set {} } // 0x00000001800365B0-0x0000000180036650 0x0000000180036750-0x0000000180036800
		public Vector3 normalized { get => default; } // 0x00000001800366F0-0x0000000180036720 
		public float magnitude { get => default; } // 0x0000000180036650-0x00000001800366F0 
		public float sqrMagnitude { get => default; } // 0x0000000180036720-0x0000000180036750 
		public static Vector3 zero { get => default; } // 0x00000001808EA8B0-0x00000001808EA920 
		public static Vector3 one { get => default; } // 0x00000001808EA730-0x00000001808EA7A0 
		public static Vector3 forward { get => default; } // 0x00000001808EA380-0x00000001808EA3F0 
		public static Vector3 back { get => default; } // 0x00000001808EA2A0-0x00000001808EA310 
		public static Vector3 up { get => default; } // 0x00000001808EA840-0x00000001808EA8B0 
		public static Vector3 down { get => default; } // 0x00000001808EA310-0x00000001808EA380 
		public static Vector3 left { get => default; } // 0x00000001808EA3F0-0x00000001808EA730 
		public static Vector3 right { get => default; } // 0x00000001808EA7A0-0x00000001808EA840 
	
		// Constructors
		public Vector3(float x, float y, float z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000180036570-0x0000000180036580
		public Vector3(float x, float y) : this() {
			this.x = default;
			this.y = default;
			z = default;
		} // 0x0000000180036590-0x00000001800365B0
		static Vector3() {
			zeroVector = default;
			oneVector = default;
			upVector = default;
			downVector = default;
			leftVector = default;
			rightVector = default;
			forwardVector = default;
			backVector = default;
			positiveInfinityVector = default;
			negativeInfinityVector = default;
		} // 0x00000001808EA000-0x00000001808EA2A0
	
		// Methods
		[FreeFunction] // 0x00000001800EE180-0x00000001800EE1C0
		public static Vector3 Slerp(Vector3 a, Vector3 b, float t) => default; // 0x00000001808E96D0-0x00000001808E9790
		[FreeFunction] // 0x00000001800EE1C0-0x00000001800EE200
		private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) {} // 0x00000001808E8EB0-0x00000001808E8F00
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) {} // 0x00000001808E8F00-0x00000001808E8F80
		[FreeFunction] // 0x00000001800E9DF0-0x00000001800E9E20
		public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) => default; // 0x00000001808E9500-0x00000001808E95D0
		public static Vector3 Lerp(Vector3 a, Vector3 b, float t) => default; // 0x00000001808E84F0-0x00000001808E8630
		public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) => default; // 0x00000001808E8920-0x00000001808E8CD0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed) => default; // 0x00000001808E9CD0-0x00000001808E9DF0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) => default; // 0x00000001808E9790-0x00000001808E98B0
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, [DefaultValue] /* 0x00000001800EE2E0-0x00000001800EE310 */ float maxSpeed, [DefaultValue] /* 0x00000001800EE370-0x00000001800EE3A0 */ float deltaTime) => default; // 0x00000001808E98B0-0x00000001808E9CD0
		public void Set(float newX, float newY, float newZ) {} // 0x0000000180036570-0x0000000180036580
		public static Vector3 Scale(Vector3 a, Vector3 b) => default; // 0x00000001808E95D0-0x00000001808E9660
		public static Vector3 Cross(Vector3 lhs, Vector3 rhs) => default; // 0x00000001808E8120-0x00000001808E8220
		public override int GetHashCode() => default; // 0x0000000180036320-0x0000000180036380
		public override bool Equals(object other) => default; // 0x0000000180036210-0x00000001800362D0
		public bool Equals(Vector3 other) => default; // 0x00000001800362D0-0x0000000180036320
		public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) => default; // 0x00000001808E9360-0x00000001808E9490
		public static Vector3 Normalize(Vector3 value) => default; // 0x00000001808E8CD0-0x00000001808E8EB0
		public void Normalize() {} // 0x0000000180036380-0x0000000180036570
		public static float Dot(Vector3 lhs, Vector3 rhs) => default; // 0x00000001808E8320-0x00000001808E84F0
		public static Vector3 Project(Vector3 vector, Vector3 onNormal) => default; // 0x00000001808E9160-0x00000001808E9360
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) => default; // 0x00000001808E8F80-0x00000001808E9160
		public static float Angle(Vector3 from, Vector3 to) => default; // 0x00000001808E7E60-0x00000001808E8010
		public static float Distance(Vector3 a, Vector3 b) => default; // 0x00000001808E8220-0x00000001808E8320
		public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) => default; // 0x00000001808E8010-0x00000001808E8120
		public static float Magnitude(Vector3 vector) => default; // 0x00000001808E8630-0x00000001808E86E0
		public static float SqrMagnitude(Vector3 vector) => default; // 0x00000001808E9DF0-0x00000001808EA000
		public static Vector3 Min(Vector3 lhs, Vector3 rhs) => default; // 0x00000001808E8800-0x00000001808E8920
		public static Vector3 Max(Vector3 lhs, Vector3 rhs) => default; // 0x00000001808E86E0-0x00000001808E8800
		public static Vector3 operator +(Vector3 a, Vector3 b) => default; // 0x00000001808EA920-0x00000001808EA9A0
		public static Vector3 operator -(Vector3 a, Vector3 b) => default; // 0x00000001808EABD0-0x00000001808EAC50
		public static Vector3 operator -(Vector3 a) => default; // 0x00000001808EAC50-0x00000001808EAE10
		public static Vector3 operator *(Vector3 a, float d) => default; // 0x00000001808EAB20-0x00000001808EAB70
		public static Vector3 operator *(float d, Vector3 a) => default; // 0x00000001808EAB70-0x00000001808EABD0
		public static Vector3 operator /(Vector3 a, float d) => default; // 0x00000001808EA9A0-0x00000001808EA9F0
		public static bool operator ==(Vector3 lhs, Vector3 rhs) => default; // 0x00000001808EA9F0-0x00000001808EAA70
		public static bool operator !=(Vector3 lhs, Vector3 rhs) => default; // 0x00000001808EAA70-0x00000001808EAB20
		public override string ToString() => default; // 0x0000000180036580-0x0000000180036590
		private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) {
			ret = default;
		} // 0x00000001808E9660-0x00000001808E96D0
		private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) {
			ret = default;
		} // 0x00000001808E9490-0x00000001808E9500
	}
}
