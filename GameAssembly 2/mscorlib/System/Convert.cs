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
	public static class Convert // TypeDefIndex: 186
	{
		// Fields
		internal static readonly RuntimeType[] ConvertTypes; // 0x00
		private static readonly RuntimeType EnumType; // 0x08
		internal static readonly char[] base64Table; // 0x10
		public static readonly object DBNull; // 0x18
	
		// Constructors
		static Convert() {} // 0x0000000180819B30-0x000000018081B0B0
	
		// Methods
		public static TypeCode GetTypeCode(object value) => default; // 0x0000000180813E10-0x0000000180813E80
		public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) => default; // 0x00000001808110B0-0x0000000180811510
		internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) => default; // 0x0000000180812620-0x0000000180813600
		public static object ChangeType(object value, Type conversionType) => default; // 0x00000001808122F0-0x0000000180812380
		public static object ChangeType(object value, Type conversionType, IFormatProvider provider) => default; // 0x0000000180811510-0x00000001808122F0
		public static bool ToBoolean(object value) => default; // 0x00000001808148D0-0x0000000180814970
		public static bool ToBoolean(object value, IFormatProvider provider) => default; // 0x0000000180814820-0x00000001808148D0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static bool ToBoolean(sbyte value) => default; // 0x00000001808149D0-0x00000001808149E0
		public static bool ToBoolean(byte value) => default; // 0x00000001808149D0-0x00000001808149E0
		public static bool ToBoolean(short value) => default; // 0x0000000180814760-0x0000000180814770
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static bool ToBoolean(ushort value) => default; // 0x0000000180814760-0x0000000180814770
		public static bool ToBoolean(int value) => default; // 0x000000018068E6C0-0x000000018068E6D0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static bool ToBoolean(uint value) => default; // 0x000000018068E6C0-0x000000018068E6D0
		public static bool ToBoolean(long value) => default; // 0x0000000180814810-0x0000000180814820
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static bool ToBoolean(ulong value) => default; // 0x0000000180814810-0x0000000180814820
		public static bool ToBoolean(string value) => default; // 0x00000001808149E0-0x0000000180814A40
		public static bool ToBoolean(string value, IFormatProvider provider) => default; // 0x0000000180814970-0x00000001808149D0
		public static bool ToBoolean(float value) => default; // 0x0000000180814A40-0x0000000180814A50
		public static bool ToBoolean(double value) => default; // 0x0000000180814770-0x0000000180814790
		public static bool ToBoolean(decimal value) => default; // 0x0000000180814790-0x0000000180814810
		public static char ToChar(object value) => default; // 0x0000000180815380-0x0000000180815420
		public static char ToChar(object value, IFormatProvider provider) => default; // 0x0000000180815620-0x00000001808156D0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static char ToChar(sbyte value) => default; // 0x00000001808154A0-0x0000000180815520
		public static char ToChar(byte value) => default; // 0x0000000180815370-0x0000000180815380
		public static char ToChar(short value) => default; // 0x00000001808156D0-0x0000000180815750
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static char ToChar(ushort value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		public static char ToChar(int value) => default; // 0x0000000180815520-0x00000001808155A0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static char ToChar(uint value) => default; // 0x0000000180815420-0x00000001808154A0
		public static char ToChar(long value) => default; // 0x00000001808155A0-0x0000000180815620
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static char ToChar(ulong value) => default; // 0x0000000180815810-0x0000000180815890
		public static char ToChar(string value) => default; // 0x0000000180815890-0x0000000180815990
		public static char ToChar(string value, IFormatProvider provider) => default; // 0x0000000180815750-0x0000000180815810
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(object value) => default; // 0x0000000180817B50-0x0000000180817BF0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(object value, IFormatProvider provider) => default; // 0x0000000180817940-0x00000001808179F0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(bool value) => default; // 0x00000001808149D0-0x00000001808149E0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(char value) => default; // 0x0000000180817830-0x00000001808178B0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(byte value) => default; // 0x0000000180817D70-0x0000000180817DF0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(short value) => default; // 0x0000000180817E80-0x0000000180817F10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(ushort value) => default; // 0x0000000180817BF0-0x0000000180817C70
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(int value) => default; // 0x0000000180817CF0-0x0000000180817D70
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(uint value) => default; // 0x0000000180817AD0-0x0000000180817B50
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(long value) => default; // 0x00000001808178B0-0x0000000180817940
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(ulong value) => default; // 0x0000000180817C70-0x0000000180817CF0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(float value) => default; // 0x0000000180817F10-0x0000000180818030
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(double value) => default; // 0x00000001808179F0-0x0000000180817AD0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(decimal value) => default; // 0x0000000180817DF0-0x0000000180817E70
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(string value, IFormatProvider provider) => default; // 0x0000000180817E70-0x0000000180817E80
		public static byte ToByte(object value) => default; // 0x0000000180814A50-0x0000000180814AF0
		public static byte ToByte(object value, IFormatProvider provider) => default; // 0x0000000180814DD0-0x0000000180814E80
		public static byte ToByte(bool value) => default; // 0x00000001808149D0-0x00000001808149E0
		public static byte ToByte(char value) => default; // 0x0000000180815280-0x0000000180815300
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static byte ToByte(sbyte value) => default; // 0x0000000180814E80-0x0000000180814F00
		public static byte ToByte(short value) => default; // 0x0000000180814AF0-0x0000000180814B70
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static byte ToByte(ushort value) => default; // 0x0000000180814B70-0x0000000180814BF0
		public static byte ToByte(int value) => default; // 0x00000001808151E0-0x0000000180815260
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static byte ToByte(uint value) => default; // 0x0000000180814BF0-0x0000000180814C70
		public static byte ToByte(long value) => default; // 0x0000000180814C70-0x0000000180814CF0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static byte ToByte(ulong value) => default; // 0x0000000180815050-0x00000001808150D0
		public static byte ToByte(float value) => default; // 0x00000001808150D0-0x00000001808151E0
		public static byte ToByte(double value) => default; // 0x0000000180814F00-0x0000000180814FD0
		public static byte ToByte(decimal value) => default; // 0x0000000180814FD0-0x0000000180815050
		public static byte ToByte(string value) => default; // 0x0000000180815300-0x0000000180815370
		public static byte ToByte(string value, IFormatProvider provider) => default; // 0x0000000180815260-0x0000000180815280
		public static short ToInt16(object value) => default; // 0x0000000180816B90-0x0000000180816C30
		public static short ToInt16(object value, IFormatProvider provider) => default; // 0x00000001808167E0-0x0000000180816890
		public static short ToInt16(bool value) => default; // 0x0000000180816B00-0x0000000180816B10
		public static short ToInt16(char value) => default; // 0x0000000180816890-0x0000000180816910
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static short ToInt16(sbyte value) => default; // 0x0000000180816630-0x0000000180816640
		public static short ToInt16(byte value) => default; // 0x0000000180815370-0x0000000180815380
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static short ToInt16(ushort value) => default; // 0x0000000180816640-0x00000001808166C0
		public static short ToInt16(int value) => default; // 0x0000000180816420-0x00000001808164A0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static short ToInt16(uint value) => default; // 0x0000000180816B10-0x0000000180816B90
		public static short ToInt16(long value) => default; // 0x0000000180816580-0x0000000180816610
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static short ToInt16(ulong value) => default; // 0x0000000180816990-0x0000000180816A10
		public static short ToInt16(float value) => default; // 0x00000001808166C0-0x00000001808167E0
		public static short ToInt16(double value) => default; // 0x00000001808164A0-0x0000000180816580
		public static short ToInt16(decimal value) => default; // 0x0000000180816910-0x0000000180816990
		public static short ToInt16(string value, IFormatProvider provider) => default; // 0x0000000180816610-0x0000000180816630
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(object value) => default; // 0x0000000180818D60-0x0000000180818E00
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(object value, IFormatProvider provider) => default; // 0x0000000180818A80-0x0000000180818B30
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(bool value) => default; // 0x0000000180816B00-0x0000000180816B10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(char value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(sbyte value) => default; // 0x0000000180818860-0x00000001808188E0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(byte value) => default; // 0x0000000180815370-0x0000000180815380
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(short value) => default; // 0x00000001808188E0-0x0000000180818960
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(int value) => default; // 0x0000000180818960-0x00000001808189E0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(uint value) => default; // 0x00000001808187E0-0x0000000180818860
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(long value) => default; // 0x00000001808189E0-0x0000000180818A60
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(ulong value) => default; // 0x0000000180818C00-0x0000000180818C80
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(float value) => default; // 0x00000001808186D0-0x00000001808187E0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(double value) => default; // 0x0000000180818B30-0x0000000180818C00
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(decimal value) => default; // 0x0000000180818650-0x00000001808186D0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(string value, IFormatProvider provider) => default; // 0x0000000180818A60-0x0000000180818A80
		public static int ToInt32(object value) => default; // 0x0000000180817180-0x0000000180817220
		public static int ToInt32(object value, IFormatProvider provider) => default; // 0x0000000180816EB0-0x0000000180816F60
		public static int ToInt32(bool value) => default; // 0x000000018068E6D0-0x000000018068E6E0
		public static int ToInt32(char value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static int ToInt32(sbyte value) => default; // 0x0000000180816630-0x0000000180816640
		public static int ToInt32(byte value) => default; // 0x0000000180815370-0x0000000180815380
		public static int ToInt32(short value) => default; // 0x0000000180817150-0x0000000180817160
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static int ToInt32(ushort value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static int ToInt32(uint value) => default; // 0x0000000180817070-0x00000001808170F0
		public static int ToInt32(long value) => default; // 0x0000000180816E20-0x0000000180816EB0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static int ToInt32(ulong value) => default; // 0x0000000180816DA0-0x0000000180816E20
		public static int ToInt32(float value) => default; // 0x00000001808170F0-0x0000000180817150
		public static int ToInt32(double value) => default; // 0x0000000180816C30-0x0000000180816D40
		public static int ToInt32(decimal value) => default; // 0x0000000180816D40-0x0000000180816DA0
		public static int ToInt32(string value) => default; // 0x0000000180817000-0x0000000180817070
		public static int ToInt32(string value, IFormatProvider provider) => default; // 0x0000000180817160-0x0000000180817180
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(object value) => default; // 0x0000000180818F20-0x0000000180818FC0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(object value, IFormatProvider provider) => default; // 0x0000000180819140-0x00000001808191F0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(bool value) => default; // 0x000000018068E6D0-0x000000018068E6E0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(char value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(sbyte value) => default; // 0x0000000180818FC0-0x0000000180819040
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(byte value) => default; // 0x0000000180815370-0x0000000180815380
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(short value) => default; // 0x00000001808192C0-0x0000000180819340
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(ushort value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(int value) => default; // 0x00000001808190C0-0x0000000180819140
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(long value) => default; // 0x0000000180819360-0x00000001808193E0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(ulong value) => default; // 0x0000000180819040-0x00000001808190C0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(float value) => default; // 0x00000001808193E0-0x00000001808194F0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(double value) => default; // 0x00000001808191F0-0x00000001808192C0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(decimal value) => default; // 0x0000000180818E00-0x0000000180818E80
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(string value, IFormatProvider provider) => default; // 0x0000000180819340-0x0000000180819360
		public static long ToInt64(object value) => default; // 0x00000001808172E0-0x0000000180817380
		public static long ToInt64(object value, IFormatProvider provider) => default; // 0x0000000180817670-0x0000000180817720
		public static long ToInt64(bool value) => default; // 0x0000000180817720-0x0000000180817730
		public static long ToInt64(char value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static long ToInt64(sbyte value) => default; // 0x0000000180817730-0x0000000180817740
		public static long ToInt64(byte value) => default; // 0x0000000180815370-0x0000000180815380
		public static long ToInt64(short value) => default; // 0x0000000180817220-0x0000000180817230
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static long ToInt64(ushort value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		public static long ToInt64(int value) => default; // 0x00000001806304D0-0x00000001806304E0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static long ToInt64(uint value) => default; // 0x0000000180322710-0x00000001803232A0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static long ToInt64(ulong value) => default; // 0x0000000180817230-0x00000001808172C0
		public static long ToInt64(float value) => default; // 0x0000000180817490-0x0000000180817560
		public static long ToInt64(double value) => default; // 0x0000000180817380-0x0000000180817410
		public static long ToInt64(decimal value) => default; // 0x0000000180817410-0x0000000180817490
		public static long ToInt64(string value) => default; // 0x0000000180817600-0x0000000180817670
		public static long ToInt64(string value, IFormatProvider provider) => default; // 0x00000001808172C0-0x00000001808172E0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(object value) => default; // 0x0000000180819A90-0x0000000180819B30
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(object value, IFormatProvider provider) => default; // 0x0000000180819870-0x0000000180819920
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(bool value) => default; // 0x000000018068E6D0-0x000000018068E6E0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(char value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(sbyte value) => default; // 0x00000001808194F0-0x0000000180819570
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(byte value) => default; // 0x0000000180815370-0x0000000180815380
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(short value) => default; // 0x0000000180819730-0x00000001808197B0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(ushort value) => default; // 0x00000001803A5E00-0x00000001803A5E10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(int value) => default; // 0x0000000180819570-0x00000001808195F0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(uint value) => default; // 0x0000000180322710-0x00000001803232A0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(long value) => default; // 0x0000000180819A10-0x0000000180819A90
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(float value) => default; // 0x0000000180819920-0x0000000180819A10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(double value) => default; // 0x00000001808197B0-0x0000000180819870
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(decimal value) => default; // 0x00000001808195F0-0x0000000180819670
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(string value, IFormatProvider provider) => default; // 0x0000000180819670-0x0000000180819690
		public static float ToSingle(object value) => default; // 0x00000001808180B0-0x0000000180818150
		public static float ToSingle(object value, IFormatProvider provider) => default; // 0x0000000180818240-0x00000001808182F0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static float ToSingle(sbyte value) => default; // 0x00000001808181A0-0x00000001808181B0
		public static float ToSingle(byte value) => default; // 0x0000000180818030-0x0000000180818040
		public static float ToSingle(short value) => default; // 0x0000000180818160-0x0000000180818170
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static float ToSingle(ushort value) => default; // 0x0000000180818310-0x0000000180818320
		public static float ToSingle(int value) => default; // 0x0000000180818170-0x0000000180818180
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static float ToSingle(uint value) => default; // 0x00000001808181B0-0x00000001808181C0
		public static float ToSingle(long value) => default; // 0x0000000180818150-0x0000000180818160
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static float ToSingle(ulong value) => default; // 0x00000001808182F0-0x0000000180818310
		public static float ToSingle(float value) => default; // 0x0000000180246DB0-0x0000000180246DC0
		public static float ToSingle(double value) => default; // 0x0000000180818230-0x0000000180818240
		public static float ToSingle(decimal value) => default; // 0x00000001808181D0-0x0000000180818230
		public static float ToSingle(string value) => default; // 0x0000000180818040-0x00000001808180B0
		public static float ToSingle(string value, IFormatProvider provider) => default; // 0x0000000180818180-0x00000001808181A0
		public static float ToSingle(bool value) => default; // 0x00000001808181C0-0x00000001808181D0
		public static double ToDouble(object value) => default; // 0x00000001808162F0-0x0000000180816390
		public static double ToDouble(object value, IFormatProvider provider) => default; // 0x0000000180816140-0x00000001808161F0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static double ToDouble(sbyte value) => default; // 0x0000000180816210-0x0000000180816220
		public static double ToDouble(byte value) => default; // 0x0000000180816410-0x0000000180816420
		public static double ToDouble(short value) => default; // 0x00000001808162D0-0x00000001808162E0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static double ToDouble(ushort value) => default; // 0x0000000180816220-0x0000000180816230
		public static double ToDouble(int value) => default; // 0x0000000180816390-0x00000001808163A0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static double ToDouble(uint value) => default; // 0x00000001808162E0-0x00000001808162F0
		public static double ToDouble(long value) => default; // 0x0000000180816230-0x0000000180816240
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static double ToDouble(ulong value) => default; // 0x00000001808161F0-0x0000000180816210
		public static double ToDouble(float value) => default; // 0x0000000180816240-0x0000000180816250
		public static double ToDouble(decimal value) => default; // 0x00000001808163A0-0x0000000180816400
		public static double ToDouble(string value, IFormatProvider provider) => default; // 0x0000000180816250-0x00000001808162D0
		public static double ToDouble(bool value) => default; // 0x0000000180816400-0x0000000180816410
		public static decimal ToDecimal(object value, IFormatProvider provider) => default; // 0x0000000180815D90-0x0000000180815F10
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static decimal ToDecimal(sbyte value) => default; // 0x0000000180815B70-0x0000000180815BE0
		public static decimal ToDecimal(byte value) => default; // 0x0000000180815A90-0x0000000180815B00
		public static decimal ToDecimal(short value) => default; // 0x0000000180815F10-0x0000000180815F80
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static decimal ToDecimal(ushort value) => default; // 0x00000001808160D0-0x0000000180816140
		public static decimal ToDecimal(int value) => default; // 0x0000000180815BE0-0x0000000180815C50
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static decimal ToDecimal(uint value) => default; // 0x0000000180815B00-0x0000000180815B70
		public static decimal ToDecimal(long value) => default; // 0x0000000180815F80-0x0000000180815FF0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static decimal ToDecimal(ulong value) => default; // 0x0000000180815D20-0x0000000180815D90
		public static decimal ToDecimal(float value) => default; // 0x0000000180815A20-0x0000000180815A90
		public static decimal ToDecimal(double value) => default; // 0x0000000180816060-0x00000001808160D0
		public static decimal ToDecimal(string value, IFormatProvider provider) => default; // 0x0000000180815C50-0x0000000180815D20
		public static decimal ToDecimal(bool value) => default; // 0x0000000180815FF0-0x0000000180816060
		public static DateTime ToDateTime(string value, IFormatProvider provider) => default; // 0x0000000180815990-0x0000000180815A20
		public static string ToString(object value, IFormatProvider provider) => default; // 0x0000000180818360-0x00000001808184B0
		public static string ToString(char value) => default; // 0x00000001808184D0-0x0000000180818530
		public static string ToString(char value, IFormatProvider provider) => default; // 0x00000001808184B0-0x00000001808184D0
		public static string ToString(int value, IFormatProvider provider) => default; // 0x0000000180818340-0x0000000180818360
		public static string ToString(long value, IFormatProvider provider) => default; // 0x0000000180818590-0x00000001808185B0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static string ToString(ulong value, IFormatProvider provider) => default; // 0x0000000180818550-0x0000000180818570
		public static string ToString(double value, IFormatProvider provider) => default; // 0x0000000180818320-0x0000000180818340
		public static string ToString(decimal value, IFormatProvider provider) => default; // 0x0000000180818570-0x0000000180818590
		public static string ToString(DateTime value, IFormatProvider provider) => default; // 0x0000000180818530-0x0000000180818550
		public static byte ToByte(string value, int fromBase) => default; // 0x0000000180814CF0-0x0000000180814DD0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static sbyte ToSByte(string value, int fromBase) => default; // 0x0000000180817740-0x0000000180817830
		public static short ToInt16(string value, int fromBase) => default; // 0x0000000180816A10-0x0000000180816B00
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ushort ToUInt16(string value, int fromBase) => default; // 0x0000000180818C80-0x0000000180818D60
		public static int ToInt32(string value, int fromBase) => default; // 0x0000000180816F60-0x0000000180817000
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static uint ToUInt32(string value, int fromBase) => default; // 0x0000000180818E80-0x0000000180818F20
		public static long ToInt64(string value, int fromBase) => default; // 0x0000000180817560-0x0000000180817600
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static ulong ToUInt64(string value, int fromBase) => default; // 0x0000000180819690-0x0000000180819730
		public static string ToString(int value, int toBase) => default; // 0x00000001808185B0-0x0000000180818650
		public static string ToBase64String(byte[] inArray) => default; // 0x00000001808145D0-0x0000000180814670
		// [ComVisible] // 0x00000001800DEBC0-0x00000001800DEBE0
		public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) => default; // 0x00000001808142E0-0x00000001808145D0
		public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) => default; // 0x0000000180813E80-0x0000000180813F10
		// [ComVisible] // 0x00000001800DEBC0-0x00000001800DEBE0
		public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options) => default; // 0x0000000180813F10-0x00000001808142E0
		private static unsafe int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) => default; // 0x0000000180812380-0x0000000180812620
		private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) => default; // 0x0000000180814670-0x0000000180814760
		public static byte[] FromBase64String(string s) => default; // 0x0000000180813980-0x0000000180813A30
		public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) => default; // 0x0000000180813600-0x00000001808137A0
		private static unsafe byte[] FromBase64CharPtr(char* inputPtr, int inputLength) => default; // 0x00000001808137A0-0x0000000180813980
		private static unsafe int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) => default; // 0x0000000180813B10-0x0000000180813E10
		private static unsafe int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) => default; // 0x0000000180813A30-0x0000000180813B10
	}
}
