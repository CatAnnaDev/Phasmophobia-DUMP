/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable // TypeDefIndex: 4708
	{
		// Fields
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool; // 0x20
		private GCHandle planeHandle; // 0x28
	
		// Constructors
		public ImageBufferNativeGCHandleSinglePlane() {} // Dummy constructor
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info) {} // 0x0000000180F1CB90-0x0000000180F1CCB0
	
		// Methods
		public void PinPlane(byte[] plane) {} // 0x0000000180F1CAE0-0x0000000180F1CB50
		public override void Release() {} // 0x0000000180F1CB50-0x0000000180F1CB90
		public override void Dispose() {} // 0x0000000180246DB0-0x0000000180246DC0
	}
}
