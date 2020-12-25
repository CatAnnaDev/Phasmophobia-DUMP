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
	[AttributeUsage(AttributeTargets.All)] // 0x0000000180146FA0-0x0000000180146FD0
	public abstract class Attribute // TypeDefIndex: 164
	{
		// Properties
		public virtual object TypeId { get; } // 0x000000018031A310-0x000000018031A320 
	
		// Constructors
		protected Attribute() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit) => default; // 0x000000018070BEE0-0x000000018070BF80
		private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit) => default; // 0x000000018070BE40-0x000000018070BEE0
		private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit) => default; // 0x000000018070BF80-0x000000018070C000
		private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit) => default; // 0x000000018070C000-0x000000018070C080
		public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit) => default; // 0x000000018070B930-0x000000018070BC80
		public static bool IsDefined(MemberInfo element, Type attributeType) => default; // 0x000000018070C320-0x000000018070C330
		public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit) => default; // 0x000000018070C080-0x000000018070C320
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) => default; // 0x000000018070B590-0x000000018070B640
		public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) => default; // 0x000000018070B420-0x000000018070B4E0
		public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit) => default; // 0x000000018070B700-0x000000018070B930
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType) => default; // 0x000000018070B4E0-0x000000018070B590
		public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) => default; // 0x000000018070B640-0x000000018070B700
		public override bool Equals(object obj) => default; // 0x000000018070B1B0-0x000000018070B420
		private static bool AreFieldValuesEqual(object thisValue, object thatValue) => default; // 0x000000018070B030-0x000000018070B1B0
		public override int GetHashCode() => default; // 0x000000018070BC80-0x000000018070BE40
		public virtual bool Match(object obj) => default; // 0x000000018070C330-0x000000018070C350
		public virtual bool IsDefaultAttribute() => default; // 0x0000000180250A70-0x0000000180250A80
	}
}
