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
	internal sealed class CultureAwareComparer : StringComparer // TypeDefIndex: 295
	{
		// Fields
		private CompareInfo _compareInfo; // 0x10
		private bool _ignoreCase; // 0x18
		[OptionalField] // 0x00000001800DF500-0x00000001800DF510
		private CompareOptions _options; // 0x1C
	
		// Constructors
		public CultureAwareComparer() {} // Dummy constructor
		internal CultureAwareComparer(CultureInfo culture, bool ignoreCase) {} // 0x0000000180900840-0x00000001809008F0
	
		// Methods
		public override int Compare(string x, string y) => default; // 0x0000000180900600-0x0000000180900660
		public override bool Equals(string x, string y) => default; // 0x0000000180900660-0x00000001809006C0
		public override int GetHashCode(string obj) => default; // 0x0000000180900770-0x0000000180900800
		public override bool Equals(object obj) => default; // 0x00000001809006C0-0x0000000180900770
		public override int GetHashCode() => default; // 0x0000000180900800-0x0000000180900840
	}
}
