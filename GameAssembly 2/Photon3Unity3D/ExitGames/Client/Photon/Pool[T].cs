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
	public class Pool<T> // TypeDefIndex: 4310
		where T : class
	{
		// Fields
		private readonly Func<T> createFunction;
		private readonly Queue<T> pool;
		private readonly Action<T> resetFunction;
	
		// Properties
		public int Count { get => default; }
	
		// Constructors
		public Pool() {} // Dummy constructor
		public Pool(Func<T> createFunction, Action<T> resetFunction, int poolCapacity) {}
		public Pool(Func<T> createFunction, int poolCapacity) {}
	
		// Methods
		private void CreatePoolItems(int numItems) {}
		[Obsolete] // 0x00000001800F2560-0x00000001800F2590
		public void Push(T item) {}
		public void Release(T item) {}
		[Obsolete] // 0x00000001800F25F0-0x00000001800F2620
		public T Pop() => default;
		public T Acquire() => default;
	}
}
