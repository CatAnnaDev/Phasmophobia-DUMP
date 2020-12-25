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
	// [AddComponentMenu] // 0x00000001800FC800-0x00000001800FC840
	[ExecuteInEditMode] // 0x00000001800FC800-0x00000001800FC840
	public class ColorCorrectionCurves : PostEffectsBase // TypeDefIndex: 5922
	{
		// Fields
		public AnimationCurve redChannel; // 0x20
		public AnimationCurve greenChannel; // 0x28
		public AnimationCurve blueChannel; // 0x30
		public bool useDepthCorrection; // 0x38
		public AnimationCurve zCurve; // 0x40
		public AnimationCurve depthRedChannel; // 0x48
		public AnimationCurve depthGreenChannel; // 0x50
		public AnimationCurve depthBlueChannel; // 0x58
		private Material ccMaterial; // 0x60
		private Material ccDepthMaterial; // 0x68
		private Material selectiveCcMaterial; // 0x70
		private Texture2D rgbChannelTex; // 0x78
		private Texture2D rgbDepthChannelTex; // 0x80
		private Texture2D zCurveTex; // 0x88
		public float saturation; // 0x90
		public bool selectiveCc; // 0x94
		public Color selectiveFromColor; // 0x98
		public Color selectiveToColor; // 0xA8
		public ColorCorrectionMode mode; // 0xB8
		public bool updateTextures; // 0xBC
		public Shader colorCorrectionCurvesShader; // 0xC0
		public Shader simpleColorCorrectionCurvesShader; // 0xC8
		public Shader colorCorrectionSelectiveShader; // 0xD0
		private bool updateTexturesOnStartup; // 0xD8
	
		// Nested types
		public enum ColorCorrectionMode // TypeDefIndex: 5923
		{
			Simple = 0,
			Advanced = 1
		}
	
		// Constructors
		public ColorCorrectionCurves() {} // 0x000000018061E3E0-0x000000018061EBC0
	
		// Methods
		private new void Start() {} // 0x000000018061DE60-0x000000018061DE80
		private void Awake() {} // 0x0000000180246DB0-0x0000000180246DC0
		public override bool CheckResources() => default; // 0x000000018061D840-0x000000018061DB50
		public void UpdateParameters() {} // 0x000000018061DE80-0x000000018061E3D0
		private void UpdateTextures() {} // 0x000000018061E3D0-0x000000018061E3E0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x000000018061DB50-0x000000018061DE60
	}
}
