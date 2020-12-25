/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 4: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2170-2964

namespace System
{
	internal static class UriHelper // TypeDefIndex: 2299
	{
		// Fields
		private static readonly char[] HexUpperChars; // 0x00
	
		// Constructors
		static UriHelper() {} // 0x00000001809CBC20-0x00000001809CBC90
	
		// Methods
		internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) => default; // 0x00000001809CA120-0x00000001809CA820
		private static unsafe char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) => default; // 0x00000001809C9EB0-0x00000001809C9FC0
		internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) => default; // 0x00000001809CB150-0x00000001809CB230
		internal static unsafe char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) => default; // 0x00000001809CB230-0x00000001809CBC20
		internal static unsafe void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) {} // 0x00000001809CABF0-0x00000001809CB150
		internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) {} // 0x00000001809C9FC0-0x00000001809CA120
		internal static char EscapedAscii(char digit, char next) => default; // 0x00000001809CA820-0x00000001809CA8C0
		internal static bool IsNotSafeForUnescape(char ch) => default; // 0x00000001809CA940-0x00000001809CA990
		private static bool IsReservedUnreservedOrHash(char c) => default; // 0x00000001809CA990-0x00000001809CAAC0
		internal static bool IsUnreserved(char c) => default; // 0x00000001809CAAC0-0x00000001809CABF0
		internal static bool Is3986Unreserved(char c) => default; // 0x00000001809CA8C0-0x00000001809CA940
	}
}
