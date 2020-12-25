/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public interface IAudioOut<T> // TypeDefIndex: 4639
	{
		// Properties
		bool IsPlaying { get; }
		int Lag { get; }
	
		// Methods
		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);
		void Flush();
		void Stop();
		void Push(T[] frame);
		void Service();
	}
}
