/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ClassInterface] // 0x00000001800F11E0-0x00000001800F1220
	// [ComVisible] // 0x00000001800F11E0-0x00000001800F1220
	public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 347
	{
		// Fields
		private IntPtr method_ptr; // 0x10
		private IntPtr invoke_impl; // 0x18
		private object m_target; // 0x20
		private IntPtr method; // 0x28
		private IntPtr delegate_trampoline; // 0x30
		private IntPtr extra_arg; // 0x38
		private IntPtr method_code; // 0x40
		private MethodInfo method_info; // 0x48
		private MethodInfo original_method_info; // 0x50
		private DelegateData data; // 0x58
		private bool method_is_virtual; // 0x60
	
		// Properties
		public MethodInfo Method { get; } // 0x0000000180292830-0x0000000180292850 
		public object Target { get; } // 0x0000000180246FE0-0x0000000180246FF0 
	
		// Constructors
		protected Delegate() {} // Dummy constructor
	
		// Methods
		private MethodInfo GetVirtualMethod_internal() => default; // 0x00000001802922E0-0x00000001802922F0
		internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) => default; // 0x0000000180290BC0-0x0000000180290BD0
		private static bool arg_type_match(Type delArgType, Type argType) => default; // 0x00000001802924F0-0x00000001802926A0
		private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) => default; // 0x00000001802926A0-0x0000000180292830
		private static bool return_type_match(Type delReturnType, Type returnType) => default; // 0x00000001802928D0-0x0000000180292990
		public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure) => default; // 0x0000000180290BD0-0x0000000180290BF0
		private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) => default; // 0x0000000180290CF0-0x0000000180291670
		public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) => default; // 0x0000000180290BF0-0x0000000180290C10
		public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) => default; // 0x0000000180291990-0x00000001802919C0
		public static Delegate CreateDelegate(Type type, MethodInfo method) => default; // 0x0000000180291960-0x0000000180291990
		public static Delegate CreateDelegate(Type type, object target, string method) => default; // 0x0000000180290C10-0x0000000180290CF0
		private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) => default; // 0x0000000180291CA0-0x00000001802920E0
		public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) => default; // 0x00000001802919C0-0x0000000180291AE0
		public static Delegate CreateDelegate(Type type, Type target, string method) => default; // 0x0000000180291860-0x0000000180291960
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) => default; // 0x0000000180291760-0x0000000180291860
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) => default; // 0x0000000180291670-0x0000000180291760
		public virtual object Clone() => default; // 0x00000001802908F0-0x0000000180290900
		public override bool Equals(object obj) => default; // 0x0000000180291AE0-0x0000000180291CA0
		public override int GetHashCode() => default; // 0x00000001802920E0-0x0000000180292170
		protected virtual MethodInfo GetMethodImpl() => default; // 0x0000000180292220-0x00000001802922C0
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001802922C0-0x00000001802922E0
		public virtual Delegate[] GetInvocationList() => default; // 0x0000000180292170-0x0000000180292220
		public static Delegate Combine(Delegate a, Delegate b) => default; // 0x00000001802909E0-0x0000000180290BB0
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static Delegate Combine(params /* 0x00000001800D4E50-0x00000001800D4E60 */ Delegate[] delegates) => default; // 0x0000000180290970-0x00000001802909E0
		protected virtual Delegate CombineImpl(Delegate d) => default; // 0x0000000180290900-0x0000000180290970
		public static Delegate Remove(Delegate source, Delegate value) => default; // 0x0000000180292320-0x00000001802924F0
		protected virtual Delegate RemoveImpl(Delegate d) => default; // 0x00000001802922F0-0x0000000180292320
		public static bool operator ==(Delegate d1, Delegate d2) => default; // 0x0000000180292850-0x0000000180292880
		public static bool operator !=(Delegate d1, Delegate d2) => default; // 0x0000000180292880-0x00000001802928D0
		internal static Delegate CreateDelegateNoSecurityCheck(RuntimeType type, object firstArgument, MethodInfo method) => default; // 0x0000000180290BB0-0x0000000180290BC0
		internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) => default; // 0x00000001802908E0-0x00000001802908F0
	}
}
