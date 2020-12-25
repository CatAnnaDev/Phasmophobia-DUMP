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
using System.Text;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[FriendAccessAllowed] // 0x00000001800D4E50-0x00000001800D4E60
	internal class Number // TypeDefIndex: 269
	{
		// Nested types
		[FriendAccessAllowed] // 0x00000001800D4E50-0x00000001800D4E60
		internal struct NumberBuffer // TypeDefIndex: 270
		{
			// Fields
			public static readonly int NumberBufferBytes; // 0x00
			private unsafe byte* baseAddress; // 0x00
			public unsafe char* digits; // 0x08
			public int precision; // 0x10
			public int scale; // 0x14
			public bool sign; // 0x18
	
			// Constructors
			public unsafe NumberBuffer(byte* stackBuffer) {
				baseAddress = default;
				digits = default;
				precision = default;
				scale = default;
				sign = default;
			} // 0x0000000180026E70-0x0000000180026EF0
			static NumberBuffer() {
				NumberBufferBytes = default;
			} // 0x00000001806842B0-0x00000001806842F0
	
			// Methods
			public unsafe byte* PackForNative() => default; // 0x0000000180026E50-0x0000000180026E70
		}
	
		// Constructors
		public Number() {} // Dummy constructor
	
		// Methods
		public static unsafe bool NumberBufferToDecimal(byte* number, ref decimal value) => default; // 0x000000018068A8D0-0x000000018068A8E0
		internal static unsafe bool NumberBufferToDouble(byte* number, ref double value) => default; // 0x000000018068A8E0-0x000000018068A8F0
		public static string FormatDecimal(decimal value, string format, NumberFormatInfo info) => default; // 0x0000000180689DE0-0x0000000180689F00
		public static string FormatDouble(double value, string format, NumberFormatInfo info) => default; // 0x0000000180689F00-0x0000000180689F80
		public static string FormatInt32(int value, string format, NumberFormatInfo info) => default; // 0x0000000180689F80-0x000000018068A0F0
		public static string FormatUInt32(uint value, string format, NumberFormatInfo info) => default; // 0x000000018068A2E0-0x000000018068A440
		public static string FormatInt64(long value, string format, NumberFormatInfo info) => default; // 0x000000018068A0F0-0x000000018068A260
		public static string FormatUInt64(ulong value, string format, NumberFormatInfo info) => default; // 0x000000018068A440-0x000000018068A5A0
		public static string FormatSingle(float value, string format, NumberFormatInfo info) => default; // 0x000000018068A260-0x000000018068A2E0
		private static bool HexNumberToInt32(ref NumberBuffer number, ref int value) => default; // 0x000000018068A5A0-0x000000018068A620
		private static bool HexNumberToInt64(ref NumberBuffer number, ref long value) => default; // 0x000000018068A620-0x000000018068A6E0
		private static bool HexNumberToUInt32(ref NumberBuffer number, ref uint value) => default; // 0x000000018068A6E0-0x000000018068A760
		private static bool HexNumberToUInt64(ref NumberBuffer number, ref ulong value) => default; // 0x000000018068A760-0x000000018068A7F0
		private static bool IsWhite(char ch) => default; // 0x000000018068A7F0-0x000000018068A810
		private static bool NumberToInt32(ref NumberBuffer number, ref int value) => default; // 0x000000018068A8F0-0x000000018068A960
		private static bool NumberToInt64(ref NumberBuffer number, ref long value) => default; // 0x000000018068A960-0x000000018068A9E0
		private static bool NumberToUInt32(ref NumberBuffer number, ref uint value) => default; // 0x000000018068A9E0-0x000000018068AA40
		private static bool NumberToUInt64(ref NumberBuffer number, ref ulong value) => default; // 0x000000018068AA40-0x000000018068AAB0
		private static unsafe char* MatchChars(char* p, string str) => default; // 0x000000018068A850-0x000000018068A8D0
		private static unsafe char* MatchChars(char* p, char* str) => default; // 0x000000018068A810-0x000000018068A850
		internal static decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt) => default; // 0x000000018068AAB0-0x000000018068AC30
		internal static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt) => default; // 0x000000018068AC30-0x000000018068AED0
		internal static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info) => default; // 0x000000018068AED0-0x000000018068B120
		internal static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt) => default; // 0x000000018068B120-0x000000018068B390
		private static unsafe bool ParseNumber(ref char* str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) => default; // 0x000000018068B390-0x000000018068BDC0
		internal static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt) => default; // 0x000000018068BDC0-0x000000018068C0D0
		internal static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt) => default; // 0x000000018068C0D0-0x000000018068C310
		internal static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt) => default; // 0x000000018068C310-0x000000018068C580
		private static void StringToNumber(string str, NumberStyles options, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal) {} // 0x000000018068C580-0x000000018068C6C0
		private static bool TrailingZeros(string s, int index) => default; // 0x000000018068C6C0-0x000000018068C720
		internal static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out decimal result) {
			result = default;
			return default;
		} // 0x000000018068C720-0x000000018068C8A0
		internal static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result) {
			result = default;
			return default;
		} // 0x000000018068C8A0-0x000000018068CA10
		internal static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result) {
			result = default;
			return default;
		} // 0x000000018068CA10-0x000000018068CC50
		internal static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result) {
			result = default;
			return default;
		} // 0x000000018068CC50-0x000000018068CE20
		internal static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result) {
			result = default;
			return default;
		} // 0x000000018068CE20-0x000000018068CFC0
		internal static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result) {
			result = default;
			return default;
		} // 0x000000018068CFC0-0x000000018068D1F0
		internal static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result) {
			result = default;
			return default;
		} // 0x000000018068D1F0-0x000000018068D440
		internal static bool TryStringToNumber(string str, NumberStyles options, ref NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal) => default; // 0x000000018068D500-0x000000018068D5C0
		[FriendAccessAllowed] // 0x00000001800D4E50-0x00000001800D4E60
		internal static bool TryStringToNumber(string str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) => default; // 0x000000018068D440-0x000000018068D500
	}
}
