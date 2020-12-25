/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 15: UnityEngine.JSONSerializeModule.dll - Assembly: UnityEngine.JSONSerializeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3787-3788

namespace UnityEngine
{
	// [NativeHeader] // 0x000000018010C550-0x000000018010C580
	public static class JsonUtility // TypeDefIndex: 3788
	{
		// Methods
		[FreeFunction] // 0x000000018010C670-0x000000018010C6C0
		[ThreadSafe] // 0x000000018010C670-0x000000018010C6C0
		private static string ToJsonInternal([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ object obj, bool prettyPrint) => default; // 0x0000000180AFB670-0x0000000180AFB6C0
		[FreeFunction] // 0x000000018010C7C0-0x000000018010C810
		[ThreadSafe] // 0x000000018010C7C0-0x000000018010C810
		private static object FromJsonInternal(string json, object objectToOverwrite, Type type) => default; // 0x0000000180AFB2F0-0x0000000180AFB350
		public static string ToJson(object obj) => default; // 0x0000000180AFB6C0-0x0000000180AFB820
		public static string ToJson(object obj, bool prettyPrint) => default; // 0x0000000180AFB820-0x0000000180AFB990
		public static T FromJson<T>(string json) => default;
		public static object FromJson(string json, Type type) => default; // 0x0000000180AFB4E0-0x0000000180AFB670
		public static void FromJsonOverwrite(string json, object objectToOverwrite) {} // 0x0000000180AFB350-0x0000000180AFB4E0
	}
}
