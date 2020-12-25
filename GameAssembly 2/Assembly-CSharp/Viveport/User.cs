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
	public class User // TypeDefIndex: 7353
	{
		// Fields
		private static StatusCallback isReadyIl2cppCallback; // 0x00
		private const int MaxIdLength = 256; // Metadata: 0x0065361E
		private const int MaxNameLength = 256; // Metadata: 0x00653622
		private const int MaxUrlLength = 512; // Metadata: 0x00653626
	
		// Constructors
		public User() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		// [MonoPInvokeCallback] // 0x0000000180126320-0x0000000180126370
		private static void IsReadyIl2cppCallback(int errorCode) {} // 0x0000000181B5AE90-0x0000000181B5AEE0
		public static int IsReady(StatusCallback callback) => default; // 0x0000000181B5AFE0-0x0000000181B5B2B0
		public static string GetUserId() => default; // 0x0000000181B5A9B0-0x0000000181B5AB70
		public static string GetUserName() => default; // 0x0000000181B5ACD0-0x0000000181B5AE90
		public static string GetUserAvatarUrl() => default; // 0x0000000181B5A5E0-0x0000000181B5A7A0
	}
}
