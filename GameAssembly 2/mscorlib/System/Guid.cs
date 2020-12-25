/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public struct Guid : IFormattable, IComparable, IComparable<System.Guid>, IEquatable<System.Guid> // TypeDefIndex: 231
	{
		// Fields
		public static readonly Guid Empty; // 0x00
		private int _a; // 0x00
		private short _b; // 0x04
		private short _c; // 0x06
		private byte _d; // 0x08
		private byte _e; // 0x09
		private byte _f; // 0x0A
		private byte _g; // 0x0B
		private byte _h; // 0x0C
		private byte _i; // 0x0D
		private byte _j; // 0x0E
		private byte _k; // 0x0F
		private static object _rngAccess; // 0x10
		private static RandomNumberGenerator _rng; // 0x18
		private static RandomNumberGenerator _fastRng; // 0x20
	
		// Nested types
		[Flags] // 0x00000001800D4E50-0x00000001800D4E60
		private enum GuidStyles // TypeDefIndex: 232
		{
			None = 0,
			NumberFormat = 0,
			AllowParenthesis = 1,
			AllowBraces = 2,
			AllowDashes = 4,
			AllowHexPrefix = 8,
			Any = 15,
			RequireParenthesis = 16,
			RequireBraces = 32,
			RequireDashes = 64,
			DigitFormat = 64,
			ParenthesisFormat = 80,
			BraceFormat = 96,
			RequireHexPrefix = 128,
			HexFormat = 160
		}
	
		private enum GuidParseThrowStyle // TypeDefIndex: 233
		{
			None = 0,
			All = 1,
			AllButOverflow = 2
		}
	
		private enum ParseFailureKind // TypeDefIndex: 234
		{
			None = 0,
			ArgumentNull = 1,
			Format = 2,
			FormatWithParameter = 3,
			NativeException = 4,
			FormatWithInnerException = 5
		}
	
		private struct GuidResult // TypeDefIndex: 235
		{
			// Fields
			internal Guid parsedGuid; // 0x00
			internal GuidParseThrowStyle throwStyle; // 0x10
			internal ParseFailureKind m_failure; // 0x14
			internal string m_failureMessageID; // 0x18
			internal object m_failureMessageFormatArgument; // 0x20
			internal string m_failureArgumentName; // 0x28
			internal Exception m_innerException; // 0x30
	
			// Methods
			internal void Init(GuidParseThrowStyle canThrow) {} // 0x000000018001A000-0x000000018001A010
			internal void SetFailure(Exception nativeException) {} // 0x000000018001A080-0x000000018001A0C0
			internal void SetFailure(ParseFailureKind failure, string failureMessageID) {} // 0x000000018001A040-0x000000018001A070
			internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) {} // 0x000000018001A010-0x000000018001A040
			internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) {} // 0x000000018001A070-0x000000018001A080
			internal Exception GetGuidParseException() => default; // 0x0000000180019FF0-0x000000018001A000
		}
	
		// Constructors
		public Guid(byte[] b) {
			_a = default;
			_b = default;
			_c = default;
			_d = default;
			_e = default;
			_f = default;
			_g = default;
			_h = default;
			_i = default;
			_j = default;
			_k = default;
		} // 0x000000018001A460-0x000000018001A470
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) {
			_a = default;
			_b = default;
			_c = default;
			_d = default;
			_e = default;
			_f = default;
			_g = default;
			_h = default;
			_i = default;
			_j = default;
			_k = default;
		} // 0x000000018001A410-0x000000018001A460
		public Guid(int a, short b, short c, byte[] d) {
			_a = default;
			_b = default;
			_c = default;
			_d = default;
			_e = default;
			_f = default;
			_g = default;
			_h = default;
			_i = default;
			_j = default;
			_k = default;
		} // 0x000000018001A470-0x000000018001A480
		public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) {
			_a = default;
			_b = default;
			_c = default;
			_d = default;
			_e = default;
			_f = default;
			_g = default;
			_h = default;
			_i = default;
			_j = default;
			_k = default;
		} // 0x000000018001A410-0x000000018001A460
		public Guid(string g) {
			_a = default;
			_b = default;
			_c = default;
			_d = default;
			_e = default;
			_f = default;
			_g = default;
			_h = default;
			_i = default;
			_j = default;
			_k = default;
		} // 0x000000018001A480-0x000000018001A990
		static Guid() {
			Empty = default;
			_rngAccess = default;
			_rng = default;
			_fastRng = default;
		} // 0x00000001804DD830-0x00000001804DDF20
	
		// Methods
		public static Guid Parse(string input) => default; // 0x00000001804DB4B0-0x00000001804DB610
		public static bool TryParse(string input, out Guid result) {
			result = default;
			return default;
		} // 0x00000001804DD700-0x00000001804DD830
		private static bool TryParseGuid(string g, GuidStyles flags, ref GuidResult result) => default; // 0x00000001804DD4F0-0x00000001804DD700
		private static bool TryParseGuidWithHexPrefix(string guidString, ref GuidResult result) => default; // 0x00000001804DC960-0x00000001804DD0B0
		private static bool TryParseGuidWithNoStyle(string guidString, ref GuidResult result) => default; // 0x00000001804DD0B0-0x00000001804DD4F0
		private static bool TryParseGuidWithDashes(string guidString, ref GuidResult result) => default; // 0x00000001804DC4B0-0x00000001804DC960
		private static bool StringToShort(string str, int requiredLength, int flags, out short result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x00000001804DBB40-0x00000001804DC4B0
		private static unsafe bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x00000001804DBA80-0x00000001804DBB40
		private static bool StringToInt(string str, int requiredLength, int flags, out int result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x00000001804DB610-0x00000001804DB6B0
		private static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x00000001804DB830-0x00000001804DB8C0
		private static unsafe bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x00000001804DB6B0-0x00000001804DB830
		private static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x00000001804DB8C0-0x00000001804DB950
		private static unsafe bool StringToLong(string str, int* parsePos, int flags, out long result, ref GuidResult parseResult) {
			result = default;
			return default;
		} // 0x00000001804DB950-0x00000001804DBA80
		private static string EatAllWhitespace(string str) => default; // 0x00000001804DABC0-0x00000001804DAF60
		private static bool IsHexPrefix(string str, int i) => default; // 0x00000001804DB170-0x00000001804DB260
		public byte[] ToByteArray() => default; // 0x000000018001A3A0-0x000000018001A3B0
		public override string ToString() => default; // 0x000000018001A3B0-0x000000018001A3F0
		public override int GetHashCode() => default; // 0x000000018001A350-0x000000018001A380
		public override bool Equals(object o) => default; // 0x000000018001A0F0-0x000000018001A260
		public bool Equals(Guid g) => default; // 0x000000018001A260-0x000000018001A350
		private int GetResult(uint me, uint them) => default; // 0x000000018001A380-0x000000018001A3A0
		public int CompareTo(object value) => default; // 0x000000018001A0C0-0x000000018001A0D0
		public int CompareTo(Guid value) => default; // 0x000000018001A0D0-0x000000018001A0F0
		public static bool operator ==(Guid a, Guid b) => default; // 0x00000001804DDF20-0x00000001804DE0A0
		public static bool operator !=(Guid a, Guid b) => default; // 0x00000001804DE0A0-0x00000001804DE270
		public string ToString(string format) => default; // 0x000000018001A400-0x000000018001A410
		private static char HexToChar(int a) => default; // 0x00000001804DAF60-0x00000001804DAF80
		private static unsafe int HexsToChars(char* guidChars, int offset, int a, int b) => default; // 0x00000001804DAF80-0x00000001804DB010
		private static unsafe int HexsToChars(char* guidChars, int offset, int a, int b, bool hex) => default; // 0x00000001804DB010-0x00000001804DB170
		public string ToString(string format, IFormatProvider provider) => default; // 0x000000018001A3F0-0x000000018001A400
		public static Guid NewGuid() => default; // 0x00000001804DB260-0x00000001804DB4B0
	}
}
