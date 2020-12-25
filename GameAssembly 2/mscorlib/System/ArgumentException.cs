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
	public class ArgumentException : SystemException, ISerializable // TypeDefIndex: 156
	{
		// Fields
		private string m_paramName; // 0x88
	
		// Properties
		public override string Message { get => default; } // 0x0000000180702D80-0x0000000180702E90 
	
		// Constructors
		public ArgumentException() {} // 0x0000000180702CA0-0x0000000180702D00
		public ArgumentException(string message) {} // 0x0000000180702D50-0x0000000180702D80
		public ArgumentException(string message, Exception innerException) {} // 0x0000000180702B90-0x0000000180702BC0
		public ArgumentException(string message, string paramName, Exception innerException) {} // 0x0000000180702D00-0x0000000180702D50
		public ArgumentException(string message, string paramName) {} // 0x0000000180702BC0-0x0000000180702C10
		protected ArgumentException(SerializationInfo info, StreamingContext context) {} // 0x0000000180702C10-0x0000000180702CA0
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180702AA0-0x0000000180702B90
	}
}
