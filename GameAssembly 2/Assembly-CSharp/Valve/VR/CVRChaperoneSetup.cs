/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class CVRChaperoneSetup // TypeDefIndex: 8212
	{
		// Fields
		private IVRChaperoneSetup FnTable; // 0x10
	
		// Constructors
		public CVRChaperoneSetup() {} // Dummy constructor
		internal CVRChaperoneSetup(IntPtr pInterface) {} // 0x00000001811DCF90-0x00000001811DD0D0
	
		// Methods
		public bool CommitWorkingCopy(EChaperoneConfigFile configFile) => default; // 0x00000001811DCAD0-0x00000001811DCAF0
		public void RevertWorkingCopy() {} // 0x00000001803DA950-0x00000001803DA970
		public bool GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ) => default; // 0x00000001811DCDE0-0x00000001811DCE10
		public bool GetWorkingPlayAreaRect(ref HmdQuad_t rect) => default; // 0x00000001811DCDC0-0x00000001811DCDE0
		public bool GetWorkingCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer) {
			pQuadsBuffer = default;
			return default;
		} // 0x00000001811DCD20-0x00000001811DCDC0
		public bool GetLiveCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer) {
			pQuadsBuffer = default;
			return default;
		} // 0x00000001811DCB20-0x00000001811DCBC0
		public bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose) => default; // 0x00000001811DCE10-0x00000001811DCE30
		public bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose) => default; // 0x00000001811DCE30-0x00000001811DCE50
		public void SetWorkingPlayAreaSize(float sizeX, float sizeZ) {} // 0x00000001811DCF30-0x00000001811DCF50
		public void SetWorkingCollisionBoundsInfo(HmdQuad_t[] pQuadsBuffer) {} // 0x00000001811DCEA0-0x00000001811DCED0
		public void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose) {} // 0x00000001811DCF50-0x00000001811DCF70
		public void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose) {} // 0x00000001811DCF70-0x00000001811DCF90
		public void ReloadFromDisk(EChaperoneConfigFile configFile) {} // 0x00000001811DCE80-0x00000001811DCEA0
		public bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose) => default; // 0x00000001811DCD00-0x00000001811DCD20
		public void SetWorkingCollisionBoundsTagsInfo(byte[] pTagsBuffer) {} // 0x00000001811DCED0-0x00000001811DCF00
		public bool GetLiveCollisionBoundsTagsInfo(out byte[] pTagsBuffer) {
			pTagsBuffer = default;
			return default;
		} // 0x00000001811DCBC0-0x00000001811DCC60
		public bool SetWorkingPhysicalBoundsInfo(HmdQuad_t[] pQuadsBuffer) => default; // 0x00000001811DCF00-0x00000001811DCF30
		public bool GetLivePhysicalBoundsInfo(out HmdQuad_t[] pQuadsBuffer) {
			pQuadsBuffer = default;
			return default;
		} // 0x00000001811DCC60-0x00000001811DCD00
		public bool ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength) => default; // 0x00000001811DCAF0-0x00000001811DCB20
		public bool ImportFromBufferToWorking(string pBuffer, uint nImportFlags) => default; // 0x00000001811DCE50-0x00000001811DCE80
	}
}
