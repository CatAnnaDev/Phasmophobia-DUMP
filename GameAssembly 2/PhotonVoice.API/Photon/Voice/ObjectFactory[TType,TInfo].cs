﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public interface ObjectFactory<TType, TInfo> : IDisposable // TypeDefIndex: 4640
	{
		// Properties
		TInfo Info { get; }
	
		// Methods
		TType New();
		TType New(TInfo info);
		void Free(TType obj);
		void Free(TType obj, TInfo info);
	}
}
