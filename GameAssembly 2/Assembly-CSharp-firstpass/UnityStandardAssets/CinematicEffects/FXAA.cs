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
	public class FXAA : IAntiAliasing // TypeDefIndex: 5977
	{
		// Fields
		private Shader m_Shader; // 0x10
		private Material m_Material; // 0x18
		[HideInInspector] // 0x00000001800D5490-0x00000001800D54C0
		[SerializeField] // 0x00000001800D5490-0x00000001800D54C0
		public Preset preset; // 0x20
		public static Preset[] availablePresets; // 0x00
	
		// Properties
		private Shader shader { get => default; } // 0x00000001808301A0-0x0000000180830230 
		public Material material { get => default; } // 0x0000000180830100-0x00000001808301A0 
		public bool validSourceFormat { get; private set; } // 0x0000000180293290-0x00000001802932A0 0x0000000180474BD0-0x0000000180474BE0
	
		// Nested types
		[Serializable]
		public struct QualitySettings // TypeDefIndex: 5978
		{
			// Fields
			// [Range] // 0x0000000180106D00-0x0000000180106D60
			// [Tooltip] // 0x0000000180106D00-0x0000000180106D60
			public float subpixelAliasingRemovalAmount; // 0x00
			// [Range] // 0x0000000180106E10-0x0000000180106E70
			// [Tooltip] // 0x0000000180106E10-0x0000000180106E70
			public float edgeDetectionThreshold; // 0x04
			// [Range] // 0x0000000180106F20-0x0000000180106F80
			// [Tooltip] // 0x0000000180106F20-0x0000000180106F80
			public float minimumRequiredLuminance; // 0x08
		}
	
		[Serializable]
		public struct ConsoleSettings // TypeDefIndex: 5979
		{
			// Fields
			// [Range] // 0x00000001801070D0-0x0000000180107130
			// [Tooltip] // 0x00000001801070D0-0x0000000180107130
			public float subpixelSpreadAmount; // 0x00
			// [Range] // 0x00000001801071E0-0x0000000180107240
			// [Tooltip] // 0x00000001801071E0-0x0000000180107240
			public float edgeSharpnessAmount; // 0x04
			// [Range] // 0x0000000180107270-0x00000001801072D0
			// [Tooltip] // 0x0000000180107270-0x00000001801072D0
			public float edgeDetectionThreshold; // 0x08
			// [Range] // 0x00000001801072D0-0x0000000180107330
			// [Tooltip] // 0x00000001801072D0-0x0000000180107330
			public float minimumRequiredLuminance; // 0x0C
		}
	
		[Serializable]
		public struct Preset // TypeDefIndex: 5980
		{
			// Fields
			[Layout] // 0x0000000180107390-0x00000001801073A0
			public QualitySettings qualitySettings; // 0x00
			[Layout] // 0x0000000180107390-0x00000001801073A0
			public ConsoleSettings consoleSettings; // 0x0C
			private static readonly Preset s_ExtremePerformance; // 0x00
			private static readonly Preset s_Performance; // 0x1C
			private static readonly Preset s_Default; // 0x38
			private static readonly Preset s_Quality; // 0x54
			private static readonly Preset s_ExtremeQuality; // 0x70
	
			// Properties
			public static Preset extremePerformancePreset { get => default; } // 0x00000001808346B0-0x0000000180834730 
			public static Preset performancePreset { get => default; } // 0x00000001808347B0-0x0000000180834830 
			public static Preset defaultPreset { get => default; } // 0x0000000180834630-0x00000001808346B0 
			public static Preset qualityPreset { get => default; } // 0x0000000180834830-0x0000000180834940 
			public static Preset extremeQualityPreset { get => default; } // 0x0000000180834730-0x00000001808347B0 
	
			// Nested types
			[AttributeUsage(AttributeTargets.All)] // 0x00000001800DFE30-0x00000001800DFE50
			public class LayoutAttribute : PropertyAttribute // TypeDefIndex: 5981
			{
				// Constructors
				public LayoutAttribute() {} // 0x000000018061D7D0-0x000000018061D7E0
			}
	
			// Constructors
			static Preset() {
				s_ExtremePerformance = default;
				s_Performance = default;
				s_Default = default;
				s_Quality = default;
				s_ExtremeQuality = default;
			} // 0x00000001808343E0-0x0000000180834630
		}
	
		// Constructors
		public FXAA() {} // 0x0000000180830040-0x0000000180830100
		static FXAA() {} // 0x000000018082FD30-0x0000000180830040
	
		// Methods
		public void OnEnable(AntiAliasing owner) {} // 0x000000018082FB30-0x000000018082FB80
		public void OnDisable() {} // 0x000000018082FA90-0x000000018082FB30
		public void OnPreCull(Camera camera) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnPostRender(Camera camera) {} // 0x0000000180246DB0-0x0000000180246DC0
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination) {} // 0x000000018082FB80-0x000000018082FD30
	}
}
