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
	// [CLSCompliant] // 0x00000001800E18D0-0x00000001800E1910
	// [ComVisible] // 0x00000001800E18D0-0x00000001800E1910
	public struct UInt64 : IComparable, IFormattable, IConvertible, IComparable<ulong>, IEquatable<ulong> // TypeDefIndex: 319
	{
		// Fields
		private ulong m_value; // 0x00
		public const ulong MaxValue = 18446744073709551615; // Metadata: 0x0063021E
		public const ulong MinValue = 0; // Metadata: 0x00630226
	
		// Methods
		public int CompareTo(object value) => default; // 0x0000000180046950-0x0000000180046A50
		public int CompareTo(ulong value) => default; // 0x0000000180046930-0x0000000180046950
		public override bool Equals(object obj) => default; // 0x0000000180046A50-0x0000000180046AE0
		public bool Equals(ulong obj) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public override int GetHashCode() => default; // 0x0000000180046AE0-0x0000000180046AF0
		public override string ToString() => default; // 0x00000001800470B0-0x00000001800470E0
		public string ToString(IFormatProvider provider) => default; // 0x0000000180047080-0x00000001800470B0
		public string ToString(string format) => default; // 0x0000000180047040-0x0000000180047080
		public string ToString(string format, IFormatProvider provider) => default; // 0x00000001800470E0-0x0000000180047120
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong Parse(string s, IFormatProvider provider) => default; // 0x0000000180A74260-0x0000000180A74290
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x0000000180A74290-0x0000000180A74490
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ulong result) {
			result = default;
			return default;
		} // 0x0000000180A74490-0x0000000180A74580
		public TypeCode GetTypeCode() => default; // 0x0000000180046AF0-0x0000000180046B00
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180046B00-0x0000000180046B60
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000180046BC0-0x0000000180046C20
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000180046E30-0x0000000180046E90
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000180046B60-0x0000000180046BC0
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000180046D10-0x0000000180046D70
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180046F80-0x0000000180046FE0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180046D70-0x0000000180046DD0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180046FE0-0x0000000180047040
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000180046DD0-0x0000000180046E30
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000180002410-0x0000000180002420
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000180046E90-0x0000000180046EF0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000180046CB0-0x0000000180046D10
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000180046C30-0x0000000180046CB0
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180046C20-0x0000000180046C30
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x0000000180046EF0-0x0000000180046F80
	}
}
