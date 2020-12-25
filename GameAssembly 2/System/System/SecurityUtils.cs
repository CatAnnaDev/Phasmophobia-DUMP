/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 4: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2170-2964

namespace System
{
	internal static class SecurityUtils // TypeDefIndex: 2283
	{
		// Methods
		private static void DemandReflectionAccess(Type type) {} // 0x0000000180246DB0-0x0000000180246DC0
		private static void DemandGrantSet(Assembly assembly) {} // 0x0000000180246DB0-0x0000000180246DC0
		private static bool HasReflectionPermission(Type type) => default; // 0x0000000180504F10-0x0000000180504F60
		internal static object SecureCreateInstance(Type type) => default; // 0x0000000180505370-0x0000000180505380
		internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) => default; // 0x0000000180505390-0x00000001805054A0
		internal static object SecureCreateInstance(Type type, object[] args) => default; // 0x0000000180505380-0x0000000180505390
		internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) => default; // 0x0000000180505090-0x0000000180505200
		internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) => default; // 0x0000000180505200-0x0000000180505370
		private static bool GenericArgumentsAreVisible(MethodInfo method) => default; // 0x0000000180504E70-0x0000000180504F10
		internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) => default; // 0x0000000180504F60-0x0000000180505090
	}
}
