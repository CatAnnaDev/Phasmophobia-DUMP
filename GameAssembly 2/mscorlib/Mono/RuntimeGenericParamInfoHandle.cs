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
	internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 7
	{
		// Fields
		private unsafe RuntimeStructs.GenericParamInfo* value; // 0x00
	
		// Properties
		internal Type[] Constraints { get => default; } // 0x0000000180027D00-0x0000000180027D10 
		internal GenericParameterAttributes Attributes { get => default; } // 0x0000000180027CE0-0x0000000180027D00 
	
		// Constructors
		internal unsafe RuntimeGenericParamInfoHandle(IntPtr ptr) : this() {
			value = default;
		} // 0x0000000180027B20-0x0000000180027B40
	
		// Methods
		private Type[] GetConstraints() => default; // 0x0000000180027CD0-0x0000000180027CE0
		private int GetConstraintsCount() => default; // 0x0000000180027C90-0x0000000180027CD0
	}
}
