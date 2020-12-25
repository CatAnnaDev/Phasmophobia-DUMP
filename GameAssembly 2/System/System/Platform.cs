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
	internal static class Platform // TypeDefIndex: 2315
	{
		// Fields
		private static bool checkedOS; // 0x00
		private static bool isMacOS; // 0x01
		private static bool isFreeBSD; // 0x02
	
		// Properties
		public static bool IsMacOS { get; } // 0x000000018041DCA0-0x000000018041DD20 
	
		// Methods
		private static extern int uname(IntPtr buf); // 0x000000018041DD20-0x000000018041DDA0
		private static void CheckOS() {} // 0x000000018041DA50-0x000000018041DCA0
	}
}
