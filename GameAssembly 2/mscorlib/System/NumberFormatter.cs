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
using System.Threading;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	internal sealed class NumberFormatter // TypeDefIndex: 372
	{
		// Fields
		private static readonly unsafe ulong* MantissaBitsTable; // 0x00
		private static readonly unsafe int* TensExponentTable; // 0x08
		private static readonly unsafe char* DigitLowerTable; // 0x10
		private static readonly unsafe char* DigitUpperTable; // 0x18
		private static readonly unsafe long* TenPowersList; // 0x20
		private static readonly unsafe int* DecHexDigits; // 0x28
		private NumberFormatInfo _nfi; // 0x10
		private char[] _cbuf; // 0x18
		private bool _NaN; // 0x20
		private bool _infinity; // 0x21
		private bool _isCustomFormat; // 0x22
		private bool _specifierIsUpper; // 0x23
		private bool _positive; // 0x24
		private char _specifier; // 0x26
		private int _precision; // 0x28
		private int _defPrecision; // 0x2C
		private int _digitsLen; // 0x30
		private int _offset; // 0x34
		private int _decPointPos; // 0x38
		private uint _val1; // 0x3C
		private uint _val2; // 0x40
		private uint _val3; // 0x44
		private uint _val4; // 0x48
		private int _ind; // 0x4C
		[ThreadStatic] // 0x00000001800D4E50-0x00000001800D4E60
		private static NumberFormatter threadNumberFormatter; // 0x80000000
		[ThreadStatic] // 0x00000001800D4E50-0x00000001800D4E60
		private static NumberFormatter userFormatProvider; // 0x80000008
	
		// Properties
		private CultureInfo CurrentCulture { set {} } // 0x0000000180689D90-0x0000000180689DE0
		private int IntegerDigits { get => default; } // 0x0000000180689D30-0x0000000180689D40 
		private int DecimalDigits { get => default; } // 0x0000000180689D20-0x0000000180689D30 
		private bool IsFloatingSource { get => default; } // 0x0000000180689D40-0x0000000180689D60 
		private bool IsZero { get => default; } // 0x0000000180689D80-0x0000000180689D90 
		private bool IsZeroInteger { get => default; } // 0x0000000180689D60-0x0000000180689D80 
	
		// Nested types
		private class CustomInfo // TypeDefIndex: 373
		{
			// Fields
			public bool UseGroup; // 0x10
			public int DecimalDigits; // 0x14
			public int DecimalPointPos; // 0x18
			public int DecimalTailSharpDigits; // 0x1C
			public int IntegerDigits; // 0x20
			public int IntegerHeadSharpDigits; // 0x24
			public int IntegerHeadPos; // 0x28
			public bool UseExponent; // 0x2C
			public int ExponentDigits; // 0x30
			public int ExponentTailSharpDigits; // 0x34
			public bool ExponentNegativeSignOnly; // 0x38
			public int DividePlaces; // 0x3C
			public int Percents; // 0x40
			public int Permilles; // 0x44
	
			// Constructors
			public CustomInfo() {} // 0x000000018067EEC0-0x000000018067EED0
	
			// Methods
			public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length) {} // 0x000000018067E710-0x000000018067EB40
			public static CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi) => default; // 0x000000018067EB40-0x000000018067EEC0
			public string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp) => default; // 0x000000018067DF50-0x000000018067E710
		}
	
		// Constructors
		public NumberFormatter() {} // Dummy constructor
		static NumberFormatter() {} // 0x0000000180689BF0-0x0000000180689C50
		private NumberFormatter(Thread current) {} // 0x0000000180689C50-0x0000000180689D20
	
		// Methods
		private static unsafe void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) {
			MantissaBitsTable = default;
			TensExponentTable = default;
			DigitLowerTable = default;
			DigitUpperTable = default;
			TenPowersList = default;
			DecHexDigits = default;
		} // 0x00000001806874B0-0x00000001806874C0
		private static long GetTenPowerOf(int i) => default; // 0x0000000180687700-0x0000000180687770
		private void InitDecHexDigits(uint value) {} // 0x0000000180687AB0-0x0000000180687B60
		private void InitDecHexDigits(ulong value) {} // 0x0000000180687970-0x0000000180687AB0
		private void InitDecHexDigits(uint hi, ulong lo) {} // 0x0000000180687770-0x0000000180687970
		private static uint FastToDecHex(int val) => default; // 0x0000000180685920-0x00000001806859F0
		private static uint ToDecHex(int val) => default; // 0x0000000180689AA0-0x0000000180689B50
		private static int FastDecHexLen(int val) => default; // 0x00000001806858F0-0x0000000180685920
		private static int DecHexLen(uint val) => default; // 0x0000000180685820-0x00000001806858E0
		private int DecHexLen() => default; // 0x00000001806856F0-0x0000000180685820
		private static int ScaleOrder(long hi) => default; // 0x0000000180689A20-0x0000000180689AA0
		private int InitialFloatingPrecision() => default; // 0x0000000180688580-0x0000000180688650
		private static int ParsePrecision(string format) => default; // 0x0000000180689460-0x00000001806894E0
		private void Init(string format) {} // 0x0000000180688290-0x00000001806883D0
		private void InitHex(ulong value) {} // 0x0000000180687B60-0x0000000180687BB0
		private void Init(string format, int value, int defPrecision) {} // 0x0000000180687C40-0x0000000180687CF0
		private void Init(string format, uint value, int defPrecision) {} // 0x0000000180687CF0-0x0000000180687D90
		private void Init(string format, long value) {} // 0x0000000180687D90-0x0000000180687E30
		private void Init(string format, ulong value) {} // 0x0000000180687BB0-0x0000000180687C40
		private void Init(string format, double value, int defPrecision) {} // 0x0000000180687E30-0x0000000180688290
		private void Init(string format, decimal value) {} // 0x00000001806883D0-0x0000000180688580
		private void ResetCharBuf(int size) {} // 0x00000001806895B0-0x0000000180689620
		private void Resize(int len) {} // 0x0000000180689620-0x0000000180689670
		private void Append(char c) {} // 0x00000001806852C0-0x0000000180685370
		private void Append(char c, int cnt) {} // 0x00000001806851E0-0x00000001806852C0
		private void Append(string s) {} // 0x0000000180685370-0x0000000180685460
		private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) => default; // 0x00000001806876E0-0x0000000180687700
		private void RoundPos(int pos) {} // 0x0000000180689A10-0x0000000180689A20
		private bool RoundDecimal(int decimals) => default; // 0x00000001806899F0-0x0000000180689A10
		private bool RoundBits(int shift) => default; // 0x0000000180689670-0x00000001806899F0
		private void RemoveTrailingZeros() {} // 0x0000000180689580-0x00000001806895B0
		private void AddOneToDecHex() {} // 0x0000000180684370-0x00000001806844A0
		private static uint AddOneToDecHex(uint val) => default; // 0x00000001806842F0-0x0000000180684370
		private int CountTrailingZeros() => default; // 0x00000001806854B0-0x00000001806856F0
		private static int CountTrailingZeros(uint val) => default; // 0x0000000180685460-0x00000001806854B0
		private static NumberFormatter GetInstance(IFormatProvider fp) => default; // 0x00000001806874C0-0x00000001806876E0
		private void Release() {} // 0x00000001806894E0-0x0000000180689580
		public static string NumberToString(string format, uint value, IFormatProvider fp) => default; // 0x00000001806890E0-0x0000000180689200
		public static string NumberToString(string format, int value, IFormatProvider fp) => default; // 0x0000000180689200-0x0000000180689330
		public static string NumberToString(string format, ulong value, IFormatProvider fp) => default; // 0x0000000180688EE0-0x0000000180689000
		public static string NumberToString(string format, long value, IFormatProvider fp) => default; // 0x0000000180689330-0x0000000180689460
		public static string NumberToString(string format, float value, IFormatProvider fp) => default; // 0x0000000180688940-0x0000000180688B10
		public static string NumberToString(string format, double value, IFormatProvider fp) => default; // 0x0000000180688B10-0x0000000180688D30
		public static string NumberToString(string format, decimal value, IFormatProvider fp) => default; // 0x0000000180689000-0x00000001806890E0
		private string IntegerToString(string format, IFormatProvider fp) => default; // 0x0000000180688650-0x0000000180688860
		private string NumberToString(string format, NumberFormatInfo nfi) => default; // 0x0000000180688D30-0x0000000180688EE0
		private string FormatCurrency(int precision, NumberFormatInfo nfi) => default; // 0x00000001806859F0-0x0000000180685DC0
		private string FormatDecimal(int precision, NumberFormatInfo nfi) => default; // 0x00000001806865A0-0x0000000180686660
		private string FormatHexadecimal(int precision) => default; // 0x0000000180686CD0-0x0000000180686E80
		private string FormatFixedPoint(int precision, NumberFormatInfo nfi) => default; // 0x00000001806869D0-0x0000000180686B60
		private string FormatRoundtrip(double origval, NumberFormatInfo nfi) => default; // 0x0000000180687250-0x0000000180687380
		private string FormatRoundtrip(float origval, NumberFormatInfo nfi) => default; // 0x0000000180687380-0x0000000180687450
		private string FormatGeneral(int precision, NumberFormatInfo nfi) => default; // 0x0000000180686B60-0x0000000180686CD0
		private string FormatNumber(int precision, NumberFormatInfo nfi) => default; // 0x0000000180686E80-0x0000000180687070
		private string FormatPercent(int precision, NumberFormatInfo nfi) => default; // 0x0000000180687070-0x0000000180687250
		private string FormatExponential(int precision, NumberFormatInfo nfi) => default; // 0x0000000180686970-0x00000001806869D0
		private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) => default; // 0x0000000180686660-0x0000000180686970
		private string FormatCustom(string format, NumberFormatInfo nfi) => default; // 0x0000000180685DC0-0x00000001806865A0
		private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) {} // 0x0000000180689B50-0x0000000180689BF0
		private static bool IsZeroOnly(StringBuilder sb) => default; // 0x0000000180688860-0x0000000180688930
		private static void AppendNonNegativeNumber(StringBuilder sb, int v) {} // 0x0000000180684F20-0x00000001806850F0
		private void AppendIntegerString(int minLength, StringBuilder sb) {} // 0x0000000180684E30-0x0000000180684EC0
		private void AppendIntegerString(int minLength) {} // 0x0000000180684EC0-0x0000000180684F20
		private void AppendDecimalString(int precision, StringBuilder sb) {} // 0x00000001806844A0-0x00000001806844D0
		private void AppendDecimalString(int precision) {} // 0x00000001806844D0-0x00000001806844F0
		private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) {} // 0x0000000180684BD0-0x0000000180684E30
		private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) {} // 0x0000000180684A70-0x0000000180684BD0
		private void AppendOneDigit(int start) {} // 0x00000001806850F0-0x00000001806851E0
		private void AppendDigits(int start, int end) {} // 0x0000000180684730-0x0000000180684A70
		private void AppendDigits(int start, int end, StringBuilder sb) {} // 0x00000001806844F0-0x0000000180684730
		private void Multiply10(int count) {} // 0x0000000180688930-0x0000000180688940
		private void Divide10(int count) {} // 0x00000001806858E0-0x00000001806858F0
		private NumberFormatter GetClone() => default; // 0x0000000180687450-0x00000001806874B0
	}
}
