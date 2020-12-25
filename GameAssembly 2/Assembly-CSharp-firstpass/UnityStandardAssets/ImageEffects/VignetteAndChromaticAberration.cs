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
	// [AddComponentMenu] // 0x0000000180102E60-0x0000000180102EF0
	[ExecuteInEditMode] // 0x0000000180102E60-0x0000000180102EF0
	// [RequireComponent] // 0x0000000180102E60-0x0000000180102EF0
	public class VignetteAndChromaticAberration : PostEffectsBase // TypeDefIndex: 5967
	{
		// Fields
		public AberrationMode mode; // 0x20
		public float intensity; // 0x24
		public float chromaticAberration; // 0x28
		public float axialAberration; // 0x2C
		public float blur; // 0x30
		public float blurSpread; // 0x34
		public float luminanceDependency; // 0x38
		public float blurDistance; // 0x3C
		public Shader vignetteShader; // 0x40
		public Shader separableBlurShader; // 0x48
		public Shader chromAberrationShader; // 0x50
		private Material m_VignetteMaterial; // 0x58
		private Material m_SeparableBlurMaterial; // 0x60
		private Material m_ChromAberrationMaterial; // 0x68
	
		// Nested types
		public enum AberrationMode // TypeDefIndex: 5968
		{
			Simple = 0,
			Advanced = 1
		}
	
		// Constructors
		public VignetteAndChromaticAberration() {} // 0x0000000180A4BA20-0x0000000180A4BA60
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A4B200-0x0000000180A4B310
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A4B310-0x0000000180A4BA20
	}
}
