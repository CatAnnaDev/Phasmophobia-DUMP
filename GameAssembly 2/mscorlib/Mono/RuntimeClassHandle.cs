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
	internal struct RuntimeClassHandle // TypeDefIndex: 5
	{
		// Fields
		private unsafe RuntimeStructs.MonoClass* value; // 0x00
	
		// Properties
		internal unsafe RuntimeStructs.MonoClass* Value { get => default; } // 0x0000000180002410-0x0000000180002420 
	
		// Constructors
		internal unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value) : this() {
			this.value = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		internal unsafe RuntimeClassHandle(IntPtr ptr) : this() {
			value = default;
		} // 0x0000000180027B20-0x0000000180027B40
	
		// Methods
		public override bool Equals(object obj) => default; // 0x00000001800279E0-0x0000000180027AE0
		public override int GetHashCode() => default; // 0x0000000180027AE0-0x0000000180027B10
		internal static unsafe IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) => default; // 0x00000001806D8330-0x00000001806D8370
		internal RuntimeTypeHandle GetTypeHandle() => default; // 0x0000000180027B10-0x0000000180027B20
	}
}
