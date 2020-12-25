/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace ExitGames.Client.Photon
{
	public class ByteArraySlicePool // TypeDefIndex: 4243
	{
		// Fields
		private int minStackIndex; // 0x10
		internal readonly Stack<ByteArraySlice>[] poolTiers; // 0x18
		internal readonly Stack<ByteArraySlice> nullPool; // 0x20
		private int allocationCounter; // 0x28
	
		// Properties
		public int MinStackIndex { get => default; set {} } // 0x00000001806ACD60-0x00000001806ACD70 0x00000001806ACD70-0x00000001806ACDA0
		public int AllocationCounter { get => default; } // 0x00000001806ACD50-0x00000001806ACD60 
	
		// Constructors
		public ByteArraySlicePool() {} // 0x00000001806ACC20-0x00000001806ACD50
	
		// Methods
		public ByteArraySlice Acquire(byte[] buffer, int offset = 0 /* Metadata: 0x0064D560 */, int count = 0 /* Metadata: 0x0064D564 */) => default; // 0x00000001806AC910-0x00000001806AC980
		public ByteArraySlice Acquire(int minByteCount) => default; // 0x00000001806AC980-0x00000001806ACB80
		private ByteArraySlice Acquire(Stack<ByteArraySlice> stack, int stackIndex) => default; // 0x00000001806AC810-0x00000001806AC910
		public bool Release(ByteArraySlice slice) => default; // 0x00000001806ACC00-0x00000001806ACC20
		public void ClearPools(int lower = 0 /* Metadata: 0x0064D568 */, int upper = 2147483647 /* Metadata: 0x0064D56C */) {} // 0x00000001806ACB80-0x00000001806ACC00
	}
}
