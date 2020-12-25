/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public struct VREvent_t_Packed // TypeDefIndex: 8314
	{
		// Fields
		public uint eventType; // 0x00
		public uint trackedDeviceIndex; // 0x04
		public float eventAgeSeconds; // 0x08
		public VREvent_Data_t data; // 0x0C
	
		// Constructors
		public VREvent_t_Packed(VREvent_t unpacked) {
			eventType = default;
			trackedDeviceIndex = default;
			eventAgeSeconds = default;
			data = default;
		} // 0x00000001801DA4C0-0x00000001801DA500
	
		// Methods
		public void Unpack(ref VREvent_t unpacked) {} // 0x00000001801DA490-0x00000001801DA4C0
	}
}
