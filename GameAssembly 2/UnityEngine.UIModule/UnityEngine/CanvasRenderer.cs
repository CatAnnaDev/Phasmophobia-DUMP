/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 32: UnityEngine.UIModule.dll - Assembly: UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4132-4141

namespace UnityEngine
{
	// [NativeClass] // 0x000000018011C0A0-0x000000018011C100
	// [NativeHeader] // 0x000000018011C0A0-0x000000018011C100
	public sealed class CanvasRenderer : Component // TypeDefIndex: 4135
	{
		// Properties
		public bool hasPopInstruction { set {} } // 0x0000000180AED8D0-0x0000000180AED920
		public int materialCount { get => default; set {} } // 0x0000000180AED840-0x0000000180AED880 0x0000000180AED920-0x0000000180AED960
		public int popMaterialCount { set {} } // 0x0000000180AED960-0x0000000180AED9A0
		public int absoluteDepth { get => default; } // 0x0000000180AED780-0x0000000180AED7C0 
		public bool hasMoved { get => default; } // 0x0000000180AED800-0x0000000180AED840 
		[NativeProperty] // 0x000000018011C5A0-0x000000018011C5E0
		public bool cull { get => default; set {} } // 0x0000000180AED7C0-0x0000000180AED800 0x0000000180AED880-0x0000000180AED8D0
	
		// Constructors
		public CanvasRenderer() {} // Dummy constructor
	
		// Methods
		public void SetColor(Color color) {} // 0x0000000180AED390-0x0000000180AED3E0
		public Color GetColor() => default; // 0x0000000180AED290-0x0000000180AED2F0
		public void EnableRectClipping(Rect rect) {} // 0x0000000180AED1F0-0x0000000180AED240
		public void DisableRectClipping() {} // 0x0000000180AED160-0x0000000180AED1A0
		public void SetMaterial(Material material, int index) {} // 0x0000000180AED3E0-0x0000000180AED440
		public void SetPopMaterial(Material material, int index) {} // 0x0000000180AED5B0-0x0000000180AED610
		public void SetTexture(Texture texture) {} // 0x0000000180AED610-0x0000000180AED660
		public void SetAlphaTexture(Texture texture) {} // 0x0000000180AED2F0-0x0000000180AED340
		public void SetMesh(Mesh mesh) {} // 0x0000000180AED560-0x0000000180AED5B0
		public void Clear() {} // 0x0000000180AED0B0-0x0000000180AED0F0
		public void SetMaterial(Material material, Texture texture) {} // 0x0000000180AED440-0x0000000180AED560
		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) {} // 0x0000000180AED6B0-0x0000000180AED780
		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) {} // 0x0000000180AED0F0-0x0000000180AED160
		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents) {} // 0x0000000180AED040-0x0000000180AED0B0
		// [StaticAccessor] // 0x000000018011C390-0x000000018011C3C0
		private static void SplitIndicesStreamsInternal(object verts, object indices) {} // 0x0000000180AED660-0x0000000180AED6B0
		// [StaticAccessor] // 0x000000018011C390-0x000000018011C3C0
		private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) {} // 0x0000000180AED040-0x0000000180AED0B0
		// [StaticAccessor] // 0x000000018011C390-0x000000018011C3C0
		private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) {} // 0x0000000180AED0F0-0x0000000180AED160
		private void SetColor_Injected(ref Color color) {} // 0x0000000180AED340-0x0000000180AED390
		private void GetColor_Injected(out Color ret) {
			ret = default;
		} // 0x0000000180AED240-0x0000000180AED290
		private void EnableRectClipping_Injected(ref Rect rect) {} // 0x0000000180AED1A0-0x0000000180AED1F0
	}
}
