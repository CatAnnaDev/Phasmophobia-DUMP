/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	public struct ArraySegment<T> : IList<T>, IReadOnlyList<T> // TypeDefIndex: 160
	{
		// Fields
		private T[] _array;
		private int _offset;
		private int _count;
	
		// Properties
		public T[] Array { get => default; }
		public int Offset { get => default; }
		public int Count { get => default; }
		T IList<T>.this[int index] { get => default; set {} }
		T IReadOnlyList<T>.this[int index] { get => default; }
		bool ICollection<T>.IsReadOnly { get => default; }
	
		// Nested types
		[Serializable]
		private sealed class ArraySegmentEnumerator : IEnumerator<T> // TypeDefIndex: 161
		{
			// Fields
			private T[] _array;
			private int _start;
			private int _end;
			private int _current;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public ArraySegmentEnumerator() {} // Dummy constructor
			internal ArraySegmentEnumerator(ArraySegment<T> arraySegment) {}
	
			// Methods
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
			public void Dispose() {}
		}
	
		// Constructors
		public ArraySegment(T[] array) : this() {
			_array = default;
			_offset = default;
			_count = default;
		}
		public ArraySegment(T[] array, int offset, int count) : this() {
			_array = default;
			_offset = default;
			_count = default;
		}
	
		// Methods
		public override int GetHashCode() => default;
		public override bool Equals(object obj) => default;
		public bool Equals(ArraySegment<T> obj) => default;
		int IList<T>.IndexOf(T item) => default;
		void IList<T>.Insert(int index, T item) {}
		void IList<T>.RemoveAt(int index) {}
		void ICollection<T>.Add(T item) {}
		void ICollection<T>.Clear() {}
		bool ICollection<T>.Contains(T item) => default;
		void ICollection<T>.CopyTo(T[] array, int arrayIndex) {}
		bool ICollection<T>.Remove(T item) => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
