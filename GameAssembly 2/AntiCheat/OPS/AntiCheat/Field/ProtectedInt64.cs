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
	public struct ProtectedInt64 : IDisposable, ISerializationCallbackReceiver // TypeDefIndex: 5281
	{
		// Fields
		private static System.Random random; // 0x00
		private long securedValue; // 0x00
		private long randomSecret; // 0x08
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private long fakeValue; // 0x10
	
		// Properties
		public long Value { get => default; } // 0x000000018004B8E0-0x000000018004B910 
	
		// Constructors
		public ProtectedInt64(long value = 0 /* Metadata: 0x0064F64E */) : this() {
			securedValue = default;
			randomSecret = default;
			fakeValue = default;
		} // 0x000000018004B8D0-0x000000018004B8E0
		static ProtectedInt64() {
			random = default;
		} // 0x0000000180ADB770-0x0000000180ADB870
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018004B850-0x000000018004B890
		public void OnAfterDeserialize() {} // 0x000000018004B750-0x000000018004B850
		public static implicit operator ProtectedInt64(long _Value) => default; // 0x0000000180ADB8F0-0x0000000180ADB920
		public void Dispose() {} // 0x000000018004B610-0x000000018004B620
		public override string ToString() => default; // 0x000000018004B890-0x000000018004B8D0
		public static ProtectedInt64 operator +(ProtectedInt64 v1, ProtectedInt64 v2) => default; // 0x0000000180ADB870-0x0000000180ADB8F0
		public override bool Equals(object obj) => default; // 0x000000018004B620-0x000000018004B720
		public override int GetHashCode() => default; // 0x000000018004B720-0x000000018004B750
	}
}
