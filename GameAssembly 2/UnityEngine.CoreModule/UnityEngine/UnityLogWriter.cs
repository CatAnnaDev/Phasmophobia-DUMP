/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800E9C90-0x00000001800E9CC0
	internal class UnityLogWriter : TextWriter // TypeDefIndex: 3215
	{
		// Constructors
		public UnityLogWriter() {} // 0x00000001808E6670-0x00000001808E66D0
	
		// Methods
		[ThreadAndSerializationSafe] // 0x00000001800D4E50-0x00000001800D4E60
		public static void WriteStringToUnityLog(string s) {} // 0x00000001808E6550-0x00000001808E6590
		[FreeFunction] // 0x00000001800E9DF0-0x00000001800E9E20
		private static void WriteStringToUnityLogImpl(string s) {} // 0x00000001808E6510-0x00000001808E6550
		public static void Init() {} // 0x00000001808E6470-0x00000001808E6510
		public override void Write(char value) {} // 0x00000001808E6590-0x00000001808E65E0
		public override void Write(string s) {} // 0x00000001808E6630-0x00000001808E6670
		public override void Write(char[] buffer, int index, int count) {} // 0x00000001808E65E0-0x00000001808E6630
	}
}
