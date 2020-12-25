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
	// [AddComponentMenu] // 0x00000001800FCAC0-0x00000001800FCB50
	[ExecuteInEditMode] // 0x00000001800FCAC0-0x00000001800FCB50
	// [RequireComponent] // 0x00000001800FCAC0-0x00000001800FCB50
	public class ContrastEnhance : PostEffectsBase // TypeDefIndex: 5926
	{
		// Fields
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float intensity; // 0x20
		// [Range] // 0x00000001800FCD00-0x00000001800FCD20
		public float threshold; // 0x24
		private Material separableBlurMaterial; // 0x28
		private Material contrastCompositeMaterial; // 0x30
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float blurSpread; // 0x38
		public Shader separableBlurShader; // 0x40
		public Shader contrastCompositeShader; // 0x48
	
		// Constructors
		public ContrastEnhance() {} // 0x0000000180620010-0x0000000180620030
	
		// Methods
		public override bool CheckResources() => default; // 0x000000018061FBE0-0x000000018061FC60
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x000000018061FC60-0x0000000180620010
	}
}
