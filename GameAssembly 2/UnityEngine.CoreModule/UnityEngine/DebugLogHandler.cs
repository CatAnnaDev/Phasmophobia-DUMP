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
	// [NativeHeader] // 0x000000018012EA00-0x000000018012EA30
	internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 3121
	{
		// Constructors
		public DebugLogHandler() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		[ThreadAndSerializationSafe] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) {} // 0x00000001809669B0-0x0000000180966A10
		[ThreadAndSerializationSafe] // 0x00000001800D4E50-0x00000001800D4E60
		internal static void Internal_LogException(Exception exception, Object obj) {} // 0x0000000180966960-0x00000001809669B0
		public void LogFormat(LogType logType, Object context, string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180966AB0-0x0000000180966B20
		public void LogException(Exception exception, Object context) {} // 0x0000000180966A10-0x0000000180966AB0
	}
}
