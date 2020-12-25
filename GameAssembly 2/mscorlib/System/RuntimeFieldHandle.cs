/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 380
	{
		// Fields
		private IntPtr value; // 0x00
	
		// Properties
		public IntPtr Value { get => default; } // 0x0000000180002410-0x0000000180002420 
	
		// Constructors
		internal RuntimeFieldHandle(IntPtr v) : this() {
			value = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		private RuntimeFieldHandle(SerializationInfo info, StreamingContext context) : this() {
			value = default;
		} // 0x0000000180012750-0x00000001800128D0
	
		// Methods
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001800125E0-0x0000000180012750
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public override bool Equals(object obj) => default; // 0x00000001800124D0-0x00000001800125E0
		public override int GetHashCode() => default; // 0x000000018000DD00-0x000000018000DD10
		private static void SetValueInternal(FieldInfo fi, object obj, object value) {} // 0x000000018043C620-0x000000018043C630
		internal static void SetValue(RtFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) {} // 0x000000018043C620-0x000000018043C630
		internal static unsafe void SetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) {} // 0x000000018043C610-0x000000018043C620
	}
}
