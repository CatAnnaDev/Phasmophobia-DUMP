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
	// [NativeClass] // 0x00000001800EBB90-0x00000001800EBC60
	// [NativeHeader] // 0x00000001800EBB90-0x00000001800EBC60
	[NativeType] // 0x00000001800EBB90-0x00000001800EBC60
	[RequiredByNativeCode] // 0x00000001800EBB90-0x00000001800EBC60
	public struct Matrix4x4 : IEquatable<UnityEngine.Matrix4x4> // TypeDefIndex: 3222
	{
		// Fields
		// [NativeName] // 0x00000001800ED0E0-0x00000001800ED110
		public float m00; // 0x00
		// [NativeName] // 0x00000001800ED1A0-0x00000001800ED1D0
		public float m10; // 0x04
		// [NativeName] // 0x00000001800ED320-0x00000001800ED350
		public float m20; // 0x08
		// [NativeName] // 0x00000001800ED450-0x00000001800ED480
		public float m30; // 0x0C
		// [NativeName] // 0x00000001800ED4E0-0x00000001800ED510
		public float m01; // 0x10
		// [NativeName] // 0x00000001800ED510-0x00000001800ED540
		public float m11; // 0x14
		// [NativeName] // 0x00000001800ED540-0x00000001800ED570
		public float m21; // 0x18
		// [NativeName] // 0x00000001800ED570-0x00000001800ED5A0
		public float m31; // 0x1C
		// [NativeName] // 0x00000001800ED600-0x00000001800ED630
		public float m02; // 0x20
		// [NativeName] // 0x00000001800ED6B0-0x00000001800ED6E0
		public float m12; // 0x24
		// [NativeName] // 0x00000001800ED760-0x00000001800ED790
		public float m22; // 0x28
		// [NativeName] // 0x00000001800ED7B0-0x00000001800ED7E0
		public float m32; // 0x2C
		// [NativeName] // 0x00000001800ED830-0x00000001800ED860
		public float m03; // 0x30
		// [NativeName] // 0x00000001800ED890-0x00000001800ED8C0
		public float m13; // 0x34
		// [NativeName] // 0x00000001800ED8F0-0x00000001800ED920
		public float m23; // 0x38
		// [NativeName] // 0x00000001800ED950-0x00000001800ED980
		public float m33; // 0x3C
		private static readonly Matrix4x4 zeroMatrix; // 0x00
		private static readonly Matrix4x4 identityMatrix; // 0x40
	
		// Properties
		public FrustumPlanes decomposeProjection { get => default; } // 0x0000000180039DB0-0x0000000180039E60 
		public Matrix4x4 inverse { get => default; } // 0x000000018003A510-0x000000018003A690 
		public Matrix4x4 transpose { get => default; } // 0x000000018003A690-0x000000018003A810 
		public float this[int row, int column] { get => default; set {} } // 0x000000018003A4E0-0x000000018003A500 0x000000018003A820-0x000000018003A840
		public float this[int index] { get => default; set {} } // 0x000000018003A500-0x000000018003A510 0x000000018003A810-0x000000018003A820
		public static Matrix4x4 identity { get => default; } // 0x0000000180936D50-0x00000001809370D0 
	
		// Constructors
		public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) : this() {
			m00 = default;
			m10 = default;
			m20 = default;
			m30 = default;
			m01 = default;
			m11 = default;
			m21 = default;
			m31 = default;
			m02 = default;
			m12 = default;
			m22 = default;
			m32 = default;
			m03 = default;
			m13 = default;
			m23 = default;
			m33 = default;
		} // 0x000000018003A430-0x000000018003A4E0
		static Matrix4x4() {
			zeroMatrix = default;
			identityMatrix = default;
		} // 0x0000000180936770-0x0000000180936D50
	
		// Methods
		[ThreadSafe] // 0x00000001800EDA80-0x00000001800EDA90
		private FrustumPlanes DecomposeProjection() => default; // 0x0000000180039DB0-0x0000000180039E60
		[FreeFunction] // 0x00000001800EDB10-0x00000001800EDB50
		public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) => default; // 0x0000000180935D00-0x00000001809365A0
		public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) {} // 0x000000018003A2B0-0x000000018003A420
		[FreeFunction] // 0x00000001800EDB80-0x00000001800EDBC0
		public static Matrix4x4 Inverse(Matrix4x4 m) => default; // 0x0000000180935390-0x0000000180935770
		[FreeFunction] // 0x00000001800EDC40-0x00000001800EDC80
		public static Matrix4x4 Transpose(Matrix4x4 m) => default; // 0x00000001809366A0-0x0000000180936770
		[FreeFunction] // 0x00000001800EDD60-0x00000001800EDDA0
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) => default; // 0x00000001809357F0-0x0000000180935920
		[FreeFunction] // 0x00000001800EDE30-0x00000001800EDE70
		public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) => default; // 0x00000001809359A0-0x0000000180935C90
		[FreeFunction] // 0x00000001800EDF00-0x00000001800EDF40
		public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) => default; // 0x0000000180935100-0x0000000180935340
		public static Matrix4x4 Frustum(FrustumPlanes fp) => default; // 0x0000000180934F80-0x0000000180935100
		public override int GetHashCode() => default; // 0x0000000180039F80-0x000000018003A070
		public override bool Equals(object other) => default; // 0x0000000180039E60-0x0000000180039F10
		public bool Equals(Matrix4x4 other) => default; // 0x0000000180039F10-0x0000000180039F50
		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs) => default; // 0x00000001809370D0-0x0000000180937830
		public Vector4 GetColumn(int index) => default; // 0x0000000180039F50-0x0000000180039F80
		public void SetRow(int index, Vector4 row) {} // 0x000000018003A230-0x000000018003A2B0
		public Vector3 MultiplyPoint(Vector3 point) => default; // 0x000000018003A130-0x000000018003A180
		public Vector3 MultiplyPoint3x4(Vector3 point) => default; // 0x000000018003A070-0x000000018003A130
		public Vector3 MultiplyVector(Vector3 vector) => default; // 0x000000018003A180-0x000000018003A230
		public static Matrix4x4 Translate(Vector3 vector) => default; // 0x00000001809365A0-0x0000000180936650
		public override string ToString() => default; // 0x000000018003A420-0x000000018003A430
		private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) {
			ret = default;
		} // 0x0000000180934C90-0x0000000180934F00
		private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180935C90-0x0000000180935D00
		private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180935340-0x0000000180935390
		private static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180936650-0x00000001809366A0
		private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180935770-0x00000001809357F0
		private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180935920-0x00000001809359A0
		private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180934F00-0x0000000180934F80
	}
}
