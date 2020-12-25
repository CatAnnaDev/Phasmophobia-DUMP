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
	public class CVRCompositor // TypeDefIndex: 8213
	{
		// Fields
		private IVRCompositor FnTable; // 0x10
	
		// Constructors
		public CVRCompositor() {} // Dummy constructor
		internal CVRCompositor(IntPtr pInterface) {} // 0x00000001811DDA70-0x00000001811DDBE0
	
		// Methods
		public void SetTrackingSpace(ETrackingUniverseOrigin eOrigin) {} // 0x00000001811DD920-0x00000001811DD940
		public ETrackingUniverseOrigin GetTrackingSpace() => default; // 0x00000001811DD730-0x00000001811DD750
		public EVRCompositorError WaitGetPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray) => default; // 0x00000001811DDA30-0x00000001811DDA70
		public EVRCompositorError GetLastPoses(TrackedDevicePose_t[] pRenderPoseArray, TrackedDevicePose_t[] pGamePoseArray) => default; // 0x00000001811DD690-0x00000001811DD6D0
		public EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose) => default; // 0x00000001811DD660-0x00000001811DD690
		public EVRCompositorError Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags) => default; // 0x00000001811DD9A0-0x00000001811DD9D0
		public void ClearLastSubmittedFrame() {} // 0x00000001811DD330-0x00000001811DD350
		public void PostPresentHandoff() {} // 0x00000001811DD870-0x00000001811DD890
		public bool GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo) => default; // 0x00000001811DD5F0-0x00000001811DD610
		public uint GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames) => default; // 0x00000001811DD610-0x00000001811DD630
		public float GetFrameTimeRemaining() => default; // 0x00000001811DD5D0-0x00000001811DD5F0
		public void GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes) {} // 0x00000001811DD510-0x00000001811DD530
		public void FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground) {} // 0x00000001811DD470-0x00000001811DD4B0
		public HmdColor_t GetCurrentFadeColor(bool bBackground) => default; // 0x00000001811DD530-0x00000001811DD570
		public void FadeGrid(float fSeconds, bool bFadeIn) {} // 0x00000001811DD440-0x00000001811DD470
		public float GetCurrentGridAlpha() => default; // 0x00000001811DD570-0x00000001811DD5A0
		public EVRCompositorError SetSkyboxOverride(Texture_t[] pTextures) => default; // 0x00000001811DD8F0-0x00000001811DD920
		public void ClearSkyboxOverride() {} // 0x00000001811DD350-0x00000001811DD380
		public void CompositorBringToFront() {} // 0x00000001811DD380-0x00000001811DD3B0
		public void CompositorGoToBack() {} // 0x00000001811DD3E0-0x00000001811DD410
		public void CompositorQuit() {} // 0x00000001811DD410-0x00000001811DD440
		public bool IsFullscreen() => default; // 0x00000001811DD7E0-0x00000001811DD810
		public uint GetCurrentSceneFocusProcess() => default; // 0x00000001811DD5A0-0x00000001811DD5D0
		public uint GetLastFrameRenderer() => default; // 0x00000001811DD630-0x00000001811DD660
		public bool CanRenderScene() => default; // 0x00000001811DD300-0x00000001811DD330
		public void ShowMirrorWindow() {} // 0x00000001811DD970-0x00000001811DD9A0
		public void HideMirrorWindow() {} // 0x00000001811DD7B0-0x00000001811DD7E0
		public bool IsMirrorWindowVisible() => default; // 0x00000001811DD810-0x00000001811DD840
		public void CompositorDumpImages() {} // 0x00000001811DD3B0-0x00000001811DD3E0
		public bool ShouldAppRenderWithLowResources() => default; // 0x00000001811DD940-0x00000001811DD970
		public void ForceInterleavedReprojectionOn(bool bOverride) {} // 0x00000001811DD4B0-0x00000001811DD4E0
		public void ForceReconnectProcess() {} // 0x00000001811DD4E0-0x00000001811DD510
		public void SuspendRendering(bool bSuspend) {} // 0x00000001811DD9D0-0x00000001811DDA00
		public EVRCompositorError GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView) => default; // 0x00000001811DD6D0-0x00000001811DD700
		public void ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView) {} // 0x00000001811DD890-0x00000001811DD8C0
		public EVRCompositorError GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle) => default; // 0x00000001811DD700-0x00000001811DD730
		public bool ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle) => default; // 0x00000001811DD8C0-0x00000001811DD8F0
		public void LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle) {} // 0x00000001811DD840-0x00000001811DD870
		public void UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle) {} // 0x00000001811DDA00-0x00000001811DDA30
		public uint GetVulkanInstanceExtensionsRequired(StringBuilder pchValue, uint unBufferSize) => default; // 0x00000001811DD780-0x00000001811DD7B0
		public uint GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, StringBuilder pchValue, uint unBufferSize) => default; // 0x00000001811DD750-0x00000001811DD780
	}
}
