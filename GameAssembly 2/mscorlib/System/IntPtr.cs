/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public struct IntPtr : ISerializable // TypeDefIndex: 360
	{
		// Fields
		private unsafe void* m_value; // 0x00
		public static readonly IntPtr Zero; // 0x00
	
		// Properties
		public static int Size { /* [ReliabilityContract] */ /* 0x00000001800DF1C0-0x00000001800DF1E0 */ get => default; } // 0x00000001803ECB70-0x00000001803ECB80 
	
		// Constructors
		// [ReliabilityContract] // 0x00000001800F1500-0x00000001800F1520
		public unsafe IntPtr(int value) : this() {
			m_value = default;
		} // 0x0000000180026090-0x00000001800260A0
		// [ReliabilityContract] // 0x00000001800F1500-0x00000001800F1520
		public unsafe IntPtr(long value) : this() {
			m_value = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		// [CLSCompliant] // 0x00000001800F1630-0x00000001800F1670
		// [ReliabilityContract] // 0x00000001800F1630-0x00000001800F1670
		public unsafe IntPtr(void* value) : this() {
			m_value = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		private unsafe IntPtr(SerializationInfo info, StreamingContext context) : this() {
			m_value = default;
		} // 0x00000001800260A0-0x0000000180026240
	
		// Methods
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x0000000180025F80-0x0000000180026010
		public override bool Equals(object obj) => default; // 0x0000000180025EF0-0x0000000180025F80
		public override int GetHashCode() => default; // 0x000000018000B580-0x000000018000B590
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public int ToInt32() => default; // 0x000000018000B580-0x000000018000B590
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public long ToInt64() => default; // 0x0000000180026010-0x0000000180026020
		// [CLSCompliant] // 0x00000001800E4780-0x00000001800E47C0
		// [ReliabilityContract] // 0x00000001800E4780-0x00000001800E47C0
		public unsafe void* ToPointer() => default; // 0x0000000180002410-0x0000000180002420
		public override string ToString() => default; // 0x0000000180026020-0x0000000180026050
		public string ToString(string format) => default; // 0x0000000180026050-0x0000000180026090
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static bool operator ==(IntPtr value1, IntPtr value2) => default; // 0x00000001802A78A0-0x00000001802A78B0
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static bool operator !=(IntPtr value1, IntPtr value2) => default; // 0x00000001802A78C0-0x00000001802A7960
		// [ReliabilityContract] // 0x00000001800F1500-0x00000001800F1520
		public static explicit operator IntPtr(int value) => default; // 0x00000001806304D0-0x00000001806304E0
		// [ReliabilityContract] // 0x00000001800F1500-0x00000001800F1520
		public static explicit operator IntPtr(long value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		// [CLSCompliant] // 0x00000001800F1630-0x00000001800F1670
		// [ReliabilityContract] // 0x00000001800F1630-0x00000001800F1670
		public static unsafe explicit operator IntPtr(void* value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator int(IntPtr value) => default; // 0x0000000180322710-0x00000001803232A0
		public static explicit operator long(IntPtr value) => default; // 0x00000001802E9530-0x00000001802E9540
		// [CLSCompliant] // 0x00000001800D4E00-0x00000001800D4E20
		public static unsafe explicit operator void*(IntPtr value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		internal bool IsNull() => default; // 0x000000018000C630-0x000000018000C640
	}
}
