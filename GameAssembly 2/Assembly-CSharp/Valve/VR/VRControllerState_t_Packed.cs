/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public struct VRControllerState_t_Packed // TypeDefIndex: 8318
	{
		// Fields
		public uint unPacketNum; // 0x00
		public ulong ulButtonPressed; // 0x04
		public ulong ulButtonTouched; // 0x0C
		public VRControllerAxis_t rAxis0; // 0x14
		public VRControllerAxis_t rAxis1; // 0x1C
		public VRControllerAxis_t rAxis2; // 0x24
		public VRControllerAxis_t rAxis3; // 0x2C
		public VRControllerAxis_t rAxis4; // 0x34
	
		// Constructors
		public VRControllerState_t_Packed(VRControllerState_t unpacked) {
			unPacketNum = default;
			ulButtonPressed = default;
			ulButtonTouched = default;
			rAxis0 = default;
			rAxis1 = default;
			rAxis2 = default;
			rAxis3 = default;
			rAxis4 = default;
		} // 0x00000001801DA3F0-0x00000001801DA490
	
		// Methods
		public void Unpack(ref VRControllerState_t unpacked) {} // 0x00000001801DA370-0x00000001801DA3F0
	}
}
