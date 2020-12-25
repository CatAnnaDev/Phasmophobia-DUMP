/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	// [CLSCompliant] // 0x00000001800E0050-0x00000001800E0090
	// [ComVisible] // 0x00000001800E0050-0x00000001800E0090
	public interface IConvertible // TypeDefIndex: 240
	{
		// Methods
		TypeCode GetTypeCode();
		bool ToBoolean(IFormatProvider provider);
		char ToChar(IFormatProvider provider);
		sbyte ToSByte(IFormatProvider provider);
		byte ToByte(IFormatProvider provider);
		short ToInt16(IFormatProvider provider);
		ushort ToUInt16(IFormatProvider provider);
		int ToInt32(IFormatProvider provider);
		uint ToUInt32(IFormatProvider provider);
		long ToInt64(IFormatProvider provider);
		ulong ToUInt64(IFormatProvider provider);
		float ToSingle(IFormatProvider provider);
		double ToDouble(IFormatProvider provider);
		decimal ToDecimal(IFormatProvider provider);
		DateTime ToDateTime(IFormatProvider provider);
		string ToString(IFormatProvider provider);
		object ToType(Type conversionType, IFormatProvider provider);
	}
}
