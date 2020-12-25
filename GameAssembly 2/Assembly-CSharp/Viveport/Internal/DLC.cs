/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Viveport.Internal
{
	internal class DLC // TypeDefIndex: 7399
	{
		// Constructors
		static DLC() {} // 0x0000000181B47B50-0x0000000181B47BA0
		public DLC() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		internal static extern int IsReady(StatusCallback callback); // 0x0000000181B478C0-0x0000000181B47940
		internal static extern int IsReady_64(StatusCallback callback); // 0x0000000181B47840-0x0000000181B478C0
		internal static extern int GetCount(); // 0x0000000181B47100-0x0000000181B47170
		internal static extern int GetCount_64(); // 0x0000000181B46F60-0x0000000181B46FD0
		internal static extern bool GetIsAvailable(int index, StringBuilder appId, out bool isAvailable); // 0x0000000181B47240-0x0000000181B47310
		internal static extern bool GetIsAvailable_64(int index, StringBuilder appId, out bool isAvailable); // 0x0000000181B47170-0x0000000181B47240
		internal static extern int IsSubscribed(); // 0x0000000181B47AE0-0x0000000181B47B50
		internal static extern int IsSubscribed_64(); // 0x0000000181B47940-0x0000000181B479B0
	}
}
