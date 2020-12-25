/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Bindings;

// Image 18: UnityEngine.UnityWebRequestModule.dll - Assembly: UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3817-3829

namespace UnityEngine
{
	[VisibleToOtherModules] // 0x000000018011E660-0x000000018011E6E0
	internal class WWWTranscoder // TypeDefIndex: 3820
	{
		// Fields
		private static byte[] ucHexChars; // 0x00
		private static byte[] lcHexChars; // 0x08
		private static byte urlEscapeChar; // 0x10
		private static byte[] urlSpace; // 0x18
		private static byte[] dataSpace; // 0x20
		private static byte[] urlForbidden; // 0x28
		private static byte qpEscapeChar; // 0x30
		private static byte[] qpSpace; // 0x38
		private static byte[] qpForbidden; // 0x40
	
		// Constructors
		public WWWTranscoder() {} // Dummy constructor
		static WWWTranscoder() {} // 0x0000000180AD7800-0x0000000180AD7A50
	
		// Methods
		private static byte Hex2Byte(byte[] b, int offset) => default; // 0x0000000180AD74B0-0x0000000180AD7540
		private static byte[] Byte2Hex(byte b, byte[] hexChars) => default; // 0x0000000180AD6BB0-0x0000000180AD6C80
		public static string DataEncode(string toEncode, Encoding e) => default; // 0x0000000180AD6D70-0x0000000180AD6E60
		public static byte[] DataEncode(byte[] toEncode) => default; // 0x0000000180AD6E60-0x0000000180AD6EE0
		public static string QPEncode(string toEncode, Encoding e) => default; // 0x0000000180AD7540-0x0000000180AD7630
		public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) => default; // 0x0000000180AD7170-0x0000000180AD74B0
		private static bool ByteArrayContains(byte[] array, byte b) => default; // 0x0000000180AD6C80-0x0000000180AD6CD0
		public static byte[] URLDecode(byte[] toEncode) => default; // 0x0000000180AD7790-0x0000000180AD7800
		private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) => default; // 0x0000000180AD6CD0-0x0000000180AD6D70
		public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) => default; // 0x0000000180AD6EE0-0x0000000180AD7170
		public static bool SevenBitClean(string s, Encoding e) => default; // 0x0000000180AD7630-0x0000000180AD7720
		public static bool SevenBitClean(byte[] input) => default; // 0x0000000180AD7720-0x0000000180AD7790
	}
}
