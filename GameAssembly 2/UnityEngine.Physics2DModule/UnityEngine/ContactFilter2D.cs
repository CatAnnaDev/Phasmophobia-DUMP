/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 16: UnityEngine.Physics2DModule.dll - Assembly: UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3789-3798

namespace UnityEngine
{
	[Serializable]
	// [NativeClass] // 0x0000000180112AF0-0x0000000180112B80
	// [NativeHeader] // 0x0000000180112AF0-0x0000000180112B80
	[RequiredByNativeCode] // 0x0000000180112AF0-0x0000000180112B80
	public struct ContactFilter2D // TypeDefIndex: 3793
	{
		// Fields
		// [NativeName] // 0x0000000180112E10-0x0000000180112E40
		public bool useTriggers; // 0x00
		// [NativeName] // 0x0000000180112EC0-0x0000000180112EF0
		public bool useLayerMask; // 0x01
		// [NativeName] // 0x0000000180112F90-0x0000000180112FC0
		public bool useDepth; // 0x02
		// [NativeName] // 0x00000001801130D0-0x0000000180113100
		public bool useOutsideDepth; // 0x03
		// [NativeName] // 0x0000000180113110-0x0000000180113140
		public bool useNormalAngle; // 0x04
		// [NativeName] // 0x00000001801131E0-0x0000000180113210
		public bool useOutsideNormalAngle; // 0x05
		// [NativeName] // 0x00000001801132F0-0x0000000180113320
		public LayerMask layerMask; // 0x08
		// [NativeName] // 0x00000001801133A0-0x00000001801133D0
		public float minDepth; // 0x0C
		// [NativeName] // 0x0000000180113400-0x0000000180113430
		public float maxDepth; // 0x10
		// [NativeName] // 0x0000000180113460-0x0000000180113490
		public float minNormalAngle; // 0x14
		// [NativeName] // 0x00000001801134C0-0x00000001801134F0
		public float maxNormalAngle; // 0x18
	
		// Methods
		private void CheckConsistency() {} // 0x000000018004DAD0-0x000000018004DB10
		public void SetLayerMask(LayerMask layerMask) {} // 0x000000018004DB60-0x000000018004DC20
		public void SetDepth(float minDepth, float maxDepth) {} // 0x000000018004DB10-0x000000018004DB60
		internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) => default; // 0x0000000180AEF3F0-0x0000000180AEF500
		private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) {} // 0x0000000180AEF3B0-0x0000000180AEF3F0
	}
}
