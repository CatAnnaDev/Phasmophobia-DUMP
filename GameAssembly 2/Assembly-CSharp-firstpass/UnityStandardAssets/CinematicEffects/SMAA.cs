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
	[Serializable]
	public class SMAA : IAntiAliasing // TypeDefIndex: 5983
	{
		// Fields
		[TopLevelSettings] // 0x00000001800D4E50-0x00000001800D4E60
		public GlobalSettings settings; // 0x10
		[SettingsGroup] // 0x00000001800D4E50-0x00000001800D4E60
		public QualitySettings quality; // 0x1C
		[SettingsGroup] // 0x00000001800D4E50-0x00000001800D4E60
		public PredicationSettings predication; // 0x38
		[ExperimentalGroup] // 0x00000001800D5490-0x00000001800D54C0
		[SettingsGroup] // 0x00000001800D5490-0x00000001800D54C0
		public TemporalSettings temporal; // 0x48
		private Matrix4x4 m_ProjectionMatrix; // 0x50
		private Matrix4x4 m_PreviousViewProjectionMatrix; // 0x90
		private float m_FlipFlop; // 0xD0
		private RenderTexture m_Accumulation; // 0xD8
		private Shader m_Shader; // 0xE0
		private Texture2D m_AreaTexture; // 0xE8
		private Texture2D m_SearchTexture; // 0xF0
		private Material m_Material; // 0xF8
	
		// Properties
		public Shader shader { get => default; } // 0x0000000180625A90-0x0000000180625B30 
		private Texture2D areaTexture { get => default; } // 0x00000001806258A0-0x0000000180625940 
		private Texture2D searchTexture { get => default; } // 0x00000001806259F0-0x0000000180625A90 
		private Material material { get => default; } // 0x0000000180625940-0x00000001806259F0 
	
		// Nested types
		[AttributeUsage(AttributeTargets.All)] // 0x00000001800DFE30-0x00000001800DFE50
		public class SettingsGroup : Attribute // TypeDefIndex: 5984
		{
			// Constructors
			public SettingsGroup() {} // 0x0000000180289A80-0x0000000180289A90
		}
	
		[AttributeUsage(AttributeTargets.All)] // 0x00000001800DFE30-0x00000001800DFE50
		public class TopLevelSettings : Attribute // TypeDefIndex: 5985
		{
			// Constructors
			public TopLevelSettings() {} // 0x0000000180289A80-0x0000000180289A90
		}
	
		[AttributeUsage(AttributeTargets.All)] // 0x00000001800DFE30-0x00000001800DFE50
		public class ExperimentalGroup : Attribute // TypeDefIndex: 5986
		{
			// Constructors
			public ExperimentalGroup() {} // 0x0000000180289A80-0x0000000180289A90
		}
	
		public enum DebugPass // TypeDefIndex: 5987
		{
			Off = 0,
			Edges = 1,
			Weights = 2,
			Accumulation = 3
		}
	
		public enum QualityPreset // TypeDefIndex: 5988
		{
			Low = 0,
			Medium = 1,
			High = 2,
			Ultra = 3,
			Custom = 4
		}
	
		public enum EdgeDetectionMethod // TypeDefIndex: 5989
		{
			Luma = 1,
			Color = 2,
			Depth = 3
		}
	
		[Serializable]
		public struct GlobalSettings // TypeDefIndex: 5990
		{
			// Fields
			// [Tooltip] // 0x0000000180107760-0x0000000180107790
			public DebugPass debugPass; // 0x00
			// [Tooltip] // 0x0000000180107790-0x00000001801077C0
			public QualityPreset quality; // 0x04
			// [Tooltip] // 0x00000001801079B0-0x00000001801079E0
			public EdgeDetectionMethod edgeDetectionMethod; // 0x08
	
			// Properties
			public static GlobalSettings defaultSettings { get => default; } // 0x0000000180622740-0x0000000180622770 
		}
	
		[Serializable]
		public struct QualitySettings // TypeDefIndex: 5991
		{
			// Fields
			// [Tooltip] // 0x0000000180107A30-0x0000000180107A60
			public bool diagonalDetection; // 0x00
			// [Tooltip] // 0x0000000180107A90-0x0000000180107AC0
			public bool cornerDetection; // 0x01
			// [Range] // 0x0000000180107AF0-0x0000000180107B40
			// [Tooltip] // 0x0000000180107AF0-0x0000000180107B40
			public float threshold; // 0x04
			// [Min] // 0x0000000180107C10-0x0000000180107C60
			// [Tooltip] // 0x0000000180107C10-0x0000000180107C60
			public float depthThreshold; // 0x08
			// [Range] // 0x0000000180107D70-0x0000000180107DC0
			// [Tooltip] // 0x0000000180107D70-0x0000000180107DC0
			public int maxSearchSteps; // 0x0C
			// [Range] // 0x0000000180107E70-0x0000000180107EC0
			// [Tooltip] // 0x0000000180107E70-0x0000000180107EC0
			public int maxDiagonalSearchSteps; // 0x10
			// [Range] // 0x0000000180108010-0x0000000180108060
			// [Tooltip] // 0x0000000180108010-0x0000000180108060
			public int cornerRounding; // 0x14
			// [Min] // 0x0000000180108260-0x00000001801082B0
			// [Tooltip] // 0x0000000180108260-0x00000001801082B0
			public float localContrastAdaptationFactor; // 0x18
			public static QualitySettings[] presetQualitySettings; // 0x00
	
			// Constructors
			static QualitySettings() {
				presetQualitySettings = default;
			} // 0x0000000180624060-0x0000000180624260
		}
	
		[Serializable]
		public struct TemporalSettings // TypeDefIndex: 5992
		{
			// Fields
			// [Tooltip] // 0x0000000180108450-0x0000000180108480
			public bool enabled; // 0x00
			// [Range] // 0x00000001801084E0-0x0000000180108530
			// [Tooltip] // 0x00000001801084E0-0x0000000180108530
			public float fuzzSize; // 0x04
	
			// Properties
			public static TemporalSettings defaultSettings { get => default; } // 0x0000000180628490-0x00000001806284B0 
	
			// Methods
			public bool UseTemporal() => default; // 0x0000000180013590-0x00000001800135A0
		}
	
		[Serializable]
		public struct PredicationSettings // TypeDefIndex: 5993
		{
			// Fields
			// [Tooltip] // 0x0000000180108750-0x0000000180108780
			public bool enabled; // 0x00
			// [Min] // 0x0000000180108780-0x00000001801087D0
			// [Tooltip] // 0x0000000180108780-0x00000001801087D0
			public float threshold; // 0x04
			// [Range] // 0x00000001801089D0-0x0000000180108A20
			// [Tooltip] // 0x00000001801089D0-0x0000000180108A20
			public float scale; // 0x08
			// [Range] // 0x0000000180108A70-0x0000000180108AC0
			// [Tooltip] // 0x0000000180108A70-0x0000000180108AC0
			public float strength; // 0x0C
	
			// Properties
			public static PredicationSettings defaultSettings { get => default; } // 0x0000000180624000-0x0000000180624060 
		}
	
		// Constructors
		public SMAA() {} // 0x0000000180625760-0x00000001806258A0
	
		// Methods
		public void OnEnable(AntiAliasing owner) {} // 0x00000001806246F0-0x0000000180624740
		public void OnDisable() {} // 0x00000001806245B0-0x00000001806246F0
		public void OnPreCull(Camera camera) {} // 0x0000000180624770-0x00000001806249E0
		public void OnPostRender(Camera camera) {} // 0x0000000180624740-0x0000000180624770
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination) {} // 0x00000001806249E0-0x0000000180625730
		private RenderTexture TempRT(int width, int height, RenderTextureFormat format) => default; // 0x0000000180625730-0x0000000180625760
	}
}
