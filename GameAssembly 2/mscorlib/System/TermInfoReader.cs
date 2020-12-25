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
	internal class TermInfoReader // TypeDefIndex: 390
	{
		// Fields
		private short boolSize; // 0x10
		private short numSize; // 0x12
		private short strOffsets; // 0x14
		private byte[] buffer; // 0x18
		private int booleansOffset; // 0x20
	
		// Constructors
		public TermInfoReader() {} // Dummy constructor
		public TermInfoReader(string term, string filename) {} // 0x00000001808D0BE0-0x00000001808D0E10
		public TermInfoReader(string term, byte[] buffer) {} // 0x00000001808D0B10-0x00000001808D0BE0
	
		// Methods
		private void ReadHeader(byte[] buffer, ref int position) {} // 0x00000001808D0820-0x00000001808D0AE0
		private void ReadNames(byte[] buffer, ref int position) {} // 0x00000001808D0AE0-0x00000001808D0B10
		public int Get(TermInfoNumbers number) => default; // 0x00000001808D07C0-0x00000001808D0820
		public string Get(TermInfoStrings tstr) => default; // 0x00000001808D06B0-0x00000001808D07C0
		public byte[] GetStringBytes(TermInfoStrings tstr) => default; // 0x00000001808D0470-0x00000001808D0620
		private short GetInt16(byte[] buffer, int offset) => default; // 0x00000001808D0330-0x00000001808D03B0
		private string GetString(byte[] buffer, int offset) => default; // 0x00000001808D0620-0x00000001808D06B0
		private byte[] GetStringBytes(byte[] buffer, int offset) => default; // 0x00000001808D03B0-0x00000001808D0470
	}
}
