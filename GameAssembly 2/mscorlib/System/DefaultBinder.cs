/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	internal class DefaultBinder : Binder // TypeDefIndex: 193
	{
		// Nested types
		internal class BinderState // TypeDefIndex: 194
		{
			// Fields
			internal int[] m_argsMap; // 0x10
			internal int m_originalSize; // 0x18
			internal bool m_isParamArray; // 0x1C
	
			// Constructors
			public BinderState() {} // Dummy constructor
			internal BinderState(int[] argsMap, int originalSize, bool isParamArray) {} // 0x0000000180288410-0x0000000180288470
		}
	
		// Constructors
		public DefaultBinder() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) {
			state = default;
			return default;
		} // 0x000000018028A390-0x000000018028CD40
		public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) => default; // 0x0000000180289D80-0x000000018028A390
		public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018028ED70-0x000000018028F4B0
		public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) => default; // 0x000000018028F4B0-0x000000018028FE80
		public override object ChangeType(object value, Type type, CultureInfo cultureInfo) => default; // 0x000000018028D0A0-0x000000018028D110
		public override void ReorderArgumentArray(ref object[] args, object state) {} // 0x000000018028E820-0x000000018028EBA0
		public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018028D510-0x000000018028D880
		public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018028D880-0x000000018028DBA0
		private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) => default; // 0x000000018028E320-0x000000018028E790
		private static int FindMostSpecificType(Type c1, Type c2, Type t) => default; // 0x000000018028E000-0x000000018028E320
		private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) => default; // 0x000000018028DDA0-0x000000018028E000
		private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) => default; // 0x000000018028DCC0-0x000000018028DDA0
		private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) => default; // 0x000000018028DCC0-0x000000018028DDA0
		internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) => default; // 0x000000018028D110-0x000000018028D2A0
		internal static int GetHierarchyDepth(Type t) => default; // 0x000000018028E790-0x000000018028E820
		internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) => default; // 0x000000018028DBA0-0x000000018028DCC0
		private static void ReorderParams(int[] paramOrder, object[] vars) {} // 0x000000018028EBA0-0x000000018028ED70
		private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) => default; // 0x000000018028D2A0-0x000000018028D510
		private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) => default; // 0x000000018028CE40-0x000000018028D0A0
		private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) => default; // 0x000000018028CD40-0x000000018028CE40
	}
}
