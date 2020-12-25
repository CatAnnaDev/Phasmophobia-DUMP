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
	internal static class ConsoleDriver // TypeDefIndex: 345
	{
		// Fields
		internal static IConsoleDriver driver; // 0x00
		private static bool is_console; // 0x08
		private static bool called_isatty; // 0x09
	
		// Properties
		public static bool IsConsole { get; } // 0x000000018080FE20-0x0000000180810080 
	
		// Constructors
		static ConsoleDriver() {} // 0x000000018080FD60-0x000000018080FE20
	
		// Methods
		private static IConsoleDriver CreateNullConsoleDriver() => default; // 0x000000018080FB20-0x000000018080FB70
		private static IConsoleDriver CreateWindowsConsoleDriver() => default; // 0x000000018080FBD0-0x000000018080FC20
		private static IConsoleDriver CreateTermInfoDriver(string term) => default; // 0x000000018080FB70-0x000000018080FBD0
		public static ConsoleKeyInfo ReadKey(bool intercept) => default; // 0x000000018080FC30-0x000000018080FD40
		private static bool Isatty(IntPtr handle) => default; // 0x000000018080FC20-0x000000018080FC30
		internal static int InternalKeyAvailable(int ms_timeout) => default; // 0x000000018031B9E0-0x000000018031B9F0
		internal static unsafe bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) {
			control_characters = default;
			address = default;
			return default;
		} // 0x000000018080FD50-0x000000018080FD60
		internal static bool SetEcho(bool wantEcho) => default; // 0x000000018080FD40-0x000000018080FD50
	}
}
