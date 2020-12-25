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
	internal static class ParameterizedStrings // TypeDefIndex: 385
	{
		// Fields
		[ThreadStatic] // 0x00000001800D4E50-0x00000001800D4E60
		private static LowLevelStack _cachedStack; // 0x80000000
	
		// Nested types
		public struct FormatParam // TypeDefIndex: 386
		{
			// Fields
			private readonly int _int32; // 0x00
			private readonly string _string; // 0x08
	
			// Properties
			public int Int32 { get => default; } // 0x000000018000B580-0x000000018000B590 
			public string String { get => default; } // 0x00000001800268B0-0x0000000180026E50 
			public object Object { get => default; } // 0x0000000180026860-0x00000001800268B0 
	
			// Constructors
			public FormatParam(int value) : this() {
				_int32 = default;
				_string = default;
			} // 0x0000000180026820-0x0000000180026840
			private FormatParam(int intValue, string stringValue) : this() {
				_int32 = default;
				_string = default;
			} // 0x0000000180026840-0x0000000180026860
	
			// Methods
			public static implicit operator FormatParam(int value) => default; // 0x000000018067EED0-0x000000018067EF00
		}
	
		private sealed class LowLevelStack // TypeDefIndex: 387
		{
			// Fields
			private FormatParam[] _arr; // 0x10
			private int _count; // 0x18
	
			// Constructors
			public LowLevelStack() {} // 0x000000018067F290-0x000000018067F2E0
	
			// Methods
			public FormatParam Pop() => default; // 0x000000018067F0C0-0x000000018067F180
			public void Push(FormatParam item) {} // 0x000000018067F180-0x000000018067F290
			public void Clear() {} // 0x000000018067F090-0x000000018067F0C0
		}
	
		// Methods
		public static string Evaluate(string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ FormatParam[] args) => default; // 0x000000018068F3F0-0x000000018068F570
		private static string EvaluateInternal(string format, ref int pos, FormatParam[] args, LowLevelStack stack, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars) => default; // 0x000000018068E6E0-0x000000018068F3F0
		private static bool AsBool(int i) => default; // 0x000000018068E6C0-0x000000018068E6D0
		private static int AsInt(bool b) => default; // 0x000000018068E6D0-0x000000018068E6E0
		private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) => default; // 0x000000018068F8F0-0x000000018068F9E0
		private static unsafe extern int snprintf(byte* str, IntPtr size, string format, string arg1); // 0x000000018068FAA0-0x000000018068FB80
		private static unsafe extern int snprintf(byte* str, IntPtr size, string format, int arg1); // 0x000000018068F9E0-0x000000018068FAA0
		private static string FormatPrintF(string format, object arg) => default; // 0x000000018068F570-0x000000018068F800
		private static FormatParam[] GetDynamicOrStaticVariables(char c, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars, out int index) {
			index = default;
			return default;
		} // 0x000000018068F800-0x000000018068F8F0
	}
}
