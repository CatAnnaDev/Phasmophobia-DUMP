/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion
{
	public static class QuaTools // TypeDefIndex: 6584
	{
		// Methods
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight) => default; // 0x00000001807D2030-0x00000001807D2100
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight) => default; // 0x00000001807D2430-0x00000001807D2500
		public static Quaternion LinearBlend(Quaternion q, float weight) => default; // 0x00000001807D2100-0x00000001807D21F0
		public static Quaternion SphericalBlend(Quaternion q, float weight) => default; // 0x00000001807D2500-0x00000001807D25F0
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis) => default; // 0x00000001807D1A40-0x00000001807D1BF0
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation) => default; // 0x00000001807D2360-0x00000001807D2430
		public static Quaternion FromToRotation(Quaternion from, Quaternion to) => default; // 0x00000001807D1BF0-0x00000001807D1D10
		public static Vector3 GetAxis(Vector3 v) => default; // 0x00000001807D1D10-0x00000001807D2030
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing) => default; // 0x00000001807D17B0-0x00000001807D1A40
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing) => default; // 0x00000001807D15D0-0x00000001807D17B0
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis) => default; // 0x00000001807D21F0-0x00000001807D2360
	}
}
