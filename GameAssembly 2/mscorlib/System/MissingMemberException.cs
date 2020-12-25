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
	public class MissingMemberException : MemberAccessException, ISerializable // TypeDefIndex: 262
	{
		// Fields
		protected string ClassName; // 0x88
		protected string MemberName; // 0x90
		protected byte[] Signature; // 0x98
	
		// Properties
		public override string Message { get => default; } // 0x0000000180680970-0x0000000180680AD0 
	
		// Constructors
		public MissingMemberException() {} // 0x0000000180680780-0x00000001806807F0
		public MissingMemberException(string message) {} // 0x00000001806807F0-0x0000000180680830
		protected MissingMemberException(SerializationInfo info, StreamingContext context) {} // 0x0000000180680830-0x0000000180680970
	
		// Methods
		internal static string FormatSignature(byte[] signature) => default; // 0x00000001802922E0-0x00000001802922F0
		public override void GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180680620-0x0000000180680780
	}
}
