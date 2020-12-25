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

namespace Mono
{
	internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 22
	{
		// Fields
		private readonly string str; // 0x00
		private IntPtr marshaled_string; // 0x08
	
		// Properties
		public IntPtr Value { get => default; } // 0x0000000180027EE0-0x0000000180027F40 
	
		// Constructors
		public SafeStringMarshal(string str) : this() {
			this.str = default;
			marshaled_string = default;
		} // 0x0000000180027E90-0x0000000180027EE0
	
		// Methods
		public static IntPtr StringToUtf8(string str) => default; // 0x00000001806D8BC0-0x00000001806D8C80
		public static void GFree(IntPtr ptr) {} // 0x00000001806D8BB0-0x00000001806D8BC0
		public void Dispose() {} // 0x0000000180027E40-0x0000000180027E90
	}
}
