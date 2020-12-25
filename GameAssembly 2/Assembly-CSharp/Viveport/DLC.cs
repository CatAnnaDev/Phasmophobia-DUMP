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
	public class DLC // TypeDefIndex: 7375
	{
		// Fields
		private static StatusCallback isDlcReadyIl2cppCallback; // 0x00
		private const int AppIdLength = 37; // Metadata: 0x00653682
	
		// Constructors
		public DLC() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		// [MonoPInvokeCallback] // 0x000000018012F5F0-0x000000018012F640
		private static void IsDlcReadyIl2cppCallback(int errorCode) {} // 0x0000000181B47520-0x0000000181B47570
		public static int IsDlcReady(StatusCallback callback) => default; // 0x0000000181B47570-0x0000000181B47840
		public static int GetCount() => default; // 0x0000000181B46FD0-0x0000000181B47100
		public static bool GetIsAvailable(int index, out string appId, out bool isAvailable) {
			appId = default;
			isAvailable = default;
			return default;
		} // 0x0000000181B47310-0x0000000181B47520
		public static int IsSubscribed() => default; // 0x0000000181B479B0-0x0000000181B47AE0
	}
}
