/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	public static class Console // TypeDefIndex: 341
	{
		// Fields
		internal static TextWriter stdout; // 0x00
		private static TextWriter stderr; // 0x08
		private static TextReader stdin; // 0x10
		private static Encoding inputEncoding; // 0x18
		private static Encoding outputEncoding; // 0x20
		private static ConsoleCancelEventHandler cancel_event; // 0x28
		private static readonly InternalCancelHandler cancel_handler; // 0x30
	
		// Properties
		public static TextWriter Error { get; } // 0x0000000180810F30-0x0000000180810F90 
		public static TextWriter Out { get; } // 0x0000000180810FF0-0x0000000180811050 
		public static Encoding InputEncoding { get; } // 0x0000000180810F90-0x0000000180810FF0 
		public static Encoding OutputEncoding { get; } // 0x0000000180811050-0x00000001808110B0 
	
		// Nested types
		private class WindowsConsole // TypeDefIndex: 342
		{
			// Fields
			public static bool ctrlHandlerAdded; // 0x00
			private static WindowsCancelHandler cancelHandler; // 0x08
	
			// Nested types
			private delegate bool WindowsCancelHandler(int keyCode); // TypeDefIndex: 343; 0x00000001808287F0-0x0000000180828AD0
	
			// Constructors
			public WindowsConsole() {} // Dummy constructor
			static WindowsConsole() {} // 0x0000000180828D50-0x0000000180828DE0
	
			// Methods
			private static extern int GetConsoleCP(); // 0x0000000180828B30-0x0000000180828BA0
			private static extern int GetConsoleOutputCP(); // 0x0000000180828BA0-0x0000000180828C10
			private static bool DoWindowsConsoleCancelEvent(int keyCode) => default; // 0x0000000180828AD0-0x0000000180828B30
			public static int GetInputCodePage() => default; // 0x0000000180828C10-0x0000000180828CB0
			public static int GetOutputCodePage() => default; // 0x0000000180828CB0-0x0000000180828D50
		}
	
		private delegate void InternalCancelHandler(); // TypeDefIndex: 344; 0x0000000180533490-0x0000000180533710
	
		// Constructors
		static Console() {} // 0x0000000180810D30-0x0000000180810F30
	
		// Methods
		private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) {} // 0x0000000180810850-0x0000000180810C30
		private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) => default; // 0x0000000180810410-0x00000001808104F0
		public static Stream OpenStandardError(int bufferSize) => default; // 0x0000000180810260-0x00000001808102F0
		public static Stream OpenStandardInput(int bufferSize) => default; // 0x00000001808102F0-0x0000000180810380
		public static Stream OpenStandardOutput(int bufferSize) => default; // 0x0000000180810380-0x0000000180810410
		public static void SetOut(TextWriter newOut) {} // 0x00000001808107B0-0x0000000180810850
		public static void WriteLine(object value) {} // 0x0000000180810C30-0x0000000180810CB0
		public static void WriteLine(string value) {} // 0x0000000180810CB0-0x0000000180810D30
		public static ConsoleKeyInfo ReadKey() => default; // 0x0000000180810640-0x00000001808107B0
		public static ConsoleKeyInfo ReadKey(bool intercept) => default; // 0x00000001808104F0-0x0000000180810640
		internal static void DoConsoleCancelEvent() {} // 0x0000000180810080-0x0000000180810260
	}
}
