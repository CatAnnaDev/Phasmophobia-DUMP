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
	internal class NullConsoleDriver : IConsoleDriver // TypeDefIndex: 369
	{
		// Fields
		private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; // 0x00
	
		// Constructors
		public NullConsoleDriver() {} // 0x0000000180246DB0-0x0000000180246DC0
		static NullConsoleDriver() {} // 0x0000000180684030-0x00000001806840A0
	
		// Methods
		public ConsoleKeyInfo ReadKey(bool intercept) => default; // 0x0000000180683FC0-0x0000000180684030
	}
}
