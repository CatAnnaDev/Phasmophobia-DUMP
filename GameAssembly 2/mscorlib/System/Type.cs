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
	// [ClassInterface] // 0x00000001800ED6E0-0x00000001800ED760
	// [ComDefaultInterface] // 0x00000001800ED6E0-0x00000001800ED760
	// [ComVisible] // 0x00000001800ED6E0-0x00000001800ED760
	public abstract class Type : MemberInfo, _Type // TypeDefIndex: 313
	{
		// Fields
		public static readonly MemberFilter FilterAttribute; // 0x00
		public static readonly MemberFilter FilterName; // 0x08
		public static readonly MemberFilter FilterNameIgnoreCase; // 0x10
		public static readonly object Missing; // 0x18
		public static readonly char Delimiter; // 0x20
		public static readonly Type[] EmptyTypes; // 0x28
		private static Binder defaultBinder; // 0x30
		private const BindingFlags DefaultLookup = BindingFlags.Default | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public; // Metadata: 0x0063020A
		internal const BindingFlags DeclaredOnlyLookup = BindingFlags.Default | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic; // Metadata: 0x0063020E
		internal RuntimeTypeHandle _impl; // 0x10
	
		// Properties
		public override MemberTypes MemberType { get; } // 0x00000001804AB860-0x00000001804AB870 
		public override Type DeclaringType { get; } // 0x0000000180246C90-0x0000000180246CA0 
		public virtual MethodBase DeclaringMethod { get; } // 0x0000000180246C90-0x0000000180246CA0 
		public override Type ReflectedType { get; } // 0x0000000180246C90-0x0000000180246CA0 
		public static Binder DefaultBinder { get; } // 0x00000001804AAE20-0x00000001804AAF90 
		public abstract Module Module { get; }
		public abstract Assembly Assembly { get; }
		public virtual RuntimeTypeHandle TypeHandle { get; } // 0x00000001804AB870-0x00000001804AB8C0 
		public abstract string FullName { get; }
		public abstract string Namespace { get; }
		public abstract string AssemblyQualifiedName { get; }
		public abstract Type BaseType { get; }
		public bool IsNested { get; } // 0x00000001804AB440-0x00000001804AB4B0 
		public TypeAttributes Attributes { get; } // 0x00000001804AACA0-0x00000001804AACC0 
		public virtual GenericParameterAttributes GenericParameterAttributes { get; } // 0x00000001804AAF90-0x00000001804AAFE0 
		public bool IsVisible { get; } // 0x00000001804AB670-0x00000001804AB860 
		public bool IsNotPublic { get; } // 0x00000001804AB4B0-0x00000001804AB4D0 
		public bool IsPublic { get; } // 0x00000001804AB510-0x00000001804AB530 
		public bool IsNestedPublic { get; } // 0x00000001804AB420-0x00000001804AB440 
		public bool IsNestedAssembly { get; } // 0x00000001804AB3F0-0x00000001804AB420 
		public bool IsExplicitLayout { get; } // 0x00000001804AB2E0-0x00000001804AB300 
		public bool IsClass { get; } // 0x00000001804AB1B0-0x00000001804AB200 
		public bool IsInterface { get; } // 0x00000001804AB300-0x00000001804AB3D0 
		public bool IsValueType { get; } // 0x00000001804AB650-0x00000001804AB670 
		public bool IsAbstract { get; } // 0x00000001804AB120-0x00000001804AB150 
		public bool IsSealed { get; } // 0x00000001804AB530-0x00000001804AB560 
		public virtual bool IsEnum { get; } // 0x00000001804AB270-0x00000001804AB2E0 
		public virtual bool IsSerializable { get; } // 0x00000001804AB560-0x00000001804AB650 
		public bool IsArray { get; } // 0x00000001804AB150-0x00000001804AB170 
		internal virtual bool IsSzArray { get; } // 0x0000000180250A70-0x0000000180250A80 
		public virtual bool IsGenericType { get; } // 0x0000000180250A70-0x0000000180250A80 
		public virtual bool IsGenericTypeDefinition { get; } // 0x0000000180250A70-0x0000000180250A80 
		public virtual bool IsConstructedGenericType { get; } // 0x00000001804AB200-0x00000001804AB250 
		public virtual bool IsGenericParameter { get; } // 0x0000000180250A70-0x0000000180250A80 
		public virtual int GenericParameterPosition { get; } // 0x00000001804AAFE0-0x00000001804AB050 
		public virtual bool ContainsGenericParameters { get; } // 0x00000001804AACC0-0x00000001804AAE20 
		public bool IsByRef { get; } // 0x00000001804AB170-0x00000001804AB190 
		public bool IsPointer { get; } // 0x00000001804AB4D0-0x00000001804AB4F0 
		public bool IsPrimitive { get; } // 0x00000001804AB4F0-0x00000001804AB510 
		public bool IsCOMObject { get; } // 0x00000001804AB190-0x00000001804AB1B0 
		public bool HasElementType { get; } // 0x00000001804AB100-0x00000001804AB120 
		public bool IsContextful { get; } // 0x00000001804AB250-0x00000001804AB270 
		public bool IsMarshalByRef { get; } // 0x00000001804AB3D0-0x00000001804AB3F0 
		public virtual Type[] GenericTypeArguments { get; } // 0x00000001804AB050-0x00000001804AB100 
		public abstract Type UnderlyingSystemType { get; }
	
		// Constructors
		protected Type() {} // 0x0000000180289A80-0x0000000180289A90
		static Type() {} // 0x00000001804AAA80-0x00000001804AACA0
	
		// Methods
		public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver) => default; // 0x00000001804A9430-0x00000001804A9470
		public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) => default; // 0x00000001804A9890-0x00000001804A98C0
		public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) => default; // 0x00000001804A9690-0x00000001804A96D0
		public virtual Type MakePointerType() => default; // 0x00000001804AA9E0-0x00000001804AAA30
		public virtual Type MakeByRefType() => default; // 0x00000001804AA920-0x00000001804AA970
		public virtual Type MakeArrayType() => default; // 0x00000001804AA880-0x00000001804AA8D0
		public virtual Type MakeArrayType(int rank) => default; // 0x00000001804AA8D0-0x00000001804AA920
		public static TypeCode GetTypeCode(Type type) => default; // 0x00000001804A9260-0x00000001804A92D0
		protected virtual TypeCode GetTypeCodeImpl() => default; // 0x00000001804A9100-0x00000001804A9260
		private static void CreateBinder() {} // 0x00000001804A7220-0x00000001804A72F0
		public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
		public static RuntimeTypeHandle GetTypeHandle(object o) => default; // 0x00000001804A9340-0x00000001804A9430
		public virtual int GetArrayRank() => default; // 0x00000001804A7670-0x00000001804A76E0
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) => default; // 0x00000001804A7990-0x00000001804A7AF0
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) => default; // 0x00000001804A7830-0x00000001804A7990
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public ConstructorInfo GetConstructor(Type[] types) => default; // 0x00000001804A76E0-0x00000001804A7830
		protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) => default; // 0x00000001804A88E0-0x00000001804A8A90
		public MethodInfo GetMethod(string name, Type[] types) => default; // 0x00000001804A8740-0x00000001804A88E0
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr) => default; // 0x00000001804A8A90-0x00000001804A8B40
		public MethodInfo GetMethod(string name) => default; // 0x00000001804A8B40-0x00000001804A8BF0
		protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
		public MethodInfo[] GetMethods() => default; // 0x00000001804A8BF0-0x00000001804A8C10
		public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);
		public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);
		public FieldInfo GetField(string name) => default; // 0x00000001804A8430-0x00000001804A8450
		public FieldInfo[] GetFields() => default; // 0x00000001804A8450-0x00000001804A8470
		public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);
		public Type GetInterface(string name) => default; // 0x00000001804A8660-0x00000001804A8680
		public abstract Type GetInterface(string name, bool ignoreCase);
		public abstract Type[] GetInterfaces();
		public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria) => default; // 0x00000001804A73F0-0x00000001804A7600
		public EventInfo GetEvent(string name) => default; // 0x00000001804A8410-0x00000001804A8430
		public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);
		public abstract EventInfo[] GetEvents(BindingFlags bindingAttr);
		public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) => default; // 0x00000001804A8CF0-0x00000001804A8DE0
		public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) => default; // 0x00000001804A8EE0-0x00000001804A8F90
		public PropertyInfo GetProperty(string name, Type returnType, Type[] types) => default; // 0x00000001804A8DE0-0x00000001804A8EE0
		public PropertyInfo GetProperty(string name, Type returnType) => default; // 0x00000001804A8F90-0x00000001804A90A0
		public PropertyInfo GetProperty(string name) => default; // 0x00000001804A8C50-0x00000001804A8CF0
		protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
		public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);
		public PropertyInfo[] GetProperties() => default; // 0x00000001804A8C30-0x00000001804A8C50
		public Type GetNestedType(string name) => default; // 0x00000001804A8C10-0x00000001804A8C30
		public abstract Type GetNestedType(string name, BindingFlags bindingAttr);
		public MemberInfo[] GetMember(string name) => default; // 0x00000001804A86F0-0x00000001804A8710
		public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) => default; // 0x00000001804A8710-0x00000001804A8740
		public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) => default; // 0x00000001804A8680-0x00000001804A86F0
		public virtual Type[] GetGenericParameterConstraints() => default; // 0x00000001804A84E0-0x00000001804A8590
		protected virtual bool IsValueTypeImpl() => default; // 0x00000001804AA810-0x00000001804AA880
		protected abstract TypeAttributes GetAttributeFlagsImpl();
		protected abstract bool IsArrayImpl();
		protected abstract bool IsByRefImpl();
		protected abstract bool IsPointerImpl();
		protected abstract bool IsPrimitiveImpl();
		protected abstract bool IsCOMObjectImpl();
		public virtual Type MakeGenericType(params /* 0x00000001800D4E50-0x00000001800D4E60 */ Type[] typeArguments) => default; // 0x00000001804AA970-0x00000001804AA9E0
		protected virtual bool IsContextfulImpl() => default; // 0x00000001804A9D10-0x00000001804A9DE0
		protected virtual bool IsMarshalByRefImpl() => default; // 0x00000001804AA670-0x00000001804AA740
		public abstract Type GetElementType();
		public virtual Type[] GetGenericArguments() => default; // 0x00000001804A8470-0x00000001804A84E0
		public virtual Type GetGenericTypeDefinition() => default; // 0x00000001804A8590-0x00000001804A8600
		protected abstract bool HasElementTypeImpl();
		internal Type GetRootElementType() => default; // 0x00000001804A90A0-0x00000001804A9100
		public virtual string[] GetEnumNames() => default; // 0x00000001804A8140-0x00000001804A8200
		public virtual Array GetEnumValues() => default; // 0x00000001804A8350-0x00000001804A8410
		private Array GetEnumRawConstantValues() => default; // 0x00000001804A8200-0x00000001804A8230
		private void GetEnumData(out string[] enumNames, out Array enumValues) {
			enumNames = default;
			enumValues = default;
		} // 0x00000001804A7AF0-0x00000001804A7F10
		public virtual Type GetEnumUnderlyingType() => default; // 0x00000001804A8230-0x00000001804A8350
		public virtual bool IsEnumDefined(object value) => default; // 0x00000001804A9DE0-0x00000001804AA310
		public virtual string GetEnumName(object value) => default; // 0x00000001804A7F10-0x00000001804A8140
		private static int BinarySearch(Array array, object value) => default; // 0x00000001804A70F0-0x00000001804A7220
		internal static bool IsIntegerType(Type t) => default; // 0x00000001804AA3B0-0x00000001804AA670
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public virtual bool IsSubclassOf(Type c) => default; // 0x00000001804AA740-0x00000001804AA810
		public virtual bool IsInstanceOfType(object o) => default; // 0x00000001804AA370-0x00000001804AA3B0
		public virtual bool IsAssignableFrom(Type c) => default; // 0x00000001804A9A60-0x00000001804A9D10
		public virtual bool IsEquivalentTo(Type other) => default; // 0x00000001804AA310-0x00000001804AA370
		internal bool ImplementInterface(Type ifaceType) => default; // 0x00000001804A98C0-0x00000001804A9A60
		internal string FormatTypeName() => default; // 0x00000001804A7600-0x00000001804A7620
		internal virtual string FormatTypeName(bool serialization) => default; // 0x00000001804A7620-0x00000001804A7670
		public override string ToString() => default; // 0x00000001804AAA30-0x00000001804AAA80
		public override bool Equals(object o) => default; // 0x00000001804A7350-0x00000001804A73F0
		public virtual bool Equals(Type o) => default; // 0x00000001804A72F0-0x00000001804A7350
		public static bool operator ==(Type left, Type right) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(Type left, Type right) => default; // 0x00000001802A78C0-0x00000001802A7960
		public override int GetHashCode() => default; // 0x00000001804A8600-0x00000001804A8660
		public new Type GetType() => default; // 0x000000018031A310-0x000000018031A320
		private static Type internal_from_name(string name, bool throwOnError, bool ignoreCase) => default; // 0x00000001804AB8D0-0x00000001804AB8E0
		public static Type GetType(string typeName) => default; // 0x00000001804A96D0-0x00000001804A9890
		public static Type GetType(string typeName, bool throwOnError) => default; // 0x00000001804A9600-0x00000001804A9690
		public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) => default; // 0x00000001804A9470-0x00000001804A9600
		public static Type GetTypeFromHandle(RuntimeTypeHandle handle) => default; // 0x00000001804A92D0-0x00000001804A9340
		private static Type internal_from_handle(IntPtr handle) => default; // 0x00000001804AB8C0-0x00000001804AB8D0
	}
}
