/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	// [NativeHeader] // 0x0000000180127F50-0x00000001801281D0
	public class Application // TypeDefIndex: 3107
	{
		// Fields
		private static LogCallback s_LogCallbackHandler; // 0x08
		private static LogCallback s_LogCallbackHandlerThreaded; // 0x10
	
		// Properties
		public static bool isPlaying { [FreeFunction] /* 0x0000000180129310-0x0000000180129340 */ get => default; } // 0x000000018095CC20-0x000000018095CC50 
		public static bool isFocused { [FreeFunction] /* 0x0000000180129370-0x00000001801293A0 */ get => default; } // 0x000000018095CB90-0x000000018095CBC0 
		public static bool runInBackground { [FreeFunction] /* 0x00000001801296F0-0x0000000180129720 */ get => default; [FreeFunction] /* 0x0000000180129780-0x00000001801297B0 */ set {} } // 0x000000018095CD10-0x000000018095CD40 0x000000018095D030-0x000000018095D070
		public static bool isBatchMode { [FreeFunction] /* 0x00000001801298A0-0x00000001801298D0 */ get => default; } // 0x000000018095CB60-0x000000018095CB90 
		public static string dataPath { [FreeFunction] /* 0x0000000180129900-0x0000000180129930 */ get => default; } // 0x000000018095CB30-0x000000018095CB60 
		[SecurityCritical] // 0x00000001800D4E50-0x00000001800D4E60
		public static string persistentDataPath { [FreeFunction] /* 0x000000018012AC80-0x000000018012ACB0 */ get => default; } // 0x000000018095CC80-0x000000018095CCB0 
		public static string unityVersion { [FreeFunction] /* 0x000000018012AD20-0x000000018012AD60 */ get => default; } // 0x000000018095CD40-0x000000018095CD70 
		public static string version { [FreeFunction] /* 0x000000018012AE50-0x000000018012AE80 */ get => default; } // 0x000000018095CD70-0x000000018095CDA0 
		public static string productName { [FreeFunction] /* 0x000000018012AEE0-0x000000018012AF10 */ get => default; } // 0x000000018095CCE0-0x000000018095CD10 
		public static string companyName { [FreeFunction] /* 0x000000018012B0E0-0x000000018012B110 */ get => default; } // 0x000000018095CB00-0x000000018095CB30 
		public static string cloudProjectId { [FreeFunction] /* 0x000000018012B170-0x000000018012B1A0 */ get => default; } // 0x000000018095CAD0-0x000000018095CB00 
		public static int targetFrameRate { [FreeFunction] /* 0x000000018012B350-0x000000018012B380 */ set {} } // 0x000000018095D070-0x000000018095D0B0
		public static ThreadPriority backgroundLoadingPriority { [FreeFunction] /* 0x000000018012B4A0-0x000000018012B4D0 */ set {} } // 0x000000018095CFF0-0x000000018095D030
		public static RuntimePlatform platform { [FreeFunction] /* 0x000000018012B5F0-0x000000018012B630 */ get => default; } // 0x000000018095CCB0-0x000000018095CCE0 
		public static bool isMobilePlatform { get => default; } // 0x000000018095CBC0-0x000000018095CC20 
		[Obsolete] // 0x000000018012BC30-0x000000018012BC60
		public static int loadedLevel { get => default; } // 0x000000018095CC50-0x000000018095CC80 
		public static bool isEditor { get => default; } // 0x00000001806C0540-0x00000001806C0550 
	
		// Events
		public static event LogCallback logMessageReceived;
		public static event UnityAction onBeforeRender;
		public static event Action<bool> focusChanged;
		public static event Action quitting;
	
		// Nested types
		public delegate void LowMemoryCallback(); // TypeDefIndex: 3108; 0x00000001802D1BD0-0x00000001802D1D60
	
		public delegate void LogCallback(string condition, string stackTrace, LogType type); // TypeDefIndex: 3109; 0x00000001809707E0-0x0000000180970CF0
	
		// Constructors
		public Application() {} // Dummy constructor
	
		// Methods
		[FreeFunction] // 0x0000000180129250-0x0000000180129280
		public static void Quit(int exitCode) {} // 0x000000018095C7B0-0x000000018095C7F0
		public static void Quit() {} // 0x000000018095C7F0-0x000000018095C820
		[FreeFunction] // 0x000000018012B1D0-0x000000018012B200
		public static void OpenURL(string url) {} // 0x000000018095C770-0x000000018095C7B0
		[FreeFunction] // 0x000000018012B3E0-0x000000018012B410
		private static void SetLogCallbackDefined(bool defined) {} // 0x000000018095C820-0x000000018095C860
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void CallLowMemory() {} // 0x000000018095C2F0-0x000000018095C4D0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) {} // 0x000000018095C230-0x000000018095C2F0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static bool Internal_ApplicationWantsToQuit() => default; // 0x000000018095C520-0x000000018095C650
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void Internal_ApplicationQuit() {} // 0x000000018095C4D0-0x000000018095C520
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void InvokeOnBeforeRender() {} // 0x000000018095C710-0x000000018095C760
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void InvokeFocusChanged(bool focus) {} // 0x000000018095C6B0-0x000000018095C710
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void InvokeDeepLinkActivated(string url) {} // 0x000000018095C650-0x000000018095C6B0
		[Obsolete] // 0x000000018012BAD0-0x000000018012BB00
		public static void LoadLevel(int index) {} // 0x000000018095C760-0x000000018095C770
	}
}
