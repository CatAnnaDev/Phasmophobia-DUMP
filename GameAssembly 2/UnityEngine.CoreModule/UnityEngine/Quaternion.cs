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
	// [DefaultMember] // 0x00000001800EE430-0x00000001800EE4D0
	// [NativeHeader] // 0x00000001800EE430-0x00000001800EE4D0
	[NativeType] // 0x00000001800EE430-0x00000001800EE4D0
	[UsedByNativeCode] // 0x00000001800EE430-0x00000001800EE4D0
	public struct Quaternion : IEquatable<UnityEngine.Quaternion> // TypeDefIndex: 3224
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
		private static readonly Quaternion identityQuaternion; // 0x00
		public const float kEpsilon = 1E-06f; // Metadata: 0x0064C13F
	
		// Properties
		public static Quaternion identity { get => default; } // 0x00000001809428E0-0x0000000180942950 
		public Vector3 eulerAngles { get => default; set {} } // 0x000000018003BA60-0x000000018003BA90 0x000000018003BA90-0x000000018003BBD0
	
		// Constructors
		public Quaternion(float x, float y, float z, float w) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			this.w = default;
		} // 0x000000018003BA40-0x000000018003BA60
		static Quaternion() {
			identityQuaternion = default;
		} // 0x00000001809426C0-0x00000001809428E0
	
		// Methods
		[FreeFunction] // 0x00000001800EE5D0-0x00000001800EE610
		public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) => default; // 0x0000000180941370-0x0000000180941490
		[FreeFunction] // 0x00000001800E9DF0-0x00000001800E9E20
		public static Quaternion Inverse(Quaternion rotation) => default; // 0x0000000180941890-0x0000000180941930
		[FreeFunction] // 0x00000001800EE7F0-0x00000001800EE830
		public static Quaternion Slerp(Quaternion a, Quaternion b, float t) => default; // 0x00000001809422D0-0x00000001809426C0
		[FreeFunction] // 0x00000001800EE910-0x00000001800EE950
		public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) => default; // 0x00000001809421A0-0x0000000180942260
		[FreeFunction] // 0x00000001800EE9B0-0x00000001800EE9F0
		public static Quaternion Lerp(Quaternion a, Quaternion b, float t) => default; // 0x00000001809419B0-0x0000000180941A70
		[FreeFunction] // 0x00000001800EEA80-0x00000001800EEAC0
		private static Quaternion Internal_FromEulerRad(Vector3 euler) => default; // 0x00000001809414E0-0x0000000180941580
		[FreeFunction] // 0x00000001800EEB00-0x00000001800EEB40
		private static Vector3 Internal_ToEulerRad(Quaternion rotation) => default; // 0x00000001809417A0-0x0000000180941840
		[FreeFunction] // 0x00000001800EEBF0-0x00000001800EEC30
		private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle) {
			axis = default;
			angle = default;
		} // 0x00000001809416C0-0x0000000180941750
		[FreeFunction] // 0x00000001800EEC90-0x00000001800EECD0
		public static Quaternion AngleAxis(float angle, Vector3 axis) => default; // 0x0000000180940CB0-0x0000000180940D60
		[FreeFunction] // 0x00000001800EEDB0-0x00000001800EEDF0
		public static Quaternion LookRotation(Vector3 forward, [DefaultValue] /* 0x00000001800EEEF0-0x00000001800EEF20 */ Vector3 upwards) => default; // 0x0000000180941C10-0x0000000180941CC0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static Quaternion LookRotation(Vector3 forward) => default; // 0x0000000180941AD0-0x0000000180941C10
		public static Quaternion operator *(Quaternion lhs, Quaternion rhs) => default; // 0x0000000180942D00-0x0000000180942FE0
		public static Vector3 operator *(Quaternion rotation, Vector3 point) => default; // 0x0000000180942B10-0x0000000180942D00
		private static bool IsEqualUsingDot(float dot) => default; // 0x0000000180941930-0x0000000180941940
		public static bool operator ==(Quaternion lhs, Quaternion rhs) => default; // 0x0000000180942950-0x0000000180942A10
		public static bool operator !=(Quaternion lhs, Quaternion rhs) => default; // 0x0000000180942A10-0x0000000180942B10
		public static float Dot(Quaternion a, Quaternion b) => default; // 0x0000000180940E80-0x0000000180941040
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void SetLookRotation(Vector3 view) {} // 0x000000018003B850-0x000000018003B8F0
		public void SetLookRotation(Vector3 view, [DefaultValue] /* 0x00000001800EEEF0-0x00000001800EEF20 */ Vector3 up) {} // 0x000000018003B8F0-0x000000018003B930
		public static float Angle(Quaternion a, Quaternion b) => default; // 0x0000000180940D60-0x0000000180940E80
		private static Vector3 Internal_MakePositive(Vector3 euler) => default; // 0x0000000180941580-0x0000000180941660
		public static Quaternion Euler(float x, float y, float z) => default; // 0x0000000180941040-0x00000001809411D0
		public static Quaternion Euler(Vector3 euler) => default; // 0x00000001809411D0-0x0000000180941310
		public void ToAngleAxis(out float angle, out Vector3 axis) {
			angle = default;
			axis = default;
		} // 0x000000018003B930-0x000000018003BA30
		public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) => default; // 0x0000000180941CC0-0x0000000180942130
		public override int GetHashCode() => default; // 0x000000018003B7E0-0x000000018003B850
		public override bool Equals(object other) => default; // 0x000000018003B690-0x000000018003B770
		public bool Equals(Quaternion other) => default; // 0x000000018003B770-0x000000018003B7E0
		public override string ToString() => default; // 0x000000018003BA30-0x000000018003BA40
		private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) {
			ret = default;
		} // 0x0000000180941310-0x0000000180941370
		private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) {
			ret = default;
		} // 0x0000000180941840-0x0000000180941890
		private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) {
			ret = default;
		} // 0x0000000180942260-0x00000001809422D0
		private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) {
			ret = default;
		} // 0x0000000180942130-0x00000001809421A0
		private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) {
			ret = default;
		} // 0x0000000180941940-0x00000001809419B0
		private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) {
			ret = default;
		} // 0x0000000180941490-0x00000001809414E0
		private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) {
			ret = default;
		} // 0x0000000180941750-0x00000001809417A0
		private static void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out float angle) {
			axis = default;
			angle = default;
		} // 0x0000000180941660-0x00000001809416C0
		private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) {
			ret = default;
		} // 0x0000000180940C50-0x0000000180940CB0
		private static void LookRotation_Injected(ref Vector3 forward, [DefaultValue] /* 0x00000001800EEEF0-0x00000001800EEF20 */ ref Vector3 upwards, out Quaternion ret) {
			ret = default;
		} // 0x0000000180941A70-0x0000000180941AD0
	}
}
