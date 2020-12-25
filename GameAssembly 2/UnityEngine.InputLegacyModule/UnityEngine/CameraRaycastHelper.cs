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
	// [NativeHeader] // 0x0000000180107AC0-0x0000000180107AF0
	internal class CameraRaycastHelper // TypeDefIndex: 3783
	{
		// Constructors
		public CameraRaycastHelper() {} // Dummy constructor
	
		// Methods
		[FreeFunction] // 0x0000000180107B80-0x0000000180107BB0
		internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) => default; // 0x0000000180AF3B50-0x0000000180AF3BC0
		[FreeFunction] // 0x0000000180107BE0-0x0000000180107C10
		internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) => default; // 0x0000000180AF3A70-0x0000000180AF3AE0
		private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) => default; // 0x0000000180AF3AE0-0x0000000180AF3B50
		private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) => default; // 0x0000000180AF3A00-0x0000000180AF3A70
	}
}
