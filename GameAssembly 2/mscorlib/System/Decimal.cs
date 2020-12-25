/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public struct Decimal : IFormattable, IComparable, IConvertible, IDeserializationCallback, IComparable<decimal>, IEquatable<decimal> // TypeDefIndex: 192
	{
		// Fields
		private const int SignMask = -2147483648; // Metadata: 0x0062FD44
		private const byte DECIMAL_NEG = 128; // Metadata: 0x0062FD48
		private const byte DECIMAL_ADD = 0; // Metadata: 0x0062FD49
		private const int ScaleMask = 16711680; // Metadata: 0x0062FD4A
		private const int ScaleShift = 16; // Metadata: 0x0062FD4E
		private const int MaxInt32Scale = 9; // Metadata: 0x0062FD52
		private static uint[] Powers10; // 0x00
		// [DecimalConstant] // 0x00000001800DED30-0x00000001800DED60
		public static readonly decimal Zero; // 0x08
		// [DecimalConstant] // 0x00000001800DED60-0x00000001800DED90
		public static readonly decimal One; // 0x18
		// [DecimalConstant] // 0x00000001800DED90-0x00000001800DEDC0
		public static readonly decimal MinusOne; // 0x28
		// [DecimalConstant] // 0x00000001800DEDC0-0x00000001800DEE00
		public static readonly decimal MaxValue; // 0x38
		// [DecimalConstant] // 0x00000001800DEE70-0x00000001800DEEB0
		public static readonly decimal MinValue; // 0x48
		// [DecimalConstant] // 0x00000001800DEEB0-0x00000001800DEEE0
		private static readonly decimal NearNegativeZero; // 0x58
		// [DecimalConstant] // 0x00000001800DEF50-0x00000001800DEF80
		private static readonly decimal NearPositiveZero; // 0x68
		private int flags; // 0x00
		private int hi; // 0x04
		private int lo; // 0x08
		private int mid; // 0x0C
	
		// Constructors
		public Decimal(int value) {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
		} // 0x0000000180039830-0x0000000180039860
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public Decimal(uint value) {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
		} // 0x0000000180039820-0x0000000180039830
		public Decimal(long value) {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
		} // 0x00000001800398B0-0x0000000180039DB0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public Decimal(ulong value) {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
		} // 0x0000000180039800-0x0000000180039820
		public Decimal(float value) {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
		} // 0x00000001800398A0-0x00000001800398B0
		public Decimal(double value) {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
		} // 0x0000000180039860-0x0000000180039870
		public Decimal(int[] bits) {
			flags = default;
			hi = default;
			lo = default;
			mid = default;
		} // 0x00000001800396E0-0x0000000180039800
		public Decimal(int lo, int mid, int hi, bool isNegative, byte scale) {
			flags = default;
			this.hi = default;
			this.lo = default;
			this.mid = default;
		} // 0x0000000180039870-0x0000000180039890
		private Decimal(int lo, int mid, int hi, int flags) {
			this.flags = default;
			this.hi = default;
			this.lo = default;
			this.mid = default;
		} // 0x0000000180039890-0x00000001800398A0
		static Decimal() {
			Powers10 = default;
			Zero = default;
			One = default;
			MinusOne = default;
			MaxValue = default;
			MinValue = default;
			NearNegativeZero = default;
			NearPositiveZero = default;
		} // 0x0000000180915B80-0x0000000180916090
	
		// Methods
		private void SetBits(int[] bits) {} // 0x0000000180039080-0x0000000180039090
		[OnSerializing] // 0x00000001800D4E50-0x00000001800D4E60
		private void OnSerializing(StreamingContext ctx) {} // 0x0000000180039060-0x0000000180039080
		void IDeserializationCallback.OnDeserialization(object sender) {} // 0x0000000180039610-0x0000000180039620
		private static void FCallAddSub(ref decimal d1, ref decimal d2, byte bSign) {} // 0x00000001809147B0-0x00000001809147C0
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		private static int FCallCompare(ref decimal d1, ref decimal d2) => default; // 0x00000001809147C0-0x00000001809147D0
		public int CompareTo(object value) => default; // 0x0000000180038DB0-0x0000000180038EB0
		public int CompareTo(decimal value) => default; // 0x0000000180038EB0-0x0000000180038F10
		private static void FCallDivide(ref decimal d1, ref decimal d2) {} // 0x00000001809147D0-0x00000001809147E0
		public override bool Equals(object value) => default; // 0x0000000180038F80-0x0000000180039040
		public bool Equals(decimal value) => default; // 0x0000000180038F10-0x0000000180038F80
		public override int GetHashCode() => default; // 0x0000000180039040-0x0000000180039050
		public override string ToString() => default; // 0x0000000180039620-0x0000000180039660
		public string ToString(IFormatProvider provider) => default; // 0x0000000180039660-0x00000001800396A0
		public string ToString(string format, IFormatProvider provider) => default; // 0x00000001800396A0-0x00000001800396E0
		public static decimal Parse(string s, IFormatProvider provider) => default; // 0x0000000180914A60-0x0000000180914AB0
		public static decimal Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x0000000180914AB0-0x0000000180914B20
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result) {
			result = default;
			return default;
		} // 0x0000000180915B20-0x0000000180915B80
		public static int[] GetBits(decimal d) => default; // 0x0000000180914830-0x0000000180914920
		internal static decimal ToDecimal(byte[] buffer) => default; // 0x0000000180915050-0x0000000180915330
		private static void FCallMultiply(ref decimal d1, ref decimal d2) {} // 0x00000001809147E0-0x00000001809147F0
		public static decimal Negate(decimal d) => default; // 0x0000000180914920-0x0000000180914A60
		public static decimal Round(decimal d, int decimals) => default; // 0x0000000180914B20-0x0000000180914F40
		private static void FCallRound(ref decimal d, int decimals) {} // 0x00000001809147F0-0x0000000180914800
		public static byte ToByte(decimal value) => default; // 0x0000000180914F40-0x0000000180915050
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(decimal value) => default; // 0x0000000180915630-0x0000000180915740
		public static short ToInt16(decimal value) => default; // 0x0000000180915350-0x0000000180915460
		public static double ToDouble(decimal d) => default; // 0x0000000180915330-0x0000000180915350
		internal static int FCallToInt32(decimal d) => default; // 0x0000000180914800-0x0000000180914820
		public static int ToInt32(decimal d) => default; // 0x0000000180915460-0x0000000180915540
		public static long ToInt64(decimal d) => default; // 0x0000000180915540-0x0000000180915630
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(decimal value) => default; // 0x00000001809157E0-0x00000001809158F0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(decimal d) => default; // 0x00000001809158F0-0x00000001809159D0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(decimal d) => default; // 0x00000001809159D0-0x0000000180915AB0
		public static float ToSingle(decimal d) => default; // 0x0000000180915740-0x00000001809157E0
		public static decimal Truncate(decimal d) => default; // 0x0000000180915AB0-0x0000000180915B20
		private static void FCallTruncate(ref decimal d) {} // 0x0000000180914820-0x0000000180914830
		public static implicit operator decimal(byte value) => default; // 0x0000000180916640-0x0000000180916660
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static implicit operator decimal(sbyte value) => default; // 0x0000000180916690-0x00000001809166C0
		public static implicit operator decimal(short value) => default; // 0x00000001809166C0-0x00000001809166F0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static implicit operator decimal(ushort value) => default; // 0x00000001809166F0-0x0000000180916710
		public static implicit operator decimal(int value) => default; // 0x0000000180916660-0x0000000180916690
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static implicit operator decimal(uint value) => default; // 0x0000000180916610-0x0000000180916620
		public static implicit operator decimal(long value) => default; // 0x0000000180916710-0x0000000180916750
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static implicit operator decimal(ulong value) => default; // 0x0000000180916620-0x0000000180916640
		public static explicit operator decimal(float value) => default; // 0x00000001809161A0-0x00000001809161C0
		public static explicit operator decimal(double value) => default; // 0x0000000180916180-0x00000001809161A0
		public static explicit operator int(decimal value) => default; // 0x00000001809163B0-0x0000000180916410
		public static explicit operator long(decimal value) => default; // 0x0000000180916280-0x00000001809163B0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static explicit operator ulong(decimal value) => default; // 0x0000000180916410-0x0000000180916530
		public static explicit operator float(decimal value) => default; // 0x0000000180916220-0x0000000180916280
		public static explicit operator double(decimal value) => default; // 0x00000001809161C0-0x0000000180916220
		public static decimal operator -(decimal d1, decimal d2) => default; // 0x0000000180916920-0x00000001809169A0
		public static decimal operator *(decimal d1, decimal d2) => default; // 0x00000001809168A0-0x0000000180916920
		public static decimal operator /(decimal d1, decimal d2) => default; // 0x0000000180916090-0x0000000180916110
		public static bool operator ==(decimal d1, decimal d2) => default; // 0x0000000180916110-0x0000000180916180
		public static bool operator !=(decimal d1, decimal d2) => default; // 0x0000000180916750-0x00000001809167C0
		public static bool operator <(decimal d1, decimal d2) => default; // 0x0000000180916830-0x00000001809168A0
		public static bool operator <=(decimal d1, decimal d2) => default; // 0x00000001809167C0-0x0000000180916830
		public static bool operator >(decimal d1, decimal d2) => default; // 0x00000001809165A0-0x0000000180916610
		public static bool operator >=(decimal d1, decimal d2) => default; // 0x0000000180916530-0x00000001809165A0
		public TypeCode GetTypeCode() => default; // 0x0000000180039050-0x0000000180039060
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180039090-0x0000000180039100
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000180039170-0x0000000180039180
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000180039350-0x00000001800393C0
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000180039100-0x0000000180039170
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000180039200-0x0000000180039270
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x00000001800394C0-0x0000000180039530
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180039270-0x00000001800392E0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180039530-0x00000001800395A0
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001800392E0-0x0000000180039350
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x00000001800395A0-0x0000000180039610
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x00000001800393C0-0x0000000180039430
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000180039190-0x0000000180039200
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x000000018000CBC0-0x000000018000CBD0
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180039180-0x0000000180039190
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x0000000180039430-0x00000001800394C0
	}
}
