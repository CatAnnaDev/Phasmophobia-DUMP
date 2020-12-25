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
	public struct ProtectedInt32 : IDisposable, ISerializationCallbackReceiver // TypeDefIndex: 5280
	{
		// Fields
		private static System.Random random; // 0x00
		private int securedValue; // 0x00
		private int randomSecret; // 0x04
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private int fakeValue; // 0x08
	
		// Properties
		internal int InternValue { get => default; set {} } // 0x000000018000B580-0x000000018000B590 0x00000001800163C0-0x00000001800163D0
		internal int RandomSecret { get => default; set {} } // 0x0000000180022C20-0x0000000180022C30 0x0000000180022C60-0x0000000180022C70
		public int Value { get => default; } // 0x000000018004B470-0x000000018004B490 
		internal int Value_WithoutCheck { get => default; } // 0x000000018004B600-0x000000018004B610 
	
		// Constructors
		public ProtectedInt32(int value = 0 /* Metadata: 0x0064F64A */) : this() {
			securedValue = default;
			randomSecret = default;
			fakeValue = default;
		} // 0x000000018004B5F0-0x000000018004B600
		static ProtectedInt32() {
			random = default;
		} // 0x0000000180ADB5D0-0x0000000180ADB6D0
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018004B580-0x000000018004B5C0
		public void OnAfterDeserialize() {} // 0x000000018004B490-0x000000018004B580
		public static implicit operator ProtectedInt32(int _Value) => default; // 0x0000000180ADB740-0x0000000180ADB770
		public void Dispose() {} // 0x000000018004B360-0x000000018004B370
		public override string ToString() => default; // 0x000000018004B5C0-0x000000018004B5F0
		public static ProtectedInt32 operator +(ProtectedInt32 v1, ProtectedInt32 v2) => default; // 0x0000000180ADB6D0-0x0000000180ADB740
		public override bool Equals(object obj) => default; // 0x000000018004B370-0x000000018004B470
		public override int GetHashCode() => default; // 0x000000018004B470-0x000000018004B490
	}
}
