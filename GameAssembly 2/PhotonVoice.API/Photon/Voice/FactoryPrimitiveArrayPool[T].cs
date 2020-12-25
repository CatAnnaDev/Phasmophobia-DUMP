/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class FactoryPrimitiveArrayPool<T> : ObjectFactory<T[], int> // TypeDefIndex: 4642
	{
		// Fields
		private PrimitiveArrayPool<T> pool;
	
		// Properties
		public int Info { get => default; }
	
		// Constructors
		public FactoryPrimitiveArrayPool() {} // Dummy constructor
		public FactoryPrimitiveArrayPool(int capacity, string name) {}
		public FactoryPrimitiveArrayPool(int capacity, string name, int info) {}
	
		// Methods
		public T[] New() => default;
		public T[] New(int size) => default;
		public void Free(T[] obj) {}
		public void Free(T[] obj, int info) {}
		public void Dispose() {}
	}
}
