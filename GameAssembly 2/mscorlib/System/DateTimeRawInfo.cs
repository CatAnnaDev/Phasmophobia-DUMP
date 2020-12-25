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
	internal struct DateTimeRawInfo // TypeDefIndex: 225
	{
		// Fields
		private unsafe int* num; // 0x00
		internal int numCount; // 0x08
		internal int month; // 0x0C
		internal int year; // 0x10
		internal int dayOfWeek; // 0x14
		internal int era; // 0x18
		internal DateTimeParse.TM timeMark; // 0x1C
		internal double fraction; // 0x20
		internal bool hasSameDateAndTimeSeparators; // 0x28
		internal bool timeZone; // 0x29
	
		// Methods
		internal unsafe void Init(int* numberBuffer) {} // 0x0000000180037E50-0x0000000180037F20
		internal void AddNumber(int value) {} // 0x0000000180037E20-0x0000000180037E40
		internal int GetNumber(int index) => default; // 0x0000000180037E40-0x0000000180037E50
	}
}
