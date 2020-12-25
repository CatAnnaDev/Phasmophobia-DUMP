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
	// [AddComponentMenu] // 0x00000001801001D0-0x0000000180100260
	[ExecuteInEditMode] // 0x00000001801001D0-0x0000000180100260
	// [RequireComponent] // 0x00000001801001D0-0x0000000180100260
	public class NoiseAndGrain : PostEffectsBase // TypeDefIndex: 5945
	{
		// Fields
		public float intensityMultiplier; // 0x20
		public float generalIntensity; // 0x24
		public float blackIntensity; // 0x28
		public float whiteIntensity; // 0x2C
		public float midGrey; // 0x30
		public bool dx11Grain; // 0x34
		public float softness; // 0x38
		public bool monochrome; // 0x3C
		public Vector3 intensities; // 0x40
		public Vector3 tiling; // 0x4C
		public float monochromeTiling; // 0x58
		public FilterMode filterMode; // 0x5C
		public Texture2D noiseTexture; // 0x60
		public Shader noiseShader; // 0x68
		private Material noiseMaterial; // 0x70
		public Shader dx11NoiseShader; // 0x78
		private Material dx11NoiseMaterial; // 0x80
		private static float TILE_AMOUNT; // 0x00
	
		// Constructors
		public NoiseAndGrain() {} // 0x0000000180A41110-0x0000000180A411E0
		static NoiseAndGrain() {} // 0x0000000180A410D0-0x0000000180A41110
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A40130-0x0000000180A40230
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A40640-0x0000000180A410D0
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) {} // 0x0000000180A40230-0x0000000180A40640
	}
}
