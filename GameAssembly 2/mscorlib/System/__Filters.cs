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
	[Serializable]
	internal class __Filters // TypeDefIndex: 134
	{
		// Fields
		internal static readonly __Filters Instance; // 0x00
	
		// Constructors
		public __Filters() {} // 0x00000001802466A0-0x00000001802466B0
		static __Filters() {} // 0x0000000180A7A1F0-0x0000000180A7A250
	
		// Methods
		internal virtual bool FilterAttribute(MemberInfo m, object filterCriteria) => default; // 0x0000000180A79B50-0x0000000180A79E80
		internal virtual bool FilterName(MemberInfo m, object filterCriteria) => default; // 0x0000000180A7A040-0x0000000180A7A1F0
		internal virtual bool FilterIgnoreCase(MemberInfo m, object filterCriteria) => default; // 0x0000000180A79E80-0x0000000180A7A040
	}
}
