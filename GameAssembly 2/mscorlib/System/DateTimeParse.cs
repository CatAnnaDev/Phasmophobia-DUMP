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
	internal static class DateTimeParse // TypeDefIndex: 216
	{
		// Fields
		internal static MatchNumberDelegate m_hebrewNumberParser; // 0x00
		private static DS[][] dateParsingStates; // 0x08
	
		// Nested types
		internal delegate bool MatchNumberDelegate(ref __DTString str, int digitLen, out int result); // TypeDefIndex: 217; 0x0000000180916AA0-0x0000000180916DC0
	
		internal enum DTT // TypeDefIndex: 218
		{
			End = 0,
			NumEnd = 1,
			NumAmpm = 2,
			NumSpace = 3,
			NumDatesep = 4,
			NumTimesep = 5,
			MonthEnd = 6,
			MonthSpace = 7,
			MonthDatesep = 8,
			NumDatesuff = 9,
			NumTimesuff = 10,
			DayOfWeek = 11,
			YearSpace = 12,
			YearDateSep = 13,
			YearEnd = 14,
			TimeZone = 15,
			Era = 16,
			NumUTCTimeMark = 17,
			Unk = 18,
			NumLocalTimeMark = 19,
			Max = 20
		}
	
		internal enum TM // TypeDefIndex: 219
		{
			NotSet = -1,
			AM = 0,
			PM = 1
		}
	
		internal enum DS // TypeDefIndex: 220
		{
			BEGIN = 0,
			N = 1,
			NN = 2,
			D_Nd = 3,
			D_NN = 4,
			D_NNd = 5,
			D_M = 6,
			D_MN = 7,
			D_NM = 8,
			D_MNd = 9,
			D_NDS = 10,
			D_Y = 11,
			D_YN = 12,
			D_YNd = 13,
			D_YM = 14,
			D_YMd = 15,
			D_S = 16,
			T_S = 17,
			T_Nt = 18,
			T_NNt = 19,
			ERROR = 20,
			DX_NN = 21,
			DX_NNN = 22,
			DX_MN = 23,
			DX_NM = 24,
			DX_MNN = 25,
			DX_DS = 26,
			DX_DSN = 27,
			DX_NDS = 28,
			DX_NNDS = 29,
			DX_YNN = 30,
			DX_YMN = 31,
			DX_YN = 32,
			DX_YM = 33,
			TX_N = 34,
			TX_NN = 35,
			TX_NNN = 36,
			TX_TS = 37,
			DX_NNY = 38
		}
	
		// Constructors
		static DateTimeParse() {} // 0x000000018090F5B0-0x00000001809106F0
	
		// Methods
		internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style) => default; // 0x000000018090C520-0x000000018090C640
		internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) => default; // 0x000000018090E800-0x000000018090E940
		internal static DateTime ParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) => default; // 0x000000018090C400-0x000000018090C520
		internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) => default; // 0x000000018090E570-0x000000018090E800
		private static bool MatchWord(ref __DTString str, string target) => default; // 0x000000018090A9C0-0x000000018090AB00
		private static bool GetTimeZoneName(ref __DTString str) => default; // 0x0000000180908B70-0x0000000180908C10
		internal static bool IsDigit(char ch) => default; // 0x00000001809090F0-0x0000000180909110
		private static bool ParseFraction(ref __DTString str, out double result) {
			result = default;
			return default;
		} // 0x000000018090C780-0x000000018090C870
		private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) => default; // 0x000000018090D1E0-0x000000018090D4F0
		private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) => default; // 0x0000000180908F90-0x00000001809090F0
		private static bool Lex(DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) => default; // 0x0000000180909110-0x000000018090A0F0
		private static bool VerifyValidPunctuation(ref __DTString str) => default; // 0x000000018090F440-0x000000018090F5B0
		private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) {
			order = default;
			return default;
		} // 0x0000000180908C10-0x0000000180908E40
		private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) {
			order = default;
			return default;
		} // 0x0000000180908E40-0x0000000180908F90
		private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) {
			order = default;
			return default;
		} // 0x0000000180908820-0x00000001809089B0
		private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) {
			adjustedYear = default;
			return default;
		} // 0x000000018090E4C0-0x000000018090E570
		private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) => default; // 0x000000018090E440-0x000000018090E4C0
		private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) => default; // 0x000000018090E2C0-0x000000018090E380
		private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) => default; // 0x000000018090E200-0x000000018090E2C0
		private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) => default; // 0x000000018090E380-0x000000018090E440
		private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) {} // 0x0000000180908600-0x00000001809086A0
		private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x0000000180907F00-0x00000001809080E0
		private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x0000000180907860-0x0000000180907D20
		private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x0000000180907340-0x00000001809075D0
		private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x00000001809086A0-0x0000000180908820
		private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x00000001809075D0-0x0000000180907860
		private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x0000000180906F30-0x0000000180907340
		private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x0000000180908320-0x00000001809084C0
		private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x0000000180907D20-0x0000000180907F00
		private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x00000001809080E0-0x00000001809081E0
		private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x00000001809084C0-0x0000000180908600
		private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x00000001809081E0-0x0000000180908320
		private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) {} // 0x00000001809052C0-0x0000000180905330
		private static bool AdjustHour(ref int hour, TM timeMark) => default; // 0x0000000180905280-0x00000001809052C0
		private static bool GetTimeOfN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x0000000180908AE0-0x0000000180908B70
		private static bool GetTimeOfNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x0000000180908A50-0x0000000180908AE0
		private static bool GetTimeOfNNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x00000001809089B0-0x0000000180908A50
		private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x00000001809067E0-0x0000000180906870
		private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) => default; // 0x0000000180906870-0x0000000180906930
		private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x0000000180906930-0x0000000180906BD0
		private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) => default; // 0x000000018090D710-0x000000018090D7F0
		internal static bool ProcessHebrewTerminalState(DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018090D7F0-0x000000018090DC70
		internal static bool ProcessTerminaltState(DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) => default; // 0x000000018090DC70-0x000000018090E200
		internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles) => default; // 0x000000018090D4F0-0x000000018090D5F0
		internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) {
			offset = default;
			return default;
		} // 0x000000018090D5F0-0x000000018090D710
		internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) {
			result = default;
			return default;
		} // 0x000000018090F330-0x000000018090F440
		internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) => default; // 0x000000018090EA10-0x000000018090F330
		private static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) => default; // 0x0000000180905B50-0x0000000180905D50
		private static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles) => default; // 0x0000000180905950-0x0000000180905B50
		private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) => default; // 0x00000001809055B0-0x0000000180905670
		private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) => default; // 0x0000000180905330-0x00000001809055B0
		private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) => default; // 0x000000018090C870-0x000000018090CE20
		internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) {
			number = default;
			return default;
		} // 0x000000018090A640-0x000000018090A720
		internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) {
			result = default;
			return default;
		} // 0x000000018090C250-0x000000018090C350
		internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) {
			result = default;
			return default;
		} // 0x000000018090C350-0x000000018090C400
		private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) => default; // 0x000000018090C640-0x000000018090C780
		private static bool ParseSign(ref __DTString str, ref bool result) => default; // 0x000000018090CE20-0x000000018090CE80
		private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) => default; // 0x000000018090CE80-0x000000018090D1E0
		private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) => default; // 0x000000018090A1D0-0x000000018090A330
		private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) => default; // 0x000000018090A720-0x000000018090A8B0
		private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) => default; // 0x000000018090A0F0-0x000000018090A1D0
		private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) => default; // 0x000000018090A3E0-0x000000018090A4C0
		private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) => default; // 0x000000018090A4C0-0x000000018090A640
		private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result) => default; // 0x000000018090A8B0-0x000000018090A9C0
		private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result) => default; // 0x000000018090A330-0x000000018090A3E0
		private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) => default; // 0x00000001809058A0-0x0000000180905950
		private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) => default; // 0x0000000180906BD0-0x0000000180906D40
		private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) => default; // 0x0000000180905670-0x00000001809058A0
		private static string ExpandPredefinedFormat(string format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) => default; // 0x00000001809063B0-0x00000001809067E0
		private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) => default; // 0x000000018090AB00-0x000000018090C250
		internal static bool TryParseQuoteString(string format, int pos, StringBuilder result, out int returnValue) {
			returnValue = default;
			return default;
		} // 0x000000018090E940-0x000000018090EA10
		private static bool DoStrictParse(string s, string formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) => default; // 0x0000000180905D50-0x00000001809063B0
		private static Exception GetDateTimeParseException(ref DateTimeResult result) => default; // 0x0000000180906D40-0x0000000180906F30
	}
}
