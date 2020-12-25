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
	// [NativeHeader] // 0x000000018011E4E0-0x000000018011E540
	// [StaticAccessor] // 0x000000018011E4E0-0x000000018011E540
	public static class UISystemProfilerApi // TypeDefIndex: 4140
	{
		// Nested types
		public enum SampleType // TypeDefIndex: 4141
		{
			Layout = 0,
			Render = 1
		}
	
		// Methods
		public static void BeginSample(SampleType type) {} // 0x0000000180AEF330-0x0000000180AEF370
		public static void EndSample(SampleType type) {} // 0x0000000180AEF370-0x0000000180AEF3B0
		public static void AddMarker(string name, Object obj) {} // 0x0000000180AEF2E0-0x0000000180AEF330
	}
}
