/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class StreamBuffer // TypeDefIndex: 4304
	{
		// Fields
		private const int DefaultInitialSize = 0; // Metadata: 0x0064D702
		private int pos; // 0x10
		private int len; // 0x14
		private byte[] buf; // 0x18
	
		// Properties
		public bool CanRead { get => default; } // 0x00000001808DAFA0-0x00000001808DAFB0 
		public bool CanSeek { get => default; } // 0x00000001808DAFA0-0x00000001808DAFB0 
		public bool CanWrite { get => default; } // 0x00000001808DAFA0-0x00000001808DAFB0 
		public int Length { get => default; } // 0x00000001806BC990-0x00000001806BC9A0 
		public int Position { get => default; set {} } // 0x00000001806ACD60-0x00000001806ACD70 0x0000000180A8CA90-0x0000000180A8CAB0
	
		// Constructors
		public StreamBuffer() {} // Dummy constructor
		public StreamBuffer(int size = 0 /* Metadata: 0x0064D6FE */) {} // 0x0000000180A8C9E0-0x0000000180A8CA40
		public StreamBuffer(byte[] buf) {} // 0x0000000180A8CA40-0x0000000180A8CA90
	
		// Methods
		public byte[] ToArray() => default; // 0x0000000180A8C3D0-0x0000000180A8C440
		public byte[] ToArrayFromPos() => default; // 0x0000000180A8C340-0x0000000180A8C3D0
		public void Compact() {} // 0x0000000180A8BFF0-0x0000000180A8C070
		public byte[] GetBuffer() => default; // 0x00000001809302F0-0x0000000180930300
		public byte[] GetBufferAndAdvance(int length, out int offset) {
			offset = default;
			return default;
		} // 0x0000000180A8C070-0x0000000180A8C0B0
		public void Flush() {} // 0x0000000180246DB0-0x0000000180246DC0
		public long Seek(long offset, SeekOrigin origin) => default; // 0x0000000180A8C200-0x0000000180A8C300
		public void SetLength(long value) {} // 0x0000000180A8C310-0x0000000180A8C340
		public void SetCapacityMinimum(int neededSize) {} // 0x0000000180A8C300-0x0000000180A8C310
		public int Read(byte[] buffer, int offset, int count) => default; // 0x0000000180A8C1A0-0x0000000180A8C200
		public void Write(byte[] buffer, int srcOffset, int count) {} // 0x0000000180A8C960-0x0000000180A8C9E0
		public byte ReadByte() => default; // 0x0000000180A8C0B0-0x0000000180A8C1A0
		public void WriteByte(byte value) {} // 0x0000000180A8C440-0x0000000180A8C4B0
		public void WriteBytes(byte v0, byte v1) {} // 0x0000000180A8C8B0-0x0000000180A8C960
		public void WriteBytes(byte v0, byte v1, byte v2) {} // 0x0000000180A8C5C0-0x0000000180A8C6A0
		public void WriteBytes(byte v0, byte v1, byte v2, byte v3) {} // 0x0000000180A8C4B0-0x0000000180A8C5C0
		public void WriteBytes(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5, byte v6, byte v7) {} // 0x0000000180A8C6A0-0x0000000180A8C8B0
		private bool CheckSize(int size) => default; // 0x0000000180A8BF30-0x0000000180A8BFF0
	}
}
