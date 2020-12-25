/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 49: AntiCheat.dll - Assembly: AntiCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5277-5290

namespace OPS.AntiCheat.Field
{
	[Serializable]
	public struct ProtectedUInt32 : IDisposable, ISerializationCallbackReceiver // TypeDefIndex: 5284
	{
		// Fields
		private static System.Random random; // 0x00
		private uint securedValue; // 0x00
		private uint randomSecret; // 0x04
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private uint fakeValue; // 0x08
	
		// Properties
		public uint Value { get => default; } // 0x000000018004B470-0x000000018004B490 
	
		// Constructors
		public ProtectedUInt32(uint value = 0 /* Metadata: 0x0064F65C */) : this() {
			securedValue = default;
			randomSecret = default;
			fakeValue = default;
		} // 0x000000018004C100-0x000000018004C110
		static ProtectedUInt32() {
			random = default;
		} // 0x0000000180ADC990-0x0000000180ADCA90
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018004B580-0x000000018004B5C0
		public void OnAfterDeserialize() {} // 0x000000018004BFE0-0x000000018004C0D0
		public static implicit operator ProtectedUInt32(uint _Value) => default; // 0x0000000180ADCB00-0x0000000180ADCB30
		public void Dispose() {} // 0x000000018004B360-0x000000018004B370
		public override string ToString() => default; // 0x000000018004C0D0-0x000000018004C100
		public static ProtectedUInt32 operator +(ProtectedUInt32 v1, ProtectedUInt32 v2) => default; // 0x0000000180ADCA90-0x0000000180ADCB00
		public override bool Equals(object obj) => default; // 0x000000018004BEB0-0x000000018004BFB0
		public override int GetHashCode() => default; // 0x000000018004BFB0-0x000000018004BFE0
	}
}
