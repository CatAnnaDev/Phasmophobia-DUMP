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
	// [AddComponentMenu] // 0x00000001800FD0D0-0x00000001800FD160
	[ExecuteInEditMode] // 0x00000001800FD0D0-0x00000001800FD160
	// [RequireComponent] // 0x00000001800FD0D0-0x00000001800FD160
	public class CreaseShading : PostEffectsBase // TypeDefIndex: 5928
	{
		// Fields
		public float intensity; // 0x20
		public int softness; // 0x24
		public float spread; // 0x28
		public Shader blurShader; // 0x30
		private Material blurMaterial; // 0x38
		public Shader depthFetchShader; // 0x40
		private Material depthFetchMaterial; // 0x48
		public Shader creaseApplyShader; // 0x50
		private Material creaseApplyMaterial; // 0x58
	
		// Constructors
		public CreaseShading() {} // 0x0000000180A37D90-0x0000000180A37DC0
	
		// Methods
		public override bool CheckResources() => default; // 0x0000000180A378E0-0x0000000180A37990
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0000000180A37990-0x0000000180A37D90
	}
}
