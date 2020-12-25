/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 9: UnityEngine.SubsystemsModule.dll - Assembly: UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3680-3691

namespace UnityEngine
{
	internal static class Internal_SubsystemInstances // TypeDefIndex: 3686
	{
		// Fields
		internal static List<ISubsystem> s_IntegratedSubsystemInstances; // 0x00
		internal static List<ISubsystem> s_StandaloneSubsystemInstances; // 0x08
	
		// Constructors
		static Internal_SubsystemInstances() {} // 0x0000000180AF72A0-0x0000000180AF7340
	
		// Methods
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void Internal_InitializeManagedInstance(IntPtr ptr, IntegratedSubsystem inst) {} // 0x0000000180AF7010-0x0000000180AF70D0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void Internal_ClearManagedInstances() {} // 0x0000000180AF6BD0-0x0000000180AF6E20
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void Internal_RemoveInstanceByPtr(IntPtr ptr) {} // 0x0000000180AF70D0-0x0000000180AF72A0
		internal static IntegratedSubsystem Internal_GetInstanceByPtr(IntPtr ptr) => default; // 0x0000000180AF6E20-0x0000000180AF7010
	}
}
