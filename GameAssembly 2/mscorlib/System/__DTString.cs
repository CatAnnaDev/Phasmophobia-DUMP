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
	internal struct __DTString // TypeDefIndex: 221
	{
		// Fields
		internal string Value; // 0x00
		internal int Index; // 0x08
		internal int len; // 0x0C
		internal char m_current; // 0x10
		private CompareInfo m_info; // 0x18
		private bool m_checkDigitToken; // 0x20
		private static char[] WhiteSpaceChecks; // 0x00
	
		// Properties
		internal CompareInfo CompareInfo { get => default; } // 0x00000001800121D0-0x00000001800124D0 
	
		// Constructors
		internal __DTString(string str, DateTimeFormatInfo dtfi, bool checkDigitToken) : this() {
			Value = default;
			Index = default;
			len = default;
			m_current = default;
			m_info = default;
			m_checkDigitToken = default;
		} // 0x0000000180048340-0x0000000180048370
		internal __DTString(string str, DateTimeFormatInfo dtfi) : this() {
			Value = default;
			Index = default;
			len = default;
			m_current = default;
			m_info = default;
			m_checkDigitToken = default;
		} // 0x0000000180048370-0x0000000180048430
		static __DTString() {
			WhiteSpaceChecks = default;
		} // 0x0000000180A799B0-0x0000000180A79B50
	
		// Methods
		internal bool GetNext() => default; // 0x0000000180047990-0x00000001800479D0
		internal bool AtEnd() => default; // 0x0000000180047840-0x0000000180047850
		internal bool Advance(int count) => default; // 0x0000000180047800-0x0000000180047840
		internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) {
			tokenType = default;
			tokenValue = default;
		} // 0x00000001800479D0-0x00000001800479E0
		internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) {
			indexBeforeSeparator = default;
			charBeforeSeparator = default;
			return default;
		} // 0x0000000180047A60-0x0000000180047B70
		internal bool MatchSpecifiedWord(string target) => default; // 0x0000000180047D80-0x0000000180047E00
		internal bool MatchSpecifiedWord(string target, int endIndex) => default; // 0x0000000180047D70-0x0000000180047D80
		internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) => default; // 0x0000000180047E00-0x0000000180047E10
		internal bool Match(string str) => default; // 0x0000000180047E10-0x0000000180047EC0
		internal bool Match(char ch) => default; // 0x0000000180047EC0-0x0000000180047F20
		internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) => default; // 0x0000000180047CC0-0x0000000180047D70
		internal int GetRepeatCount() => default; // 0x00000001800479E0-0x0000000180047A60
		internal bool GetNextDigit() => default; // 0x0000000180047910-0x0000000180047990
		internal char GetChar() => default; // 0x00000001800478B0-0x00000001800478E0
		internal int GetDigit() => default; // 0x00000001800478E0-0x0000000180047910
		internal void SkipWhiteSpaces() {} // 0x00000001800481C0-0x0000000180048260
		internal bool SkipWhiteSpaceCurrent() => default; // 0x00000001800481B0-0x00000001800481C0
		internal void TrimTail() {} // 0x0000000180048260-0x0000000180048340
		internal void RemoveTrailingInQuoteSpaces() {} // 0x0000000180048040-0x00000001800481B0
		internal void RemoveLeadingInQuoteSpaces() {} // 0x0000000180047F20-0x0000000180048040
		internal DTSubString GetSubString() => default; // 0x0000000180047B70-0x0000000180047CC0
		internal void ConsumeSubString(DTSubString sub) {} // 0x0000000180047850-0x00000001800478B0
	}
}
