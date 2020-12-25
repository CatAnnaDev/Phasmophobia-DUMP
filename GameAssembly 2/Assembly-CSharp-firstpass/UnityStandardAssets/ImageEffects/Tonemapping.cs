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
	// [AddComponentMenu] // 0x00000001801028B0-0x0000000180102940
	[ExecuteInEditMode] // 0x00000001801028B0-0x0000000180102940
	// [RequireComponent] // 0x00000001801028B0-0x0000000180102940
	public class Tonemapping : PostEffectsBase // TypeDefIndex: 5962
	{
		// Fields
		public TonemapperType type; // 0x20
		public AdaptiveTexSize adaptiveTextureSize; // 0x24
		public AnimationCurve remapCurve; // 0x28
		private Texture2D curveTex; // 0x30
		public float exposureAdjustment; // 0x38
		public float middleGrey; // 0x3C
		public float white; // 0x40
		public float adaptionSpeed; // 0x44
		public Shader tonemapper; // 0x48
		public bool validRenderTextureFormat; // 0x50
		private Material tonemapMaterial; // 0x58
		private RenderTexture rt; // 0x60
		private RenderTextureFormat rtFormat; // 0x68
	
		// Nested types
		public enum TonemapperType // TypeDefIndex: 5963
		{
			SimpleReinhard = 0,
			UserCurve = 1,
			Hable = 2,
			Photographic = 3,
			OptimizedHejiDawson = 4,
			AdaptiveReinhard = 5,
			AdaptiveReinhardAutoWhite = 6
		}
	
		public enum AdaptiveTexSize // TypeDefIndex: 5964
		{
			Square16 = 16,
			Square32 = 32,
			Square64 = 64,
			Square128 = 128,
			Square256 = 256,
			Square512 = 512,
			Square1024 = 1024
		}
	
		// Constructors
		public Tonemapping() {} // 0x0000000180A49090-0x0000000180A490E0
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A47F60-0x0000000180A480D0
		public float UpdateCurve() => default; // 0x0000000180A48D30-0x0000000180A49090
		private void OnDisable() {} // 0x0000000180A481E0-0x0000000180A48370
		private bool CreateInternalRenderTexture() => default; // 0x0000000180A480D0-0x0000000180A481E0
		[ImageEffectTransformsToLDR] // 0x00000001800D4E50-0x00000001800D4E60
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A48370-0x0000000180A48D30
	}
}
