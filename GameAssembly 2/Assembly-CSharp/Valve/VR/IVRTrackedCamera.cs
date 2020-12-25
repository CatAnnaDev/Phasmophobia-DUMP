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
	public struct IVRTrackedCamera // TypeDefIndex: 7954
	{
		// Fields
		internal _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum; // 0x00
		internal _HasCamera HasCamera; // 0x08
		internal _GetCameraFrameSize GetCameraFrameSize; // 0x10
		internal _GetCameraIntrinsics GetCameraIntrinsics; // 0x18
		internal _GetCameraProjection GetCameraProjection; // 0x20
		internal _AcquireVideoStreamingService AcquireVideoStreamingService; // 0x28
		internal _ReleaseVideoStreamingService ReleaseVideoStreamingService; // 0x30
		internal _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer; // 0x38
		internal _GetVideoStreamTextureSize GetVideoStreamTextureSize; // 0x40
		internal _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11; // 0x48
		internal _GetVideoStreamTextureGL GetVideoStreamTextureGL; // 0x50
		internal _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL; // 0x58
	
		// Nested types
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate IntPtr _GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError); // TypeDefIndex: 7955; 0x00000001811EA830-0x00000001811EAA00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _HasCamera(uint nDeviceIndex, ref bool pHasCamera); // TypeDefIndex: 7956; 0x00000001811ED1B0-0x00000001811ED4D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize); // TypeDefIndex: 7957; 0x0000000181F372C0-0x0000000181F376A0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _GetCameraIntrinsics(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter); // TypeDefIndex: 7958; 0x0000000181F37770-0x0000000181F37B00
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _GetCameraProjection(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection); // TypeDefIndex: 7959; 0x0000000181F37BF0-0x0000000181F37FD0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle); // TypeDefIndex: 7960; 0x00000001811ED1B0-0x00000001811ED4D0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamingService(ulong hTrackedCamera); // TypeDefIndex: 7961; 0x00000001807CD390-0x00000001807CD680
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // TypeDefIndex: 7962; 0x0000000181F3DEF0-0x0000000181F3E310
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight); // TypeDefIndex: 7963; 0x0000000181F372C0-0x0000000181F376A0
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // TypeDefIndex: 7964; 0x0000000181F3E420-0x0000000181F3E840
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize); // TypeDefIndex: 7965; 0x0000000181F3E930-0x0000000181F3ED10
	
		// [UnmanagedFunctionPointer] // 0x0000000180123050-0x0000000180123070
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId); // TypeDefIndex: 7966; 0x0000000181F3FCF0-0x0000000181F3FEF0
	}
}
