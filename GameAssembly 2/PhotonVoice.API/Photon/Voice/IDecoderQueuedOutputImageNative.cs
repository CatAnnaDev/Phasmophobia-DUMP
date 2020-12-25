/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public interface IDecoderQueuedOutputImageNative : IDecoder // TypeDefIndex: 4698
	{
		// Properties
		ImageFormat OutputImageFormat { get; set; }
		Flip OutputImageFlip { get; set; }
		Func<int, int, IntPtr> OutputImageBufferGetter { get; set; }
	}
}
