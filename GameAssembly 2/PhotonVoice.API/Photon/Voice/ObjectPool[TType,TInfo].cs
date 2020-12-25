/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public abstract class ObjectPool<TType, TInfo> : IDisposable // TypeDefIndex: 4643
	{
		// Fields
		protected int capacity;
		protected TInfo info;
		private TType[] freeObj;
		protected int pos;
		protected string name;
		private bool inited;
	
		// Properties
		internal string LogPrefix { get; }
		public TInfo Info { get; }
	
		// Constructors
		protected ObjectPool() {} // Dummy constructor
		public ObjectPool(int capacity, string name) {}
		public ObjectPool(int capacity, string name, TInfo info) {}
	
		// Methods
		protected abstract TType createObject(TInfo info);
		protected abstract void destroyObject(TType obj);
		protected abstract bool infosMatch(TInfo i0, TInfo i1);
		public void Init(TInfo info) {}
		public TType AcquireOrCreate() => default;
		public TType AcquireOrCreate(TInfo info) => default;
		public virtual bool Release(TType obj, TInfo objInfo) => default;
		public virtual bool Release(TType obj) => default;
		public void Dispose() {}
	}
}
