/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	internal struct ParamsArray // TypeDefIndex: 277
	{
		// Fields
		private static readonly object[] oneArgArray; // 0x00
		private static readonly object[] twoArgArray; // 0x08
		private static readonly object[] threeArgArray; // 0x10
		private readonly object arg0; // 0x00
		private readonly object arg1; // 0x08
		private readonly object arg2; // 0x10
		private readonly object[] args; // 0x18
	
		// Properties
		public int Length { get => default; } // 0x00000001800272B0-0x00000001800272F0 
		public object this[int index] { get => default; } // 0x0000000180027250-0x00000001800272B0 
	
		// Constructors
		public ParamsArray(object arg0) : this() {
			this.arg0 = default;
			arg1 = default;
			arg2 = default;
			args = default;
		} // 0x0000000180027010-0x00000001800270B0
		public ParamsArray(object arg0, object arg1) : this() {
			this.arg0 = default;
			this.arg1 = default;
			arg2 = default;
			args = default;
		} // 0x0000000180027190-0x0000000180027250
		public ParamsArray(object arg0, object arg1, object arg2) : this() {
			this.arg0 = default;
			this.arg1 = default;
			this.arg2 = default;
			args = default;
		} // 0x0000000180026F50-0x0000000180027010
		public ParamsArray(object[] args) : this() {
			arg0 = default;
			arg1 = default;
			arg2 = default;
			this.args = default;
		} // 0x00000001800270B0-0x0000000180027190
		static ParamsArray() {
			oneArgArray = default;
			twoArgArray = default;
			threeArgArray = default;
		} // 0x000000018068FB80-0x000000018068FF80
	
		// Methods
		private object GetAtSlow(int index) => default; // 0x0000000180026EF0-0x0000000180026F50
	}
}
