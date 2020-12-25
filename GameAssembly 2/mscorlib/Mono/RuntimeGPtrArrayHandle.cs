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
	internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 10
	{
		// Fields
		private unsafe RuntimeStructs.GPtrArray* value; // 0x00
	
		// Properties
		internal int Length { get => default; } // 0x0000000180027C70-0x0000000180027C90 
		internal IntPtr this[int i] { get => default; } // 0x0000000180027C60-0x0000000180027C70 
	
		// Constructors
		internal unsafe RuntimeGPtrArrayHandle(IntPtr ptr) : this() {
			value = default;
		} // 0x0000000180027B20-0x0000000180027B40
	
		// Methods
		internal IntPtr Lookup(int i) => default; // 0x0000000180027C50-0x0000000180027C60
		private static unsafe void GPtrArrayFree(RuntimeStructs.GPtrArray* value) {} // 0x00000001806D8390-0x00000001806D8570
		internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) {} // 0x00000001806D8370-0x00000001806D8390
	}
}
