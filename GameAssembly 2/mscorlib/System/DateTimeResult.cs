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

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	internal struct DateTimeResult // TypeDefIndex: 228
	{
		// Fields
		internal int Year; // 0x00
		internal int Month; // 0x04
		internal int Day; // 0x08
		internal int Hour; // 0x0C
		internal int Minute; // 0x10
		internal int Second; // 0x14
		internal double fraction; // 0x18
		internal int era; // 0x20
		internal ParseFlags flags; // 0x24
		internal TimeSpan timeZoneOffset; // 0x28
		internal Calendar calendar; // 0x30
		internal DateTime parsedDate; // 0x38
		internal ParseFailureKind failure; // 0x40
		internal string failureMessageID; // 0x48
		internal object failureMessageFormatArgument; // 0x50
		internal string failureArgumentName; // 0x58
	
		// Methods
		internal void Init() {} // 0x0000000180037F20-0x0000000180037F50
		internal void SetDate(int year, int month, int day) {} // 0x00000001800084C0-0x0000000180008520
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) {} // 0x0000000180037F50-0x0000000180037F90
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) {} // 0x0000000180037F90-0x0000000180038000
	}
}
