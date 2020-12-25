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
	public class CVROverlay // TypeDefIndex: 8214
	{
		// Fields
		private IVROverlay FnTable; // 0x10
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _PollNextOverlayEventPacked(ulong ulOverlayHandle, ref VREvent_t_Packed pEvent, uint uncbVREvent); // TypeDefIndex: 8215; 0x00000001811EE8C0-0x00000001811EEC30
	
		private struct PollNextOverlayEventUnion // TypeDefIndex: 8216
		{
			// Fields
			public IVROverlay._PollNextOverlayEvent pPollNextOverlayEvent; // 0x00
			public _PollNextOverlayEventPacked pPollNextOverlayEventPacked; // 0x00
		}
	
		// Constructors
		public CVROverlay() {} // Dummy constructor
		internal CVROverlay(IntPtr pInterface) {} // 0x00000001811DF0D0-0x00000001811DF220
	
		// Methods
		public EVROverlayError FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle) => default; // 0x00000001811DE0F0-0x00000001811DE120
		public EVROverlayError CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle) => default; // 0x00000001811DE0A0-0x00000001811DE0D0
		public EVROverlayError DestroyOverlay(ulong ulOverlayHandle) => default; // 0x00000001811DE0D0-0x00000001811DE0F0
		public EVROverlayError SetHighQualityOverlay(ulong ulOverlayHandle) => default; // 0x00000001811DEB00-0x00000001811DEB20
		public ulong GetHighQualityOverlay() => default; // 0x00000001811DE180-0x00000001811DE1A0
		public uint GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError) => default; // 0x00000001811DE3C0-0x00000001811DE3F0
		public uint GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError) => default; // 0x00000001811DE420-0x00000001811DE450
		public EVROverlayError SetOverlayName(ulong ulOverlayHandle, string pchName) => default; // 0x00000001811DED10-0x00000001811DED30
		public EVROverlayError GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight) => default; // 0x00000001811DE350-0x00000001811DE390
		public string GetOverlayErrorNameFromEnum(EVROverlayError error) => default; // 0x00000001811DE270-0x00000001811DE2F0
		public EVROverlayError SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID) => default; // 0x00000001811DEDC0-0x00000001811DEDE0
		public uint GetOverlayRenderingPid(ulong ulOverlayHandle) => default; // 0x00000001811DE480-0x00000001811DE4A0
		public EVROverlayError SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled) => default; // 0x00000001811DEC20-0x00000001811DEC50
		public EVROverlayError GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled) => default; // 0x00000001811DE2F0-0x00000001811DE320
		public EVROverlayError SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue) => default; // 0x00000001811DEBF0-0x00000001811DEC20
		public EVROverlayError GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue) => default; // 0x00000001811DE230-0x00000001811DE270
		public EVROverlayError SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha) => default; // 0x00000001811DEB90-0x00000001811DEBC0
		public EVROverlayError GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha) => default; // 0x00000001811DE1D0-0x00000001811DE200
		public EVROverlayError SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect) => default; // 0x00000001811DEE10-0x00000001811DEE40
		public EVROverlayError GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect) => default; // 0x00000001811DE4D0-0x00000001811DE500
		public EVROverlayError SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder) => default; // 0x00000001811DEDE0-0x00000001811DEE10
		public EVROverlayError GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder) => default; // 0x00000001811DE4A0-0x00000001811DE4D0
		public EVROverlayError SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters) => default; // 0x00000001811DEF90-0x00000001811DEFC0
		public EVROverlayError GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters) => default; // 0x00000001811DE6D0-0x00000001811DE700
		public EVROverlayError SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters) => default; // 0x00000001811DEBC0-0x00000001811DEBF0
		public EVROverlayError GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters) => default; // 0x00000001811DE200-0x00000001811DE230
		public EVROverlayError SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace) => default; // 0x00000001811DEE70-0x00000001811DEEA0
		public EVROverlayError GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace) => default; // 0x00000001811DE530-0x00000001811DE560
		public EVROverlayError SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds) => default; // 0x00000001811DEE40-0x00000001811DEE70
		public EVROverlayError GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds) => default; // 0x00000001811DE500-0x00000001811DE530
		public uint GetOverlayRenderModel(ulong ulOverlayHandle, string pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError) => default; // 0x00000001811DE450-0x00000001811DE480
		public EVROverlayError SetOverlayRenderModel(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor) => default; // 0x00000001811DED90-0x00000001811DEDC0
		public EVROverlayError GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType) => default; // 0x00000001811DE6A0-0x00000001811DE6D0
		public EVROverlayError SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform) => default; // 0x00000001811DEED0-0x00000001811DEF00
		public EVROverlayError GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform) => default; // 0x00000001811DE5E0-0x00000001811DE610
		public EVROverlayError SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform) => default; // 0x00000001811DEF60-0x00000001811DEF90
		public EVROverlayError GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform) => default; // 0x00000001811DE670-0x00000001811DE6A0
		public EVROverlayError SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName) => default; // 0x00000001811DEF30-0x00000001811DEF60
		public EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, string pchComponentName, uint unComponentNameSize) => default; // 0x00000001811DE640-0x00000001811DE670
		public EVROverlayError GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform) => default; // 0x00000001811DE610-0x00000001811DE640
		public EVROverlayError SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform) => default; // 0x00000001811DEF00-0x00000001811DEF30
		public EVROverlayError ShowOverlay(ulong ulOverlayHandle) => default; // 0x00000001811DF0A0-0x00000001811DF0D0
		public EVROverlayError HideOverlay(ulong ulOverlayHandle) => default; // 0x00000001811DE7C0-0x00000001811DE7F0
		public bool IsOverlayVisible(ulong ulOverlayHandle) => default; // 0x00000001811DE880-0x00000001811DE8B0
		public EVROverlayError GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform) => default; // 0x00000001811DE730-0x00000001811DE760
		public bool PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent) => default; // 0x00000001811DE8E0-0x00000001811DEA70
		public EVROverlayError GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod) => default; // 0x00000001811DE390-0x00000001811DE3C0
		public EVROverlayError SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod) => default; // 0x00000001811DEC80-0x00000001811DECB0
		public EVROverlayError GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale) => default; // 0x00000001811DE3F0-0x00000001811DE420
		public EVROverlayError SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale) => default; // 0x00000001811DECE0-0x00000001811DED10
		public bool ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults) => default; // 0x00000001811DE030-0x00000001811DE060
		public bool HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle, uint unControllerDeviceIndex) => default; // 0x00000001811DE760-0x00000001811DE790
		public bool IsHoverTargetOverlay(ulong ulOverlayHandle) => default; // 0x00000001811DE850-0x00000001811DE880
		public ulong GetGamepadFocusOverlay() => default; // 0x00000001811DE150-0x00000001811DE180
		public EVROverlayError SetGamepadFocusOverlay(ulong ulNewFocusOverlay) => default; // 0x00000001811DEAD0-0x00000001811DEB00
		public EVROverlayError SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo) => default; // 0x00000001811DED30-0x00000001811DED60
		public EVROverlayError MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom) => default; // 0x00000001811DE8B0-0x00000001811DE8E0
		public EVROverlayError SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture) => default; // 0x00000001811DEEA0-0x00000001811DEED0
		public EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle) => default; // 0x00000001811DE000-0x00000001811DE030
		public EVROverlayError SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth) => default; // 0x00000001811DED60-0x00000001811DED90
		public EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath) => default; // 0x00000001811DEC50-0x00000001811DEC80
		public EVROverlayError GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds) => default; // 0x00000001811DE590-0x00000001811DE5E0
		public EVROverlayError ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle) => default; // 0x00000001811DEA70-0x00000001811DEAA0
		public EVROverlayError GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight) => default; // 0x00000001811DE560-0x00000001811DE590
		public EVROverlayError CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle) => default; // 0x00000001811DE060-0x00000001811DE0A0
		public bool IsDashboardVisible() => default; // 0x00000001811DE820-0x00000001811DE850
		public bool IsActiveDashboardOverlay(ulong ulOverlayHandle) => default; // 0x00000001811DE7F0-0x00000001811DE820
		public EVROverlayError SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId) => default; // 0x00000001811DEAA0-0x00000001811DEAD0
		public EVROverlayError GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId) => default; // 0x00000001811DE120-0x00000001811DE150
		public void ShowDashboard(string pchOverlayToShow) {} // 0x00000001811DEFC0-0x00000001811DEFF0
		public uint GetPrimaryDashboardDevice() => default; // 0x00000001811DE700-0x00000001811DE730
		public EVROverlayError ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue) => default; // 0x00000001811DF030-0x00000001811DF070
		public EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue) => default; // 0x00000001811DEFF0-0x00000001811DF030
		public uint GetKeyboardText(StringBuilder pchText, uint cchText) => default; // 0x00000001811DE1A0-0x00000001811DE1D0
		public void HideKeyboard() {} // 0x00000001811DE790-0x00000001811DE7C0
		public void SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform) {} // 0x00000001811DEB60-0x00000001811DEB90
		public void SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect) {} // 0x00000001811DEB20-0x00000001811DEB60
		public EVROverlayError SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize) => default; // 0x00000001811DECB0-0x00000001811DECE0
		public EVROverlayError GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags) => default; // 0x00000001811DE320-0x00000001811DE350
		public VRMessageOverlayResponse ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text) => default; // 0x00000001811DF070-0x00000001811DF0A0
	}
}
