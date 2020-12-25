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
	public class Subscription // TypeDefIndex: 7376
	{
		// Fields
		private static StatusCallback2 isReadyIl2cppCallback; // 0x00
	
		// Constructors
		public Subscription() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		// [MonoPInvokeCallback] // 0x0000000180130A10-0x0000000180130A60
		private static void IsReadyIl2cppCallback(int errorCode, string message) {} // 0x0000000181B55E10-0x0000000181B55E70
		public static void IsReady(StatusCallback2 callback) {} // 0x0000000181B55F70-0x0000000181B56240
		public static SubscriptionStatus GetUserStatus() => default; // 0x0000000181B558F0-0x0000000181B55D30
	}
}
