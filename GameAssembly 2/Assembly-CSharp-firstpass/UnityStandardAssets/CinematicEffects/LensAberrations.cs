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
	// [AddComponentMenu] // 0x000000018010C1A0-0x000000018010C230
	[ExecuteInEditMode] // 0x000000018010C1A0-0x000000018010C230
	// [RequireComponent] // 0x000000018010C1A0-0x000000018010C230
	public class LensAberrations : MonoBehaviour // TypeDefIndex: 6011
	{
		// Fields
		[SettingsGroup] // 0x00000001800D4E50-0x00000001800D4E60
		public DistortionSettings distortion; // 0x18
		[SettingsGroup] // 0x00000001800D4E50-0x00000001800D4E60
		public VignetteSettings vignette; // 0x34
		[SettingsGroup] // 0x00000001800D4E50-0x00000001800D4E60
		public ChromaticAberrationSettings chromaticAberration; // 0x64
		[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
		private Shader m_Shader; // 0x80
		private Material m_Material; // 0x88
		private RenderTextureUtility m_RTU; // 0x90
	
		// Properties
		public Shader shader { get => default; } // 0x00000001808335F0-0x0000000180833690 
		public Material material { get => default; } // 0x0000000180833540-0x00000001808335F0 
	
		// Nested types
		[AttributeUsage(AttributeTargets.All)] // 0x00000001800DFE30-0x00000001800DFE50
		public class SettingsGroup : Attribute // TypeDefIndex: 6012
		{
			// Constructors
			public SettingsGroup() {} // 0x0000000180289A80-0x0000000180289A90
		}
	
		[AttributeUsage(AttributeTargets.All)] // 0x00000001800DFE30-0x00000001800DFE50
		public class AdvancedSetting : Attribute // TypeDefIndex: 6013
		{
			// Constructors
			public AdvancedSetting() {} // 0x0000000180289A80-0x0000000180289A90
		}
	
		[Serializable]
		public struct DistortionSettings // TypeDefIndex: 6014
		{
			// Fields
			public bool enabled; // 0x00
			// [Range] // 0x000000018010C500-0x000000018010C550
			// [Tooltip] // 0x000000018010C500-0x000000018010C550
			public float amount; // 0x04
			// [Range] // 0x000000018010C5D0-0x000000018010C620
			// [Tooltip] // 0x000000018010C5D0-0x000000018010C620
			public float centerX; // 0x08
			// [Range] // 0x000000018010C6C0-0x000000018010C710
			// [Tooltip] // 0x000000018010C6C0-0x000000018010C710
			public float centerY; // 0x0C
			// [Range] // 0x000000018010C770-0x000000018010C7C0
			// [Tooltip] // 0x000000018010C770-0x000000018010C7C0
			public float amountX; // 0x10
			// [Range] // 0x000000018010C870-0x000000018010C8C0
			// [Tooltip] // 0x000000018010C870-0x000000018010C8C0
			public float amountY; // 0x14
			// [Range] // 0x000000018010DBF0-0x000000018010DC40
			// [Tooltip] // 0x000000018010DBF0-0x000000018010DC40
			public float scale; // 0x18
	
			// Properties
			public static DistortionSettings defaultSettings { get => default; } // 0x00000001806220D0-0x0000000180622120 
		}
	
		[Serializable]
		public struct VignetteSettings // TypeDefIndex: 6015
		{
			// Fields
			public bool enabled; // 0x00
			// [ColorUsage] // 0x000000018010DC90-0x000000018010DCE0
			// [Tooltip] // 0x000000018010DC90-0x000000018010DCE0
			public Color color; // 0x04
			// [Tooltip] // 0x000000018010DD10-0x000000018010DD40
			public Vector2 center; // 0x14
			// [Range] // 0x000000018010DDF0-0x000000018010DE40
			// [Tooltip] // 0x000000018010DDF0-0x000000018010DE40
			public float intensity; // 0x1C
			// [Range] // 0x000000018010DE90-0x000000018010DEE0
			// [Tooltip] // 0x000000018010DE90-0x000000018010DEE0
			public float smoothness; // 0x20
			[AdvancedSetting] // 0x000000018010DFD0-0x000000018010E030
			// [Range] // 0x000000018010DFD0-0x000000018010E030
			// [Tooltip] // 0x000000018010DFD0-0x000000018010E030
			public float roundness; // 0x24
			// [Range] // 0x000000018010E080-0x000000018010E0D0
			// [Tooltip] // 0x000000018010E080-0x000000018010E0D0
			public float blur; // 0x28
			// [Range] // 0x000000018010E0D0-0x000000018010E120
			// [Tooltip] // 0x000000018010E0D0-0x000000018010E120
			public float desaturate; // 0x2C
	
			// Properties
			public static VignetteSettings defaultSettings { get => default; } // 0x000000018062DEE0-0x000000018062DFB0 
		}
	
		[Serializable]
		public struct ChromaticAberrationSettings // TypeDefIndex: 6016
		{
			// Fields
			public bool enabled; // 0x00
			// [ColorUsage] // 0x000000018010E230-0x000000018010E280
			// [Tooltip] // 0x000000018010E230-0x000000018010E280
			public Color color; // 0x04
			// [Range] // 0x000000018010E3B0-0x000000018010E400
			// [Tooltip] // 0x000000018010E3B0-0x000000018010E400
			public float amount; // 0x14
	
			// Properties
			public static ChromaticAberrationSettings defaultSettings { get => default; } // 0x000000018061D7E0-0x000000018061D840 
		}
	
		private enum Pass // TypeDefIndex: 6017
		{
			BlurPrePass = 0,
			Chroma = 1,
			Distort = 2,
			Vignette = 3,
			ChromaDistort = 4,
			ChromaVignette = 5,
			DistortVignette = 6,
			ChromaDistortVignette = 7
		}
	
		// Constructors
		public LensAberrations() {} // 0x00000001808334C0-0x0000000180833540
	
		// Methods
		private void OnEnable() {} // 0x00000001808327A0-0x0000000180832840
		private void OnDisable() {} // 0x00000001808326C0-0x00000001808327A0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180832840-0x00000001808334C0
	}
}
