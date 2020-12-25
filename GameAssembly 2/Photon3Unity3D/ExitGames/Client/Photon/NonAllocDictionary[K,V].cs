/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class NonAllocDictionary<K, V> // TypeDefIndex: 4244
		where K : IEquatable<K>
	{
		// Fields
		private static uint[] _primeTableUInt;
		private int _freeHead;
		private int _freeCount;
		private int _usedCount;
		private uint _capacity;
		private int[] _buckets;
		private Node[] _nodes;
	
		// Properties
		public KeyIterator Keys { get => default; }
		public ValueIterator Values { get => default; }
		public int Count { get => default; }
		public uint Capacity { get => default; }
		public V this[K key] { get => default; set {} }
	
		// Nested types
		public struct KeyIterator // TypeDefIndex: 4245
		{
			// Fields
			private int _index;
			private NonAllocDictionary<K, V> _dict;
	
			// Properties
			public K Current { get => default; }
	
			// Constructors
			public KeyIterator(NonAllocDictionary<K, V> dictionary) : this() {
				_index = default;
				_dict = default;
			}
	
			// Methods
			public KeyIterator<K, V> GetEnumerator() => default;
			public bool MoveNext() => default;
		}
	
		public struct ValueIterator // TypeDefIndex: 4246
		{
			// Fields
			private int _index;
			private NonAllocDictionary<K, V> _dict;
	
			// Properties
			public V Current { get => default; }
	
			// Constructors
			public ValueIterator(NonAllocDictionary<K, V> dictionary) : this() {
				_index = default;
				_dict = default;
			}
	
			// Methods
			public ValueIterator<K, V> GetEnumerator() => default;
			public bool MoveNext() => default;
		}
	
		public struct PairIterator // TypeDefIndex: 4247
		{
			// Fields
			private int _index;
			private NonAllocDictionary<K, V> _dict;
	
			// Properties
			public KeyValuePair<K, V> Current { get => default; }
	
			// Constructors
			public PairIterator(NonAllocDictionary<K, V> dictionary) : this() {
				_index = default;
				_dict = default;
			}
	
			// Methods
			public bool MoveNext() => default;
		}
	
		private struct Node // TypeDefIndex: 4248
		{
			// Fields
			public bool Used;
			public int Next;
			public uint Hash;
			public K Key;
			public V Val;
		}
	
		// Constructors
		public NonAllocDictionary() {} // Dummy constructor
		public NonAllocDictionary(uint capacity = 29 /* Metadata: 0x0064D570 */) {}
		static NonAllocDictionary() {}
	
		// Methods
		public bool ContainsKey(K key) => default;
		public bool TryGetValue(K key, out V val) {
			val = default;
			return default;
		}
		public void Set(K key, V val) {}
		public void Add(K key, V val) {}
		public bool Remove(K key) => default;
		public PairIterator GetEnumerator() => default;
		private int FindNode(K key) => default;
		private void Insert(K key, V val) {}
		private void Expand() {}
		public void Clear() {}
		private static bool IsPrimeFromList(uint value) => default;
		private static uint GetNextPrime(uint value) => default;
		private static void Assert(bool condition) {}
	}
}
