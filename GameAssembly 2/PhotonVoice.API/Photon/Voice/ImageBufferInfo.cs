/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 47: PhotonVoice.API.dll - Assembly: PhotonVoice.API, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4602-4758

namespace Photon.Voice
{
	public class ImageBufferInfo // TypeDefIndex: 4705
	{
		// Properties
		public int Width { get; private set; } // 0x0000000180245EA0-0x0000000180246600 0x00000001802932E0-0x00000001802932F0
		public int Height { get; private set; } // 0x00000001802932A0-0x00000001802932B0 0x00000001802932F0-0x0000000180293300
		public int[] Stride { get; private set; } // 0x0000000180246BC0-0x0000000180246BD0 0x0000000180246D40-0x0000000180246D50
		public ImageFormat Format { get; private set; } // 0x00000001802800D0-0x00000001802800E0 0x0000000180293310-0x0000000180293320
		public Rotation Rotation { get; set; } // 0x000000018027A6B0-0x000000018027A6C0 0x0000000180326FA0-0x0000000180326FB0
		public Flip Flip { get; set; } // 0x000000018026C7E0-0x000000018026C7F0 0x000000018026D130-0x000000018026D140
	
		// Constructors
		public ImageBufferInfo() {} // Dummy constructor
		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format) {} // 0x0000000180F1C820-0x0000000180F1C880
	}
}
