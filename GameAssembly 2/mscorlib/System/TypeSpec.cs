/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	internal class TypeSpec // TypeDefIndex: 405
	{
		// Fields
		private TypeIdentifier name; // 0x10
		private string assembly_name; // 0x18
		private List<TypeIdentifier> nested; // 0x20
		private List<TypeSpec> generic_params; // 0x28
		private List<ModifierSpec> modifier_spec; // 0x30
		private bool is_byref; // 0x38
		private string display_fullname; // 0x40
	
		// Properties
		internal bool HasModifiers { get => default; } // 0x0000000180448BE0-0x0000000180448BF0 
		internal string DisplayFullName { get => default; } // 0x0000000180A73140-0x0000000180A731F0 
	
		// Nested types
		[Flags] // 0x00000001800D4E50-0x00000001800D4E60
		internal enum DisplayNameFormat // TypeDefIndex: 406
		{
			Default = 0,
			WANT_ASSEMBLY = 1,
			NO_MODIFIERS = 2
		}
	
		// Constructors
		public TypeSpec() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		private string GetDisplayFullName(DisplayNameFormat flags) => default; // 0x0000000180A712D0-0x0000000180A71780
		private StringBuilder GetModifierString(StringBuilder sb) => default; // 0x0000000180A71780-0x0000000180A71970
		internal static TypeSpec Parse(string typeName) => default; // 0x0000000180A71970-0x0000000180A71A30
		internal static string UnescapeInternalName(string displayName) => default; // 0x0000000180A73060-0x0000000180A73140
		internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) => default; // 0x0000000180A72750-0x0000000180A72FB0
		private void AddName(string type_name) {} // 0x0000000180A71170-0x0000000180A71250
		private void AddModifier(ModifierSpec md) {} // 0x0000000180A710D0-0x0000000180A71170
		private static void SkipSpace(string name, ref int pos) {} // 0x0000000180A72FB0-0x0000000180A73060
		private static void BoundCheck(int idx, string s) {} // 0x0000000180A71250-0x0000000180A712D0
		private static TypeIdentifier ParsedTypeIdentifier(string displayName) => default; // 0x0000000180A70610-0x0000000180A70680
		private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) => default; // 0x0000000180A71A30-0x0000000180A72750
	}
}
