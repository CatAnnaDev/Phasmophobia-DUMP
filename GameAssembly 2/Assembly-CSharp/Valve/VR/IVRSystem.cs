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
	public struct IVRSystem // TypeDefIndex: 7904
	{
		// Fields
		internal _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize; // 0x00
		internal _GetProjectionMatrix GetProjectionMatrix; // 0x08
		internal _GetProjectionRaw GetProjectionRaw; // 0x10
		internal _ComputeDistortion ComputeDistortion; // 0x18
		internal _GetEyeToHeadTransform GetEyeToHeadTransform; // 0x20
		internal _GetTimeSinceLastVsync GetTimeSinceLastVsync; // 0x28
		internal _GetD3D9AdapterIndex GetD3D9AdapterIndex; // 0x30
		internal _GetDXGIOutputInfo GetDXGIOutputInfo; // 0x38
		internal _GetOutputDevice GetOutputDevice; // 0x40
		internal _IsDisplayOnDesktop IsDisplayOnDesktop; // 0x48
		internal _SetDisplayVisibility SetDisplayVisibility; // 0x50
		internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose; // 0x58
		internal _ResetSeatedZeroPose ResetSeatedZeroPose; // 0x60
		internal _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose; // 0x68
		internal _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose; // 0x70
		internal _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass; // 0x78
		internal _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel; // 0x80
		internal _ApplyTransform ApplyTransform; // 0x88
		internal _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole; // 0x90
		internal _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex; // 0x98
		internal _GetTrackedDeviceClass GetTrackedDeviceClass; // 0xA0
		internal _IsTrackedDeviceConnected IsTrackedDeviceConnected; // 0xA8
		internal _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty; // 0xB0
		internal _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty; // 0xB8
		internal _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty; // 0xC0
		internal _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty; // 0xC8
		internal _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty; // 0xD0
		internal _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty; // 0xD8
		internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum; // 0xE0
		internal _PollNextEvent PollNextEvent; // 0xE8
		internal _PollNextEventWithPose PollNextEventWithPose; // 0xF0
		internal _GetEventTypeNameFromEnum GetEventTypeNameFromEnum; // 0xF8
		internal _GetHiddenAreaMesh GetHiddenAreaMesh; // 0x100
		internal _GetControllerState GetControllerState; // 0x108
		internal _GetControllerStateWithPose GetControllerStateWithPose; // 0x110
		internal _TriggerHapticPulse TriggerHapticPulse; // 0x118
		internal _GetButtonIdNameFromEnum GetButtonIdNameFromEnum; // 0x120
		internal _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum; // 0x128
		internal _CaptureInputFocus CaptureInputFocus; // 0x130
		internal _ReleaseInputFocus ReleaseInputFocus; // 0x138
		internal _IsInputFocusCapturedByAnotherProcess IsInputFocusCapturedByAnotherProcess; // 0x140
		internal _DriverDebugRequest DriverDebugRequest; // 0x148
		internal _PerformFirmwareUpdate PerformFirmwareUpdate; // 0x150
		internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting; // 0x158
		internal _AcknowledgeQuit_UserPrompt AcknowledgeQuit_UserPrompt; // 0x160
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 7905; 0x000000018047CEC0-0x000000018047D1A0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate HmdMatrix44_t _GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ); // TypeDefIndex: 7906; 0x0000000181F3B2B0-0x0000000181F3B690
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom); // TypeDefIndex: 7907; 0x0000000181E66D60-0x0000000181E67130
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates); // TypeDefIndex: 7908; 0x0000000181F36120-0x0000000181F364C0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate HmdMatrix34_t _GetEyeToHeadTransform(EVREye eEye); // TypeDefIndex: 7909; 0x0000000181F39130-0x0000000181F39470
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter); // TypeDefIndex: 7910; 0x00000001811EC860-0x00000001811ECB50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate int _GetD3D9AdapterIndex(); // TypeDefIndex: 7911; 0x0000000180A8BB90-0x0000000180A8BE20
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex); // TypeDefIndex: 7912; 0x0000000181E6EFA0-0x0000000181E6F160
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetOutputDevice(ref ulong pnDevice, ETextureType textureType); // TypeDefIndex: 7913; 0x000000018047AFB0-0x000000018047B290
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsDisplayOnDesktop(); // TypeDefIndex: 7914; 0x00000001811E8170-0x00000001811E8310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _SetDisplayVisibility(bool bIsVisibleOnDesktop); // TypeDefIndex: 7915; 0x00000001815C2770-0x00000001815C2A60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, [In, Out] TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount); // TypeDefIndex: 7916; 0x0000000181F38C60-0x0000000181F38FE0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ResetSeatedZeroPose(); // TypeDefIndex: 7917; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate HmdMatrix34_t _GetSeatedZeroPoseToStandingAbsoluteTrackingPose(); // TypeDefIndex: 7918; 0x0000000181F3B810-0x0000000181F3BA00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate HmdMatrix34_t _GetRawZeroPoseToStandingAbsoluteTrackingPose(); // TypeDefIndex: 7919; 0x0000000181F3B810-0x0000000181F3BA00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, [In, Out] uint[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex); // TypeDefIndex: 7920; 0x0000000181F3CCE0-0x0000000181F3D070
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EDeviceActivityLevel _GetTrackedDeviceActivityLevel(uint unDeviceId); // TypeDefIndex: 7921; 0x0000000181F38790-0x0000000181F38960
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform); // TypeDefIndex: 7922; 0x000000018047BD10-0x000000018047C020
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType); // TypeDefIndex: 7923; 0x0000000181AA8BF0-0x0000000181AA8ED0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate ETrackedControllerRole _GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex); // TypeDefIndex: 7924; 0x0000000181F38790-0x0000000181F38960
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate ETrackedDeviceClass _GetTrackedDeviceClass(uint unDeviceIndex); // TypeDefIndex: 7925; 0x0000000181F38790-0x0000000181F38960
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsTrackedDeviceConnected(uint unDeviceIndex); // TypeDefIndex: 7926; 0x00000001808287F0-0x0000000180828AD0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 7927; 0x0000000181F367B0-0x0000000181F36B20
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate float _GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 7928; 0x0000000181F39560-0x0000000181F398D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate int _GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 7929; 0x0000000181F3A380-0x0000000181F3A6F0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate ulong _GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 7930; 0x0000000181F3DA70-0x0000000181F3DDE0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate HmdMatrix34_t _GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError); // TypeDefIndex: 7931; 0x0000000181F3ADA0-0x0000000181F3B160
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError); // TypeDefIndex: 7932; 0x0000000181F3C870-0x0000000181F3CAF0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error); // TypeDefIndex: 7933; 0x00000001811EA830-0x00000001811EAA00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent); // TypeDefIndex: 7934; 0x00000001811EE520-0x00000001811EE810
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose); // TypeDefIndex: 7935; 0x0000000181F3F820-0x0000000181F3FBB0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate IntPtr _GetEventTypeNameFromEnum(EVREventType eType); // TypeDefIndex: 7936; 0x00000001811EA830-0x00000001811EAA00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate HiddenAreaMesh_t _GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type); // TypeDefIndex: 7937; 0x0000000181F39F20-0x0000000181F3A2D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize); // TypeDefIndex: 7938; 0x00000001811EBB90-0x00000001811EBF00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose); // TypeDefIndex: 7939; 0x00000001811EBFF0-0x00000001811EC3D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec); // TypeDefIndex: 7940; 0x0000000181F44350-0x0000000181F446B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate IntPtr _GetButtonIdNameFromEnum(EVRButtonId eButtonId); // TypeDefIndex: 7941; 0x00000001811EA830-0x00000001811EAA00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate IntPtr _GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType); // TypeDefIndex: 7942; 0x00000001811EA830-0x00000001811EAA00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _CaptureInputFocus(); // TypeDefIndex: 7943; 0x00000001811E8170-0x00000001811E8310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ReleaseInputFocus(); // TypeDefIndex: 7944; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsInputFocusCapturedByAnotherProcess(); // TypeDefIndex: 7945; 0x00000001811E8170-0x00000001811E8310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _DriverDebugRequest(uint unDeviceIndex, string pchRequest, string pchResponseBuffer, uint unResponseBufferSize); // TypeDefIndex: 7946; 0x0000000181E6F2D0-0x0000000181E6F660
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRFirmwareError _PerformFirmwareUpdate(uint unDeviceIndex); // TypeDefIndex: 7947; 0x0000000181F38790-0x0000000181F38960
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _AcknowledgeQuit_Exiting(); // TypeDefIndex: 7948; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _AcknowledgeQuit_UserPrompt(); // TypeDefIndex: 7949; 0x00000001802D1BD0-0x00000001802D1D60
	}
}
