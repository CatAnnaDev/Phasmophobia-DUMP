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
	public struct ProtectedInt16 : IDisposable, ISerializationCallbackReceiver // TypeDefIndex: 5279
	{
		// Fields
		private static System.Random random; // 0x00
		private short securedValue; // 0x00
		private short randomSecret; // 0x02
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private short fakeValue; // 0x04
	
		// Properties
		public short Value { get => default; } // 0x000000018004B330-0x000000018004B360 
	
		// Constructors
		public ProtectedInt16(short value = 0 /* Metadata: 0x0064F644 */) : this() {
			securedValue = default;
			randomSecret = default;
			fakeValue = default;
		} // 0x000000018004B310-0x000000018004B320
		private ProtectedInt16(int value = 0 /* Metadata: 0x0064F646 */) : this() {
			securedValue = default;
			randomSecret = default;
			fakeValue = default;
		} // 0x000000018004B320-0x000000018004B330
		static ProtectedInt16() {
			random = default;
		} // 0x0000000180ADB430-0x0000000180ADB530
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018004B290-0x000000018004B2D0
		public void OnAfterDeserialize() {} // 0x000000018004B1A0-0x000000018004B290
		public static implicit operator ProtectedInt16(short _Value) => default; // 0x0000000180ADB5A0-0x0000000180ADB5D0
		public void Dispose() {} // 0x000000018004B060-0x000000018004B070
		public override string ToString() => default; // 0x000000018004B2D0-0x000000018004B310
		public static ProtectedInt16 operator +(ProtectedInt16 v1, ProtectedInt16 v2) => default; // 0x0000000180ADB530-0x0000000180ADB5A0
		public override bool Equals(object obj) => default; // 0x000000018004B070-0x000000018004B170
		public override int GetHashCode() => default; // 0x000000018004B170-0x000000018004B1A0
	}
}
