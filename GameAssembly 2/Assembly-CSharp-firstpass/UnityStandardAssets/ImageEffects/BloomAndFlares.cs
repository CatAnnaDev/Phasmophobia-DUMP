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
	// [AddComponentMenu] // 0x00000001800FBAB0-0x00000001800FBB40
	[ExecuteInEditMode] // 0x00000001800FBAB0-0x00000001800FBB40
	// [RequireComponent] // 0x00000001800FBAB0-0x00000001800FBB40
	public class BloomAndFlares : PostEffectsBase // TypeDefIndex: 5913
	{
		// Fields
		public TweakMode34 tweakMode; // 0x20
		public BloomScreenBlendMode screenBlendMode; // 0x24
		public HDRBloomMode hdr; // 0x28
		private bool doHdr; // 0x2C
		public float sepBlurSpread; // 0x30
		public float useSrcAlphaAsMask; // 0x34
		public float bloomIntensity; // 0x38
		public float bloomThreshold; // 0x3C
		public int bloomBlurIterations; // 0x40
		public bool lensflares; // 0x44
		public int hollywoodFlareBlurIterations; // 0x48
		public LensflareStyle34 lensflareMode; // 0x4C
		public float hollyStretchWidth; // 0x50
		public float lensflareIntensity; // 0x54
		public float lensflareThreshold; // 0x58
		public Color flareColorA; // 0x5C
		public Color flareColorB; // 0x6C
		public Color flareColorC; // 0x7C
		public Color flareColorD; // 0x8C
		public Texture2D lensFlareVignetteMask; // 0xA0
		public Shader lensFlareShader; // 0xA8
		private Material lensFlareMaterial; // 0xB0
		public Shader vignetteShader; // 0xB8
		private Material vignetteMaterial; // 0xC0
		public Shader separableBlurShader; // 0xC8
		private Material separableBlurMaterial; // 0xD0
		public Shader addBrightStuffOneOneShader; // 0xD8
		private Material addBrightStuffBlendOneOneMaterial; // 0xE0
		public Shader screenBlendShader; // 0xE8
		private Material screenBlend; // 0xF0
		public Shader hollywoodFlaresShader; // 0xF8
		private Material hollywoodFlaresMaterial; // 0x100
		public Shader brightPassFilterShader; // 0x108
		private Material brightPassFilterMaterial; // 0x110
	
		// Constructors
		public BloomAndFlares() {} // 0x0000000180617A30-0x0000000180617BC0
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180616A40-0x0000000180616BD0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180616BD0-0x00000001806178D0
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to) {} // 0x0000000180616570-0x0000000180616620
		private void BlendFlares(RenderTexture from, RenderTexture to) {} // 0x0000000180616620-0x00000001806168F0
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to) {} // 0x00000001806168F0-0x0000000180616A40
		private void Vignette(float amount, RenderTexture from, RenderTexture to) {} // 0x00000001806178D0-0x0000000180617A30
	}
}
