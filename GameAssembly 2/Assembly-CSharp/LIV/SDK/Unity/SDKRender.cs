/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace LIV.SDK.Unity
{
	public class SDKRender : IDisposable // TypeDefIndex: 8575
	{
		// Fields
		private CommandBuffer _clipPlaneCommandBuffer; // 0x10
		private CommandBuffer _addAlphaCommandBuffer; // 0x18
		private CommandBuffer _captureBackgroundCommandBuffer; // 0x20
		private CommandBuffer _captureForegroundCommandBuffer; // 0x28
		private CommandBuffer _applyBackgroundCommandBuffer; // 0x30
		private CommandBuffer _applyForegroundCommandBuffer; // 0x38
		private CameraEvent _clipPlaneCameraEvent; // 0x40
		private CameraEvent _clipPlaneFixAlphaCameraEvent; // 0x44
		private CameraEvent _captureBackgroundEvent; // 0x48
		private CameraEvent _captureForegroundEvent; // 0x4C
		private CameraEvent _applyBackgroundEvent; // 0x50
		private CameraEvent _applyForegroundEvent; // 0x54
		private Mesh _clipPlaneMesh; // 0x58
		private Material _clipPlaneSimpleMaterial; // 0x60
		private Material _clipPlaneSimpleDebugMaterial; // 0x68
		private Material _clipPlaneComplexMaterial; // 0x70
		private Material _clipPlaneComplexDebugMaterial; // 0x78
		private Material _clipPlaneFixAlphaMaterial; // 0x80
		private Material _addAlphaMaterial; // 0x88
		private Material _writeAlphaMaterial; // 0x90
		private Material _forceForwardRenderingMaterial; // 0x98
		private RenderTexture _backgroundRenderTexture; // 0xA0
		private RenderTexture _foregroundRenderTexture; // 0xA8
		private RenderTexture _complexClipPlaneRenderTexture; // 0xB0
		private LIV _liv; // 0xB8
		private SDKOutputFrame _outputFrame; // 0xC0
		private SDKInputFrame _inputFrame; // 0x170
		private Camera _cameraInstance; // 0x2C8
		private SDKPose _requestedPose; // 0x2D0
		private int _requestedPoseFrameIndex; // 0x340
	
		// Properties
		public LIV liv { get => default; } // 0x000000018113AEE0-0x000000018113AEF0 
		public SDKOutputFrame outputFrame { get => default; } // 0x000000018113B0B0-0x000000018113B130 
		public SDKInputFrame inputFrame { get => default; } // 0x000000018113AE30-0x000000018113AEE0 
		public Camera cameraInstance { get => default; } // 0x000000018113AD40-0x000000018113AD50 
		public Camera cameraReference { get => default; } // 0x000000018113AD50-0x000000018113ADF0 
		public Camera hmdCamera { get => default; } // 0x000000018113AE10-0x000000018113AE30 
		public Transform stage { get => default; } // 0x000000018113B290-0x000000018113B2C0 
		public Transform stageTransform { get => default; } // 0x000000018113B270-0x000000018113B290 
		public Matrix4x4 stageLocalToWorldMatrix { get => default; } // 0x000000018113B160-0x000000018113B270 
		public Matrix4x4 localToWorldMatrix { get => default; } // 0x000000018113AEF0-0x000000018113B0B0 
		public int spectatorLayerMask { get => default; } // 0x000000018113B130-0x000000018113B160 
		public bool disableStandardAssets { get => default; } // 0x000000018113ADF0-0x000000018113AE10 
	
		// Constructors
		public SDKRender() {} // Dummy constructor
		public SDKRender(LIV liv) {} // 0x000000018113AAC0-0x000000018113AD40
	
		// Methods
		public void Render() {} // 0x0000000181139850-0x0000000181139B10
		private void RenderBackground() {} // 0x0000000181137660-0x0000000181137FB0
		private void RenderForeground() {} // 0x0000000181137FB0-0x0000000181139850
		private void CreateAssets() {} // 0x00000001811366D0-0x0000000181136F00
		private void DestroyAssets() {} // 0x0000000181137140-0x0000000181137310
		public void Dispose() {} // 0x0000000181137310-0x00000001811373B0
		public bool SetPose(Vector3 position, Quaternion rotation, float verticalFieldOfView = 60f /* Metadata: 0x00655B6C */, bool useLocalSpace = false /* Metadata: 0x00655B70 */) => default; // 0x0000000181139F70-0x000000018113A380
		private void ReleaseBridgePoseControl() {} // 0x00000001811375F0-0x0000000181137660
		private void UpdateBridgeInputFrame() {} // 0x000000018113A380-0x000000018113A530
		private void InvokePreRender() {} // 0x0000000181137530-0x0000000181137590
		private void IvokePostRender() {} // 0x0000000181137590-0x00000001811375F0
		private void InvokePreRenderBackground() {} // 0x0000000181137470-0x00000001811374D0
		private void InvokePostRenderBackground() {} // 0x00000001811373B0-0x0000000181137410
		private void InvokePreRenderForeground() {} // 0x00000001811374D0-0x0000000181137530
		private void InvokePostRenderForeground() {} // 0x0000000181137410-0x0000000181137470
		private void CreateBackgroundTexture() {} // 0x0000000181136F00-0x0000000181136FC0
		private void CreateForegroundTexture() {} // 0x0000000181137080-0x0000000181137140
		private void CreateComplexClipPlaneTexture() {} // 0x0000000181136FC0-0x0000000181137080
		private void SendBackgroundTextureToBridge() {} // 0x0000000181139B10-0x0000000181139D40
		private void SendForegroundTextureToBridge() {} // 0x0000000181139D40-0x0000000181139F70
		private void UpdateTextures() {} // 0x000000018113A530-0x000000018113AAC0
	}
}
