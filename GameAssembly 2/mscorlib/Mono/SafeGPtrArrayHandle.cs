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
	internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 21
	{
		// Fields
		private RuntimeGPtrArrayHandle handle; // 0x00
	
		// Properties
		internal int Length { get => default; } // 0x0000000180027C70-0x0000000180027C90 
		internal IntPtr this[int i] { get => default; } // 0x0000000180027C60-0x0000000180027C70 
	
		// Constructors
		internal SafeGPtrArrayHandle(IntPtr ptr) : this() {
			handle = default;
		} // 0x0000000180027B20-0x0000000180027B40
	
		// Methods
		public void Dispose() {} // 0x0000000180027E20-0x0000000180027E40
	}
}
