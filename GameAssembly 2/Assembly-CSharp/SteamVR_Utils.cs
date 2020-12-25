/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public static class SteamVR_Utils // TypeDefIndex: 7310
{
	// Nested types
	[Serializable]
	public struct RigidTransform // TypeDefIndex: 7311
	{
		// Fields
		public Vector3 pos; // 0x00
		public Quaternion rot; // 0x0C

		// Properties
		public static RigidTransform identity { get => default; } // 0x0000000181D22800-0x0000000181D228B0 

		// Constructors
		public RigidTransform(Vector3 pos, Quaternion rot) : this() {
			this.pos = default;
			this.rot = default;
		} // 0x000000018020C210-0x000000018020C230
		public RigidTransform(Transform t) : this() {
			pos = default;
			rot = default;
		} // 0x000000018020BFB0-0x000000018020C010
		public RigidTransform(Transform from, Transform to) : this() {
			pos = default;
			rot = default;
		} // 0x000000018020C050-0x000000018020C210
		public RigidTransform(HmdMatrix34_t pose) : this() {
			pos = default;
			rot = default;
		} // 0x000000018020C010-0x000000018020C050
		public RigidTransform(HmdMatrix44_t pose) : this() {
			pos = default;
			rot = default;
		} // 0x000000018020C230-0x000000018020C290

		// Methods
		public static RigidTransform FromLocal(Transform t) => default; // 0x0000000181D21210-0x0000000181D212F0
		public HmdMatrix44_t ToHmdMatrix44() => default; // 0x000000018020BF20-0x000000018020BF60
		public HmdMatrix34_t ToHmdMatrix34() => default; // 0x000000018020BEE0-0x000000018020BF20
		public override bool Equals(object o) => default; // 0x000000018020B8D0-0x000000018020BA30
		public override int GetHashCode() => default; // 0x000000018020BA30-0x000000018020BA70
		public static bool operator ==(RigidTransform a, RigidTransform b) => default; // 0x0000000181D228B0-0x0000000181D229F0
		public static bool operator !=(RigidTransform a, RigidTransform b) => default; // 0x0000000181D229F0-0x0000000181D22B30
		public static RigidTransform operator *(RigidTransform a, RigidTransform b) => default; // 0x0000000181D22B80-0x0000000181D22D30
		public void Inverse() {} // 0x000000018020BD30-0x000000018020BD40
		public RigidTransform GetInverse() => default; // 0x000000018020BA70-0x000000018020BAD0
		public void Multiply(RigidTransform a, RigidTransform b) {} // 0x000000018020BD40-0x000000018020BEE0
		public Vector3 InverseTransformPoint(Vector3 point) => default; // 0x000000018020BBF0-0x000000018020BD30
		public Vector3 TransformPoint(Vector3 point) => default; // 0x000000018020BF60-0x000000018020BFB0
		public static Vector3 operator *(RigidTransform t, Vector3 v) => default; // 0x0000000181D22B30-0x0000000181D22B80
		public static RigidTransform Interpolate(RigidTransform a, RigidTransform b, float t) => default; // 0x0000000181D212F0-0x0000000181D22800
		public void Interpolate(RigidTransform to, float t) {} // 0x000000018020BAD0-0x000000018020BBF0
	}

	public delegate object SystemFn(CVRSystem system, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args); // TypeDefIndex: 7312; 0x000000018078EAB0-0x000000018078EFB0

	// Methods
	public static Quaternion Slerp(Quaternion A, Quaternion B, float t) => default; // 0x0000000181D2C3C0-0x0000000181D2C640
	public static Vector3 Lerp(Vector3 A, Vector3 B, float t) => default; // 0x0000000181D2C270-0x0000000181D2C320
	public static float Lerp(float A, float B, float t) => default; // 0x0000000181D2C320-0x0000000181D2C330
	public static double Lerp(double A, double B, double t) => default; // 0x0000000181D2C330-0x0000000181D2C340
	public static float InverseLerp(Vector3 A, Vector3 B, Vector3 result) => default; // 0x0000000181D2C130-0x0000000181D2C250
	public static float InverseLerp(float A, float B, float result) => default; // 0x0000000181D2C250-0x0000000181D2C260
	public static double InverseLerp(double A, double B, double result) => default; // 0x0000000181D2C260-0x0000000181D2C270
	public static float Saturate(float A) => default; // 0x0000000181D2C3A0-0x0000000181D2C3C0
	public static Vector2 Saturate(Vector2 A) => default; // 0x0000000181D2C340-0x0000000181D2C3A0
	public static float Abs(float A) => default; // 0x0000000180C7F9E0-0x0000000180C7F9F0
	public static Vector2 Abs(Vector2 A) => default; // 0x0000000181D2BBA0-0x0000000181D2BBF0
	private static float _copysign(float sizeval, float signval) => default; // 0x0000000181D2DC10-0x0000000181D2DD00
	public static object CallSystemFn(SystemFn fn, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) => default; // 0x0000000181D2BBF0-0x0000000181D2BD40
	public static void TakeStereoScreenshot(uint screenshotHandle, GameObject target, int cellSize, float ipd, ref string previewFilename, ref string VRFilename) {} // 0x0000000181D2C640-0x0000000181D2DC10

	// Extension methods
	public static Quaternion GetRotation(this Matrix4x4 matrix) => default; // 0x0000000181D2BD80-0x0000000181D2BF80
	public static Vector3 GetPosition(this Matrix4x4 matrix) => default; // 0x0000000181D2BD40-0x0000000181D2BD80
	public static Vector3 GetScale(this Matrix4x4 m) => default; // 0x0000000181D2BF80-0x0000000181D2C130
}

