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
	public class ArgumentOutOfRangeException : ArgumentException, ISerializable // TypeDefIndex: 158
	{
		// Fields
		private static string _rangeMessage; // 0x00
		private object m_actualValue; // 0x90
	
		// Properties
		private static string RangeMessage { get => default; } // 0x0000000180703620-0x00000001807036B0 
		public override string Message { get => default; } // 0x0000000180703410-0x0000000180703620 
	
		// Constructors
		public ArgumentOutOfRangeException() {} // 0x0000000180703160-0x00000001807031B0
		public ArgumentOutOfRangeException(string paramName) {} // 0x0000000180703210-0x0000000180703280
		public ArgumentOutOfRangeException(string paramName, string message) {} // 0x00000001807031B0-0x0000000180703210
		public ArgumentOutOfRangeException(string paramName, object actualValue, string message) {} // 0x0000000180703390-0x0000000180703410
		protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context) {} // 0x0000000180703280-0x0000000180703390
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180702FF0-0x0000000180703160
	}
}
