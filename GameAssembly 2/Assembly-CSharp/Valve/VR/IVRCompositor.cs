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
	public struct IVRCompositor // TypeDefIndex: 8029
	{
		// Fields
		internal _SetTrackingSpace SetTrackingSpace; // 0x00
		internal _GetTrackingSpace GetTrackingSpace; // 0x08
		internal _WaitGetPoses WaitGetPoses; // 0x10
		internal _GetLastPoses GetLastPoses; // 0x18
		internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex; // 0x20
		internal _Submit Submit; // 0x28
		internal _ClearLastSubmittedFrame ClearLastSubmittedFrame; // 0x30
		internal _PostPresentHandoff PostPresentHandoff; // 0x38
		internal _GetFrameTiming GetFrameTiming; // 0x40
		internal _GetFrameTimings GetFrameTimings; // 0x48
		internal _GetFrameTimeRemaining GetFrameTimeRemaining; // 0x50
		internal _GetCumulativeStats GetCumulativeStats; // 0x58
		internal _FadeToColor FadeToColor; // 0x60
		internal _GetCurrentFadeColor GetCurrentFadeColor; // 0x68
		internal _FadeGrid FadeGrid; // 0x70
		internal _GetCurrentGridAlpha GetCurrentGridAlpha; // 0x78
		internal _SetSkyboxOverride SetSkyboxOverride; // 0x80
		internal _ClearSkyboxOverride ClearSkyboxOverride; // 0x88
		internal _CompositorBringToFront CompositorBringToFront; // 0x90
		internal _CompositorGoToBack CompositorGoToBack; // 0x98
		internal _CompositorQuit CompositorQuit; // 0xA0
		internal _IsFullscreen IsFullscreen; // 0xA8
		internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess; // 0xB0
		internal _GetLastFrameRenderer GetLastFrameRenderer; // 0xB8
		internal _CanRenderScene CanRenderScene; // 0xC0
		internal _ShowMirrorWindow ShowMirrorWindow; // 0xC8
		internal _HideMirrorWindow HideMirrorWindow; // 0xD0
		internal _IsMirrorWindowVisible IsMirrorWindowVisible; // 0xD8
		internal _CompositorDumpImages CompositorDumpImages; // 0xE0
		internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources; // 0xE8
		internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn; // 0xF0
		internal _ForceReconnectProcess ForceReconnectProcess; // 0xF8
		internal _SuspendRendering SuspendRendering; // 0x100
		internal _GetMirrorTextureD3D11 GetMirrorTextureD3D11; // 0x108
		internal _ReleaseMirrorTextureD3D11 ReleaseMirrorTextureD3D11; // 0x110
		internal _GetMirrorTextureGL GetMirrorTextureGL; // 0x118
		internal _ReleaseSharedGLTexture ReleaseSharedGLTexture; // 0x120
		internal _LockGLSharedTextureForAccess LockGLSharedTextureForAccess; // 0x128
		internal _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess; // 0x130
		internal _GetVulkanInstanceExtensionsRequired GetVulkanInstanceExtensionsRequired; // 0x138
		internal _GetVulkanDeviceExtensionsRequired GetVulkanDeviceExtensionsRequired; // 0x140
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SetTrackingSpace(ETrackingUniverseOrigin eOrigin); // TypeDefIndex: 8030; 0x0000000180AC5520-0x0000000180AC56E0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate ETrackingUniverseOrigin _GetTrackingSpace(); // TypeDefIndex: 8031; 0x0000000180A8BB90-0x0000000180A8BE20
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRCompositorError _WaitGetPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount); // TypeDefIndex: 8032; 0x0000000181E67DD0-0x0000000181E68010
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRCompositorError _GetLastPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount); // TypeDefIndex: 8033; 0x0000000181E67DD0-0x0000000181E68010
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRCompositorError _GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose); // TypeDefIndex: 8034; 0x0000000181E679B0-0x0000000181E67D20
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRCompositorError _Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags); // TypeDefIndex: 8035; 0x0000000181E6F2D0-0x0000000181E6F660
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ClearLastSubmittedFrame(); // TypeDefIndex: 8036; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _PostPresentHandoff(); // TypeDefIndex: 8037; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo); // TypeDefIndex: 8038; 0x00000001811EE520-0x00000001811EE810
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames); // TypeDefIndex: 8039; 0x0000000181E67270-0x0000000181E67560
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate float _GetFrameTimeRemaining(); // TypeDefIndex: 8040; 0x0000000181E666A0-0x0000000181E66840
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes); // TypeDefIndex: 8041; 0x000000018047AFB0-0x000000018047B290
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground); // TypeDefIndex: 8042; 0x0000000181E658F0-0x0000000181E65D00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate HmdColor_t _GetCurrentFadeColor(bool bBackground); // TypeDefIndex: 8043; 0x0000000181E66320-0x0000000181E666A0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _FadeGrid(float fSeconds, bool bFadeIn); // TypeDefIndex: 8044; 0x0000000181E654C0-0x0000000181E657E0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate float _GetCurrentGridAlpha(); // TypeDefIndex: 8045; 0x0000000181E666A0-0x0000000181E66840
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRCompositorError _SetSkyboxOverride([In, Out] Texture_t[] pTextures, uint unTextureCount); // TypeDefIndex: 8046; 0x0000000181E67270-0x0000000181E67560
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ClearSkyboxOverride(); // TypeDefIndex: 8047; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _CompositorBringToFront(); // TypeDefIndex: 8048; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _CompositorGoToBack(); // TypeDefIndex: 8049; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _CompositorQuit(); // TypeDefIndex: 8050; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsFullscreen(); // TypeDefIndex: 8051; 0x00000001811E8170-0x00000001811E8310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetCurrentSceneFocusProcess(); // TypeDefIndex: 8052; 0x00000001811E8610-0x00000001811E87B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetLastFrameRenderer(); // TypeDefIndex: 8053; 0x00000001811E8610-0x00000001811E87B0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _CanRenderScene(); // TypeDefIndex: 8054; 0x00000001811E8170-0x00000001811E8310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ShowMirrorWindow(); // TypeDefIndex: 8055; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _HideMirrorWindow(); // TypeDefIndex: 8056; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _IsMirrorWindowVisible(); // TypeDefIndex: 8057; 0x00000001811E8170-0x00000001811E8310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _CompositorDumpImages(); // TypeDefIndex: 8058; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _ShouldAppRenderWithLowResources(); // TypeDefIndex: 8059; 0x00000001811E8170-0x00000001811E8310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ForceInterleavedReprojectionOn(bool bOverride); // TypeDefIndex: 8060; 0x0000000181844D30-0x0000000181844F00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ForceReconnectProcess(); // TypeDefIndex: 8061; 0x00000001802D1BD0-0x00000001802D1D60
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _SuspendRendering(bool bSuspend); // TypeDefIndex: 8062; 0x0000000181844D30-0x0000000181844F00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRCompositorError _GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView); // TypeDefIndex: 8063; 0x0000000181E679B0-0x0000000181E67D20
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView); // TypeDefIndex: 8064; 0x00000001802A7CC0-0x00000001802A7E90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRCompositorError _GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle); // TypeDefIndex: 8065; 0x0000000181E679B0-0x0000000181E67D20
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate bool _ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle); // TypeDefIndex: 8066; 0x0000000181AAFE10-0x0000000181AB0130
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle); // TypeDefIndex: 8067; 0x00000001802A7CC0-0x00000001802A7E90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate void _UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle); // TypeDefIndex: 8068; 0x00000001802A7CC0-0x00000001802A7E90
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize); // TypeDefIndex: 8069; 0x0000000181E675F0-0x0000000181E678F0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate uint _GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize); // TypeDefIndex: 8070; 0x0000000181E6B5F0-0x0000000181E6B960
	}
}
