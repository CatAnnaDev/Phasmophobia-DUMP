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
	public struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool> // TypeDefIndex: 169
	{
		// Fields
		private bool m_value; // 0x00
		internal const int True = 1; // Metadata: 0x0062F94C
		internal const int False = 0; // Metadata: 0x0062F950
		internal const string TrueLiteral = "True"; // Metadata: 0x0062F954
		internal const string FalseLiteral = "False"; // Metadata: 0x0062F95C
		public static readonly string TrueString; // 0x00
		public static readonly string FalseString; // 0x08
	
		// Constructors
		static Boolean() {
			TrueString = default;
			FalseString = default;
		} // 0x000000018070E150-0x000000018070E1C0
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000180028330-0x0000000180028340
		public override string ToString() => default; // 0x0000000180028890-0x00000001800288D0
		public string ToString(IFormatProvider provider) => default; // 0x0000000180028850-0x0000000180028890
		public override bool Equals(object obj) => default; // 0x00000001800282A0-0x0000000180028330
		public bool Equals(bool obj) => default; // 0x0000000180013280-0x0000000180013290
		public int CompareTo(object obj) => default; // 0x00000001800281B0-0x00000001800282A0
		public int CompareTo(bool value) => default; // 0x0000000180028190-0x00000001800281B0
		public static bool Parse(string value) => default; // 0x000000018070DB10-0x000000018070DDE0
		public static bool TryParse(string value, out bool result) {
			result = default;
			return default;
		} // 0x000000018070DF10-0x000000018070E150
		private static string TrimWhiteSpaceAndNull(string value) => default; // 0x000000018070DDE0-0x000000018070DF10
		public TypeCode GetTypeCode() => default; // 0x0000000180028340-0x0000000180028350
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180028350-0x0000000180028360
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001800283C0-0x00000001800283D0
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x00000001800285E0-0x0000000180028640
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000180028360-0x00000001800283C0
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x00000001800284C0-0x0000000180028520
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180028730-0x0000000180028790
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180028520-0x0000000180028580
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180028790-0x00000001800287F0
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000180028580-0x00000001800285E0
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x00000001800287F0-0x0000000180028850
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000180028640-0x00000001800286A0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000180028460-0x00000001800284C0
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001800283E0-0x0000000180028460
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x00000001800283D0-0x00000001800283E0
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x00000001800286A0-0x0000000180028730
	}
}
