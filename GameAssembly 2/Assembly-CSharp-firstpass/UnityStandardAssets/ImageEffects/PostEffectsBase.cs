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
	[ExecuteInEditMode] // 0x0000000180100BB0-0x0000000180100C10
	// [RequireComponent] // 0x0000000180100BB0-0x0000000180100C10
	public class PostEffectsBase : MonoBehaviour // TypeDefIndex: 5947
	{
		// Fields
		protected bool supportHDRTextures; // 0x18
		protected bool supportDX11; // 0x19
		protected bool isSupported; // 0x1A
	
		// Constructors
		public PostEffectsBase() {} // 0x0000000180A434A0-0x0000000180A434B0
	
		// Methods
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) => default; // 0x0000000180A42530-0x0000000180A429A0
		protected Material CreateMaterial(Shader s, Material m2Create) => default; // 0x0000000180A42E60-0x0000000180A43050
		private void OnEnable() {} // 0x0000000180A43410-0x0000000180A43420
		protected bool CheckSupport() => default; // 0x0000000180A42C80-0x0000000180A42D10
		public virtual bool CheckResources() => default; // 0x0000000180A424A0-0x0000000180A42530
		protected void Start() {} // 0x0000000180277BB0-0x0000000180277BD0
		protected bool CheckSupport(bool needDepth) => default; // 0x0000000180A42D70-0x0000000180A42E60
		protected bool CheckSupport(bool needDepth, bool needHdr) => default; // 0x0000000180A42D10-0x0000000180A42D70
		public bool Dx11Support() => default; // 0x00000001804680A0-0x00000001804680B0
		protected void ReportAutoDisable() {} // 0x0000000180A43420-0x0000000180A434A0
		private bool CheckShader(Shader s) => default; // 0x0000000180A429A0-0x0000000180A42C80
		protected void NotSupported() {} // 0x0000000180A433F0-0x0000000180A43410
		protected void DrawBorder(RenderTexture dest, Material material) {} // 0x0000000180A43050-0x0000000180A433F0
	}
}
