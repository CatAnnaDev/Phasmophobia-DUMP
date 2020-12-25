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
	[Serializable]
	[DebuggerStepThrough] // 0x00000001800D4E50-0x00000001800D4E60
	public struct Nullable<T> // TypeDefIndex: 371
		where T : struct
	{
		// Fields
		internal T value;
		internal bool has_value;
	
		// Properties
		public bool HasValue { get => default; }
		public T Value { get => default; }
	
		// Constructors
		public Nullable(T value) : this() {
			this.value = default;
			has_value = default;
		}
	
		// Methods
		public override bool Equals(object other) => default;
		private bool Equals(T? other) => default;
		public override int GetHashCode() => default;
		public T GetValueOrDefault() => default;
		public T GetValueOrDefault(T defaultValue) => default;
		public override string ToString() => default;
		private static object Box(T? o) => default;
		private static T? Unbox(object o) => default;
	}
}
