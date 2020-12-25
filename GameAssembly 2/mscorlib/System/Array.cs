/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	public abstract class Array : IList, IStructuralComparable, IStructuralEquatable, ICloneable // TypeDefIndex: 119
	{
		// Properties
		int ICollection.Count { get; } // 0x00000001807083A0-0x0000000180708400 
		bool IList.IsReadOnly { get; } // 0x0000000180250A70-0x0000000180250A80 
		object IList.this[int index] { get => default; set {} } // 0x000000018070A120-0x000000018070A130 0x000000018070A130-0x000000018070A150
		public long LongLength { get; } // 0x000000018070A710-0x000000018070A780 
		public bool IsFixedSize { get; } // 0x0000000180246BB0-0x0000000180246BC0 
		public bool IsReadOnly { get; } // 0x0000000180250A70-0x0000000180250A80 
		public bool IsSynchronized { get; } // 0x0000000180250A70-0x0000000180250A80 
		public object SyncRoot { get; } // 0x00000001802A78B0-0x00000001802A78C0 
		public int Length { /* [ReliabilityContract] */ /* 0x00000001800DF1C0-0x00000001800DF1E0 */ get; } // 0x00000001807083A0-0x0000000180708400 
		public int Rank { /* [ReliabilityContract] */ /* 0x00000001800DF1C0-0x00000001800DF1E0 */ get; } // 0x0000000180707670-0x0000000180707680 
	
		// Nested types
		private sealed class ArrayEnumerator : IEnumerator, ICloneable // TypeDefIndex: 120
		{
			// Fields
			private Array _array; // 0x10
			private int _index; // 0x18
			private int _endIndex; // 0x1C
	
			// Properties
			public object Current { get => default; } // 0x0000000180703830-0x0000000180703960 
	
			// Constructors
			public ArrayEnumerator() {} // Dummy constructor
			internal ArrayEnumerator(Array array) {} // 0x0000000180703790-0x0000000180703830
	
			// Methods
			public bool MoveNext() => default; // 0x0000000180703770-0x0000000180703790
			public void Reset() {} // 0x0000000180245710-0x0000000180245720
			public object Clone() => default; // 0x00000001802908F0-0x0000000180290900
		}
	
		internal struct InternalEnumerator<T> : IEnumerator<T> // TypeDefIndex: 121
		{
			// Fields
			private readonly Array array;
			private int idx;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			internal InternalEnumerator(Array array) : this() {
				this.array = default;
				idx = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		internal class EmptyInternalEnumerator<T> : IEnumerator<T> // TypeDefIndex: 122
		{
			// Fields
			public static readonly EmptyInternalEnumerator<T> Value;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public EmptyInternalEnumerator() {}
			static EmptyInternalEnumerator() {}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		private struct SorterObjectArray // TypeDefIndex: 123
		{
			// Fields
			private object[] keys; // 0x00
			private object[] items; // 0x08
			private IComparer comparer; // 0x10
	
			// Constructors
			internal SorterObjectArray(object[] keys, object[] items, IComparer comparer) {
				this.keys = default;
				this.items = default;
				this.comparer = default;
			} // 0x0000000180029800-0x00000001800298F0
	
			// Methods
			internal void SwapIfGreaterWithItems(int a, int b) {} // 0x00000001800297E0-0x00000001800297F0
			private void Swap(int i, int j) {} // 0x00000001800297F0-0x0000000180029800
			internal void Sort(int left, int length) {} // 0x00000001800297D0-0x00000001800297E0
			private void IntrospectiveSort(int left, int length) {} // 0x00000001800297B0-0x00000001800297C0
			private void IntroSort(int lo, int hi, int depthLimit) {} // 0x00000001800297A0-0x00000001800297B0
			private int PickPivotAndPartition(int lo, int hi) => default; // 0x00000001800297C0-0x00000001800297D0
			private void Heapsort(int lo, int hi) {} // 0x0000000180029780-0x0000000180029790
			private void DownHeap(int i, int n, int lo) {} // 0x0000000180029770-0x0000000180029780
			private void InsertionSort(int lo, int hi) {} // 0x0000000180029790-0x00000001800297A0
		}
	
		private struct SorterGenericArray // TypeDefIndex: 124
		{
			// Fields
			private Array keys; // 0x00
			private Array items; // 0x08
			private IComparer comparer; // 0x10
	
			// Constructors
			internal SorterGenericArray(Array keys, Array items, IComparer comparer) {
				this.keys = default;
				this.items = default;
				this.comparer = default;
			} // 0x0000000180029740-0x0000000180029770
	
			// Methods
			internal void SwapIfGreaterWithItems(int a, int b) {} // 0x0000000180029720-0x0000000180029730
			private void Swap(int i, int j) {} // 0x0000000180029730-0x0000000180029740
			internal void Sort(int left, int length) {} // 0x0000000180029710-0x0000000180029720
			private void IntrospectiveSort(int left, int length) {} // 0x00000001800296F0-0x0000000180029700
			private void IntroSort(int lo, int hi, int depthLimit) {} // 0x00000001800296E0-0x00000001800296F0
			private int PickPivotAndPartition(int lo, int hi) => default; // 0x0000000180029700-0x0000000180029710
			private void Heapsort(int lo, int hi) {} // 0x00000001800296C0-0x00000001800296D0
			private void DownHeap(int i, int n, int lo) {} // 0x00000001800296B0-0x00000001800296C0
			private void InsertionSort(int lo, int hi) {} // 0x00000001800296D0-0x00000001800296E0
		}
	
		// Constructors
		private Array() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		public static Array CreateInstance(Type elementType, params /* 0x00000001800D4E50-0x00000001800D4E60 */ long[] lengths) => default; // 0x0000000180706B10-0x0000000180706C80
		public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array) => default;
		public static void Resize<T>(ref T[] array, int newSize) {}
		int IList.Add(object value) => default; // 0x0000000180709EF0-0x0000000180709F50
		bool IList.Contains(object value) => default; // 0x0000000180709FD0-0x0000000180709FF0
		void IList.Clear() {} // 0x0000000180709F50-0x0000000180709FD0
		int IList.IndexOf(object value) => default; // 0x0000000180709FF0-0x000000018070A000
		void IList.Insert(int index, object value) {} // 0x000000018070A000-0x000000018070A060
		void IList.Remove(object value) {} // 0x000000018070A0C0-0x000000018070A120
		void IList.RemoveAt(int index) {} // 0x000000018070A060-0x000000018070A0C0
		public void CopyTo(Array array, int index) {} // 0x00000001807061E0-0x00000001807062F0
		public object Clone() => default; // 0x00000001802908F0-0x0000000180290900
		int IStructuralComparable.CompareTo(object other, IComparer comparer) => default; // 0x000000018070A150-0x000000018070A380
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default; // 0x000000018070A380-0x000000018070A520
		internal static int CombineHashCodes(int h1, int h2) => default; // 0x00000001804A70B0-0x00000001804A70C0
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default; // 0x000000018070A520-0x000000018070A6F0
		public static int BinarySearch(Array array, object value) => default; // 0x00000001807059D0-0x0000000180705AD0
		public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter) => default;
		public static void Copy(Array sourceArray, Array destinationArray, long length) {} // 0x00000001807062F0-0x0000000180706390
		public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length) {} // 0x0000000180706930-0x0000000180706A80
		public void CopyTo(Array array, long index) {} // 0x0000000180706140-0x00000001807061E0
		public static void ForEach<T>(T[] array, Action<T> action) {}
		public long GetLongLength(int dimension) => default; // 0x0000000180707640-0x0000000180707650
		public object GetValue(long index) => default; // 0x0000000180707C50-0x0000000180707CE0
		public object GetValue(long index1, long index2) => default; // 0x0000000180707D80-0x0000000180707ED0
		public object GetValue(long index1, long index2, long index3) => default; // 0x0000000180707850-0x0000000180707A10
		public object GetValue(params /* 0x00000001800D4E50-0x00000001800D4E60 */ long[] indices) => default; // 0x00000001807076E0-0x0000000180707850
		public static int BinarySearch(Array array, int index, int length, object value) => default; // 0x0000000180705BD0-0x0000000180705BF0
		public static int BinarySearch(Array array, object value, IComparer comparer) => default; // 0x0000000180705AD0-0x0000000180705BD0
		public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer) => default; // 0x0000000180705BF0-0x0000000180705F00
		private static int GetMedian(int low, int hi) => default; // 0x0000000180707660-0x0000000180707670
		public static int BinarySearch<T>(T[] array, T value) => default;
		public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer) => default;
		public static int BinarySearch<T>(T[] array, int index, int length, T value) => default;
		public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer) => default;
		public static int IndexOf(Array array, object value) => default; // 0x0000000180708150-0x0000000180708240
		public static int IndexOf(Array array, object value, int startIndex) => default; // 0x0000000180708240-0x0000000180708340
		public static int IndexOf(Array array, object value, int startIndex, int count) => default; // 0x0000000180707ED0-0x0000000180708150
		public static int IndexOf<T>(T[] array, T value) => default;
		public static int IndexOf<T>(T[] array, T value, int startIndex) => default;
		public static int IndexOf<T>(T[] array, T value, int startIndex, int count) => default;
		public static int LastIndexOf(Array array, object value) => default; // 0x0000000180708460-0x0000000180708580
		public static int LastIndexOf(Array array, object value, int startIndex) => default; // 0x0000000180708870-0x0000000180708910
		public static int LastIndexOf(Array array, object value, int startIndex, int count) => default; // 0x0000000180708580-0x0000000180708870
		public static int LastIndexOf<T>(T[] array, T value) => default;
		public static int LastIndexOf<T>(T[] array, T value, int startIndex) => default;
		public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count) => default;
		public static void Reverse(Array array) {} // 0x0000000180708C20-0x0000000180708D00
		public static void Reverse(Array array, int index, int length) {} // 0x0000000180708910-0x0000000180708C20
		public static void Reverse<T>(T[] array) {}
		public static void Reverse<T>(T[] array, int index, int length) {}
		public void SetValue(object value, long index) {} // 0x00000001807092F0-0x0000000180709390
		public void SetValue(object value, long index1, long index2) {} // 0x0000000180709390-0x00000001807094F0
		public void SetValue(object value, long index1, long index2, long index3) {} // 0x0000000180709110-0x00000001807092F0
		public void SetValue(object value, params /* 0x00000001800D4E50-0x00000001800D4E60 */ long[] indices) {} // 0x0000000180708D20-0x0000000180708EA0
		public static void Sort(Array array) {} // 0x0000000180709860-0x0000000180709940
		public static void Sort(Array array, int index, int length) {} // 0x0000000180709730-0x0000000180709760
		public static void Sort(Array array, IComparer comparer) {} // 0x0000000180709DC0-0x0000000180709EC0
		public static void Sort(Array array, int index, int length, IComparer comparer) {} // 0x0000000180709EC0-0x0000000180709EF0
		public static void Sort(Array keys, Array items) {} // 0x0000000180709CA0-0x0000000180709DA0
		public static void Sort(Array keys, Array items, IComparer comparer) {} // 0x0000000180709760-0x0000000180709860
		public static void Sort(Array keys, Array items, int index, int length) {} // 0x0000000180709DA0-0x0000000180709DC0
		public static void Sort(Array keys, Array items, int index, int length, IComparer comparer) {} // 0x0000000180709940-0x0000000180709CA0
		public static void Sort<T>(T[] array) {}
		public static void Sort<T>(T[] array, int index, int length) {}
		public static void Sort<T>(T[] array, IComparer<T> comparer) {}
		public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer) {}
		public static void Sort<T>(T[] array, Comparison<T> comparison) {}
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items) {}
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length) {}
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer) {}
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer) {}
		public static bool Exists<T>(T[] array, Predicate<T> match) => default;
		public static void Fill<T>(T[] array, T value) {}
		public static void Fill<T>(T[] array, T value, int startIndex, int count) {}
		public static T Find<T>(T[] array, Predicate<T> match) => default;
		public static T[] FindAll<T>(T[] array, Predicate<T> match) => default;
		public static int FindIndex<T>(T[] array, Predicate<T> match) => default;
		public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match) => default;
		public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) => default;
		public static T FindLast<T>(T[] array, Predicate<T> match) => default;
		public static int FindLastIndex<T>(T[] array, Predicate<T> match) => default;
		public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match) => default;
		public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) => default;
		public static bool TrueForAll<T>(T[] array, Predicate<T> match) => default;
		public IEnumerator GetEnumerator() => default; // 0x0000000180707570-0x0000000180707630
		internal int InternalArray__ICollection_get_Count() => default; // 0x00000001807083A0-0x0000000180708400
		internal bool InternalArray__ICollection_get_IsReadOnly() => default; // 0x0000000180246BB0-0x0000000180246BC0
		internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>() => default;
		internal void InternalArray__ICollection_Clear() {} // 0x0000000180708340-0x00000001807083A0
		internal void InternalArray__ICollection_Add<T>(T item) {}
		internal bool InternalArray__ICollection_Remove<T>(T item) => default;
		internal bool InternalArray__ICollection_Contains<T>(T item) => default;
		internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex) {}
		internal T InternalArray__IReadOnlyList_get_Item<T>(int index) => default;
		internal int InternalArray__IReadOnlyCollection_get_Count() => default; // 0x00000001807083A0-0x0000000180708400
		internal void InternalArray__Insert<T>(int index, T item) {}
		internal void InternalArray__RemoveAt(int index) {} // 0x0000000180708400-0x0000000180708460
		internal int InternalArray__IndexOf<T>(T item) => default;
		internal T InternalArray__get_Item<T>(int index) => default;
		internal void InternalArray__set_Item<T>(int index, T item) {}
		internal void GetGenericValueImpl<T>(int pos, out T value) {
			value = default;
		}
		internal void SetGenericValueImpl<T>(int pos, ref T value) {}
		private int GetRank() => default; // 0x0000000180707670-0x0000000180707680
		public int GetLength(int dimension) => default; // 0x0000000180707630-0x0000000180707640
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public int GetLowerBound(int dimension) => default; // 0x0000000180707650-0x0000000180707660
		public object GetValue(params /* 0x00000001800D4E50-0x00000001800D4E60 */ int[] indices) => default; // 0x00000001807076D0-0x00000001807076E0
		public void SetValue(object value, params /* 0x00000001800D4E50-0x00000001800D4E60 */ int[] indices) {} // 0x0000000180708D10-0x0000000180708D20
		internal object GetValueImpl(int pos) => default; // 0x00000001807076C0-0x00000001807076D0
		internal void SetValueImpl(object value, int pos) {} // 0x0000000180708D00-0x0000000180708D10
		internal static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length) => default; // 0x0000000180707560-0x0000000180707570
		internal static Array CreateInstanceImpl(Type elementType, int[] lengths, int[] bounds) => default; // 0x0000000180706B00-0x0000000180706B10
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public int GetUpperBound(int dimension) => default; // 0x0000000180707680-0x00000001807076C0
		public object GetValue(int index) => default; // 0x0000000180707A10-0x0000000180707B90
		public object GetValue(int index1, int index2) => default; // 0x0000000180707CE0-0x0000000180707D80
		public object GetValue(int index1, int index2, int index3) => default; // 0x0000000180707B90-0x0000000180707C50
		public void SetValue(object value, int index) {} // 0x0000000180708F70-0x0000000180709110
		public void SetValue(object value, int index1, int index2) {} // 0x00000001807094F0-0x00000001807095A0
		public void SetValue(object value, int index1, int index2, int index3) {} // 0x0000000180708EA0-0x0000000180708F70
		internal static Array UnsafeCreateInstance(Type elementType, int[] lengths, int[] lowerBounds) => default; // 0x000000018070A6F0-0x000000018070A700
		internal static Array UnsafeCreateInstance(Type elementType, int length1, int length2) => default; // 0x0000000180706C80-0x0000000180706D20
		internal static Array UnsafeCreateInstance(Type elementType, params /* 0x00000001800D4E50-0x00000001800D4E60 */ int[] lengths) => default; // 0x000000018070A700-0x000000018070A710
		public static Array CreateInstance(Type elementType, int length) => default; // 0x00000001807074E0-0x0000000180707560
		public static Array CreateInstance(Type elementType, int length1, int length2) => default; // 0x0000000180706C80-0x0000000180706D20
		public static Array CreateInstance(Type elementType, int length1, int length2, int length3) => default; // 0x0000000180707180-0x0000000180707250
		public static Array CreateInstance(Type elementType, params /* 0x00000001800D4E50-0x00000001800D4E60 */ int[] lengths) => default; // 0x0000000180707250-0x00000001807074E0
		public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds) => default; // 0x0000000180706D20-0x0000000180707180
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static void Clear(Array array, int index, int length) {} // 0x0000000180705FE0-0x0000000180706130
		private static void ClearInternal(Array a, int index, int count) {} // 0x0000000180705FD0-0x0000000180705FE0
		// [ReliabilityContract] // 0x00000001800F1500-0x00000001800F1520
		public static void Copy(Array sourceArray, Array destinationArray, int length) {} // 0x0000000180706390-0x0000000180706480
		// [ReliabilityContract] // 0x00000001800F1500-0x00000001800F1520
		public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) {} // 0x0000000180706480-0x0000000180706930
		private static Exception CreateArrayTypeMismatchException() => default; // 0x0000000180706A80-0x0000000180706B00
		private static bool CanAssignArrayElement(Type source, Type target) => default; // 0x0000000180705F00-0x0000000180705FD0
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) {} // 0x0000000180706130-0x0000000180706140
		public static T[] Empty<T>() => default;
		public void Initialize() {} // 0x0000000180246DB0-0x0000000180246DC0
		private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count) => default;
		private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count) => default;
		private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer) {} // 0x00000001807095A0-0x0000000180709730
		internal static T UnsafeLoad<T>(T[] array, int index) => default;
		internal static void UnsafeStore<T>(T[] array, int index, T value) {}
		internal static R UnsafeMov<S, R>(S instance) => default;
	}
}
