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
	// [AddComponentMenu] // 0x0000000180104650-0x00000001801046F0
	[ExecuteInEditMode] // 0x0000000180104650-0x00000001801046F0
	[ImageEffectAllowedInSceneView] // 0x0000000180104650-0x00000001801046F0
	// [RequireComponent] // 0x0000000180104650-0x00000001801046F0
	public class AmbientOcclusion : MonoBehaviour // TypeDefIndex: 5970
	{
		// Fields
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		public Settings settings; // 0x18
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Shader _aoShader; // 0x20
		private Material _aoMaterial; // 0x28
		private CommandBuffer _aoCommands; // 0x30
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Mesh _quadMesh; // 0x50
	
		// Properties
		public bool isAmbientOnlySupported { get => default; } // 0x000000018082ACB0-0x000000018082AD20 
		public bool isGBufferAvailable { get => default; } // 0x000000018082AD20-0x000000018082AD80 
		private float intensity { get => default; } // 0x000000018082AC90-0x000000018082ACB0 
		private float radius { get => default; } // 0x000000018082AE20-0x000000018082AEA0 
		private SampleCount sampleCount { get => default; } // 0x00000001805F2830-0x00000001805F2850 
		private int sampleCountValue { get => default; } // 0x000000018082AEA0-0x000000018082AF60 
		private OcclusionSource occlusionSource { get => default; } // 0x000000018082AD80-0x000000018082AE00 
		private bool downsampling { get => default; } // 0x000000018082AC70-0x000000018082AC90 
		private bool ambientOnly { get => default; } // 0x000000018082A9F0-0x000000018082AA80 
		private RenderTextureFormat aoTextureFormat { get => default; } // 0x000000018082AC40-0x000000018082AC70 
		private Shader aoShader { get => default; } // 0x000000018082ABB0-0x000000018082AC40 
		private Material aoMaterial { get => default; } // 0x000000018082AB10-0x000000018082ABB0 
		private CommandBuffer aoCommands { get => default; } // 0x000000018082AA80-0x000000018082AB10 
		private Camera targetCamera { get => default; } // 0x000000018082AF60-0x000000018082AFA0 
		private PropertyObserver propertyObserver { get; set; } // 0x000000018082AE00-0x000000018082AE20 0x000000018082AFA0-0x000000018082AFB0
		private Mesh quadMesh { get => default; } // 0x00000001802505D0-0x00000001802505E0 
	
		// Nested types
		private struct PropertyObserver // TypeDefIndex: 5971
		{
			// Fields
			private bool _downsampling; // 0x00
			private OcclusionSource _occlusionSource; // 0x04
			private bool _ambientOnly; // 0x08
			private bool _debug; // 0x09
			private int _pixelWidth; // 0x0C
			private int _pixelHeight; // 0x10
	
			// Methods
			public bool CheckNeedsReset(Settings setting, Camera camera) => default; // 0x0000000180030310-0x0000000180030320
			public void Update(Settings setting, Camera camera) {} // 0x0000000180030320-0x0000000180030420
		}
	
		public enum SampleCount // TypeDefIndex: 5972
		{
			Lowest = 0,
			Low = 1,
			Medium = 2,
			High = 3,
			Variable = 4
		}
	
		public enum OcclusionSource // TypeDefIndex: 5973
		{
			DepthTexture = 0,
			DepthNormalsTexture = 1,
			GBuffer = 2
		}
	
		[Serializable]
		public class Settings // TypeDefIndex: 5974
		{
			// Fields
			// [Range] // 0x0000000180106070-0x00000001801060D0
			[SerializeField] // 0x0000000180106070-0x00000001801060D0
			// [Tooltip] // 0x0000000180106070-0x00000001801060D0
			public float intensity; // 0x10
			[SerializeField] // 0x0000000180106210-0x0000000180106250
			// [Tooltip] // 0x0000000180106210-0x0000000180106250
			public float radius; // 0x14
			[SerializeField] // 0x00000001801062F0-0x0000000180106330
			// [Tooltip] // 0x00000001801062F0-0x0000000180106330
			public SampleCount sampleCount; // 0x18
			[SerializeField] // 0x0000000180106430-0x0000000180106470
			// [Tooltip] // 0x0000000180106430-0x0000000180106470
			public int sampleCountValue; // 0x1C
			[SerializeField] // 0x0000000180106560-0x00000001801065A0
			// [Tooltip] // 0x0000000180106560-0x00000001801065A0
			public bool downsampling; // 0x20
			[SerializeField] // 0x0000000180106650-0x0000000180106690
			// [Tooltip] // 0x0000000180106650-0x0000000180106690
			public bool ambientOnly; // 0x21
			[SerializeField] // 0x0000000180106740-0x0000000180106780
			// [Tooltip] // 0x0000000180106740-0x0000000180106780
			public OcclusionSource occlusionSource; // 0x24
			[SerializeField] // 0x0000000180106870-0x00000001801068B0
			// [Tooltip] // 0x0000000180106870-0x00000001801068B0
			public bool debug; // 0x28
	
			// Properties
			public static Settings defaultSettings { get => default; } // 0x0000000180836C80-0x0000000180836D00 
	
			// Constructors
			public Settings() {} // 0x00000001802466A0-0x00000001802466B0
		}
	
		// Constructors
		public AmbientOcclusion() {} // 0x000000018082A950-0x000000018082A9F0
	
		// Methods
		private void BuildAOCommands() {} // 0x00000001808291B0-0x0000000180829A10
		private void ExecuteAOPass(RenderTexture source, RenderTexture destination) {} // 0x0000000180829A10-0x000000018082A0B0
		private void UpdateMaterialProperties() {} // 0x000000018082A3E0-0x000000018082A5B0
		private void OnEnable() {} // 0x000000018082A1C0-0x000000018082A330
		private void OnDisable() {} // 0x000000018082A0B0-0x000000018082A1C0
		private void Update() {} // 0x000000018082A5B0-0x000000018082A950
		[ImageEffectOpaque] // 0x00000001800D4E50-0x00000001800D4E60
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x000000018082A330-0x000000018082A3E0
	}
}
