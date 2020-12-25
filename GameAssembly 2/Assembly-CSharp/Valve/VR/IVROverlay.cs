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
	public struct IVROverlay // TypeDefIndex: 8071
	{
		// Fields
		internal _FindOverlay FindOverlay; // 0x00
		internal _CreateOverlay CreateOverlay; // 0x08
		internal _DestroyOverlay DestroyOverlay; // 0x10
		internal _SetHighQualityOverlay SetHighQualityOverlay; // 0x18
		internal _GetHighQualityOverlay GetHighQualityOverlay; // 0x20
		internal _GetOverlayKey GetOverlayKey; // 0x28
		internal _GetOverlayName GetOverlayName; // 0x30
		internal _SetOverlayName SetOverlayName; // 0x38
		internal _GetOverlayImageData GetOverlayImageData; // 0x40
		internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum; // 0x48
		internal _SetOverlayRenderingPid SetOverlayRenderingPid; // 0x50
		internal _GetOverlayRenderingPid GetOverlayRenderingPid; // 0x58
		internal _SetOverlayFlag SetOverlayFlag; // 0x60
		internal _GetOverlayFlag GetOverlayFlag; // 0x68
		internal _SetOverlayColor SetOverlayColor; // 0x70
		internal _GetOverlayColor GetOverlayColor; // 0x78
		internal _SetOverlayAlpha SetOverlayAlpha; // 0x80
		internal _GetOverlayAlpha GetOverlayAlpha; // 0x88
		internal _SetOverlayTexelAspect SetOverlayTexelAspect; // 0x90
		internal _GetOverlayTexelAspect GetOverlayTexelAspect; // 0x98
		internal _SetOverlaySortOrder SetOverlaySortOrder; // 0xA0
		internal _GetOverlaySortOrder GetOverlaySortOrder; // 0xA8
		internal _SetOverlayWidthInMeters SetOverlayWidthInMeters; // 0xB0
		internal _GetOverlayWidthInMeters GetOverlayWidthInMeters; // 0xB8
		internal _SetOverlayAutoCurveDistanceRangeInMeters SetOverlayAutoCurveDistanceRangeInMeters; // 0xC0
		internal _GetOverlayAutoCurveDistanceRangeInMeters GetOverlayAutoCurveDistanceRangeInMeters; // 0xC8
		internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace; // 0xD0
		internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace; // 0xD8
		internal _SetOverlayTextureBounds SetOverlayTextureBounds; // 0xE0
		internal _GetOverlayTextureBounds GetOverlayTextureBounds; // 0xE8
		internal _GetOverlayRenderModel GetOverlayRenderModel; // 0xF0
		internal _SetOverlayRenderModel SetOverlayRenderModel; // 0xF8
		internal _GetOverlayTransformType GetOverlayTransformType; // 0x100
		internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute; // 0x108
		internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute; // 0x110
		internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative; // 0x118
		internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative; // 0x120
		internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent; // 0x128
		internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent; // 0x130
		internal _GetOverlayTransformOverlayRelative GetOverlayTransformOverlayRelative; // 0x138
		internal _SetOverlayTransformOverlayRelative SetOverlayTransformOverlayRelative; // 0x140
		internal _ShowOverlay ShowOverlay; // 0x148
		internal _HideOverlay HideOverlay; // 0x150
		internal _IsOverlayVisible IsOverlayVisible; // 0x158
		internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates; // 0x160
		internal _PollNextOverlayEvent PollNextOverlayEvent; // 0x168
		internal _GetOverlayInputMethod GetOverlayInputMethod; // 0x170
		internal _SetOverlayInputMethod SetOverlayInputMethod; // 0x178
		internal _GetOverlayMouseScale GetOverlayMouseScale; // 0x180
		internal _SetOverlayMouseScale SetOverlayMouseScale; // 0x188
		internal _ComputeOverlayIntersection ComputeOverlayIntersection; // 0x190
		internal _HandleControllerOverlayInteractionAsMouse HandleControllerOverlayInteractionAsMouse; // 0x198
		internal _IsHoverTargetOverlay IsHoverTargetOverlay; // 0x1A0
		internal _GetGamepadFocusOverlay GetGamepadFocusOverlay; // 0x1A8
		internal _SetGamepadFocusOverlay SetGamepadFocusOverlay; // 0x1B0
		internal _SetOverlayNeighbor SetOverlayNeighbor; // 0x1B8
		internal _MoveGamepadFocusToNeighbor MoveGamepadFocusToNeighbor; // 0x1C0
		internal _SetOverlayTexture SetOverlayTexture; // 0x1C8
		internal _ClearOverlayTexture ClearOverlayTexture; // 0x1D0
		internal _SetOverlayRaw SetOverlayRaw; // 0x1D8
		internal _SetOverlayFromFile SetOverlayFromFile; // 0x1E0
		internal _GetOverlayTexture GetOverlayTexture; // 0x1E8
		internal _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle; // 0x1F0
		internal _GetOverlayTextureSize GetOverlayTextureSize; // 0x1F8
		internal _CreateDashboardOverlay CreateDashboardOverlay; // 0x200
		internal _IsDashboardVisible IsDashboardVisible; // 0x208
		internal _IsActiveDashboardOverlay IsActiveDashboardOverlay; // 0x210
		internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess; // 0x218
		internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess; // 0x220
		internal _ShowDashboard ShowDashboard; // 0x228
		internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice; // 0x230
		internal _ShowKeyboard ShowKeyboard; // 0x238
		internal _ShowKeyboardForOverlay ShowKeyboardForOverlay; // 0x240
		internal _GetKeyboardText GetKeyboardText; // 0x248
		internal _HideKeyboard HideKeyboard; // 0x250
		internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute; // 0x258
		internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay; // 0x260
		internal _SetOverlayIntersectionMask SetOverlayIntersectionMask; // 0x268
		internal _GetOverlayFlags GetOverlayFlags; // 0x270
		internal _ShowMessageOverlay ShowMessageOverlay; // 0x278
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle); // TypeDefIndex: 8072; 0x0000000181E65D90-0x0000000181E66180
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle); // TypeDefIndex: 8073; 0x00000001811EDA70-0x00000001811EDE90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle); // TypeDefIndex: 8074; 0x0000000181DE0140-0x0000000181DE0320
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetHighQualityOverlay(ulong ulOverlayHandle); // TypeDefIndex: 8075; 0x0000000181DE0140-0x0000000181DE0320
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate ulong _GetHighQualityOverlay(); // TypeDefIndex: 8076; 0x00000001815C87B0-0x00000001815C8950
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError); // TypeDefIndex: 8077; 0x0000000181E69930-0x0000000181E69B90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError); // TypeDefIndex: 8078; 0x0000000181E69930-0x0000000181E69B90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayName(ulong ulOverlayHandle, string pchName); // TypeDefIndex: 8079; 0x0000000181C89210-0x0000000181C89540
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight); // TypeDefIndex: 8080; 0x0000000181E693E0-0x0000000181E697C0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error); // TypeDefIndex: 8081; 0x0000000181DDFE60-0x0000000181DE0140
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID); // TypeDefIndex: 8082; 0x0000000181F3FCF0-0x0000000181F3FEF0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetOverlayRenderingPid(ulong ulOverlayHandle); // TypeDefIndex: 8083; 0x00000001807CD390-0x00000001807CD680
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled); // TypeDefIndex: 8084; 0x0000000181E6DF40-0x0000000181E6E2C0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled); // TypeDefIndex: 8085; 0x0000000180764C40-0x0000000180764FB0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue); // TypeDefIndex: 8086; 0x0000000181E6DAE0-0x0000000181E6DE90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue); // TypeDefIndex: 8087; 0x0000000181E68D70-0x0000000181E69120
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha); // TypeDefIndex: 8088; 0x0000000181E6D2B0-0x0000000181E6D5E0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha); // TypeDefIndex: 8089; 0x0000000181E66980-0x0000000181E66B80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect); // TypeDefIndex: 8090; 0x0000000181F42010-0x0000000181F42230
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect); // TypeDefIndex: 8091; 0x0000000181E66980-0x0000000181E66B80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder); // TypeDefIndex: 8092; 0x0000000181F3FCF0-0x0000000181F3FEF0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder); // TypeDefIndex: 8093; 0x0000000181E66980-0x0000000181E66B80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters); // TypeDefIndex: 8094; 0x0000000181F42010-0x0000000181F42230
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters); // TypeDefIndex: 8095; 0x0000000181E66980-0x0000000181E66B80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters); // TypeDefIndex: 8096; 0x0000000181E6D690-0x0000000181E6DA10
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters); // TypeDefIndex: 8097; 0x0000000181E688E0-0x0000000181E68C50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace); // TypeDefIndex: 8098; 0x0000000181E6C940-0x0000000181E6CC70
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace); // TypeDefIndex: 8099; 0x0000000181E66980-0x0000000181E66B80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds); // TypeDefIndex: 8100; 0x0000000181C89210-0x0000000181C89540
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds); // TypeDefIndex: 8101; 0x0000000181C89210-0x0000000181C89540
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetOverlayRenderModel(ulong ulOverlayHandle, string pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError); // TypeDefIndex: 8102; 0x0000000181E693E0-0x0000000181E697C0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayRenderModel(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor); // TypeDefIndex: 8103; 0x0000000181E688E0-0x0000000181E68C50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType); // TypeDefIndex: 8104; 0x0000000181E66980-0x0000000181E66B80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform); // TypeDefIndex: 8105; 0x0000000180764C40-0x0000000180764FB0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform); // TypeDefIndex: 8106; 0x0000000181E688E0-0x0000000181E68C50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform); // TypeDefIndex: 8107; 0x0000000180764C40-0x0000000180764FB0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform); // TypeDefIndex: 8108; 0x0000000181E688E0-0x0000000181E68C50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName); // TypeDefIndex: 8109; 0x0000000180764C40-0x0000000180764FB0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, string pchComponentName, uint unComponentNameSize); // TypeDefIndex: 8110; 0x0000000181E6AB20-0x0000000181E6AEC0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform); // TypeDefIndex: 8111; 0x0000000181E688E0-0x0000000181E68C50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform); // TypeDefIndex: 8112; 0x0000000181E688E0-0x0000000181E68C50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _ShowOverlay(ulong ulOverlayHandle); // TypeDefIndex: 8113; 0x00000001807CD390-0x00000001807CD680
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _HideOverlay(ulong ulOverlayHandle); // TypeDefIndex: 8114; 0x0000000181DE0140-0x0000000181DE0320
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsOverlayVisible(ulong ulOverlayHandle); // TypeDefIndex: 8115; 0x0000000181E001D0-0x0000000181E003B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform); // TypeDefIndex: 8116; 0x0000000181E6B190-0x0000000181E6B550
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent); // TypeDefIndex: 8117; 0x00000001811EE8C0-0x00000001811EEC30
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod); // TypeDefIndex: 8118; 0x0000000181E66980-0x0000000181E66B80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod); // TypeDefIndex: 8119; 0x0000000181E6C940-0x0000000181E6CC70
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale); // TypeDefIndex: 8120; 0x0000000181C89210-0x0000000181C89540
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale); // TypeDefIndex: 8121; 0x0000000181C89210-0x0000000181C89540
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults); // TypeDefIndex: 8122; 0x0000000181E63E10-0x0000000181E64180
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle, uint unControllerDeviceIndex); // TypeDefIndex: 8123; 0x0000000181E6BE50-0x0000000181E6C180
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle); // TypeDefIndex: 8124; 0x0000000181E001D0-0x0000000181E003B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate ulong _GetGamepadFocusOverlay(); // TypeDefIndex: 8125; 0x00000001815C87B0-0x00000001815C8950
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetGamepadFocusOverlay(ulong ulNewFocusOverlay); // TypeDefIndex: 8126; 0x0000000181DE0140-0x0000000181DE0320
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo); // TypeDefIndex: 8127; 0x0000000181E679B0-0x0000000181E67D20
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom); // TypeDefIndex: 8128; 0x00000001811ED1B0-0x00000001811ED4D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture); // TypeDefIndex: 8129; 0x0000000181C89210-0x0000000181C89540
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle); // TypeDefIndex: 8130; 0x0000000181DE0140-0x0000000181DE0320
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth); // TypeDefIndex: 8131; 0x0000000181F419A0-0x0000000181F41D80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath); // TypeDefIndex: 8132; 0x0000000181C89210-0x0000000181C89540
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds); // TypeDefIndex: 8133; 0x0000000181E6A360-0x0000000181E6A8D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle); // TypeDefIndex: 8134; 0x0000000181C89210-0x0000000181C89540
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight); // TypeDefIndex: 8135; 0x0000000181E688E0-0x0000000181E68C50
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle); // TypeDefIndex: 8136; 0x0000000181E64280-0x0000000181E647D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsDashboardVisible(); // TypeDefIndex: 8137; 0x00000001811E8170-0x00000001811E8310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle); // TypeDefIndex: 8138; 0x0000000181E001D0-0x0000000181E003B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId); // TypeDefIndex: 8139; 0x0000000181E6C940-0x0000000181E6CC70
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId); // TypeDefIndex: 8140; 0x0000000181E66980-0x0000000181E66B80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ShowDashboard(string pchOverlayToShow); // TypeDefIndex: 8141; 0x000000018070A7F0-0x000000018070AB70
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetPrimaryDashboardDevice(); // TypeDefIndex: 8142; 0x00000001811E8610-0x00000001811E87B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue); // TypeDefIndex: 8143; 0x0000000181F42F20-0x0000000181F433C0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue); // TypeDefIndex: 8144; 0x0000000181F42910-0x0000000181F42E00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetKeyboardText(StringBuilder pchText, uint cchText); // TypeDefIndex: 8145; 0x0000000181E675F0-0x0000000181E678F0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _HideKeyboard(); // TypeDefIndex: 8146; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform); // TypeDefIndex: 8147; 0x0000000180275080-0x00000001802753A0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect); // TypeDefIndex: 8148; 0x0000000181E6CE10-0x0000000181E6D170
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize); // TypeDefIndex: 8149; 0x0000000181E6E4D0-0x0000000181E6E870
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVROverlayError _GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags); // TypeDefIndex: 8150; 0x0000000181E66980-0x0000000181E66B80
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate VRMessageOverlayResponse _ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text); // TypeDefIndex: 8151; 0x0000000181F43420-0x0000000181F439D0
	}
}
