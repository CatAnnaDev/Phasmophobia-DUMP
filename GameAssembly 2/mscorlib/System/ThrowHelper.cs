/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	internal static class ThrowHelper // TypeDefIndex: 116
	{
		// Methods
		internal static void ThrowArgumentNullException(ExceptionArgument argument) {} // 0x000000018049B220-0x000000018049B260
		private static Exception CreateArgumentNullException(ExceptionArgument argument) => default; // 0x000000018049ABB0-0x000000018049AC50
		internal static void ThrowArgumentOutOfRangeException() {} // 0x000000018049B350-0x000000018049B370
		internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType) {} // 0x000000018049B450-0x000000018049B6C0
		internal static void ThrowArgumentException(ExceptionResource resource) {} // 0x000000018049B1B0-0x000000018049B220
		internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource) {} // 0x000000018049B260-0x000000018049B350
		internal static void ThrowInvalidOperationException(ExceptionResource resource) {} // 0x000000018049B370-0x000000018049B3E0
		internal static void ThrowNotSupportedException(ExceptionResource resource) {} // 0x000000018049B3E0-0x000000018049B450
		internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName) {}
		internal static string GetArgumentName(ExceptionArgument argument) => default; // 0x000000018049AC50-0x000000018049AE40
		internal static string GetResourceName(ExceptionResource resource) => default; // 0x000000018049AE40-0x000000018049B1B0
	}
}
