/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.CinematicEffects
{
	// [AddComponentMenu] // 0x000000018010E430-0x000000018010E4D0
	[ExecuteInEditMode] // 0x000000018010E430-0x000000018010E4D0
	[ImageEffectAllowedInSceneView] // 0x000000018010E430-0x000000018010E4D0
	// [RequireComponent] // 0x000000018010E430-0x000000018010E4D0
	public class ScreenSpaceReflection : MonoBehaviour // TypeDefIndex: 6018
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		public SSRSettings settings; // 0x18
		// [Tooltip] // 0x000000018010E620-0x000000018010E650
		private bool highlightSuppression; // 0x4C
		// [Tooltip] // 0x000000018010E6C0-0x000000018010E6F0
		private bool traceBehindObjects; // 0x4D
		// [Tooltip] // 0x000000018010E760-0x000000018010E790
		private bool treatBackfaceHitAsMiss; // 0x4E
		// [Tooltip] // 0x000000018010E840-0x000000018010E870
		private bool bilateralUpsample; // 0x4F
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Shader m_Shader; // 0x50
		private Material m_Material; // 0x58
		private Camera m_Camera; // 0x60
		private CommandBuffer m_CommandBuffer; // 0x68
		private static int kNormalAndRoughnessTexture; // 0x00
		private static int kHitPointTexture; // 0x04
		private static int[] kReflectionTextures; // 0x08
		private static int kFilteredReflections; // 0x10
		private static int kBlurTexture; // 0x14
		private static int kFinalReflectionTexture; // 0x18
		private static int kTempTexture; // 0x1C
	
		// Properties
		public Shader shader { get => default; } // 0x0000000180628090-0x0000000180628120 
		public Material material { get => default; } // 0x0000000180627FF0-0x0000000180628090 
		public Camera camera_ { get => default; } // 0x0000000180627F50-0x0000000180627FF0 
	
		// Nested types
		public enum SSRResolution // TypeDefIndex: 6019
		{
			High = 0,
			Low = 2
		}
	
		public enum SSRReflectionBlendType // TypeDefIndex: 6020
		{
			PhysicallyBased = 0,
			Additive = 1
		}
	
		[Serializable]
		public struct SSRSettings // TypeDefIndex: 6021
		{
			// Fields
			[Layout] // 0x0000000180107390-0x00000001801073A0
			public ReflectionSettings reflectionSettings; // 0x00
			[Layout] // 0x0000000180107390-0x00000001801073A0
			public IntensitySettings intensitySettings; // 0x20
			[Layout] // 0x0000000180107390-0x00000001801073A0
			public ScreenEdgeMask screenEdgeMask; // 0x30
			private static readonly SSRSettings s_Default; // 0x00
	
			// Properties
			public static SSRSettings defaultSettings { get => default; } // 0x0000000180625BF0-0x0000000180625C70 
	
			// Nested types
			[AttributeUsage(AttributeTargets.All)] // 0x00000001800DFE30-0x00000001800DFE50
			public class LayoutAttribute : PropertyAttribute // TypeDefIndex: 6022
			{
				// Constructors
				public LayoutAttribute() {} // 0x000000018061D7D0-0x000000018061D7E0
			}
	
			// Constructors
			static SSRSettings() {
				s_Default = default;
			} // 0x0000000180625B30-0x0000000180625BF0
		}
	
		[Serializable]
		public struct IntensitySettings // TypeDefIndex: 6023
		{
			// Fields
			// [Range] // 0x000000018010E990-0x000000018010E9F0
			// [Tooltip] // 0x000000018010E990-0x000000018010E9F0
			public float reflectionMultiplier; // 0x00
			// [Range] // 0x000000018010E9F0-0x000000018010EA50
			// [Tooltip] // 0x000000018010E9F0-0x000000018010EA50
			public float fadeDistance; // 0x04
			// [Range] // 0x000000018010EA50-0x000000018010EAB0
			// [Tooltip] // 0x000000018010EA50-0x000000018010EAB0
			public float fresnelFade; // 0x08
			// [Range] // 0x000000018010EB00-0x000000018010EB60
			// [Tooltip] // 0x000000018010EB00-0x000000018010EB60
			public float fresnelFadePower; // 0x0C
		}
	
		[Serializable]
		public struct ReflectionSettings // TypeDefIndex: 6024
		{
			// Fields
			// [Tooltip] // 0x000000018010EBB0-0x000000018010EBE0
			public SSRReflectionBlendType blendType; // 0x00
			// [Tooltip] // 0x000000018010ECD0-0x000000018010ED00
			public SSRResolution reflectionQuality; // 0x04
			// [Range] // 0x000000018010ED80-0x000000018010EDE0
			// [Tooltip] // 0x000000018010ED80-0x000000018010EDE0
			public float maxDistance; // 0x08
			// [Range] // 0x000000018010EEB0-0x000000018010EF10
			// [Tooltip] // 0x000000018010EEB0-0x000000018010EF10
			public int iterationCount; // 0x0C
			// [Range] // 0x000000018010EFB0-0x000000018010F010
			// [Tooltip] // 0x000000018010EFB0-0x000000018010F010
			public int stepSize; // 0x10
			// [Range] // 0x000000018010F0E0-0x000000018010F140
			// [Tooltip] // 0x000000018010F0E0-0x000000018010F140
			public float widthModifier; // 0x14
			// [Range] // 0x000000018010F250-0x000000018010F2B0
			// [Tooltip] // 0x000000018010F250-0x000000018010F2B0
			public float reflectionBlur; // 0x18
			// [Tooltip] // 0x000000018010F3E0-0x000000018010F410
			public bool reflectBackfaces; // 0x1C
		}
	
		[Serializable]
		public struct ScreenEdgeMask // TypeDefIndex: 6025
		{
			// Fields
			// [Range] // 0x000000018010F570-0x000000018010F5D0
			// [Tooltip] // 0x000000018010F570-0x000000018010F5D0
			public float intensity; // 0x00
		}
	
		private enum PassIndex // TypeDefIndex: 6026
		{
			RayTraceStep = 0,
			CompositeFinal = 1,
			Blur = 2,
			CompositeSSR = 3,
			MinMipGeneration = 4,
			HitPointToReflections = 5,
			BilateralKeyPack = 6,
			BlitDepthAsCSZ = 7,
			PoissonBlur = 8
		}
	
		// Constructors
		public ScreenSpaceReflection() {} // 0x0000000180627E80-0x0000000180627F50
	
		// Methods
		private void OnEnable() {} // 0x0000000180625DA0-0x0000000180626080
		private void OnDisable() {} // 0x0000000180625C70-0x0000000180625DA0
		public void OnPreRender() {} // 0x0000000180626080-0x0000000180627E80
	}
}
