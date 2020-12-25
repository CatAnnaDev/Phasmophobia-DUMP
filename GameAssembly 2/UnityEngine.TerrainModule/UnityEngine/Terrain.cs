/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 17: UnityEngine.TerrainModule.dll - Assembly: UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3799-3816

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180116A10-0x0000000180116AD0
	// [NativeHeader] // 0x0000000180116A10-0x0000000180116AD0
	// [NativeHeader] // 0x0000000180116A10-0x0000000180116AD0
	// [StaticAccessor] // 0x0000000180116A10-0x0000000180116AD0
	[UsedByNativeCode] // 0x0000000180116A10-0x0000000180116AD0
	public sealed class Terrain : Behaviour // TypeDefIndex: 3800
	{
		// Properties
		public TerrainData terrainData { get => default; } // 0x0000000180ADFFF0-0x0000000180AE0030 
		[NativeProperty] // 0x0000000180118190-0x00000001801181C0
		public int lightmapIndex { get => default; set {} } // 0x0000000180ADFFB0-0x0000000180ADFFF0 0x0000000180AE0030-0x0000000180AE0070
		[NativeProperty] // 0x0000000180118220-0x0000000180118250
		public Vector4 lightmapScaleOffset { set {} } // 0x0000000180AE00C0-0x0000000180AE0110
		public bool allowAutoConnect { get => default; } // 0x0000000180ADFF30-0x0000000180ADFF70 
		public int groupingID { get => default; } // 0x0000000180ADFF70-0x0000000180ADFFB0 
		public static Terrain activeTerrain { get => default; } // 0x0000000180ADFED0-0x0000000180ADFF00 
		[NativeProperty] // 0x0000000180118250-0x0000000180118280
		public static Terrain[] activeTerrains { get => default; } // 0x0000000180ADFF00-0x0000000180ADFF30 
	
		// Constructors
		public Terrain() {} // 0x00000001808E4F10-0x00000001808E4F20
	
		// Methods
		public float SampleHeight(Vector3 worldPosition) => default; // 0x0000000180ADFDC0-0x0000000180ADFE10
		public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) {} // 0x0000000180ADFE10-0x0000000180ADFE80
		public Vector3 GetPosition() => default; // 0x0000000180ADFD00-0x0000000180ADFD70
		[NativeMethod] // 0x0000000180118090-0x00000001801180C0
		public void SetSplatMaterialPropertyBlock(MaterialPropertyBlock properties) {} // 0x0000000180ADFE80-0x0000000180ADFED0
		private void set_lightmapScaleOffset_Injected(ref Vector4 value) {} // 0x0000000180AE0070-0x0000000180AE00C0
		private float SampleHeight_Injected(ref Vector3 worldPosition) => default; // 0x0000000180ADFD70-0x0000000180ADFDC0
		private void GetPosition_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000180ADFCB0-0x0000000180ADFD00
	}
}
