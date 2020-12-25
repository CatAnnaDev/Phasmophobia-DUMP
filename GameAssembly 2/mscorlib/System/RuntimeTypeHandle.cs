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
	public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 382
	{
		// Fields
		private IntPtr value; // 0x00
	
		// Properties
		public IntPtr Value { get => default; } // 0x0000000180002410-0x0000000180002420 
	
		// Constructors
		internal RuntimeTypeHandle(IntPtr val) : this() {
			value = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		internal RuntimeTypeHandle(RuntimeType type) : this() {
			value = default;
		} // 0x00000001800130F0-0x0000000180013110
		private RuntimeTypeHandle(SerializationInfo info, StreamingContext context) : this() {
			value = default;
		} // 0x0000000180012F70-0x00000001800130F0
	
		// Methods
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180012E20-0x0000000180012F70
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public override bool Equals(object obj) => default; // 0x0000000180012D10-0x0000000180012E20
		public override int GetHashCode() => default; // 0x000000018000DD00-0x000000018000DD10
		internal static TypeAttributes GetAttributes(RuntimeType type) => default; // 0x000000018043C7D0-0x000000018043C7E0
		private static int GetMetadataToken(RuntimeType type) => default; // 0x000000018043C820-0x000000018043C830
		internal static int GetToken(RuntimeType type) => default; // 0x000000018043C820-0x000000018043C830
		private static Type GetGenericTypeDefinition_impl(RuntimeType type) => default; // 0x000000018043C810-0x000000018043C820
		internal static Type GetGenericTypeDefinition(RuntimeType type) => default; // 0x000000018043C810-0x000000018043C820
		internal static bool HasElementType(RuntimeType type) => default; // 0x000000018043C840-0x000000018043C880
		internal static bool HasInstantiation(RuntimeType type) => default; // 0x000000018043C880-0x000000018043C890
		internal static bool IsArray(RuntimeType type) => default; // 0x000000018043C8A0-0x000000018043C8B0
		internal static bool IsByRef(RuntimeType type) => default; // 0x000000018043C8B0-0x000000018043C8C0
		internal static bool IsComObject(RuntimeType type) => default; // 0x0000000180289B70-0x0000000180289B80
		internal static bool IsInstanceOfType(RuntimeType type, object o) => default; // 0x000000018043C980-0x000000018043C990
		internal static bool IsPointer(RuntimeType type) => default; // 0x000000018043C9B0-0x000000018043C9C0
		internal static bool IsPrimitive(RuntimeType type) => default; // 0x000000018043C9C0-0x000000018043C9D0
		internal static bool HasReferences(RuntimeType type) => default; // 0x000000018043C890-0x000000018043C8A0
		internal static bool IsComObject(RuntimeType type, bool isGenericCOM) => default; // 0x000000018043C8C0-0x000000018043C8D0
		internal static bool IsContextful(RuntimeType type) => default; // 0x000000018043C8D0-0x000000018043C960
		internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) => default; // 0x0000000180250A70-0x0000000180250A80
		internal static bool IsSzArray(RuntimeType type) => default; // 0x000000018043C9D0-0x000000018043CA40
		internal static bool IsInterface(RuntimeType type) => default; // 0x000000018043C990-0x000000018043C9B0
		internal static int GetArrayRank(RuntimeType type) => default; // 0x000000018043C7B0-0x000000018043C7C0
		internal static RuntimeAssembly GetAssembly(RuntimeType type) => default; // 0x000000018043C7C0-0x000000018043C7D0
		internal static RuntimeType GetElementType(RuntimeType type) => default; // 0x000000018043C7F0-0x000000018043C800
		internal static RuntimeModule GetModule(RuntimeType type) => default; // 0x000000018043C830-0x000000018043C840
		internal static bool IsGenericVariable(RuntimeType type) => default; // 0x000000018043C970-0x000000018043C980
		internal static RuntimeType GetBaseType(RuntimeType type) => default; // 0x000000018043C7E0-0x000000018043C7F0
		internal static bool CanCastTo(RuntimeType type, RuntimeType target) => default; // 0x000000018043C7A0-0x000000018043C7B0
		private static bool type_is_assignable_from(Type a, Type b) => default; // 0x000000018043CA40-0x000000018043CA50
		internal static bool IsGenericTypeDefinition(RuntimeType type) => default; // 0x000000018043C960-0x000000018043C970
		internal static IntPtr GetGenericParameterInfo(RuntimeType type) => default; // 0x000000018043C800-0x000000018043C810
	}
}
