/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable // TypeDefIndex: 4716
	{
		// Fields
		protected IDataReader<T> reader;
	
		// Constructors
		protected BufferReaderPushAdapterBase() {} // Dummy constructor
		public BufferReaderPushAdapterBase(IDataReader<T> reader) {}
	
		// Methods
		public abstract void Service(LocalVoice localVoice);
		public void Dispose() {}
	}
}
