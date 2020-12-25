/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport.Core
{
	public class Logger // TypeDefIndex: 7409
	{
		// Fields
		private const string LoggerTypeNameUnity = "UnityEngine.Debug"; // Metadata: 0x00653712
		private static bool _hasDetected; // 0x00
		private static bool _usingUnityLog; // 0x01
		private static Type _unityLogType; // 0x08
	
		// Constructors
		public Logger() {} // 0x00000001802466A0-0x00000001802466B0
		static Logger() {} // 0x0000000181B529B0-0x0000000181B529F0
	
		// Methods
		public static void Log(string message) {} // 0x0000000181B52490-0x0000000181B52560
		private static void ConsoleLog(string message) {} // 0x0000000181B52280-0x0000000181B52320
		private static void UnityLog(string message) {} // 0x0000000181B52560-0x0000000181B529B0
		private static Type GetType(string typeName) => default; // 0x0000000181B52320-0x0000000181B52490
	}
}
