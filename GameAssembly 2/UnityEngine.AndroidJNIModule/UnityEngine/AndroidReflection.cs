/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 21: UnityEngine.AndroidJNIModule.dll - Assembly: UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3877-3890

namespace UnityEngine
{
	internal class AndroidReflection // TypeDefIndex: 3885
	{
		// Fields
		private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x00
		private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x08
		private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
		private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
		private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
		private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
		private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
		private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38
	
		// Constructors
		public AndroidReflection() {} // Dummy constructor
		static AndroidReflection() {} // 0x0000000180AB7CA0-0x0000000180AB7E60
	
		// Methods
		public static bool IsPrimitive(Type t) => default; // 0x0000000180AB7A40-0x0000000180AB7A60
		public static bool IsAssignableFrom(Type t, Type from) => default; // 0x0000000180AB7A10-0x0000000180AB7A40
		private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) => default; // 0x0000000180AB7900-0x0000000180AB7A10
		private static IntPtr GetMethodID(string clazz, string methodName, string signature) => default; // 0x0000000180AB7520-0x0000000180AB7630
		public static IntPtr GetConstructorMember(IntPtr jclass, string signature) => default; // 0x0000000180AB6F20-0x0000000180AB7120
		public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) => default; // 0x0000000180AB7630-0x0000000180AB7900
		public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) => default; // 0x0000000180AB7190-0x0000000180AB7460
		public static IntPtr GetFieldClass(IntPtr field) => default; // 0x0000000180AB7120-0x0000000180AB7190
		public static string GetFieldSignature(IntPtr field) => default; // 0x0000000180AB7460-0x0000000180AB7520
		public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) => default; // 0x0000000180AB7A60-0x0000000180AB7B50
		public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) {} // 0x0000000180AB7B50-0x0000000180AB7CA0
	}
}
