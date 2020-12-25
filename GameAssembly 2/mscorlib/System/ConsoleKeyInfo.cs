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
	public struct ConsoleKeyInfo // TypeDefIndex: 180
	{
		// Fields
		private char _keyChar; // 0x00
		private ConsoleKey _key; // 0x04
		private ConsoleModifiers _mods; // 0x08
	
		// Properties
		public char KeyChar { get => default; } // 0x0000000180004230-0x0000000180004240 
		public ConsoleKey Key { get => default; } // 0x0000000180022C20-0x0000000180022C30 
	
		// Constructors
		public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) : this() {
			_keyChar = default;
			_key = default;
			_mods = default;
		} // 0x000000018002FE80-0x0000000180030310
	
		// Methods
		public override bool Equals(object value) => default; // 0x000000018002FD70-0x000000018002FE20
		public bool Equals(ConsoleKeyInfo obj) => default; // 0x000000018002FE20-0x000000018002FE70
		public override int GetHashCode() => default; // 0x000000018002FE70-0x000000018002FE80
	}
}
