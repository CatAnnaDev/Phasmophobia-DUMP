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
	public struct Int32 : IComparable, IFormattable, IConvertible, IComparable<int>, IEquatable<int> // TypeDefIndex: 248
	{
		// Fields
		internal int m_value; // 0x00
		public const int MaxValue = 2147483647; // Metadata: 0x0062FFF4
		public const int MinValue = -2147483648; // Metadata: 0x0062FFF8
	
		// Methods
		public int CompareTo(object value) => default; // 0x0000000180024F90-0x0000000180025090
		public int CompareTo(int value) => default; // 0x0000000180025090-0x00000001800250B0
		public override bool Equals(object obj) => default; // 0x00000001800250B0-0x0000000180025130
		public bool Equals(int obj) => default; // 0x0000000180016320-0x0000000180016330
		public override int GetHashCode() => default; // 0x000000018000B580-0x000000018000B590
		public override string ToString() => default; // 0x0000000180025670-0x00000001800256A0
		public string ToString(string format) => default; // 0x00000001800256D0-0x0000000180025710
		public string ToString(IFormatProvider provider) => default; // 0x00000001800256A0-0x00000001800256D0
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000180025710-0x0000000180025750
		public static int Parse(string s) => default; // 0x000000018062FCC0-0x000000018062FCF0
		public static int Parse(string s, NumberStyles style) => default; // 0x000000018062FD20-0x000000018062FF00
		public static int Parse(string s, IFormatProvider provider) => default; // 0x000000018062FCF0-0x000000018062FD20
		public static int Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x000000018062FC70-0x000000018062FCC0
		public static bool TryParse(string s, out int result) {
			result = default;
			return default;
		} // 0x000000018062FF00-0x000000018062FF40
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) {
			result = default;
			return default;
		} // 0x000000018062FF40-0x0000000180630130
		public TypeCode GetTypeCode() => default; // 0x0000000180025130-0x0000000180025140
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180025140-0x00000001800251A0
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000180025200-0x0000000180025260
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000180025400-0x0000000180025460
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x00000001800251A0-0x0000000180025200
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000180025340-0x00000001800253A0
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180025550-0x00000001800255B0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x000000018000B580-0x000000018000B590
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x00000001800255B0-0x0000000180025610
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001800253A0-0x0000000180025400
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000180025610-0x0000000180025670
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000180025460-0x00000001800254C0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001800252E0-0x0000000180025340
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000180025270-0x00000001800252E0
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180025260-0x0000000180025270
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x00000001800254C0-0x0000000180025550
	}
}
