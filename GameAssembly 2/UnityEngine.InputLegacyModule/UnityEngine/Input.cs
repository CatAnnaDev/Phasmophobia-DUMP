/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 14: UnityEngine.InputLegacyModule.dll - Assembly: UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3778-3786

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180107A60-0x0000000180107A90
	public class Input // TypeDefIndex: 3784
	{
		// Properties
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static Vector3 mousePosition { get => default; } // 0x0000000180AF4340-0x0000000180AF43A0 
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static Vector2 mouseScrollDelta { get => default; } // 0x0000000180AF4410-0x0000000180AF4450 
		public static IMECompositionMode imeCompositionMode { get => default; set {} } // 0x0000000180AF42D0-0x0000000180AF4300 0x0000000180AF4670-0x0000000180AF46B0
		public static string compositionString { get => default; } // 0x0000000180AF42A0-0x0000000180AF42D0 
		public static Vector2 compositionCursorPos { get => default; set {} } // 0x0000000180AF4260-0x0000000180AF42A0 0x0000000180AF4630-0x0000000180AF4670
		public static bool mousePresent { [FreeFunction] /* 0x0000000180108C40-0x0000000180108C70 */ get => default; } // 0x0000000180AF43A0-0x0000000180AF43D0 
		public static int touchCount { [FreeFunction] /* 0x0000000180108D20-0x0000000180108D50 */ get => default; } // 0x0000000180AF4450-0x0000000180AF4480 
		public static bool touchSupported { [FreeFunction] /* 0x0000000180108D80-0x0000000180108DB0 */ get => default; } // 0x0000000180AF4480-0x0000000180AF44B0 
		public static Vector3 acceleration { [FreeFunction] /* 0x0000000180108EB0-0x0000000180108EE0 */ get => default; } // 0x0000000180AF41C0-0x0000000180AF4220 
		public static Touch[] touches { get => default; } // 0x0000000180AF44B0-0x0000000180AF45F0 
	
		// Constructors
		public Input() {} // Dummy constructor
	
		// Methods
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		private static bool GetKeyInt(KeyCode key) => default; // 0x0000000180AF3EE0-0x0000000180AF3F20
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		private static bool GetKeyString(string name) => default; // 0x0000000180AF3F20-0x0000000180AF3F60
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		private static bool GetKeyUpInt(KeyCode key) => default; // 0x0000000180AF3F60-0x0000000180AF3FA0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		private static bool GetKeyUpString(string name) => default; // 0x0000000180AF3FA0-0x0000000180AF3FE0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		private static bool GetKeyDownInt(KeyCode key) => default; // 0x0000000180AF3EA0-0x0000000180AF3EE0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static float GetAxis(string axisName) => default; // 0x0000000180AF3D70-0x0000000180AF3DB0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static float GetAxisRaw(string axisName) => default; // 0x0000000180AF3D30-0x0000000180AF3D70
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static bool GetButton(string buttonName) => default; // 0x0000000180AF3E30-0x0000000180AF3E70
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static bool GetButtonDown(string buttonName) => default; // 0x0000000180AF3DB0-0x0000000180AF3DF0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static bool GetButtonUp(string buttonName) => default; // 0x0000000180AF3DF0-0x0000000180AF3E30
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static bool GetMouseButton(int button) => default; // 0x0000000180AF4060-0x0000000180AF40A0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static bool GetMouseButtonDown(int button) => default; // 0x0000000180AF3FE0-0x0000000180AF4020
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static bool GetMouseButtonUp(int button) => default; // 0x0000000180AF4020-0x0000000180AF4060
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static string[] GetJoystickNames() => default; // 0x0000000180AF3E70-0x0000000180AF3EA0
		[NativeThrows] // 0x00000001800D8770-0x00000001800D8780
		public static Touch GetTouch(int index) => default; // 0x0000000180AF40E0-0x0000000180AF4180
		public static bool GetKey(KeyCode key) => default; // 0x0000000180AF3EE0-0x0000000180AF3F20
		public static bool GetKey(string name) => default; // 0x0000000180AF3F20-0x0000000180AF3F60
		public static bool GetKeyUp(KeyCode key) => default; // 0x0000000180AF3F60-0x0000000180AF3FA0
		public static bool GetKeyUp(string name) => default; // 0x0000000180AF3FA0-0x0000000180AF3FE0
		public static bool GetKeyDown(KeyCode key) => default; // 0x0000000180AF3EA0-0x0000000180AF3EE0
		private static void GetTouch_Injected(int index, out Touch ret) {
			ret = default;
		} // 0x0000000180AF40A0-0x0000000180AF40E0
		private static void get_mousePosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180AF4300-0x0000000180AF4340
		private static void get_mouseScrollDelta_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180AF43D0-0x0000000180AF4410
		private static void get_compositionCursorPos_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000180AF4220-0x0000000180AF4260
		private static void set_compositionCursorPos_Injected(ref Vector2 value) {} // 0x0000000180AF45F0-0x0000000180AF4630
		private static void get_acceleration_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180AF4180-0x0000000180AF41C0
	}
}
