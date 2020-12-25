/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Microsoft.Win32;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [TypeForwardedFrom] // 0x00000001800E4640-0x00000001800E4670
	public sealed class TimeZoneInfo : IEquatable<System.TimeZoneInfo>, ISerializable, IDeserializationCallback // TypeDefIndex: 305
	{
		// Fields
		private TimeSpan baseUtcOffset; // 0x10
		private string daylightDisplayName; // 0x18
		private string displayName; // 0x20
		private string id; // 0x28
		private static TimeZoneInfo local; // 0x00
		private List<KeyValuePair<DateTime, TimeType>> transitions; // 0x30
		private static bool readlinkNotFound; // 0x08
		private string standardDisplayName; // 0x38
		private bool supportsDaylightSavingTime; // 0x40
		private static TimeZoneInfo utc; // 0x10
		private static string timeZoneDirectory; // 0x18
		private AdjustmentRule[] adjustmentRules; // 0x48
		private static RegistryKey timeZoneKey; // 0x20
		private static RegistryKey localZoneKey; // 0x28
		private static ReadOnlyCollection<TimeZoneInfo> systemTimeZones; // 0x30
	
		// Properties
		public TimeSpan BaseUtcOffset { get => default; } // 0x0000000180248E10-0x0000000180248E20 
		public string DisplayName { get => default; } // 0x0000000180246FE0-0x0000000180246FF0 
		public string Id { get => default; } // 0x00000001802470A0-0x00000001802470B0 
		public static TimeZoneInfo Local { get => default; } // 0x00000001804A5830-0x00000001804A58E0 
		public bool SupportsDaylightSavingTime { get => default; } // 0x0000000180247090-0x00000001802470A0 
		public static TimeZoneInfo Utc { get => default; } // 0x00000001804A5A60-0x00000001804A5AF0 
		private static string TimeZoneDirectory { get => default; } // 0x00000001804A58E0-0x00000001804A5940 
		private static bool IsWindows { get => default; } // 0x00000001804A56D0-0x00000001804A5710 
		private static RegistryKey TimeZoneKey { get => default; } // 0x00000001804A5940-0x00000001804A5A60 
		private static RegistryKey LocalZoneKey { get => default; } // 0x00000001804A5710-0x00000001804A5830 
	
		// Nested types
		[Serializable]
		// [TypeForwardedFrom] // 0x00000001800E4640-0x00000001800E4670
		public sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback // TypeDefIndex: 306
		{
			// Fields
			private DateTime m_dateStart; // 0x10
			private DateTime m_dateEnd; // 0x18
			private TimeSpan m_daylightDelta; // 0x20
			private TransitionTime m_daylightTransitionStart; // 0x28
			private TransitionTime m_daylightTransitionEnd; // 0x40
			private TimeSpan m_baseUtcOffsetDelta; // 0x58
	
			// Properties
			public DateTime DateStart { get => default; } // 0x0000000180248E10-0x0000000180248E20 
			public DateTime DateEnd { get => default; } // 0x0000000180246BC0-0x0000000180246BD0 
			public TimeSpan DaylightDelta { get => default; } // 0x0000000180246FE0-0x0000000180246FF0 
			public TransitionTime DaylightTransitionStart { get => default; } // 0x00000001804928F0-0x0000000180492910 
			public TransitionTime DaylightTransitionEnd { get => default; } // 0x00000001804928D0-0x00000001804928F0 
	
			// Constructors
			private AdjustmentRule() {} // 0x00000001802466A0-0x00000001802466B0
			private AdjustmentRule(SerializationInfo info, StreamingContext context) {} // 0x00000001804925F0-0x00000001804928D0
	
			// Methods
			public bool Equals(AdjustmentRule other) => default; // 0x0000000180491DE0-0x0000000180491F60
			public override int GetHashCode() => default; // 0x0000000180491F60-0x0000000180491F70
			public static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd) => default; // 0x0000000180491C20-0x0000000180491D70
			internal static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta) => default; // 0x0000000180491D70-0x0000000180491DE0
			private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd) {} // 0x00000001804921D0-0x00000001804925F0
			void IDeserializationCallback.OnDeserialization(object sender) {} // 0x0000000180491F70-0x0000000180492060
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180492060-0x00000001804921D0
		}
	
		[Serializable]
		// [TypeForwardedFrom] // 0x00000001800E4640-0x00000001800E4670
		public struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback // TypeDefIndex: 307
		{
			// Fields
			private DateTime m_timeOfDay; // 0x00
			private byte m_month; // 0x08
			private byte m_week; // 0x09
			private byte m_day; // 0x0A
			private DayOfWeek m_dayOfWeek; // 0x0C
			private bool m_isFixedDateRule; // 0x10
	
			// Properties
			public DateTime TimeOfDay { get => default; } // 0x0000000180002410-0x0000000180002420 
			public int Month { get => default; } // 0x0000000180019BB0-0x0000000180019D80 
			public int Week { get => default; } // 0x0000000180006B40-0x0000000180006B50 
			public int Day { get => default; } // 0x0000000180019BA0-0x0000000180019BB0 
			public DayOfWeek DayOfWeek { get => default; } // 0x0000000180006B70-0x0000000180006C90 
			public bool IsFixedDateRule { get => default; } // 0x000000018000B1A0-0x000000018000B1B0 
	
			// Constructors
			private TransitionTime(SerializationInfo info, StreamingContext context) : this() {
				m_timeOfDay = default;
				m_month = default;
				m_week = default;
				m_day = default;
				m_dayOfWeek = default;
				m_isFixedDateRule = default;
			} // 0x0000000180019B80-0x0000000180019BA0
	
			// Methods
			public override bool Equals(object obj) => default; // 0x00000001800199A0-0x0000000180019A40
			public static bool operator !=(TransitionTime t1, TransitionTime t2) => default; // 0x00000001804A7080-0x00000001804A70B0
			public bool Equals(TransitionTime other) => default; // 0x0000000180019970-0x00000001800199A0
			public override int GetHashCode() => default; // 0x0000000180019A40-0x0000000180019A50
			public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) => default; // 0x00000001804A6730-0x00000001804A67D0
			public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) => default; // 0x00000001804A67D0-0x00000001804A6880
			private static TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) => default; // 0x00000001804A6880-0x00000001804A6B30
			private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) {} // 0x00000001804A6B30-0x00000001804A7080
			void IDeserializationCallback.OnDeserialization(object sender) {} // 0x0000000180019A50-0x0000000180019A60
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180019A60-0x0000000180019B80
		}
	
		internal struct SYSTEMTIME // TypeDefIndex: 308
		{
			// Fields
			internal ushort wYear; // 0x00
			internal ushort wMonth; // 0x02
			internal ushort wDayOfWeek; // 0x04
			internal ushort wDay; // 0x06
			internal ushort wHour; // 0x08
			internal ushort wMinute; // 0x0A
			internal ushort wSecond; // 0x0C
			internal ushort wMilliseconds; // 0x0E
		}
	
		internal struct TIME_ZONE_INFORMATION // TypeDefIndex: 309
		{
			// Fields
			internal int Bias; // 0x00
			internal string StandardName; // 0x08
			internal SYSTEMTIME StandardDate; // 0x10
			internal int StandardBias; // 0x20
			internal string DaylightName; // 0x28
			internal SYSTEMTIME DaylightDate; // 0x30
			internal int DaylightBias; // 0x40
		}
	
		internal struct DYNAMIC_TIME_ZONE_INFORMATION // TypeDefIndex: 310
		{
			// Fields
			internal TIME_ZONE_INFORMATION TZI; // 0x00
			internal string TimeZoneKeyName; // 0x48
			internal byte DynamicDaylightTimeDisabled; // 0x50
		}
	
		// Constructors
		private TimeZoneInfo(SerializationInfo info, StreamingContext context) {} // 0x00000001804A4DB0-0x00000001804A50F0
		private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) {} // 0x00000001804A50F0-0x00000001804A56A0
		internal TimeZoneInfo() {} // 0x00000001804A56A0-0x00000001804A56D0
	
		// Methods
		internal static bool UtcOffsetOutOfRange(TimeSpan offset) => default; // 0x00000001804A4660-0x00000001804A4690
		private static List<AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names, string standardNameCurrentYear, string daylightNameCurrentYear) {
			data = default;
			names = default;
			return default;
		} // 0x000000018049D520-0x000000018049DCA0
		private static TimeZoneInfo CreateLocalUnity() => default; // 0x000000018049DDC0-0x000000018049E260
		internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation); // 0x000000018049E7F0-0x000000018049E910
		internal static extern uint GetDynamicTimeZoneInformation(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation); // 0x000000018049FA00-0x000000018049FB20
		internal static extern uint GetDynamicTimeZoneInformationWin32(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation); // 0x000000018049F8E0-0x000000018049FA00
		internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear); // 0x000000018049F7A0-0x000000018049F8E0
		internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TIME_ZONE_INFORMATION ptzi); // 0x00000001804A0DD0-0x00000001804A0FE0
		internal static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) => default; // 0x000000018049CF90-0x000000018049D520
		private static bool TransitionTimeFromTimeZoneInformation(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TransitionTime transitionTime, bool readStartDate) {
			transitionTime = default;
			return default;
		} // 0x00000001804A3530-0x00000001804A3730
		internal static TimeZoneInfo TryCreateTimeZone(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) => default; // 0x00000001804A3A00-0x00000001804A40B0
		internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() => default; // 0x000000018049FC40-0x000000018049FE10
		internal static string GetLocalTimeZoneKeyNameWin32Fallback() => default; // 0x000000018049FE10-0x000000018049FFC0
		internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) => default; // 0x000000018049EBF0-0x000000018049EEA0
		internal static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback() => default; // 0x00000001804A0A70-0x00000001804A0D00
		private static extern int readlink(string path, byte[] buffer, int buflen); // 0x00000001804A5CB0-0x00000001804A5D70
		private static string readlink(string path) => default; // 0x00000001804A5AF0-0x00000001804A5CB0
		private static bool TryGetNameFromPath(string path, out string name) {
			name = default;
			return default;
		} // 0x00000001804A40B0-0x00000001804A43B0
		private static TimeZoneInfo CreateLocal() => default; // 0x000000018049E260-0x000000018049E7A0
		private static TimeZoneInfo FindSystemTimeZoneByIdCore(string id) => default; // 0x000000018049EB30-0x000000018049EBF0
		private static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones) {} // 0x00000001804A0000-0x00000001804A0A70
		private static string TrimSpecial(string str) => default; // 0x00000001804A3730-0x00000001804A3860
		private static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = DateTimeKind.Unspecified /* Metadata: 0x00630206 */) {
			result = default;
			return default;
		} // 0x00000001804A3860-0x00000001804A3A00
		public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone) => default; // 0x000000018049CD20-0x000000018049CF90
		private DateTime ConvertTimeFromUtc(DateTime dateTime) => default; // 0x000000018049C960-0x000000018049CAE0
		public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone) => default; // 0x000000018049C8E0-0x000000018049C960
		internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) => default; // 0x000000018049CAE0-0x000000018049CB20
		public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone) => default; // 0x000000018049CD10-0x000000018049CD20
		private static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags) => default; // 0x000000018049CB20-0x000000018049CD10
		internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) {
			isAmbiguousLocalDst = default;
			return default;
		} // 0x000000018049F730-0x000000018049F7A0
		public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) => default; // 0x000000018049DD90-0x000000018049DDC0
		public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules) => default; // 0x000000018049DD60-0x000000018049DD90
		public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) => default; // 0x000000018049DCA0-0x000000018049DD60
		public override bool Equals(object obj) => default; // 0x000000018049E910-0x000000018049E9A0
		public bool Equals(TimeZoneInfo other) => default; // 0x000000018049E9A0-0x000000018049E9F0
		public static TimeZoneInfo FindSystemTimeZoneById(string id) => default; // 0x000000018049EEA0-0x000000018049F0B0
		private static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath) => default; // 0x000000018049E9F0-0x000000018049EB30
		private static TimeZoneInfo FromRegistryKey(string id, RegistryKey key) => default; // 0x000000018049F0B0-0x000000018049F4E0
		private static void ParseRegTzi(List<AdjustmentRule> adjustmentRules, int start_year, int end_year, byte[] buffer) {} // 0x00000001804A1F00-0x00000001804A22A0
		public AdjustmentRule[] GetAdjustmentRules() => default; // 0x000000018049F4E0-0x000000018049F570
		public override int GetHashCode() => default; // 0x000000018049FB20-0x000000018049FC40
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001804A3270-0x00000001804A33A0
		public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() => default; // 0x00000001804A0D00-0x00000001804A0DD0
		public TimeSpan GetUtcOffset(DateTime dateTime) => default; // 0x00000001804A13E0-0x00000001804A1400
		private TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST) {
			isDST = default;
			return default;
		} // 0x00000001804A1300-0x00000001804A13E0
		private static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST) {
			isDST = default;
			return default;
		} // 0x00000001804A1050-0x00000001804A1300
		public bool HasSameRules(TimeZoneInfo other) => default; // 0x00000001804A1400-0x00000001804A1720
		public bool IsAmbiguousTime(DateTime dateTime) => default; // 0x00000001804A1720-0x00000001804A1940
		private bool IsInDST(AdjustmentRule rule, DateTime dateTime) => default; // 0x00000001804A1B20-0x00000001804A1BE0
		private bool IsInDSTForYear(AdjustmentRule rule, DateTime dateTime, int year) => default; // 0x00000001804A1940-0x00000001804A1B20
		public bool IsInvalidTime(DateTime dateTime) => default; // 0x00000001804A1BE0-0x00000001804A1D50
		void IDeserializationCallback.OnDeserialization(object sender) {} // 0x00000001804A31D0-0x00000001804A3270
		private static void Validate(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules) {} // 0x00000001804A48B0-0x00000001804A4DB0
		public override string ToString() => default; // 0x0000000180246FE0-0x0000000180246FF0
		private AdjustmentRule GetApplicableRule(DateTime dateTime) => default; // 0x000000018049F570-0x000000018049F730
		private bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst) {
			offset = default;
			isDst = default;
			return default;
		} // 0x00000001804A43B0-0x00000001804A4660
		private static DateTime TransitionPoint(TransitionTime transition, int year) => default; // 0x00000001804A33A0-0x00000001804A3530
		private static AdjustmentRule[] ValidateRules(List<AdjustmentRule> adjustmentRules) => default; // 0x00000001804A4770-0x00000001804A48B0
		private static TimeZoneInfo BuildFromStream(string id, Stream stream) => default; // 0x000000018049C6E0-0x000000018049C8E0
		private static bool ValidTZFile(byte[] buffer, int length) => default; // 0x00000001804A4690-0x00000001804A4770
		private static int SwapInt32(int i) => default; // 0x00000001804A31A0-0x00000001804A31D0
		private static int ReadBigEndianInt32(byte[] buffer, int start) => default; // 0x00000001804A3100-0x00000001804A31A0
		private static TimeZoneInfo ParseTZBuffer(string id, byte[] buffer, int length) => default; // 0x00000001804A22A0-0x00000001804A2CF0
		private static Dictionary<int, string> ParseAbbreviations(byte[] buffer, int index, int count) => default; // 0x00000001804A1D50-0x00000001804A1F00
		private static Dictionary<int, TimeType> ParseTimesTypes(byte[] buffer, int index, int count, Dictionary<int, string> abbreviations) => default; // 0x00000001804A2CF0-0x00000001804A2EF0
		private static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(byte[] buffer, int index, int count, Dictionary<int, TimeType> time_types) => default; // 0x00000001804A2EF0-0x00000001804A3100
		private static DateTime DateTimeFromUnixTime(long unix_time) => default; // 0x000000018049E7A0-0x000000018049E7F0
		internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) => default; // 0x000000018049FFC0-0x00000001804A0000
		internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) => default; // 0x00000001804A13E0-0x00000001804A1400
		internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) {
			isDaylightSavings = default;
			isAmbiguousLocalDst = default;
			return default;
		} // 0x00000001804A0FE0-0x00000001804A1050
	}
}
