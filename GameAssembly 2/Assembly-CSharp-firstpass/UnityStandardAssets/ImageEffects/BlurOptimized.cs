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
	// [AddComponentMenu] // 0x00000001800FC310-0x00000001800FC3A0
	[ExecuteInEditMode] // 0x00000001800FC310-0x00000001800FC3A0
	// [RequireComponent] // 0x00000001800FC310-0x00000001800FC3A0
	public class BlurOptimized : PostEffectsBase // TypeDefIndex: 5918
	{
		// Fields
		// [Range] // 0x00000001800DF770-0x00000001800DF790
		public int downsample; // 0x20
		// [Range] // 0x00000001800DF840-0x00000001800DF860
		public float blurSize; // 0x24
		// [Range] // 0x00000001800FC040-0x00000001800FC060
		public int blurIterations; // 0x28
		public BlurType blurType; // 0x2C
		public Shader blurShader; // 0x30
		private Material blurMaterial; // 0x38
	
		// Nested types
		public enum BlurType // TypeDefIndex: 5919
		{
			StandardGauss = 0,
			SgxGauss = 1
		}
	
		// Constructors
		public BlurOptimized() {} // 0x000000018061A2E0-0x000000018061A300
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180619D90-0x0000000180619DF0
		public void OnDisable() {} // 0x0000000180619DF0-0x0000000180619E80
		public void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180619E80-0x000000018061A2E0
	}
}
