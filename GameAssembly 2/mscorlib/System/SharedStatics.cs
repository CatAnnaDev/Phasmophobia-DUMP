/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Util;

// Image 0: mscorlib.dll - Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 - Types 0-1656

namespace System
{
	internal sealed class SharedStatics // TypeDefIndex: 289
	{
		// Fields
		private static readonly SharedStatics _sharedStatics; // 0x00
		private Tokenizer.StringMaker _maker; // 0x10
	
		// Constructors
		private SharedStatics() {} // 0x00000001802466A0-0x00000001802466B0
		static SharedStatics() {} // 0x00000001808C00F0-0x00000001808C03E0
	
		// Methods
		public static Tokenizer.StringMaker GetSharedStringMaker() => default; // 0x00000001808BFD70-0x00000001808BFF90
		public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker) {} // 0x00000001808BFF90-0x00000001808C00F0
	}
}
