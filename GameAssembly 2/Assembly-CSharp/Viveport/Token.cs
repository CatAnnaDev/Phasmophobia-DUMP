/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using Viveport.Internal;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport
{
	internal class Token // TypeDefIndex: 7378
	{
		// Fields
		private static StatusCallback isReadyIl2cppCallback; // 0x00
		private static StatusCallback2 getSessionTokenIl2cppCallback; // 0x08
	
		// Constructors
		public Token() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		// [MonoPInvokeCallback] // 0x0000000180131A20-0x0000000180131A70
		private static void IsReadyIl2cppCallback(int errorCode) {} // 0x0000000181B567B0-0x0000000181B56800
		public static void IsReady(StatusCallback callback) {} // 0x0000000181B56880-0x0000000181B56B50
		// [MonoPInvokeCallback] // 0x0000000180131AE0-0x0000000180131B30
		private static void GetSessionTokenIl2cppCallback(int errorCode, string message) {} // 0x0000000181B56370-0x0000000181B563D0
		public static void GetSessionToken(StatusCallback2 callback) {} // 0x0000000181B56450-0x0000000181B56730
	}
}
