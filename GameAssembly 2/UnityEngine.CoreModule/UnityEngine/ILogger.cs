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
	public interface ILogger : ILogHandler // TypeDefIndex: 3212
	{
		// Properties
		ILogHandler logHandler { get; }
	
		// Methods
		void Log(LogType logType, object message);
		void Log(LogType logType, object message, Object context);
		void LogFormat(LogType logType, string format, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args);
	}
}
