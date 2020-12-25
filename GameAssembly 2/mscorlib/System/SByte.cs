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
	// [CLSCompliant] // 0x00000001800E18D0-0x00000001800E1910
	// [ComVisible] // 0x00000001800E18D0-0x00000001800E1910
	public struct SByte : IComparable, IFormattable, IConvertible, IComparable<sbyte>, IEquatable<sbyte> // TypeDefIndex: 287
	{
		// Fields
		private sbyte m_value; // 0x00
		public const sbyte MaxValue = 127; // Metadata: 0x006300A0
		public const sbyte MinValue = 128; // Metadata: 0x006300A1
	
		// Methods
		public int CompareTo(object obj) => default; // 0x0000000180013120-0x00000001800131F0
		public int CompareTo(sbyte value) => default; // 0x0000000180013110-0x0000000180013120
		public override bool Equals(object obj) => default; // 0x00000001800131F0-0x0000000180013280
		public bool Equals(sbyte obj) => default; // 0x0000000180013280-0x0000000180013290
		public override int GetHashCode() => default; // 0x0000000180013290-0x00000001800132A0
		public override string ToString() => default; // 0x0000000180013830-0x0000000180013860
		public string ToString(IFormatProvider provider) => default; // 0x00000001800137C0-0x00000001800137F0
		public string ToString(string format, IFormatProvider provider) => default; // 0x00000001800137F0-0x0000000180013830
		private string ToString(string format, NumberFormatInfo info) => default; // 0x00000001800137B0-0x00000001800137C0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte Parse(string s, IFormatProvider provider) => default; // 0x0000000180447AE0-0x0000000180447B10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) => default; // 0x0000000180447A90-0x0000000180447AE0
		private static sbyte Parse(string s, NumberStyles style, NumberFormatInfo info) => default; // 0x0000000180447B10-0x0000000180447E40
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) {
			result = default;
			return default;
		} // 0x0000000180447EC0-0x0000000180447F60
		private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out sbyte result) {
			result = default;
			return default;
		} // 0x0000000180447E40-0x0000000180447EC0
		public TypeCode GetTypeCode() => default; // 0x00000001800132A0-0x00000001800132B0
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x00000001800132B0-0x0000000180013310
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000180013370-0x00000001800133D0
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x0000000180013590-0x00000001800135A0
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000180013310-0x0000000180013370
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x00000001800134C0-0x0000000180013520
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180013690-0x00000001800136F0
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x0000000180013520-0x0000000180013530
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x00000001800136F0-0x0000000180013750
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x0000000180013530-0x0000000180013590
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000180013750-0x00000001800137B0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x00000001800135A0-0x0000000180013600
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000180013460-0x00000001800134C0
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x00000001800133E0-0x0000000180013460
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x00000001800133D0-0x00000001800133E0
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x0000000180013600-0x0000000180013690
	}
}
