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
	public class MissingMethodException : MissingMemberException, ISerializable // TypeDefIndex: 263
	{
		// Fields
		[NonSerialized]
		private string signature; // 0xA0
	
		// Properties
		public override string Message { get => default; } // 0x0000000180680C40-0x0000000180680D30 
	
		// Constructors
		public MissingMethodException() {} // 0x0000000180680B70-0x0000000180680BF0
		public MissingMethodException(string message) {} // 0x0000000180680BF0-0x0000000180680C40
		protected MissingMethodException(SerializationInfo info, StreamingContext context) {} // 0x00000001806803C0-0x00000001806803E0
		public MissingMethodException(string className, string methodName) {} // 0x0000000180680430-0x00000001806804E0
		private MissingMethodException(string className, string methodName, string signature, string message) {} // 0x0000000180680AD0-0x0000000180680B70
	}
}
