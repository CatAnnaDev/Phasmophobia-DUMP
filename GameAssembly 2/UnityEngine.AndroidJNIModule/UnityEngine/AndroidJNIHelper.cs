/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 21: UnityEngine.AndroidJNIModule.dll - Assembly: UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3877-3890

namespace UnityEngine
{
	// [NativeConditional] // 0x0000000180133F90-0x0000000180134020
	// [NativeHeader] // 0x0000000180133F90-0x0000000180134020
	// [StaticAccessor] // 0x0000000180133F90-0x0000000180134020
	[UsedByNativeCode] // 0x0000000180133F90-0x0000000180134020
	public static class AndroidJNIHelper // TypeDefIndex: 3888
	{
		// Methods
		public static IntPtr GetConstructorID(IntPtr javaClass, [DefaultValue] /* 0x00000001800E3EC0-0x00000001800E3EF0 */ string signature) => default; // 0x0000000180AB0720-0x0000000180AB0730
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue] /* 0x00000001800E3EC0-0x00000001800E3EF0 */ string signature, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool isStatic) => default; // 0x0000000180AB0790-0x0000000180AB07A0
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue] /* 0x00000001800E3EC0-0x00000001800E3EF0 */ string signature, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool isStatic) => default; // 0x0000000180AB0730-0x0000000180AB0740
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) => default; // 0x0000000180AB04C0-0x0000000180AB05F0
		public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) => default; // 0x0000000180AB02F0-0x0000000180AB04C0
		public static jvalue[] CreateJNIArgArray(object[] args) => default; // 0x0000000180AB02E0-0x0000000180AB02F0
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) {} // 0x0000000180AB05F0-0x0000000180AB06F0
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args) => default; // 0x0000000180AB06F0-0x0000000180AB0720
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) => default; // 0x0000000180AB0740-0x0000000180AB0790
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) => default;
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) => default;
		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic) => default;
	}
}
