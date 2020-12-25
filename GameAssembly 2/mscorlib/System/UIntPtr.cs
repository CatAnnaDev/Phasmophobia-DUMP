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
	// [CLSCompliant] // 0x00000001800E18D0-0x00000001800E1910
	// [ComVisible] // 0x00000001800E18D0-0x00000001800E1910
	public struct UIntPtr : ISerializable // TypeDefIndex: 407
	{
		// Fields
		public static readonly UIntPtr Zero; // 0x00
		private unsafe void* _pointer; // 0x00
	
		// Properties
		public static int Size { get => default; } // 0x00000001803ECB70-0x00000001803ECB80 
	
		// Constructors
		public unsafe UIntPtr(ulong value) : this() {
			_pointer = default;
		} // 0x00000001800472B0-0x0000000180047320
		public unsafe UIntPtr(uint value) : this() {
			_pointer = default;
		} // 0x0000000180047320-0x0000000180047330
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public unsafe UIntPtr(void* value) : this() {
			_pointer = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static UIntPtr() {
			Zero = default;
		} // 0x0000000180A74580-0x0000000180A745B0
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000180047120-0x00000001800471B0
		public override int GetHashCode() => default; // 0x000000018000B580-0x000000018000B590
		public override string ToString() => default; // 0x0000000180047240-0x00000001800472B0
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x00000001800471B0-0x0000000180047240
		public static bool operator ==(UIntPtr value1, UIntPtr value2) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static explicit operator ulong(UIntPtr value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator UIntPtr(ulong value) => default; // 0x0000000180A745B0-0x0000000180A746D0
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static unsafe explicit operator UIntPtr(void* value) => default; // 0x00000001802A78B0-0x00000001802A78C0
	}
}
