/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
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
	public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 294
	{
		// Fields
		private static readonly StringComparer _invariantCulture; // 0x00
		private static readonly StringComparer _invariantCultureIgnoreCase; // 0x08
		private static readonly StringComparer _ordinal; // 0x10
		private static readonly StringComparer _ordinalIgnoreCase; // 0x18
	
		// Properties
		public static StringComparer InvariantCultureIgnoreCase { get; } // 0x00000001808C1000-0x00000001808C1060 
		public static StringComparer CurrentCultureIgnoreCase { get; } // 0x00000001808C0F80-0x00000001808C1000 
		public static StringComparer Ordinal { get; } // 0x00000001808C10C0-0x00000001808C1120 
		public static StringComparer OrdinalIgnoreCase { get; } // 0x00000001808C1060-0x00000001808C10C0 
	
		// Constructors
		protected StringComparer() {} // 0x00000001802466A0-0x00000001802466B0
		static StringComparer() {} // 0x00000001808C0E30-0x00000001808C0F80
	
		// Methods
		public int Compare(object x, object y) => default; // 0x00000001808C0AE0-0x00000001808C0CA0
		public new bool Equals(object x, object y) => default; // 0x00000001808C0CA0-0x00000001808C0D80
		public int GetHashCode(object obj) => default; // 0x00000001808C0D80-0x00000001808C0E30
		public abstract int Compare(string x, string y);
		public abstract bool Equals(string x, string y);
		public abstract int GetHashCode(string obj);
	}
}
