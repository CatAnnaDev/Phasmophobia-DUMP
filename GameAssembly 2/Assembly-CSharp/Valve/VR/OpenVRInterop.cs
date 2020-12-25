/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class OpenVRInterop // TypeDefIndex: 8225
	{
		// Constructors
		public OpenVRInterop() {} // 0x00000001802466A0-0x00000001802466B0
	
		// Methods
		internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType); // 0x0000000180EE76F0-0x0000000180EE7780
		internal static extern void ShutdownInternal(); // 0x0000000180EE7900-0x0000000180EE7970
		internal static extern bool IsHmdPresent(); // 0x0000000180EE7780-0x0000000180EE77F0
		internal static extern bool IsRuntimeInstalled(); // 0x0000000180EE7890-0x0000000180EE7900
		internal static extern IntPtr GetStringForHmdError(EVRInitError error); // 0x0000000180EE7670-0x0000000180EE76F0
		internal static extern IntPtr GetGenericInterface(in string pchInterfaceVersion, ref EVRInitError peError); // 0x0000000180EE7550-0x0000000180EE7600
		internal static extern bool IsInterfaceVersionValid(in string pchInterfaceVersion); // 0x0000000180EE77F0-0x0000000180EE7890
		internal static extern uint GetInitToken(); // 0x0000000180EE7600-0x0000000180EE7670
	}
}
