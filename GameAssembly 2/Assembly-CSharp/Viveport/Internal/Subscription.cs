/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport.Internal
{
	internal class Subscription // TypeDefIndex: 7400
	{
		// Constructors
		static Subscription() {} // 0x0000000181B56320-0x0000000181B56370
		public Subscription() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		internal static extern void IsReady(StatusCallback2 IsReadyCallback); // 0x0000000181B55EF0-0x0000000181B55F70
		internal static extern void IsReady_64(StatusCallback2 IsReadyCallback); // 0x0000000181B55E70-0x0000000181B55EF0
		internal static extern bool IsWindowsSubscriber(); // 0x0000000181B562B0-0x0000000181B56320
		internal static extern bool IsWindowsSubscriber_64(); // 0x0000000181B56240-0x0000000181B562B0
		internal static extern bool IsAndroidSubscriber(); // 0x0000000181B55DA0-0x0000000181B55E10
		internal static extern bool IsAndroidSubscriber_64(); // 0x0000000181B55D30-0x0000000181B55DA0
		internal static extern ESubscriptionTransactionType GetTransactionType(); // 0x0000000181B55880-0x0000000181B558F0
		internal static extern ESubscriptionTransactionType GetTransactionType_64(); // 0x0000000181B55810-0x0000000181B55880
	}
}
