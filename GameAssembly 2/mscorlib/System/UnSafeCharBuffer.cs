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
	internal struct UnSafeCharBuffer // TypeDefIndex: 324
	{
		// Fields
		private unsafe char* m_buffer; // 0x00
		private int m_totalSize; // 0x08
		private int m_length; // 0x0C
	
		// Constructors
		public unsafe UnSafeCharBuffer(char* buffer, int bufferSize) {
			m_buffer = default;
			m_totalSize = default;
			m_length = default;
		} // 0x00000001800473F0-0x0000000180047420
	
		// Methods
		public void AppendString(string stringToAppend) {} // 0x0000000180047330-0x00000001800473F0
	}
}
