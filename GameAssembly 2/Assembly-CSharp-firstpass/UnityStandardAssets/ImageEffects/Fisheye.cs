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
	// [AddComponentMenu] // 0x00000001800FEDB0-0x00000001800FEE40
	[ExecuteInEditMode] // 0x00000001800FEDB0-0x00000001800FEE40
	// [RequireComponent] // 0x00000001800FEDB0-0x00000001800FEE40
	public class Fisheye : PostEffectsBase // TypeDefIndex: 5939
	{
		// Fields
		// [Range] // 0x00000001800FBE50-0x00000001800FBE70
		public float strengthX; // 0x20
		// [Range] // 0x00000001800FBE50-0x00000001800FBE70
		public float strengthY; // 0x24
		public Shader fishEyeShader; // 0x28
		private Material fisheyeMaterial; // 0x30
	
		// Constructors
		public Fisheye() {} // 0x0000000180A3E440-0x0000000180A3E460
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A3E1E0-0x0000000180A3E2A0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A3E2A0-0x0000000180A3E440
	}
}
