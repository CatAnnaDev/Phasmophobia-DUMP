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
	internal class User // TypeDefIndex: 7396
	{
		// Constructors
		static User() {} // 0x0000000181B5B2B0-0x0000000181B5B300
		public User() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		internal static extern int IsReady(StatusCallback IsReadyCallback); // 0x0000000181B5AF60-0x0000000181B5AFE0
		internal static extern int IsReady_64(StatusCallback IsReadyCallback); // 0x0000000181B5AEE0-0x0000000181B5AF60
		internal static extern int GetUserID(StringBuilder userId, int size); // 0x0000000181B5A900-0x0000000181B5A9B0
		internal static extern int GetUserID_64(StringBuilder userId, int size); // 0x0000000181B5A850-0x0000000181B5A900
		internal static extern int GetUserName(StringBuilder userName, int size); // 0x0000000181B5AC20-0x0000000181B5ACD0
		internal static extern int GetUserName_64(StringBuilder userName, int size); // 0x0000000181B5AB70-0x0000000181B5AC20
		internal static extern int GetUserAvatarUrl(StringBuilder userAvatarUrl, int size); // 0x0000000181B5A7A0-0x0000000181B5A850
		internal static extern int GetUserAvatarUrl_64(StringBuilder userAvatarUrl, int size); // 0x0000000181B5A530-0x0000000181B5A5E0
	}
}
