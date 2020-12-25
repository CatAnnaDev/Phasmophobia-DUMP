/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public class BadImageFormatException : SystemException // TypeDefIndex: 167
	{
		// Fields
		private string _fileName; // 0x88
		private string _fusionLog; // 0x90
	
		// Properties
		public override string Message { get => default; } // 0x000000018070C9A0-0x000000018070CA20 
		public string FusionLog { get => default; } // 0x0000000180274960-0x0000000180274970 
	
		// Constructors
		public BadImageFormatException() {} // 0x000000018070C820-0x000000018070C880
		public BadImageFormatException(string message) {} // 0x000000018070C970-0x000000018070C9A0
		public BadImageFormatException(string message, Exception inner) {} // 0x000000018070C7F0-0x000000018070C820
		public BadImageFormatException(string message, string fileName) {} // 0x000000018070C7A0-0x000000018070C7F0
		protected BadImageFormatException(SerializationInfo info, StreamingContext context) {} // 0x000000018070C880-0x000000018070C970
	
		// Methods
		private void SetMessageField() {} // 0x000000018070C490-0x000000018070C510
		public override string ToString() => default; // 0x000000018070C510-0x000000018070C7A0
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018070C350-0x000000018070C490
	}
}
