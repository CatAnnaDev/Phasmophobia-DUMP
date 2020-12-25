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
	// [AddComponentMenu] // 0x00000001800FB7F0-0x00000001800FB880
	[ExecuteInEditMode] // 0x00000001800FB7F0-0x00000001800FB880
	// [RequireComponent] // 0x00000001800FB7F0-0x00000001800FB880
	public class Bloom : PostEffectsBase // TypeDefIndex: 5903
	{
		// Fields
		public TweakMode tweakMode; // 0x20
		public BloomScreenBlendMode screenBlendMode; // 0x24
		public HDRBloomMode hdr; // 0x28
		private bool doHdr; // 0x2C
		public float sepBlurSpread; // 0x30
		public BloomQuality quality; // 0x34
		public float bloomIntensity; // 0x38
		public float bloomThreshold; // 0x3C
		public Color bloomThresholdColor; // 0x40
		public int bloomBlurIterations; // 0x50
		public int hollywoodFlareBlurIterations; // 0x54
		public float flareRotation; // 0x58
		public LensFlareStyle lensflareMode; // 0x5C
		public float hollyStretchWidth; // 0x60
		public float lensflareIntensity; // 0x64
		public float lensflareThreshold; // 0x68
		public float lensFlareSaturation; // 0x6C
		public Color flareColorA; // 0x70
		public Color flareColorB; // 0x80
		public Color flareColorC; // 0x90
		public Color flareColorD; // 0xA0
		public Texture2D lensFlareVignetteMask; // 0xB0
		public Shader lensFlareShader; // 0xB8
		private Material lensFlareMaterial; // 0xC0
		public Shader screenBlendShader; // 0xC8
		private Material screenBlend; // 0xD0
		public Shader blurAndFlaresShader; // 0xD8
		private Material blurAndFlaresMaterial; // 0xE0
		public Shader brightPassFilterShader; // 0xE8
		private Material brightPassFilterMaterial; // 0xF0
	
		// Nested types
		public enum LensFlareStyle // TypeDefIndex: 5904
		{
			Ghosting = 0,
			Anamorphic = 1,
			Combined = 2
		}
	
		public enum TweakMode // TypeDefIndex: 5905
		{
			Basic = 0,
			Complex = 1
		}
	
		public enum HDRBloomMode // TypeDefIndex: 5906
		{
			Auto = 0,
			On = 1,
			Off = 2
		}
	
		public enum BloomScreenBlendMode // TypeDefIndex: 5907
		{
			Screen = 0,
			Add = 1
		}
	
		public enum BloomQuality // TypeDefIndex: 5908
		{
			Cheap = 0,
			High = 1
		}
	
		// Constructors
		public Bloom() {} // 0x0000000180619BF0-0x0000000180619D90
	
		// Methods
		public override bool CheckResources() => default; // 0x00000001806186E0-0x00000001806187E0
		public void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00000001806187E0-0x00000001806199E0
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to) {} // 0x0000000180618130-0x0000000180618200
		private void BlendFlares(RenderTexture from, RenderTexture to) {} // 0x0000000180618200-0x00000001806184F0
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to) {} // 0x00000001806184F0-0x00000001806185F0
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to) {} // 0x00000001806185F0-0x00000001806186E0
		private void Vignette(float amount, RenderTexture from, RenderTexture to) {} // 0x00000001806199E0-0x0000000180619BF0
	}
}
