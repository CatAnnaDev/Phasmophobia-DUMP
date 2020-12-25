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
	public static class Math // TypeDefIndex: 257
	{
		// Fields
		private static double doubleRoundLimit; // 0x00
		private const int maxRoundingDigits = 15; // Metadata: 0x0063000C
		private static double[] roundPower10Double; // 0x08
		public const double PI = 3.141592653589793; // Metadata: 0x00630010
		public const double E = 2.718281828459045; // Metadata: 0x00630018
	
		// Constructors
		static Math() {} // 0x0000000180680170-0x0000000180680200
	
		// Methods
		public static double Acos(double d) => default; // 0x000000018067F840-0x000000018067F850
		public static double Asin(double d) => default; // 0x000000018067F850-0x000000018067F860
		public static double Atan(double d) => default; // 0x000000018067F870-0x000000018067F880
		public static double Atan2(double y, double x) => default; // 0x000000018067F860-0x000000018067F870
		public static double Ceiling(double a) => default; // 0x000000018067F880-0x000000018067F890
		public static double Cos(double d) => default; // 0x000000018067F890-0x000000018067F8A0
		public static double Floor(double d) => default; // 0x000000018067F8B0-0x000000018067F8C0
		private static double InternalRound(double value, int digits, MidpointRounding mode) => default; // 0x000000018067F8C0-0x000000018067FB20
		public static double Sin(double a) => default; // 0x0000000180680130-0x0000000180680140
		public static double Tan(double a) => default; // 0x0000000180680160-0x0000000180680170
		public static double Round(double a) => default; // 0x000000018067FED0-0x000000018067FEE0
		public static double Round(double value, int digits, MidpointRounding mode) => default; // 0x000000018067FEE0-0x0000000180680070
		public static decimal Round(decimal d, int decimals) => default; // 0x000000018067FE40-0x000000018067FED0
		private static unsafe double SplitFractionDouble(double* value) => default; // 0x0000000180680140-0x0000000180680150
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static double Sqrt(double d) => default; // 0x0000000180680150-0x0000000180680160
		public static double Log(double d) => default; // 0x000000018067FC90-0x000000018067FCA0
		public static double Log10(double d) => default; // 0x000000018067FB20-0x000000018067FB30
		public static double Exp(double d) => default; // 0x000000018067F8A0-0x000000018067F8B0
		public static double Pow(double x, double y) => default; // 0x000000018067FE30-0x000000018067FE40
		public static short Abs(short value) => default; // 0x000000018067F5B0-0x000000018067F680
		private static short AbsHelper(short value) => default; // 0x000000018067F420-0x000000018067F4A0
		public static int Abs(int value) => default; // 0x000000018067F760-0x000000018067F820
		private static int AbsHelper(int value) => default; // 0x000000018067F530-0x000000018067F5B0
		public static long Abs(long value) => default; // 0x000000018067F680-0x000000018067F750
		private static long AbsHelper(long value) => default; // 0x000000018067F4A0-0x000000018067F530
		public static float Abs(float value) => default; // 0x000000018067F820-0x000000018067F840
		public static double Abs(double value) => default; // 0x000000018067F750-0x000000018067F760
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static int Max(int val1, int val2) => default; // 0x000000018067FD10-0x000000018067FD20
		// [CLSCompliant] // 0x00000001800E4780-0x00000001800E47C0
		// [ReliabilityContract] // 0x00000001800E4780-0x00000001800E47C0
		public static uint Max(uint val1, uint val2) => default; // 0x000000018067FCB0-0x000000018067FCC0
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static long Max(long val1, long val2) => default; // 0x000000018067FCA0-0x000000018067FCB0
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static float Max(float val1, float val2) => default; // 0x000000018067FCC0-0x000000018067FD10
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static double Max(double val1, double val2) => default; // 0x000000018067FD20-0x000000018067FDB0
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static int Min(int val1, int val2) => default; // 0x000000018067FE10-0x000000018067FE20
		// [CLSCompliant] // 0x00000001800E4780-0x00000001800E47C0
		// [ReliabilityContract] // 0x00000001800E4780-0x00000001800E47C0
		public static uint Min(uint val1, uint val2) => default; // 0x000000018067FE20-0x000000018067FE30
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static long Min(long val1, long val2) => default; // 0x000000018067FDB0-0x000000018067FDC0
		// [ReliabilityContract] // 0x00000001800DF1C0-0x00000001800DF1E0
		public static float Min(float val1, float val2) => default; // 0x000000018067FDC0-0x000000018067FE10
		public static double Log(double a, double newBase) => default; // 0x000000018067FB30-0x000000018067FC90
		public static int Sign(double value) => default; // 0x0000000180680070-0x0000000180680130
	}
}
