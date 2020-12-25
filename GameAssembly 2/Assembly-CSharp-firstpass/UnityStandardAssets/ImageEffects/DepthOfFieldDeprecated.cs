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
	// [AddComponentMenu] // 0x00000001800FD630-0x00000001800FD6C0
	[ExecuteInEditMode] // 0x00000001800FD630-0x00000001800FD6C0
	// [RequireComponent] // 0x00000001800FD630-0x00000001800FD6C0
	public class DepthOfFieldDeprecated : PostEffectsBase // TypeDefIndex: 5932
	{
		// Fields
		private static int SMOOTH_DOWNSAMPLE_PASS; // 0x00
		private static float BOKEH_EXTRA_BLUR; // 0x04
		public Dof34QualitySetting quality; // 0x20
		public DofResolution resolution; // 0x24
		public bool simpleTweakMode; // 0x28
		public float focalPoint; // 0x2C
		public float smoothness; // 0x30
		public float focalZDistance; // 0x34
		public float focalZStartCurve; // 0x38
		public float focalZEndCurve; // 0x3C
		private float focalStartCurve; // 0x40
		private float focalEndCurve; // 0x44
		private float focalDistance01; // 0x48
		public Transform objectFocus; // 0x50
		public float focalSize; // 0x58
		public DofBlurriness bluriness; // 0x5C
		public float maxBlurSpread; // 0x60
		public float foregroundBlurExtrude; // 0x64
		public Shader dofBlurShader; // 0x68
		private Material dofBlurMaterial; // 0x70
		public Shader dofShader; // 0x78
		private Material dofMaterial; // 0x80
		public bool visualize; // 0x88
		public BokehDestination bokehDestination; // 0x8C
		private float widthOverHeight; // 0x90
		private float oneOverBaseSize; // 0x94
		public bool bokeh; // 0x98
		public bool bokehSupport; // 0x99
		public Shader bokehShader; // 0xA0
		public Texture2D bokehTexture; // 0xA8
		public float bokehScale; // 0xB0
		public float bokehIntensity; // 0xB4
		public float bokehThresholdContrast; // 0xB8
		public float bokehThresholdLuminance; // 0xBC
		public int bokehDownsample; // 0xC0
		private Material bokehMaterial; // 0xC8
		private Camera _camera; // 0xD0
		private RenderTexture foregroundTexture; // 0xD8
		private RenderTexture mediumRezWorkTexture; // 0xE0
		private RenderTexture finalDefocus; // 0xE8
		private RenderTexture lowRezWorkTexture; // 0xF0
		private RenderTexture bokehSource; // 0xF8
		private RenderTexture bokehSource2; // 0x100
	
		// Nested types
		public enum Dof34QualitySetting // TypeDefIndex: 5933
		{
			OnlyBackground = 1,
			BackgroundAndForeground = 2
		}
	
		public enum DofResolution // TypeDefIndex: 5934
		{
			High = 2,
			Medium = 3,
			Low = 4
		}
	
		public enum DofBlurriness // TypeDefIndex: 5935
		{
			Low = 1,
			High = 2,
			VeryHigh = 4
		}
	
		public enum BokehDestination // TypeDefIndex: 5936
		{
			Background = 1,
			Foreground = 2,
			BackgroundAndForeground = 3
		}
	
		// Constructors
		public DepthOfFieldDeprecated() {} // 0x0000000180A3A9D0-0x0000000180A3AA90
		static DepthOfFieldDeprecated() {} // 0x0000000180A3A980-0x0000000180A3A9D0
	
		// Methods
		private void CreateMaterials() {} // 0x0000000180A39620-0x0000000180A39740
		public override bool CheckResources() => default; // 0x0000000180A394E0-0x0000000180A39620
		private void OnDisable() {} // 0x0000000180A39AF0-0x0000000180A39B40
		private new void OnEnable() {} // 0x0000000180A39B40-0x0000000180A39BC0
		private float FocalDistance01(float worldDist) => default; // 0x0000000180A398C0-0x0000000180A39AB0
		private int GetDividerBasedOnQuality() => default; // 0x0000000180A39AB0-0x0000000180A39AD0
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider) => default; // 0x0000000180A39AD0-0x0000000180A39AF0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A39BC0-0x0000000180A3A7C0
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread) {} // 0x0000000180A391B0-0x0000000180A394E0
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread) {} // 0x0000000180A38BB0-0x0000000180A38F00
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp) {} // 0x0000000180A38F00-0x0000000180A391B0
		private void Downsample(RenderTexture from, RenderTexture to) {} // 0x0000000180A39740-0x0000000180A398C0
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget) {} // 0x0000000180A38290-0x0000000180A38760
		private void ReleaseTextures() {} // 0x0000000180A3A7C0-0x0000000180A3A980
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider) {} // 0x0000000180A38760-0x0000000180A38BB0
	}
}
