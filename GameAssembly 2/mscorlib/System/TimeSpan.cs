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
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public struct TimeSpan : IComparable, IComparable<System.TimeSpan>, IEquatable<System.TimeSpan>, IFormattable // TypeDefIndex: 303
	{
		// Fields
		public static readonly TimeSpan Zero; // 0x00
		public static readonly TimeSpan MaxValue; // 0x08
		public static readonly TimeSpan MinValue; // 0x10
		internal long _ticks; // 0x00
		private static bool _legacyConfigChecked; // 0x18
		private static bool _legacyMode; // 0x19
	
		// Properties
		public long Ticks { get => default; } // 0x0000000180002410-0x0000000180002420 
		public int Hours { get => default; } // 0x00000001800197A0-0x00000001800197E0 
		public int Milliseconds { get => default; } // 0x00000001800197E0-0x0000000180019830 
		public int Minutes { get => default; } // 0x0000000180019830-0x0000000180019880 
		public int Seconds { get => default; } // 0x0000000180019880-0x00000001800198D0 
		public double TotalHours { get => default; } // 0x00000001800198D0-0x00000001800198F0 
		public double TotalMilliseconds { get => default; } // 0x00000001800198F0-0x0000000180019930 
		public double TotalMinutes { get => default; } // 0x0000000180019930-0x0000000180019950 
		public double TotalSeconds { get => default; } // 0x0000000180019950-0x0000000180019970 
		private static bool LegacyMode { get => default; } // 0x000000018049C080-0x000000018049C320 
	
		// Constructors
		public TimeSpan(long ticks) : this() {
			_ticks = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		public TimeSpan(int hours, int minutes, int seconds) : this() {
			_ticks = default;
		} // 0x0000000180019790-0x00000001800197A0
		public TimeSpan(int days, int hours, int minutes, int seconds) : this() {
			_ticks = default;
		} // 0x0000000180019750-0x0000000180019780
		public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) : this() {
			_ticks = default;
		} // 0x0000000180019780-0x0000000180019790
		static TimeSpan() {
			Zero = default;
			MaxValue = default;
			MinValue = default;
			_legacyConfigChecked = default;
			_legacyMode = default;
		} // 0x000000018049BDD0-0x000000018049C080
	
		// Methods
		public TimeSpan Add(TimeSpan ts) => default; // 0x0000000180019220-0x0000000180019230
		public static int Compare(TimeSpan t1, TimeSpan t2) => default; // 0x000000018049B6C0-0x000000018049B780
		public int CompareTo(object value) => default; // 0x0000000180019250-0x0000000180019330
		public int CompareTo(TimeSpan value) => default; // 0x0000000180019230-0x0000000180019250
		public static TimeSpan FromDays(double value) => default; // 0x000000018049B780-0x000000018049B7E0
		public override bool Equals(object value) => default; // 0x0000000180019330-0x00000001800193C0
		public bool Equals(TimeSpan obj) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public override int GetHashCode() => default; // 0x00000001800193C0-0x00000001800193D0
		public static TimeSpan FromHours(double value) => default; // 0x000000018049B7E0-0x000000018049B840
		private static TimeSpan Interval(double value, int scale) => default; // 0x000000018049B9B0-0x000000018049BBA0
		public static TimeSpan FromMilliseconds(double value) => default; // 0x000000018049B840-0x000000018049B8A0
		public static TimeSpan FromMinutes(double value) => default; // 0x000000018049B8A0-0x000000018049B900
		public TimeSpan Negate() => default; // 0x00000001800193D0-0x0000000180019490
		public static TimeSpan FromSeconds(double value) => default; // 0x000000018049B900-0x000000018049B970
		public TimeSpan Subtract(TimeSpan ts) => default; // 0x0000000180019490-0x00000001800194A0
		public static TimeSpan FromTicks(long value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		internal static long TimeToTicks(int hour, int minute, int second) => default; // 0x000000018049BD10-0x000000018049BDD0
		public static TimeSpan Parse(string s) => default; // 0x000000018049BC10-0x000000018049BD10
		public static TimeSpan Parse(string input, IFormatProvider formatProvider) => default; // 0x000000018049BBA0-0x000000018049BC10
		public override string ToString() => default; // 0x00000001800194A0-0x0000000180019500
		public string ToString(string format) => default; // 0x0000000180019500-0x0000000180019570
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000180019570-0x0000000180019750
		public static TimeSpan operator -(TimeSpan t1, TimeSpan t2) => default; // 0x000000018049C380-0x000000018049C3A0
		public static TimeSpan operator +(TimeSpan t1, TimeSpan t2) => default; // 0x000000018049C320-0x000000018049C340
		public static bool operator ==(TimeSpan t1, TimeSpan t2) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(TimeSpan t1, TimeSpan t2) => default; // 0x00000001802A78C0-0x00000001802A7960
		public static bool operator <(TimeSpan t1, TimeSpan t2) => default; // 0x000000018049C370-0x000000018049C380
		public static bool operator <=(TimeSpan t1, TimeSpan t2) => default; // 0x000000018049C360-0x000000018049C370
		public static bool operator >(TimeSpan t1, TimeSpan t2) => default; // 0x000000018049C350-0x000000018049C360
		public static bool operator >=(TimeSpan t1, TimeSpan t2) => default; // 0x000000018049C340-0x000000018049C350
		private static bool GetLegacyFormatMode() => default; // 0x000000018049B970-0x000000018049B9B0
	}
}
