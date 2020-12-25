/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class CVRExtendedDisplay // TypeDefIndex: 8208
	{
		// Fields
		private IVRExtendedDisplay FnTable; // 0x10
	
		// Constructors
		public CVRExtendedDisplay() {} // Dummy constructor
		internal CVRExtendedDisplay(IntPtr pInterface) {} // 0x00000001811DDDB0-0x00000001811DDEB0
	
		// Methods
		public void GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight) {} // 0x00000001811DDD70-0x00000001811DDDB0
		public void GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight) {} // 0x00000001811DDD30-0x00000001811DDD70
		public void GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex) {} // 0x00000001811DDD00-0x00000001811DDD30
	}
}
