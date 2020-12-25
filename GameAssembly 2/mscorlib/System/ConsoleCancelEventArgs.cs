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
	public sealed class ConsoleCancelEventArgs : EventArgs // TypeDefIndex: 177
	{
		// Fields
		private ConsoleSpecialKey _type; // 0x10
		private bool _cancel; // 0x14
	
		// Properties
		public bool Cancel { get => default; } // 0x00000001802D2B60-0x00000001802D2B70 
	
		// Constructors
		internal ConsoleCancelEventArgs(ConsoleSpecialKey type) {} // 0x000000018080FAB0-0x000000018080FB20
		internal ConsoleCancelEventArgs() {} // 0x000000018080FA80-0x000000018080FAB0
	}
}
