/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x000000018012EA00-0x000000018012EA30
	public class Debug // TypeDefIndex: 3122
	{
		// Fields
		internal static ILogger s_Logger; // 0x00
	
		// Properties
		public static ILogger unityLogger { get => default; } // 0x0000000180968260-0x00000001809682C0 
		[NativeProperty] // 0x00000001801317F0-0x0000000180131850
		// [StaticAccessor] // 0x00000001801317F0-0x0000000180131850
		public static bool isDebugBuild { get => default; } // 0x0000000180968230-0x0000000180968260 
	
		// Constructors
		public Debug() {} // Dummy constructor
		static Debug() {} // 0x00000001809681B0-0x0000000180968230
	
		// Methods
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawLine(Vector3 start, Vector3 end, Color color) {} // 0x0000000180967080-0x0000000180967190
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawLine(Vector3 start, Vector3 end) {} // 0x0000000180966EC0-0x0000000180966FD0
		[FreeFunction] // 0x000000018012EE20-0x000000018012EE50
		public static void DrawLine(Vector3 start, Vector3 end, [DefaultValue] /* 0x000000018012EF80-0x000000018012EFB0 */ Color color, [DefaultValue] /* 0x000000018012F090-0x000000018012F0C0 */ float duration, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool depthTest) {} // 0x0000000180966FD0-0x0000000180967080
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawRay(Vector3 start, Vector3 dir, Color color) {} // 0x0000000180967190-0x0000000180967340
		public static void DrawRay(Vector3 start, Vector3 dir, [DefaultValue] /* 0x000000018012EF80-0x000000018012EFB0 */ Color color, [DefaultValue] /* 0x000000018012F090-0x000000018012F0C0 */ float duration, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool depthTest) {} // 0x0000000180967340-0x00000001809674C0
		public static void Log(object message) {} // 0x0000000180968000-0x00000001809680D0
		public static void Log(object message, Object context) {} // 0x00000001809680D0-0x00000001809681B0
		public static void LogFormat(string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180967AB0-0x0000000180967B90
		public static void LogFormat(Object context, string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180967B90-0x0000000180967C80
		public static void LogError(object message) {} // 0x0000000180967760-0x0000000180967830
		public static void LogError(object message, Object context) {} // 0x0000000180967830-0x0000000180967910
		public static void LogErrorFormat(string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180967680-0x0000000180967760
		public static void LogErrorFormat(Object context, string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180967590-0x0000000180967680
		public static void LogException(Exception exception) {} // 0x00000001809679E0-0x0000000180967AB0
		public static void LogException(Exception exception, Object context) {} // 0x0000000180967910-0x00000001809679E0
		public static void LogWarning(object message) {} // 0x0000000180967E50-0x0000000180967F20
		public static void LogWarning(object message, Object context) {} // 0x0000000180967F20-0x0000000180968000
		public static void LogWarningFormat(string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180967C80-0x0000000180967D60
		public static void LogWarningFormat(Object context, string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180967D60-0x0000000180967E50
		// [Conditional] // 0x000000018012C780-0x000000018012C7B0
		public static void Assert(bool condition) {} // 0x0000000180966B20-0x0000000180966C00
		// [Conditional] // 0x000000018012C780-0x000000018012C7B0
		public static void Assert(bool condition, string message) {} // 0x0000000180966C00-0x0000000180966CE0
		// [Conditional] // 0x000000018012C780-0x000000018012C7B0
		public static void LogAssertion(object message) {} // 0x00000001809674C0-0x0000000180967590
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		internal static bool CallOverridenDebugHandler(Exception exception, Object obj) => default; // 0x0000000180966CE0-0x0000000180966E50
		private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, [DefaultValue] /* 0x000000018012EF80-0x000000018012EFB0 */ ref Color color, [DefaultValue] /* 0x000000018012F090-0x000000018012F0C0 */ float duration, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool depthTest) {} // 0x0000000180966E50-0x0000000180966EC0
	}
}
