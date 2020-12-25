/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public static class Buffer // TypeDefIndex: 170
	{
		// Methods
		internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) => default; // 0x000000018070E570-0x000000018070E580
		internal static unsafe int IndexOfByte(byte* src, byte value, int index, int count) => default; // 0x000000018070E4B0-0x000000018070E570
		private static int _ByteLength(Array array) => default; // 0x000000018070E870-0x000000018070E880
		internal static unsafe void ZeroMemory(byte* src, long len) {} // 0x000000018070E850-0x000000018070E870
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		internal static unsafe void Memcpy(byte[] dest, int destIndex, byte* src, int srcIndex, int len) {} // 0x000000018070E810-0x000000018070E850
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		internal static unsafe void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) {} // 0x000000018070E580-0x000000018070E5C0
		public static int ByteLength(Array array) => default; // 0x000000018070E3F0-0x000000018070E4B0
		public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) {} // 0x000000018070E1C0-0x000000018070E3F0
		internal static unsafe void memcpy4(byte* dest, byte* src, int size) {} // 0x000000018070E9B0-0x000000018070EA50
		internal static unsafe void memcpy2(byte* dest, byte* src, int size) {} // 0x000000018070E930-0x000000018070E9B0
		private static unsafe void memcpy1(byte* dest, byte* src, int size) {} // 0x000000018070E880-0x000000018070E930
		internal static unsafe void Memcpy(byte* dest, byte* src, int size) {} // 0x000000018070E5C0-0x000000018070E810
	}
}
