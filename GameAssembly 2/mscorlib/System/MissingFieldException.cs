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
	public class MissingFieldException : MissingMemberException, ISerializable // TypeDefIndex: 261
	{
		// Properties
		public override string Message { get => default; } // 0x00000001806804E0-0x0000000180680620 
	
		// Constructors
		public MissingFieldException() {} // 0x0000000180680340-0x00000001806803C0
		public MissingFieldException(string message) {} // 0x00000001806803E0-0x0000000180680430
		protected MissingFieldException(SerializationInfo info, StreamingContext context) {} // 0x00000001806803C0-0x00000001806803E0
		public MissingFieldException(string className, string fieldName) {} // 0x0000000180680430-0x00000001806804E0
	}
}
