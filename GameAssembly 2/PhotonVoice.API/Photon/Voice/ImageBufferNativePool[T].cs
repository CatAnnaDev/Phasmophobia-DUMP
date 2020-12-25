/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class ImageBufferNativePool<T> : ObjectPool<T, Photon.Voice.ImageBufferInfo> // TypeDefIndex: 4645
		where T : ImageBufferNative
	{
		// Fields
		private Factory factory;
	
		// Nested types
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info); // TypeDefIndex: 4646; 0x00000000-0x00000000
	
		// Constructors
		public ImageBufferNativePool() {} // Dummy constructor
		public ImageBufferNativePool(int capacity, Factory factory, string name) {}
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info) {}
	
		// Methods
		protected override T createObject(ImageBufferInfo info) => default;
		protected override void destroyObject(T obj) {}
		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1) => default;
	}
}
