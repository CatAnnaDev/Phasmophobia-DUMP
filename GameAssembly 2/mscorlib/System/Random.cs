/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	[Serializable]
	// [ComVisible] // 0x00000001800DEC30-0x00000001800DEC50
	public class Random // TypeDefIndex: 279
	{
		// Fields
		private const int MBIG = 2147483647; // Metadata: 0x00630028
		private const int MSEED = 161803398; // Metadata: 0x0063002C
		private const int MZ = 0; // Metadata: 0x00630030
		private int inext; // 0x10
		private int inextp; // 0x14
		private int[] SeedArray; // 0x18
	
		// Constructors
		public Random() {} // 0x00000001806918D0-0x0000000180691900
		public Random(int Seed) {} // 0x0000000180691900-0x0000000180691B70
	
		// Methods
		protected virtual double Sample() => default; // 0x00000001806918B0-0x00000001806918D0
		private int InternalSample() => default; // 0x0000000180691570-0x0000000180691620
		public virtual int Next() => default; // 0x0000000180691620-0x0000000180691630
		private double GetSampleForLargeRange() => default; // 0x0000000180691510-0x0000000180691570
		public virtual int Next(int minValue, int maxValue) => default; // 0x0000000180691630-0x00000001806917C0
		public virtual int Next(int maxValue) => default; // 0x00000001806917C0-0x00000001806918B0
		public virtual double NextDouble() => default; // 0x0000000180277BB0-0x0000000180277BD0
	}
}
