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
	internal static class RuntimeStructs // TypeDefIndex: 12
	{
		// Nested types
		internal struct RemoteClass // TypeDefIndex: 13
		{
			// Fields
			internal IntPtr default_vtable; // 0x00
			internal IntPtr xdomain_vtable; // 0x08
			internal unsafe MonoClass* proxy_class; // 0x10
			internal IntPtr proxy_class_name; // 0x18
			internal uint interface_count; // 0x20
		}
	
		internal struct MonoClass // TypeDefIndex: 14
		{
		}
	
		internal struct GenericParamInfo // TypeDefIndex: 15
		{
			// Fields
			internal unsafe MonoClass* pklass; // 0x00
			internal IntPtr name; // 0x08
			internal ushort flags; // 0x10
			internal uint token; // 0x14
			internal unsafe MonoClass** constraints; // 0x18
		}
	
		internal struct GPtrArray // TypeDefIndex: 16
		{
			// Fields
			internal unsafe IntPtr* data; // 0x00
			internal int len; // 0x08
		}
	
		private struct HandleStackMark // TypeDefIndex: 17
		{
			// Fields
			private int size; // 0x00
			private int interior_size; // 0x04
			private IntPtr chunk; // 0x08
		}
	
		private struct MonoError // TypeDefIndex: 18
		{
			// Fields
			private ushort error_code; // 0x00
			private ushort hidden_0; // 0x02
			private IntPtr hidden_1; // 0x08
			private IntPtr hidden_2; // 0x10
			private IntPtr hidden_3; // 0x18
			private IntPtr hidden_4; // 0x20
			private IntPtr hidden_5; // 0x28
			private IntPtr hidden_6; // 0x30
			private IntPtr hidden_7; // 0x38
			private IntPtr hidden_8; // 0x40
			private IntPtr hidden_11; // 0x48
			private IntPtr hidden_12; // 0x50
			private IntPtr hidden_13; // 0x58
			private IntPtr hidden_14; // 0x60
			private IntPtr hidden_15; // 0x68
			private IntPtr hidden_16; // 0x70
			private IntPtr hidden_17; // 0x78
			private IntPtr hidden_18; // 0x80
		}
	}
}
