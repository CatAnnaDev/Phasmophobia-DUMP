/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport
{
	public class SubscriptionStatus // TypeDefIndex: 7348
	{
		// Properties
		public List<Platform> Platforms { get; set; } // 0x0000000180248E10-0x0000000180248E20 0x0000000180248410-0x0000000180248420
		public TransactionType Type { get; set; } // 0x000000018027A800-0x000000018027A810 0x000000018027AC40-0x000000018027AC50
	
		// Nested types
		public enum Platform // TypeDefIndex: 7349
		{
			Windows = 0,
			Android = 1
		}
	
		public enum TransactionType // TypeDefIndex: 7350
		{
			Unknown = 0,
			Paid = 1,
			Redeem = 2,
			FreeTrial = 3
		}
	
		// Constructors
		public SubscriptionStatus() {} // 0x0000000181B55790-0x0000000181B55810
	}
}
