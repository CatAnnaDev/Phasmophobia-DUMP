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
	public struct Byte : IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte> // TypeDefIndex: 171
	{
		// Fields
		private byte m_value; // 0x00
		public const byte MaxValue = 255; // Metadata: 0x0062F965
		public const byte MinValue = 0; // Metadata: 0x0062F966
	
		// Methods
		public int CompareTo(object value) => default; // 0x00000001800288E0-0x00000001800289B0
		public int CompareTo(byte value) => default; // 0x00000001800288D0-0x00000001800288E0
		public override bool Equals(object obj) => default; // 0x00000001800289B0-0x0000000180028A40
		public bool Equals(byte obj) => default; // 0x0000000180013280-0x0000000180013290
		public override int GetHashCode() => default; // 0x0000000180013590-0x00000001800135A0
		public static byte Parse(string s, IFormatProvider provider) => default; // 0x000000018070F1E0-0x000000018070F210
		public static byte Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x000000018070F210-0x000000018070F410
		private static byte Parse(string s, NumberStyles style, NumberFormatInfo info) => default; // 0x000000018070F0E0-0x000000018070F1E0
		public static bool TryParse(string s, out byte result) {
			result = default;
			return default;
		} // 0x000000018070F4F0-0x000000018070F560
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) {
			result = default;
			return default;
		} // 0x000000018070F410-0x000000018070F4A0
		private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out byte result) {
			result = default;
			return default;
		} // 0x000000018070F4A0-0x000000018070F4F0
		public override string ToString() => default; // 0x0000000180028FC0-0x0000000180028FF0
		public string ToString(string format) => default; // 0x0000000180028FF0-0x0000000180029030
		public string ToString(IFormatProvider provider) => default; // 0x0000000180028F90-0x0000000180028FC0
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000180029030-0x0000000180029070
		public TypeCode GetTypeCode() => default; // 0x0000000180028A40-0x0000000180028A50
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180028A50-0x0000000180028AB0
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000180028AB0-0x0000000180028B10
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000180028D20-0x0000000180028D80
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000180013590-0x00000001800135A0
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000180028C00-0x0000000180028C60
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180028E70-0x0000000180028ED0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180028C60-0x0000000180028CC0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180028ED0-0x0000000180028F30
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000180028CC0-0x0000000180028D20
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000180028F30-0x0000000180028F90
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000180028D80-0x0000000180028DE0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000180028BA0-0x0000000180028C00
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000180028B20-0x0000000180028BA0
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180028B10-0x0000000180028B20
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x0000000180028DE0-0x0000000180028E70
	}
}
