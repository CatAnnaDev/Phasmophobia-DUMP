/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace LIV.SDK.Unity
{
	public static class SDKUtils // TypeDefIndex: 8600
	{
		// Properties
		public static TEXTURE_COLOR_SPACE GetDefaultColorSpace { get; } // 0x000000018113E170-0x000000018113E1A0 
	
		// Methods
		public static void CreateClipPlane(Mesh mesh, int resX, int resY, bool useQuads, float skirtLength) {} // 0x000000018113CB90-0x000000018113D230
		public static RenderTextureReadWrite GetReadWriteFromColorSpace(TEXTURE_COLOR_SPACE colorSpace) => default; // 0x000000018113D700-0x000000018113D720
		public static TEXTURE_COLOR_SPACE GetColorSpace(RenderTexture renderTexture) => default; // 0x000000018113D600-0x000000018113D680
		public static RENDERING_PIPELINE GetRenderingPipeline(RenderingPath renderingPath) => default; // 0x000000018113D720-0x000000018113D750
		public static TEXTURE_DEVICE GetDevice() => default; // 0x000000018113D680-0x000000018113D700
		public static bool ContainsFlag(ulong flags, ulong flag) => default; // 0x00000001809DAAE0-0x00000001809DAAF0
		public static ulong SetFlag(ulong flags, ulong flag, bool enabled) => default; // 0x000000018113E150-0x000000018113E170
		public static void GetCameraPositionAndRotation(SDKPose pose, Matrix4x4 originLocalToWorldMatrix, out Vector3 position, out Quaternion rotation) {
			position = default;
			rotation = default;
		} // 0x000000018113D450-0x000000018113D600
		public static void CleanCameraBehaviours(Camera camera, string[] excludeBehaviours) {} // 0x000000018113C2D0-0x000000018113C6A0
		public static void SetCamera(Camera camera, SDKInputFrame inputFrame, Matrix4x4 originLocalToWorldMatrix, int layerMask) {} // 0x000000018113DB70-0x000000018113E150
		public static Quaternion RotateQuaternionByMatrix(Matrix4x4 matrix, Quaternion rotation) => default; // 0x000000018113DA00-0x000000018113DB70
		public static SDKTrackedSpace GetTrackedSpace(Transform transform) => default; // 0x000000018113D750-0x000000018113DA00
		public static bool DestroyObject<T>(ref T reference)
			where T : UnityEngine.Object => default;
		public static bool DisposeObject<T>(ref T reference)
			where T : IDisposable => default;
		public static bool CreateTexture(ref RenderTexture renderTexture, int width, int height, int depth, RenderTextureFormat format) => default; // 0x000000018113D230-0x000000018113D3B0
		public static void DestroyTexture(ref RenderTexture _renderTexture) {} // 0x000000018113D3B0-0x000000018113D450
		public static void ApplyUserSpaceTransform(SDKRender render) {} // 0x000000018113BEF0-0x000000018113C2D0
		public static void CreateBridgeOutputFrame(SDKRender render) {} // 0x000000018113C6A0-0x000000018113CB90
		public static bool FeatureEnabled(FEATURES features, FEATURES feature) => default; // 0x00000001809DAAE0-0x00000001809DAAF0
	}
}
