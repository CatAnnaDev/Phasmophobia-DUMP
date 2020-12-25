/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public struct IVRChaperone // TypeDefIndex: 7999
	{
		// Fields
		internal _GetCalibrationState GetCalibrationState; // 0x00
		internal _GetPlayAreaSize GetPlayAreaSize; // 0x08
		internal _GetPlayAreaRect GetPlayAreaRect; // 0x10
		internal _ReloadInfo ReloadInfo; // 0x18
		internal _SetSceneColor SetSceneColor; // 0x20
		internal _GetBoundsColor GetBoundsColor; // 0x28
		internal _AreBoundsVisible AreBoundsVisible; // 0x30
		internal _ForceBoundsVisible ForceBoundsVisible; // 0x38
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate ChaperoneCalibrationState _GetCalibrationState(); // TypeDefIndex: 8000; 0x00000001811E8610-0x00000001811E87B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetPlayAreaSize(ref float pSizeX, ref float pSizeZ); // TypeDefIndex: 8001; 0x00000001811EC860-0x00000001811ECB50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetPlayAreaRect(ref HmdQuad_t rect); // TypeDefIndex: 8002; 0x00000001811EC4F0-0x00000001811EC7C0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ReloadInfo(); // TypeDefIndex: 8003; 0x0000000180533490-0x0000000180533710
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetSceneColor(HmdColor_t color); // TypeDefIndex: 8004; 0x0000000180448CB0-0x0000000180448FE0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor); // TypeDefIndex: 8005; 0x00000001811EB130-0x00000001811EB490
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _AreBoundsVisible(); // TypeDefIndex: 8006; 0x00000001811E8170-0x00000001811E8310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ForceBoundsVisible(bool bForce); // TypeDefIndex: 8007; 0x0000000180AEAE60-0x0000000180AEB150
	}
}
