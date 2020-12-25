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
	// [AddComponentMenu] // 0x00000001800FBCD0-0x00000001800FBD60
	[ExecuteInEditMode] // 0x00000001800FBCD0-0x00000001800FBD60
	// [RequireComponent] // 0x00000001800FBCD0-0x00000001800FBD60
	public class BloomOptimized : PostEffectsBase // TypeDefIndex: 5914
	{
		// Fields
		// [Range] // 0x00000001800FBE50-0x00000001800FBE70
		public float threshold; // 0x20
		// [Range] // 0x00000001800FBF20-0x00000001800FBF40
		public float intensity; // 0x24
		// [Range] // 0x00000001800FBFB0-0x00000001800FBFD0
		public float blurSize; // 0x28
		private Resolution resolution; // 0x2C
		// [Range] // 0x00000001800FC040-0x00000001800FC060
		public int blurIterations; // 0x30
		public BlurType blurType; // 0x34
		public Shader fastBloomShader; // 0x38
		private Material fastBloomMaterial; // 0x40
	
		// Nested types
		public enum Resolution // TypeDefIndex: 5915
		{
			Low = 0,
			High = 1
		}
	
		public enum BlurType // TypeDefIndex: 5916
		{
			Standard = 0,
			Sgx = 1
		}
	
		// Constructors
		public BloomOptimized() {} // 0x0000000180618100-0x0000000180618130
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180617BC0-0x0000000180617C20
		private void OnDisable() {} // 0x0000000180617C20-0x0000000180617CB0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180617CB0-0x0000000180618100
	}
}
