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
	// [AddComponentMenu] // 0x0000000180100FE0-0x0000000180101070
	[ExecuteInEditMode] // 0x0000000180100FE0-0x0000000180101070
	// [RequireComponent] // 0x0000000180100FE0-0x0000000180101070
	public class ScreenOverlay : PostEffectsBase // TypeDefIndex: 5950
	{
		// Fields
		public OverlayBlendMode blendMode; // 0x20
		public float intensity; // 0x24
		public Texture2D texture; // 0x28
		public Shader overlayShader; // 0x30
		private Material overlayMaterial; // 0x38
	
		// Nested types
		public enum OverlayBlendMode // TypeDefIndex: 5951
		{
			Additive = 0,
			ScreenBlend = 1,
			Multiply = 2,
			Overlay = 3,
			AlphaBlend = 4
		}
	
		// Constructors
		public ScreenOverlay() {} // 0x0000000180A44DF0-0x0000000180A44E10
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A44BA0-0x0000000180A44C60
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A44C60-0x0000000180A44DF0
	}
}
