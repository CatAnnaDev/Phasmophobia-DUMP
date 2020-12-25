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
	public sealed class TypeInitializationException : SystemException // TypeDefIndex: 315
	{
		// Fields
		private string _typeName; // 0x88
	
		// Properties
		public string TypeName { get => default; } // 0x0000000180A70970-0x0000000180A709C0 
	
		// Constructors
		private TypeInitializationException() {} // 0x0000000180A70880-0x0000000180A708E0
		public TypeInitializationException(string fullTypeName, Exception innerException) {} // 0x0000000180A70770-0x0000000180A70880
		internal TypeInitializationException(SerializationInfo info, StreamingContext context) {} // 0x0000000180A708E0-0x0000000180A70970
	
		// Methods
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180A70680-0x0000000180A70770
	}
}
