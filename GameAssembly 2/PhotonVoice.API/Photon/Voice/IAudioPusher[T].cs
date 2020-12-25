/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public interface IAudioPusher<T> : IAudioDesc // TypeDefIndex: 4672
	{
		// Methods
		void SetCallback(Action<T[]> callback, ObjectFactory<T[], int> bufferFactory);
	}
}
