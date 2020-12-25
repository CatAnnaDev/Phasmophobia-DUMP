/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon.Voice;
using UnityEngine;

// Image 52: PhotonVoice.dll - Assembly: PhotonVoice, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5360-5410

namespace Photon.Voice.Unity
{
	public class VoiceLogger : Photon.Voice.ILogger // TypeDefIndex: 5391
	{
		// Fields
		private readonly UnityEngine.Object context; // 0x20
	
		// Properties
		public string Tag { get; set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
		public DebugLevel LogLevel { get; set; } // 0x00000001802D9720-0x00000001802D9730 0x00000001803DE8D0-0x00000001803DE8E0
		public bool IsErrorEnabled { get => default; } // 0x0000000180F573B0-0x0000000180F573C0 
		public bool IsWarningEnabled { get => default; } // 0x0000000180F573D0-0x0000000180F573E0 
		public bool IsInfoEnabled { get => default; } // 0x0000000180F573C0-0x0000000180F573D0 
		public bool IsDebugEnabled { get => default; } // 0x0000000180F573A0-0x0000000180F573B0 
	
		// Constructors
		public VoiceLogger() {} // Dummy constructor
		public VoiceLogger(UnityEngine.Object context, string tag, DebugLevel level = DebugLevel.ERROR /* Metadata: 0x0064FA53 */) {} // 0x0000000180F57340-0x0000000180F573A0
		public VoiceLogger(string tag, DebugLevel level = DebugLevel.ERROR /* Metadata: 0x0064FA54 */) {} // 0x0000000180328A50-0x0000000180328AA0
	
		// Methods
		public void LogError(string fmt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180F57010-0x0000000180F57120
		public void LogWarning(string fmt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180F57230-0x0000000180F57340
		public void LogInfo(string fmt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180F57120-0x0000000180F57230
		public void LogDebug(string fmt, params /* 0x00000001800D4E50-0x00000001800D4E60 */ object[] args) {} // 0x0000000180F57000-0x0000000180F57010
		private string GetFormatString(string fmt) => default; // 0x0000000180F56EF0-0x0000000180F56F60
		private string GetTimestamp() => default; // 0x0000000180F56F60-0x0000000180F57000
	}
}
