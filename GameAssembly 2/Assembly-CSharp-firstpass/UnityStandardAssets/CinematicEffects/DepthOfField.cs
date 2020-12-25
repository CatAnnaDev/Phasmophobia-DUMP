/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.CinematicEffects
{
	// [AddComponentMenu] // 0x000000018010AC90-0x000000018010AD20
	[ExecuteInEditMode] // 0x000000018010AC90-0x000000018010AD20
	// [RequireComponent] // 0x000000018010AC90-0x000000018010AD20
	public class DepthOfField : MonoBehaviour // TypeDefIndex: 5999
	{
		// Fields
		private const float kMaxBlur = 40f; // Metadata: 0x00650989
		public GlobalSettings settings; // 0x18
		public FocusSettings focus; // 0x30
		public BokehTextureSettings bokehTexture; // 0x58
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Shader m_FilmicDepthOfFieldShader; // 0x70
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Shader m_MedianFilterShader; // 0x78
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Shader m_TextureBokehShader; // 0x80
		private RenderTextureUtility m_RTU; // 0x88
		private Material m_FilmicDepthOfFieldMaterial; // 0x90
		private Material m_MedianFilterMaterial; // 0x98
		private Material m_TextureBokehMaterial; // 0xA0
		private ComputeBuffer m_ComputeBufferDrawArgs; // 0xA8
		private ComputeBuffer m_ComputeBufferPoints; // 0xB0
		private QualitySettings m_CurrentQualitySettings; // 0xB8
		private float m_LastApertureOrientation; // 0xC4
		private Vector4 m_OctogonalBokehDirection1; // 0xC8
		private Vector4 m_OctogonalBokehDirection2; // 0xD8
		private Vector4 m_OctogonalBokehDirection3; // 0xE8
		private Vector4 m_OctogonalBokehDirection4; // 0xF8
		private Vector4 m_HexagonalBokehDirection1; // 0x108
		private Vector4 m_HexagonalBokehDirection2; // 0x118
		private Vector4 m_HexagonalBokehDirection3; // 0x128
	
		// Properties
		public Shader filmicDepthOfFieldShader { get => default; } // 0x000000018082F6B0-0x000000018082F740 
		public Shader medianFilterShader { get => default; } // 0x000000018082F7F0-0x000000018082F880 
		public Shader textureBokehShader { get => default; } // 0x000000018082F9F0-0x000000018082FA90 
		public Material filmicDepthOfFieldMaterial { get => default; } // 0x000000018082F600-0x000000018082F6B0 
		public Material medianFilterMaterial { get => default; } // 0x000000018082F740-0x000000018082F7F0 
		public Material textureBokehMaterial { get => default; } // 0x000000018082F940-0x000000018082F9F0 
		public ComputeBuffer computeBufferDrawArgs { get => default; } // 0x000000018082F480-0x000000018082F570 
		public ComputeBuffer computeBufferPoints { get => default; } // 0x000000018082F570-0x000000018082F600 
		private bool shouldPerformBokeh { get => default; } // 0x000000018082F880-0x000000018082F940 
	
		// Nested types
		private enum Passes // TypeDefIndex: 6000
		{
			BlurAlphaWeighted = 0,
			BoxBlur = 1,
			DilateFgCocFromColor = 2,
			DilateFgCoc = 3,
			CaptureCocExplicit = 4,
			VisualizeCocExplicit = 5,
			CocPrefilter = 6,
			CircleBlur = 7,
			CircleBlurWithDilatedFg = 8,
			CircleBlurLowQuality = 9,
			CircleBlowLowQualityWithDilatedFg = 10,
			MergeExplicit = 11,
			ShapeLowQuality = 12,
			ShapeLowQualityDilateFg = 13,
			ShapeLowQualityMerge = 14,
			ShapeLowQualityMergeDilateFg = 15,
			ShapeMediumQuality = 16,
			ShapeMediumQualityDilateFg = 17,
			ShapeMediumQualityMerge = 18,
			ShapeMediumQualityMergeDilateFg = 19,
			ShapeHighQuality = 20,
			ShapeHighQualityDilateFg = 21,
			ShapeHighQualityMerge = 22,
			ShapeHighQualityMergeDilateFg = 23
		}
	
		private enum MedianPasses // TypeDefIndex: 6001
		{
			Median3 = 0,
			Median3X3 = 1
		}
	
		private enum BokehTexturesPasses // TypeDefIndex: 6002
		{
			Apply = 0,
			Collect = 1
		}
	
		public enum TweakMode // TypeDefIndex: 6003
		{
			Range = 0,
			Explicit = 1
		}
	
		public enum ApertureShape // TypeDefIndex: 6004
		{
			Circular = 0,
			Hexagonal = 1,
			Octogonal = 2
		}
	
		public enum QualityPreset // TypeDefIndex: 6005
		{
			Low = 0,
			Medium = 1,
			High = 2
		}
	
		public enum FilterQuality // TypeDefIndex: 6006
		{
			None = 0,
			Normal = 1,
			High = 2
		}
	
		[Serializable]
		public struct GlobalSettings // TypeDefIndex: 6007
		{
			// Fields
			// [Tooltip] // 0x000000018010AF80-0x000000018010AFB0
			public bool visualizeFocus; // 0x00
			// [Tooltip] // 0x000000018010B0B0-0x000000018010B0E0
			public TweakMode tweakMode; // 0x04
			// [Tooltip] // 0x000000018010B1C0-0x000000018010B1F0
			public QualityPreset filteringQuality; // 0x08
			// [Tooltip] // 0x000000018010B270-0x000000018010B2A0
			public ApertureShape apertureShape; // 0x0C
			// [Range] // 0x000000018010B320-0x000000018010B370
			// [Tooltip] // 0x000000018010B320-0x000000018010B370
			public float apertureOrientation; // 0x10
	
			// Properties
			public static GlobalSettings defaultSettings { get => default; } // 0x0000000180831C20-0x0000000180831C60 
		}
	
		[Serializable]
		public struct QualitySettings // TypeDefIndex: 6008
		{
			// Fields
			// [Tooltip] // 0x000000018010B3A0-0x000000018010B3D0
			public bool prefilterBlur; // 0x00
			// [Tooltip] // 0x000000018010B4D0-0x000000018010B500
			public FilterQuality medianFilter; // 0x04
			// [Tooltip] // 0x000000018010B580-0x000000018010B5B0
			public bool dilateNearBlur; // 0x08
			public static QualitySettings[] presetQualitySettings; // 0x00
	
			// Constructors
			static QualitySettings() {
				presetQualitySettings = default;
			} // 0x00000001808353A0-0x00000001808354B0
		}
	
		[Serializable]
		public struct FocusSettings // TypeDefIndex: 6009
		{
			// Fields
			// [Tooltip] // 0x000000018010B6A0-0x000000018010B6D0
			public Transform transform; // 0x00
			// [Min] // 0x000000018010B720-0x000000018010B770
			// [Tooltip] // 0x000000018010B720-0x000000018010B770
			public float focusPlane; // 0x08
			// [Min] // 0x000000018010B770-0x000000018010B7C0
			// [Tooltip] // 0x000000018010B770-0x000000018010B7C0
			public float range; // 0x0C
			// [Min] // 0x000000018010B860-0x000000018010B8B0
			// [Tooltip] // 0x000000018010B860-0x000000018010B8B0
			public float nearPlane; // 0x10
			// [Min] // 0x000000018010B950-0x000000018010B9A0
			// [Tooltip] // 0x000000018010B950-0x000000018010B9A0
			public float nearFalloff; // 0x14
			// [Min] // 0x000000018010B9F0-0x000000018010BA40
			// [Tooltip] // 0x000000018010B9F0-0x000000018010BA40
			public float farPlane; // 0x18
			// [Min] // 0x000000018010BAF0-0x000000018010BB40
			// [Tooltip] // 0x000000018010BAF0-0x000000018010BB40
			public float farFalloff; // 0x1C
			// [Range] // 0x000000018010BBF0-0x000000018010BC40
			// [Tooltip] // 0x000000018010BBF0-0x000000018010BC40
			public float nearBlurRadius; // 0x20
			// [Range] // 0x000000018010BCE0-0x000000018010BD30
			// [Tooltip] // 0x000000018010BCE0-0x000000018010BD30
			public float farBlurRadius; // 0x24
	
			// Properties
			public static FocusSettings defaultSettings { get => default; } // 0x0000000180831420-0x0000000180831490 
		}
	
		[Serializable]
		public struct BokehTextureSettings // TypeDefIndex: 6010
		{
			// Fields
			// [Tooltip] // 0x000000018010BD30-0x000000018010BD60
			public Texture2D texture; // 0x00
			// [Range] // 0x000000018010BDF0-0x000000018010BE40
			// [Tooltip] // 0x000000018010BDF0-0x000000018010BE40
			public float scale; // 0x08
			// [Range] // 0x000000018010BF20-0x000000018010BF70
			// [Tooltip] // 0x000000018010BF20-0x000000018010BF70
			public float intensity; // 0x0C
			// [Range] // 0x000000018010C080-0x000000018010C0D0
			// [Tooltip] // 0x000000018010C080-0x000000018010C0D0
			public float threshold; // 0x10
			// [Range] // 0x000000018010C150-0x000000018010C1A0
			// [Tooltip] // 0x000000018010C150-0x000000018010C1A0
			public float spawnHeuristic; // 0x14
	
			// Properties
			public static BokehTextureSettings defaultSettings { get => default; } // 0x000000018082C8A0-0x000000018082C8F0 
		}
	
		// Constructors
		public DepthOfField() {} // 0x000000018082F340-0x000000018082F480
	
		// Methods
		private void OnEnable() {} // 0x000000018082EF20-0x000000018082F040
		private void OnDisable() {} // 0x000000018082ECF0-0x000000018082EF20
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x000000018082F040-0x000000018082F250
		private void DoDepthOfField(RenderTexture source, RenderTexture destination) {} // 0x000000018082D310-0x000000018082E480
		private void DoHexagonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius) {} // 0x000000018082E480-0x000000018082E820
		private void DoOctogonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius) {} // 0x000000018082E820-0x000000018082EBF0
		private void DoCircularBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius) {} // 0x000000018082D1D0-0x000000018082D310
		private void ComputeCocParameters(out Vector4 blurParams, out Vector4 blurCoe) {
			blurParams = default;
			blurCoe = default;
		} // 0x000000018082CDF0-0x000000018082D1D0
		private void ReleaseComputeResources() {} // 0x000000018082F250-0x000000018082F2C0
		private void ComputeBlurDirections(bool force) {} // 0x000000018082C8F0-0x000000018082CDF0
		private static void Rotate2D(ref Vector4 direction, float cosinus, float sinus) {} // 0x000000018082F2C0-0x000000018082F300
		private static void SwapRenderTexture(ref RenderTexture src, ref RenderTexture dst) {} // 0x000000018082F300-0x000000018082F340
		private static void GetDirectionalBlurPassesFromRadius(RenderTexture blurredFgCoc, float maxRadius, out int blurPass, out int blurAndMergePass) {
			blurPass = default;
			blurAndMergePass = default;
		} // 0x000000018082EBF0-0x000000018082ECF0
	}
}
