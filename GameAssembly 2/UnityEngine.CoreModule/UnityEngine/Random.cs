/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800F2A40-0x00000001800F2A70
	public sealed class Random // TypeDefIndex: 3244
	{
		// Properties
		public static float value { [FreeFunction] /* 0x00000001800F2910-0x00000001800F2920 */ get => default; } // 0x0000000180943280-0x0000000180943690 
		public static Vector3 insideUnitSphere { [FreeFunction] /* 0x00000001800F2910-0x00000001800F2920 */ get => default; } // 0x00000001809430F0-0x0000000180943150 
		public static Vector3 onUnitSphere { [FreeFunction] /* 0x00000001800F2910-0x00000001800F2920 */ get => default; } // 0x0000000180943190-0x00000001809431F0 
		public static Quaternion rotation { [FreeFunction] /* 0x00000001800F2910-0x00000001800F2920 */ get => default; } // 0x0000000180943230-0x0000000180943280 
	
		// Constructors
		public Random() {} // Dummy constructor
	
		// Methods
		[NativeMethod] // 0x00000001800F2AA0-0x00000001800F2B00
		// [StaticAccessor] // 0x00000001800F2AA0-0x00000001800F2B00
		public static void InitState(int seed) {} // 0x0000000180942FE0-0x0000000180943020
		[FreeFunction] // 0x00000001800F2910-0x00000001800F2920
		public static float Range(float min, float max) => default; // 0x0000000180943060-0x00000001809430B0
		public static int Range(int min, int max) => default; // 0x0000000180943020-0x0000000180943060
		[FreeFunction] // 0x00000001800F2910-0x00000001800F2920
		private static int RandomRangeInt(int min, int max) => default; // 0x0000000180943020-0x0000000180943060
		private static void get_insideUnitSphere_Injected(out Vector3 ret) {
			ret = default;
		} // 0x00000001809430B0-0x00000001809430F0
		private static void get_onUnitSphere_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180943150-0x0000000180943190
		private static void get_rotation_Injected(out Quaternion ret) {
			ret = default;
		} // 0x00000001809431F0-0x0000000180943230
	}
}
