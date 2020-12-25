/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngineInternal;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800F4350-0x00000001800F43B0
	// [NativeHeader] // 0x00000001800F4350-0x00000001800F43B0
	public sealed class Resources // TypeDefIndex: 3246
	{
		// Constructors
		public Resources() {} // Dummy constructor
	
		// Methods
		internal static T[] ConvertObjects<T>(Object[] rawObjects)
			where T : Object => default;
		[FreeFunction] // 0x00000001800F44D0-0x00000001800F4520
		// [TypeInferenceRule] // 0x00000001800F44D0-0x00000001800F4520
		public static Object[] FindObjectsOfTypeAll(Type type) => default; // 0x00000001808D9A60-0x00000001808D9AA0
		public static T[] FindObjectsOfTypeAll<T>()
			where T : Object => default;
		public static Object Load(string path) => default; // 0x00000001808D9BD0-0x00000001808D9C60
		public static T Load<T>(string path)
			where T : Object => default;
		[FreeFunction] // 0x00000001800F45E0-0x00000001800F4640
		[NativeThrows] // 0x00000001800F45E0-0x00000001800F4640
		// [TypeInferenceRule] // 0x00000001800F45E0-0x00000001800F4640
		public static Object Load(string path, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Type systemTypeInstance) => default; // 0x00000001808D9C60-0x00000001808D9CB0
		[FreeFunction] // 0x00000001800F4870-0x00000001800F48B0
		[NativeThrows] // 0x00000001800F4870-0x00000001800F48B0
		public static Object[] LoadAll([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ string path, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Type systemTypeInstance) => default; // 0x00000001808D9B80-0x00000001808D9BD0
		public static Object[] LoadAll(string path) => default; // 0x00000001808D9AF0-0x00000001808D9B80
		[FreeFunction] // 0x00000001800F4AD0-0x00000001800F4B20
		// [TypeInferenceRule] // 0x00000001800F4AD0-0x00000001800F4B20
		public static Object GetBuiltinResource([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Type type, string path) => default; // 0x00000001808D9AA0-0x00000001808D9AF0
		public static T GetBuiltinResource<T>(string path)
			where T : Object => default;
	}
}
