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
	internal static class IriHelper // TypeDefIndex: 2285
	{
		// Methods
		internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) => default; // 0x0000000180466310-0x0000000180466380
		internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) => default; // 0x0000000180465F00-0x0000000180466310
		internal static bool CheckIsReserved(char ch, UriComponents component) => default; // 0x0000000180466380-0x00000001804664A0
		internal static unsafe string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component) => default; // 0x00000001804664A0-0x0000000180466D00
	}
}
