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
using System.Runtime.Serialization;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	public struct DateTime : IComparable, IFormattable, IConvertible, ISerializable, IComparable<System.DateTime>, IEquatable<System.DateTime> // TypeDefIndex: 187
	{
		// Fields
		private const long TicksPerMillisecond = 10000; // Metadata: 0x0062FC1B
		private const long TicksPerSecond = 10000000; // Metadata: 0x0062FC23
		private const long TicksPerMinute = 600000000; // Metadata: 0x0062FC2B
		private const long TicksPerHour = 36000000000; // Metadata: 0x0062FC33
		private const long TicksPerDay = 864000000000; // Metadata: 0x0062FC3B
		private const int MillisPerSecond = 1000; // Metadata: 0x0062FC43
		private const int MillisPerMinute = 60000; // Metadata: 0x0062FC47
		private const int MillisPerHour = 3600000; // Metadata: 0x0062FC4B
		private const int MillisPerDay = 86400000; // Metadata: 0x0062FC4F
		private const int DaysPerYear = 365; // Metadata: 0x0062FC53
		private const int DaysPer4Years = 1461; // Metadata: 0x0062FC57
		private const int DaysPer100Years = 36524; // Metadata: 0x0062FC5B
		private const int DaysPer400Years = 146097; // Metadata: 0x0062FC5F
		private const int DaysTo1601 = 584388; // Metadata: 0x0062FC63
		private const int DaysTo1899 = 693593; // Metadata: 0x0062FC67
		internal const int DaysTo1970 = 719162; // Metadata: 0x0062FC6B
		private const int DaysTo10000 = 3652059; // Metadata: 0x0062FC6F
		internal const long MinTicks = 0; // Metadata: 0x0062FC73
		internal const long MaxTicks = 3155378975999999999; // Metadata: 0x0062FC7B
		private const long MaxMillis = 315537897600000; // Metadata: 0x0062FC83
		private const long FileTimeOffset = 504911232000000000; // Metadata: 0x0062FC8B
		private const long DoubleDateOffset = 599264352000000000; // Metadata: 0x0062FC93
		private const long OADateMinAsTicks = 31241376000000000; // Metadata: 0x0062FC9B
		private const double OADateMinAsDouble = -657435; // Metadata: 0x0062FCA3
		private const double OADateMaxAsDouble = 2958466; // Metadata: 0x0062FCAB
		private const int DatePartYear = 0; // Metadata: 0x0062FCB3
		private const int DatePartDayOfYear = 1; // Metadata: 0x0062FCB7
		private const int DatePartMonth = 2; // Metadata: 0x0062FCBB
		private const int DatePartDay = 3; // Metadata: 0x0062FCBF
		private static readonly int[] DaysToMonth365; // 0x00
		private static readonly int[] DaysToMonth366; // 0x08
		public static readonly DateTime MinValue; // 0x10
		public static readonly DateTime MaxValue; // 0x18
		private const ulong TicksMask = 4611686018427387903; // Metadata: 0x0062FCC3
		private const ulong FlagsMask = 13835058055282163712; // Metadata: 0x0062FCCB
		private const ulong LocalMask = 9223372036854775808; // Metadata: 0x0062FCD3
		private const long TicksCeiling = 4611686018427387904; // Metadata: 0x0062FCDB
		private const ulong KindUnspecified = 0; // Metadata: 0x0062FCE3
		private const ulong KindUtc = 4611686018427387904; // Metadata: 0x0062FCEB
		private const ulong KindLocal = 9223372036854775808; // Metadata: 0x0062FCF3
		private const ulong KindLocalAmbiguousDst = 13835058055282163712; // Metadata: 0x0062FCFB
		private const int KindShift = 62; // Metadata: 0x0062FD03
		private const string TicksField = "ticks"; // Metadata: 0x0062FD07
		private const string DateDataField = "dateData"; // Metadata: 0x0062FD10
		private ulong dateData; // 0x00
	
		// Properties
		internal long InternalTicks { get => default; } // 0x0000000180038C20-0x0000000180038C40 
		private ulong InternalKind { get => default; } // 0x0000000180038C00-0x0000000180038C20 
		public DateTime Date { get => default; } // 0x0000000180038B10-0x0000000180038B50 
		public int Day { get => default; } // 0x0000000180038BA0-0x0000000180038BB0 
		public DayOfWeek DayOfWeek { get => default; } // 0x0000000180038B50-0x0000000180038BA0 
		public int Hour { get => default; } // 0x0000000180038BB0-0x0000000180038C00 
		public DateTimeKind Kind { get => default; } // 0x0000000180038C40-0x0000000180038C70 
		public int Millisecond { get => default; } // 0x0000000180038C70-0x0000000180038CC0 
		public int Minute { get => default; } // 0x0000000180038CC0-0x0000000180038D10 
		public int Month { get => default; } // 0x0000000180038D10-0x0000000180038D20 
		public static DateTime Now { get => default; } // 0x0000000180913FB0-0x0000000180914240 
		public static DateTime UtcNow { get => default; } // 0x0000000180914240-0x00000001809142C0 
		public int Second { get => default; } // 0x0000000180038D20-0x0000000180038D70 
		public long Ticks { get => default; } // 0x0000000180038C20-0x0000000180038C40 
		public TimeSpan TimeOfDay { get => default; } // 0x0000000180038D70-0x0000000180038DA0 
		public int Year { get => default; } // 0x0000000180038DA0-0x0000000180038DB0 
	
		// Constructors
		public DateTime(long ticks) : this() {
			dateData = default;
		} // 0x00000001800388A0-0x00000001800388B0
		private DateTime(ulong dateData) : this() {
			this.dateData = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		public DateTime(long ticks, DateTimeKind kind) : this() {
			dateData = default;
		} // 0x00000001800388D0-0x00000001800388E0
		internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst) : this() {
			dateData = default;
		} // 0x0000000180038960-0x0000000180038970
		public DateTime(int year, int month, int day) : this() {
			dateData = default;
		} // 0x0000000180038A90-0x0000000180038B10
		public DateTime(int year, int month, int day, Calendar calendar) : this() {
			dateData = default;
		} // 0x0000000180038900-0x0000000180038940
		public DateTime(int year, int month, int day, int hour, int minute, int second) : this() {
			dateData = default;
		} // 0x0000000180038940-0x0000000180038950
		public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) : this() {
			dateData = default;
		} // 0x0000000180038980-0x0000000180038A80
		public DateTime(int year, int month, int day, int hour, int minute, int second, Calendar calendar) : this() {
			dateData = default;
		} // 0x00000001800388B0-0x00000001800388C0
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) : this() {
			dateData = default;
		} // 0x0000000180038950-0x0000000180038960
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) : this() {
			dateData = default;
		} // 0x0000000180038A80-0x0000000180038A90
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar) : this() {
			dateData = default;
		} // 0x0000000180038970-0x0000000180038980
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, DateTimeKind kind) : this() {
			dateData = default;
		} // 0x00000001800388C0-0x00000001800388D0
		private DateTime(SerializationInfo info, StreamingContext context) : this() {
			dateData = default;
		} // 0x00000001800388E0-0x0000000180038900
		static DateTime() {
			DaysToMonth365 = default;
			DaysToMonth366 = default;
			MinValue = default;
			MaxValue = default;
		} // 0x0000000180912BC0-0x0000000180913FB0
	
		// Methods
		public DateTime Add(TimeSpan value) => default; // 0x0000000180038110-0x0000000180038120
		private DateTime Add(double value, int scale) => default; // 0x0000000180038120-0x0000000180038130
		public DateTime AddDays(double value) => default; // 0x0000000180038000-0x0000000180038020
		public DateTime AddMilliseconds(double value) => default; // 0x0000000180038020-0x0000000180038030
		public DateTime AddMonths(int months) => default; // 0x0000000180038030-0x0000000180038040
		public DateTime AddSeconds(double value) => default; // 0x0000000180038040-0x0000000180038060
		public DateTime AddTicks(long value) => default; // 0x0000000180038060-0x0000000180038070
		public DateTime AddYears(int value) => default; // 0x0000000180038070-0x0000000180038110
		public int CompareTo(object value) => default; // 0x0000000180038160-0x0000000180038240
		public int CompareTo(DateTime value) => default; // 0x0000000180038130-0x0000000180038160
		private static long DateToTicks(int year, int month, int day) => default; // 0x00000001809106F0-0x00000001809108E0
		private static long TimeToTicks(int hour, int minute, int second) => default; // 0x0000000180912240-0x00000001809127E0
		public static int DaysInMonth(int year, int month) => default; // 0x00000001809108E0-0x0000000180910B00
		public override bool Equals(object value) => default; // 0x0000000180038260-0x00000001800382F0
		public bool Equals(DateTime value) => default; // 0x0000000180038240-0x0000000180038260
		public static DateTime FromBinary(long dateData) => default; // 0x0000000180910BA0-0x0000000180910E10
		internal static DateTime FromBinaryRaw(long dateData) => default; // 0x0000000180910B00-0x0000000180910BA0
		public static DateTime FromFileTime(long fileTime) => default; // 0x0000000180910ED0-0x00000001809111F0
		public static DateTime FromFileTimeUtc(long fileTime) => default; // 0x0000000180910E10-0x0000000180910ED0
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001800384A0-0x0000000180038550
		public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) => default; // 0x0000000180911770-0x0000000180912240
		internal long ToBinaryRaw() => default; // 0x0000000180002410-0x0000000180002420
		private int GetDatePart(int part) => default; // 0x00000001800382F0-0x0000000180038300
		public override int GetHashCode() => default; // 0x0000000180038300-0x0000000180038320
		internal static long GetSystemTimeAsFileTime() => default; // 0x00000001809111F0-0x0000000180911200
		public static bool IsLeapYear(int year) => default; // 0x0000000180911200-0x00000001809112E0
		public static DateTime Parse(string s, IFormatProvider provider) => default; // 0x0000000180911600-0x0000000180911770
		public static DateTime ParseExact(string s, string format, IFormatProvider provider) => default; // 0x00000001809112E0-0x0000000180911390
		public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) => default; // 0x0000000180911530-0x0000000180911600
		public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style) => default; // 0x0000000180911390-0x0000000180911530
		public long ToFileTimeUtc() => default; // 0x0000000180038550-0x0000000180038600
		public DateTime ToLocalTime() => default; // 0x0000000180038600-0x0000000180038610
		internal DateTime ToLocalTime(bool throwOnOverflow) => default; // 0x0000000180038610-0x0000000180038620
		public override string ToString() => default; // 0x0000000180038800-0x0000000180038890
		public string ToString(string format) => default; // 0x0000000180038620-0x00000001800386C0
		public string ToString(IFormatProvider provider) => default; // 0x00000001800386C0-0x0000000180038760
		public string ToString(string format, IFormatProvider provider) => default; // 0x0000000180038760-0x0000000180038800
		public DateTime ToUniversalTime() => default; // 0x0000000180038890-0x00000001800388A0
		public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) {
			result = default;
			return default;
		} // 0x0000000180912A30-0x0000000180912BC0
		public static DateTime operator +(DateTime d, TimeSpan t) => default; // 0x00000001809142C0-0x0000000180914380
		public static DateTime operator -(DateTime d, TimeSpan t) => default; // 0x0000000180914440-0x0000000180914500
		public static TimeSpan operator -(DateTime d1, DateTime d2) => default; // 0x0000000180914500-0x00000001809147B0
		public static bool operator ==(DateTime d1, DateTime d2) => default; // 0x0000000180914380-0x00000001809143A0
		public static bool operator !=(DateTime d1, DateTime d2) => default; // 0x00000001809143E0-0x0000000180914400
		public static bool operator <(DateTime t1, DateTime t2) => default; // 0x0000000180914420-0x0000000180914440
		public static bool operator <=(DateTime t1, DateTime t2) => default; // 0x0000000180914400-0x0000000180914420
		public static bool operator >(DateTime t1, DateTime t2) => default; // 0x00000001809143C0-0x00000001809143E0
		public static bool operator >=(DateTime t1, DateTime t2) => default; // 0x00000001809143A0-0x00000001809143C0
		public TypeCode GetTypeCode() => default; // 0x0000000180038320-0x0000000180038330
		bool IConvertible.ToBoolean(IFormatProvider provider) => default; // 0x0000000180038330-0x0000000180038340
		char IConvertible.ToChar(IFormatProvider provider) => default; // 0x0000000180038350-0x0000000180038360
		sbyte IConvertible.ToSByte(IFormatProvider provider) => default; // 0x00000001800383C0-0x00000001800383D0
		byte IConvertible.ToByte(IFormatProvider provider) => default; // 0x0000000180038340-0x0000000180038350
		short IConvertible.ToInt16(IFormatProvider provider) => default; // 0x0000000180038390-0x00000001800383A0
		ushort IConvertible.ToUInt16(IFormatProvider provider) => default; // 0x0000000180038470-0x0000000180038480
		int IConvertible.ToInt32(IFormatProvider provider) => default; // 0x00000001800383A0-0x00000001800383B0
		uint IConvertible.ToUInt32(IFormatProvider provider) => default; // 0x0000000180038480-0x0000000180038490
		long IConvertible.ToInt64(IFormatProvider provider) => default; // 0x00000001800383B0-0x00000001800383C0
		ulong IConvertible.ToUInt64(IFormatProvider provider) => default; // 0x0000000180038490-0x00000001800384A0
		float IConvertible.ToSingle(IFormatProvider provider) => default; // 0x00000001800383D0-0x00000001800383E0
		double IConvertible.ToDouble(IFormatProvider provider) => default; // 0x0000000180038380-0x0000000180038390
		decimal IConvertible.ToDecimal(IFormatProvider provider) => default; // 0x0000000180038360-0x0000000180038380
		DateTime IConvertible.ToDateTime(IFormatProvider provider) => default; // 0x0000000180002410-0x0000000180002420
		object IConvertible.ToType(Type type, IFormatProvider provider) => default; // 0x00000001800383E0-0x0000000180038470
		internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) {
			result = default;
			return default;
		} // 0x00000001809127E0-0x0000000180912A30
	}
}
