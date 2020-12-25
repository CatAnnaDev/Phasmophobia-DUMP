/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class CVRSystem // TypeDefIndex: 8201
	{
		// Fields
		private IVRSystem FnTable; // 0x10
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _PollNextEventPacked(ref VREvent_t_Packed pEvent, uint uncbVREvent); // TypeDefIndex: 8202; 0x00000001811EE520-0x00000001811EE810
	
		private struct PollNextEventUnion // TypeDefIndex: 8203
		{
			// Fields
			public IVRSystem._PollNextEvent pPollNextEvent; // 0x00
			public _PollNextEventPacked pPollNextEventPacked; // 0x00
		}
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetControllerStatePacked(uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize); // TypeDefIndex: 8204; 0x00000001811EBB90-0x00000001811EBF00
	
		private struct GetControllerStateUnion // TypeDefIndex: 8205
		{
			// Fields
			public IVRSystem._GetControllerState pGetControllerState; // 0x00
			public _GetControllerStatePacked pGetControllerStatePacked; // 0x00
		}
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetControllerStateWithPosePacked(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose); // TypeDefIndex: 8206; 0x00000001811EBFF0-0x00000001811EC3D0
	
		private struct GetControllerStateWithPoseUnion // TypeDefIndex: 8207
		{
			// Fields
			public IVRSystem._GetControllerStateWithPose pGetControllerStateWithPose; // 0x00
			public _GetControllerStateWithPosePacked pGetControllerStateWithPosePacked; // 0x00
		}
	
		// Constructors
		public CVRSystem() {} // Dummy constructor
		internal CVRSystem(IntPtr pInterface) {} // 0x00000001811E0E20-0x00000001811E0FB0
	
		// Methods
		public void GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight) {} // 0x00000001811E0940-0x00000001811E0970
		public HmdMatrix44_t GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ) => default; // 0x00000001811E07C0-0x00000001811E0830
		public void GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom) {} // 0x00000001811E0830-0x00000001811E0870
		public bool ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates) => default; // 0x00000001811DFF60-0x00000001811DFF90
		public HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye) => default; // 0x00000001811E0640-0x00000001811E0690
		public bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter) => default; // 0x00000001811E0A30-0x00000001811E0A60
		public int GetD3D9AdapterIndex() => default; // 0x00000001811E0530-0x00000001811E0550
		public void GetDXGIOutputInfo(ref int pnAdapterIndex) {} // 0x00000001811E0550-0x00000001811E0580
		public void GetOutputDevice(ref ulong pnDevice, ETextureType textureType) {} // 0x00000001811E0790-0x00000001811E07C0
		public bool IsDisplayOnDesktop() => default; // 0x00000001811E0B20-0x00000001811E0B40
		public bool SetDisplayVisibility(bool bIsVisibleOnDesktop) => default; // 0x00000001811E0DD0-0x00000001811E0DF0
		public void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, TrackedDevicePose_t[] pTrackedDevicePoseArray) {} // 0x00000001811E0580-0x00000001811E05C0
		public void ResetSeatedZeroPose() {} // 0x00000001811E0DB0-0x00000001811E0DD0
		public HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose() => default; // 0x00000001811E0970-0x00000001811E09C0
		public HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose() => default; // 0x00000001811E08F0-0x00000001811E0940
		public uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, uint[] punTrackedDeviceIndexArray, uint unRelativeToTrackedDeviceIndex) => default; // 0x00000001811E09C0-0x00000001811E0A00
		public EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId) => default; // 0x00000001811E0A60-0x00000001811E0A90
		public void ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform) {} // 0x00000001811DFF00-0x00000001811DFF30
		public uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType) => default; // 0x00000001811E0AC0-0x00000001811E0AF0
		public ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex) => default; // 0x00000001811E00F0-0x00000001811E0120
		public ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex) => default; // 0x00000001811E0A90-0x00000001811E0AC0
		public bool IsTrackedDeviceConnected(uint unDeviceIndex) => default; // 0x00000001811E0B70-0x00000001811E0BA0
		public bool GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) => default; // 0x00000001811DFFC0-0x00000001811DFFF0
		public float GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) => default; // 0x00000001811E0690-0x00000001811E06C0
		public int GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) => default; // 0x00000001811E0700-0x00000001811E0730
		public ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) => default; // 0x00000001811E0AF0-0x00000001811E0B20
		public HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) => default; // 0x00000001811E0730-0x00000001811E0790
		public uint GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError) => default; // 0x00000001811E0A00-0x00000001811E0A30
		public string GetPropErrorNameFromEnum(ETrackedPropertyError error) => default; // 0x00000001811E0870-0x00000001811E08F0
		public bool PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent) => default; // 0x00000001811E0C00-0x00000001811E0D80
		public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose) => default; // 0x00000001811E0BD0-0x00000001811E0C00
		public string GetEventTypeNameFromEnum(EVREventType eType) => default; // 0x00000001811E05C0-0x00000001811E0640
		public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type) => default; // 0x00000001811E06C0-0x00000001811E0700
		public bool GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize) => default; // 0x00000001811E0340-0x00000001811E0530
		public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose) => default; // 0x00000001811E0120-0x00000001811E0340
		public void TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec) {} // 0x00000001811E0DF0-0x00000001811E0E20
		public string GetButtonIdNameFromEnum(EVRButtonId eButtonId) => default; // 0x00000001811DFFF0-0x00000001811E0070
		public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType) => default; // 0x00000001811E0070-0x00000001811E00F0
		public bool CaptureInputFocus() => default; // 0x00000001811DFF30-0x00000001811DFF60
		public void ReleaseInputFocus() {} // 0x00000001811E0D80-0x00000001811E0DB0
		public bool IsInputFocusCapturedByAnotherProcess() => default; // 0x00000001811E0B40-0x00000001811E0B70
		public uint DriverDebugRequest(uint unDeviceIndex, string pchRequest, string pchResponseBuffer, uint unResponseBufferSize) => default; // 0x00000001811DFF90-0x00000001811DFFC0
		public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex) => default; // 0x00000001811E0BA0-0x00000001811E0BD0
		public void AcknowledgeQuit_Exiting() {} // 0x00000001811DFEA0-0x00000001811DFED0
		public void AcknowledgeQuit_UserPrompt() {} // 0x00000001811DFED0-0x00000001811DFF00
	}
}
