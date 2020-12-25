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
using System.Text;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal // TypeDefIndex: 127
	{
		// Fields
		private readonly T1 m_Item1;
		private readonly T2 m_Item2;
	
		// Properties
		public T1 Item1 { get => default; }
		public T2 Item2 { get => default; }
	
		// Constructors
		public Tuple() {} // Dummy constructor
		public Tuple(T1 item1, T2 item2) {}
	
		// Methods
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, IComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		public override string ToString() => default;
		string ITupleInternal.ToString(StringBuilder sb) => default;
	}
}
