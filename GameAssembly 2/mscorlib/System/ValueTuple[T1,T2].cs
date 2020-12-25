/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	public struct ValueTuple<T1, T2> : IEquatable<System.ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<System.ValueTuple<T1, T2>> // TypeDefIndex: 118
	{
		// Fields
		public T1 Item1;
		public T2 Item2;
	
		// Constructors
		public ValueTuple(T1 item1, T2 item2) {
			Item1 = default;
			Item2 = default;
		}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(ValueTuple<T1, T2> other) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object other) => default;
		public int CompareTo(ValueTuple<T1, T2> other) => default;
		int IStructuralComparable.CompareTo(object other, IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		private int GetHashCodeCore(IEqualityComparer comparer) => default;
		public override string ToString() => default;
	}
}
