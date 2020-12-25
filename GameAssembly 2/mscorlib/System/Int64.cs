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
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 249
	{
		// Fields
		internal long m_value; // 0x00
		public const long MaxValue = 9223372036854775807; // Metadata: 0x0062FFFC
		public const long MinValue = -9223372036854775808; // Metadata: 0x00630004
	
		// Methods
		public int CompareTo(object value) => default; // 0x0000000180025770-0x0000000180025870
		public int CompareTo(long value) => default; // 0x0000000180025750-0x0000000180025770
		public override bool Equals(object obj) => default; // 0x0000000180025870-0x0000000180025900
		public bool Equals(long obj) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public override int GetHashCode() => default; // 0x00000001800193C0-0x00000001800193D0
		public override string ToString() => default; // 0x0000000180025E80-0x0000000180025EB0
		public string ToString(IFormatProvider provider) => default; // 0x0000000180025E50-0x0000000180025E80
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000180025EB0-0x0000000180025EF0
		public static long Parse(string s) => default; // 0x00000001806301B0-0x0000000180630350
		public static long Parse(string s, IFormatProvider provider) => default; // 0x0000000180630180-0x00000001806301B0
		public static long Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x0000000180630130-0x0000000180630180
		public static bool TryParse(string s, out long result) {
			result = default;
			return default;
		} // 0x0000000180630350-0x0000000180630390
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) {
			result = default;
			return default;
		} // 0x0000000180630390-0x0000000180630480
		public TypeCode GetTypeCode() => default; // 0x0000000180025900-0x0000000180025910
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180025910-0x0000000180025970
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001800259D0-0x0000000180025A30
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000180025BE0-0x0000000180025C40
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000180025970-0x00000001800259D0
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000180025B20-0x0000000180025B80
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180025D30-0x0000000180025D90
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180025B80-0x0000000180025BE0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180025D90-0x0000000180025DF0
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000180002410-0x0000000180002420
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000180025DF0-0x0000000180025E50
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000180025C40-0x0000000180025CA0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000180025AC0-0x0000000180025B20
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000180025A40-0x0000000180025AC0
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180025A30-0x0000000180025A40
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x0000000180025CA0-0x0000000180025D30
	}
}
