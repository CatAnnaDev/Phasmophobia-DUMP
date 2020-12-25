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
	// [AddComponentMenu] // 0x00000001800FF070-0x00000001800FF100
	[ExecuteInEditMode] // 0x00000001800FF070-0x00000001800FF100
	// [RequireComponent] // 0x00000001800FF070-0x00000001800FF100
	internal class GlobalFog : PostEffectsBase // TypeDefIndex: 5940
	{
		// Fields
		// [Tooltip] // 0x00000001800FF350-0x00000001800FF380
		public bool distanceFog; // 0x20
		// [Tooltip] // 0x00000001800FF440-0x00000001800FF470
		public bool excludeFarPixels; // 0x21
		// [Tooltip] // 0x00000001800FF4A0-0x00000001800FF4D0
		public bool useRadialDistance; // 0x22
		// [Tooltip] // 0x00000001800FF550-0x00000001800FF580
		public bool heightFog; // 0x23
		// [Tooltip] // 0x00000001800FF5C0-0x00000001800FF5F0
		public float height; // 0x24
		// [Range] // 0x00000001800FF6A0-0x00000001800FF6C0
		public float heightDensity; // 0x28
		// [Tooltip] // 0x00000001800FF740-0x00000001800FF770
		public float startDistance; // 0x2C
		public Shader fogShader; // 0x30
		private Material fogMaterial; // 0x38
	
		// Constructors
		public GlobalFog() {} // 0x0000000180A3F490-0x0000000180A3F4C0
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A3E5C0-0x0000000180A3E620
		[ImageEffectOpaque] // 0x00000001800D4E50-0x00000001800D4E60
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A3E770-0x0000000180A3F490
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) {} // 0x0000000180A3E620-0x0000000180A3E770
	}
}
