/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	public static class StackTraceUtility // TypeDefIndex: 3283
	{
		// Fields
		private static string projectFolder; // 0x00
	
		// Constructors
		static StackTraceUtility() {} // 0x00000001808DE4F0-0x00000001808DE530
	
		// Methods
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void SetProjectFolder(string folder) {} // 0x00000001808DE400-0x00000001808DE4F0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public static string ExtractStackTrace() => default; // 0x00000001808DDFE0-0x00000001808DE070
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) {
			message = default;
			stackTrace = default;
		} // 0x00000001808DE070-0x00000001808DE400
		internal static string ExtractFormattedStackTrace(StackTrace stackTrace) => default; // 0x00000001808DD990-0x00000001808DDFE0
	}
}
