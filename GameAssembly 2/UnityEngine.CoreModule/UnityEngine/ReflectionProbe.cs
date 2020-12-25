/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x000000018012B710-0x000000018012B740
	public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 3119
	{
		// Properties
		public ReflectionProbeRefreshMode refreshMode { set {} } // 0x0000000180946380-0x00000001809463C0
		public ReflectionProbeTimeSlicingMode timeSlicingMode { get => default; } // 0x0000000180946340-0x0000000180946380 
	
		// Nested types
		public enum ReflectionProbeEvent // TypeDefIndex: 3120
		{
			ReflectionProbeAdded = 0,
			ReflectionProbeRemoved = 1
		}
	
		// Constructors
		public ReflectionProbe() {} // Dummy constructor
	
		// Methods
		public int RenderProbe() => default; // 0x0000000180946280-0x00000001809462F0
		public int RenderProbe([DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ RenderTexture targetTexture) => default; // 0x0000000180946200-0x0000000180946280
		private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) => default; // 0x00000001809462F0-0x0000000180946340
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) {} // 0x0000000180946140-0x00000001809461A0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) {} // 0x00000001809461A0-0x0000000180946200
	}
}
