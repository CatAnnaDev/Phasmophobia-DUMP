/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace UnityStandardAssets.ImageEffects
{
	// [AddComponentMenu] // 0x00000001801015C0-0x0000000180101650
	[ExecuteInEditMode] // 0x00000001801015C0-0x0000000180101650
	// [RequireComponent] // 0x00000001801015C0-0x0000000180101650
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour // TypeDefIndex: 5953
	{
		// Fields
		// [Range] // 0x0000000180101860-0x0000000180101880
		public float m_Radius; // 0x18
		public SSAOSamples m_SampleCount; // 0x1C
		// [Range] // 0x0000000180101930-0x0000000180101950
		public float m_OcclusionIntensity; // 0x20
		// [Range] // 0x00000001800EDF90-0x00000001800EDFB0
		public int m_Blur; // 0x24
		// [Range] // 0x0000000180101B70-0x0000000180101B90
		public int m_Downsampling; // 0x28
		// [Range] // 0x0000000180101D40-0x0000000180101D60
		public float m_OcclusionAttenuation; // 0x2C
		// [Range] // 0x0000000180101D90-0x0000000180101DB0
		public float m_MinZ; // 0x30
		public Shader m_SSAOShader; // 0x38
		private Material m_SSAOMaterial; // 0x40
		public Texture2D m_RandomTexture; // 0x48
		private bool m_Supported; // 0x50
	
		// Nested types
		public enum SSAOSamples // TypeDefIndex: 5954
		{
			Low = 0,
			Medium = 1,
			High = 2
		}
	
		// Constructors
		public ScreenSpaceAmbientOcclusion() {} // 0x0000000180A462A0-0x0000000180A462E0
	
		// Methods
		private static Material CreateMaterial(Shader shader) => default; // 0x0000000180A45670-0x0000000180A45720
		private static void DestroyMaterial(Material mat) {} // 0x0000000180A45870-0x0000000180A45900
		private void OnDisable() {} // 0x0000000180A45900-0x0000000180A45990
		private void Start() {} // 0x0000000180A461E0-0x0000000180A462A0
		private void OnEnable() {} // 0x0000000180A45990-0x0000000180A459F0
		private void CreateMaterials() {} // 0x0000000180A45720-0x0000000180A45870
		[ImageEffectOpaque] // 0x00000001800D4E50-0x00000001800D4E60
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A459F0-0x0000000180A461E0
	}
}
