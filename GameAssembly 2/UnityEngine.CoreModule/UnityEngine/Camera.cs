/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x000000018012BE10-0x000000018012BF60
	// [NativeHeader] // 0x000000018012BE10-0x000000018012BF60
	// [NativeHeader] // 0x000000018012BE10-0x000000018012BF60
	// [NativeHeader] // 0x000000018012BE10-0x000000018012BF60
	// [NativeHeader] // 0x000000018012BE10-0x000000018012BF60
	// [NativeHeader] // 0x000000018012BE10-0x000000018012BF60
	// [NativeHeader] // 0x000000018012BE10-0x000000018012BF60
	// [RequireComponent] // 0x000000018012BE10-0x000000018012BF60
	[UsedByNativeCode] // 0x000000018012BE10-0x000000018012BF60
	public sealed class Camera : Behaviour // TypeDefIndex: 3111
	{
		// Fields
		public static CameraCallback onPreCull; // 0x00
		public static CameraCallback onPreRender; // 0x08
		public static CameraCallback onPostRender; // 0x10
	
		// Properties
		[NativeProperty] // 0x000000018012E490-0x000000018012E4C0
		public float nearClipPlane { get => default; set {} } // 0x0000000180962270-0x00000001809622B0 0x0000000180962C00-0x0000000180962C50
		[NativeProperty] // 0x000000018012E5B0-0x000000018012E5E0
		public float farClipPlane { get => default; set {} } // 0x00000001809621C0-0x0000000180962200 0x0000000180962B60-0x0000000180962BB0
		[NativeProperty] // 0x000000018012E620-0x000000018012E650
		public float fieldOfView { get => default; set {} } // 0x0000000180962200-0x0000000180962240 0x0000000180962BB0-0x0000000180962C00
		public RenderingPath actualRenderingPath { /* [NativeName] */ /* 0x000000018012C320-0x000000018012C350 */ get => default; } // 0x0000000180961D80-0x0000000180961DC0 
		public bool allowHDR { get => default; } // 0x0000000180961E00-0x0000000180961E40 
		public bool allowMSAA { set {} } // 0x0000000180962910-0x0000000180962960
		public bool allowDynamicResolution { get => default; } // 0x0000000180961DC0-0x0000000180961E00 
		public float orthographicSize { get => default; set {} } // 0x00000001809622B0-0x00000001809622F0 0x0000000180962CF0-0x0000000180962D40
		public bool orthographic { get => default; set {} } // 0x00000001809622F0-0x0000000180962330 0x0000000180962D40-0x0000000180962D90
		public float depth { get => default; set {} } // 0x0000000180962140-0x0000000180962180 0x0000000180962B10-0x0000000180962B60
		public float aspect { get => default; set {} } // 0x0000000180961E40-0x0000000180961E80 0x0000000180962960-0x00000001809629B0
		public int cullingMask { get => default; set {} } // 0x0000000180962090-0x00000001809620D0 0x0000000180962A90-0x0000000180962AD0
		public int eventMask { get => default; } // 0x0000000180962180-0x00000001809621C0 
		public CameraType cameraType { get => default; } // 0x0000000180962010-0x0000000180962050 
		public bool useOcclusionCulling { set {} } // 0x0000000180962FB0-0x0000000180963000
		public Color backgroundColor { get => default; set {} } // 0x0000000180961ED0-0x0000000180961F30 0x0000000180962A00-0x0000000180962A50
		public CameraClearFlags clearFlags { get => default; set {} } // 0x0000000180962050-0x0000000180962090 0x0000000180962A50-0x0000000180962A90
		public DepthTextureMode depthTextureMode { get => default; set {} } // 0x0000000180962100-0x0000000180962140 0x0000000180962AD0-0x0000000180962B10
		public bool usePhysicalProperties { get => default; set {} } // 0x00000001809627F0-0x0000000180962830 0x0000000180963000-0x0000000180963050
		[NativeProperty] // 0x000000018012E6E0-0x000000018012E710
		public Rect rect { get => default; set {} } // 0x0000000180962590-0x00000001809625F0 0x0000000180962E80-0x0000000180962ED0
		[NativeProperty] // 0x000000018012E790-0x000000018012E7C0
		public Rect pixelRect { get => default; } // 0x00000001809623C0-0x0000000180962420 
		public int pixelWidth { [FreeFunction] /* 0x000000018012C3D0-0x000000018012C410 */ get => default; } // 0x0000000180962420-0x0000000180962460 
		public int pixelHeight { [FreeFunction] /* 0x000000018012C4F0-0x000000018012C530 */ get => default; } // 0x0000000180962330-0x0000000180962370 
		public int scaledPixelWidth { [FreeFunction] /* 0x000000018012C590-0x000000018012C5D0 */ get => default; } // 0x0000000180962630-0x0000000180962670 
		public int scaledPixelHeight { [FreeFunction] /* 0x000000018012C670-0x000000018012C6B0 */ get => default; } // 0x00000001809625F0-0x0000000180962630 
		public RenderTexture targetTexture { get => default; set {} } // 0x00000001809627B0-0x00000001809627F0 0x0000000180962F10-0x0000000180962F60
		public int targetDisplay { get => default; } // 0x0000000180962770-0x00000001809627B0 
		public Matrix4x4 cameraToWorldMatrix { get => default; } // 0x0000000180961F80-0x0000000180962010 
		public Matrix4x4 worldToCameraMatrix { get => default; } // 0x0000000180962880-0x0000000180962910 
		public Matrix4x4 projectionMatrix { get => default; set {} } // 0x00000001809624B0-0x0000000180962540 0x0000000180962DE0-0x0000000180962E30
		public Matrix4x4 nonJitteredProjectionMatrix { set {} } // 0x0000000180962CA0-0x0000000180962CF0
		[NativeProperty] // 0x000000018012E7C0-0x000000018012E7F0
		public bool useJitteredProjectionMatrixForTransparentRendering { set {} } // 0x0000000180962F60-0x0000000180962FB0
		public static Camera main { [FreeFunction] /* 0x000000018012C7B0-0x000000018012C7E0 */ get => default; } // 0x0000000180962240-0x0000000180962270 
		public static Camera current { [FreeFunction] /* 0x000000018012C840-0x000000018012C870 */ get => default; } // 0x00000001809620D0-0x0000000180962100 
		public bool stereoEnabled { get => default; } // 0x00000001809626B0-0x00000001809626F0 
		public float stereoSeparation { get => default; } // 0x00000001809626F0-0x0000000180962730 
		public StereoTargetEyeMask stereoTargetEye { get => default; set {} } // 0x0000000180962730-0x0000000180962770 0x0000000180962ED0-0x0000000180962F10
		public MonoOrStereoscopicEye stereoActiveEye { [FreeFunction] /* 0x000000018012C8E0-0x000000018012C920 */ get => default; } // 0x0000000180962670-0x00000001809626B0 
		public static int allCamerasCount { get => default; } // 0x0000000180960CA0-0x0000000180960CD0 
	
		// Nested types
		public enum StereoscopicEye // TypeDefIndex: 3112
		{
			Left = 0,
			Right = 1
		}
	
		public enum MonoOrStereoscopicEye // TypeDefIndex: 3113
		{
			Left = 0,
			Right = 1,
			Mono = 2
		}
	
		public delegate void CameraCallback(Camera cam); // TypeDefIndex: 3114; 0x000000018070A7F0-0x000000018070AB70
	
		// Constructors
		public Camera() {} // 0x000000018095F5F0-0x000000018095F650
	
		// Methods
		public void ResetProjectionMatrix() {} // 0x00000001809612C0-0x0000000180961300
		public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) => default; // 0x0000000180961AD0-0x0000000180961B60
		public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) => default; // 0x0000000180961C60-0x0000000180961CF0
		public Vector3 WorldToScreenPoint(Vector3 position) => default; // 0x0000000180961B60-0x0000000180961BF0
		public Vector3 WorldToViewportPoint(Vector3 position) => default; // 0x0000000180961CF0-0x0000000180961D80
		public Vector3 ScreenToViewportPoint(Vector3 position) => default; // 0x0000000180961670-0x00000001809616F0
		private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) => default; // 0x00000001809618F0-0x0000000180961980
		public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) => default; // 0x0000000180961800-0x00000001809618F0
		public Ray ViewportPointToRay(Vector3 pos) => default; // 0x0000000180961980-0x0000000180961A60
		private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) => default; // 0x0000000180961580-0x0000000180961610
		public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) => default; // 0x0000000180961490-0x0000000180961580
		public Ray ScreenPointToRay(Vector3 pos) => default; // 0x00000001809613B0-0x0000000180961490
		public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) => default; // 0x0000000180960E40-0x0000000180960EE0
		public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) => default; // 0x0000000180961020-0x00000001809610C0
		public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) {} // 0x0000000180960B50-0x0000000180960B90
		public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) => default; // 0x0000000180960F30-0x0000000180960FD0
		public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) {} // 0x0000000180961740-0x0000000180961790
		public void ResetStereoProjectionMatrices() {} // 0x0000000180961300-0x0000000180961340
		[FreeFunction] // 0x000000018012C9A0-0x000000018012C9D0
		private static int GetAllCamerasCount() => default; // 0x0000000180960CA0-0x0000000180960CD0
		[FreeFunction] // 0x000000018012DD00-0x000000018012DD30
		private static int GetAllCamerasImpl([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ out Camera[] cam) {
			cam = default;
			return default;
		} // 0x0000000180960CD0-0x0000000180960D10
		public static int GetAllCameras(Camera[] cameras) => default; // 0x0000000180960D10-0x0000000180960DF0
		[FreeFunction] // 0x000000018012DE00-0x000000018012DE40
		public void Render() {} // 0x0000000180961280-0x00000001809612C0
		[FreeFunction] // 0x000000018012DE40-0x000000018012DE80
		public void RenderWithShader(Shader shader, string replacementTag) {} // 0x0000000180961220-0x0000000180961280
		[FreeFunction] // 0x000000018012DED0-0x000000018012DF10
		public void CopyFrom(Camera other) {} // 0x0000000180960B00-0x0000000180960B50
		// [NativeName] // 0x000000018012DF60-0x000000018012DF90
		private void AddCommandBufferImpl(CameraEvent evt, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ CommandBuffer buffer) {} // 0x00000001809609A0-0x00000001809609F0
		// [NativeName] // 0x000000018012E0C0-0x000000018012E0F0
		private void RemoveCommandBufferImpl(CameraEvent evt, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ CommandBuffer buffer) {} // 0x00000001809610C0-0x0000000180961110
		public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) {} // 0x00000001809609F0-0x0000000180960B00
		public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) {} // 0x0000000180961110-0x0000000180961220
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void FireOnPreCull(Camera cam) {} // 0x0000000180960BF0-0x0000000180960C40
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void FireOnPreRender(Camera cam) {} // 0x0000000180960C40-0x0000000180960CA0
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		private static void FireOnPostRender(Camera cam) {} // 0x0000000180960B90-0x0000000180960BF0
		private void get_backgroundColor_Injected(out Color ret) {
			ret = default;
		} // 0x0000000180961E80-0x0000000180961ED0
		private void set_backgroundColor_Injected(ref Color value) {} // 0x00000001809629B0-0x0000000180962A00
		private void get_rect_Injected(out Rect ret) {
			ret = default;
		} // 0x0000000180962540-0x0000000180962590
		private void set_rect_Injected(ref Rect value) {} // 0x0000000180962E30-0x0000000180962E80
		private void get_pixelRect_Injected(out Rect ret) {
			ret = default;
		} // 0x0000000180962370-0x00000001809623C0
		private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180961F30-0x0000000180961F80
		private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180962830-0x0000000180962880
		private void get_projectionMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180962460-0x00000001809624B0
		private void set_projectionMatrix_Injected(ref Matrix4x4 value) {} // 0x0000000180962D90-0x0000000180962DE0
		private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) {} // 0x0000000180962C50-0x0000000180962CA0
		private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) {
			ret = default;
		} // 0x0000000180961A60-0x0000000180961AD0
		private void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) {
			ret = default;
		} // 0x0000000180961BF0-0x0000000180961C60
		private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) {
			ret = default;
		} // 0x0000000180961610-0x0000000180961670
		private void ViewportPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) {
			ret = default;
		} // 0x0000000180961790-0x0000000180961800
		private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) {
			ret = default;
		} // 0x0000000180961340-0x00000001809613B0
		private void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180960DF0-0x0000000180960E40
		private void GetStereoViewMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180960FD0-0x0000000180961020
		private void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000180960EE0-0x0000000180960F30
		private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) {} // 0x00000001809616F0-0x0000000180961740
	}
}
