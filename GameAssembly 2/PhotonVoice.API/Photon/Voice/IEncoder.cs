/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public interface IEncoder : IDisposable // TypeDefIndex: 4693
	{
		// Properties
		string Error { get; }
		Action<ArraySegment<byte>, FrameFlags> Output { get; set; }
		VoiceInfo Info { get; }
	
		// Methods
		ArraySegment<byte> DequeueOutput(out FrameFlags flags);
		void EndOfStream();
	}
}
