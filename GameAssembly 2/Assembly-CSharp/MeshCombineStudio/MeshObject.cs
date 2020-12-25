/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace MeshCombineStudio
{
	[Serializable]
	public class MeshObject // TypeDefIndex: 8562
	{
		// Fields
		public CachedGameObject cachedGO; // 0x10
		public u0925u091Du091Du0929u0928u0928u0923u091Du091Fu091Eu091E meshCache; // 0x18
		public int subMeshIndex; // 0x20
		public Vector3 position; // 0x24
		public Vector3 scale; // 0x30
		public Quaternion rotation; // 0x3C
		public Vector4 lightmapScaleOffset; // 0x4C
		public bool intersectsSurface; // 0x5C
		public int startNewTriangleIndex; // 0x60
		public int newTriangleCount; // 0x64
		public bool skip; // 0x68
	
		// Constructors
		public MeshObject() {} // Dummy constructor
		public MeshObject(CachedGameObject cachedGO, int subMeshIndex) {} // 0x0000000181390260-0x0000000181390330
	}
}
