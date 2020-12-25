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
using UnityEngineInternal;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x0000000180145B50-0x0000000180145C00
	// [NativeHeader] // 0x0000000180145B50-0x0000000180145C00
	// [RequireComponent] // 0x0000000180145B50-0x0000000180145C00
	[UsedByNativeCode] // 0x0000000180145B50-0x0000000180145C00
	public class Renderer : Component // TypeDefIndex: 3155
	{
		// Properties
		public Bounds bounds { [FreeFunction] /* 0x0000000180145DD0-0x0000000180145E10 */ get => default; } // 0x00000001808D92A0-0x00000001808D9310 
		public bool enabled { get => default; set {} } // 0x00000001808D9310-0x00000001808D9350 0x00000001808D9670-0x00000001808D96C0
		public bool isVisible { /* [NativeName] */ /* 0x0000000180146530-0x0000000180146560 */ get => default; } // 0x00000001808D9390-0x00000001808D93D0 
		public ShadowCastingMode shadowCastingMode { get => default; set {} } // 0x00000001808D95B0-0x00000001808D95F0 0x00000001808D9860-0x00000001808D9A60
		public bool receiveShadows { get => default; set {} } // 0x00000001808D9530-0x00000001808D9570 0x00000001808D97D0-0x00000001808D9820
		public MotionVectorGenerationMode motionVectorGenerationMode { get => default; set {} } // 0x00000001808D94B0-0x00000001808D94F0 0x00000001808D9790-0x00000001808D97D0
		public LightProbeUsage lightProbeUsage { get => default; set {} } // 0x00000001808D93D0-0x00000001808D9410 0x00000001808D96C0-0x00000001808D9700
		public ReflectionProbeUsage reflectionProbeUsage { get => default; set {} } // 0x00000001808D9570-0x00000001808D95B0 0x00000001808D9820-0x00000001808D9860
		public int sortingLayerID { get => default; } // 0x00000001808D95F0-0x00000001808D9630 
		public int sortingOrder { get => default; } // 0x00000001808D9630-0x00000001808D9670 
		public bool isPartOfStaticBatch { /* [NativeName] */ /* 0x00000001801465C0-0x00000001801465F0 */ get => default; } // 0x00000001808D9350-0x00000001808D9390 
		public Transform probeAnchor { get => default; } // 0x00000001808D94F0-0x00000001808D9530 
		public int lightmapIndex { get => default; set {} } // 0x00000001808D9410-0x00000001808D9450 0x00000001808D9700-0x00000001808D9750
		public Vector4 lightmapScaleOffset { get => default; set {} } // 0x00000001808D9450-0x00000001808D94B0 0x00000001808D9750-0x00000001808D9790
		public Material[] materials { get => default; set {} } // 0x00000001808D8F20-0x00000001808D8F60 0x00000001808D9110-0x00000001808D9160
		public Material material { get => default; set {} } // 0x00000001808D8F60-0x00000001808D8FA0 0x00000001808D9160-0x00000001808D91B0
		public Material sharedMaterial { get => default; set {} } // 0x00000001808D9030-0x00000001808D9070 0x00000001808D9160-0x00000001808D91B0
		public Material[] sharedMaterials { get => default; set {} } // 0x00000001808D8FF0-0x00000001808D9030 0x00000001808D9110-0x00000001808D9160
	
		// Constructors
		public Renderer() {} // Dummy constructor
	
		// Methods
		[FreeFunction] // 0x0000000180145E60-0x0000000180145EA0
		private void SetStaticLightmapST(Vector4 st) {} // 0x00000001808D9200-0x00000001808D9250
		[FreeFunction] // 0x0000000180145F50-0x0000000180145F90
		private Material GetMaterial() => default; // 0x00000001808D8F60-0x00000001808D8FA0
		[FreeFunction] // 0x0000000180145FF0-0x0000000180146030
		private Material GetSharedMaterial() => default; // 0x00000001808D9030-0x00000001808D9070
		[FreeFunction] // 0x0000000180146090-0x00000001801460D0
		private void SetMaterial(Material m) {} // 0x00000001808D9160-0x00000001808D91B0
		[FreeFunction] // 0x0000000180146130-0x0000000180146170
		private Material[] GetMaterialArray() => default; // 0x00000001808D8F20-0x00000001808D8F60
		[FreeFunction] // 0x00000001801461D0-0x0000000180146210
		private void SetMaterialArray([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ Material[] m) {} // 0x00000001808D9110-0x00000001808D9160
		[FreeFunction] // 0x00000001801462D0-0x0000000180146310
		internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) {} // 0x00000001808D9070-0x00000001808D90C0
		[FreeFunction] // 0x0000000180146400-0x0000000180146440
		internal void Internal_GetPropertyBlock([NotNull] /* 0x00000001800D4E50-0x00000001800D4E60 */ MaterialPropertyBlock dest) {} // 0x00000001808D8FA0-0x00000001808D8FF0
		public void SetPropertyBlock(MaterialPropertyBlock properties) {} // 0x00000001808D9070-0x00000001808D90C0
		public void GetPropertyBlock(MaterialPropertyBlock properties) {} // 0x00000001808D8FA0-0x00000001808D8FF0
		// [NativeName] // 0x00000001801466E0-0x0000000180146710
		private int GetLightmapIndex(LightmapType lt) => default; // 0x00000001808D8E20-0x00000001808D8E60
		// [NativeName] // 0x00000001801467F0-0x0000000180146820
		private void SetLightmapIndex(int index, LightmapType lt) {} // 0x00000001808D90C0-0x00000001808D9110
		// [NativeName] // 0x0000000180146850-0x0000000180146880
		private Vector4 GetLightmapST(LightmapType lt) => default; // 0x00000001808D8EB0-0x00000001808D8F20
		// [NativeName] // 0x0000000180146900-0x0000000180146930
		private Material[] GetSharedMaterialArray() => default; // 0x00000001808D8FF0-0x00000001808D9030
		private void get_bounds_Injected(out Bounds ret) {
			ret = default;
		} // 0x00000001808D9250-0x00000001808D92A0
		private void SetStaticLightmapST_Injected(ref Vector4 st) {} // 0x00000001808D91B0-0x00000001808D9200
		private void GetLightmapST_Injected(LightmapType lt, out Vector4 ret) {
			ret = default;
		} // 0x00000001808D8E60-0x00000001808D8EB0
	}
}
