/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 4: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2170-2964

namespace System
{
	internal static class IPv6AddressHelper // TypeDefIndex: 2306
	{
		// Methods
		internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) => default; // 0x000000018075D710-0x000000018075D7C0
		internal static unsafe string CreateCanonicalName(ushort* numbers) => default; // 0x000000018075CAB0-0x000000018075D360
		private static unsafe KeyValuePair<int, int> FindCompressionRange(ushort* numbers) => default; // 0x000000018075D360-0x000000018075D400
		private static unsafe bool ShouldHaveIpv4Embedded(ushort* numbers) => default; // 0x000000018075DBC0-0x000000018075DC30
		private static unsafe bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) => default; // 0x000000018075D400-0x000000018075D6D0
		internal static unsafe bool IsValid(char* name, int start, ref int end) => default; // 0x000000018075D6F0-0x000000018075D710
		internal static unsafe bool IsValidStrict(char* name, int start, ref int end) => default; // 0x000000018075D6D0-0x000000018075D6F0
		internal static unsafe bool Parse(string address, ushort* numbers, int start, ref string scopeId) => default; // 0x000000018075D7C0-0x000000018075DBC0
	}
}
