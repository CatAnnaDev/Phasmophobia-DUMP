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
	public struct ProtectedFloat : IDisposable, ISerializationCallbackReceiver // TypeDefIndex: 5278
	{
		// Fields
		private static System.Random random; // 0x00
		private UIntFloat securedValue; // 0x00
		private UIntFloat manager; // 0x04
		private uint randomSecret; // 0x08
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private float fakeValue; // 0x0C
	
		// Properties
		internal UIntFloat InternValue { get => default; set {} } // 0x000000018000B580-0x000000018000B590 0x00000001800163C0-0x00000001800163D0
		internal uint RandomSecret { get => default; set {} } // 0x0000000180006CC0-0x0000000180006D60 0x0000000180008030-0x0000000180008060
		public float Value { get => default; } // 0x000000018004B020-0x000000018004B060 
		internal float Value_WithoutCheck { get => default; } // 0x000000018004B010-0x000000018004B020 
	
		// Constructors
		public ProtectedFloat(float value = 0f /* Metadata: 0x0064F640 */) : this() {
			securedValue = default;
			manager = default;
			randomSecret = default;
			fakeValue = default;
		} // 0x000000018004B000-0x000000018004B010
		static ProtectedFloat() {
			random = default;
		} // 0x0000000180ADB260-0x0000000180ADB370
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018004AF60-0x000000018004AFB0
		public void OnAfterDeserialize() {} // 0x000000018004AE50-0x000000018004AF60
		public static implicit operator ProtectedFloat(float _Value) => default; // 0x0000000180ADB400-0x0000000180ADB430
		public void Dispose() {} // 0x000000018004ACF0-0x000000018004AD00
		public override string ToString() => default; // 0x000000018004AFB0-0x000000018004B000
		public static ProtectedFloat operator +(ProtectedFloat v1, ProtectedFloat v2) => default; // 0x0000000180ADB370-0x0000000180ADB400
		public override bool Equals(object obj) => default; // 0x000000018004AD00-0x000000018004AE40
		public override int GetHashCode() => default; // 0x000000018004AE40-0x000000018004AE50
	}
}
