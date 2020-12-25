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
	public struct ProtectedString : IDisposable, ISerializationCallbackReceiver // TypeDefIndex: 5282
	{
		// Fields
		private static System.Random random; // 0x00
		private string securedValue; // 0x00
		private int randomSecret; // 0x08
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private string fakeValue; // 0x10
	
		// Properties
		internal string InternValue { get => default; set {} } // 0x0000000180002410-0x0000000180002420 0x000000018000A570-0x000000018000A580
		internal int RandomSecret { get => default; set {} } // 0x0000000180006CC0-0x0000000180006D60 0x0000000180008030-0x0000000180008060
		public string Value { get => default; } // 0x000000018004BB90-0x000000018004BC60 
		internal string Value_WithoutCheck { get => default; } // 0x000000018004BB80-0x000000018004BB90 
	
		// Constructors
		public ProtectedString(string _Value) : this() {
			securedValue = default;
			randomSecret = default;
			fakeValue = default;
		} // 0x000000018004BB70-0x000000018004BB80
		static ProtectedString() {
			random = default;
		} // 0x0000000180ADC4E0-0x0000000180ADC750
	
		// Methods
		private static string EncryptToUTF8(string str, int secret) => default; // 0x0000000180ADC280-0x0000000180ADC4E0
		private static string DecryptFromUTF8(string str, int secret) => default; // 0x0000000180ADC070-0x0000000180ADC280
		public void OnBeforeSerialize() {} // 0x000000018004BB00-0x000000018004BB30
		public void OnAfterDeserialize() {} // 0x000000018004BA60-0x000000018004BB00
		public static implicit operator ProtectedString(string _Value) => default; // 0x0000000180ADC7C0-0x0000000180ADC7F0
		public void Dispose() {} // 0x000000018004B910-0x000000018004B930
		public override string ToString() => default; // 0x000000018004BB30-0x000000018004BB70
		public static ProtectedString operator +(ProtectedString v1, ProtectedString v2) => default; // 0x0000000180ADC750-0x0000000180ADC7C0
		public override bool Equals(object obj) => default; // 0x000000018004B930-0x000000018004BA20
		public override int GetHashCode() => default; // 0x000000018004BA20-0x000000018004BA60
	}
}
