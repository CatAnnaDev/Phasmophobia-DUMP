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
	public static class GC // TypeDefIndex: 214
	{
		// Fields
		internal static readonly object EPHEMERON_TOMBSTONE; // 0x00
	
		// Properties
		public static int MaxGeneration { get; } // 0x000000018031BCB0-0x000000018031BD00 
	
		// Constructors
		static GC() {} // 0x000000018031BC60-0x000000018031BCB0
	
		// Methods
		private static int GetCollectionCount(int generation) => default; // 0x000000018031B9D0-0x000000018031B9E0
		private static int GetMaxGeneration() => default; // 0x000000018031B9E0-0x000000018031B9F0
		private static void InternalCollect(int generation) {} // 0x000000018031BA00-0x000000018031BA10
		private static void RecordPressure(long bytesAllocated) {} // 0x000000018031BAA0-0x000000018031BAB0
		internal static void register_ephemeron_array(Ephemeron[] array) {} // 0x0000000180289B80-0x0000000180289B90
		private static object get_ephemeron_tombstone() => default; // 0x000000018031BD00-0x000000018031BD10
		public static void AddMemoryPressure(long bytesAllocated) {} // 0x000000018031B7A0-0x000000018031B8A0
		public static void RemoveMemoryPressure(long bytesAllocated) {} // 0x000000018031BAB0-0x000000018031BBB0
		public static void Collect() {} // 0x000000018031B8A0-0x000000018031B930
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static int CollectionCount(int generation) => default; // 0x000000018031B930-0x000000018031B9D0
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static void KeepAlive(object obj) {} // 0x0000000180246DB0-0x0000000180246DC0
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		private static void _SuppressFinalize(object o) {} // 0x000000018031BC50-0x000000018031BC60
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static void SuppressFinalize(object obj) {} // 0x000000018031BBB0-0x000000018031BC40
		private static void _ReRegisterForFinalize(object o) {} // 0x000000018031BC40-0x000000018031BC50
		public static void ReRegisterForFinalize(object obj) {} // 0x000000018031BA10-0x000000018031BAA0
		public static long GetTotalMemory(bool forceFullCollection) => default; // 0x000000018031B9F0-0x000000018031BA00
	}
}
