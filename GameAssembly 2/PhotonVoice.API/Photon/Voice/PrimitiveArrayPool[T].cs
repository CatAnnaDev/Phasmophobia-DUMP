/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int> // TypeDefIndex: 4644
	{
		// Constructors
		public PrimitiveArrayPool() {} // Dummy constructor
		public PrimitiveArrayPool(int capacity, string name) {}
		public PrimitiveArrayPool(int capacity, string name, int info) {}
	
		// Methods
		protected override T[] createObject(int info) => default;
		protected override void destroyObject(T[] obj) {}
		protected override bool infosMatch(int i0, int i1) => default;
	}
}
