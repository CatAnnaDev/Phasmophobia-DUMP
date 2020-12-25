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
	public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 290
	{
		// Fields
		internal float m_value; // 0x00
		public const float MinValue = -3.4028235E+38f; // Metadata: 0x006300A2
		public const float Epsilon = 1E-45f; // Metadata: 0x006300A6
		public const float MaxValue = 3.4028235E+38f; // Metadata: 0x006300AA
		public const float PositiveInfinity = 1F / 0F; // Metadata: 0x006300AE
		public const float NegativeInfinity = -1F / 0F; // Metadata: 0x006300B2
		public const float NaN = 0F / 0F; // Metadata: 0x006300B6
	
		// Methods
		public static bool IsInfinity(float f) => default; // 0x00000001808C03E0-0x00000001808C0400
		public static bool IsPositiveInfinity(float f) => default; // 0x00000001808C0440-0x00000001808C0460
		public static bool IsNegativeInfinity(float f) => default; // 0x00000001808C0420-0x00000001808C0440
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static bool IsNaN(float f) => default; // 0x00000001808C0400-0x00000001808C0420
		public int CompareTo(object value) => default; // 0x0000000180033D80-0x0000000180033EC0
		public int CompareTo(float value) => default; // 0x0000000180033EC0-0x0000000180033F20
		public override bool Equals(object obj) => default; // 0x0000000180033F60-0x0000000180034020
		public bool Equals(float obj) => default; // 0x0000000180033F20-0x0000000180033F60
		public override int GetHashCode() => default; // 0x0000000180034020-0x0000000180034040
		public override string ToString() => default; // 0x0000000180034590-0x00000001800345C0
		public string ToString(IFormatProvider provider) => default; // 0x00000001800345C0-0x0000000180034600
		public string ToString(string format) => default; // 0x0000000180034550-0x0000000180034590
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000180034600-0x0000000180034640
		public static float Parse(string s) => default; // 0x00000001808C0490-0x00000001808C04C0
		public static float Parse(string s, IFormatProvider provider) => default; // 0x00000001808C0460-0x00000001808C0490
		public static float Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x00000001808C04C0-0x00000001808C0510
		private static float Parse(string s, NumberStyles style, NumberFormatInfo info) => default; // 0x00000001808C0510-0x00000001808C07B0
		public static bool TryParse(string s, out float result) {
			result = default;
			return default;
		} // 0x00000001808C0910-0x00000001808C0950
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) {
			result = default;
			return default;
		} // 0x00000001808C08B0-0x00000001808C0910
		private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) {
			result = default;
			return default;
		} // 0x00000001808C07B0-0x00000001808C08B0
		public TypeCode GetTypeCode() => default; // 0x0000000180034040-0x0000000180034050
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180034050-0x00000001800340B0
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000180034110-0x0000000180034120
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000180034330-0x0000000180034390
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x00000001800340B0-0x0000000180034110
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000180034210-0x0000000180034270
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180034430-0x0000000180034490
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180034270-0x00000001800342D0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180034490-0x00000001800344F0
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001800342D0-0x0000000180034330
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x00000001800344F0-0x0000000180034550
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x000000018000FCD0-0x000000018000FCE0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001800341B0-0x0000000180034210
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000180034130-0x00000001800341B0
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180034120-0x0000000180034130
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x0000000180034390-0x0000000180034430
	}
}
