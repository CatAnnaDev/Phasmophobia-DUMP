/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	public class Logger : ILogger // TypeDefIndex: 3214
	{
		// Properties
		public ILogHandler logHandler { get; set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
		public bool logEnabled { get; set; } // 0x00000001802D9720-0x00000001802D9730 0x00000001803DE8D0-0x00000001803DE8E0
		public LogType filterLogType { get; set; } // 0x000000018027A6E0-0x000000018027A6F0 0x00000001802D6530-0x00000001802D6540
	
		// Constructors
		public Logger() {} // Dummy constructor
		public Logger(ILogHandler logHandler) {} // 0x0000000180930D80-0x0000000180930DC0
	
		// Methods
		public bool IsLogTypeAllowed(LogType logType) => default; // 0x00000001809308F0-0x0000000180930910
		private static string GetString(object message) => default; // 0x00000001809307E0-0x00000001809308F0
		public void Log(LogType logType, object message) {} // 0x0000000180930B30-0x0000000180930C50
		public void Log(LogType logType, object message, Object context) {} // 0x0000000180930C50-0x0000000180930D80
		public void LogFormat(LogType logType, string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180930A90-0x0000000180930B30
		public void LogFormat(LogType logType, Object context, string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x00000001809309F0-0x0000000180930A90
		public void LogException(Exception exception, Object context) {} // 0x0000000180930910-0x00000001809309F0
	}
}
