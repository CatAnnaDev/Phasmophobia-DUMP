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
	// [AddComponentMenu] // 0x0000000180101160-0x00000001801011F0
	[ExecuteInEditMode] // 0x0000000180101160-0x00000001801011F0
	// [RequireComponent] // 0x0000000180101160-0x00000001801011F0
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase // TypeDefIndex: 5952
	{
		// Fields
		// [Range] // 0x00000001800F77C0-0x00000001800F77E0
		public float intensity; // 0x20
		// [Range] // 0x00000001801013C0-0x00000001801013E0
		public float radius; // 0x24
		// [Range] // 0x00000001800F77C0-0x00000001800F77E0
		public int blurIterations; // 0x28
		// [Range] // 0x00000001801006C0-0x00000001801006E0
		public float blurFilterDistance; // 0x2C
		// [Range] // 0x00000001800D6560-0x00000001800D6580
		public int downsample; // 0x30
		public Texture2D rand; // 0x38
		public Shader aoShader; // 0x40
		private Material aoMaterial; // 0x48
	
		// Constructors
		public ScreenSpaceAmbientObscurance() {} // 0x0000000180A45640-0x0000000180A45670
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A44E10-0x0000000180A44E70
		private void OnDisable() {} // 0x0000000180A44E70-0x0000000180A44F20
		[ImageEffectOpaque] // 0x00000001800D4E50-0x00000001800D4E60
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A44F20-0x0000000180A45640
	}
}
