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
	// [AddComponentMenu] // 0x00000001801003C0-0x0000000180100450
	[ExecuteInEditMode] // 0x00000001801003C0-0x0000000180100450
	// [RequireComponent] // 0x00000001801003C0-0x0000000180100450
	public class NoiseAndScratches : MonoBehaviour // TypeDefIndex: 5946
	{
		// Fields
		public bool monochrome; // 0x18
		private bool rgbFallback; // 0x19
		// [Range] // 0x00000001801006C0-0x00000001801006E0
		public float grainIntensityMin; // 0x1C
		// [Range] // 0x00000001801006C0-0x00000001801006E0
		public float grainIntensityMax; // 0x20
		// [Range] // 0x00000001801008C0-0x00000001801008E0
		public float grainSize; // 0x24
		// [Range] // 0x00000001801006C0-0x00000001801006E0
		public float scratchIntensityMin; // 0x28
		// [Range] // 0x00000001801006C0-0x00000001801006E0
		public float scratchIntensityMax; // 0x2C
		// [Range] // 0x0000000180100A50-0x0000000180100A70
		public float scratchFPS; // 0x30
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public float scratchJitter; // 0x34
		public Texture grainTexture; // 0x38
		public Texture scratchTexture; // 0x40
		public Shader shaderRGB; // 0x48
		public Shader shaderYUV; // 0x50
		private Material m_MaterialRGB; // 0x58
		private Material m_MaterialYUV; // 0x60
		private float scratchTimeLeft; // 0x68
		private float scratchX; // 0x6C
		private float scratchY; // 0x70
	
		// Properties
		protected Material material { get => default; } // 0x0000000180A41B90-0x0000000180A41D00 
	
		// Constructors
		public NoiseAndScratches() {} // 0x0000000180A41B50-0x0000000180A41B90
	
		// Methods
		protected void Start() {} // 0x0000000180A41A30-0x0000000180A41B50
		protected void OnDisable() {} // 0x0000000180A411E0-0x0000000180A412D0
		private void SanitizeParameters() {} // 0x0000000180A41900-0x0000000180A41A30
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A412D0-0x0000000180A41900
	}
}
