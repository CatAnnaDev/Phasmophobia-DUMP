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
	public struct Char : IComparable, IConvertible, IComparable<char>, IEquatable<char> // TypeDefIndex: 173
	{
		// Fields
		internal char m_value; // 0x00
		public const char MaxValue = '\xffff'; // Metadata: 0x0062F967
		public const char MinValue = '\x0000'; // Metadata: 0x0062F969
		private static readonly byte[] categoryForLatin1; // 0x00
		internal const int UNICODE_PLANE00_END = 65535; // Metadata: 0x0062F96B
		internal const int UNICODE_PLANE01_START = 65536; // Metadata: 0x0062F96F
		internal const int UNICODE_PLANE16_END = 1114111; // Metadata: 0x0062F973
		internal const int HIGH_SURROGATE_START = 55296; // Metadata: 0x0062F977
		internal const int LOW_SURROGATE_END = 57343; // Metadata: 0x0062F97B
	
		// Constructors
		static Char() {
			categoryForLatin1 = default;
		} // 0x0000000180711880-0x00000001807118F0
	
		// Methods
		private static bool IsLatin1(char ch) => default; // 0x00000001807100F0-0x0000000180710100
		private static bool IsAscii(char ch) => default; // 0x000000018070FE60-0x000000018070FE70
		private static UnicodeCategory GetLatin1UnicodeCategory(char ch) => default; // 0x000000018070FBC0-0x000000018070FC50
		public override int GetHashCode() => default; // 0x00000001800291E0-0x00000001800291F0
		public override bool Equals(object obj) => default; // 0x0000000180029150-0x00000001800291E0
		public bool Equals(char obj) => default; // 0x00000001800248E0-0x00000001800248F0
		public int CompareTo(object value) => default; // 0x0000000180029080-0x0000000180029150
		public int CompareTo(char value) => default; // 0x0000000180029070-0x0000000180029080
		public override string ToString() => default; // 0x00000001800295F0-0x0000000180029650
		public string ToString(IFormatProvider provider) => default; // 0x0000000180029650-0x00000001800296B0
		public static string ToString(char c) => default; // 0x00000001807115B0-0x0000000180711690
		public static char Parse(string s) => default; // 0x0000000180710F20-0x00000001807113F0
		public static bool TryParse(string s, out char result) {
			result = default;
			return default;
		} // 0x0000000180711850-0x0000000180711880
		public static bool IsDigit(char c) => default; // 0x000000018070FF30-0x000000018070FFD0
		internal static bool CheckLetter(UnicodeCategory uc) => default; // 0x000000018070F8D0-0x000000018070F8E0
		public static bool IsLetter(char c) => default; // 0x0000000180710370-0x0000000180710490
		private static bool IsWhiteSpaceLatin1(char c) => default; // 0x0000000180710CA0-0x0000000180710CD0
		public static bool IsWhiteSpace(char c) => default; // 0x0000000180710CD0-0x0000000180710DA0
		public static bool IsUpper(char c) => default; // 0x0000000180710BA0-0x0000000180710CA0
		public static bool IsLower(char c) => default; // 0x00000001807104B0-0x00000001807105B0
		internal static bool CheckPunctuation(UnicodeCategory uc) => default; // 0x000000018070F8F0-0x000000018070F900
		public static bool IsPunctuation(char c) => default; // 0x0000000180710890-0x0000000180710970
		internal static bool CheckLetterOrDigit(UnicodeCategory uc) => default; // 0x000000018070F8C0-0x000000018070F8D0
		public static bool IsLetterOrDigit(char c) => default; // 0x0000000180710290-0x0000000180710370
		public static char ToUpper(char c, CultureInfo culture) => default; // 0x00000001807117B0-0x0000000180711850
		public static char ToUpper(char c) => default; // 0x0000000180711720-0x00000001807117B0
		public static char ToUpperInvariant(char c) => default; // 0x0000000180711690-0x0000000180711720
		public static char ToLower(char c, CultureInfo culture) => default; // 0x0000000180711480-0x0000000180711520
		public static char ToLower(char c) => default; // 0x0000000180711520-0x00000001807115B0
		public static char ToLowerInvariant(char c) => default; // 0x00000001807113F0-0x0000000180711480
		public TypeCode GetTypeCode() => default; // 0x00000001800291F0-0x0000000180029200
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180029200-0x0000000180029210
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000180004230-0x0000000180004240
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x00000001800293D0-0x0000000180029430
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000180029210-0x0000000180029270
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x00000001800292B0-0x0000000180029310
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x00000001800294D0-0x0000000180029530
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180029310-0x0000000180029370
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180029530-0x0000000180029590
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000180029370-0x00000001800293D0
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000180029590-0x00000001800295F0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x0000000180029430-0x0000000180029440
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001800292A0-0x00000001800292B0
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000180029280-0x00000001800292A0
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180029270-0x0000000180029280
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x0000000180029440-0x00000001800294D0
		public static bool IsControl(char c) => default; // 0x000000018070FE70-0x000000018070FF30
		public static bool IsLetterOrDigit(string s, int index) => default; // 0x0000000180710100-0x0000000180710290
		internal static bool CheckNumber(UnicodeCategory uc) => default; // 0x000000018070F8E0-0x000000018070F8F0
		public static bool IsNumber(char c) => default; // 0x00000001807105B0-0x00000001807106D0
		public static bool IsNumber(string s, int index) => default; // 0x00000001807106D0-0x0000000180710890
		public static bool IsSurrogate(char c) => default; // 0x0000000180710AA0-0x0000000180710AC0
		public static bool IsSurrogate(string s, int index) => default; // 0x00000001807109A0-0x0000000180710AA0
		internal static bool CheckSymbol(UnicodeCategory uc) => default; // 0x000000018070F900-0x000000018070F9E0
		public static bool IsSymbol(char c) => default; // 0x0000000180710AC0-0x0000000180710BA0
		public static bool IsWhiteSpace(string s, int index) => default; // 0x0000000180710DA0-0x0000000180710F20
		public static UnicodeCategory GetUnicodeCategory(char c) => default; // 0x000000018070FC50-0x000000018070FD00
		public static UnicodeCategory GetUnicodeCategory(string s, int index) => default; // 0x000000018070FD00-0x000000018070FE60
		public static bool IsHighSurrogate(char c) => default; // 0x000000018070FFD0-0x000000018070FFF0
		public static bool IsHighSurrogate(string s, int index) => default; // 0x000000018070FFF0-0x00000001807100F0
		public static bool IsLowSurrogate(char c) => default; // 0x0000000180710490-0x00000001807104B0
		public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) => default; // 0x0000000180710970-0x00000001807109A0
		public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) => default; // 0x000000018070F9E0-0x000000018070FBC0
	}
}
