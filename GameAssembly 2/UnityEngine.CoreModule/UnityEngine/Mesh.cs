/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800D8CB0-0x00000001800D8CF0
	[RequiredByNativeCode] // 0x00000001800D8CB0-0x00000001800D8CF0
	public sealed class Mesh : Object // TypeDefIndex: 3199
	{
		// Properties
		public bool isReadable { [NativeMethod] /* 0x00000001800DA2A0-0x00000001800DA2D0 */ get => default; } // 0x0000000180939EF0-0x0000000180939F30 
		internal bool canAccess { [NativeMethod] /* 0x00000001800DB770-0x00000001800DB7A0 */ get => default; } // 0x0000000180939E60-0x0000000180939EA0 
		public int vertexCount { [NativeMethod] /* 0x00000001800DCFB0-0x00000001800DCFE0 */ get => default; } // 0x000000018093A190-0x000000018093A1D0 
		public int subMeshCount { [NativeMethod] /* 0x00000001800DD010-0x00000001800DD050 */ get => default; } // 0x0000000180939F70-0x0000000180939FB0 
		public Bounds bounds { get => default; set {} } // 0x0000000180939DF0-0x0000000180939E60 0x000000018093A260-0x000000018093A2B0
		public Vector3[] vertices { get => default; set {} } // 0x000000018093A1D0-0x000000018093A210 0x000000018093A640-0x000000018093A690
		public Vector3[] normals { get => default; set {} } // 0x0000000180939F30-0x0000000180939F70 0x000000018093A360-0x000000018093A3B0
		public Vector4[] tangents { get => default; set {} } // 0x0000000180939FB0-0x0000000180939FF0 0x000000018093A3B0-0x000000018093A400
		public Vector2[] uv { get => default; set {} } // 0x000000018093A150-0x000000018093A190 0x000000018093A5F0-0x000000018093A640
		public Vector2[] uv2 { get => default; set {} } // 0x000000018093A090-0x000000018093A0D0 0x000000018093A500-0x000000018093A550
		public Vector2[] uv3 { get => default; set {} } // 0x000000018093A0D0-0x000000018093A110 0x000000018093A550-0x000000018093A5A0
		public Vector2[] uv4 { get => default; set {} } // 0x000000018093A110-0x000000018093A150 0x000000018093A5A0-0x000000018093A5F0
		public Color[] colors { set {} } // 0x000000018093A310-0x000000018093A360
		public Color32[] colors32 { get => default; set {} } // 0x0000000180939EA0-0x0000000180939EF0 0x000000018093A2B0-0x000000018093A310
		public int[] triangles { get => default; set {} } // 0x0000000180939FF0-0x000000018093A090 0x000000018093A400-0x000000018093A500
	
		// Constructors
		[RequiredByNativeCode] // 0x00000001800D4E50-0x00000001800D4E60
		public Mesh() {} // 0x0000000180939D20-0x0000000180939DA0
	
		// Methods
		[FreeFunction] // 0x00000001800D8E90-0x00000001800D8EC0
		private static void Internal_Create([Writable] /* 0x00000001800D4E50-0x00000001800D4E60 */ Mesh mono) {} // 0x00000001809387D0-0x0000000180938810
		[FreeFunction] // 0x00000001800D92E0-0x00000001800D9320
		private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) => default; // 0x0000000180938590-0x00000001809385F0
		[FreeFunction] // 0x00000001800D95D0-0x00000001800D9610
		private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) => default; // 0x0000000180938400-0x0000000180938460
		[FreeFunction] // 0x00000001800D9770-0x00000001800D97B0
		private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) {} // 0x0000000180938CC0-0x0000000180938D30
		[FreeFunction] // 0x00000001800D99B0-0x00000001800D99F0
		private void PrintErrorCantAccessChannel(VertexAttribute ch) {} // 0x0000000180938810-0x0000000180938850
		[FreeFunction] // 0x00000001800D9E50-0x00000001800D9E90
		public bool HasVertexAttribute(VertexAttribute attr) => default; // 0x0000000180938790-0x00000001809387D0
		[FreeFunction] // 0x00000001800DA060-0x00000001800DA0A0
		private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount) {} // 0x0000000180938B40-0x0000000180938BA0
		[FreeFunction] // 0x00000001800DA0D0-0x00000001800DA110
		private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) => default; // 0x00000001809383A0-0x0000000180938400
		[NativeMethod] // 0x00000001800DD150-0x00000001800DD180
		private void ClearImpl(bool keepVertexLayout) {} // 0x0000000180938180-0x00000001809381D0
		[NativeMethod] // 0x00000001800DE550-0x00000001800DE580
		private void RecalculateBoundsImpl() {} // 0x0000000180938920-0x0000000180938960
		[NativeMethod] // 0x00000001800DE5B0-0x00000001800DE5E0
		private void RecalculateNormalsImpl() {} // 0x0000000180938A30-0x0000000180938A70
		[NativeMethod] // 0x00000001800DE610-0x00000001800DE640
		private void UploadMeshDataImpl(bool markNoLongerReadable) {} // 0x0000000180939C60-0x0000000180939CB0
		[FreeFunction] // 0x00000001800DE840-0x00000001800DE880
		private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) {} // 0x0000000180938210-0x0000000180938290
		internal VertexAttribute GetUVChannel(int uvIndex) => default; // 0x0000000180938720-0x0000000180938790
		internal static int DefaultDimensionForChannel(VertexAttribute channel) => default; // 0x0000000180938300-0x00000001809383A0
		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) => default;
		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) => default;
		private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount) {} // 0x0000000180939070-0x0000000180939330
		private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values) {}
		private void SetArrayForChannel<T>(VertexAttribute channel, T[] values) {}
		private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length) {}
		private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length) {}
		public void SetVertices(List<Vector3> inVertices) {} // 0x0000000180939B60-0x0000000180939BF0
		public void SetVertices(List<Vector3> inVertices, int start, int length) {} // 0x0000000180939BF0-0x0000000180939C60
		public void SetNormals(List<Vector3> inNormals) {} // 0x0000000180938FE0-0x0000000180939070
		public void SetNormals(List<Vector3> inNormals, int start, int length) {} // 0x0000000180938F60-0x0000000180938FE0
		public void SetTangents(List<Vector4> inTangents) {} // 0x00000001809393B0-0x0000000180939440
		public void SetTangents(List<Vector4> inTangents, int start, int length) {} // 0x0000000180939330-0x00000001809393B0
		public void SetColors(List<Color32> inColors) {} // 0x0000000180938BA0-0x0000000180938C40
		public void SetColors(List<Color32> inColors, int start, int length) {} // 0x0000000180938C40-0x0000000180938CC0
		private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length) {}
		public void SetUVs(int channel, List<Vector2> uvs) {} // 0x0000000180939A30-0x0000000180939AE0
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length) {} // 0x0000000180939AE0-0x0000000180939B60
		private void PrintErrorCantAccessIndices() {} // 0x0000000180938850-0x0000000180938920
		private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) => default; // 0x0000000180937E90-0x0000000180937FB0
		private bool CheckCanAccessSubmeshTriangles(int submesh) => default; // 0x0000000180937E80-0x0000000180937E90
		private bool CheckCanAccessSubmeshIndices(int submesh) => default; // 0x0000000180937E70-0x0000000180937E80
		public int[] GetTriangles(int submesh) => default; // 0x00000001809385F0-0x0000000180938680
		public int[] GetTriangles(int submesh, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool applyBaseVertex) => default; // 0x0000000180938680-0x0000000180938720
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public int[] GetIndices(int submesh) => default; // 0x0000000180938460-0x00000001809384F0
		public int[] GetIndices(int submesh, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool applyBaseVertex) => default; // 0x00000001809384F0-0x0000000180938590
		private void CheckIndicesArrayRange(int valuesLength, int start, int length) {} // 0x0000000180937FB0-0x0000000180938180
		private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) {} // 0x0000000180939440-0x0000000180939500
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void SetTriangles(int[] triangles, int submesh) {} // 0x0000000180939980-0x0000000180939A30
		public void SetTriangles(int[] triangles, int submesh, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool calculateBounds, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int baseVertex) {} // 0x0000000180939500-0x00000001809395C0
		public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true /* Metadata: 0x0064BBF7 */, int baseVertex = 0 /* Metadata: 0x0064BBF8 */) {} // 0x00000001809396D0-0x0000000180939780
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void SetTriangles(List<int> triangles, int submesh) {} // 0x0000000180939780-0x0000000180939880
		public void SetTriangles(List<int> triangles, int submesh, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool calculateBounds, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int baseVertex) {} // 0x00000001809395C0-0x00000001809396D0
		public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true /* Metadata: 0x0064BBFC */, int baseVertex = 0 /* Metadata: 0x0064BBFD */) {} // 0x0000000180939880-0x0000000180939980
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void SetIndices(int[] indices, MeshTopology topology, int submesh) {} // 0x0000000180938D30-0x0000000180938D50
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) {} // 0x0000000180938E30-0x0000000180938E60
		public void SetIndices(int[] indices, MeshTopology topology, int submesh, [DefaultValue] /* 0x00000001800DE930-0x00000001800DE960 */ bool calculateBounds, [DefaultValue] /* 0x00000001800DEB90-0x00000001800DEBC0 */ int baseVertex) {} // 0x0000000180938E60-0x0000000180938F60
		public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true /* Metadata: 0x0064BC01 */, int baseVertex = 0 /* Metadata: 0x0064BC02 */) {} // 0x0000000180938D50-0x0000000180938E30
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void Clear() {} // 0x00000001809381D0-0x0000000180938210
		public void RecalculateBounds() {} // 0x0000000180938960-0x0000000180938A30
		public void RecalculateNormals() {} // 0x0000000180938A70-0x0000000180938B40
		public void UploadMeshData(bool markNoLongerReadable) {} // 0x0000000180939CB0-0x0000000180939D20
		[ExcludeFromDocs] // 0x00000001800D4E50-0x00000001800D4E60
		public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) {} // 0x0000000180938290-0x0000000180938300
		private void get_bounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x0000000180939DA0-0x0000000180939DF0
		private void set_bounds_Injected(ref Bounds value) {} // 0x000000018093A210-0x000000018093A260
	}
}
