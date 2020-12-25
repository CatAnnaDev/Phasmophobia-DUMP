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
	public struct ProtectedUInt64 : IDisposable, ISerializationCallbackReceiver // TypeDefIndex: 5285
	{
		// Fields
		private static System.Random random; // 0x00
		private ulong securedValue; // 0x00
		private ulong randomSecret; // 0x08
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private ulong fakeValue; // 0x10
	
		// Properties
		public ulong Value { get => default; } // 0x000000018004B8E0-0x000000018004B910 
	
		// Constructors
		public ProtectedUInt64(ulong value = 0 /* Metadata: 0x0064F660 */) : this() {
			securedValue = default;
			randomSecret = default;
			fakeValue = default;
		} // 0x000000018004C360-0x000000018004C370
		static ProtectedUInt64() {
			random = default;
		} // 0x0000000180ADCB30-0x0000000180ADCC30
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018004B850-0x000000018004B890
		public void OnAfterDeserialize() {} // 0x000000018004C220-0x000000018004C320
		public static implicit operator ProtectedUInt64(ulong _Value) => default; // 0x0000000180ADCCB0-0x0000000180ADCCE0
		public void Dispose() {} // 0x000000018004B610-0x000000018004B620
		public override string ToString() => default; // 0x000000018004C320-0x000000018004C360
		public static ProtectedUInt64 operator +(ProtectedUInt64 v1, ProtectedUInt64 v2) => default; // 0x0000000180ADCC30-0x0000000180ADCCB0
		public override bool Equals(object obj) => default; // 0x000000018004C110-0x000000018004C220
		public override int GetHashCode() => default; // 0x000000018004B720-0x000000018004B750
	}
}
