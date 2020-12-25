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
	internal static class DateTimeFormat // TypeDefIndex: 215
	{
		// Fields
		internal static readonly TimeSpan NullOffset; // 0x00
		internal static char[] allStandardFormats; // 0x08
		internal static string[] fixedNumberFormats; // 0x10
	
		// Constructors
		static DateTimeFormat() {} // 0x00000001809038B0-0x0000000180903EB0
	
		// Methods
		internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) {} // 0x0000000180902C30-0x0000000180902CB0
		internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) {} // 0x0000000180902CB0-0x0000000180902DB0
		private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) {} // 0x00000001809034C0-0x0000000180903540
		internal static int ParseRepeatPattern(string format, int pos, char patternChar) => default; // 0x0000000180903830-0x00000001809038B0
		private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) => default; // 0x0000000180902BF0-0x0000000180902C30
		private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) => default; // 0x0000000180902E70-0x0000000180902EB0
		private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) => default; // 0x0000000180902DB0-0x0000000180902E70
		internal static int ParseQuoteString(string format, int pos, StringBuilder result) => default; // 0x0000000180903690-0x0000000180903830
		internal static int ParseNextChar(string format, int pos) => default; // 0x0000000180903650-0x0000000180903690
		private static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch) => default; // 0x0000000180903540-0x0000000180903650
		private static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) => default; // 0x0000000180901B40-0x0000000180902BF0
		private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result) {} // 0x00000001809017B0-0x0000000180901B40
		private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) {} // 0x0000000180901580-0x00000001809017B0
		internal static string GetRealFormat(string format, DateTimeFormatInfo dtfi) => default; // 0x00000001809031A0-0x00000001809034C0
		private static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) => default; // 0x0000000180901190-0x0000000180901580
		internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi) => default; // 0x0000000180902EB0-0x0000000180902F40
		internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) => default; // 0x0000000180902F40-0x00000001809031A0
		internal static void InvalidFormatForLocal(string format, DateTime dateTime) {} // 0x0000000180246DB0-0x0000000180246DC0
		internal static void InvalidFormatForUtc(string format, DateTime dateTime) {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
