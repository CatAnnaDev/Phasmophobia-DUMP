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
	// [AddComponentMenu] // 0x00000001800FD340-0x00000001800FD3D0
	[ExecuteInEditMode] // 0x00000001800FD340-0x00000001800FD3D0
	// [RequireComponent] // 0x00000001800FD340-0x00000001800FD3D0
	public class DepthOfField : PostEffectsBase // TypeDefIndex: 5929
	{
		// Fields
		public bool visualizeFocus; // 0x20
		public float focalLength; // 0x24
		public float focalSize; // 0x28
		public float aperture; // 0x2C
		public Transform focalTransform; // 0x30
		public float maxBlurSize; // 0x38
		public bool highResolution; // 0x3C
		public BlurType blurType; // 0x40
		public BlurSampleCount blurSampleCount; // 0x44
		public bool nearBlur; // 0x48
		public float foregroundOverlap; // 0x4C
		public Shader dofHdrShader; // 0x50
		private Material dofHdrMaterial; // 0x58
		public Shader dx11BokehShader; // 0x60
		private Material dx11bokehMaterial; // 0x68
		public float dx11BokehThreshold; // 0x70
		public float dx11SpawnHeuristic; // 0x74
		public Texture2D dx11BokehTexture; // 0x78
		public float dx11BokehScale; // 0x80
		public float dx11BokehIntensity; // 0x84
		private float focalDistance01; // 0x88
		private ComputeBuffer cbDrawArgs; // 0x90
		private ComputeBuffer cbPoints; // 0x98
		private float internalBlurWidth; // 0xA0
		private Camera cachedCamera; // 0xA8
	
		// Nested types
		public enum BlurType // TypeDefIndex: 5930
		{
			DiscBlur = 0,
			DX11 = 1
		}
	
		public enum BlurSampleCount // TypeDefIndex: 5931
		{
			Low = 0,
			Medium = 1,
			High = 2
		}
	
		// Constructors
		public DepthOfField() {} // 0x0000000180A3D1C0-0x0000000180A3D230
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A3AA90-0x0000000180A3ACA0
		private new void OnEnable() {} // 0x0000000180A3B190-0x0000000180A3B210
		private void OnDisable() {} // 0x0000000180A3B020-0x0000000180A3B190
		private void ReleaseComputeResources() {} // 0x0000000180A3CE00-0x0000000180A3CE70
		private void CreateComputeResources() {} // 0x0000000180A3ACA0-0x0000000180A3AE30
		private float FocalDistance01(float worldDist) => default; // 0x0000000180A3AE30-0x0000000180A3B020
		private void WriteCoc(RenderTexture fromTo, bool fgDilate) {} // 0x0000000180A3CE70-0x0000000180A3D1C0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A3B210-0x0000000180A3CE00
	}
}
