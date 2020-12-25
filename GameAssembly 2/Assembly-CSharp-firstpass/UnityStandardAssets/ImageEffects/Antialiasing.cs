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
	// [AddComponentMenu] // 0x00000001800FB4C0-0x00000001800FB550
	[ExecuteInEditMode] // 0x00000001800FB4C0-0x00000001800FB550
	// [RequireComponent] // 0x00000001800FB4C0-0x00000001800FB550
	public class Antialiasing : PostEffectsBase // TypeDefIndex: 5902
	{
		// Fields
		public AAMode mode; // 0x20
		public bool showGeneratedNormals; // 0x24
		public float offsetScale; // 0x28
		public float blurRadius; // 0x2C
		public float edgeThresholdMin; // 0x30
		public float edgeThreshold; // 0x34
		public float edgeSharpness; // 0x38
		public bool dlaaSharp; // 0x3C
		public Shader ssaaShader; // 0x40
		private Material ssaa; // 0x48
		public Shader dlaaShader; // 0x50
		private Material dlaa; // 0x58
		public Shader nfaaShader; // 0x60
		private Material nfaa; // 0x68
		public Shader shaderFXAAPreset2; // 0x70
		private Material materialFXAAPreset2; // 0x78
		public Shader shaderFXAAPreset3; // 0x80
		private Material materialFXAAPreset3; // 0x88
		public Shader shaderFXAAII; // 0x90
		private Material materialFXAAII; // 0x98
		public Shader shaderFXAAIII; // 0xA0
		private Material materialFXAAIII; // 0xA8
	
		// Constructors
		public Antialiasing() {} // 0x0000000180615E90-0x0000000180615ED0
	
		// Methods
		public Material CurrentAAMaterial() => default; // 0x0000000180615930-0x00000001806159A0
		public override bool CheckResources() => default; // 0x00000001806157C0-0x0000000180615930
		public void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00000001806159A0-0x0000000180615E90
	}
}
