/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 32: UnityEngine.UIModule.dll - Assembly: UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4132-4141

namespace UnityEngine
{
	// [NativeHeader] // 0x000000018011C6F0-0x000000018011C7C0
	// [NativeHeader] // 0x000000018011C6F0-0x000000018011C7C0
	// [NativeHeader] // 0x000000018011C6F0-0x000000018011C7C0
	// [NativeHeader] // 0x000000018011C6F0-0x000000018011C7C0
	// [StaticAccessor] // 0x000000018011C6F0-0x000000018011C7C0
	public sealed class RectTransformUtility // TypeDefIndex: 4136
	{
		// Fields
		private static readonly Vector3[] s_Corners; // 0x00
	
		// Constructors
		public RectTransformUtility() {} // Dummy constructor
		static RectTransformUtility() {} // 0x0000000180AEF290-0x0000000180AEF2E0
	
		// Methods
		public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) => default; // 0x0000000180AEE6F0-0x0000000180AEE790
		public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) => default; // 0x0000000180AEE7F0-0x0000000180AEE8A0
		private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam) => default; // 0x0000000180AEE900-0x0000000180AEE990
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) => default; // 0x0000000180AEE990-0x0000000180AEEA70
		public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) {
			worldPoint = default;
			return default;
		} // 0x0000000180AEEDB0-0x0000000180AEF160
		public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) {
			localPoint = default;
			return default;
		} // 0x0000000180AEEA70-0x0000000180AEEBF0
		public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) => default; // 0x0000000180AEEBF0-0x0000000180AEEDB0
		public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) => default; // 0x0000000180AEF160-0x0000000180AEF290
		public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) {} // 0x0000000180AEE370-0x0000000180AEE640
		public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) {} // 0x0000000180AEE0C0-0x0000000180AEE370
		private static Vector2 GetTransposed(Vector2 input) => default; // 0x0000000180AEE640-0x0000000180AEE680
		private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) {
			ret = default;
		} // 0x0000000180AEE680-0x0000000180AEE6F0
		private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) {
			ret = default;
		} // 0x0000000180AEE790-0x0000000180AEE7F0
		private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam) => default; // 0x0000000180AEE8A0-0x0000000180AEE900
	}
}
