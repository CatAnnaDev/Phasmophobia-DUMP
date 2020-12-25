/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class ByteArraySlice : IDisposable // TypeDefIndex: 4242
	{
		// Fields
		public byte[] Buffer; // 0x10
		public int Offset; // 0x18
		public int Count; // 0x1C
		private ByteArraySlicePool returnPool; // 0x20
		private readonly int stackIndex; // 0x28
	
		// Constructors
		internal ByteArraySlice(ByteArraySlicePool returnPool, int stackIndex) {} // 0x00000001806ACE70-0x00000001806ACF10
		public ByteArraySlice(byte[] buffer, int offset = 0 /* Metadata: 0x0064D558 */, int count = 0 /* Metadata: 0x0064D55C */) {} // 0x00000001806ACF10-0x00000001806ACF80
		public ByteArraySlice() {} // 0x00000001806ACF80-0x00000001806ACFB0
	
		// Methods
		public void Dispose() {} // 0x00000001806ACDA0-0x00000001806ACDB0
		public bool Release() => default; // 0x00000001806ACDB0-0x00000001806ACE60
		public void Reset() {} // 0x00000001806ACE60-0x00000001806ACE70
	}
}
