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
	public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 381
	{
		// Fields
		private IntPtr value; // 0x00
	
		// Properties
		public IntPtr Value { get => default; } // 0x0000000180002410-0x0000000180002420 
	
		// Constructors
		internal RuntimeMethodHandle(IntPtr v) : this() {
			value = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		private RuntimeMethodHandle(SerializationInfo info, StreamingContext context) : this() {
			value = default;
		} // 0x0000000180012B90-0x0000000180012D10
	
		// Methods
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001800129E0-0x0000000180012B50
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public override bool Equals(object obj) => default; // 0x00000001800128D0-0x00000001800129E0
		public override int GetHashCode() => default; // 0x000000018000DD00-0x000000018000DD10
		internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) => default; // 0x000000018043C630-0x000000018043C7A0
		internal bool IsNullHandle() => default; // 0x0000000180012B50-0x0000000180012B90
	}
}
