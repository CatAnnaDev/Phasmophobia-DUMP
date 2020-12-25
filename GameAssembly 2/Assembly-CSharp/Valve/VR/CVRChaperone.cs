/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class CVRChaperone // TypeDefIndex: 8211
	{
		// Fields
		private IVRChaperone FnTable; // 0x10
	
		// Constructors
		public CVRChaperone() {} // Dummy constructor
		internal CVRChaperone(IntPtr pInterface) {} // 0x00000001811DD200-0x00000001811DD300
	
		// Methods
		public ChaperoneCalibrationState GetCalibrationState() => default; // 0x00000001811DD140-0x00000001811DD160
		public bool GetPlayAreaSize(ref float pSizeX, ref float pSizeZ) => default; // 0x00000001811DD180-0x00000001811DD1B0
		public bool GetPlayAreaRect(ref HmdQuad_t rect) => default; // 0x00000001811DD160-0x00000001811DD180
		public void ReloadInfo() {} // 0x00000001811DD1B0-0x00000001811DD1D0
		public void SetSceneColor(HmdColor_t color) {} // 0x00000001811DD1D0-0x00000001811DD200
		public void GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor) {} // 0x00000001811DD110-0x00000001811DD140
		public bool AreBoundsVisible() => default; // 0x00000001811DD0D0-0x00000001811DD0F0
		public void ForceBoundsVisible(bool bForce) {} // 0x00000001811DD0F0-0x00000001811DD110
	}
}
