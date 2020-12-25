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
	public struct ProtectedUInt16 : IDisposable, ISerializationCallbackReceiver // TypeDefIndex: 5283
	{
		// Fields
		private static System.Random random; // 0x00
		private ushort securedValue; // 0x00
		private ushort randomSecret; // 0x02
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private ushort fakeValue; // 0x04
	
		// Properties
		public ushort Value { get => default; } // 0x000000018004B330-0x000000018004B360 
	
		// Constructors
		public ProtectedUInt16(ushort value = 0 /* Metadata: 0x0064F656 */) : this() {
			securedValue = default;
			randomSecret = default;
			fakeValue = default;
		} // 0x000000018004BEA0-0x000000018004BEB0
		private ProtectedUInt16(int value = 0 /* Metadata: 0x0064F658 */) : this() {
			securedValue = default;
			randomSecret = default;
			fakeValue = default;
		} // 0x000000018004BE90-0x000000018004BEA0
		static ProtectedUInt16() {
			random = default;
		} // 0x0000000180ADC7F0-0x0000000180ADC8F0
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018004B290-0x000000018004B2D0
		public void OnAfterDeserialize() {} // 0x000000018004BD60-0x000000018004BE50
		public static implicit operator ProtectedUInt16(ushort _Value) => default; // 0x0000000180ADC960-0x0000000180ADC990
		public void Dispose() {} // 0x000000018004B060-0x000000018004B070
		public override string ToString() => default; // 0x000000018004BE50-0x000000018004BE90
		public static ProtectedUInt16 operator +(ProtectedUInt16 v1, ProtectedUInt16 v2) => default; // 0x0000000180ADC8F0-0x0000000180ADC960
		public override bool Equals(object obj) => default; // 0x000000018004BC60-0x000000018004BD60
		public override int GetHashCode() => default; // 0x000000018004B330-0x000000018004B360
	}
}
