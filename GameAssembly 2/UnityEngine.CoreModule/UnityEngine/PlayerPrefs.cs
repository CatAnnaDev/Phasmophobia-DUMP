/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800F1B40-0x00000001800F1B70
	public class PlayerPrefs // TypeDefIndex: 3232
	{
		// Constructors
		public PlayerPrefs() {} // Dummy constructor
	
		// Methods
		[NativeMethod] // 0x00000001800F1C10-0x00000001800F1C40
		private static bool TrySetInt(string key, int value) => default; // 0x0000000180940630-0x0000000180940670
		[NativeMethod] // 0x00000001800F1D70-0x00000001800F1DA0
		private static bool TrySetFloat(string key, float value) => default; // 0x00000001809405E0-0x0000000180940630
		[NativeMethod] // 0x00000001800F1E40-0x00000001800F1E70
		private static bool TrySetSetString(string key, string value) => default; // 0x0000000180940670-0x00000001809406C0
		public static void SetInt(string key, int value) {} // 0x00000001809404B0-0x0000000180940540
		public static int GetInt(string key, int defaultValue) => default; // 0x0000000180940260-0x00000001809402A0
		public static int GetInt(string key) => default; // 0x00000001809402A0-0x00000001809402E0
		public static void SetFloat(string key, float value) {} // 0x0000000180940410-0x00000001809404B0
		public static float GetFloat(string key, float defaultValue) => default; // 0x00000001809401D0-0x0000000180940220
		public static float GetFloat(string key) => default; // 0x0000000180940220-0x0000000180940260
		public static void SetString(string key, string value) {} // 0x0000000180940540-0x00000001809405E0
		public static string GetString(string key, string defaultValue) => default; // 0x0000000180940350-0x00000001809403A0
		public static string GetString(string key) => default; // 0x00000001809402E0-0x0000000180940350
		public static bool HasKey(string key) => default; // 0x00000001809403A0-0x00000001809403E0
		public static void DeleteKey(string key) {} // 0x0000000180940190-0x00000001809401D0
		[NativeMethod] // 0x00000001800F1F20-0x00000001800F1F50
		public static void Save() {} // 0x00000001809403E0-0x0000000180940410
	}
}
