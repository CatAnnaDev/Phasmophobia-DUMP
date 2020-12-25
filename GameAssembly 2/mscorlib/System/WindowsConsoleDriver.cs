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
	internal class WindowsConsoleDriver : IConsoleDriver // TypeDefIndex: 419
	{
		// Fields
		private IntPtr inputHandle; // 0x10
		private IntPtr outputHandle; // 0x18
		private short defaultAttribute; // 0x20
	
		// Constructors
		public WindowsConsoleDriver() {} // 0x0000000180A78620-0x0000000180A78700
	
		// Methods
		public ConsoleKeyInfo ReadKey(bool intercept) => default; // 0x0000000180A783E0-0x0000000180A78620
		private static bool IsModifierKey(short virtualKeyCode) => default; // 0x0000000180A782A0-0x0000000180A782D0
		private static extern IntPtr GetStdHandle(Handles handle); // 0x0000000180A78210-0x0000000180A782A0
		private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info); // 0x0000000180A78170-0x0000000180A78210
		private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread); // 0x0000000180A782D0-0x0000000180A783E0
	}
}
