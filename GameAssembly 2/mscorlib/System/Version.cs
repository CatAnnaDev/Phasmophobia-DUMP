/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public sealed class Version : ICloneable, IComparable, IComparable<System.Version>, IEquatable<System.Version> // TypeDefIndex: 325
	{
		// Fields
		private int _Major; // 0x10
		private int _Minor; // 0x14
		private int _Build; // 0x18
		private int _Revision; // 0x1C
		private static readonly char[] SeparatorsArray; // 0x00
		private const int ZERO_CHAR_VALUE = 48; // Metadata: 0x0063022E
	
		// Properties
		public int Major { get => default; } // 0x0000000180245EA0-0x0000000180246600 
		public int Minor { get => default; } // 0x00000001802932A0-0x00000001802932B0 
		public int Build { get => default; } // 0x000000018027A800-0x000000018027A810 
		public int Revision { get => default; } // 0x000000018027A6E0-0x000000018027A6F0 
	
		// Nested types
		internal enum ParseFailureKind // TypeDefIndex: 326
		{
			ArgumentNullException = 0,
			ArgumentException = 1,
			ArgumentOutOfRangeException = 2,
			FormatException = 3
		}
	
		internal struct VersionResult // TypeDefIndex: 327
		{
			// Fields
			internal Version m_parsedVersion; // 0x00
			internal ParseFailureKind m_failure; // 0x08
			internal string m_exceptionArgument; // 0x10
			internal string m_argumentName; // 0x18
			internal bool m_canThrow; // 0x20
	
			// Methods
			internal void Init(string argumentName, bool canThrow) {} // 0x00000001800477B0-0x00000001800477C0
			internal void SetFailure(ParseFailureKind failure) {} // 0x00000001800477D0-0x0000000180047800
			internal void SetFailure(ParseFailureKind failure, string argument) {} // 0x00000001800477C0-0x00000001800477D0
			internal Exception GetVersionParseException() => default; // 0x00000001800477A0-0x00000001800477B0
		}
	
		// Constructors
		public Version(int major, int minor, int build, int revision) {} // 0x0000000180A77920-0x0000000180A77AC0
		public Version(int major, int minor, int build) {} // 0x0000000180A77570-0x0000000180A776C0
		public Version(int major, int minor) {} // 0x0000000180A77830-0x0000000180A77920
		public Version(string version) {} // 0x0000000180A776C0-0x0000000180A77830
		public Version() {} // 0x0000000180A77540-0x0000000180A77570
		static Version() {} // 0x0000000180A774C0-0x0000000180A77540
	
		// Methods
		public object Clone() => default; // 0x0000000180A76230-0x0000000180A762B0
		public int CompareTo(object version) => default; // 0x0000000180A762B0-0x0000000180A76410
		public int CompareTo(Version value) => default; // 0x0000000180A76410-0x0000000180A76510
		public override bool Equals(object obj) => default; // 0x0000000180A765B0-0x0000000180A766B0
		public bool Equals(Version obj) => default; // 0x0000000180A76510-0x0000000180A765B0
		public override int GetHashCode() => default; // 0x0000000180A766B0-0x0000000180A766E0
		public override string ToString() => default; // 0x0000000180A76C20-0x0000000180A76D00
		public string ToString(int fieldCount) => default; // 0x0000000180A767D0-0x0000000180A76C20
		private static void AppendPositiveNumber(int num, StringBuilder sb) {} // 0x0000000180A761A0-0x0000000180A76230
		public static Version Parse(string input) => default; // 0x0000000180A766E0-0x0000000180A767D0
		private static bool TryParseVersion(string version, ref VersionResult result) => default; // 0x0000000180A76E50-0x0000000180A774C0
		private static bool TryParseComponent(string component, string componentName, ref VersionResult result, out int parsedComponent) {
			parsedComponent = default;
			return default;
		} // 0x0000000180A76D00-0x0000000180A76E50
		public static bool operator ==(Version v1, Version v2) => default; // 0x0000000180A77AC0-0x0000000180A77B80
		public static bool operator !=(Version v1, Version v2) => default; // 0x0000000180A77C40-0x0000000180A77CB0
		public static bool operator <(Version v1, Version v2) => default; // 0x0000000180A77D30-0x0000000180A77DB0
		public static bool operator <=(Version v1, Version v2) => default; // 0x0000000180A77CB0-0x0000000180A77D30
		public static bool operator >=(Version v1, Version v2) => default; // 0x0000000180A77B80-0x0000000180A77C40
	}
}
