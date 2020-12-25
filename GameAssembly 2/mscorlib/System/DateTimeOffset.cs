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
	public struct DateTimeOffset : IComparable, IFormattable, ISerializable, IDeserializationCallback, IComparable<System.DateTimeOffset>, IEquatable<System.DateTimeOffset> // TypeDefIndex: 189
	{
		// Fields
		public static readonly DateTimeOffset MinValue; // 0x00
		public static readonly DateTimeOffset MaxValue; // 0x10
		private DateTime m_dateTime; // 0x00
		private short m_offsetMinutes; // 0x08
	
		// Properties
		public DateTime DateTime { get => default; } // 0x0000000180037B20-0x0000000180037B30 
		public DateTime UtcDateTime { get => default; } // 0x0000000180037DE0-0x0000000180037DF0 
		public DateTime LocalDateTime { get => default; } // 0x0000000180037BC0-0x0000000180037BF0 
		private DateTime ClockDateTime { get => default; } // 0x0000000180037B10-0x0000000180037B20 
		public int Day { get => default; } // 0x0000000180037B30-0x0000000180037B60 
		public int Hour { get => default; } // 0x0000000180037B60-0x0000000180037BC0 
		public int Millisecond { get => default; } // 0x0000000180037BF0-0x0000000180037C50 
		public int Minute { get => default; } // 0x0000000180037C50-0x0000000180037CB0 
		public int Month { get => default; } // 0x0000000180037CB0-0x0000000180037CE0 
		public TimeSpan Offset { get => default; } // 0x0000000180037CE0-0x0000000180037D10 
		public int Second { get => default; } // 0x0000000180037D10-0x0000000180037D70 
		public long Ticks { get => default; } // 0x0000000180037D70-0x0000000180037DA0 
		public TimeSpan TimeOfDay { get => default; } // 0x0000000180037DA0-0x0000000180037DE0 
		public int Year { get => default; } // 0x0000000180037DF0-0x0000000180037E20 
	
		// Constructors
		public DateTimeOffset(long ticks, TimeSpan offset) : this() {
			m_dateTime = default;
			m_offsetMinutes = default;
		} // 0x0000000180037690-0x00000001800376A0
		public DateTimeOffset(DateTime dateTime) : this() {
			m_dateTime = default;
			m_offsetMinutes = default;
		} // 0x0000000180037B00-0x0000000180037B10
		public DateTimeOffset(DateTime dateTime, TimeSpan offset) : this() {
			m_dateTime = default;
			m_offsetMinutes = default;
		} // 0x0000000180037900-0x0000000180037910
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset) : this() {
			m_dateTime = default;
			m_offsetMinutes = default;
		} // 0x00000001800376A0-0x00000001800377A0
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset) : this() {
			m_dateTime = default;
			m_offsetMinutes = default;
		} // 0x0000000180037A10-0x0000000180037B00
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset) : this() {
			m_dateTime = default;
			m_offsetMinutes = default;
		} // 0x0000000180037910-0x0000000180037A10
		private DateTimeOffset(SerializationInfo info, StreamingContext context) : this() {
			m_dateTime = default;
			m_offsetMinutes = default;
		} // 0x00000001800377A0-0x0000000180037900
		static DateTimeOffset() {
			MinValue = default;
			MaxValue = default;
		} // 0x0000000180904820-0x00000001809051C0
	
		// Methods
		int IComparable.CompareTo(object obj) => default; // 0x0000000180037170-0x0000000180037330
		public int CompareTo(DateTimeOffset other) => default; // 0x0000000180036E60-0x0000000180036F80
		public override bool Equals(object obj) => default; // 0x0000000180037020-0x0000000180037140
		public bool Equals(DateTimeOffset other) => default; // 0x0000000180036F80-0x0000000180037020
		void IDeserializationCallback.OnDeserialization(object sender) {} // 0x0000000180037330-0x0000000180037340
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180037340-0x00000001800373E0
		public override int GetHashCode() => default; // 0x0000000180037140-0x0000000180037170
		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) => default; // 0x0000000180903EB0-0x0000000180903F40
		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) => default; // 0x0000000180903F40-0x0000000180904520
		public override string ToString() => default; // 0x00000001800374C0-0x00000001800375A0
		public string ToString(IFormatProvider formatProvider) => default; // 0x00000001800373E0-0x00000001800374C0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x00000001800375A0-0x0000000180037690
		private static short ValidateOffset(TimeSpan offset) => default; // 0x00000001809045E0-0x00000001809046F0
		private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) => default; // 0x0000000180904520-0x00000001809045E0
		private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) => default; // 0x00000001809046F0-0x0000000180904820
		public static implicit operator DateTimeOffset(DateTime dateTime) => default; // 0x0000000180905250-0x0000000180905280
		public static bool operator ==(DateTimeOffset left, DateTimeOffset right) => default; // 0x00000001809051C0-0x0000000180905250
	}
}
