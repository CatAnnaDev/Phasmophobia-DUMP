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
	internal static class IPv4AddressHelper // TypeDefIndex: 2305
	{
		// Methods
		internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) => default; // 0x000000018075C0F0-0x000000018075C4C0
		internal static int ParseHostNumber(string str, int start, int end) => default; // 0x000000018075C560-0x000000018075C630
		internal static unsafe bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) => default; // 0x000000018075BF40-0x000000018075C0F0
		internal static unsafe bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) => default; // 0x000000018075BDD0-0x000000018075BF40
		internal static unsafe long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) => default; // 0x000000018075C630-0x000000018075CA20
		private static unsafe bool Parse(string name, byte* numbers, int start, int end) => default; // 0x000000018075CA20-0x000000018075CAB0
		private static unsafe bool ParseCanonical(string name, byte* numbers, int start, int end) => default; // 0x000000018075C4C0-0x000000018075C560
	}
}
