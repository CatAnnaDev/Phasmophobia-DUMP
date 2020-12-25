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
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public abstract struct Enum : IComparable, IFormattable, IConvertible // TypeDefIndex: 201
	{
		// Fields
		private static readonly char[] enumSeperatorCharArray; // 0x00
		private const string enumSeperator = ", "; // Metadata: 0x0062FD86
	
		// Nested types
		private enum ParseFailureKind // TypeDefIndex: 202
		{
			None = 0,
			Argument = 1,
			ArgumentNull = 2,
			ArgumentWithParameter = 3,
			UnhandledException = 4
		}
	
		private struct EnumResult // TypeDefIndex: 203
		{
			// Fields
			internal object parsedEnum; // 0x00
			internal bool canThrow; // 0x08
			internal ParseFailureKind m_failure; // 0x0C
			internal string m_failureMessageID; // 0x10
			internal string m_failureParameter; // 0x18
			internal object m_failureMessageFormatArgument; // 0x20
			internal Exception m_innerException; // 0x28
	
			// Methods
			internal void Init(bool canMethodThrow) {} // 0x0000000180007EA0-0x0000000180007F10
			internal void SetFailure(Exception unhandledException) {} // 0x0000000180007F20-0x0000000180007F40
			internal void SetFailure(ParseFailureKind failure, string failureParameter) {} // 0x0000000180007F40-0x0000000180007F70
			internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) {} // 0x0000000180007F10-0x0000000180007F20
			internal Exception GetEnumParseException() => default; // 0x0000000180007E90-0x0000000180007EA0
		}
	
		private class ValuesAndNames // TypeDefIndex: 204
		{
			// Fields
			public ulong[] Values; // 0x10
			public string[] Names; // 0x18
	
			// Constructors
			public ValuesAndNames() {} // Dummy constructor
			public ValuesAndNames(ulong[] values, string[] names) {} // 0x0000000180294750-0x00000001802947A0
		}
	
		// Constructors
		protected Enum() {
	
		} // 0x0000000180289A80-0x0000000180289A90
		static Enum() {
			enumSeperatorCharArray = default;
		} // 0x0000000180318080-0x0000000180318100
	
		// Methods
		private static ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames) => default; // 0x0000000180313B60-0x0000000180313CD0
		private static string InternalFormattedHexString(object value) => default; // 0x0000000180314B00-0x0000000180314F70
		private static string InternalFormat(RuntimeType eT, object value) => default; // 0x0000000180314950-0x0000000180314B00
		private static string InternalFlagsFormat(RuntimeType eT, object value) => default; // 0x0000000180314560-0x0000000180314950
		internal static ulong ToUInt64(object value) => default; // 0x0000000180317850-0x00000001803179F0
		private static int InternalCompareTo(object o1, object o2) => default; // 0x0000000180314550-0x0000000180314560
		internal static RuntimeType InternalGetUnderlyingType(RuntimeType enumType) => default; // 0x0000000180314FE0-0x0000000180314FF0
		private static bool GetEnumValuesAndNames(RuntimeType enumType, out ulong[] values, out string[] names) {
			values = default;
			names = default;
			return default;
		} // 0x0000000180313CD0-0x0000000180313CE0
		private static object InternalBoxEnum(RuntimeType enumType, long value) => default; // 0x0000000180314540-0x0000000180314550
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static object Parse(Type enumType, string value) => default; // 0x0000000180315130-0x0000000180315270
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static object Parse(Type enumType, string value, bool ignoreCase) => default; // 0x0000000180315270-0x0000000180315390
		private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref EnumResult parseResult) => default; // 0x00000001803179F0-0x0000000180318080
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static Type GetUnderlyingType(Type enumType) => default; // 0x0000000180314250-0x0000000180314300
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static Array GetValues(Type enumType) => default; // 0x0000000180314310-0x00000001803143C0
		internal static ulong[] InternalGetValues(RuntimeType enumType) => default; // 0x0000000180314FF0-0x0000000180315060
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static string GetName(Type enumType, object value) => default; // 0x0000000180313CF0-0x0000000180313DB0
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static string[] GetNames(Type enumType) => default; // 0x0000000180313DB0-0x0000000180313E60
		internal static string[] InternalGetNames(RuntimeType enumType) => default; // 0x0000000180314F70-0x0000000180314FE0
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static object ToObject(Type enumType, object value) => default; // 0x0000000180316E80-0x00000001803173A0
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static bool IsDefined(Type enumType, object value) => default; // 0x0000000180315070-0x0000000180315130
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static string Format(Type enumType, object value, string format) => default; // 0x0000000180313520-0x0000000180313B60
		private object get_value() => default; // 0x0000000180314300-0x0000000180314310
		internal object GetValue() => default; // 0x0000000180314300-0x0000000180314310
		private bool InternalHasFlag(Enum flags) => default; // 0x0000000180315060-0x0000000180315070
		private int get_hashcode() => default; // 0x0000000180313CE0-0x0000000180313CF0
		public override bool Equals(object obj) => default; // 0x0000000180313510-0x0000000180313520
		public override int GetHashCode() => default; // 0x0000000180313CE0-0x0000000180313CF0
		public override string ToString() => default; // 0x0000000180317780-0x0000000180317850
		[Obsolete] // 0x00000001800DFD80-0x00000001800DFDB0
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000180317770-0x0000000180317780
		public int CompareTo(object target) => default; // 0x0000000180313340-0x0000000180313510
		public string ToString(string format) => default; // 0x0000000180317590-0x0000000180317770
		[Obsolete] // 0x00000001800DFEA0-0x00000001800DFED0
		public string ToString(IFormatProvider provider) => default; // 0x00000001802A5E70-0x00000001802A5E90
		public bool HasFlag(Enum flag) => default; // 0x00000001803143C0-0x0000000180314540
		public TypeCode GetTypeCode() => default; // 0x0000000180313E60-0x0000000180314250
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180315390-0x0000000180315430
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001803154D0-0x0000000180315570
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000180315970-0x0000000180315A10
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000180315430-0x00000001803154D0
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000180315790-0x0000000180315830
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180315B30-0x0000000180315BD0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180315830-0x00000001803158D0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180315BD0-0x0000000180315C70
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001803158D0-0x0000000180315970
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000180315C70-0x0000000180315D10
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000180315A10-0x0000000180315AB0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001803156F0-0x0000000180315790
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000180315640-0x00000001803156F0
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180315570-0x0000000180315640
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x0000000180315AB0-0x0000000180315B30
		// [CLSCompliant] // 0x00000001800E0050-0x00000001800E0090
		// [ComVisible] // 0x00000001800E0050-0x00000001800E0090
		public static object ToObject(Type enumType, sbyte value) => default; // 0x00000001803173A0-0x0000000180317590
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static object ToObject(Type enumType, short value) => default; // 0x00000001803166C0-0x00000001803168B0
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static object ToObject(Type enumType, int value) => default; // 0x0000000180316AA0-0x0000000180316C90
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static object ToObject(Type enumType, byte value) => default; // 0x00000001803160F0-0x00000001803162E0
		// [CLSCompliant] // 0x00000001800E0050-0x00000001800E0090
		// [ComVisible] // 0x00000001800E0050-0x00000001800E0090
		public static object ToObject(Type enumType, ushort value) => default; // 0x00000001803164D0-0x00000001803166C0
		// [CLSCompliant] // 0x00000001800E18D0-0x00000001800E1910
		// [ComVisible] // 0x00000001800E18D0-0x00000001800E1910
		public static object ToObject(Type enumType, uint value) => default; // 0x0000000180315F00-0x00000001803160F0
		// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
		public static object ToObject(Type enumType, long value) => default; // 0x0000000180316C90-0x0000000180316E80
		// [CLSCompliant] // 0x00000001800E18D0-0x00000001800E1910
		// [ComVisible] // 0x00000001800E18D0-0x00000001800E1910
		public static object ToObject(Type enumType, ulong value) => default; // 0x00000001803162E0-0x00000001803164D0
		private static object ToObject(Type enumType, char value) => default; // 0x00000001803168B0-0x0000000180316AA0
		private static object ToObject(Type enumType, bool value) => default; // 0x0000000180315D10-0x0000000180315F00
	}
}
