/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace Valve.VR
{
	public class CVRTrackedCamera // TypeDefIndex: 8209
	{
		// Fields
		private IVRTrackedCamera FnTable; // 0x10
	
		// Constructors
		public CVRTrackedCamera() {} // Dummy constructor
		internal CVRTrackedCamera(IntPtr pInterface) {} // 0x00000001811E1240-0x00000001811E1350
	
		// Methods
		public string GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError) => default; // 0x00000001811E0FE0-0x00000001811E1060
		public EVRTrackedCameraError HasCamera(uint nDeviceIndex, ref bool pHasCamera) => default; // 0x00000001811E11D0-0x00000001811E1200
		public EVRTrackedCameraError GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize) => default; // 0x00000001811E1060-0x00000001811E10A0
		public EVRTrackedCameraError GetCameraIntrinsics(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter) => default; // 0x00000001811E10A0-0x00000001811E10D0
		public EVRTrackedCameraError GetCameraProjection(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection) => default; // 0x00000001811E10D0-0x00000001811E1100
		public EVRTrackedCameraError AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle) => default; // 0x00000001811E0FB0-0x00000001811E0FE0
		public EVRTrackedCameraError ReleaseVideoStreamingService(ulong hTrackedCamera) => default; // 0x00000001811E1220-0x00000001811E1240
		public EVRTrackedCameraError GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) => default; // 0x00000001811E1100-0x00000001811E1130
		public EVRTrackedCameraError GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight) => default; // 0x00000001811E1190-0x00000001811E11D0
		public EVRTrackedCameraError GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) => default; // 0x00000001811E1130-0x00000001811E1160
		public EVRTrackedCameraError GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize) => default; // 0x00000001811E1160-0x00000001811E1190
		public EVRTrackedCameraError ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId) => default; // 0x00000001811E1200-0x00000001811E1220
	}
}
