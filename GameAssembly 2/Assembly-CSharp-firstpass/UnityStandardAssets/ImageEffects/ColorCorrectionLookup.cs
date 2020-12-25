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
	// [AddComponentMenu] // 0x00000001800FC8F0-0x00000001800FC930
	[ExecuteInEditMode] // 0x00000001800FC8F0-0x00000001800FC930
	public class ColorCorrectionLookup : PostEffectsBase // TypeDefIndex: 5924
	{
		// Fields
		public Shader shader; // 0x20
		private Material material; // 0x28
		public Texture3D converted3DLut; // 0x30
		public string basedOnTempTex; // 0x38
	
		// Constructors
		public ColorCorrectionLookup() {} // 0x000000018061F6D0-0x000000018061F720
	
		// Methods
		public override bool CheckResources() => default; // 0x000000018061EBC0-0x000000018061EC30
		private void OnDisable() {} // 0x000000018061F0E0-0x000000018061F190
		private void OnDestroy() {} // 0x000000018061F030-0x000000018061F0E0
		public void SetIdentityLut() {} // 0x000000018061F390-0x000000018061F5F0
		public bool ValidDimensions(Texture2D tex2d) => default; // 0x000000018061F5F0-0x000000018061F6D0
		public void Convert(Texture2D temp2DTex, string path) {} // 0x000000018061EC30-0x000000018061F030
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x000000018061F190-0x000000018061F390
	}
}
