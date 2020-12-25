/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800E9800-0x00000001800E9850
	public sealed class String : IComparable, ICloneable, IConvertible, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 292
	{
		// Fields
		[NonSerialized]
		private int m_stringLength; // 0x10
		[NonSerialized]
		private char m_firstChar; // 0x14
		private const int TrimHead = 0; // Metadata: 0x006300BA
		private const int TrimTail = 1; // Metadata: 0x006300BE
		private const int TrimBoth = 2; // Metadata: 0x006300C2
		public static readonly string Empty; // 0x00
		private const int charPtrAlignConst = 1; // Metadata: 0x006300C6
		private const int alignConst = 3; // Metadata: 0x006300CA
	
		// Properties
		public char this[int index] { get => default; } // 0x00000001808CA490-0x00000001808CA500 
		public int Length { get => default; } // 0x0000000180245EA0-0x0000000180246600 
	
		// Constructors
		public String() {} // Dummy constructor
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public unsafe String(char* value) {} // 0x00000001808CA390-0x00000001808CA3A0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public unsafe String(char* value, int startIndex, int length) {} // 0x00000001808CA390-0x00000001808CA3A0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public unsafe String(sbyte* value) {} // 0x00000001808CA390-0x00000001808CA3A0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public unsafe String(sbyte* value, int startIndex, int length) {} // 0x00000001808CA390-0x00000001808CA3A0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public unsafe String(sbyte* value, int startIndex, int length, Encoding enc) {} // 0x00000001808CA390-0x00000001808CA3A0
		public String(char[] value, int startIndex, int length) {} // 0x00000001808CA390-0x00000001808CA3A0
		public String(char[] value) {} // 0x00000001808CA390-0x00000001808CA3A0
		public String(char c, int count) {} // 0x00000001808CA390-0x00000001808CA3A0
	
		// Methods
		public static string Join(string separator, params /* 0x00000001800D4E50-0x00000001800D4E60 */ string[] value) => default; // 0x00000001808C6EF0-0x00000001808C6F80
		// [ComVisible] // 0x00000001800DEBC0-0x00000001800DEBE0
		public static string Join(string separator, IEnumerable<string> values) => default; // 0x00000001808C6C40-0x00000001808C6EF0
		public static string Join(string separator, string[] value, int startIndex, int count) => default; // 0x00000001808C6F80-0x00000001808C7290
		private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) => default; // 0x00000001808C1920-0x00000001808C1A20
		// [ReliabilityContract] // 0x00000001800E9980-0x00000001800E99A0
		private static bool EqualsHelper(string strA, string strB) => default; // 0x00000001808C4890-0x00000001808C49A0
		private static int CompareOrdinalHelper(string strA, string strB) => default; // 0x00000001808C1770-0x00000001808C1920
		// [ReliabilityContract] // 0x00000001800E9980-0x00000001800E99A0
		public override bool Equals(object obj) => default; // 0x00000001808C4CB0-0x00000001808C4D60
		// [ReliabilityContract] // 0x00000001800E9980-0x00000001800E99A0
		public bool Equals(string value) => default; // 0x00000001808C4D90-0x00000001808C4E30
		public bool Equals(string value, StringComparison comparisonType) => default; // 0x00000001808C4E30-0x00000001808C5140
		public static bool Equals(string a, string b) => default; // 0x00000001808C4D60-0x00000001808C4D90
		public static bool Equals(string a, string b, StringComparison comparisonType) => default; // 0x00000001808C49A0-0x00000001808C4CB0
		public static bool operator ==(string a, string b) => default; // 0x00000001808C4D60-0x00000001808C4D90
		public static bool operator !=(string a, string b) => default; // 0x00000001808CA7B0-0x00000001808CA7F0
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) {} // 0x00000001808C3590-0x00000001808C3790
		public char[] ToCharArray() => default; // 0x00000001808C9CA0-0x00000001808C9D20
		public static bool IsNullOrEmpty(string value) => default; // 0x0000000180422B20-0x0000000180422B30
		public static bool IsNullOrWhiteSpace(string value) => default; // 0x00000001808C6BA0-0x00000001808C6C40
		// [ReliabilityContract] // 0x00000001800E9980-0x00000001800E99A0
		public override int GetHashCode() => default; // 0x00000001808C5710-0x00000001808C5770
		// [ReliabilityContract] // 0x00000001800E9980-0x00000001800E99A0
		internal int GetLegacyNonRandomizedHashCode() => default; // 0x00000001808C5710-0x00000001808C5770
		public string[] Split(params /* 0x00000001800D4E50-0x00000001800D4E60 */ char[] separator) => default; // 0x00000001808C8F20-0x00000001808C8F40
		public string[] Split(char[] separator, int count) => default; // 0x00000001808C8F60-0x00000001808C8F80
		// [ComVisible] // 0x00000001800DEBC0-0x00000001800DEBE0
		public string[] Split(char[] separator, StringSplitOptions options) => default; // 0x00000001808C8F40-0x00000001808C8F60
		// [ComVisible] // 0x00000001800DEBC0-0x00000001800DEBE0
		internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) => default; // 0x00000001808C8D10-0x00000001808C8F20
		private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) => default; // 0x00000001808C6520-0x00000001808C67D0
		private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) => default; // 0x00000001808C67D0-0x00000001808C6B00
		private int MakeSeparatorList(char[] separator, ref int[] sepList) => default; // 0x00000001808C7C90-0x00000001808C7E30
		public string Substring(int startIndex) => default; // 0x00000001808C9350-0x00000001808C9360
		public string Substring(int startIndex, int length) => default; // 0x00000001808C9360-0x00000001808C9530
		private string InternalSubString(int startIndex, int length) => default; // 0x00000001808C6B00-0x00000001808C6B70
		public string Trim(params /* 0x00000001800D4E50-0x00000001800D4E60 */ char[] trimChars) => default; // 0x00000001808CA350-0x00000001808CA380
		public string TrimStart(params /* 0x00000001800D4E50-0x00000001800D4E60 */ char[] trimChars) => default; // 0x00000001808CA320-0x00000001808CA350
		public string TrimEnd(params /* 0x00000001800D4E50-0x00000001800D4E60 */ char[] trimChars) => default; // 0x00000001808C9FE0-0x00000001808CA010
		internal static unsafe string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) => default; // 0x00000001808C3840-0x00000001808C3930
		public string Normalize(NormalizationForm normalizationForm) => default; // 0x00000001808C7E30-0x00000001808C7EE0
		internal static string FastAllocateString(int length) => default; // 0x00000001808C5140-0x00000001808C5150
		private static void FillStringChecked(string dest, int destPos, string src) {} // 0x00000001808C5150-0x00000001808C51F0
		internal static unsafe void wstrcpy(char* dmem, char* smem, int charCount) {} // 0x00000001808CA850-0x00000001808CA860
		private string CtorCharArray(char[] value) => default; // 0x00000001808C4100-0x00000001808C41A0
		private string CtorCharArrayStartLength(char[] value, int startIndex, int length) => default; // 0x00000001808C3F20-0x00000001808C4100
		private static unsafe int wcslen(char* ptr) => default; // 0x00000001808CA7F0-0x00000001808CA850
		private unsafe string CtorCharPtr(char* ptr) => default; // 0x00000001808C43B0-0x00000001808C4540
		private unsafe string CtorCharPtrStartLength(char* ptr, int startIndex, int length) => default; // 0x00000001808C41A0-0x00000001808C43B0
		public static int Compare(string strA, string strB, bool ignoreCase) => default; // 0x00000001808C27A0-0x00000001808C28A0
		public static int Compare(string strA, string strB, StringComparison comparisonType) => default; // 0x00000001808C2470-0x00000001808C27A0
		public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) => default; // 0x00000001808C29B0-0x00000001808C2A90
		public static int Compare(string strA, int indexA, string strB, int indexB, int length) => default; // 0x00000001808C28A0-0x00000001808C29B0
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) => default; // 0x00000001808C2350-0x00000001808C2470
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) => default; // 0x00000001808C1E70-0x00000001808C2350
		public int CompareTo(object value) => default; // 0x00000001808C1CF0-0x00000001808C1E70
		public int CompareTo(string strB) => default; // 0x00000001808C1C30-0x00000001808C1CF0
		public static int CompareOrdinal(string strA, string strB) => default; // 0x00000001808C1BB0-0x00000001808C1BF0
		public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) => default; // 0x00000001808C1BF0-0x00000001808C1C30
		public bool Contains(string value) => default; // 0x00000001808C3560-0x00000001808C3590
		public bool EndsWith(string value) => default; // 0x00000001808C4880-0x00000001808C4890
		// [ComVisible] // 0x00000001800DEBC0-0x00000001800DEBE0
		public bool EndsWith(string value, StringComparison comparisonType) => default; // 0x00000001808C4570-0x00000001808C4880
		internal bool EndsWith(char value) => default; // 0x00000001808C4540-0x00000001808C4570
		public int IndexOf(char value) => default; // 0x00000001808C5E80-0x00000001808C5EA0
		public int IndexOf(char value, int startIndex) => default; // 0x00000001808C5ED0-0x00000001808C5EF0
		public int IndexOfAny(char[] anyOf) => default; // 0x00000001808C58A0-0x00000001808C58C0
		public int IndexOfAny(char[] anyOf, int startIndex) => default; // 0x00000001808C58C0-0x00000001808C58E0
		public int IndexOf(string value) => default; // 0x00000001808C5F10-0x00000001808C5F30
		public int IndexOf(string value, int startIndex) => default; // 0x00000001808C5EF0-0x00000001808C5F10
		public int IndexOf(string value, StringComparison comparisonType) => default; // 0x00000001808C6300-0x00000001808C6330
		public int IndexOf(string value, int startIndex, StringComparison comparisonType) => default; // 0x00000001808C5EA0-0x00000001808C5ED0
		public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) => default; // 0x00000001808C5F30-0x00000001808C6300
		public int LastIndexOf(char value) => default; // 0x00000001808C7AB0-0x00000001808C7AD0
		public int LastIndexOf(char value, int startIndex) => default; // 0x00000001808C7B00-0x00000001808C7B20
		public int LastIndexOfAny(char[] anyOf) => default; // 0x00000001808C7550-0x00000001808C7570
		public int LastIndexOfAny(char[] anyOf, int startIndex) => default; // 0x00000001808C7570-0x00000001808C7590
		public int LastIndexOf(string value) => default; // 0x00000001808C7B20-0x00000001808C7B50
		public int LastIndexOf(string value, StringComparison comparisonType) => default; // 0x00000001808C7AD0-0x00000001808C7B00
		public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) => default; // 0x00000001808C76A0-0x00000001808C7AB0
		public string PadLeft(int totalWidth, char paddingChar) => default; // 0x00000001808C80A0-0x00000001808C80C0
		public string PadRight(int totalWidth, char paddingChar) => default; // 0x00000001808C80C0-0x00000001808C80E0
		public bool StartsWith(string value) => default; // 0x00000001808C8FD0-0x00000001808C9050
		// [ComVisible] // 0x00000001800DEBC0-0x00000001800DEBE0
		public bool StartsWith(string value, StringComparison comparisonType) => default; // 0x00000001808C9050-0x00000001808C9350
		public string ToLower() => default; // 0x00000001808C9D80-0x00000001808C9DE0
		public string ToLower(CultureInfo culture) => default; // 0x00000001808C9DE0-0x00000001808C9E80
		public string ToLowerInvariant() => default; // 0x00000001808C9D20-0x00000001808C9D80
		public string ToUpper() => default; // 0x00000001808C9EE0-0x00000001808C9F40
		public string ToUpper(CultureInfo culture) => default; // 0x00000001808C9F40-0x00000001808C9FE0
		public string ToUpperInvariant() => default; // 0x00000001808C9E80-0x00000001808C9EE0
		public override string ToString() => default; // 0x00000001802A78B0-0x00000001802A78C0
		public string ToString(IFormatProvider provider) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public object Clone() => default; // 0x00000001802A78B0-0x00000001802A78C0
		private static bool IsBOMWhitespace(char c) => default; // 0x0000000180250A70-0x0000000180250A80
		public string Trim() => default; // 0x00000001808CA380-0x00000001808CA390
		private string TrimHelper(int trimType) => default; // 0x00000001808CA180-0x00000001808CA320
		private string TrimHelper(char[] trimChars, int trimType) => default; // 0x00000001808CA010-0x00000001808CA180
		private string CreateTrimmedString(int start, int end) => default; // 0x00000001808C3E80-0x00000001808C3F20
		public string Insert(int startIndex, string value) => default; // 0x00000001808C6330-0x00000001808C64A0
		public string Replace(char oldChar, char newChar) => default; // 0x00000001808C8AD0-0x00000001808C8C10
		public string Replace(string oldValue, string newValue) => default; // 0x00000001808C8C10-0x00000001808C8D10
		public string Remove(int startIndex, int count) => default; // 0x00000001808C80E0-0x00000001808C82A0
		public static string Format(string format, object arg0) => default; // 0x00000001808C52D0-0x00000001808C5330
		public static string Format(string format, object arg0, object arg1) => default; // 0x00000001808C5330-0x00000001808C5390
		public static string Format(string format, object arg0, object arg1, object arg2) => default; // 0x00000001808C5390-0x00000001808C53F0
		public static string Format(string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) => default; // 0x00000001808C54E0-0x00000001808C55B0
		public static string Format(IFormatProvider provider, string format, object arg0) => default; // 0x00000001808C53F0-0x00000001808C5460
		public static string Format(IFormatProvider provider, string format, object arg0, object arg1) => default; // 0x00000001808C5460-0x00000001808C54E0
		public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) => default; // 0x00000001808C55B0-0x00000001808C5630
		public static string Format(IFormatProvider provider, string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) => default; // 0x00000001808C5630-0x00000001808C5710
		private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) => default; // 0x00000001808C51F0-0x00000001808C52D0
		public static string Copy(string str) => default; // 0x00000001808C3790-0x00000001808C3840
		public static string Concat(object arg0) => default; // 0x00000001808C2E30-0x00000001808C2E90
		public static string Concat(object arg0, object arg1) => default; // 0x00000001808C3170-0x00000001808C3220
		public static string Concat(object arg0, object arg1, object arg2) => default; // 0x00000001808C2D40-0x00000001808C2E30
		public static string Concat(params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) => default; // 0x00000001808C2F80-0x00000001808C3170
		public static string Concat(string str0, string str1) => default; // 0x00000001808C2E90-0x00000001808C2F80
		public static string Concat(string str0, string str1, string str2) => default; // 0x00000001808C33D0-0x00000001808C3560
		public static string Concat(string str0, string str1, string str2, string str3) => default; // 0x00000001808C3220-0x00000001808C33D0
		private static string ConcatArray(string[] values, int totalLength) => default; // 0x00000001808C2A90-0x00000001808C2BC0
		public static string Concat(params /* 0x00000001800D4E50-0x00000001800D4E60 */ string[] values) => default; // 0x00000001808C2BC0-0x00000001808C2D40
		public static string Intern(string str) => default; // 0x00000001808C64A0-0x00000001808C6510
		public TypeCode GetTypeCode() => default; // 0x0000000180605000-0x0000000180605010
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x00000001808C95F0-0x00000001808C9660
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x00000001808C96D0-0x00000001808C9740
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x00000001808C99F0-0x00000001808C9A60
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x00000001808C9660-0x00000001808C96D0
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x00000001808C98A0-0x00000001808C9910
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x00000001808C9B50-0x00000001808C9BC0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x00000001808C9910-0x00000001808C9980
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x00000001808C9BC0-0x00000001808C9C30
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001808C9980-0x00000001808C99F0
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x00000001808C9C30-0x00000001808C9CA0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x00000001808C9A60-0x00000001808C9AD0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x00000001808C9830-0x00000001808C98A0
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001808C97B0-0x00000001808C9830
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x00000001808C9740-0x00000001808C97B0
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x00000001808C9AD0-0x00000001808C9B50
		IEnumerator<char> IEnumerable<char>.GetEnumerator() => default; // 0x00000001808C9530-0x00000001808C9590
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001808C9590-0x00000001808C95F0
		internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) => default; // 0x00000001808C1A20-0x00000001808C1BB0
		public int IndexOf(char value, int startIndex, int count) => default; // 0x00000001808C5D30-0x00000001808C5E80
		internal int IndexOfUnchecked(char value, int startIndex, int count) => default; // 0x00000001808C5AE0-0x00000001808C5BE0
		internal int IndexOfUnchecked(string value, int startIndex, int count) => default; // 0x00000001808C5BE0-0x00000001808C5D30
		public int IndexOfAny(char[] anyOf, int startIndex, int count) => default; // 0x00000001808C58E0-0x00000001808C5AE0
		private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) => default; // 0x00000001808C5770-0x00000001808C58A0
		public int LastIndexOf(char value, int startIndex, int count) => default; // 0x00000001808C7B50-0x00000001808C7C90
		internal int LastIndexOfUnchecked(char value, int startIndex, int count) => default; // 0x00000001808C7590-0x00000001808C76A0
		public int LastIndexOfAny(char[] anyOf, int startIndex, int count) => default; // 0x00000001808C7350-0x00000001808C7550
		private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) => default; // 0x00000001808C7290-0x00000001808C7350
		internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) => default; // 0x00000001808CA630-0x00000001808CA7B0
		private string ReplaceInternal(char oldChar, char newChar) => default; // 0x00000001808C8400-0x00000001808C8520
		internal string ReplaceInternal(string oldValue, string newValue) => default; // 0x00000001808C8520-0x00000001808C8620
		private string ReplaceUnchecked(string oldValue, string newValue) => default; // 0x00000001808C8620-0x00000001808C8AD0
		private string ReplaceFallback(string oldValue, string newValue, int testedCount) => default; // 0x00000001808C82A0-0x00000001808C8400
		private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) => default; // 0x00000001808C7EE0-0x00000001808C80A0
		internal bool StartsWithOrdinalUnchecked(string value) => default; // 0x00000001808C8F80-0x00000001808C8FD0
		internal bool IsAscii() => default; // 0x00000001808C6B70-0x00000001808C6BA0
		private static string InternalIntern(string str) => default; // 0x00000001808C6510-0x00000001808C6520
		internal static unsafe void CharCopy(char* dest, char* src, int count) {} // 0x00000001808C1720-0x00000001808C1770
		private static unsafe void memset(byte* dest, int val, int len) {} // 0x00000001808CA550-0x00000001808CA630
		private static unsafe void memcpy(byte* dest, byte* src, int size) {} // 0x00000001808CA540-0x00000001808CA550
		internal static unsafe void bzero(byte* dest, int len) {} // 0x00000001808CA3E0-0x00000001808CA490
		internal static unsafe void bzero_aligned_1(byte* dest, int len) {} // 0x00000001808CA3A0-0x00000001808CA3B0
		internal static unsafe void bzero_aligned_2(byte* dest, int len) {} // 0x00000001808CA3B0-0x00000001808CA3C0
		internal static unsafe void bzero_aligned_4(byte* dest, int len) {} // 0x00000001808CA3C0-0x00000001808CA3D0
		internal static unsafe void bzero_aligned_8(byte* dest, int len) {} // 0x00000001808CA3D0-0x00000001808CA3E0
		internal static unsafe void memcpy_aligned_1(byte* dest, byte* src, int size) {} // 0x00000001808CA500-0x00000001808CA510
		internal static unsafe void memcpy_aligned_2(byte* dest, byte* src, int size) {} // 0x00000001808CA510-0x00000001808CA520
		internal static unsafe void memcpy_aligned_4(byte* dest, byte* src, int size) {} // 0x00000001808CA520-0x00000001808CA530
		internal static unsafe void memcpy_aligned_8(byte* dest, byte* src, int size) {} // 0x00000001808CA530-0x00000001808CA540
		private unsafe string CreateString(sbyte* value) => default; // 0x00000001808C3D70-0x00000001808C3E60
		private unsafe string CreateString(sbyte* value, int startIndex, int length) => default; // 0x00000001808C3AD0-0x00000001808C3AF0
		private unsafe string CreateString(char* value) => default; // 0x00000001808C3D60-0x00000001808C3D70
		private unsafe string CreateString(char* value, int startIndex, int length) => default; // 0x00000001808C3E60-0x00000001808C3E70
		private string CreateString(char[] val, int startIndex, int length) => default; // 0x00000001808C3E70-0x00000001808C3E80
		private string CreateString(char[] val) => default; // 0x00000001808C3A10-0x00000001808C3AD0
		private string CreateString(char c, int count) => default; // 0x00000001808C3930-0x00000001808C3A10
		private unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc) => default; // 0x00000001808C3AF0-0x00000001808C3D60
	}
}
