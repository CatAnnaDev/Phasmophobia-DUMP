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
	public sealed class CharEnumerator : ICloneable, IEnumerator<char> // TypeDefIndex: 174
	{
		// Fields
		private string str; // 0x10
		private int index; // 0x18
		private char currentElement; // 0x1C
	
		// Properties
		object IEnumerator.Current { get => default; } // 0x000000018070F6C0-0x000000018070F7B0 
		public char Current { get => default; } // 0x000000018070F7E0-0x000000018070F8C0 
	
		// Constructors
		internal CharEnumerator(string str) {} // 0x000000018041D850-0x000000018041D890
		internal CharEnumerator() {} // 0x000000018070F7B0-0x000000018070F7E0
	
		// Methods
		public object Clone() => default; // 0x00000001802908F0-0x0000000180290900
		public bool MoveNext() => default; // 0x000000018070F650-0x000000018070F6B0
		public void Dispose() {} // 0x000000018070F620-0x000000018070F650
		public void Reset() {} // 0x000000018070F6B0-0x000000018070F6C0
	}
}
