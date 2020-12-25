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
	public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 316
	{
		// Fields
		private string ClassName; // 0x88
		private string AssemblyName; // 0x90
		private string MessageArg; // 0x98
		internal int ResourceId; // 0xA0
	
		// Properties
		public override string Message { get => default; } // 0x0000000180A70F90-0x0000000180A70FB0 
	
		// Constructors
		public TypeLoadException() {} // 0x0000000180A70F30-0x0000000180A70F90
		public TypeLoadException(string message) {} // 0x0000000180A70F00-0x0000000180A70F30
		private TypeLoadException(string className, string assemblyName) {} // 0x0000000180A70CB0-0x0000000180A70D40
		private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId) {} // 0x0000000180A70D40-0x0000000180A70DE0
		protected TypeLoadException(SerializationInfo info, StreamingContext context) {} // 0x0000000180A70DE0-0x0000000180A70F00
	
		// Methods
		private void SetMessageField() {} // 0x0000000180A70B40-0x0000000180A70CB0
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180A709C0-0x0000000180A70B40
	}
}
