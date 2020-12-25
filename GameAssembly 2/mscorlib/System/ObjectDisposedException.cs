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
	public class ObjectDisposedException : InvalidOperationException // TypeDefIndex: 271
	{
		// Fields
		private string objectName; // 0x88
	
		// Properties
		public override string Message { get => default; } // 0x000000018068D8A0-0x000000018068DA00 
		public string ObjectName { get => default; } // 0x000000018068DA00-0x000000018068DA70 
	
		// Constructors
		private ObjectDisposedException() {} // 0x000000018068D720-0x000000018068D790
		public ObjectDisposedException(string objectName) {} // 0x000000018068D820-0x000000018068D8A0
		public ObjectDisposedException(string objectName, string message) {} // 0x000000018068D6D0-0x000000018068D720
		protected ObjectDisposedException(SerializationInfo info, StreamingContext context) {} // 0x000000018068D790-0x000000018068D820
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018068D5C0-0x000000018068D6D0
	}
}
