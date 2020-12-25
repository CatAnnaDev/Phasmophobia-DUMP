/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180136060-0x0000000180136150
	// [NativeHeader] // 0x0000000180136060-0x0000000180136150
	// [NativeHeader] // 0x0000000180136060-0x0000000180136150
	// [NativeHeader] // 0x0000000180136060-0x0000000180136150
	// [NativeHeader] // 0x0000000180136060-0x0000000180136150
	// [NativeHeader] // 0x0000000180136060-0x0000000180136150
	public class Graphics // TypeDefIndex: 3140
	{
		// Fields
		internal static readonly int kMaxDrawMeshInstanceCount; // 0x00
	
		// Constructors
		public Graphics() {} // Dummy constructor
		static Graphics() {} // 0x000000018096DDF0-0x000000018096DE50
	
		// Methods
		[FreeFunction] // 0x00000001801374F0-0x0000000180137520
		private static int Internal_GetMaxDrawMeshInstanceCount() => default; // 0x000000018096D090-0x000000018096D0C0
		[FreeFunction] // 0x00000001801375D0-0x0000000180137600
		private static void Internal_SetNullRT() {} // 0x000000018096D0C0-0x000000018096D0F0
		[NativeMethod] // 0x0000000180137650-0x0000000180137690
		private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) {} // 0x000000018096D160-0x000000018096D210
		[FreeFunction] // 0x00000001801376E0-0x0000000180137710
		private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) {} // 0x000000018096D210-0x000000018096D270
		// [StaticAccessor] // 0x0000000180137AB0-0x0000000180137AE0
		public static void ClearRandomWriteTargets() {} // 0x000000018096B730-0x000000018096B760
		[FreeFunction] // 0x0000000180137AE0-0x0000000180137B10
		private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) {} // 0x000000018096CDE0-0x000000018096CE70
		[FreeFunction] // 0x0000000180137B90-0x0000000180137C30
		[VisibleToOtherModules] // 0x0000000180137B90-0x0000000180137C30
		internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) {} // 0x000000018096D050-0x000000018096D090
		[FreeFunction] // 0x0000000180138160-0x0000000180138190
		private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018096CEF0-0x000000018096D000
		[FreeFunction] // 0x0000000180138240-0x0000000180138270
		private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) {} // 0x000000018096D000-0x000000018096D050
		[FreeFunction] // 0x0000000180138700-0x0000000180138730
		private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Material mat, int pass, bool setRT) {} // 0x000000018096CCB0-0x000000018096CD20
		[FreeFunction] // 0x00000001801387F0-0x0000000180138820
		private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Material mat, [NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Vector2[] offsets) {} // 0x000000018096CD20-0x000000018096CD90
		[FreeFunction] // 0x0000000180138BB0-0x0000000180138BE0
		private static void Blit2(Texture source, RenderTexture dest) {} // 0x000000018096B3F0-0x000000018096B440
		internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) {} // 0x000000018096D5B0-0x000000018096D6B0
		internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) {} // 0x000000018096D6B0-0x000000018096D810
		public static void SetRenderTarget(RenderTexture rt, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int mipLevel, [DefaultValue] /* 0x0000000180138D00-0x0000000180138D30 */ CubemapFace face, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int depthSlice) {} // 0x000000018096D970-0x000000018096DB00
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int mipLevel, [DefaultValue] /* 0x0000000180138D00-0x0000000180138D30 */ CubemapFace face, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int depthSlice) {} // 0x000000018096DB00-0x000000018096DC40
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav, [DefaultValue] /* 0x00000001800DFAE0-0x00000001800DFB10 */ bool preserveCounterValue) {} // 0x000000018096D270-0x000000018096D400
		private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass) {} // 0x000000018096C630-0x000000018096C770
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ Material mat, [DefaultValue] /* 0x0000000180139340-0x0000000180139370 */ int pass) {} // 0x000000018096C910-0x000000018096CAF0
		public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ Material mat, [DefaultValue] /* 0x0000000180139340-0x0000000180139370 */ int pass) {} // 0x000000018096C800-0x000000018096C910
		public static void DrawTexture(Rect screenRect, Texture texture, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ Material mat, [DefaultValue] /* 0x0000000180139340-0x0000000180139370 */ int pass) {} // 0x000000018096CAF0-0x000000018096CC30
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) {} // 0x000000018096B760-0x000000018096B8C0
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) {} // 0x000000018096B8C0-0x000000018096BA50
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ Camera camera, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int submeshIndex, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ MaterialPropertyBlock properties, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool castShadows, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool receiveShadows, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool useLightProbes) {} // 0x000000018096BCD0-0x000000018096BDF0
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, [DefaultValue] /* 0x00000001800F6CB0-0x00000001800F6CE0 */ LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018096C380-0x000000018096C570
		public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0 /* Metadata: 0x0064B88F */) {} // 0x000000018096C570-0x000000018096C630
		public static void Blit(Texture source, RenderTexture dest) {} // 0x000000018096B5D0-0x000000018096B650
		public static void Blit(Texture source, RenderTexture dest, Material mat, [DefaultValue] /* 0x0000000180139340-0x0000000180139370 */ int pass) {} // 0x000000018096B530-0x000000018096B5D0
		public static void Blit(Texture source, RenderTexture dest, Material mat) {} // 0x000000018096B650-0x000000018096B730
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, params /* 0x00000001800D4E50-0x00000001800D4E60 */ Vector2[] offsets) {} // 0x000000018096B440-0x000000018096B530
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer) {} // 0x000000018096BDF0-0x000000018096C060
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows) {} // 0x000000018096BA50-0x000000018096BCD0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) {} // 0x000000018096C200-0x000000018096C380
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows) {} // 0x000000018096C060-0x000000018096C200
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawTexture(Rect screenRect, Texture texture, Material mat) {} // 0x000000018096C770-0x000000018096C800
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void DrawTexture(Rect screenRect, Texture texture) {} // 0x000000018096CC30-0x000000018096CCB0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void SetRenderTarget(RenderTexture rt) {} // 0x000000018096DC40-0x000000018096DDF0
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer) {} // 0x000000018096D810-0x000000018096D970
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav) {} // 0x000000018096D400-0x000000018096D5B0
		private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) {} // 0x000000018096D0F0-0x000000018096D160
		private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) {} // 0x000000018096CD90-0x000000018096CDE0
		private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) {} // 0x000000018096CE70-0x000000018096CEF0
	}
}
