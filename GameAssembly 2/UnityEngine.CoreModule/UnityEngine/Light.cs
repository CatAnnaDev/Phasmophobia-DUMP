/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

// Image 7: UnityEngine.CoreModule.dll - Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3059-3645

namespace UnityEngine
{
	// [NativeHeader] // 0x00000001800D5AA0-0x00000001800D5B60
	// [NativeHeader] // 0x00000001800D5AA0-0x00000001800D5B60
	// [RequireComponent] // 0x00000001800D5AA0-0x00000001800D5B60
	// [RequireComponent] // 0x00000001800D5AA0-0x00000001800D5B60
	public sealed class Light : Behaviour // TypeDefIndex: 3161
	{
		// Fields
		private int m_BakedIndex; // 0x18
	
		// Properties
		[NativeProperty] // 0x00000001800D6480-0x00000001800D64B0
		public LightType type { get => default; } // 0x000000018096F0C0-0x000000018096F100 
		public float spotAngle { get => default; set {} } // 0x000000018096F080-0x000000018096F0C0 0x000000018096F3D0-0x000000018096F420
		public Color color { get => default; set {} } // 0x000000018096EE60-0x000000018096EEC0 0x000000018096F1F0-0x000000018096F240
		public float intensity { get => default; set {} } // 0x000000018096EF00-0x000000018096EF40 0x000000018096F290-0x000000018096F2E0
		public float bounceIntensity { get => default; } // 0x000000018096EDD0-0x000000018096EE10 
		public float shadowBias { get => default; set {} } // 0x000000018096EF80-0x000000018096EFC0 0x000000018096F330-0x000000018096F380
		public float shadowNearPlane { get => default; } // 0x000000018096EFC0-0x000000018096F000 
		public float range { get => default; set {} } // 0x000000018096EF40-0x000000018096EF80 0x000000018096F2E0-0x000000018096F330
		public LightBakingOutput bakingOutput { get => default; set {} } // 0x000000018096ED60-0x000000018096EDD0 0x000000018096F150-0x000000018096F1A0
		public LightShadows shadows { [NativeMethod] /* 0x00000001800D6310-0x00000001800D6340 */ get => default; } // 0x000000018096F040-0x000000018096F080 
		public float shadowStrength { get => default; [FreeFunction] /* 0x00000001800D63A0-0x00000001800D63E0 */ set {} } // 0x000000018096F000-0x000000018096F040 0x000000018096F380-0x000000018096F3D0
		public Texture cookie { get => default; set {} } // 0x000000018096EEC0-0x000000018096EF00 0x000000018096F240-0x000000018096F290
	
		// Constructors
		public Light() {} // Dummy constructor
	
		// Methods
		public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) {} // 0x000000018096EC00-0x000000018096EC60
		[FreeFunction] // 0x00000001800D6410-0x00000001800D6450
		public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) {} // 0x000000018096EC60-0x000000018096ECC0
		public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) {} // 0x000000018096ECC0-0x000000018096ED10
		private void get_color_Injected(out Color ret) {
			ret = default;
		} // 0x000000018096EE10-0x000000018096EE60
		private void set_color_Injected(ref Color value) {} // 0x000000018096F1A0-0x000000018096F1F0
		private void get_bakingOutput_Injected(out LightBakingOutput ret) {
			ret = default;
		} // 0x000000018096ED10-0x000000018096ED60
		private void set_bakingOutput_Injected(ref LightBakingOutput value) {} // 0x000000018096F100-0x000000018096F150
	}
}
