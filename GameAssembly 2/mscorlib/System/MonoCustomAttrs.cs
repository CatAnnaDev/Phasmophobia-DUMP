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

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	internal static class MonoCustomAttrs // TypeDefIndex: 364
	{
		// Fields
		private static Assembly corlib; // 0x00
		[ThreadStatic] // 0x00000001800D4E50-0x00000001800D4E60
		private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
		private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x08
	
		// Nested types
		private class AttributeInfo // TypeDefIndex: 365
		{
			// Fields
			private AttributeUsageAttribute _usage; // 0x10
			private int _inheritanceLevel; // 0x18
	
			// Properties
			public AttributeUsageAttribute Usage { get => default; } // 0x0000000180248E10-0x0000000180248E20 
			public int InheritanceLevel { get => default; } // 0x000000018027A800-0x000000018027A810 
	
			// Constructors
			public AttributeInfo() {} // Dummy constructor
			public AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel) {} // 0x000000018067CA30-0x000000018067CA60
		}
	
		// Constructors
		static MonoCustomAttrs() {} // 0x0000000180683220-0x0000000180683290
	
		// Methods
		private static bool IsUserCattrProvider(object obj) => default; // 0x0000000180682BC0-0x0000000180682E40
		internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) => default; // 0x0000000180681780-0x0000000180681790
		internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) => default; // 0x0000000180682310-0x0000000180682740
		private static object[] GetPseudoCustomAttributes(Type type) => default; // 0x0000000180682740-0x00000001806828E0
		internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) => default; // 0x00000001806814F0-0x00000001806816D0
		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) => default; // 0x0000000180681790-0x00000001806821A0
		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) => default; // 0x00000001806821A0-0x0000000180682310
		private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) => default; // 0x00000001806816D0-0x00000001806816E0
		internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) => default; // 0x00000001806816E0-0x0000000180681780
		internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) => default; // 0x00000001806828F0-0x0000000180682BC0
		internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) => default; // 0x00000001806828E0-0x00000001806828F0
		private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) => default; // 0x0000000180680F00-0x0000000180681210
		private static EventInfo GetBaseEventDefinition(MonoEvent evt) => default; // 0x0000000180680D30-0x0000000180680F00
		private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) => default; // 0x0000000180681210-0x00000001806814F0
		private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) => default; // 0x0000000180682E40-0x00000001806830B0
		private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) => default; // 0x00000001806830B0-0x0000000180683220
	}
}
