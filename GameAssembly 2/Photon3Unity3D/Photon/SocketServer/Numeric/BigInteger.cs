/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 43: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.4.5, Culture=neutral, PublicKeyToken=null - Types 4241-4332

namespace Photon.SocketServer.Numeric
{
	internal class BigInteger // TypeDefIndex: 4325
	{
		// Fields
		public static readonly int[] primesBelow2000; // 0x00
		private uint[] data; // 0x10
		public int dataLength; // 0x18
	
		// Constructors
		public BigInteger() {} // 0x0000000180A87AF0-0x0000000180A87B70
		public BigInteger(long value) {} // 0x0000000180A87410-0x0000000180A875E0
		public BigInteger(BigInteger bi) {} // 0x0000000180A87B70-0x0000000180A87C60
		public BigInteger(byte[] inData) {} // 0x0000000180A87750-0x0000000180A87AF0
		public BigInteger(uint[] inData) {} // 0x0000000180A875E0-0x0000000180A87750
		static BigInteger() {} // 0x0000000180A873A0-0x0000000180A87410
	
		// Methods
		public static implicit operator BigInteger(long value) => default; // 0x0000000180A88F20-0x0000000180A88F80
		public static implicit operator BigInteger(int value) => default; // 0x0000000180A88F80-0x0000000180A88FE0
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2) => default; // 0x0000000180A887E0-0x0000000180A88A50
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2) => default; // 0x0000000180A89970-0x0000000180A89BF0
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2) => default; // 0x0000000180A89460-0x0000000180A89970
		public static BigInteger operator <<(BigInteger bi1, int shiftVal) => default; // 0x0000000180A88FE0-0x0000000180A89080
		private static int shiftLeft(uint[] buffer, int shiftVal) => default; // 0x0000000180A89E40-0x0000000180A89F20
		private static int shiftRight(uint[] buffer, int shiftVal) => default; // 0x0000000180A89F20-0x0000000180A8A070
		public static BigInteger operator -(BigInteger bi1) => default; // 0x0000000180A89BF0-0x0000000180A89E40
		public static bool operator ==(BigInteger bi1, BigInteger bi2) => default; // 0x0000000180A88CA0-0x0000000180A88CD0
		public override bool Equals(object o) => default; // 0x0000000180A867A0-0x0000000180A868B0
		public override int GetHashCode() => default; // 0x0000000180A86AF0-0x0000000180A86B30
		public static bool operator >(BigInteger bi1, BigInteger bi2) => default; // 0x0000000180A88D90-0x0000000180A88F20
		public static bool operator <(BigInteger bi1, BigInteger bi2) => default; // 0x0000000180A89080-0x0000000180A89210
		public static bool operator >=(BigInteger bi1, BigInteger bi2) => default; // 0x0000000180A88CD0-0x0000000180A88D90
		private static void multiByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder) {} // 0x0000000180A87F40-0x0000000180A887E0
		private static void singleByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder) {} // 0x0000000180A8A070-0x0000000180A8A4E0
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2) => default; // 0x0000000180A88A50-0x0000000180A88CA0
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2) => default; // 0x0000000180A89210-0x0000000180A89460
		public override string ToString() => default; // 0x0000000180A87000-0x0000000180A87010
		public string ToString(int radix) => default; // 0x0000000180A87010-0x0000000180A873A0
		public BigInteger ModPow(BigInteger exp, BigInteger n) => default; // 0x0000000180A86B30-0x0000000180A87000
		private BigInteger BarrettReduction(BigInteger x, BigInteger n, BigInteger constant) => default; // 0x0000000180A86080-0x0000000180A867A0
		public static BigInteger GenerateRandom(int bits) => default; // 0x0000000180A868B0-0x0000000180A86940
		public void genRandomBits(int bits, Random rand) {} // 0x0000000180A87D10-0x0000000180A87F40
		public int bitCount() => default; // 0x0000000180A87C60-0x0000000180A87D10
		public byte[] GetBytes() => default; // 0x0000000180A86940-0x0000000180A86AF0
	}
}
