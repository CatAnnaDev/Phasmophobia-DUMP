/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	public class InteropHelp // TypeDefIndex: 6121
	{
		// Nested types
		public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 6122
		{
			// Constructors
			public UTF8StringHandle() {} // Dummy constructor
			public UTF8StringHandle(string str) {} // 0x00000001802D26C0-0x00000001802D2800
	
			// Methods
			protected override bool ReleaseHandle() => default; // 0x00000001802D2650-0x00000001802D26C0
		}
	
		public class SteamParamStringArray // TypeDefIndex: 6123
		{
			// Fields
			private IntPtr[] m_Strings; // 0x10
			private IntPtr m_ptrStrings; // 0x18
			private IntPtr m_pSteamParamStringArray; // 0x20
	
			// Constructors
			public SteamParamStringArray() {} // Dummy constructor
			public SteamParamStringArray(IList<string> strings) {} // 0x00000001802D22D0-0x00000001802D2630
	
			// Methods
			~SteamParamStringArray() {} // 0x00000001802D2130-0x00000001802D22D0
			public static implicit operator IntPtr(SteamParamStringArray that) => default; // 0x00000001802D2630-0x00000001802D2650
		}
	
		// Constructors
		public InteropHelp() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		public static void TestIfPlatformSupported() {} // 0x0000000180246DB0-0x0000000180246DC0
		public static void TestIfAvailableClient() {} // 0x00000001802A85B0-0x00000001802A8660
		public static void TestIfAvailableGameServer() {} // 0x00000001802A8660-0x00000001802A8710
		public static string PtrToStringUTF8(IntPtr nativeUtf8) => default; // 0x00000001802A8480-0x00000001802A85B0
	}
}
