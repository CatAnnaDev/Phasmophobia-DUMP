/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 21: UnityEngine.AndroidJNIModule.dll - Assembly: UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3877-3890

namespace UnityEngine
{
	[UsedByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
	internal sealed class _AndroidJNIHelper // TypeDefIndex: 3886
	{
		// Constructors
		public _AndroidJNIHelper() {} // Dummy constructor
	
		// Methods
		public static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy) => default; // 0x0000000180AB9C50-0x0000000180AB9DB0
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) => default; // 0x0000000180AB04C0-0x0000000180AB05F0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) => default; // 0x0000000180ABB210-0x0000000180ABB4C0
		public static jvalue[] CreateJNIArgArray(object[] args) => default; // 0x0000000180AB9410-0x0000000180AB9C50
		public static object UnboxArray(AndroidJavaObject obj) => default; // 0x0000000180ABB4C0-0x0000000180ABB9F0
		public static object Unbox(AndroidJavaObject obj) => default; // 0x0000000180ABB9F0-0x0000000180ABBFA0
		public static AndroidJavaObject Box(object obj) => default; // 0x0000000180AB8020-0x0000000180AB8BD0
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) {} // 0x0000000180AB05F0-0x0000000180AB06F0
		public static IntPtr ConvertToJNIArray(Array array) => default; // 0x0000000180AB8BD0-0x0000000180AB9410
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) => default;
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args) => default; // 0x0000000180AB06F0-0x0000000180AB0720
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) => default; // 0x0000000180AB0740-0x0000000180AB0790
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) => default;
		public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic) => default;
		public static IntPtr GetConstructorID(IntPtr jclass, string signature) => default; // 0x0000000180AB9DB0-0x0000000180AB9F90
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) => default; // 0x0000000180ABA3C0-0x0000000180ABA5B0
		private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) => default; // 0x0000000180ABA330-0x0000000180ABA3C0
		public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) => default; // 0x0000000180AB9F90-0x0000000180ABA330
		public static string GetSignature(object obj) => default; // 0x0000000180ABA5B0-0x0000000180ABB130
		public static string GetSignature(object[] args) => default; // 0x0000000180ABB130-0x0000000180ABB210
		public static string GetSignature<ReturnType>(object[] args) => default;
	}
}
