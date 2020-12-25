/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 283
	{
		// Fields
		internal static readonly RuntimeType ValueType; // 0x00
		internal static readonly RuntimeType EnumType; // 0x08
		private static readonly RuntimeType ObjectType; // 0x10
		private static readonly RuntimeType StringType; // 0x18
		private static readonly RuntimeType DelegateType; // 0x20
		private static Type[] s_SICtorParamTypes; // 0x28
		private const BindingFlags MemberBindingMask = BindingFlags.Default | BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy; // Metadata: 0x0063006C
		private const BindingFlags InvocationMask = BindingFlags.Default | BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty; // Metadata: 0x00630070
		private const BindingFlags BinderNonCreateInstance = BindingFlags.Default | BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.SetField | BindingFlags.GetProperty | BindingFlags.SetProperty; // Metadata: 0x00630074
		private const BindingFlags BinderGetSetProperty = BindingFlags.Default | BindingFlags.GetProperty | BindingFlags.SetProperty; // Metadata: 0x00630078
		private const BindingFlags BinderSetInvokeProperty = BindingFlags.Default | BindingFlags.InvokeMethod | BindingFlags.SetProperty; // Metadata: 0x0063007C
		private const BindingFlags BinderGetSetField = BindingFlags.Default | BindingFlags.GetField | BindingFlags.SetField; // Metadata: 0x00630080
		private const BindingFlags BinderSetInvokeField = BindingFlags.Default | BindingFlags.InvokeMethod | BindingFlags.SetField; // Metadata: 0x00630084
		private const BindingFlags BinderNonFieldGetSet = BindingFlags.Default | BindingFlags.InvokeMethod | BindingFlags.CreateInstance | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty | BindingFlags.ExactBinding | BindingFlags.SuppressChangeType | BindingFlags.OptionalParamBinding; // Metadata: 0x00630088
		private const BindingFlags ClassicBindingMask = BindingFlags.Default | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.PutDispProperty | BindingFlags.PutRefDispProperty; // Metadata: 0x0063008C
		private static RuntimeType s_typedRef; // 0x30
		[NonSerialized]
		private MonoTypeInfo type_info; // 0x18
		internal object GenericCache; // 0x20
		private RuntimeConstructorInfo m_serializationCtor; // 0x28
	
		// Properties
		public override Module Module { get => default; } // 0x000000018043C830-0x000000018043C840 
		public override Assembly Assembly { get => default; } // 0x000000018043C7C0-0x000000018043C7D0 
		public override RuntimeTypeHandle TypeHandle { get => default; } // 0x00000001802A8A40-0x00000001802A8A60 
		public override Type BaseType { get => default; } // 0x0000000180447400-0x0000000180447410 
		public override Type UnderlyingSystemType { get => default; } // 0x00000001802A78B0-0x00000001802A78C0 
		public override bool IsEnum { get => default; } // 0x00000001804477F0-0x0000000180447860 
		public override GenericParameterAttributes GenericParameterAttributes { get => default; } // 0x0000000180447640-0x0000000180447710 
		internal override bool IsSzArray { get => default; } // 0x000000018043C9D0-0x000000018043CA40 
		public override bool IsGenericTypeDefinition { get => default; } // 0x000000018043C960-0x000000018043C970 
		public override bool IsGenericParameter { get => default; } // 0x000000018043C970-0x000000018043C980 
		public override int GenericParameterPosition { get => default; } // 0x0000000180447710-0x00000001804477A0 
		public override bool IsGenericType { get => default; } // 0x000000018043C880-0x000000018043C890 
		public override bool IsConstructedGenericType { get => default; } // 0x00000001804477A0-0x00000001804477F0 
		public override MemberTypes MemberType { get => default; } // 0x0000000180447860-0x00000001804478A0 
		public override Type ReflectedType { get => default; } // 0x00000001804478C0-0x00000001804478E0 
		public override int MetadataToken { get => default; } // 0x000000018043C820-0x000000018043C830 
		public override bool ContainsGenericParameters { get => default; } // 0x0000000180447410-0x0000000180447530 
		public override MethodBase DeclaringMethod { get => default; } // 0x00000001802922E0-0x00000001802922F0 
		public override string AssemblyQualifiedName { get => default; } // 0x00000001804473F0-0x0000000180447400 
		public override Type DeclaringType { get => default; } // 0x0000000180447530-0x0000000180447540 
		public override string Name { get => default; } // 0x00000001804478A0-0x00000001804478B0 
		public override string Namespace { get => default; } // 0x00000001804478B0-0x00000001804478C0 
		public override string FullName { get => default; } // 0x0000000180447540-0x0000000180447640 
	
		// Nested types
		internal enum MemberListType // TypeDefIndex: 284
		{
			All = 0,
			CaseSensitive = 1,
			CaseInsensitive = 2,
			HandleToInfo = 3
		}
	
		private struct ListBuilder<T> // TypeDefIndex: 285
			where T : class
		{
			// Fields
			private T[] _items;
			private T _item;
			private int _count;
			private int _capacity;
	
			// Properties
			public T this[int index] { get => default; }
			public int Count { get => default; }
	
			// Constructors
			public ListBuilder(int capacity) : this() {
				_items = default;
				_item = default;
				_count = default;
				_capacity = default;
			}
	
			// Methods
			public T[] ToArray() => default;
			public void CopyTo(object[] array, int index) {}
			public void Add(T item) {}
		}
	
		// Constructors
		internal RuntimeType() {} // 0x0000000180447380-0x00000001804473E0
		static RuntimeType() {} // 0x0000000180447050-0x0000000180447380
	
		// Methods
		private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) {} // 0x0000000180446C70-0x0000000180446DB0
		internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) {} // 0x0000000180446930-0x0000000180446B70
		private static void SplitName(string fullname, out string name, out string ns) {
			name = default;
			ns = default;
		} // 0x0000000180446B70-0x0000000180446C70
		private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out MemberListType listType) {
			prefixLookup = default;
			ignoreCase = default;
			listType = default;
		} // 0x000000018043E3B0-0x000000018043E500
		private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out MemberListType listType) {
			ignoreCase = default;
			listType = default;
		} // 0x000000018043E500-0x000000018043E610
		private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) => default; // 0x000000018043E210-0x000000018043E290
		private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) => default; // 0x000000018043DC10-0x000000018043DDF0
		private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) => default; // 0x000000018043E290-0x000000018043E3B0
		private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) => default; // 0x000000018043E160-0x000000018043E210
		private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) => default; // 0x000000018043DDF0-0x000000018043DEA0
		private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) => default; // 0x000000018043DEA0-0x000000018043E160
		internal bool IsSpecialSerializableType() => default; // 0x0000000180446010-0x00000001804460F0
		private ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) => default; // 0x0000000180441BE0-0x0000000180441EC0
		private ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) => default; // 0x000000018043EAF0-0x000000018043EE60
		private ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) => default; // 0x0000000180443130-0x0000000180443420
		private ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) => default; // 0x000000018043FD50-0x0000000180440010
		private ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) => default; // 0x00000001804405F0-0x00000001804408B0
		private ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) => default; // 0x00000001804424E0-0x0000000180442790
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr) => default; // 0x0000000180442440-0x00000001804424E0
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) => default; // 0x000000018043F2D0-0x000000018043F370
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) => default; // 0x00000001804430A0-0x0000000180443130
		public override EventInfo[] GetEvents(BindingFlags bindingAttr) => default; // 0x0000000180440550-0x00000001804405E0
		public override FieldInfo[] GetFields(BindingFlags bindingAttr) => default; // 0x0000000180440FC0-0x0000000180441050
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) => default; // 0x0000000180441EC0-0x0000000180442130
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) => default; // 0x000000018043EE60-0x000000018043F060
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) => default; // 0x0000000180443420-0x00000001804436A0
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr) => default; // 0x0000000180440010-0x0000000180440260
		public override FieldInfo GetField(string name, BindingFlags bindingAttr) => default; // 0x00000001804408B0-0x0000000180440CD0
		public override Type GetInterface(string fullname, bool ignoreCase) => default; // 0x0000000180441410-0x0000000180441820
		public override Type GetNestedType(string fullname, BindingFlags bindingAttr) => default; // 0x0000000180442790-0x0000000180442A50
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) => default; // 0x0000000180441830-0x0000000180441BE0
		internal RuntimeModule GetRuntimeModule() => default; // 0x000000018043C830-0x000000018043C840
		internal RuntimeAssembly GetRuntimeAssembly() => default; // 0x000000018043C7C0-0x000000018043C7D0
		public override bool IsInstanceOfType(object o) => default; // 0x000000018043C980-0x000000018043C990
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public override bool IsSubclassOf(Type type) => default; // 0x00000001804460F0-0x0000000180446290
		public override bool IsAssignableFrom(Type c) => default; // 0x0000000180444C00-0x0000000180444CF0
		public override bool IsEquivalentTo(Type other) => default; // 0x0000000180445F50-0x0000000180446010
		private RuntimeType GetBaseType() => default; // 0x000000018043E840-0x000000018043EA70
		protected override TypeAttributes GetAttributeFlagsImpl() => default; // 0x000000018043C7D0-0x000000018043C7E0
		protected override bool IsContextfulImpl() => default; // 0x000000018043C8D0-0x000000018043C960
		protected override bool IsByRefImpl() => default; // 0x000000018043C8B0-0x000000018043C8C0
		protected override bool IsPrimitiveImpl() => default; // 0x000000018043C9C0-0x000000018043C9D0
		protected override bool IsPointerImpl() => default; // 0x000000018043C9B0-0x000000018043C9C0
		protected override bool IsCOMObjectImpl() => default; // 0x0000000180289B70-0x0000000180289B80
		protected override bool IsValueTypeImpl() => default; // 0x0000000180446290-0x00000001804463A0
		protected override bool HasElementTypeImpl() => default; // 0x000000018043C840-0x000000018043C880
		protected override bool IsArrayImpl() => default; // 0x000000018043C8A0-0x000000018043C8B0
		public override int GetArrayRank() => default; // 0x000000018043E7B0-0x000000018043E840
		public override Type GetElementType() => default; // 0x000000018043C7F0-0x000000018043C800
		public override string[] GetEnumNames() => default; // 0x000000018043F9F0-0x000000018043FAE0
		public override Array GetEnumValues() => default; // 0x000000018043FBA0-0x000000018043FD50
		public override Type GetEnumUnderlyingType() => default; // 0x000000018043FAE0-0x000000018043FBA0
		public override bool IsEnumDefined(object value) => default; // 0x0000000180445A10-0x0000000180445F50
		public override string GetEnumName(object value) => default; // 0x000000018043F810-0x000000018043F9F0
		internal RuntimeType[] GetGenericArgumentsInternal() => default; // 0x0000000180441060-0x00000001804410D0
		public override Type[] GetGenericArguments() => default; // 0x00000001804410E0-0x0000000180441150
		public override Type MakeGenericType(params /* 0x00000001800D4E50-0x00000001800D4E60 */ Type[] instantiation) => default; // 0x00000001804464B0-0x00000001804468D0
		public override Type GetGenericTypeDefinition() => default; // 0x00000001804412A0-0x0000000180441330
		[DebuggerHidden] // 0x00000001800D5490-0x00000001800D54C0
		[DebuggerStepThrough] // 0x00000001800D5490-0x00000001800D54C0
		public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) => default; // 0x0000000180443910-0x0000000180444C00
		public override bool Equals(object obj) => default; // 0x000000018043DC00-0x000000018043DC10
		public static bool operator ==(RuntimeType left, RuntimeType right) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(RuntimeType left, RuntimeType right) => default; // 0x00000001802A78C0-0x00000001802A7960
		public object Clone() => default; // 0x00000001802A78B0-0x00000001802A78C0
		public void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180442D10-0x0000000180442D90
		public override object[] GetCustomAttributes(bool inherit) => default; // 0x000000018043F390-0x000000018043F440
		public override object[] GetCustomAttributes(Type attributeType, bool inherit) => default; // 0x000000018043F440-0x000000018043F5B0
		public override bool IsDefined(Type attributeType, bool inherit) => default; // 0x00000001804458A0-0x0000000180445A10
		public override IList<CustomAttributeData> GetCustomAttributesData() => default; // 0x000000018043F380-0x000000018043F390
		internal override string FormatTypeName(bool serialization) => default; // 0x000000018043E610-0x000000018043E7B0
		private void CreateInstanceCheckThis() {} // 0x000000018043CC50-0x000000018043CE90
		internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) => default; // 0x000000018043D130-0x000000018043D8E0
		[DebuggerHidden] // 0x00000001800D5490-0x00000001800D54C0
		[DebuggerStepThrough] // 0x00000001800D5490-0x00000001800D54C0
		internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) => default; // 0x000000018043CE90-0x000000018043CFA0
		internal MonoCMethod GetDefaultConstructor() => default; // 0x000000018043F5B0-0x000000018043F730
		private string GetDefaultMemberName() => default; // 0x000000018043F730-0x000000018043F810
		internal RuntimeConstructorInfo GetSerializationCtor() => default; // 0x00000001804436A0-0x00000001804438B0
		internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) => default; // 0x000000018043DBC0-0x000000018043DC00
		private object CreateInstanceMono(bool nonPublic) => default; // 0x000000018043D8F0-0x000000018043DBC0
		internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) => default; // 0x000000018043CA50-0x000000018043CC50
		private object TryConvertToType(object value, ref bool failed) => default; // 0x0000000180446DC0-0x0000000180447050
		private static object IsConvertibleToPrimitiveType(object value, Type targetType) => default; // 0x0000000180444CF0-0x00000001804458A0
		private string GetCachedName(TypeNameKind kind) => default; // 0x000000018043EA70-0x000000018043EAF0
		private Type make_array_type(int rank) => default; // 0x00000001804478E0-0x00000001804478F0
		public override Type MakeArrayType() => default; // 0x00000001804463A0-0x00000001804463B0
		public override Type MakeArrayType(int rank) => default; // 0x00000001804463B0-0x0000000180446430
		private Type make_byref_type() => default; // 0x00000001804478F0-0x0000000180447A90
		public override Type MakeByRefType() => default; // 0x0000000180446430-0x00000001804464A0
		private static Type MakePointerType(Type type) => default; // 0x0000000180446920-0x0000000180446930
		public override Type MakePointerType() => default; // 0x00000001804468D0-0x0000000180446920
		public override Type[] GetGenericParameterConstraints() => default; // 0x00000001804411A0-0x0000000180441290
		internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) => default; // 0x000000018043CFA0-0x000000018043D130
		private static Type MakeGenericType(Type gt, Type[] types) => default; // 0x00000001804464A0-0x00000001804464B0
		internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) => default; // 0x0000000180442430-0x0000000180442440
		internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) => default; // 0x0000000180442130-0x0000000180442430
		private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) => default; // 0x0000000180443090-0x00000001804430A0
		private IntPtr GetConstructors_native(BindingFlags bindingAttr) => default; // 0x000000018043F370-0x000000018043F380
		private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) => default; // 0x000000018043F060-0x000000018043F2D0
		private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) => default; // 0x0000000180442D90-0x0000000180443090
		protected override TypeCode GetTypeCodeImpl() => default; // 0x00000001804438C0-0x0000000180443910
		private static TypeCode GetTypeCodeImplInternal(Type type) => default; // 0x00000001804438B0-0x00000001804438C0
		public override string ToString() => default; // 0x0000000180446DB0-0x0000000180446DC0
		private bool IsGenericCOMObjectImpl() => default; // 0x0000000180250A70-0x0000000180250A80
		private static object CreateInstanceInternal(Type type) => default; // 0x000000018043D8E0-0x000000018043D8F0
		internal string getFullName(bool full_name, bool assembly_qualified) => default; // 0x00000001804473E0-0x00000001804473F0
		private Type[] GetGenericArgumentsInternal(bool runtimeArray) => default; // 0x00000001804410D0-0x00000001804410E0
		private GenericParameterAttributes GetGenericParameterAttributes() => default; // 0x0000000180441150-0x00000001804411A0
		private int GetGenericParameterPosition() => default; // 0x0000000180441290-0x00000001804412A0
		private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) => default; // 0x00000001804405E0-0x00000001804405F0
		private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) => default; // 0x0000000180441050-0x0000000180441060
		private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) => default; // 0x0000000180440CD0-0x0000000180440FC0
		private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) => default; // 0x0000000180440260-0x0000000180440550
		public override Type[] GetInterfaces() => default; // 0x0000000180441820-0x0000000180441830
		private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) => default; // 0x0000000180442D00-0x0000000180442D10
		private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) => default; // 0x0000000180442A50-0x0000000180442D00
		public override int GetHashCode() => default; // 0x0000000180441330-0x0000000180441410
	}
}
