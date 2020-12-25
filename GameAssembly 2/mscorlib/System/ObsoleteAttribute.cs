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
	[AttributeUsage(AttributeTargets.All)] // 0x00000001800E82D0-0x00000001800E8310
	// [ComVisible] // 0x00000001800E82D0-0x00000001800E8310
	public sealed class ObsoleteAttribute : Attribute // TypeDefIndex: 272
	{
		// Fields
		private string _message; // 0x10
		private bool _error; // 0x18
	
		// Properties
		public string Message { get => default; } // 0x0000000180248E10-0x0000000180248E20 
	
		// Constructors
		public ObsoleteAttribute() {} // 0x000000018068DB30-0x000000018068DB60
		public ObsoleteAttribute(string message) {} // 0x000000018068DAF0-0x000000018068DB30
		public ObsoleteAttribute(string message, bool error) {} // 0x000000018068DB60-0x000000018068DBB0
	}
}
