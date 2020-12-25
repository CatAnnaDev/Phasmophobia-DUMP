/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 4: System.dll - Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 2170-2964

namespace System
{
	internal class DomainNameHelper // TypeDefIndex: 2304
	{
		// Constructors
		public DomainNameHelper() {} // Dummy constructor
	
		// Methods
		internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) => default; // 0x00000001807589F0-0x0000000180758B60
		internal static unsafe bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) => default; // 0x0000000180758860-0x00000001807589F0
		internal static unsafe bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) => default; // 0x0000000180758640-0x0000000180758820
		internal static unsafe string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) => default; // 0x0000000180758190-0x00000001807583E0
		internal static unsafe string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) => default; // 0x00000001807583E0-0x0000000180758560
		private static bool IsIdnAce(string input, int index) => default; // 0x0000000180758590-0x0000000180758610
		private static unsafe bool IsIdnAce(char* input, int index) => default; // 0x0000000180758610-0x0000000180758640
		internal static unsafe string UnicodeEquivalent(string idnHost, char* hostname, int start, int end) => default; // 0x0000000180758B60-0x0000000180758C20
		internal static unsafe string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) => default; // 0x0000000180758C20-0x0000000180759000
		private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) => default; // 0x0000000180758560-0x0000000180758590
		private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) => default; // 0x0000000180758820-0x0000000180758860
	}
}
