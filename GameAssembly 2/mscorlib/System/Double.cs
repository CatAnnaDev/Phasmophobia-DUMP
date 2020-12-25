/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public struct Double : IComparable, IFormattable, IConvertible, IComparable<double>, IEquatable<double> // TypeDefIndex: 198
	{
		// Fields
		internal double m_value; // 0x00
		public const double MinValue = -1.7976931348623157E+308; // Metadata: 0x0062FD56
		public const double MaxValue = 1.7976931348623157E+308; // Metadata: 0x0062FD5E
		public const double Epsilon = 5E-324; // Metadata: 0x0062FD66
		public const double NegativeInfinity = -1D / 0D; // Metadata: 0x0062FD6E
		public const double PositiveInfinity = 1D / 0D; // Metadata: 0x0062FD76
		public const double NaN = 0D / 0D; // Metadata: 0x0062FD7E
		internal static double NegativeZero; // 0x00
	
		// Constructors
		static Double() {
			NegativeZero = default;
		} // 0x0000000180312EA0-0x0000000180312F10
	
		// Methods
		public static bool IsInfinity(double d) => default; // 0x00000001803127C0-0x00000001803127F0
		public static bool IsPositiveInfinity(double d) => default; // 0x0000000180312840-0x0000000180312860
		public static bool IsNegativeInfinity(double d) => default; // 0x0000000180312820-0x0000000180312840
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static bool IsNaN(double d) => default; // 0x00000001803127F0-0x0000000180312820
		public int CompareTo(object value) => default; // 0x00000001800074D0-0x0000000180007660
		public int CompareTo(double value) => default; // 0x00000001800073A0-0x00000001800074D0
		public override bool Equals(object obj) => default; // 0x0000000180007750-0x0000000180007870
		public bool Equals(double obj) => default; // 0x0000000180007660-0x0000000180007750
		public override int GetHashCode() => default; // 0x0000000180007870-0x0000000180007880
		public override string ToString() => default; // 0x0000000180007E60-0x0000000180007E90
		public string ToString(string format) => default; // 0x0000000180007DE0-0x0000000180007E20
		public string ToString(IFormatProvider provider) => default; // 0x0000000180007E20-0x0000000180007E60
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000180007DA0-0x0000000180007DE0
		public static double Parse(string s) => default; // 0x0000000180312860-0x00000001803128D0
		public static double Parse(string s, IFormatProvider provider) => default; // 0x0000000180312960-0x00000001803129E0
		public static double Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x00000001803128D0-0x0000000180312960
		private static double Parse(string s, NumberStyles style, NumberFormatInfo info) => default; // 0x00000001803129E0-0x0000000180312C80
		public static bool TryParse(string s, out double result) {
			result = default;
			return default;
		} // 0x0000000180312D20-0x0000000180312DB0
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) {
			result = default;
			return default;
		} // 0x0000000180312C80-0x0000000180312D20
		private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result) {
			result = default;
			return default;
		} // 0x0000000180312DB0-0x0000000180312EA0
		public TypeCode GetTypeCode() => default; // 0x0000000180007880-0x0000000180007890
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180007890-0x00000001800078F0
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000180007950-0x0000000180007960
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000180007B20-0x0000000180007B80
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x00000001800078F0-0x0000000180007950
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000180007A00-0x0000000180007A60
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180007C80-0x0000000180007CE0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180007A60-0x0000000180007AC0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180007CE0-0x0000000180007D40
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000180007AC0-0x0000000180007B20
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000180007D40-0x0000000180007DA0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000180007B80-0x0000000180007BE0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001800079F0-0x0000000180007A00
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000180007970-0x00000001800079F0
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180007960-0x0000000180007970
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x0000000180007BE0-0x0000000180007C80
	}
}
