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
	public static class V3Tools // TypeDefIndex: 6588
	{
		// Methods
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight) => default; // 0x00000001807D5FA0-0x00000001807D6090
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight) => default; // 0x00000001807D64E0-0x00000001807D65D0
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight) => default; // 0x00000001807D5E80-0x00000001807D5FA0
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight) => default; // 0x00000001807D5D30-0x00000001807D5E80
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed) {
			changed = default;
			return default;
		} // 0x00000001807D5A60-0x00000001807D5D30
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue) {
			clampValue = default;
			return default;
		} // 0x00000001807D5750-0x00000001807D5A60
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint) => default; // 0x00000001807D6090-0x00000001807D62A0
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal) => default; // 0x00000001807D62A0-0x00000001807D64E0
	}
}
