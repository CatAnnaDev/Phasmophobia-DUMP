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
	public struct Int16 : IComparable, IFormattable, IConvertible, IComparable<short>, IEquatable<short> // TypeDefIndex: 247
	{
		// Fields
		internal short m_value; // 0x00
		public const short MaxValue = 32767; // Metadata: 0x0062FFF0
		public const short MinValue = -32768; // Metadata: 0x0062FFF2
	
		// Methods
		public int CompareTo(object value) => default; // 0x0000000180024810-0x00000001800248E0
		public int CompareTo(short value) => default; // 0x0000000180024800-0x0000000180024810
		public override bool Equals(object obj) => default; // 0x00000001800248F0-0x0000000180024980
		public bool Equals(short obj) => default; // 0x00000001800248E0-0x00000001800248F0
		public override int GetHashCode() => default; // 0x0000000180024980-0x0000000180024990
		public override string ToString() => default; // 0x0000000180024F20-0x0000000180024F50
		public string ToString(IFormatProvider provider) => default; // 0x0000000180024EE0-0x0000000180024F10
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000180024F50-0x0000000180024F90
		private string ToString(string format, NumberFormatInfo info) => default; // 0x0000000180024F10-0x0000000180024F20
		public static short Parse(string s, IFormatProvider provider) => default; // 0x000000018062F5D0-0x000000018062F600
		public static short Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x000000018062F600-0x000000018062F650
		private static short Parse(string s, NumberStyles style, NumberFormatInfo info) => default; // 0x000000018062F650-0x000000018062F9C0
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) {
			result = default;
			return default;
		} // 0x000000018062FA40-0x000000018062FC70
		private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out short result) {
			result = default;
			return default;
		} // 0x000000018062F9C0-0x000000018062FA40
		public TypeCode GetTypeCode() => default; // 0x0000000180024990-0x00000001800249A0
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x00000001800249A0-0x0000000180024A00
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000180024A60-0x0000000180024AC0
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000180024C70-0x0000000180024CD0
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000180024A00-0x0000000180024A60
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000180004230-0x0000000180004240
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180024DC0-0x0000000180024E20
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180024BB0-0x0000000180024C10
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180024E20-0x0000000180024E80
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000180024C10-0x0000000180024C70
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000180024E80-0x0000000180024EE0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000180024CD0-0x0000000180024D30
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000180024B50-0x0000000180024BB0
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000180024AD0-0x0000000180024B50
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180024AC0-0x0000000180024AD0
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x0000000180024D30-0x0000000180024DC0
	}
}
